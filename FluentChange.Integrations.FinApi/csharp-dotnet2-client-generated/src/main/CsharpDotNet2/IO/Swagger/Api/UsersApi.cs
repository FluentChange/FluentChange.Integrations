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
    public interface IUsersApi
    {
        /// <summary>
        /// Create a new user &lt;p&gt;Create a new user. Must pass your global (i.e. client) access_token. &lt;/p&gt;&lt;p&gt;This service returns the user&#39;s password as plain text. &lt;/p&gt;&lt;p&gt;The automatic update of the user&#39;s bank connections is disabled by default for any new user. User identifiers are regarded case-insensitive by finAPI.&lt;/p&gt;&lt;p&gt;Please note that finAPI generally has a restricted set of allowed characters for input fields. You can find the allowed characters &lt;a href &#x3D; \&quot;https://finapi.zendesk.com/hc/en-us/articles/222013148-What-symbols-are-allowed-in-finAPI-\&quot;&gt;here&lt;/a&gt;. If a field does not explicitly specify a set of allowed characters, then these are the characters that are allowed for the field. Some fields may specify a different set of characters, in which case this will be documented for the field (like for the &#39;id&#39; field in this service).&lt;/p&gt;
        /// </summary>
        /// <param name="body">User&#39;s details</param>
        /// <returns>User</returns>
        User CreateUser (UserCreateParams body);
        /// <summary>
        /// Delete the authorized user Delete the authorized user. Must pass the user&#39;s access_token. ATTENTION: This deletes the user including all of his bank connections, accounts, balance data and transactions! THIS PROCESS CANNOT BE UNDONE! Note that a user cannot get deleted while any of his bank connections are currently busy (in the process of import, update, or transactions categorization). &lt;p&gt;Note: finAPI will send a notification about the deletion of the user to each of your clients that has a user synchronization callback URL set in its configuration. This also includes the client that is performing this request.&lt;/p&gt;
        /// </summary>
        /// <returns></returns>
        void DeleteAuthorizedUser ();
        /// <summary>
        /// Delete an unverified user Delete an unverified user. Must pass your global (i.e. client) access_token.&lt;br/&gt;&lt;br/&gt;Notes:&lt;br/&gt;&amp;bull; Unverified users can only exist if the field &#39;isUserAutoVerificationEnabled&#39; (see Client Configuration Resource) is set to &#39;false&#39; (or had been false at some point in the past).&lt;br/&gt;&amp;bull; finAPI will send a notification about the deletion of the user to each of your clients that has a user synchronization callback URL set in its configuration. This also includes the client that is performing this request.&lt;br/&gt;&amp;bull; finAPI regards user identifiers case-insensitive.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        void DeleteUnverifiedUser (string userId);
        /// <summary>
        /// Edit the authorized user Edit the authorized user&#39;s data and settings. Must pass the user&#39;s access_token. Pass an empty string (but not null) to unset either the email or phone number. At least one field must have a non-null value in the request body. This service returns the user&#39;s password as &#39;XXXXX&#39;.
        /// </summary>
        /// <param name="body">User&#39;s details</param>
        /// <returns>User</returns>
        User EditAuthorizedUser (UserUpdateParams body);
        /// <summary>
        /// Execute password change Change the password of a user. Must pass your global (i.e. client) access_token.&lt;br/&gt;&lt;br/&gt;Note: When changing the password of a user, all tokens that have been handed out for that user (for whatever client) will be revoked! Also note that finAPI regards user identifiers case-insensitive.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void ExecutePasswordChange (ExecutePasswordChangeParams body);
        /// <summary>
        /// Get the authorized user Get the authorized user&#39;s data. Must pass the user&#39;s access_token. Only the authorized user can get his data, i.e. his access_token must be used. This service returns the user&#39;s password as &#39;XXXXX&#39;.
        /// </summary>
        /// <returns>User</returns>
        User GetAuthorizedUser ();
        /// <summary>
        /// Get a user&#39;s verification status Get the verification status of the requested user. Must pass your global (i.e. client) access_token. Note that finAPI regards user identifiers case-insensitive.
        /// </summary>
        /// <param name="userId">User&#39;s identifier</param>
        /// <returns>VerificationStatusResource</returns>
        VerificationStatusResource GetVerificationStatus (string userId);
        /// <summary>
        /// Request password change Request password change for a user. Must pass your global (i.e. client) access_token. Note that finAPI regards user identifiers case-insensitive.
        /// </summary>
        /// <param name="body"></param>
        /// <returns>PasswordChangingResource</returns>
        PasswordChangingResource RequestPasswordChange (RequestPasswordChangeParams body);
        /// <summary>
        /// Verify a user Verify a user. User verification is only required when your client does not have auto-verification enabled (see field &#39;isUserAutoVerificationEnabled&#39; in Client Configuration Resource). Must pass your global (i.e. client) access_token. Note that finAPI regards user identifiers case-insensitive.
        /// </summary>
        /// <param name="userId">User&#39;s identifier</param>
        /// <returns></returns>
        void VerifyUser (string userId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
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
        /// Create a new user &lt;p&gt;Create a new user. Must pass your global (i.e. client) access_token. &lt;/p&gt;&lt;p&gt;This service returns the user&#39;s password as plain text. &lt;/p&gt;&lt;p&gt;The automatic update of the user&#39;s bank connections is disabled by default for any new user. User identifiers are regarded case-insensitive by finAPI.&lt;/p&gt;&lt;p&gt;Please note that finAPI generally has a restricted set of allowed characters for input fields. You can find the allowed characters &lt;a href &#x3D; \&quot;https://finapi.zendesk.com/hc/en-us/articles/222013148-What-symbols-are-allowed-in-finAPI-\&quot;&gt;here&lt;/a&gt;. If a field does not explicitly specify a set of allowed characters, then these are the characters that are allowed for the field. Some fields may specify a different set of characters, in which case this will be documented for the field (like for the &#39;id&#39; field in this service).&lt;/p&gt;
        /// </summary>
        /// <param name="body">User&#39;s details</param> 
        /// <returns>User</returns>            
        public User CreateUser (UserCreateParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateUser");
            
    
            var path = "/api/v1/users";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
        }
    
        /// <summary>
        /// Delete the authorized user Delete the authorized user. Must pass the user&#39;s access_token. ATTENTION: This deletes the user including all of his bank connections, accounts, balance data and transactions! THIS PROCESS CANNOT BE UNDONE! Note that a user cannot get deleted while any of his bank connections are currently busy (in the process of import, update, or transactions categorization). &lt;p&gt;Note: finAPI will send a notification about the deletion of the user to each of your clients that has a user synchronization callback URL set in its configuration. This also includes the client that is performing this request.&lt;/p&gt;
        /// </summary>
        /// <returns></returns>            
        public void DeleteAuthorizedUser ()
        {
            
    
            var path = "/api/v1/users";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAuthorizedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAuthorizedUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an unverified user Delete an unverified user. Must pass your global (i.e. client) access_token.&lt;br/&gt;&lt;br/&gt;Notes:&lt;br/&gt;&amp;bull; Unverified users can only exist if the field &#39;isUserAutoVerificationEnabled&#39; (see Client Configuration Resource) is set to &#39;false&#39; (or had been false at some point in the past).&lt;br/&gt;&amp;bull; finAPI will send a notification about the deletion of the user to each of your clients that has a user synchronization callback URL set in its configuration. This also includes the client that is performing this request.&lt;br/&gt;&amp;bull; finAPI regards user identifiers case-insensitive.
        /// </summary>
        /// <param name="userId"></param> 
        /// <returns></returns>            
        public void DeleteUnverifiedUser (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling DeleteUnverifiedUser");
            
    
            var path = "/api/v1/users/{userId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUnverifiedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUnverifiedUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Edit the authorized user Edit the authorized user&#39;s data and settings. Must pass the user&#39;s access_token. Pass an empty string (but not null) to unset either the email or phone number. At least one field must have a non-null value in the request body. This service returns the user&#39;s password as &#39;XXXXX&#39;.
        /// </summary>
        /// <param name="body">User&#39;s details</param> 
        /// <returns>User</returns>            
        public User EditAuthorizedUser (UserUpdateParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling EditAuthorizedUser");
            
    
            var path = "/api/v1/users";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EditAuthorizedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditAuthorizedUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
        }
    
        /// <summary>
        /// Execute password change Change the password of a user. Must pass your global (i.e. client) access_token.&lt;br/&gt;&lt;br/&gt;Note: When changing the password of a user, all tokens that have been handed out for that user (for whatever client) will be revoked! Also note that finAPI regards user identifiers case-insensitive.
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ExecutePasswordChange (ExecutePasswordChangeParams body)
        {
            
    
            var path = "/api/v1/users/executePasswordChange";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ExecutePasswordChange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ExecutePasswordChange: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the authorized user Get the authorized user&#39;s data. Must pass the user&#39;s access_token. Only the authorized user can get his data, i.e. his access_token must be used. This service returns the user&#39;s password as &#39;XXXXX&#39;.
        /// </summary>
        /// <returns>User</returns>            
        public User GetAuthorizedUser ()
        {
            
    
            var path = "/api/v1/users";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuthorizedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuthorizedUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
        }
    
        /// <summary>
        /// Get a user&#39;s verification status Get the verification status of the requested user. Must pass your global (i.e. client) access_token. Note that finAPI regards user identifiers case-insensitive.
        /// </summary>
        /// <param name="userId">User&#39;s identifier</param> 
        /// <returns>VerificationStatusResource</returns>            
        public VerificationStatusResource GetVerificationStatus (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetVerificationStatus");
            
    
            var path = "/api/v1/users/verificationStatus";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVerificationStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVerificationStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VerificationStatusResource) ApiClient.Deserialize(response.Content, typeof(VerificationStatusResource), response.Headers);
        }
    
        /// <summary>
        /// Request password change Request password change for a user. Must pass your global (i.e. client) access_token. Note that finAPI regards user identifiers case-insensitive.
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>PasswordChangingResource</returns>            
        public PasswordChangingResource RequestPasswordChange (RequestPasswordChangeParams body)
        {
            
    
            var path = "/api/v1/users/requestPasswordChange";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RequestPasswordChange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RequestPasswordChange: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordChangingResource) ApiClient.Deserialize(response.Content, typeof(PasswordChangingResource), response.Headers);
        }
    
        /// <summary>
        /// Verify a user Verify a user. User verification is only required when your client does not have auto-verification enabled (see field &#39;isUserAutoVerificationEnabled&#39; in Client Configuration Resource). Must pass your global (i.e. client) access_token. Note that finAPI regards user identifiers case-insensitive.
        /// </summary>
        /// <param name="userId">User&#39;s identifier</param> 
        /// <returns></returns>            
        public void VerifyUser (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling VerifyUser");
            
    
            var path = "/api/v1/users/verify/{userId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VerifyUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VerifyUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
