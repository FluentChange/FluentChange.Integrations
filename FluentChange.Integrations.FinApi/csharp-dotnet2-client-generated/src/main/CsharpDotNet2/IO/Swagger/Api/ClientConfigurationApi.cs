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
    public interface IClientConfigurationApi
    {
        /// <summary>
        /// Edit client configuration Edit your client&#39;s configuration. Must pass your global (i.e. client) access_token.&lt;br/&gt;&lt;br/&gt; &lt;b&gt;NOTE&lt;/b&gt;: When token validity periods are changed, this only applies to newly requested tokens, and does not change the expiration time of already existing tokens.
        /// </summary>
        /// <param name="body">Client configuration parameters</param>
        /// <returns>ClientConfiguration</returns>
        ClientConfiguration EditClientConfiguration (ClientConfigurationParams body);
        /// <summary>
        /// Get client configuration Get your client&#39;s configuration. Must pass your global (i.e. client) access_token.
        /// </summary>
        /// <returns>ClientConfiguration</returns>
        ClientConfiguration GetClientConfiguration ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ClientConfigurationApi : IClientConfigurationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientConfigurationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ClientConfigurationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientConfigurationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClientConfigurationApi(String basePath)
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
        /// Edit client configuration Edit your client&#39;s configuration. Must pass your global (i.e. client) access_token.&lt;br/&gt;&lt;br/&gt; &lt;b&gt;NOTE&lt;/b&gt;: When token validity periods are changed, this only applies to newly requested tokens, and does not change the expiration time of already existing tokens.
        /// </summary>
        /// <param name="body">Client configuration parameters</param> 
        /// <returns>ClientConfiguration</returns>            
        public ClientConfiguration EditClientConfiguration (ClientConfigurationParams body)
        {
            
    
            var path = "/api/v1/clientConfiguration";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditClientConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditClientConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClientConfiguration) ApiClient.Deserialize(response.Content, typeof(ClientConfiguration), response.Headers);
        }
    
        /// <summary>
        /// Get client configuration Get your client&#39;s configuration. Must pass your global (i.e. client) access_token.
        /// </summary>
        /// <returns>ClientConfiguration</returns>            
        public ClientConfiguration GetClientConfiguration ()
        {
            
    
            var path = "/api/v1/clientConfiguration";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClientConfiguration) ApiClient.Deserialize(response.Content, typeof(ClientConfiguration), response.Headers);
        }
    
    }
}
