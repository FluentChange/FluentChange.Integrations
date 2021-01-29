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
    public interface INotificationRulesApi
    {
        /// <summary>
        /// Create a new notification rule Create a new notification rule for a specific user. Must pass the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;Setting up notification rules for a user allows your client application to get notified about changes in the user&#39;s data, e.g. when new transactions were downloaded, an account&#39;s balance has changed, or the user&#39;s banking credentials are no longer correct. Note that currently, this feature is implemented only for finAPI&#39;s automatic batch update, i.e. notification rules are only relevant when the user has activated the automatic updates (and when the automatic batch update is activated in general for your client).&lt;br/&gt;&lt;br/&gt;There are different kinds of notification rules. The kind of a rule is depicted by the &#39;triggerEvent&#39;. The trigger event specifies what data you have to pass when creating a rule (specifically, the contents of the &#39;params&#39; field), on which events finAPI will send notifications to your client application, as well as what data is contained in those notifications. The specifics of the different trigger events are documented in the following article on our Dev Portal: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/232324608-How-to-create-notification-rules-and-receive-notifications&#39; target&#x3D;&#39;_blank&#39;&gt;How to create notification rules and receive notifications&lt;/a&gt;
        /// </summary>
        /// <param name="body">Notification rule parameters</param>
        /// <returns>NotificationRule</returns>
        NotificationRule CreateNotificationRule (NotificationRuleParams body);
        /// <summary>
        /// Delete all notification rules Delete all notification rules of the user that is authorized by the access_token. Must pass the user&#39;s access_token. 
        /// </summary>
        /// <returns>IdentifierList</returns>
        IdentifierList DeleteAllNotificationRules ();
        /// <summary>
        /// Delete a notification rule Delete a single notification rule of the user that is authorized by the access_token. Must pass the notification rule&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of the notification rule to delete</param>
        /// <returns></returns>
        void DeleteNotificationRule (long? id);
        /// <summary>
        /// Get and search all notification rules Get notification rules of the user that is authorized by the access_token. Must pass the user&#39;s access_token. You can set optional search criteria to get only those notification rules that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="ids">A comma-separated list of notification rule identifiers. If specified, then only notification rules whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param>
        /// <param name="triggerEvent">If specified, then only notification rules with given trigger event will be regarded.</param>
        /// <param name="includeDetails">If specified, then only notification rules that include or not include details will be regarded.</param>
        /// <returns>NotificationRuleList</returns>
        NotificationRuleList GetAndSearchAllNotificationRules (List<long?> ids, string triggerEvent, bool? includeDetails);
        /// <summary>
        /// Get a notification rule Get a single notification rule of the user that is authorized by the access_token. Must pass the notification rule&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of requested notification rule</param>
        /// <returns>NotificationRule</returns>
        NotificationRule GetNotificationRule (long? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class NotificationRulesApi : INotificationRulesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationRulesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public NotificationRulesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationRulesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificationRulesApi(String basePath)
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
        /// Create a new notification rule Create a new notification rule for a specific user. Must pass the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;Setting up notification rules for a user allows your client application to get notified about changes in the user&#39;s data, e.g. when new transactions were downloaded, an account&#39;s balance has changed, or the user&#39;s banking credentials are no longer correct. Note that currently, this feature is implemented only for finAPI&#39;s automatic batch update, i.e. notification rules are only relevant when the user has activated the automatic updates (and when the automatic batch update is activated in general for your client).&lt;br/&gt;&lt;br/&gt;There are different kinds of notification rules. The kind of a rule is depicted by the &#39;triggerEvent&#39;. The trigger event specifies what data you have to pass when creating a rule (specifically, the contents of the &#39;params&#39; field), on which events finAPI will send notifications to your client application, as well as what data is contained in those notifications. The specifics of the different trigger events are documented in the following article on our Dev Portal: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/232324608-How-to-create-notification-rules-and-receive-notifications&#39; target&#x3D;&#39;_blank&#39;&gt;How to create notification rules and receive notifications&lt;/a&gt;
        /// </summary>
        /// <param name="body">Notification rule parameters</param> 
        /// <returns>NotificationRule</returns>            
        public NotificationRule CreateNotificationRule (NotificationRuleParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNotificationRule");
            
    
            var path = "/api/v1/notificationRules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNotificationRule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNotificationRule: " + response.ErrorMessage, response.ErrorMessage);
    
            return (NotificationRule) ApiClient.Deserialize(response.Content, typeof(NotificationRule), response.Headers);
        }
    
        /// <summary>
        /// Delete all notification rules Delete all notification rules of the user that is authorized by the access_token. Must pass the user&#39;s access_token. 
        /// </summary>
        /// <returns>IdentifierList</returns>            
        public IdentifierList DeleteAllNotificationRules ()
        {
            
    
            var path = "/api/v1/notificationRules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAllNotificationRules: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAllNotificationRules: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentifierList) ApiClient.Deserialize(response.Content, typeof(IdentifierList), response.Headers);
        }
    
        /// <summary>
        /// Delete a notification rule Delete a single notification rule of the user that is authorized by the access_token. Must pass the notification rule&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of the notification rule to delete</param> 
        /// <returns></returns>            
        public void DeleteNotificationRule (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteNotificationRule");
            
    
            var path = "/api/v1/notificationRules/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNotificationRule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNotificationRule: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get and search all notification rules Get notification rules of the user that is authorized by the access_token. Must pass the user&#39;s access_token. You can set optional search criteria to get only those notification rules that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="ids">A comma-separated list of notification rule identifiers. If specified, then only notification rules whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param> 
        /// <param name="triggerEvent">If specified, then only notification rules with given trigger event will be regarded.</param> 
        /// <param name="includeDetails">If specified, then only notification rules that include or not include details will be regarded.</param> 
        /// <returns>NotificationRuleList</returns>            
        public NotificationRuleList GetAndSearchAllNotificationRules (List<long?> ids, string triggerEvent, bool? includeDetails)
        {
            
    
            var path = "/api/v1/notificationRules";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
 if (triggerEvent != null) queryParams.Add("triggerEvent", ApiClient.ParameterToString(triggerEvent)); // query parameter
 if (includeDetails != null) queryParams.Add("includeDetails", ApiClient.ParameterToString(includeDetails)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchAllNotificationRules: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchAllNotificationRules: " + response.ErrorMessage, response.ErrorMessage);
    
            return (NotificationRuleList) ApiClient.Deserialize(response.Content, typeof(NotificationRuleList), response.Headers);
        }
    
        /// <summary>
        /// Get a notification rule Get a single notification rule of the user that is authorized by the access_token. Must pass the notification rule&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of requested notification rule</param> 
        /// <returns>NotificationRule</returns>            
        public NotificationRule GetNotificationRule (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetNotificationRule");
            
    
            var path = "/api/v1/notificationRules/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationRule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationRule: " + response.ErrorMessage, response.ErrorMessage);
    
            return (NotificationRule) ApiClient.Deserialize(response.Content, typeof(NotificationRule), response.Headers);
        }
    
    }
}
