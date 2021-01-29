# IO.Swagger.Api.BanksApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAndSearchAllBanks**](BanksApi.md#getandsearchallbanks) | **GET** /api/v1/banks | Get and search all banks
[**GetBank**](BanksApi.md#getbank) | **GET** /api/v1/banks/{id} | Get a bank


<a name="getandsearchallbanks"></a>
# **GetAndSearchAllBanks**
> PageableBankList GetAndSearchAllBanks (List<long?> ids, string search, List<string> supportedInterfaces, List<string> location, List<long?> tppAuthenticationGroupIds, bool? isTestBank, int? page, int? perPage, List<string> order)

Get and search all banks

Get and search banks from finAPI's database of banks. Must pass the authorized user's access_token, or your client's access_token. You can set optional search criteria to get only those banks that you are interested in. If you do not specify any search criteria, then this service functions as a 'get all' service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAndSearchAllBanksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BanksApi();
            var ids = new List<long?>(); // List<long?> | A comma-separated list of bank identifiers. If specified, then only banks whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. (optional) 
            var search = search_example;  // string | If specified, then only those banks will be contained in the result whose 'name', 'blz', 'bic' or 'city' contains the given search string (the matching works case-insensitive). If no banks contain the search string in any of the regarded fields, then the result will be an empty list. Note that you may also pass an IBAN in this field, in which case finAPI will try to detect the related bank and regard only this bank for the search (The IBAN may not contain spaces). Also note: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must apply to a bank in order for it to get included into the result. (optional) 
            var supportedInterfaces = new List<string>(); // List<string> | Comma-separated list of bank interfaces. Possible values: FINTS_SERVER,WEB_SCRAPER,XS2A. If this parameter is specified, then all the banks that support at least one of the given interfaces will be returned. Note that this does NOT imply that those interfaces must be the only ones that are supported by a bank. (optional) 
            var location = new List<string>(); // List<string> | Comma-separated list of two-letter country codes (ISO 3166 ALPHA-2), for example: DE, AT. If set, then only those banks will be regarded in the search that are located in the specified countries. Notes: Banks which do not have a location set (i.e. international institutes) will ALWAYS be regarded in the search, independent of what you specify for this field. When you pass a country code that doesn't exist in the ISO 3166 ALPHA-2 standard, then the service will respond with 400 BAD_REQUEST. (optional) 
            var tppAuthenticationGroupIds = new List<long?>(); // List<long?> | A comma-separated list of TPP authentication group identifiers. If specified, then only banks who have at least one interface belonging to one of the given groups will be regarded. The maximum number of identifiers is 1000. (optional) 
            var isTestBank = true;  // bool? | If specified, then only those banks will be regarded that have the given value (true or false) for their 'isTestBank' field. (optional) 
            var page = 56;  // int? | Result page that you want to retrieve. (optional)  (default to 1)
            var perPage = 56;  // int? | Maximum number of records per page. By default it's 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. (optional)  (default to 20)
            var order = new List<string>(); // List<string> | Determines the order of the results. You can order the results by 'id', 'name', 'blz', 'bic' or 'popularity'. The default order for all services is 'id,asc'. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: '/banks?order=name,desc&order=id,asc' will return banks ordered by 'name' (descending), where banks with the same 'name' are ordered by 'id' (ascending). The general format is: 'property[,asc|desc]', with 'asc' being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC).  (optional) 

            try
            {
                // Get and search all banks
                PageableBankList result = apiInstance.GetAndSearchAllBanks(ids, search, supportedInterfaces, location, tppAuthenticationGroupIds, isTestBank, page, perPage, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BanksApi.GetAndSearchAllBanks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List<long?>**](long?.md)| A comma-separated list of bank identifiers. If specified, then only banks whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. | [optional] 
 **search** | **string**| If specified, then only those banks will be contained in the result whose &#39;name&#39;, &#39;blz&#39;, &#39;bic&#39; or &#39;city&#39; contains the given search string (the matching works case-insensitive). If no banks contain the search string in any of the regarded fields, then the result will be an empty list. Note that you may also pass an IBAN in this field, in which case finAPI will try to detect the related bank and regard only this bank for the search (The IBAN may not contain spaces). Also note: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must apply to a bank in order for it to get included into the result. | [optional] 
 **supportedInterfaces** | [**List<string>**](string.md)| Comma-separated list of bank interfaces. Possible values: FINTS_SERVER,WEB_SCRAPER,XS2A. If this parameter is specified, then all the banks that support at least one of the given interfaces will be returned. Note that this does NOT imply that those interfaces must be the only ones that are supported by a bank. | [optional] 
 **location** | [**List<string>**](string.md)| Comma-separated list of two-letter country codes (ISO 3166 ALPHA-2), for example: DE, AT. If set, then only those banks will be regarded in the search that are located in the specified countries. Notes: Banks which do not have a location set (i.e. international institutes) will ALWAYS be regarded in the search, independent of what you specify for this field. When you pass a country code that doesn&#39;t exist in the ISO 3166 ALPHA-2 standard, then the service will respond with 400 BAD_REQUEST. | [optional] 
 **tppAuthenticationGroupIds** | [**List<long?>**](long?.md)| A comma-separated list of TPP authentication group identifiers. If specified, then only banks who have at least one interface belonging to one of the given groups will be regarded. The maximum number of identifiers is 1000. | [optional] 
 **isTestBank** | **bool?**| If specified, then only those banks will be regarded that have the given value (true or false) for their &#39;isTestBank&#39; field. | [optional] 
 **page** | **int?**| Result page that you want to retrieve. | [optional] [default to 1]
 **perPage** | **int?**| Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. | [optional] [default to 20]
 **order** | [**List<string>**](string.md)| Determines the order of the results. You can order the results by &#39;id&#39;, &#39;name&#39;, &#39;blz&#39;, &#39;bic&#39; or &#39;popularity&#39;. The default order for all services is &#39;id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/banks?order&#x3D;name,desc&amp;order&#x3D;id,asc&#39; will return banks ordered by &#39;name&#39; (descending), where banks with the same &#39;name&#39; are ordered by &#39;id&#39; (ascending). The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC).  | [optional] 

### Return type

[**PageableBankList**](PageableBankList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbank"></a>
# **GetBank**
> Bank GetBank (long? id)

Get a bank

Get a single bank from finAPI's database of banks. You have to pass the bank's identifier, and either the authorized user's access_token, or your client's access token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBankExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BanksApi();
            var id = 789;  // long? | Identifier of requested bank

            try
            {
                // Get a bank
                Bank result = apiInstance.GetBank(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BanksApi.GetBank: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Identifier of requested bank | 

### Return type

[**Bank**](Bank.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

