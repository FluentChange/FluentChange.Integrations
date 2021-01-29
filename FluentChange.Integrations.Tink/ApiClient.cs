using RestSharp;
using System;
using System.Net;

namespace FluentChange.Integrations.Tink
{

    public class ApiClient
    {
        private static string apiEndpoint = "https://api.tink.com/";
        private string tinkClientId { get; set; }
        private string tinkClientSecret { get; set; }

        private RestClient client { get; set; }

        public ApiClient(string tinkClientId,string tinkClientSecret)
        {
            this.tinkClientId = tinkClientId;
            this.tinkClientSecret = tinkClientSecret;

            client = new RestClient(apiEndpoint);
        }

        public ApiClient(string clientId, string clientSecret, string tinkLink)
        {
            this.tinkClientId = clientId;
            this.tinkClientSecret = clientSecret;

            client = new RestClient(apiEndpoint);

            //LoadAccesToken();
        }

        public string GetTinkLink(Markets market, Locales locale, string redirectUri, bool isTest, string state)
        {
            var url = "https://link.tink.com/1.0/authorize/";
            url += "?client_id=" + tinkClientId;
            url += "&redirect_uri=" + WebUtility.UrlEncode(redirectUri);
            url += "&scope=accounts:read,transactions:read,user:read,credentials:read,identity:read,investments:read,statistics:read";
            url += "&state=" + WebUtility.UrlEncode(state);
            url += "&market=" + market.ToString();
            url += "&locale=" + locale.ToString();
            if (isTest)
            {
                url += "&test=true";
            }
            return url;

        }


        public MarketsResponse Markets(string accessToken)
        {
            var request = new RestRequest("api/v1/providers/markets", Method.GET);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            var response = client.Execute<MarketsResponse>(request);
            var data = response.Data;
            return data;

        }


        public ProvidersResponse Providers(string market)
        {
            //var client2 = new RestClient("https://api.tink.com/api/v1/providers/de");
            //client2.Timeout = -1;
            //var request = new RestRequest(Method.GET);
            //request.AddHeader("X-Tink-OAuth-Client-ID", "2e2e0cea84754035b4dfe540a624a21f");
            //request.AddParameter("text/plain", "", ParameterType.RequestBody);
            //IRestResponse response = client2.Execute(request);
            //Console.WriteLine(response.Content);


            var request2 = new RestRequest("api/v1/providers/" + market, Method.GET);
            //request.AddHeader("X-Tink-OAuth-Client-ID", tinkClientId);
            var response2 = client.Execute<ProvidersResponse>(request2);
            var data = response2.Data;
            return data;
        }

        public ProvidersResponse Providers(string accessToken, string market)
        {
            var request = new RestRequest("api/v1/providers/" + market, Method.GET);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddHeader("X-Tink-OAuth-Client-ID", tinkClientId);

            var response = client.Execute<ProvidersResponse>(request);
            var data = response.Data;
            return data;

        }

        public AccountsRequest Accounts(string accessToken)
        {
            var request = new RestRequest("api/v1/accounts/list", Method.GET);
            request.AddHeader("Authorization", "Bearer " + accessToken);

            var response = client.Execute<AccountsRequest>(request);
            var data = response.Data;
            return data;

        }

        public TransactionsSearchRequest Search(string accessToken)
        {
            var request = new RestRequest("api/v1/search", Method.GET);
            request.AddHeader("Authorization", "Bearer " + accessToken);

            var response = client.Execute<TransactionsSearchRequest>(request);
            var data = response.Data;
            return data;

        }







        public AccessTokenResponse GetAccessToken(string scope)
        {
            var client = new RestClient(apiEndpoint);
            var request = new RestRequest("api/v1/oauth/token", Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("client_id", tinkClientId);
            request.AddParameter("client_secret", tinkClientSecret);
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("scope", "authorization:grant," + scope);

            var response = client.Execute<AccessTokenResponse>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {
                if (response.ErrorException != null) throw response.ErrorException;
                throw new Exception(response.StatusDescription + " " + response.Content);
            }


        }

        public AccessTokenResponse GetAccessTokenTinkLinkCode(string code)
        {
            var client = new RestClient(apiEndpoint);
            var request = new RestRequest("api/v1/oauth/token", Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("client_id", tinkClientId);
            request.AddParameter("client_secret", tinkClientSecret);

            request.AddParameter("code", code);
            request.AddParameter("grant_type", "authorization_code");


            var response = client.Execute<AccessTokenResponse>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {
                if (response.ErrorException != null) throw response.ErrorException;
                throw new Exception(response.StatusDescription + " " + response.Content);
            }


        }

        public AccessTokenResponse RefreshAccessToken(string refreshToken)
        {
            var client = new RestClient(apiEndpoint);
            var request = new RestRequest("api/v1/oauth/token", Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("client_id", tinkClientId);
            request.AddParameter("client_secret", tinkClientSecret);

            request.AddParameter("refresh_token", refreshToken);
            request.AddParameter("grant_type", "refresh_token");


            var response = client.Execute<AccessTokenResponse>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {
                if (response.ErrorException != null) throw response.ErrorException;
                throw new Exception(response.StatusDescription + " " + response.Content);
            }


        }


    }
}
