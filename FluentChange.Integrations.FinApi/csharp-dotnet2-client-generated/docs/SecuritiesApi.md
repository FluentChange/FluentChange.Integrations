# IO.Swagger.Api.SecuritiesApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAndSearchAllSecurities**](SecuritiesApi.md#getandsearchallsecurities) | **GET** /api/v1/securities | Get and search all securities
[**GetSecurity**](SecuritiesApi.md#getsecurity) | **GET** /api/v1/securities/{id} | Get a security


<a name="getandsearchallsecurities"></a>
# **GetAndSearchAllSecurities**
> PageableSecurityList GetAndSearchAllSecurities (List<long?> ids, string search, List<long?> accountIds, int? page, int? perPage, List<string> order)

Get and search all securities

Get securities of the user that is authorized by the access_token. Must pass the user's access_token. You can set optional search criteria to get only those securities that you are interested in. If you do not specify any search criteria, then this service functions as a 'get all' service.<p>Note: Whenever a security account is being updated, its security positions will be internally re-created, meaning that the identifier of a security position might change over time.</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAndSearchAllSecuritiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecuritiesApi();
            var ids = new List<long?>(); // List<long?> | A comma-separated list of security identifiers. If specified, then only securities whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. (optional) 
            var search = search_example;  // string | If specified, then only those securities will be contained in the result whose 'name', 'isin' or 'wkn' contains the given search string (the matching works case-insensitive). If no securities contain the search string in any of these fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for a security to get included into the result. (optional) 
            var accountIds = new List<long?>(); // List<long?> | Comma-separated list of identifiers of accounts (optional) 
            var page = 56;  // int? | Result page that you want to retrieve. (optional)  (default to 1)
            var perPage = 56;  // int? | Maximum number of records per page. By default it's 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. (optional)  (default to 20)
            var order = new List<string>(); // List<string> | Determines the order of the results. You can order the results by next fields: 'id', 'name', 'isin', 'wkn', 'quote', 'quantityNominal', 'marketValue' and 'entryQuote'. The default order for all services is 'id,asc'. You can also order by multiple properties. In that case the order of the parameters passed is important. The general format is: 'property[,asc|desc]', with 'asc' being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC).  (optional) 

            try
            {
                // Get and search all securities
                PageableSecurityList result = apiInstance.GetAndSearchAllSecurities(ids, search, accountIds, page, perPage, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecuritiesApi.GetAndSearchAllSecurities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List<long?>**](long?.md)| A comma-separated list of security identifiers. If specified, then only securities whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. | [optional] 
 **search** | **string**| If specified, then only those securities will be contained in the result whose &#39;name&#39;, &#39;isin&#39; or &#39;wkn&#39; contains the given search string (the matching works case-insensitive). If no securities contain the search string in any of these fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for a security to get included into the result. | [optional] 
 **accountIds** | [**List<long?>**](long?.md)| Comma-separated list of identifiers of accounts | [optional] 
 **page** | **int?**| Result page that you want to retrieve. | [optional] [default to 1]
 **perPage** | **int?**| Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. | [optional] [default to 20]
 **order** | [**List<string>**](string.md)| Determines the order of the results. You can order the results by next fields: &#39;id&#39;, &#39;name&#39;, &#39;isin&#39;, &#39;wkn&#39;, &#39;quote&#39;, &#39;quantityNominal&#39;, &#39;marketValue&#39; and &#39;entryQuote&#39;. The default order for all services is &#39;id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC).  | [optional] 

### Return type

[**PageableSecurityList**](PageableSecurityList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsecurity"></a>
# **GetSecurity**
> Security GetSecurity (long? id)

Get a security

Get a single security for a specific user. Must pass the security's identifier and the user's access_token. <p>Note: Whenever a security account is being updated, its security positions will be internally re-created, meaning that the identifier of a security position might change over time.</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSecurityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecuritiesApi();
            var id = 789;  // long? | Security identifier

            try
            {
                // Get a security
                Security result = apiInstance.GetSecurity(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecuritiesApi.GetSecurity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Security identifier | 

### Return type

[**Security**](Security.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

