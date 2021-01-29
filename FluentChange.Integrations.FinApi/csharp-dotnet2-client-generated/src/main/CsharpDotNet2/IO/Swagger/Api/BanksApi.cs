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
    public interface IBanksApi
    {
        /// <summary>
        /// Get and search all banks Get and search banks from finAPI&#39;s database of banks. Must pass the authorized user&#39;s access_token, or your client&#39;s access_token. You can set optional search criteria to get only those banks that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="ids">A comma-separated list of bank identifiers. If specified, then only banks whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param>
        /// <param name="search">If specified, then only those banks will be contained in the result whose &#39;name&#39;, &#39;blz&#39;, &#39;bic&#39; or &#39;city&#39; contains the given search string (the matching works case-insensitive). If no banks contain the search string in any of the regarded fields, then the result will be an empty list. Note that you may also pass an IBAN in this field, in which case finAPI will try to detect the related bank and regard only this bank for the search (The IBAN may not contain spaces). Also note: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must apply to a bank in order for it to get included into the result.</param>
        /// <param name="supportedInterfaces">Comma-separated list of bank interfaces. Possible values: FINTS_SERVER,WEB_SCRAPER,XS2A. If this parameter is specified, then all the banks that support at least one of the given interfaces will be returned. Note that this does NOT imply that those interfaces must be the only ones that are supported by a bank.</param>
        /// <param name="location">Comma-separated list of two-letter country codes (ISO 3166 ALPHA-2), for example: DE, AT. If set, then only those banks will be regarded in the search that are located in the specified countries. Notes: Banks which do not have a location set (i.e. international institutes) will ALWAYS be regarded in the search, independent of what you specify for this field. When you pass a country code that doesn&#39;t exist in the ISO 3166 ALPHA-2 standard, then the service will respond with 400 BAD_REQUEST.</param>
        /// <param name="tppAuthenticationGroupIds">A comma-separated list of TPP authentication group identifiers. If specified, then only banks who have at least one interface belonging to one of the given groups will be regarded. The maximum number of identifiers is 1000.</param>
        /// <param name="isTestBank">If specified, then only those banks will be regarded that have the given value (true or false) for their &#39;isTestBank&#39; field.</param>
        /// <param name="page">Result page that you want to retrieve.</param>
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param>
        /// <param name="order">Determines the order of the results. You can order the results by &#39;id&#39;, &#39;name&#39;, &#39;blz&#39;, &#39;bic&#39; or &#39;popularity&#39;. The default order for all services is &#39;id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/banks?order&#x3D;name,desc&amp;order&#x3D;id,asc&#39; will return banks ordered by &#39;name&#39; (descending), where banks with the same &#39;name&#39; are ordered by &#39;id&#39; (ascending). The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC). </param>
        /// <returns>PageableBankList</returns>
        PageableBankList GetAndSearchAllBanks (List<long?> ids, string search, List<string> supportedInterfaces, List<string> location, List<long?> tppAuthenticationGroupIds, bool? isTestBank, int? page, int? perPage, List<string> order);
        /// <summary>
        /// Get a bank Get a single bank from finAPI&#39;s database of banks. You have to pass the bank&#39;s identifier, and either the authorized user&#39;s access_token, or your client&#39;s access token.
        /// </summary>
        /// <param name="id">Identifier of requested bank</param>
        /// <returns>Bank</returns>
        Bank GetBank (long? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BanksApi : IBanksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BanksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BanksApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BanksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BanksApi(String basePath)
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
        /// Get and search all banks Get and search banks from finAPI&#39;s database of banks. Must pass the authorized user&#39;s access_token, or your client&#39;s access_token. You can set optional search criteria to get only those banks that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="ids">A comma-separated list of bank identifiers. If specified, then only banks whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param> 
        /// <param name="search">If specified, then only those banks will be contained in the result whose &#39;name&#39;, &#39;blz&#39;, &#39;bic&#39; or &#39;city&#39; contains the given search string (the matching works case-insensitive). If no banks contain the search string in any of the regarded fields, then the result will be an empty list. Note that you may also pass an IBAN in this field, in which case finAPI will try to detect the related bank and regard only this bank for the search (The IBAN may not contain spaces). Also note: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must apply to a bank in order for it to get included into the result.</param> 
        /// <param name="supportedInterfaces">Comma-separated list of bank interfaces. Possible values: FINTS_SERVER,WEB_SCRAPER,XS2A. If this parameter is specified, then all the banks that support at least one of the given interfaces will be returned. Note that this does NOT imply that those interfaces must be the only ones that are supported by a bank.</param> 
        /// <param name="location">Comma-separated list of two-letter country codes (ISO 3166 ALPHA-2), for example: DE, AT. If set, then only those banks will be regarded in the search that are located in the specified countries. Notes: Banks which do not have a location set (i.e. international institutes) will ALWAYS be regarded in the search, independent of what you specify for this field. When you pass a country code that doesn&#39;t exist in the ISO 3166 ALPHA-2 standard, then the service will respond with 400 BAD_REQUEST.</param> 
        /// <param name="tppAuthenticationGroupIds">A comma-separated list of TPP authentication group identifiers. If specified, then only banks who have at least one interface belonging to one of the given groups will be regarded. The maximum number of identifiers is 1000.</param> 
        /// <param name="isTestBank">If specified, then only those banks will be regarded that have the given value (true or false) for their &#39;isTestBank&#39; field.</param> 
        /// <param name="page">Result page that you want to retrieve.</param> 
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param> 
        /// <param name="order">Determines the order of the results. You can order the results by &#39;id&#39;, &#39;name&#39;, &#39;blz&#39;, &#39;bic&#39; or &#39;popularity&#39;. The default order for all services is &#39;id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/banks?order&#x3D;name,desc&amp;order&#x3D;id,asc&#39; will return banks ordered by &#39;name&#39; (descending), where banks with the same &#39;name&#39; are ordered by &#39;id&#39; (ascending). The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC). </param> 
        /// <returns>PageableBankList</returns>            
        public PageableBankList GetAndSearchAllBanks (List<long?> ids, string search, List<string> supportedInterfaces, List<string> location, List<long?> tppAuthenticationGroupIds, bool? isTestBank, int? page, int? perPage, List<string> order)
        {
            
    
            var path = "/api/v1/banks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
 if (supportedInterfaces != null) queryParams.Add("supportedInterfaces", ApiClient.ParameterToString(supportedInterfaces)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (tppAuthenticationGroupIds != null) queryParams.Add("tppAuthenticationGroupIds", ApiClient.ParameterToString(tppAuthenticationGroupIds)); // query parameter
 if (isTestBank != null) queryParams.Add("isTestBank", ApiClient.ParameterToString(isTestBank)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("perPage", ApiClient.ParameterToString(perPage)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchAllBanks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchAllBanks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageableBankList) ApiClient.Deserialize(response.Content, typeof(PageableBankList), response.Headers);
        }
    
        /// <summary>
        /// Get a bank Get a single bank from finAPI&#39;s database of banks. You have to pass the bank&#39;s identifier, and either the authorized user&#39;s access_token, or your client&#39;s access token.
        /// </summary>
        /// <param name="id">Identifier of requested bank</param> 
        /// <returns>Bank</returns>            
        public Bank GetBank (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetBank");
            
    
            var path = "/api/v1/banks/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBank: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBank: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Bank) ApiClient.Deserialize(response.Content, typeof(Bank), response.Headers);
        }
    
    }
}
