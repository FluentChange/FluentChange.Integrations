# IO.Swagger.Api.AccountsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAccount**](AccountsApi.md#deleteaccount) | **DELETE** /api/v1/accounts/{id} | Delete an account
[**DeleteAllAccounts**](AccountsApi.md#deleteallaccounts) | **DELETE** /api/v1/accounts | Delete all accounts
[**EditAccount**](AccountsApi.md#editaccount) | **PATCH** /api/v1/accounts/{id} | Edit an account
[**GetAccount**](AccountsApi.md#getaccount) | **GET** /api/v1/accounts/{id} | Get an account
[**GetAndSearchAllAccounts**](AccountsApi.md#getandsearchallaccounts) | **GET** /api/v1/accounts | Get and search all accounts
[**GetDailyBalances**](AccountsApi.md#getdailybalances) | **GET** /api/v1/accounts/dailyBalances | Get daily balances


<a name="deleteaccount"></a>
# **DeleteAccount**
> void DeleteAccount (long? id)

Delete an account

Delete a single bank account of the user that is authorized by the access_token, including its transactions and balance data. Must pass the account's identifier and the user's access_token.<br/><br/>Notes: <br/>- You cannot delete an account while the bank connection that it relates to is currently in the process of import, update, or transactions categorization. <br/>- When the last remaining account of a bank connection gets deleted, then the bank connection itself will get deleted as well! <br/>- All notification rules that are connected to the account will get adjusted so that they no longer have this account listed. Notification rules that are connected to just this account (and no other accounts) will get deleted altogether.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAccountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var id = 789;  // long? | Identifier of the account to delete

            try
            {
                // Delete an account
                apiInstance.DeleteAccount(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Identifier of the account to delete | 

### Return type

void (empty response body)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteallaccounts"></a>
# **DeleteAllAccounts**
> IdentifierList DeleteAllAccounts ()

Delete all accounts

Delete all accounts of the user that is authorized by the access_token, including all transactions and balance data. Must pass the user's access_token.<br/><br/>Notes: <br/>- Deleting all of the user's accounts also deletes all of his bank connections. <br/>- All notification rules that are connected to any specific accounts will get deleted as well. <br/>- If at least one of the user's bank connections in currently in the process of import, update, or transactions categorization, then this service will perform no action at all.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAllAccountsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();

            try
            {
                // Delete all accounts
                IdentifierList result = apiInstance.DeleteAllAccounts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteAllAccounts: " + e.Message );
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

<a name="editaccount"></a>
# **EditAccount**
> Account EditAccount (long? id, AccountParams body)

Edit an account

Change the name and/or the type and/or the 'isNew' flag of a single bank account of the user that is authorized by the access_token. Must pass the account's identifier, the account's new name and/or type and/or 'isNew' flag, and the user's access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditAccountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var id = 789;  // long? | Identifier of the account to edit
            var body = new AccountParams(); // AccountParams | New account name and/or type and/or 'isNew' flag (optional) 

            try
            {
                // Edit an account
                Account result = apiInstance.EditAccount(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.EditAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Identifier of the account to edit | 
 **body** | [**AccountParams**](AccountParams.md)| New account name and/or type and/or &#39;isNew&#39; flag | [optional] 

### Return type

[**Account**](Account.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccount"></a>
# **GetAccount**
> Account GetAccount (long? id)

Get an account

Get a single bank account of the user that is authorized by the access_token. Must pass the account's identifier and the user's access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var id = 789;  // long? | Identifier of requested account

            try
            {
                // Get an account
                Account result = apiInstance.GetAccount(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Identifier of requested account | 

### Return type

[**Account**](Account.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getandsearchallaccounts"></a>
# **GetAndSearchAllAccounts**
> AccountList GetAndSearchAllAccounts (List<long?> ids, string search, List<string> accountTypes, List<long?> bankConnectionIds, string minLastSuccessfulUpdate, string maxLastSuccessfulUpdate, decimal? minBalance, decimal? maxBalance)

Get and search all accounts

Get bank accounts of the user that is authorized by the access_token. Must pass the user's access_token. You can set optional search criteria to get only those bank accounts that you are interested in. If you do not specify any search criteria, then this service functions as a 'get all' service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAndSearchAllAccountsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var ids = new List<long?>(); // List<long?> | A comma-separated list of account identifiers. If specified, then only accounts whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. (optional) 
            var search = search_example;  // string | If specified, then only those accounts will be contained in the result whose 'accountName', 'iban', 'accountNumber' or 'subAccountNumber' contains the given search string (the matching works case-insensitive). If no accounts contain the search string in any of these fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for an account to get included into the result. (optional) 
            var accountTypes = new List<string>(); // List<string> | A comma-separated list of account types. If specified, then only accounts that relate to the given types will be regarded. If not specified, then all accounts will be regarded. (optional) 
            var bankConnectionIds = new List<long?>(); // List<long?> | A comma-separated list of bank connection identifiers. If specified, then only accounts that relate to the given bank connections will be regarded. If not specified, then all accounts will be regarded. (optional) 
            var minLastSuccessfulUpdate = minLastSuccessfulUpdate_example;  // string | Lower bound for a account's last successful update date, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only accounts whose 'lastSuccessfulUpdate' is equal to or later than the given date will be regarded. (optional) 
            var maxLastSuccessfulUpdate = maxLastSuccessfulUpdate_example;  // string | Upper bound for a account's last successful update date, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only accounts whose 'lastSuccessfulUpdate' is equal to or earlier than the given date will be regarded. (optional) 
            var minBalance = 8.14;  // decimal? | If specified, then only accounts whose balance is equal to or greater than the given balance will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95 (optional) 
            var maxBalance = 8.14;  // decimal? | If specified, then only accounts whose balance is equal to or less than the given balance will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95 (optional) 

            try
            {
                // Get and search all accounts
                AccountList result = apiInstance.GetAndSearchAllAccounts(ids, search, accountTypes, bankConnectionIds, minLastSuccessfulUpdate, maxLastSuccessfulUpdate, minBalance, maxBalance);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAndSearchAllAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List<long?>**](long?.md)| A comma-separated list of account identifiers. If specified, then only accounts whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. | [optional] 
 **search** | **string**| If specified, then only those accounts will be contained in the result whose &#39;accountName&#39;, &#39;iban&#39;, &#39;accountNumber&#39; or &#39;subAccountNumber&#39; contains the given search string (the matching works case-insensitive). If no accounts contain the search string in any of these fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for an account to get included into the result. | [optional] 
 **accountTypes** | [**List<string>**](string.md)| A comma-separated list of account types. If specified, then only accounts that relate to the given types will be regarded. If not specified, then all accounts will be regarded. | [optional] 
 **bankConnectionIds** | [**List<long?>**](long?.md)| A comma-separated list of bank connection identifiers. If specified, then only accounts that relate to the given bank connections will be regarded. If not specified, then all accounts will be regarded. | [optional] 
 **minLastSuccessfulUpdate** | **string**| Lower bound for a account&#39;s last successful update date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only accounts whose &#39;lastSuccessfulUpdate&#39; is equal to or later than the given date will be regarded. | [optional] 
 **maxLastSuccessfulUpdate** | **string**| Upper bound for a account&#39;s last successful update date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only accounts whose &#39;lastSuccessfulUpdate&#39; is equal to or earlier than the given date will be regarded. | [optional] 
 **minBalance** | **decimal?**| If specified, then only accounts whose balance is equal to or greater than the given balance will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95 | [optional] 
 **maxBalance** | **decimal?**| If specified, then only accounts whose balance is equal to or less than the given balance will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95 | [optional] 

### Return type

[**AccountList**](AccountList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdailybalances"></a>
# **GetDailyBalances**
> DailyBalanceList GetDailyBalances (List<long?> accountIds, string startDate, string endDate, bool? withProjection, int? page, int? perPage, List<string> order)

Get daily balances

Returns the user's daily balances for a given period and a set of specified accounts (or all accounts, if none are specified). The daily balances are calculated by finAPI and are based on the current balances of the regarded accounts.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDailyBalancesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var accountIds = new List<long?>(); // List<long?> | A comma-separated list of (non-security) account identifiers. If no accounts are specified, all (non-security) accounts of the user are regarded. (optional) 
            var startDate = startDate_example;  // string | A string in the format 'YYYY-MM-DD'. Note that the requested date range [startDate..endDate] may not exceed 1 year (366 days - considering Leap Years too).If startDate is not specified, it defaults to the endDate minus one month. (optional) 
            var endDate = endDate_example;  // string | A string in the format 'YYYY-MM-DD'. Note that the requested date range [startDate..endDate] may not exceed 1 year (366 days - considering Leap Years too). If endDate is not specified, it defaults to today's date. (optional) 
            var withProjection = true;  // bool? | Whether finAPI should project the first and last actually existing balance of an account into the past and future. When passing 'true', then the result will always contain a daily balance for every day of the entire requested date range, even for days before the first actually existing balance, resp. after the last actually existing balance. Those days will have the same balance as the day of the first actual balance, resp. last actual balance, i.e. the first/last balance will be infinitely projected into the past/the future. When passing 'false', then the result will contain daily balances only from the day on where the first actual balance exists for any of the regarded accounts, and only up to the day where the last actual balance exists for any of the regarded accounts. Note that when in this case there are no actual balances within the requested date range, then an empty array will be returned. Default value for this parameter is 'true'. (optional)  (default to true)
            var page = 56;  // int? | Result page that you want to retrieve. (optional)  (default to 1)
            var perPage = 56;  // int? | Maximum number of records per page. By default it's 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. (optional)  (default to 20)
            var order = new List<string>(); // List<string> | Determines the order of the results. You can order the results by 'date', 'balance', 'income' or 'spending'. The default order for this service is 'date,asc'. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: '/accounts/dailyBalances?order=date,desc&order=balance,asc' will return daily balances ordered by 'date' (descending), where items with the same 'date' are ordered by 'balance' (ascending). The general format is: 'property[,asc|desc]', with 'asc' being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC).  (optional) 

            try
            {
                // Get daily balances
                DailyBalanceList result = apiInstance.GetDailyBalances(accountIds, startDate, endDate, withProjection, page, perPage, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetDailyBalances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountIds** | [**List<long?>**](long?.md)| A comma-separated list of (non-security) account identifiers. If no accounts are specified, all (non-security) accounts of the user are regarded. | [optional] 
 **startDate** | **string**| A string in the format &#39;YYYY-MM-DD&#39;. Note that the requested date range [startDate..endDate] may not exceed 1 year (366 days - considering Leap Years too).If startDate is not specified, it defaults to the endDate minus one month. | [optional] 
 **endDate** | **string**| A string in the format &#39;YYYY-MM-DD&#39;. Note that the requested date range [startDate..endDate] may not exceed 1 year (366 days - considering Leap Years too). If endDate is not specified, it defaults to today&#39;s date. | [optional] 
 **withProjection** | **bool?**| Whether finAPI should project the first and last actually existing balance of an account into the past and future. When passing &#39;true&#39;, then the result will always contain a daily balance for every day of the entire requested date range, even for days before the first actually existing balance, resp. after the last actually existing balance. Those days will have the same balance as the day of the first actual balance, resp. last actual balance, i.e. the first/last balance will be infinitely projected into the past/the future. When passing &#39;false&#39;, then the result will contain daily balances only from the day on where the first actual balance exists for any of the regarded accounts, and only up to the day where the last actual balance exists for any of the regarded accounts. Note that when in this case there are no actual balances within the requested date range, then an empty array will be returned. Default value for this parameter is &#39;true&#39;. | [optional] [default to true]
 **page** | **int?**| Result page that you want to retrieve. | [optional] [default to 1]
 **perPage** | **int?**| Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. | [optional] [default to 20]
 **order** | [**List<string>**](string.md)| Determines the order of the results. You can order the results by &#39;date&#39;, &#39;balance&#39;, &#39;income&#39; or &#39;spending&#39;. The default order for this service is &#39;date,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/accounts/dailyBalances?order&#x3D;date,desc&amp;order&#x3D;balance,asc&#39; will return daily balances ordered by &#39;date&#39; (descending), where items with the same &#39;date&#39; are ordered by &#39;balance&#39; (ascending). The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC).  | [optional] 

### Return type

[**DailyBalanceList**](DailyBalanceList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

