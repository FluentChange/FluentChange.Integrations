# IO.Swagger.Api.TPPCredentialsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTppCredential**](TPPCredentialsApi.md#createtppcredential) | **POST** /api/v1/tppCredentials | Create new TPP credentials
[**DeleteTppCredential**](TPPCredentialsApi.md#deletetppcredential) | **DELETE** /api/v1/tppCredentials/{id} | Delete a set of TPP credentials
[**EditTppCredential**](TPPCredentialsApi.md#edittppcredential) | **PATCH** /api/v1/tppCredentials/{id} | Edit a set of TPP credentials
[**GetAllTppCredentials**](TPPCredentialsApi.md#getalltppcredentials) | **GET** /api/v1/tppCredentials | Get all TPP credentials
[**GetAndSearchTppAuthenticationGroups**](TPPCredentialsApi.md#getandsearchtppauthenticationgroups) | **GET** /api/v1/tppCredentials/tppAuthenticationGroups | Get all TPP Authentication Groups
[**GetTppCredential**](TPPCredentialsApi.md#gettppcredential) | **GET** /api/v1/tppCredentials/{id} | Get a set of TPP credentials


<a name="createtppcredential"></a>
# **CreateTppCredential**
> TppCredentials CreateTppCredential (TppCredentialsParams body)

Create new TPP credentials

Upload TPP credentials for a TPP Authentication Group. Must pass the <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client' target='_blank'>mandator admin client</a>'s access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTppCredentialExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TPPCredentialsApi();
            var body = new TppCredentialsParams(); // TppCredentialsParams | Parameters of a new set of TPP credentials

            try
            {
                // Create new TPP credentials
                TppCredentials result = apiInstance.CreateTppCredential(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TPPCredentialsApi.CreateTppCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TppCredentialsParams**](TppCredentialsParams.md)| Parameters of a new set of TPP credentials | 

### Return type

[**TppCredentials**](TppCredentials.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetppcredential"></a>
# **DeleteTppCredential**
> void DeleteTppCredential (long? id)

Delete a set of TPP credentials

Delete a single set of TPP credentials by its id. Must pass the <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client' target='_blank'>mandator admin client</a>'s access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTppCredentialExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TPPCredentialsApi();
            var id = 789;  // long? | Id of the TPP credentials to delete

            try
            {
                // Delete a set of TPP credentials
                apiInstance.DeleteTppCredential(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TPPCredentialsApi.DeleteTppCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the TPP credentials to delete | 

### Return type

void (empty response body)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittppcredential"></a>
# **EditTppCredential**
> TppCredentials EditTppCredential (long? id, EditTppCredentialParams body)

Edit a set of TPP credentials

Edit TPP credentials data. Must pass the <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client' target='_blank'>mandator admin client</a>'s access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditTppCredentialExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TPPCredentialsApi();
            var id = 789;  // long? | Id of the TPP credentials to edit
            var body = new EditTppCredentialParams(); // EditTppCredentialParams | New TPP credentials parameters

            try
            {
                // Edit a set of TPP credentials
                TppCredentials result = apiInstance.EditTppCredential(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TPPCredentialsApi.EditTppCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the TPP credentials to edit | 
 **body** | [**EditTppCredentialParams**](EditTppCredentialParams.md)| New TPP credentials parameters | 

### Return type

[**TppCredentials**](TppCredentials.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalltppcredentials"></a>
# **GetAllTppCredentials**
> PageableTppCredentialResources GetAllTppCredentials (string search, int? page, int? perPage)

Get all TPP credentials

Get and search all TPP credentials. Must pass the <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client' target='_blank'>mandator admin client</a>'s access_token. You can set optional search criteria to get only those TPP credentials that you are interested in. If you do not specify any search criteria, then this service functions as a 'get all' service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllTppCredentialsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TPPCredentialsApi();
            var search = search_example;  // string | Returns only the TPP credentials belonging to those banks whose 'name', 'blz', or 'bic' contains the given search string (the matching works case-insensitive). Note: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must apply to a bank in order for it to get included into the result. (optional) 
            var page = 56;  // int? | Result page that you want to retrieve (optional)  (default to 1)
            var perPage = 56;  // int? | Maximum number of records per page. By default it's 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. (optional)  (default to 20)

            try
            {
                // Get all TPP credentials
                PageableTppCredentialResources result = apiInstance.GetAllTppCredentials(search, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TPPCredentialsApi.GetAllTppCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**| Returns only the TPP credentials belonging to those banks whose &#39;name&#39;, &#39;blz&#39;, or &#39;bic&#39; contains the given search string (the matching works case-insensitive). Note: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must apply to a bank in order for it to get included into the result. | [optional] 
 **page** | **int?**| Result page that you want to retrieve | [optional] [default to 1]
 **perPage** | **int?**| Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. | [optional] [default to 20]

### Return type

[**PageableTppCredentialResources**](PageableTppCredentialResources.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getandsearchtppauthenticationgroups"></a>
# **GetAndSearchTppAuthenticationGroups**
> PageableTppAuthenticationGroupResources GetAndSearchTppAuthenticationGroups (List<long?> ids, string name, string bankBlz, string bankName, int? page, int? perPage)

Get all TPP Authentication Groups

Get and search across all available TPP authentication groups. Must pass the <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client' target='_blank'>mandator admin client</a>'s access_token. You can set optional search criteria to get only those TPP authentication groups that you are interested in. If you do not specify any search criteria, then this service functions as a 'get all' service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAndSearchTppAuthenticationGroupsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TPPCredentialsApi();
            var ids = new List<long?>(); // List<long?> | A comma-separated list of TPP authentication group identifiers. If specified, then only TPP authentication groups whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. (optional) 
            var name = name_example;  // string | Only the tpp authentication groups with name matching the given one should appear in the result list (optional) 
            var bankBlz = bankBlz_example;  // string | Search by connected banks: only the banks with BLZ matching the given one should appear in the result list (optional) 
            var bankName = bankName_example;  // string | Search by connected banks: only the banks with name matching the given one should appear in the result list (optional) 
            var page = 56;  // int? | Result page that you want to retrieve (optional)  (default to 1)
            var perPage = 56;  // int? | Maximum number of records per page. By default it's 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. (optional)  (default to 20)

            try
            {
                // Get all TPP Authentication Groups
                PageableTppAuthenticationGroupResources result = apiInstance.GetAndSearchTppAuthenticationGroups(ids, name, bankBlz, bankName, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TPPCredentialsApi.GetAndSearchTppAuthenticationGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List<long?>**](long?.md)| A comma-separated list of TPP authentication group identifiers. If specified, then only TPP authentication groups whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. | [optional] 
 **name** | **string**| Only the tpp authentication groups with name matching the given one should appear in the result list | [optional] 
 **bankBlz** | **string**| Search by connected banks: only the banks with BLZ matching the given one should appear in the result list | [optional] 
 **bankName** | **string**| Search by connected banks: only the banks with name matching the given one should appear in the result list | [optional] 
 **page** | **int?**| Result page that you want to retrieve | [optional] [default to 1]
 **perPage** | **int?**| Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. | [optional] [default to 20]

### Return type

[**PageableTppAuthenticationGroupResources**](PageableTppAuthenticationGroupResources.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettppcredential"></a>
# **GetTppCredential**
> TppCredentials GetTppCredential (long? id)

Get a set of TPP credentials

Get a single set of TPP credentials by its id. Must pass the <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client' target='_blank'>mandator admin client</a>'s access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTppCredentialExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TPPCredentialsApi();
            var id = 789;  // long? | Id of the requested TPP credentials

            try
            {
                // Get a set of TPP credentials
                TppCredentials result = apiInstance.GetTppCredential(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TPPCredentialsApi.GetTppCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the requested TPP credentials | 

### Return type

[**TppCredentials**](TppCredentials.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

