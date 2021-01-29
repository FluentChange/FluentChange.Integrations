using FluentChange.Integrations.FinApi.Models;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace FluentChange.Integrations.FinApi
{
    public class Client
    {
        private readonly string BasePath = "https://sandbox.finapi.io/";

        private readonly string DefaultClientId;
        private readonly string DefaultClientSecret;

        private RestClient restClient;
        public Client(string DefaultClientId, string DefaultClientSecret)
        {
            this.DefaultClientId = DefaultClientId;
            this.DefaultClientSecret = DefaultClientSecret;
            restClient = new RestClient(BasePath);
        }
        public PageableBankList SearchBanks(string bankName)
        {
            var token = GetClientToken();

            var bankApi = new BanksApi(BasePath);
            bankApi.ApiClient.AddDefaultHeader("Authorization", "Bearer " + token);
            return bankApi.GetAndSearchAllBanks(null, bankName, null, null, null, null, null, null, null);
        }

        public User CreateUser(string userId)
        {
            var token = GetClientToken();

            var user = new UserCreateParams();
            user.Id = userId;

            var userApi = new UsersApi(BasePath);
            userApi.ApiClient.AddDefaultHeader("Authorization", "Bearer " + token);
            var result = userApi.CreateUser(user);
            return result;
        }



        public ConnetionWebFormResult ImportBankConnection(long bankid, string userId, string userPassword, string redirectUrl)
        {
            var token = GetUserAccessToken(userId, userPassword);

            var body = new ImportBankConnectionParams();
            body.BankId = bankid;

            var body2 = new { bankId = bankid };

            //var userApi = new BankConnectionsApi(BasePath);
            //userApi.ApiClient.AddDefaultHeader("Authorization", "Bearer " + response._AccessToken);
            var request = new RestRequest("/api/v1/bankConnections/import", Method.POST);
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddJsonBody(body2);
            var responseX = restClient.Execute<BankConnection>(request);
            if (responseX.StatusCode == System.Net.HttpStatusCode.UnavailableForLegalReasons)
            {
                var errorMessage = JsonConvert.DeserializeObject<ErrorMessage>(responseX.Content);
                var result = new ConnetionWebFormResult();

                result.WebFormId = int.Parse(errorMessage.Errors.First().Message);
                var webformurl = responseX.Headers.SingleOrDefault(h => h.Name == "Location").Value.ToString();

                if (redirectUrl.Contains("{connectid}")) redirectUrl = redirectUrl.Replace("{connectid}", result.WebFormId.ToString());

                // see docs here https://finapi.zendesk.com/hc/en-us/articles/360002596391
                webformurl = webformurl + "?redirectUrl=" + WebUtility.UrlEncode(redirectUrl);
                result.WebFormUrl = webformurl;



                return result;
            }

            throw new Exception("this case should currently not happen, as evry connection should end up in webform flow");


        }

        public WebForm ConnectStatus(long webformid, string userId, string userPassword)
        {
            var token = GetUserAccessToken(userId, userPassword);

            var api = new WebFormsApi(BasePath);
            api.ApiClient.AddDefaultHeader("Authorization", "Bearer " + token);
            var result = api.GetWebForm(webformid);
            return result;
        }

        public BankConnectionList AllConnections(string userId, string userPassword)
        {
            var token = GetUserAccessToken(userId, userPassword);

            var api = new BankConnectionsApi(BasePath);
            api.ApiClient.AddDefaultHeader("Authorization", "Bearer " + token);
            var result = api.GetAllBankConnections(null);
            return result;
        }

        public AccountList AllAccounts(string userId, string userPassword)
        {
            var token = GetUserAccessToken(userId, userPassword);

            var api = new AccountsApi(BasePath);
            api.ApiClient.AddDefaultHeader("Authorization", "Bearer " + token);
            var result = api.GetAndSearchAllAccounts(null, null, null, null, null, null, null, null);
            return result;
        }

        public PageableTransactionList NewTransactions(string userId, string userPassword, long accountid, int page)
        {
            var token = GetUserAccessToken(userId, userPassword);

            var api = new TransactionsApi(BasePath);
            api.ApiClient.AddDefaultHeader("Authorization", "Bearer " + token);
            var ids = new List<long?>();
            ids.Add(accountid);
            var isNew = true;
            //var page = 1;
            var amount = 100;
            //var result = api.GetAndSearchAllTransactions("bankView", ids, null, null, null, null, null, null, null, null, null, null, null, null, null, null, isNew, null, null, null, null, page, amount, null);

            var request = new RestRequest("/api/v1/transactions", Method.GET);
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddParameter("page", page);
            request.AddParameter("perPage", amount);
            request.AddParameter("isNew", isNew);
            request.AddParameter("accountIds", accountid);
            request.AddParameter("view", "bankView");
            var response = restClient.Execute<PageableTransactionList>(request);
            var result = response.Data;

            return result;
        }


        public AccountList Accounts(long connectionid, string userId, string userPassword)
        {
            var token = GetUserAccessToken(userId, userPassword);

            var api = new AccountsApi(BasePath);
            api.ApiClient.AddDefaultHeader("Authorization", "Bearer " + token);
            var ids = new List<long?>();
            ids.Add(connectionid);
            var result = api.GetAndSearchAllAccounts(null, null, null, ids, null, null, null, null);
            return result;
        }



        private string GetClientToken()
        {
            var authApi = new AuthorizationApi(BasePath);
            var response = authApi.GetToken("client_credentials", DefaultClientId, DefaultClientSecret, null, null, null);
            return response._AccessToken;
        }
        private string GetUserAccessToken(string userId, string userPassword)
        {
            var authApi = new AuthorizationApi(BasePath);
            var responseAuth = authApi.GetToken("password", DefaultClientId, DefaultClientSecret, null, userId, userPassword);
            return responseAuth._AccessToken;
        }

    }
}
