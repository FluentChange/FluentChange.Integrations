# IO.Swagger.Api.NotificationRulesApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNotificationRule**](NotificationRulesApi.md#createnotificationrule) | **POST** /api/v1/notificationRules | Create a new notification rule
[**DeleteAllNotificationRules**](NotificationRulesApi.md#deleteallnotificationrules) | **DELETE** /api/v1/notificationRules | Delete all notification rules
[**DeleteNotificationRule**](NotificationRulesApi.md#deletenotificationrule) | **DELETE** /api/v1/notificationRules/{id} | Delete a notification rule
[**GetAndSearchAllNotificationRules**](NotificationRulesApi.md#getandsearchallnotificationrules) | **GET** /api/v1/notificationRules | Get and search all notification rules
[**GetNotificationRule**](NotificationRulesApi.md#getnotificationrule) | **GET** /api/v1/notificationRules/{id} | Get a notification rule


<a name="createnotificationrule"></a>
# **CreateNotificationRule**
> NotificationRule CreateNotificationRule (NotificationRuleParams body)

Create a new notification rule

Create a new notification rule for a specific user. Must pass the user's access_token.<br/><br/>Setting up notification rules for a user allows your client application to get notified about changes in the user's data, e.g. when new transactions were downloaded, an account's balance has changed, or the user's banking credentials are no longer correct. Note that currently, this feature is implemented only for finAPI's automatic batch update, i.e. notification rules are only relevant when the user has activated the automatic updates (and when the automatic batch update is activated in general for your client).<br/><br/>There are different kinds of notification rules. The kind of a rule is depicted by the 'triggerEvent'. The trigger event specifies what data you have to pass when creating a rule (specifically, the contents of the 'params' field), on which events finAPI will send notifications to your client application, as well as what data is contained in those notifications. The specifics of the different trigger events are documented in the following article on our Dev Portal: <a href='https://finapi.zendesk.com/hc/en-us/articles/232324608-How-to-create-notification-rules-and-receive-notifications' target='_blank'>How to create notification rules and receive notifications</a>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateNotificationRuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationRulesApi();
            var body = new NotificationRuleParams(); // NotificationRuleParams | Notification rule parameters

            try
            {
                // Create a new notification rule
                NotificationRule result = apiInstance.CreateNotificationRule(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationRulesApi.CreateNotificationRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NotificationRuleParams**](NotificationRuleParams.md)| Notification rule parameters | 

### Return type

[**NotificationRule**](NotificationRule.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteallnotificationrules"></a>
# **DeleteAllNotificationRules**
> IdentifierList DeleteAllNotificationRules ()

Delete all notification rules

Delete all notification rules of the user that is authorized by the access_token. Must pass the user's access_token. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAllNotificationRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationRulesApi();

            try
            {
                // Delete all notification rules
                IdentifierList result = apiInstance.DeleteAllNotificationRules();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationRulesApi.DeleteAllNotificationRules: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**IdentifierList**](IdentifierList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenotificationrule"></a>
# **DeleteNotificationRule**
> void DeleteNotificationRule (long? id)

Delete a notification rule

Delete a single notification rule of the user that is authorized by the access_token. Must pass the notification rule's identifier and the user's access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteNotificationRuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationRulesApi();
            var id = 789;  // long? | Identifier of the notification rule to delete

            try
            {
                // Delete a notification rule
                apiInstance.DeleteNotificationRule(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationRulesApi.DeleteNotificationRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Identifier of the notification rule to delete | 

### Return type

void (empty response body)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getandsearchallnotificationrules"></a>
# **GetAndSearchAllNotificationRules**
> NotificationRuleList GetAndSearchAllNotificationRules (List<long?> ids, string triggerEvent, bool? includeDetails)

Get and search all notification rules

Get notification rules of the user that is authorized by the access_token. Must pass the user's access_token. You can set optional search criteria to get only those notification rules that you are interested in. If you do not specify any search criteria, then this service functions as a 'get all' service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAndSearchAllNotificationRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationRulesApi();
            var ids = new List<long?>(); // List<long?> | A comma-separated list of notification rule identifiers. If specified, then only notification rules whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. (optional) 
            var triggerEvent = triggerEvent_example;  // string | If specified, then only notification rules with given trigger event will be regarded. (optional) 
            var includeDetails = true;  // bool? | If specified, then only notification rules that include or not include details will be regarded. (optional) 

            try
            {
                // Get and search all notification rules
                NotificationRuleList result = apiInstance.GetAndSearchAllNotificationRules(ids, triggerEvent, includeDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationRulesApi.GetAndSearchAllNotificationRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List<long?>**](long?.md)| A comma-separated list of notification rule identifiers. If specified, then only notification rules whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. | [optional] 
 **triggerEvent** | **string**| If specified, then only notification rules with given trigger event will be regarded. | [optional] 
 **includeDetails** | **bool?**| If specified, then only notification rules that include or not include details will be regarded. | [optional] 

### Return type

[**NotificationRuleList**](NotificationRuleList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotificationrule"></a>
# **GetNotificationRule**
> NotificationRule GetNotificationRule (long? id)

Get a notification rule

Get a single notification rule of the user that is authorized by the access_token. Must pass the notification rule's identifier and the user's access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNotificationRuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationRulesApi();
            var id = 789;  // long? | Identifier of requested notification rule

            try
            {
                // Get a notification rule
                NotificationRule result = apiInstance.GetNotificationRule(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationRulesApi.GetNotificationRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Identifier of requested notification rule | 

### Return type

[**NotificationRule**](NotificationRule.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

