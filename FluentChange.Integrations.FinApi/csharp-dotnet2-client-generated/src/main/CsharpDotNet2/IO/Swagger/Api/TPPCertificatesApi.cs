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
    public interface ITPPCertificatesApi
    {
        /// <summary>
        /// Create a new certificate Upload a new TPP certificate. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token. &lt;br/&gt;QWAC certificate is used to verify your identity by the bank during the TLS handshake.&lt;br/&gt;QsealC certificate is used to sign the requests to the bank.
        /// </summary>
        /// <param name="body">Create new certificate parameters</param>
        /// <returns>TppCertificate</returns>
        TppCertificate CreateNewCertificate (TppCertificateParams body);
        /// <summary>
        /// Delete a certificate Delete a single certificate by its id. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token.
        /// </summary>
        /// <param name="id">Id of the certificate to delete</param>
        /// <returns></returns>
        void DeleteCertificate (long? id);
        /// <summary>
        /// Get all certificates Returns all certificates that you have uploaded via &#39;Create a new certificate&#39; service. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token.
        /// </summary>
        /// <param name="page">Result page that you want to retrieve</param>
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param>
        /// <returns>PageableTppCertificateList</returns>
        PageableTppCertificateList GetAllCertificates (int? page, int? perPage);
        /// <summary>
        /// Get a certificate Get a single certificate by its id. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token.
        /// </summary>
        /// <param name="id">Id of requested certificate</param>
        /// <returns>TppCertificate</returns>
        TppCertificate GetCertificate (long? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TPPCertificatesApi : ITPPCertificatesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPPCertificatesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TPPCertificatesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TPPCertificatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TPPCertificatesApi(String basePath)
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
        /// Create a new certificate Upload a new TPP certificate. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token. &lt;br/&gt;QWAC certificate is used to verify your identity by the bank during the TLS handshake.&lt;br/&gt;QsealC certificate is used to sign the requests to the bank.
        /// </summary>
        /// <param name="body">Create new certificate parameters</param> 
        /// <returns>TppCertificate</returns>            
        public TppCertificate CreateNewCertificate (TppCertificateParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNewCertificate");
            
    
            var path = "/api/v1/tppCertificates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNewCertificate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNewCertificate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TppCertificate) ApiClient.Deserialize(response.Content, typeof(TppCertificate), response.Headers);
        }
    
        /// <summary>
        /// Delete a certificate Delete a single certificate by its id. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token.
        /// </summary>
        /// <param name="id">Id of the certificate to delete</param> 
        /// <returns></returns>            
        public void DeleteCertificate (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteCertificate");
            
    
            var path = "/api/v1/tppCertificates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCertificate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCertificate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get all certificates Returns all certificates that you have uploaded via &#39;Create a new certificate&#39; service. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token.
        /// </summary>
        /// <param name="page">Result page that you want to retrieve</param> 
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param> 
        /// <returns>PageableTppCertificateList</returns>            
        public PageableTppCertificateList GetAllCertificates (int? page, int? perPage)
        {
            
    
            var path = "/api/v1/tppCertificates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllCertificates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllCertificates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageableTppCertificateList) ApiClient.Deserialize(response.Content, typeof(PageableTppCertificateList), response.Headers);
        }
    
        /// <summary>
        /// Get a certificate Get a single certificate by its id. Must pass the &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client&#39; target&#x3D;&#39;_blank&#39;&gt;mandator admin client&lt;/a&gt;&#39;s access_token.
        /// </summary>
        /// <param name="id">Id of requested certificate</param> 
        /// <returns>TppCertificate</returns>            
        public TppCertificate GetCertificate (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetCertificate");
            
    
            var path = "/api/v1/tppCertificates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCertificate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCertificate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TppCertificate) ApiClient.Deserialize(response.Content, typeof(TppCertificate), response.Headers);
        }
    
    }
}
