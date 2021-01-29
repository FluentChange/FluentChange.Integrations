using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountsApi
    {
        /// <summary>
        /// Delete an account Delete a single bank account of the user that is authorized by the access_token, including its transactions and balance data. Must pass the account&#39;s identifier and the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;Notes: &lt;br/&gt;- You cannot delete an account while the bank connection that it relates to is currently in the process of import, update, or transactions categorization. &lt;br/&gt;- When the last remaining account of a bank connection gets deleted, then the bank connection itself will get deleted as well! &lt;br/&gt;- All notification rules that are connected to the account will get adjusted so that they no longer have this account listed. Notification rules that are connected to just this account (and no other accounts) will get deleted altogether.
        /// </summary>
        /// <param name="id">Identifier of the account to delete</param>
        /// <returns></returns>
        void DeleteAccount (long? id);
        /// <summary>
        /// Delete all accounts Delete all accounts of the user that is authorized by the access_token, including all transactions and balance data. Must pass the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;Notes: &lt;br/&gt;- Deleting all of the user&#39;s accounts also deletes all of his bank connections. &lt;br/&gt;- All notification rules that are connected to any specific accounts will get deleted as well. &lt;br/&gt;- If at least one of the user&#39;s bank connections in currently in the process of import, update, or transactions categorization, then this service will perform no action at all.
        /// </summary>
        /// <returns>IdentifierList</returns>
        IdentifierList DeleteAllAccounts ();
        /// <summary>
        /// Edit an account Change the name and/or the type and/or the &#39;isNew&#39; flag of a single bank account of the user that is authorized by the access_token. Must pass the account&#39;s identifier, the account&#39;s new name and/or type and/or &#39;isNew&#39; flag, and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of the account to edit</param>
        /// <param name="body">New account name and/or type and/or &#39;isNew&#39; flag</param>
        /// <returns>Account</returns>
        Account EditAccount (long? id, AccountParams body);
        /// <summary>
        /// Get an account Get a single bank account of the user that is authorized by the access_token. Must pass the account&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of requested account</param>
        /// <returns>Account</returns>
        Account GetAccount (long? id);
        /// <summary>
        /// Get and search all accounts Get bank accounts of the user that is authorized by the access_token. Must pass the user&#39;s access_token. You can set optional search criteria to get only those bank accounts that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="ids">A comma-separated list of account identifiers. If specified, then only accounts whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param>
        /// <param name="search">If specified, then only those accounts will be contained in the result whose &#39;accountName&#39;, &#39;iban&#39;, &#39;accountNumber&#39; or &#39;subAccountNumber&#39; contains the given search string (the matching works case-insensitive). If no accounts contain the search string in any of these fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for an account to get included into the result.</param>
        /// <param name="accountTypes">A comma-separated list of account types. If specified, then only accounts that relate to the given types will be regarded. If not specified, then all accounts will be regarded.</param>
        /// <param name="bankConnectionIds">A comma-separated list of bank connection identifiers. If specified, then only accounts that relate to the given bank connections will be regarded. If not specified, then all accounts will be regarded.</param>
        /// <param name="minLastSuccessfulUpdate">Lower bound for a account&#39;s last successful update date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only accounts whose &#39;lastSuccessfulUpdate&#39; is equal to or later than the given date will be regarded.</param>
        /// <param name="maxLastSuccessfulUpdate">Upper bound for a account&#39;s last successful update date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only accounts whose &#39;lastSuccessfulUpdate&#39; is equal to or earlier than the given date will be regarded.</param>
        /// <param name="minBalance">If specified, then only accounts whose balance is equal to or greater than the given balance will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95</param>
        /// <param name="maxBalance">If specified, then only accounts whose balance is equal to or less than the given balance will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95</param>
        /// <returns>AccountList</returns>
        AccountList GetAndSearchAllAccounts (List<long?> ids, string search, List<string> accountTypes, List<long?> bankConnectionIds, string minLastSuccessfulUpdate, string maxLastSuccessfulUpdate, decimal? minBalance, decimal? maxBalance);
        /// <summary>
        /// Get daily balances Returns the user&#39;s daily balances for a given period and a set of specified accounts (or all accounts, if none are specified). The daily balances are calculated by finAPI and are based on the current balances of the regarded accounts.
        /// </summary>
        /// <param name="accountIds">A comma-separated list of (non-security) account identifiers. If no accounts are specified, all (non-security) accounts of the user are regarded.</param>
        /// <param name="startDate">A string in the format &#39;YYYY-MM-DD&#39;. Note that the requested date range [startDate..endDate] may not exceed 1 year (366 days - considering Leap Years too).If startDate is not specified, it defaults to the endDate minus one month.</param>
        /// <param name="endDate">A string in the format &#39;YYYY-MM-DD&#39;. Note that the requested date range [startDate..endDate] may not exceed 1 year (366 days - considering Leap Years too). If endDate is not specified, it defaults to today&#39;s date.</param>
        /// <param name="withProjection">Whether finAPI should project the first and last actually existing balance of an account into the past and future. When passing &#39;true&#39;, then the result will always contain a daily balance for every day of the entire requested date range, even for days before the first actually existing balance, resp. after the last actually existing balance. Those days will have the same balance as the day of the first actual balance, resp. last actual balance, i.e. the first/last balance will be infinitely projected into the past/the future. When passing &#39;false&#39;, then the result will contain daily balances only from the day on where the first actual balance exists for any of the regarded accounts, and only up to the day where the last actual balance exists for any of the regarded accounts. Note that when in this case there are no actual balances within the requested date range, then an empty array will be returned. Default value for this parameter is &#39;true&#39;.</param>
        /// <param name="page">Result page that you want to retrieve.</param>
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param>
        /// <param name="order">Determines the order of the results. You can order the results by &#39;date&#39;, &#39;balance&#39;, &#39;income&#39; or &#39;spending&#39;. The default order for this service is &#39;date,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/accounts/dailyBalances?order&#x3D;date,desc&amp;order&#x3D;balance,asc&#39; will return daily balances ordered by &#39;date&#39; (descending), where items with the same &#39;date&#39; are ordered by &#39;balance&#39; (ascending). The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC). </param>
        /// <returns>DailyBalanceList</returns>
        DailyBalanceList GetDailyBalances (List<long?> accountIds, string startDate, string endDate, bool? withProjection, int? page, int? perPage, List<string> order);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountsApi : IAccountsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Delete an account Delete a single bank account of the user that is authorized by the access_token, including its transactions and balance data. Must pass the account&#39;s identifier and the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;Notes: &lt;br/&gt;- You cannot delete an account while the bank connection that it relates to is currently in the process of import, update, or transactions categorization. &lt;br/&gt;- When the last remaining account of a bank connection gets deleted, then the bank connection itself will get deleted as well! &lt;br/&gt;- All notification rules that are connected to the account will get adjusted so that they no longer have this account listed. Notification rules that are connected to just this account (and no other accounts) will get deleted altogether.
        /// </summary>
        /// <param name="id">Identifier of the account to delete</param> 
        /// <returns></returns>            
        public void DeleteAccount (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAccount");
            
    
            var path = "/api/v1/accounts/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete all accounts Delete all accounts of the user that is authorized by the access_token, including all transactions and balance data. Must pass the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;Notes: &lt;br/&gt;- Deleting all of the user&#39;s accounts also deletes all of his bank connections. &lt;br/&gt;- All notification rules that are connected to any specific accounts will get deleted as well. &lt;br/&gt;- If at least one of the user&#39;s bank connections in currently in the process of import, update, or transactions categorization, then this service will perform no action at all.
        /// </summary>
        /// <returns>IdentifierList</returns>            
        public IdentifierList DeleteAllAccounts ()
        {
            
    
            var path = "/api/v1/accounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAllAccounts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAllAccounts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentifierList) ApiClient.Deserialize(response.Content, typeof(IdentifierList), response.Headers);
        }
    
        /// <summary>
        /// Edit an account Change the name and/or the type and/or the &#39;isNew&#39; flag of a single bank account of the user that is authorized by the access_token. Must pass the account&#39;s identifier, the account&#39;s new name and/or type and/or &#39;isNew&#39; flag, and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of the account to edit</param> 
        /// <param name="body">New account name and/or type and/or &#39;isNew&#39; flag</param> 
        /// <returns>Account</returns>            
        public Account EditAccount (long? id, AccountParams body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditAccount");
            
    
            var path = "/api/v1/accounts/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Account) ApiClient.Deserialize(response.Content, typeof(Account), response.Headers);
        }
    
        /// <summary>
        /// Get an account Get a single bank account of the user that is authorized by the access_token. Must pass the account&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of requested account</param> 
        /// <returns>Account</returns>            
        public Account GetAccount (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetAccount");
            
    
            var path = "/api/v1/accounts/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Account) ApiClient.Deserialize(response.Content, typeof(Account), response.Headers);
        }
    
        /// <summary>
        /// Get and search all accounts Get bank accounts of the user that is authorized by the access_token. Must pass the user&#39;s access_token. You can set optional search criteria to get only those bank accounts that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="ids">A comma-separated list of account identifiers. If specified, then only accounts whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param> 
        /// <param name="search">If specified, then only those accounts will be contained in the result whose &#39;accountName&#39;, &#39;iban&#39;, &#39;accountNumber&#39; or &#39;subAccountNumber&#39; contains the given search string (the matching works case-insensitive). If no accounts contain the search string in any of these fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for an account to get included into the result.</param> 
        /// <param name="accountTypes">A comma-separated list of account types. If specified, then only accounts that relate to the given types will be regarded. If not specified, then all accounts will be regarded.</param> 
        /// <param name="bankConnectionIds">A comma-separated list of bank connection identifiers. If specified, then only accounts that relate to the given bank connections will be regarded. If not specified, then all accounts will be regarded.</param> 
        /// <param name="minLastSuccessfulUpdate">Lower bound for a account&#39;s last successful update date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only accounts whose &#39;lastSuccessfulUpdate&#39; is equal to or later than the given date will be regarded.</param> 
        /// <param name="maxLastSuccessfulUpdate">Upper bound for a account&#39;s last successful update date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only accounts whose &#39;lastSuccessfulUpdate&#39; is equal to or earlier than the given date will be regarded.</param> 
        /// <param name="minBalance">If specified, then only accounts whose balance is equal to or greater than the given balance will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95</param> 
        /// <param name="maxBalance">If specified, then only accounts whose balance is equal to or less than the given balance will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95</param> 
        /// <returns>AccountList</returns>            
        public AccountList GetAndSearchAllAccounts (List<long?> ids, string search, List<string> accountTypes, List<long?> bankConnectionIds, string minLastSuccessfulUpdate, string maxLastSuccessfulUpdate, decimal? minBalance, decimal? maxBalance)
        {
            
    
            var path = "/api/v1/accounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
 if (accountTypes != null) queryParams.Add("accountTypes", ApiClient.ParameterToString(accountTypes)); // query parameter
 if (bankConnectionIds != null) queryParams.Add("bankConnectionIds", ApiClient.ParameterToString(bankConnectionIds)); // query parameter
 if (minLastSuccessfulUpdate != null) queryParams.Add("minLastSuccessfulUpdate", ApiClient.ParameterToString(minLastSuccessfulUpdate)); // query parameter
 if (maxLastSuccessfulUpdate != null) queryParams.Add("maxLastSuccessfulUpdate", ApiClient.ParameterToString(maxLastSuccessfulUpdate)); // query parameter
 if (minBalance != null) queryParams.Add("minBalance", ApiClient.ParameterToString(minBalance)); // query parameter
 if (maxBalance != null) queryParams.Add("maxBalance", ApiClient.ParameterToString(maxBalance)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchAllAccounts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchAllAccounts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountList) ApiClient.Deserialize(response.Content, typeof(AccountList), response.Headers);
        }
    
        /// <summary>
        /// Get daily balances Returns the user&#39;s daily balances for a given period and a set of specified accounts (or all accounts, if none are specified). The daily balances are calculated by finAPI and are based on the current balances of the regarded accounts.
        /// </summary>
        /// <param name="accountIds">A comma-separated list of (non-security) account identifiers. If no accounts are specified, all (non-security) accounts of the user are regarded.</param> 
        /// <param name="startDate">A string in the format &#39;YYYY-MM-DD&#39;. Note that the requested date range [startDate..endDate] may not exceed 1 year (366 days - considering Leap Years too).If startDate is not specified, it defaults to the endDate minus one month.</param> 
        /// <param name="endDate">A string in the format &#39;YYYY-MM-DD&#39;. Note that the requested date range [startDate..endDate] may not exceed 1 year (366 days - considering Leap Years too). If endDate is not specified, it defaults to today&#39;s date.</param> 
        /// <param name="withProjection">Whether finAPI should project the first and last actually existing balance of an account into the past and future. When passing &#39;true&#39;, then the result will always contain a daily balance for every day of the entire requested date range, even for days before the first actually existing balance, resp. after the last actually existing balance. Those days will have the same balance as the day of the first actual balance, resp. last actual balance, i.e. the first/last balance will be infinitely projected into the past/the future. When passing &#39;false&#39;, then the result will contain daily balances only from the day on where the first actual balance exists for any of the regarded accounts, and only up to the day where the last actual balance exists for any of the regarded accounts. Note that when in this case there are no actual balances within the requested date range, then an empty array will be returned. Default value for this parameter is &#39;true&#39;.</param> 
        /// <param name="page">Result page that you want to retrieve.</param> 
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param> 
        /// <param name="order">Determines the order of the results. You can order the results by &#39;date&#39;, &#39;balance&#39;, &#39;income&#39; or &#39;spending&#39;. The default order for this service is &#39;date,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/accounts/dailyBalances?order&#x3D;date,desc&amp;order&#x3D;balance,asc&#39; will return daily balances ordered by &#39;date&#39; (descending), where items with the same &#39;date&#39; are ordered by &#39;balance&#39; (ascending). The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC). </param> 
        /// <returns>DailyBalanceList</returns>            
        public DailyBalanceList GetDailyBalances (List<long?> accountIds, string startDate, string endDate, bool? withProjection, int? page, int? perPage, List<string> order)
        {
            
    
            var path = "/api/v1/accounts/dailyBalances";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountIds != null) queryParams.Add("accountIds", ApiClient.ParameterToString(accountIds)); // query parameter
 if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (withProjection != null) queryParams.Add("withProjection", ApiClient.ParameterToString(withProjection)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("perPage", ApiClient.ParameterToString(perPage)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDailyBalances: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDailyBalances: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DailyBalanceList) ApiClient.Deserialize(response.Content, typeof(DailyBalanceList), response.Headers);
        }
    
    }
}
