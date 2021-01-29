# IO.Swagger.Api.MandatorAdministrationApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeClientCredentials**](MandatorAdministrationApi.md#changeclientcredentials) | **POST** /api/v1/mandatorAdmin/changeClientCredentials | Change client credentials
[**CreateIbanRules**](MandatorAdministrationApi.md#createibanrules) | **POST** /api/v1/mandatorAdmin/ibanRules | Create IBAN rules
[**CreateKeywordRules**](MandatorAdministrationApi.md#createkeywordrules) | **POST** /api/v1/mandatorAdmin/keywordRules | Create keyword rules
[**DeleteIbanRules**](MandatorAdministrationApi.md#deleteibanrules) | **POST** /api/v1/mandatorAdmin/ibanRules/delete | Delete IBAN rules
[**DeleteKeywordRules**](MandatorAdministrationApi.md#deletekeywordrules) | **POST** /api/v1/mandatorAdmin/keywordRules/delete | Delete keyword rules
[**DeleteUsers**](MandatorAdministrationApi.md#deleteusers) | **POST** /api/v1/mandatorAdmin/deleteUsers | Delete users
[**GetIbanRuleList**](MandatorAdministrationApi.md#getibanrulelist) | **GET** /api/v1/mandatorAdmin/ibanRules | Get IBAN rules
[**GetKeywordRuleList**](MandatorAdministrationApi.md#getkeywordrulelist) | **GET** /api/v1/mandatorAdmin/keywordRules | Get keyword rules
[**GetUserList**](MandatorAdministrationApi.md#getuserlist) | **GET** /api/v1/mandatorAdmin/getUserList | Get user list


<a name="changeclientcredentials"></a>
# **ChangeClientCredentials**
> void ChangeClientCredentials (ChangeClientCredentialsParams body)

Change client credentials

Change the client_secret for any of your clients, including the mandator admin client. Must pass the <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client'>mandator admin client</a>'s access_token. <br/><br/>NOTES:<br/>&bull; When you change a client's secret, then all of its existing access tokens will be revoked. User access tokens are not affected.<br/>&bull; finAPI is storing client secrets with a one-way encryption. A lost client secret can NOT be recovered.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeClientCredentialsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MandatorAdministrationApi();
            var body = new ChangeClientCredentialsParams(); // ChangeClientCredentialsParams | Parameters for changing client credentials

            try
            {
                // Change client credentials
                apiInstance.ChangeClientCredentials(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MandatorAdministrationApi.ChangeClientCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ChangeClientCredentialsParams**](ChangeClientCredentialsParams.md)| Parameters for changing client credentials | 

### Return type

void (empty response body)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createibanrules"></a>
# **CreateIbanRules**
> IbanRuleList CreateIbanRules (IbanRulesParams body)

Create IBAN rules

This service can be used to define IBAN rules for finAPI's transaction categorization system. The transaction categorization is run automatically whenever new transactions are imported, as well as when you call the services 'Check categorization' or 'Trigger categorization'. <br/><br/>An IBAN rule maps an IBAN to a certain category. finAPI's categorization system will pick the category as a candidate for any transaction whose counterpart's account matches the IBAN. It is not guaranteed though that this candidate will actually be applied, as there could be other categorization rules that have higher priority or that are an even better match for the transaction.<br/><br/>Note that the rules that you define here will be applied to all of your users. They have higher priority than finAPI's default categorization rules, but lower priority than user-specific rules (User-specific rules are created implicitly whenever a category is manually assigned to a transaction via the PATCH /transactions services). IBAN rules have a higher priority than keyword rules (see the 'Create keyword rules' service).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateIbanRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MandatorAdministrationApi();
            var body = new IbanRulesParams(); // IbanRulesParams | IBAN rule definitions

            try
            {
                // Create IBAN rules
                IbanRuleList result = apiInstance.CreateIbanRules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MandatorAdministrationApi.CreateIbanRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IbanRulesParams**](IbanRulesParams.md)| IBAN rule definitions | 

### Return type

[**IbanRuleList**](IbanRuleList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createkeywordrules"></a>
# **CreateKeywordRules**
> KeywordRuleList CreateKeywordRules (KeywordRulesParams body)

Create keyword rules

This service can be used to define keyword rules for finAPI's transaction categorization system. The transaction categorization is run automatically whenever new transactions are imported, as well as when you call the services 'Check categorization' or 'Trigger categorization'. <br/><br/>A keyword rule maps a set of keywords to a certain category. finAPI's categorization system will pick the category as a candidate for any transaction that contains at least one of the defined keywords in its purpose or counterpart information. It is not guaranteed though that this candidate will actually be applied, as there could be other categorization rules that have higher priority or that are an even better match for the transaction. If there are multiple keyword rules that match a transaction, finAPI will pick the one with the highest count of matched keywords.<br/><br/>Note that the rules that you define here will be applied to all of your users. They have higher priority than finAPI's default categorization rules, but lower priority than user-specific rules (User-specific rules are created implicitly whenever a category is manually assigned to a transaction via the PATCH /transactions services). Keyword rules have a lower priority than IBAN rules (see the 'Create IBAN rules' service).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateKeywordRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MandatorAdministrationApi();
            var body = new KeywordRulesParams(); // KeywordRulesParams | Keyword rule definitions

            try
            {
                // Create keyword rules
                KeywordRuleList result = apiInstance.CreateKeywordRules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MandatorAdministrationApi.CreateKeywordRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**KeywordRulesParams**](KeywordRulesParams.md)| Keyword rule definitions | 

### Return type

[**KeywordRuleList**](KeywordRuleList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteibanrules"></a>
# **DeleteIbanRules**
> IdentifierList DeleteIbanRules (IbanRuleIdentifiersParams body)

Delete IBAN rules

Delete one or multiple IBAN rules that you have previously created via the 'Create IBAN rules' service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteIbanRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MandatorAdministrationApi();
            var body = new IbanRuleIdentifiersParams(); // IbanRuleIdentifiersParams | List of IBAN rules identifiers.The maximum number of identifiers is 100.

            try
            {
                // Delete IBAN rules
                IdentifierList result = apiInstance.DeleteIbanRules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MandatorAdministrationApi.DeleteIbanRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IbanRuleIdentifiersParams**](IbanRuleIdentifiersParams.md)| List of IBAN rules identifiers.The maximum number of identifiers is 100. | 

### Return type

[**IdentifierList**](IdentifierList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletekeywordrules"></a>
# **DeleteKeywordRules**
> IdentifierList DeleteKeywordRules (KeywordRuleIdentifiersParams body)

Delete keyword rules

Delete one or multiple keyword rules that you have previously created via the 'Create keyword rules' service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteKeywordRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MandatorAdministrationApi();
            var body = new KeywordRuleIdentifiersParams(); // KeywordRuleIdentifiersParams | List of keyword rule identifiers.The maximum number of identifiers is 100.

            try
            {
                // Delete keyword rules
                IdentifierList result = apiInstance.DeleteKeywordRules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MandatorAdministrationApi.DeleteKeywordRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**KeywordRuleIdentifiersParams**](KeywordRuleIdentifiersParams.md)| List of keyword rule identifiers.The maximum number of identifiers is 100. | 

### Return type

[**IdentifierList**](IdentifierList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteusers"></a>
# **DeleteUsers**
> UserIdentifiersList DeleteUsers (UserIdentifiersParams body)

Delete users

Delete one or several users, which are specified by a given list of identifiers. Must pass the <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client' target='_blank'>mandator admin client</a>'s access_token. <br/><br/><b>NOTE</b>: finAPI may fail to delete one (or several, or all) of the specified users. A user cannot get deleted when his data is currently locked by an internal process (for instance, update of a bank connection or transactions categorization). The response contains the identifiers of all users that could not get deleted, and all users that could get deleted, separated in two lists. The mandator admin client can retry the request at a later time for the users who could not get deleted.<br/> Note that non-existing user identifiers will be ignored entirely, meaning that those identifiers will not appear in the response at all.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MandatorAdministrationApi();
            var body = new UserIdentifiersParams(); // UserIdentifiersParams | List of user identifiers

            try
            {
                // Delete users
                UserIdentifiersList result = apiInstance.DeleteUsers(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MandatorAdministrationApi.DeleteUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIdentifiersParams**](UserIdentifiersParams.md)| List of user identifiers | 

### Return type

[**UserIdentifiersList**](UserIdentifiersList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getibanrulelist"></a>
# **GetIbanRuleList**
> PageableIbanRuleList GetIbanRuleList (int? page, int? perPage)

Get IBAN rules

Returns all IBAN-based categorization rules that you have defined for your users via the 'Create IBAN rules' service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIbanRuleListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MandatorAdministrationApi();
            var page = 56;  // int? | Result page that you want to retrieve (optional)  (default to 1)
            var perPage = 56;  // int? | Maximum number of records per page. By default it's 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. (optional)  (default to 20)

            try
            {
                // Get IBAN rules
                PageableIbanRuleList result = apiInstance.GetIbanRuleList(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MandatorAdministrationApi.GetIbanRuleList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Result page that you want to retrieve | [optional] [default to 1]
 **perPage** | **int?**| Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. | [optional] [default to 20]

### Return type

[**PageableIbanRuleList**](PageableIbanRuleList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkeywordrulelist"></a>
# **GetKeywordRuleList**
> PageableKeywordRuleList GetKeywordRuleList (int? page, int? perPage)

Get keyword rules

Returns all keyword-based categorization rules that you have defined for your users via the 'Create keyword rules' service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetKeywordRuleListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MandatorAdministrationApi();
            var page = 56;  // int? | Result page that you want to retrieve (optional)  (default to 1)
            var perPage = 56;  // int? | Maximum number of records per page. By default it's 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. (optional)  (default to 20)

            try
            {
                // Get keyword rules
                PageableKeywordRuleList result = apiInstance.GetKeywordRuleList(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MandatorAdministrationApi.GetKeywordRuleList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Result page that you want to retrieve | [optional] [default to 1]
 **perPage** | **int?**| Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. | [optional] [default to 20]

### Return type

[**PageableKeywordRuleList**](PageableKeywordRuleList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserlist"></a>
# **GetUserList**
> PageableUserInfoList GetUserList (string minRegistrationDate, string maxRegistrationDate, string minDeletionDate, string maxDeletionDate, string minLastActiveDate, string maxLastActiveDate, bool? includeMonthlyStats, string monthlyStatsStartDate, string monthlyStatsEndDate, int? minBankConnectionCountInMonthlyStats, string userId, bool? isDeleted, bool? isLocked, int? page, int? perPage, List<string> order)

Get user list

<p>Get a list of the users of the mandator that is authorized by the access_token. Must pass the <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client' target='_blank'>mandator admin client</a>'s access_token. You can set optional search criteria to get only those users that you are interested in. If you do not specify any search criteria, then this service functions as a 'get all' service.</p><p>Note that the original user id is no longer available in finAPI once a user has been deleted. Because of this, the userId of deleted users will be a distorted version of the original userId. For example, if the deleted user's id was originally 'user', then this service will return 'uXXr' as the userId.</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MandatorAdministrationApi();
            var minRegistrationDate = minRegistrationDate_example;  // string | Lower bound for a user's registration date, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only users whose 'registrationDate' is equal to or later than the given date will be regarded. (optional) 
            var maxRegistrationDate = maxRegistrationDate_example;  // string | Upper bound for a user's registration date, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only users whose 'registrationDate' is equal to or earlier than the given date will be regarded. (optional) 
            var minDeletionDate = minDeletionDate_example;  // string | Lower bound for a user's deletion date, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only users whose 'deletionDate' is not null, and is equal to or later than the given date will be regarded. (optional) 
            var maxDeletionDate = maxDeletionDate_example;  // string | Upper bound for a user's deletion date, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only users whose 'deletionDate' is null, or is equal to or earlier than the given date will be regarded. (optional) 
            var minLastActiveDate = minLastActiveDate_example;  // string | Lower bound for a user's last active date, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only users whose 'lastActiveDate' is not null, and is equal to or later than the given date will be regarded. (optional) 
            var maxLastActiveDate = maxLastActiveDate_example;  // string | Upper bound for a user's last active date, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only users whose 'lastActiveDate' is null, or is equal to or earlier than the given date will be regarded. (optional) 
            var includeMonthlyStats = true;  // bool? | Whether to include the 'monthlyStats' for the returned users. If not specified, then the field defaults to 'false'. (optional)  (default to false)
            var monthlyStatsStartDate = monthlyStatsStartDate_example;  // string | Minimum bound for the monthly stats (=oldest month that should be included). Must be passed in the format 'YYYY-MM'. If not specified, then the monthly stats will go back up to the first month in which the user existed (date of the user's registration). Note that this field is only regarded if 'includeMonthlyStats' = true. (optional) 
            var monthlyStatsEndDate = monthlyStatsEndDate_example;  // string | Maximum bound for the monthly stats (=latest month that should be included). Must be passed in the format 'YYYY-MM'. If not specified, then the monthly stats will go up to either the current month (for active users), or up to the month of deletion (for deleted users). Note that this field is only regarded if  'includeMonthlyStats' = true. (optional) 
            var minBankConnectionCountInMonthlyStats = 56;  // int? | A value of X means that the service will return only those users which had at least X bank connections imported at any time within the returned monthly stats set. This field is only regarded when 'includeMonthlyStats' is set to 'true'. The default value for this field is 0. (optional)  (default to 0)
            var userId = userId_example;  // string | The identifier of a user to search for. If specified, then only the user with the given id will be regarded. If no user can be found for the passed userId (because the user was deleted or his username was misspelled), then the result list will be empty. (optional) 
            var isDeleted = true;  // bool? | If NOT specified, then the service will regard both active and deleted users in the search. If set to 'true', then ONLY deleted users will be regarded. If set to 'false', then ONLY active users will be regarded. (optional) 
            var isLocked = true;  // bool? | If NOT specified, then the service will regard both locked and not locked users in the search. If set to 'true', then ONLY locked users will be regarded. If set to 'false', then ONLY not locked users will be regarded. (optional) 
            var page = 56;  // int? | Result page that you want to retrieve (optional)  (default to 1)
            var perPage = 56;  // int? | Maximum number of records per page. By default it's 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. (optional)  (default to 20)
            var order = new List<string>(); // List<string> | Determines the order of the results. You can order the results by 'userId'. The default order for this service is 'userId,asc'. The general format is: 'property[,asc|desc]', with 'asc' being the default value.  (optional) 

            try
            {
                // Get user list
                PageableUserInfoList result = apiInstance.GetUserList(minRegistrationDate, maxRegistrationDate, minDeletionDate, maxDeletionDate, minLastActiveDate, maxLastActiveDate, includeMonthlyStats, monthlyStatsStartDate, monthlyStatsEndDate, minBankConnectionCountInMonthlyStats, userId, isDeleted, isLocked, page, perPage, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MandatorAdministrationApi.GetUserList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **minRegistrationDate** | **string**| Lower bound for a user&#39;s registration date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;registrationDate&#39; is equal to or later than the given date will be regarded. | [optional] 
 **maxRegistrationDate** | **string**| Upper bound for a user&#39;s registration date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;registrationDate&#39; is equal to or earlier than the given date will be regarded. | [optional] 
 **minDeletionDate** | **string**| Lower bound for a user&#39;s deletion date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;deletionDate&#39; is not null, and is equal to or later than the given date will be regarded. | [optional] 
 **maxDeletionDate** | **string**| Upper bound for a user&#39;s deletion date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;deletionDate&#39; is null, or is equal to or earlier than the given date will be regarded. | [optional] 
 **minLastActiveDate** | **string**| Lower bound for a user&#39;s last active date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;lastActiveDate&#39; is not null, and is equal to or later than the given date will be regarded. | [optional] 
 **maxLastActiveDate** | **string**| Upper bound for a user&#39;s last active date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only users whose &#39;lastActiveDate&#39; is null, or is equal to or earlier than the given date will be regarded. | [optional] 
 **includeMonthlyStats** | **bool?**| Whether to include the &#39;monthlyStats&#39; for the returned users. If not specified, then the field defaults to &#39;false&#39;. | [optional] [default to false]
 **monthlyStatsStartDate** | **string**| Minimum bound for the monthly stats (&#x3D;oldest month that should be included). Must be passed in the format &#39;YYYY-MM&#39;. If not specified, then the monthly stats will go back up to the first month in which the user existed (date of the user&#39;s registration). Note that this field is only regarded if &#39;includeMonthlyStats&#39; &#x3D; true. | [optional] 
 **monthlyStatsEndDate** | **string**| Maximum bound for the monthly stats (&#x3D;latest month that should be included). Must be passed in the format &#39;YYYY-MM&#39;. If not specified, then the monthly stats will go up to either the current month (for active users), or up to the month of deletion (for deleted users). Note that this field is only regarded if  &#39;includeMonthlyStats&#39; &#x3D; true. | [optional] 
 **minBankConnectionCountInMonthlyStats** | **int?**| A value of X means that the service will return only those users which had at least X bank connections imported at any time within the returned monthly stats set. This field is only regarded when &#39;includeMonthlyStats&#39; is set to &#39;true&#39;. The default value for this field is 0. | [optional] [default to 0]
 **userId** | **string**| The identifier of a user to search for. If specified, then only the user with the given id will be regarded. If no user can be found for the passed userId (because the user was deleted or his username was misspelled), then the result list will be empty. | [optional] 
 **isDeleted** | **bool?**| If NOT specified, then the service will regard both active and deleted users in the search. If set to &#39;true&#39;, then ONLY deleted users will be regarded. If set to &#39;false&#39;, then ONLY active users will be regarded. | [optional] 
 **isLocked** | **bool?**| If NOT specified, then the service will regard both locked and not locked users in the search. If set to &#39;true&#39;, then ONLY locked users will be regarded. If set to &#39;false&#39;, then ONLY not locked users will be regarded. | [optional] 
 **page** | **int?**| Result page that you want to retrieve | [optional] [default to 1]
 **perPage** | **int?**| Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. | [optional] [default to 20]
 **order** | [**List<string>**](string.md)| Determines the order of the results. You can order the results by &#39;userId&#39;. The default order for this service is &#39;userId,asc&#39;. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value.  | [optional] 

### Return type

[**PageableUserInfoList**](PageableUserInfoList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

