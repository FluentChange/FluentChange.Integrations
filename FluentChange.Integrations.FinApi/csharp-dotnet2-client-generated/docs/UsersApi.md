# IO.Swagger.Api.UsersApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUser**](UsersApi.md#createuser) | **POST** /api/v1/users | Create a new user
[**DeleteAuthorizedUser**](UsersApi.md#deleteauthorizeduser) | **DELETE** /api/v1/users | Delete the authorized user
[**DeleteUnverifiedUser**](UsersApi.md#deleteunverifieduser) | **DELETE** /api/v1/users/{userId} | Delete an unverified user
[**EditAuthorizedUser**](UsersApi.md#editauthorizeduser) | **PATCH** /api/v1/users | Edit the authorized user
[**ExecutePasswordChange**](UsersApi.md#executepasswordchange) | **POST** /api/v1/users/executePasswordChange | Execute password change
[**GetAuthorizedUser**](UsersApi.md#getauthorizeduser) | **GET** /api/v1/users | Get the authorized user
[**GetVerificationStatus**](UsersApi.md#getverificationstatus) | **GET** /api/v1/users/verificationStatus | Get a user&#39;s verification status
[**RequestPasswordChange**](UsersApi.md#requestpasswordchange) | **POST** /api/v1/users/requestPasswordChange | Request password change
[**VerifyUser**](UsersApi.md#verifyuser) | **POST** /api/v1/users/verify/{userId} | Verify a user


<a name="createuser"></a>
# **CreateUser**
> User CreateUser (UserCreateParams body)

Create a new user

<p>Create a new user. Must pass your global (i.e. client) access_token. </p><p>This service returns the user's password as plain text. </p><p>The automatic update of the user's bank connections is disabled by default for any new user. User identifiers are regarded case-insensitive by finAPI.</p><p>Please note that finAPI generally has a restricted set of allowed characters for input fields. You can find the allowed characters <a href = \"https://finapi.zendesk.com/hc/en-us/articles/222013148-What-symbols-are-allowed-in-finAPI-\">here</a>. If a field does not explicitly specify a set of allowed characters, then these are the characters that are allowed for the field. Some fields may specify a different set of characters, in which case this will be documented for the field (like for the 'id' field in this service).</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new UserCreateParams(); // UserCreateParams | User's details

            try
            {
                // Create a new user
                User result = apiInstance.CreateUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserCreateParams**](UserCreateParams.md)| User&#39;s details | 

### Return type

[**User**](User.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthorizeduser"></a>
# **DeleteAuthorizedUser**
> void DeleteAuthorizedUser ()

Delete the authorized user

Delete the authorized user. Must pass the user's access_token. ATTENTION: This deletes the user including all of his bank connections, accounts, balance data and transactions! THIS PROCESS CANNOT BE UNDONE! Note that a user cannot get deleted while any of his bank connections are currently busy (in the process of import, update, or transactions categorization). <p>Note: finAPI will send a notification about the deletion of the user to each of your clients that has a user synchronization callback URL set in its configuration. This also includes the client that is performing this request.</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAuthorizedUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();

            try
            {
                // Delete the authorized user
                apiInstance.DeleteAuthorizedUser();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteAuthorizedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteunverifieduser"></a>
# **DeleteUnverifiedUser**
> void DeleteUnverifiedUser (string userId)

Delete an unverified user

Delete an unverified user. Must pass your global (i.e. client) access_token.<br/><br/>Notes:<br/>&bull; Unverified users can only exist if the field 'isUserAutoVerificationEnabled' (see Client Configuration Resource) is set to 'false' (or had been false at some point in the past).<br/>&bull; finAPI will send a notification about the deletion of the user to each of your clients that has a user synchronization callback URL set in its configuration. This also includes the client that is performing this request.<br/>&bull; finAPI regards user identifiers case-insensitive.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUnverifiedUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | 

            try
            {
                // Delete an unverified user
                apiInstance.DeleteUnverifiedUser(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUnverifiedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editauthorizeduser"></a>
# **EditAuthorizedUser**
> User EditAuthorizedUser (UserUpdateParams body)

Edit the authorized user

Edit the authorized user's data and settings. Must pass the user's access_token. Pass an empty string (but not null) to unset either the email or phone number. At least one field must have a non-null value in the request body. This service returns the user's password as 'XXXXX'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditAuthorizedUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new UserUpdateParams(); // UserUpdateParams | User's details

            try
            {
                // Edit the authorized user
                User result = apiInstance.EditAuthorizedUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.EditAuthorizedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserUpdateParams**](UserUpdateParams.md)| User&#39;s details | 

### Return type

[**User**](User.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executepasswordchange"></a>
# **ExecutePasswordChange**
> void ExecutePasswordChange (ExecutePasswordChangeParams body)

Execute password change

Change the password of a user. Must pass your global (i.e. client) access_token.<br/><br/>Note: When changing the password of a user, all tokens that have been handed out for that user (for whatever client) will be revoked! Also note that finAPI regards user identifiers case-insensitive.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecutePasswordChangeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new ExecutePasswordChangeParams(); // ExecutePasswordChangeParams |  (optional) 

            try
            {
                // Execute password change
                apiInstance.ExecutePasswordChange(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ExecutePasswordChange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecutePasswordChangeParams**](ExecutePasswordChangeParams.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthorizeduser"></a>
# **GetAuthorizedUser**
> User GetAuthorizedUser ()

Get the authorized user

Get the authorized user's data. Must pass the user's access_token. Only the authorized user can get his data, i.e. his access_token must be used. This service returns the user's password as 'XXXXX'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAuthorizedUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();

            try
            {
                // Get the authorized user
                User result = apiInstance.GetAuthorizedUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetAuthorizedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**User**](User.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getverificationstatus"></a>
# **GetVerificationStatus**
> VerificationStatusResource GetVerificationStatus (string userId)

Get a user's verification status

Get the verification status of the requested user. Must pass your global (i.e. client) access_token. Note that finAPI regards user identifiers case-insensitive.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVerificationStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User's identifier

            try
            {
                // Get a user's verification status
                VerificationStatusResource result = apiInstance.GetVerificationStatus(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetVerificationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User&#39;s identifier | 

### Return type

[**VerificationStatusResource**](VerificationStatusResource.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestpasswordchange"></a>
# **RequestPasswordChange**
> PasswordChangingResource RequestPasswordChange (RequestPasswordChangeParams body)

Request password change

Request password change for a user. Must pass your global (i.e. client) access_token. Note that finAPI regards user identifiers case-insensitive.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RequestPasswordChangeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new RequestPasswordChangeParams(); // RequestPasswordChangeParams |  (optional) 

            try
            {
                // Request password change
                PasswordChangingResource result = apiInstance.RequestPasswordChange(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.RequestPasswordChange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestPasswordChangeParams**](RequestPasswordChangeParams.md)|  | [optional] 

### Return type

[**PasswordChangingResource**](PasswordChangingResource.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifyuser"></a>
# **VerifyUser**
> void VerifyUser (string userId)

Verify a user

Verify a user. User verification is only required when your client does not have auto-verification enabled (see field 'isUserAutoVerificationEnabled' in Client Configuration Resource). Must pass your global (i.e. client) access_token. Note that finAPI regards user identifiers case-insensitive.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VerifyUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User's identifier

            try
            {
                // Verify a user
                apiInstance.VerifyUser(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.VerifyUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User&#39;s identifier | 

### Return type

void (empty response body)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

