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
    public interface IMandatorAdministrationApi
    {
        /// <summary>
        /// Change client credentials Change the client_secret for any of your clients, including the mandator admin client. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token. &lt;br/&gt;&lt;br/&gt;NOTES:&lt;br/&gt;&amp;bull; When you change a client&#39;s secret, then all of its existing access tokens will be revoked. User access tokens are not affected.&lt;br/&gt;&amp;bull; finAPI is storing client secrets with a one-way encryption. A lost client secret can NOT be recovered.
        /// </summary>
        /// <param name="body">Parameters for changing client credentials</param>
        /// <returns></returns>
        void ChangeClientCredentials (ChangeClientCredentialsParams body);
        /// <summary>
        /// Create IBAN rules This service can be used to define IBAN rules for finAPI&#39;s transaction categorization system. The transaction categorization is run automatically whenever new transactions are imported, as well as when you call the services &#39;Check categorization&#39; or &#39;Trigger categorization&#39;. &lt;br/&gt;&lt;br/&gt;An IBAN rule maps an IBAN to a certain category. finAPI&#39;s categorization system will pick the category as a candidate for any transaction whose counterpart&#39;s account matches the IBAN. It is not guaranteed though that this candidate will actually be applied, as there could be other categorization rules that have higher priority or that are an even better match for the transaction.&lt;br/&gt;&lt;br/&gt;Note that the rules that you define here will be applied to all of your users. They have higher priority than finAPI&#39;s default categorization rules, but lower priority than user-specific rules (User-specific rules are created implicitly whenever a category is manually assigned to a transaction via the PATCH /transactions services). IBAN rules have a higher priority than keyword rules (see the &#39;Create keyword rules&#39; service).
        /// </summary>
        /// <param name="body">IBAN rule definitions</param>
        /// <returns>IbanRuleList</returns>
        IbanRuleList CreateIbanRules (IbanRulesParams body);
        /// <summary>
        /// Create keyword rules This service can be used to define keyword rules for finAPI&#39;s transaction categorization system. The transaction categorization is run automatically whenever new transactions are imported, as well as when you call the services &#39;Check categorization&#39; or &#39;Trigger categorization&#39;. &lt;br/&gt;&lt;br/&gt;A keyword rule maps a set of keywords to a certain category. finAPI&#39;s categorization system will pick the category as a candidate for any transaction that contains at least one of the defined keywords in its purpose or counterpart information. It is not guaranteed though that this candidate will actually be applied, as there could be other categorization rules that have higher priority or that are an even better match for the transaction. If there are multiple keyword rules that match a transaction, finAPI will pick the one with the highest count of matched keywords.&lt;br/&gt;&lt;br/&gt;Note that the rules that you define here will be applied to all of your users. They have higher priority than finAPI&#39;s default categorization rules, but lower priority than user-specific rules (User-specific rules are created implicitly whenever a category is manually assigned to a transaction via the PATCH /transactions services). Keyword rules have a lower priority than IBAN rules (see the &#39;Create IBAN rules&#39; service).
        /// </summary>
        /// <param name="body">Keyword rule definitions</param>
        /// <returns>KeywordRuleList</returns>
        KeywordRuleList CreateKeywordRules (KeywordRulesParams body);
        /// <summary>
        /// Delete IBAN rules Delete one or multiple IBAN rules that you have previously created via the &#39;Create IBAN rules&#39; service.
        /// </summary>
        /// <param name="body">List of IBAN rules identifiers.The maximum number of identifiers is 100.</param>
        /// <returns>IdentifierList</returns>
        IdentifierList DeleteIbanRules (IbanRuleIdentifiersParams body);
        /// <summary>
        /// Delete keyword rules Delete one or multiple keyword rules that you have previously created via the &#39;Create keyword rules&#39; service.
        /// </summary>
        /// <param name="body">List of keyword rule identifiers.The maximum number of identifiers is 100.</param>
        /// <returns>IdentifierList</returns>
        IdentifierList DeleteKeywordRules (KeywordRuleIdentifiersParams body);
        /// <summary>
        /// Delete users Delete one or several users, which are specified by a given list of identifiers. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token. &lt;br/&gt;&lt;br/&gt;&lt;b&gt;NOTE&lt;/b&gt;: finAPI may fail to delete one (or several, or all) of the specified users. A user cannot get deleted when his data is currently locked by an internal process (for instance, update of a bank connection or transactions categorization). The response contains the identifiers of all users that could not get deleted, and all users that could get deleted, separated in two lists. The mandator admin client can retry the request at a later time for the users who could not get deleted.&lt;br/&gt; Note that non-existing user identifiers will be ignored entirely, meaning that those identifiers will not appear in the response at all.
        /// </summary>
        /// <param name="body">List of user identifiers</param>
        /// <returns>UserIdentifiersList</returns>
        UserIdentifiersList DeleteUsers (UserIdentifiersParams body);
        /// <summary>
        /// Get IBAN rules Returns all IBAN-based categorization rules that you have defined for your users via the &#39;Create IBAN rules&#39; service.
        /// </summary>
        /// <param name="page">Result page that you want to retrieve</param>
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param>
        /// <returns>PageableIbanRuleList</returns>
        PageableIbanRuleList GetIbanRuleList (int? page, int? perPage);
        /// <summary>
        /// Get keyword rules Returns all keyword-based categorization rules that you have defined for your users via the &#39;Create keyword rules&#39; service.
        /// </summary>
        /// <param name="page">Result page that you want to retrieve</param>
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param>
        /// <returns>PageableKeywordRuleList</returns>
        PageableKeywordRuleList GetKeywordRuleList (int? page, int? perPage);
        /// <summary>
        /// Get user list &lt;p&gt;Get a list of the users of the mandator that is authorized by the access_token. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token. You can set optional search criteria to get only those users that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.&lt;/p&gt;&lt;p&gt;Note that the original user id is no longer available in finAPI once a user has been deleted. Because of this, the userId of deleted users will be a distorted version of the original userId. For example, if the deleted user&#39;s id was originally &#39;user&#39;, then this service will return &#39;uXXr&#39; as the userId.&lt;/p&gt;
        /// </summary>
        /// <param name="minRegistrationDate">Lower bound for a user&#39;s registration date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;registrationDate&#39; is equal to or later than the given date will be regarded.</param>
        /// <param name="maxRegistrationDate">Upper bound for a user&#39;s registration date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;registrationDate&#39; is equal to or earlier than the given date will be regarded.</param>
        /// <param name="minDeletionDate">Lower bound for a user&#39;s deletion date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;deletionDate&#39; is not null, and is equal to or later than the given date will be regarded.</param>
        /// <param name="maxDeletionDate">Upper bound for a user&#39;s deletion date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;deletionDate&#39; is null, or is equal to or earlier than the given date will be regarded.</param>
        /// <param name="minLastActiveDate">Lower bound for a user&#39;s last active date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;lastActiveDate&#39; is not null, and is equal to or later than the given date will be regarded.</param>
        /// <param name="maxLastActiveDate">Upper bound for a user&#39;s last active date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;lastActiveDate&#39; is null, or is equal to or earlier than the given date will be regarded.</param>
        /// <param name="includeMonthlyStats">Whether to include the &#39;monthlyStats&#39; for the returned users. If not specified, then the field defaults to &#39;false&#39;.</param>
        /// <param name="monthlyStatsStartDate">Minimum bound for the monthly stats (&#x3D;oldest month that should be included). Must be passed in the format &#39;YYYY-MM&#39;. If not specified, then the monthly stats will go back up to the first month in which the user existed (date of the user&#39;s registration). Note that this field is only regarded if &#39;includeMonthlyStats&#39; &#x3D; true.</param>
        /// <param name="monthlyStatsEndDate">Maximum bound for the monthly stats (&#x3D;latest month that should be included). Must be passed in the format &#39;YYYY-MM&#39;. If not specified, then the monthly stats will go up to either the current month (for active users), or up to the month of deletion (for deleted users). Note that this field is only regarded if  &#39;includeMonthlyStats&#39; &#x3D; true.</param>
        /// <param name="minBankConnectionCountInMonthlyStats">A value of X means that the service will return only those users which had at least X bank connections imported at any time within the returned monthly stats set. This field is only regarded when &#39;includeMonthlyStats&#39; is set to &#39;true&#39;. The default value for this field is 0.</param>
        /// <param name="userId">The identifier of a user to search for. If specified, then only the user with the given id will be regarded. If no user can be found for the passed userId (because the user was deleted or his username was misspelled), then the result list will be empty.</param>
        /// <param name="isDeleted">If NOT specified, then the service will regard both active and deleted users in the search. If set to &#39;true&#39;, then ONLY deleted users will be regarded. If set to &#39;false&#39;, then ONLY active users will be regarded.</param>
        /// <param name="isLocked">If NOT specified, then the service will regard both locked and not locked users in the search. If set to &#39;true&#39;, then ONLY locked users will be regarded. If set to &#39;false&#39;, then ONLY not locked users will be regarded.</param>
        /// <param name="page">Result page that you want to retrieve</param>
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param>
        /// <param name="order">Determines the order of the results. You can order the results by &#39;userId&#39;. The default order for this service is &#39;userId,asc&#39;. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. </param>
        /// <returns>PageableUserInfoList</returns>
        PageableUserInfoList GetUserList (string minRegistrationDate, string maxRegistrationDate, string minDeletionDate, string maxDeletionDate, string minLastActiveDate, string maxLastActiveDate, bool? includeMonthlyStats, string monthlyStatsStartDate, string monthlyStatsEndDate, int? minBankConnectionCountInMonthlyStats, string userId, bool? isDeleted, bool? isLocked, int? page, int? perPage, List<string> order);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MandatorAdministrationApi : IMandatorAdministrationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MandatorAdministrationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MandatorAdministrationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MandatorAdministrationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MandatorAdministrationApi(String basePath)
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
        /// Change client credentials Change the client_secret for any of your clients, including the mandator admin client. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token. &lt;br/&gt;&lt;br/&gt;NOTES:&lt;br/&gt;&amp;bull; When you change a client&#39;s secret, then all of its existing access tokens will be revoked. User access tokens are not affected.&lt;br/&gt;&amp;bull; finAPI is storing client secrets with a one-way encryption. A lost client secret can NOT be recovered.
        /// </summary>
        /// <param name="body">Parameters for changing client credentials</param> 
        /// <returns></returns>            
        public void ChangeClientCredentials (ChangeClientCredentialsParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ChangeClientCredentials");
            
    
            var path = "/api/v1/mandatorAdmin/changeClientCredentials";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ChangeClientCredentials: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChangeClientCredentials: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create IBAN rules This service can be used to define IBAN rules for finAPI&#39;s transaction categorization system. The transaction categorization is run automatically whenever new transactions are imported, as well as when you call the services &#39;Check categorization&#39; or &#39;Trigger categorization&#39;. &lt;br/&gt;&lt;br/&gt;An IBAN rule maps an IBAN to a certain category. finAPI&#39;s categorization system will pick the category as a candidate for any transaction whose counterpart&#39;s account matches the IBAN. It is not guaranteed though that this candidate will actually be applied, as there could be other categorization rules that have higher priority or that are an even better match for the transaction.&lt;br/&gt;&lt;br/&gt;Note that the rules that you define here will be applied to all of your users. They have higher priority than finAPI&#39;s default categorization rules, but lower priority than user-specific rules (User-specific rules are created implicitly whenever a category is manually assigned to a transaction via the PATCH /transactions services). IBAN rules have a higher priority than keyword rules (see the &#39;Create keyword rules&#39; service).
        /// </summary>
        /// <param name="body">IBAN rule definitions</param> 
        /// <returns>IbanRuleList</returns>            
        public IbanRuleList CreateIbanRules (IbanRulesParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateIbanRules");
            
    
            var path = "/api/v1/mandatorAdmin/ibanRules";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateIbanRules: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateIbanRules: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IbanRuleList) ApiClient.Deserialize(response.Content, typeof(IbanRuleList), response.Headers);
        }
    
        /// <summary>
        /// Create keyword rules This service can be used to define keyword rules for finAPI&#39;s transaction categorization system. The transaction categorization is run automatically whenever new transactions are imported, as well as when you call the services &#39;Check categorization&#39; or &#39;Trigger categorization&#39;. &lt;br/&gt;&lt;br/&gt;A keyword rule maps a set of keywords to a certain category. finAPI&#39;s categorization system will pick the category as a candidate for any transaction that contains at least one of the defined keywords in its purpose or counterpart information. It is not guaranteed though that this candidate will actually be applied, as there could be other categorization rules that have higher priority or that are an even better match for the transaction. If there are multiple keyword rules that match a transaction, finAPI will pick the one with the highest count of matched keywords.&lt;br/&gt;&lt;br/&gt;Note that the rules that you define here will be applied to all of your users. They have higher priority than finAPI&#39;s default categorization rules, but lower priority than user-specific rules (User-specific rules are created implicitly whenever a category is manually assigned to a transaction via the PATCH /transactions services). Keyword rules have a lower priority than IBAN rules (see the &#39;Create IBAN rules&#39; service).
        /// </summary>
        /// <param name="body">Keyword rule definitions</param> 
        /// <returns>KeywordRuleList</returns>            
        public KeywordRuleList CreateKeywordRules (KeywordRulesParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateKeywordRules");
            
    
            var path = "/api/v1/mandatorAdmin/keywordRules";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateKeywordRules: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateKeywordRules: " + response.ErrorMessage, response.ErrorMessage);
    
            return (KeywordRuleList) ApiClient.Deserialize(response.Content, typeof(KeywordRuleList), response.Headers);
        }
    
        /// <summary>
        /// Delete IBAN rules Delete one or multiple IBAN rules that you have previously created via the &#39;Create IBAN rules&#39; service.
        /// </summary>
        /// <param name="body">List of IBAN rules identifiers.The maximum number of identifiers is 100.</param> 
        /// <returns>IdentifierList</returns>            
        public IdentifierList DeleteIbanRules (IbanRuleIdentifiersParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteIbanRules");
            
    
            var path = "/api/v1/mandatorAdmin/ibanRules/delete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteIbanRules: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteIbanRules: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentifierList) ApiClient.Deserialize(response.Content, typeof(IdentifierList), response.Headers);
        }
    
        /// <summary>
        /// Delete keyword rules Delete one or multiple keyword rules that you have previously created via the &#39;Create keyword rules&#39; service.
        /// </summary>
        /// <param name="body">List of keyword rule identifiers.The maximum number of identifiers is 100.</param> 
        /// <returns>IdentifierList</returns>            
        public IdentifierList DeleteKeywordRules (KeywordRuleIdentifiersParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteKeywordRules");
            
    
            var path = "/api/v1/mandatorAdmin/keywordRules/delete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteKeywordRules: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteKeywordRules: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentifierList) ApiClient.Deserialize(response.Content, typeof(IdentifierList), response.Headers);
        }
    
        /// <summary>
        /// Delete users Delete one or several users, which are specified by a given list of identifiers. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token. &lt;br/&gt;&lt;br/&gt;&lt;b&gt;NOTE&lt;/b&gt;: finAPI may fail to delete one (or several, or all) of the specified users. A user cannot get deleted when his data is currently locked by an internal process (for instance, update of a bank connection or transactions categorization). The response contains the identifiers of all users that could not get deleted, and all users that could get deleted, separated in two lists. The mandator admin client can retry the request at a later time for the users who could not get deleted.&lt;br/&gt; Note that non-existing user identifiers will be ignored entirely, meaning that those identifiers will not appear in the response at all.
        /// </summary>
        /// <param name="body">List of user identifiers</param> 
        /// <returns>UserIdentifiersList</returns>            
        public UserIdentifiersList DeleteUsers (UserIdentifiersParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteUsers");
            
    
            var path = "/api/v1/mandatorAdmin/deleteUsers";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserIdentifiersList) ApiClient.Deserialize(response.Content, typeof(UserIdentifiersList), response.Headers);
        }
    
        /// <summary>
        /// Get IBAN rules Returns all IBAN-based categorization rules that you have defined for your users via the &#39;Create IBAN rules&#39; service.
        /// </summary>
        /// <param name="page">Result page that you want to retrieve</param> 
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param> 
        /// <returns>PageableIbanRuleList</returns>            
        public PageableIbanRuleList GetIbanRuleList (int? page, int? perPage)
        {
            
    
            var path = "/api/v1/mandatorAdmin/ibanRules";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("perPage", ApiClient.ParameterToString(perPage)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetIbanRuleList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetIbanRuleList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageableIbanRuleList) ApiClient.Deserialize(response.Content, typeof(PageableIbanRuleList), response.Headers);
        }
    
        /// <summary>
        /// Get keyword rules Returns all keyword-based categorization rules that you have defined for your users via the &#39;Create keyword rules&#39; service.
        /// </summary>
        /// <param name="page">Result page that you want to retrieve</param> 
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param> 
        /// <returns>PageableKeywordRuleList</returns>            
        public PageableKeywordRuleList GetKeywordRuleList (int? page, int? perPage)
        {
            
    
            var path = "/api/v1/mandatorAdmin/keywordRules";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("perPage", ApiClient.ParameterToString(perPage)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKeywordRuleList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKeywordRuleList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageableKeywordRuleList) ApiClient.Deserialize(response.Content, typeof(PageableKeywordRuleList), response.Headers);
        }
    
        /// <summary>
        /// Get user list &lt;p&gt;Get a list of the users of the mandator that is authorized by the access_token. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token. You can set optional search criteria to get only those users that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.&lt;/p&gt;&lt;p&gt;Note that the original user id is no longer available in finAPI once a user has been deleted. Because of this, the userId of deleted users will be a distorted version of the original userId. For example, if the deleted user&#39;s id was originally &#39;user&#39;, then this service will return &#39;uXXr&#39; as the userId.&lt;/p&gt;
        /// </summary>
        /// <param name="minRegistrationDate">Lower bound for a user&#39;s registration date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;registrationDate&#39; is equal to or later than the given date will be regarded.</param> 
        /// <param name="maxRegistrationDate">Upper bound for a user&#39;s registration date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;registrationDate&#39; is equal to or earlier than the given date will be regarded.</param> 
        /// <param name="minDeletionDate">Lower bound for a user&#39;s deletion date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;deletionDate&#39; is not null, and is equal to or later than the given date will be regarded.</param> 
        /// <param name="maxDeletionDate">Upper bound for a user&#39;s deletion date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;deletionDate&#39; is null, or is equal to or earlier than the given date will be regarded.</param> 
        /// <param name="minLastActiveDate">Lower bound for a user&#39;s last active date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;lastActiveDate&#39; is not null, and is equal to or later than the given date will be regarded.</param> 
        /// <param name="maxLastActiveDate">Upper bound for a user&#39;s last active date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;lastActiveDate&#39; is null, or is equal to or earlier than the given date will be regarded.</param> 
        /// <param name="includeMonthlyStats">Whether to include the &#39;monthlyStats&#39; for the returned users. If not specified, then the field defaults to &#39;false&#39;.</param> 
        /// <param name="monthlyStatsStartDate">Minimum bound for the monthly stats (&#x3D;oldest month that should be included). Must be passed in the format &#39;YYYY-MM&#39;. If not specified, then the monthly stats will go back up to the first month in which the user existed (date of the user&#39;s registration). Note that this field is only regarded if &#39;includeMonthlyStats&#39; &#x3D; true.</param> 
        /// <param name="monthlyStatsEndDate">Maximum bound for the monthly stats (&#x3D;latest month that should be included). Must be passed in the format &#39;YYYY-MM&#39;. If not specified, then the monthly stats will go up to either the current month (for active users), or up to the month of deletion (for deleted users). Note that this field is only regarded if  &#39;includeMonthlyStats&#39; &#x3D; true.</param> 
        /// <param name="minBankConnectionCountInMonthlyStats">A value of X means that the service will return only those users which had at least X bank connections imported at any time within the returned monthly stats set. This field is only regarded when &#39;includeMonthlyStats&#39; is set to &#39;true&#39;. The default value for this field is 0.</param> 
        /// <param name="userId">The identifier of a user to search for. If specified, then only the user with the given id will be regarded. If no user can be found for the passed userId (because the user was deleted or his username was misspelled), then the result list will be empty.</param> 
        /// <param name="isDeleted">If NOT specified, then the service will regard both active and deleted users in the search. If set to &#39;true&#39;, then ONLY deleted users will be regarded. If set to &#39;false&#39;, then ONLY active users will be regarded.</param> 
        /// <param name="isLocked">If NOT specified, then the service will regard both locked and not locked users in the search. If set to &#39;true&#39;, then ONLY locked users will be regarded. If set to &#39;false&#39;, then ONLY not locked users will be regarded.</param> 
        /// <param name="page">Result page that you want to retrieve</param> 
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param> 
        /// <param name="order">Determines the order of the results. You can order the results by &#39;userId&#39;. The default order for this service is &#39;userId,asc&#39;. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. </param> 
        /// <returns>PageableUserInfoList</returns>            
        public PageableUserInfoList GetUserList (string minRegistrationDate, string maxRegistrationDate, string minDeletionDate, string maxDeletionDate, string minLastActiveDate, string maxLastActiveDate, bool? includeMonthlyStats, string monthlyStatsStartDate, string monthlyStatsEndDate, int? minBankConnectionCountInMonthlyStats, string userId, bool? isDeleted, bool? isLocked, int? page, int? perPage, List<string> order)
        {
            
    
            var path = "/api/v1/mandatorAdmin/getUserList";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (minRegistrationDate != null) queryParams.Add("minRegistrationDate", ApiClient.ParameterToString(minRegistrationDate)); // query parameter
 if (maxRegistrationDate != null) queryParams.Add("maxRegistrationDate", ApiClient.ParameterToString(maxRegistrationDate)); // query parameter
 if (minDeletionDate != null) queryParams.Add("minDeletionDate", ApiClient.ParameterToString(minDeletionDate)); // query parameter
 if (maxDeletionDate != null) queryParams.Add("maxDeletionDate", ApiClient.ParameterToString(maxDeletionDate)); // query parameter
 if (minLastActiveDate != null) queryParams.Add("minLastActiveDate", ApiClient.ParameterToString(minLastActiveDate)); // query parameter
 if (maxLastActiveDate != null) queryParams.Add("maxLastActiveDate", ApiClient.ParameterToString(maxLastActiveDate)); // query parameter
 if (includeMonthlyStats != null) queryParams.Add("includeMonthlyStats", ApiClient.ParameterToString(includeMonthlyStats)); // query parameter
 if (monthlyStatsStartDate != null) queryParams.Add("monthlyStatsStartDate", ApiClient.ParameterToString(monthlyStatsStartDate)); // query parameter
 if (monthlyStatsEndDate != null) queryParams.Add("monthlyStatsEndDate", ApiClient.ParameterToString(monthlyStatsEndDate)); // query parameter
 if (minBankConnectionCountInMonthlyStats != null) queryParams.Add("minBankConnectionCountInMonthlyStats", ApiClient.ParameterToString(minBankConnectionCountInMonthlyStats)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
 if (isDeleted != null) queryParams.Add("isDeleted", ApiClient.ParameterToString(isDeleted)); // query parameter
 if (isLocked != null) queryParams.Add("isLocked", ApiClient.ParameterToString(isLocked)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("perPage", ApiClient.ParameterToString(perPage)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageableUserInfoList) ApiClient.Deserialize(response.Content, typeof(PageableUserInfoList), response.Headers);
        }
    
    }
}
