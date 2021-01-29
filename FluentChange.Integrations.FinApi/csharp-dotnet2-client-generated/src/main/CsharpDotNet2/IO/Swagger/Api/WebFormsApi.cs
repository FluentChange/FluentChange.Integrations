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
    public interface IWebFormsApi
    {
        /// <summary>
        /// Get a web form Get a web form of the user that is authorized by the access_token. Must pass the web form&#39;s identifier and the user&#39;s access_token. &lt;br/&gt;&lt;br/&gt;Note that every web form resource is automatically removed from the finAPI system after 7 days from its creation.
        /// </summary>
        /// <param name="id">Identifier of web form</param>
        /// <returns>WebForm</returns>
        WebForm GetWebForm (long? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebFormsApi : IWebFormsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebFormsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WebFormsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebFormsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebFormsApi(String basePath)
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
        /// Get a web form Get a web form of the user that is authorized by the access_token. Must pass the web form&#39;s identifier and the user&#39;s access_token. &lt;br/&gt;&lt;br/&gt;Note that every web form resource is automatically removed from the finAPI system after 7 days from its creation.
        /// </summary>
        /// <param name="id">Identifier of web form</param> 
        /// <returns>WebForm</returns>            
        public WebForm GetWebForm (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetWebForm");
            
    
            var path = "/api/v1/webForms/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetWebForm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWebForm: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WebForm) ApiClient.Deserialize(response.Content, typeof(WebForm), response.Headers);
        }
    
    }
}
