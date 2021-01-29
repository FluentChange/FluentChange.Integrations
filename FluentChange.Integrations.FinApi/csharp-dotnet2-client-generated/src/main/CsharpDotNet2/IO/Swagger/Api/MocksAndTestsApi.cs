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
    public interface IMocksAndTestsApi
    {
        /// <summary>
        /// Check categorization This service can be used to check the categorization for a given set of transactions, without the need of having the transactions actually imported in finAPI. The result of the categorization is the same as if the transactions were actually imported (the service regards the user-specific categorization rules of the user that is authorized by the access_token). Must pass the user&#39;s access_token.
        /// </summary>
        /// <param name="body">Transactions data</param>
        /// <returns>CategorizationCheckResults</returns>
        CategorizationCheckResults CheckCategorization (CheckCategorizationData body);
        /// <summary>
        /// Mock batch update This service can be used to mock an update of one or several bank connections by letting you simulate finAPI&#39;s communication with a bank server. More specifically, you can provide custom balances and transactions for existing accounts and finAPI will import that data into the accounts as if the data had been delivered by a real bank server during a real update. The idea of this service is to allow you to create accounts with specific data in them so that you can test your application in different scenarios.&lt;br/&gt;&lt;br/&gt;You can also test your application&#39;s reception and processing of push notifications with this service, by enabling the &#39;triggerNotifications&#39; flag in your request. When this flag is enabled, finAPI will send notifications to your application based on the notification rules that are set up for the user and on the data you provided in the request, the same way as it works with finAPI&#39;s real automatic batch update process.&lt;br/&gt;&lt;br/&gt;Note that this service behaves mostly like calling the bank connection update service, meaning that it returns immediately after having asynchronously started the update process, and also meaning that you have to check the status of the updated bank connections and accounts to find out when the update has finished and what the result is. As you can update several bank connections at once, this service is closer to how finAPI&#39;s automatic batch updates work as it is to the manual update service though. Because of this, the result of the mocked bank connection updates will be stored in the &#39;lastAutoUpdate&#39; field of the bank connection interface and not in the &#39;lastManualUpdate&#39; field. Also, just like with the real batch update, any bank connection that you use with this service must have a PIN stored (even though it is not actually forwarded to any bank server).&lt;br/&gt;&lt;br/&gt;Also note that this service may be called only when the user&#39;s automatic bank connection updates are disabled, to make sure that the mock updates cannot intervene with a real update (please see the User field &#39;isAutoUpdateEnabled&#39;). Also, it is currently not possible to mock data for security accounts with this service, as you can only pass transactions, but not security positions.&lt;br/&gt;&lt;br/&gt;Please be aware that you will &#39;mess up&#39; the accounts when using this service, meaning that when you perform a real update of accounts that you have previously updated with this service, finAPI might detect inconsistencies in the data that exists in its database and the data that is reported by the bank server, and try to fix this with the insertion of an adjusting entry (&#39;Zwischensaldo&#39; transaction). Also, new real transactions might not get imported as finAPI could match them to mocked transactions. Also note that transactions older than 89 days from the current date will be skipped. &lt;b&gt;THIS SERVICE IS MEANT FOR TESTING PURPOSES DURING DEVELOPMENT OF YOUR APPLICATION ONLY!&lt;/b&gt; This is why it will work only on the sandbox or alpha environments. Calling it on the live environment will result in &lt;b&gt;403 Forbidden&lt;/b&gt;.
        /// </summary>
        /// <param name="body">Data for mock bank connection updates</param>
        /// <returns></returns>
        void MockBatchUpdate (MockBatchUpdateParams body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MocksAndTestsApi : IMocksAndTestsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MocksAndTestsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MocksAndTestsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MocksAndTestsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MocksAndTestsApi(String basePath)
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
        /// Check categorization This service can be used to check the categorization for a given set of transactions, without the need of having the transactions actually imported in finAPI. The result of the categorization is the same as if the transactions were actually imported (the service regards the user-specific categorization rules of the user that is authorized by the access_token). Must pass the user&#39;s access_token.
        /// </summary>
        /// <param name="body">Transactions data</param> 
        /// <returns>CategorizationCheckResults</returns>            
        public CategorizationCheckResults CheckCategorization (CheckCategorizationData body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CheckCategorization");
            
    
            var path = "/api/v1/tests/checkCategorization";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CheckCategorization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckCategorization: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CategorizationCheckResults) ApiClient.Deserialize(response.Content, typeof(CategorizationCheckResults), response.Headers);
        }
    
        /// <summary>
        /// Mock batch update This service can be used to mock an update of one or several bank connections by letting you simulate finAPI&#39;s communication with a bank server. More specifically, you can provide custom balances and transactions for existing accounts and finAPI will import that data into the accounts as if the data had been delivered by a real bank server during a real update. The idea of this service is to allow you to create accounts with specific data in them so that you can test your application in different scenarios.&lt;br/&gt;&lt;br/&gt;You can also test your application&#39;s reception and processing of push notifications with this service, by enabling the &#39;triggerNotifications&#39; flag in your request. When this flag is enabled, finAPI will send notifications to your application based on the notification rules that are set up for the user and on the data you provided in the request, the same way as it works with finAPI&#39;s real automatic batch update process.&lt;br/&gt;&lt;br/&gt;Note that this service behaves mostly like calling the bank connection update service, meaning that it returns immediately after having asynchronously started the update process, and also meaning that you have to check the status of the updated bank connections and accounts to find out when the update has finished and what the result is. As you can update several bank connections at once, this service is closer to how finAPI&#39;s automatic batch updates work as it is to the manual update service though. Because of this, the result of the mocked bank connection updates will be stored in the &#39;lastAutoUpdate&#39; field of the bank connection interface and not in the &#39;lastManualUpdate&#39; field. Also, just like with the real batch update, any bank connection that you use with this service must have a PIN stored (even though it is not actually forwarded to any bank server).&lt;br/&gt;&lt;br/&gt;Also note that this service may be called only when the user&#39;s automatic bank connection updates are disabled, to make sure that the mock updates cannot intervene with a real update (please see the User field &#39;isAutoUpdateEnabled&#39;). Also, it is currently not possible to mock data for security accounts with this service, as you can only pass transactions, but not security positions.&lt;br/&gt;&lt;br/&gt;Please be aware that you will &#39;mess up&#39; the accounts when using this service, meaning that when you perform a real update of accounts that you have previously updated with this service, finAPI might detect inconsistencies in the data that exists in its database and the data that is reported by the bank server, and try to fix this with the insertion of an adjusting entry (&#39;Zwischensaldo&#39; transaction). Also, new real transactions might not get imported as finAPI could match them to mocked transactions. Also note that transactions older than 89 days from the current date will be skipped. &lt;b&gt;THIS SERVICE IS MEANT FOR TESTING PURPOSES DURING DEVELOPMENT OF YOUR APPLICATION ONLY!&lt;/b&gt; This is why it will work only on the sandbox or alpha environments. Calling it on the live environment will result in &lt;b&gt;403 Forbidden&lt;/b&gt;.
        /// </summary>
        /// <param name="body">Data for mock bank connection updates</param> 
        /// <returns></returns>            
        public void MockBatchUpdate (MockBatchUpdateParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling MockBatchUpdate");
            
    
            var path = "/api/v1/tests/mockBatchUpdate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MockBatchUpdate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MockBatchUpdate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
