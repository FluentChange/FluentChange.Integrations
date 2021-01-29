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
    public interface ISecuritiesApi
    {
        /// <summary>
        /// Get and search all securities Get securities of the user that is authorized by the access_token. Must pass the user&#39;s access_token. You can set optional search criteria to get only those securities that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.&lt;p&gt;Note: Whenever a security account is being updated, its security positions will be internally re-created, meaning that the identifier of a security position might change over time.&lt;/p&gt;
        /// </summary>
        /// <param name="ids">A comma-separated list of security identifiers. If specified, then only securities whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param>
        /// <param name="search">If specified, then only those securities will be contained in the result whose &#39;name&#39;, &#39;isin&#39; or &#39;wkn&#39; contains the given search string (the matching works case-insensitive). If no securities contain the search string in any of these fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for a security to get included into the result.</param>
        /// <param name="accountIds">Comma-separated list of identifiers of accounts</param>
        /// <param name="page">Result page that you want to retrieve.</param>
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param>
        /// <param name="order">Determines the order of the results. You can order the results by next fields: &#39;id&#39;, &#39;name&#39;, &#39;isin&#39;, &#39;wkn&#39;, &#39;quote&#39;, &#39;quantityNominal&#39;, &#39;marketValue&#39; and &#39;entryQuote&#39;. The default order for all services is &#39;id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC). </param>
        /// <returns>PageableSecurityList</returns>
        PageableSecurityList GetAndSearchAllSecurities (List<long?> ids, string search, List<long?> accountIds, int? page, int? perPage, List<string> order);
        /// <summary>
        /// Get a security Get a single security for a specific user. Must pass the security&#39;s identifier and the user&#39;s access_token. &lt;p&gt;Note: Whenever a security account is being updated, its security positions will be internally re-created, meaning that the identifier of a security position might change over time.&lt;/p&gt;
        /// </summary>
        /// <param name="id">Security identifier</param>
        /// <returns>Security</returns>
        Security GetSecurity (long? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SecuritiesApi : ISecuritiesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritiesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SecuritiesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SecuritiesApi(String basePath)
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
        /// Get and search all securities Get securities of the user that is authorized by the access_token. Must pass the user&#39;s access_token. You can set optional search criteria to get only those securities that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.&lt;p&gt;Note: Whenever a security account is being updated, its security positions will be internally re-created, meaning that the identifier of a security position might change over time.&lt;/p&gt;
        /// </summary>
        /// <param name="ids">A comma-separated list of security identifiers. If specified, then only securities whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param> 
        /// <param name="search">If specified, then only those securities will be contained in the result whose &#39;name&#39;, &#39;isin&#39; or &#39;wkn&#39; contains the given search string (the matching works case-insensitive). If no securities contain the search string in any of these fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for a security to get included into the result.</param> 
        /// <param name="accountIds">Comma-separated list of identifiers of accounts</param> 
        /// <param name="page">Result page that you want to retrieve.</param> 
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param> 
        /// <param name="order">Determines the order of the results. You can order the results by next fields: &#39;id&#39;, &#39;name&#39;, &#39;isin&#39;, &#39;wkn&#39;, &#39;quote&#39;, &#39;quantityNominal&#39;, &#39;marketValue&#39; and &#39;entryQuote&#39;. The default order for all services is &#39;id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC). </param> 
        /// <returns>PageableSecurityList</returns>            
        public PageableSecurityList GetAndSearchAllSecurities (List<long?> ids, string search, List<long?> accountIds, int? page, int? perPage, List<string> order)
        {
            
    
            var path = "/api/v1/securities";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
 if (accountIds != null) queryParams.Add("accountIds", ApiClient.ParameterToString(accountIds)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("perPage", ApiClient.ParameterToString(perPage)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchAllSecurities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchAllSecurities: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageableSecurityList) ApiClient.Deserialize(response.Content, typeof(PageableSecurityList), response.Headers);
        }
    
        /// <summary>
        /// Get a security Get a single security for a specific user. Must pass the security&#39;s identifier and the user&#39;s access_token. &lt;p&gt;Note: Whenever a security account is being updated, its security positions will be internally re-created, meaning that the identifier of a security position might change over time.&lt;/p&gt;
        /// </summary>
        /// <param name="id">Security identifier</param> 
        /// <returns>Security</returns>            
        public Security GetSecurity (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSecurity");
            
    
            var path = "/api/v1/securities/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSecurity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSecurity: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Security) ApiClient.Deserialize(response.Content, typeof(Security), response.Headers);
        }
    
    }
}
