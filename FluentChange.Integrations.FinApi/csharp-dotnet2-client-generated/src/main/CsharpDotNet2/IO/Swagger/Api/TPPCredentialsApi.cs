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
    public interface ITPPCredentialsApi
    {
        /// <summary>
        /// Create new TPP credentials Upload TPP credentials for a TPP Authentication Group. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token.
        /// </summary>
        /// <param name="body">Parameters of a new set of TPP credentials</param>
        /// <returns>TppCredentials</returns>
        TppCredentials CreateTppCredential (TppCredentialsParams body);
        /// <summary>
        /// Delete a set of TPP credentials Delete a single set of TPP credentials by its id. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token.
        /// </summary>
        /// <param name="id">Id of the TPP credentials to delete</param>
        /// <returns></returns>
        void DeleteTppCredential (long? id);
        /// <summary>
        /// Edit a set of TPP credentials Edit TPP credentials data. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token.
        /// </summary>
        /// <param name="id">Id of the TPP credentials to edit</param>
        /// <param name="body">New TPP credentials parameters</param>
        /// <returns>TppCredentials</returns>
        TppCredentials EditTppCredential (long? id, EditTppCredentialParams body);
        /// <summary>
        /// Get all TPP credentials Get and search all TPP credentials. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token. You can set optional search criteria to get only those TPP credentials that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="search">Returns only the TPP credentials belonging to those banks whose &#39;name&#39;, &#39;blz&#39;, or &#39;bic&#39; contains the given search string (the matching works case-insensitive). Note: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must apply to a bank in order for it to get included into the result.</param>
        /// <param name="page">Result page that you want to retrieve</param>
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param>
        /// <returns>PageableTppCredentialResources</returns>
        PageableTppCredentialResources GetAllTppCredentials (string search, int? page, int? perPage);
        /// <summary>
        /// Get all TPP Authentication Groups Get and search across all available TPP authentication groups. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token. You can set optional search criteria to get only those TPP authentication groups that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="ids">A comma-separated list of TPP authentication group identifiers. If specified, then only TPP authentication groups whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param>
        /// <param name="name">Only the tpp authentication groups with name matching the given one should appear in the result list</param>
        /// <param name="bankBlz">Search by connected banks: only the banks with BLZ matching the given one should appear in the result list</param>
        /// <param name="bankName">Search by connected banks: only the banks with name matching the given one should appear in the result list</param>
        /// <param name="page">Result page that you want to retrieve</param>
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param>
        /// <returns>PageableTppAuthenticationGroupResources</returns>
        PageableTppAuthenticationGroupResources GetAndSearchTppAuthenticationGroups (List<long?> ids, string name, string bankBlz, string bankName, int? page, int? perPage);
        /// <summary>
        /// Get a set of TPP credentials Get a single set of TPP credentials by its id. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token.
        /// </summary>
        /// <param name="id">Id of the requested TPP credentials</param>
        /// <returns>TppCredentials</returns>
        TppCredentials GetTppCredential (long? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TPPCredentialsApi : ITPPCredentialsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPPCredentialsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TPPCredentialsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TPPCredentialsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TPPCredentialsApi(String basePath)
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
        /// Create new TPP credentials Upload TPP credentials for a TPP Authentication Group. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token.
        /// </summary>
        /// <param name="body">Parameters of a new set of TPP credentials</param> 
        /// <returns>TppCredentials</returns>            
        public TppCredentials CreateTppCredential (TppCredentialsParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateTppCredential");
            
    
            var path = "/api/v1/tppCredentials";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTppCredential: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTppCredential: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TppCredentials) ApiClient.Deserialize(response.Content, typeof(TppCredentials), response.Headers);
        }
    
        /// <summary>
        /// Delete a set of TPP credentials Delete a single set of TPP credentials by its id. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token.
        /// </summary>
        /// <param name="id">Id of the TPP credentials to delete</param> 
        /// <returns></returns>            
        public void DeleteTppCredential (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteTppCredential");
            
    
            var path = "/api/v1/tppCredentials/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTppCredential: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTppCredential: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Edit a set of TPP credentials Edit TPP credentials data. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token.
        /// </summary>
        /// <param name="id">Id of the TPP credentials to edit</param> 
        /// <param name="body">New TPP credentials parameters</param> 
        /// <returns>TppCredentials</returns>            
        public TppCredentials EditTppCredential (long? id, EditTppCredentialParams body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditTppCredential");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling EditTppCredential");
            
    
            var path = "/api/v1/tppCredentials/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EditTppCredential: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditTppCredential: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TppCredentials) ApiClient.Deserialize(response.Content, typeof(TppCredentials), response.Headers);
        }
    
        /// <summary>
        /// Get all TPP credentials Get and search all TPP credentials. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token. You can set optional search criteria to get only those TPP credentials that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="search">Returns only the TPP credentials belonging to those banks whose &#39;name&#39;, &#39;blz&#39;, or &#39;bic&#39; contains the given search string (the matching works case-insensitive). Note: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must apply to a bank in order for it to get included into the result.</param> 
        /// <param name="page">Result page that you want to retrieve</param> 
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param> 
        /// <returns>PageableTppCredentialResources</returns>            
        public PageableTppCredentialResources GetAllTppCredentials (string search, int? page, int? perPage)
        {
            
    
            var path = "/api/v1/tppCredentials";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("perPage", ApiClient.ParameterToString(perPage)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllTppCredentials: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllTppCredentials: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageableTppCredentialResources) ApiClient.Deserialize(response.Content, typeof(PageableTppCredentialResources), response.Headers);
        }
    
        /// <summary>
        /// Get all TPP Authentication Groups Get and search across all available TPP authentication groups. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token. You can set optional search criteria to get only those TPP authentication groups that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="ids">A comma-separated list of TPP authentication group identifiers. If specified, then only TPP authentication groups whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param> 
        /// <param name="name">Only the tpp authentication groups with name matching the given one should appear in the result list</param> 
        /// <param name="bankBlz">Search by connected banks: only the banks with BLZ matching the given one should appear in the result list</param> 
        /// <param name="bankName">Search by connected banks: only the banks with name matching the given one should appear in the result list</param> 
        /// <param name="page">Result page that you want to retrieve</param> 
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param> 
        /// <returns>PageableTppAuthenticationGroupResources</returns>            
        public PageableTppAuthenticationGroupResources GetAndSearchTppAuthenticationGroups (List<long?> ids, string name, string bankBlz, string bankName, int? page, int? perPage)
        {
            
    
            var path = "/api/v1/tppCredentials/tppAuthenticationGroups";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (bankBlz != null) queryParams.Add("bankBlz", ApiClient.ParameterToString(bankBlz)); // query parameter
 if (bankName != null) queryParams.Add("bankName", ApiClient.ParameterToString(bankName)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("perPage", ApiClient.ParameterToString(perPage)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchTppAuthenticationGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchTppAuthenticationGroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageableTppAuthenticationGroupResources) ApiClient.Deserialize(response.Content, typeof(PageableTppAuthenticationGroupResources), response.Headers);
        }
    
        /// <summary>
        /// Get a set of TPP credentials Get a single set of TPP credentials by its id. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token.
        /// </summary>
        /// <param name="id">Id of the requested TPP credentials</param> 
        /// <returns>TppCredentials</returns>            
        public TppCredentials GetTppCredential (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetTppCredential");
            
    
            var path = "/api/v1/tppCredentials/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTppCredential: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTppCredential: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TppCredentials) ApiClient.Deserialize(response.Content, typeof(TppCredentials), response.Headers);
        }
    
    }
}
