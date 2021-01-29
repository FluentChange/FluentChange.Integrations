# IO.Swagger.Api.TPPCertificatesApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNewCertificate**](TPPCertificatesApi.md#createnewcertificate) | **POST** /api/v1/tppCertificates | Create a new certificate
[**DeleteCertificate**](TPPCertificatesApi.md#deletecertificate) | **DELETE** /api/v1/tppCertificates/{id} | Delete a certificate
[**GetAllCertificates**](TPPCertificatesApi.md#getallcertificates) | **GET** /api/v1/tppCertificates | Get all certificates
[**GetCertificate**](TPPCertificatesApi.md#getcertificate) | **GET** /api/v1/tppCertificates/{id} | Get a certificate


<a name="createnewcertificate"></a>
# **CreateNewCertificate**
> TppCertificate CreateNewCertificate (TppCertificateParams body)

Create a new certificate

Upload a new TPP certificate. Must pass the <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client' target='_blank'>mandator admin client</a>'s access_token. <br/>QWAC certificate is used to verify your identity by the bank during the TLS handshake.<br/>QsealC certificate is used to sign the requests to the bank.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateNewCertificateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TPPCertificatesApi();
            var body = new TppCertificateParams(); // TppCertificateParams | Create new certificate parameters

            try
            {
                // Create a new certificate
                TppCertificate result = apiInstance.CreateNewCertificate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TPPCertificatesApi.CreateNewCertificate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TppCertificateParams**](TppCertificateParams.md)| Create new certificate parameters | 

### Return type

[**TppCertificate**](TppCertificate.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecertificate"></a>
# **DeleteCertificate**
> void DeleteCertificate (long? id)

Delete a certificate

Delete a single certificate by its id. Must pass the <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client' target='_blank'>mandator admin client</a>'s access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCertificateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TPPCertificatesApi();
            var id = 789;  // long? | Id of the certificate to delete

            try
            {
                // Delete a certificate
                apiInstance.DeleteCertificate(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TPPCertificatesApi.DeleteCertificate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the certificate to delete | 

### Return type

void (empty response body)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcertificates"></a>
# **GetAllCertificates**
> PageableTppCertificateList GetAllCertificates (int? page, int? perPage)

Get all certificates

Returns all certificates that you have uploaded via 'Create a new certificate' service. Must pass the <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client' target='_blank'>mandator admin client</a>'s access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllCertificatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TPPCertificatesApi();
            var page = 56;  // int? | Result page that you want to retrieve (optional)  (default to 1)
            var perPage = 56;  // int? | Maximum number of records per page. By default it's 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. (optional)  (default to 20)

            try
            {
                // Get all certificates
                PageableTppCertificateList result = apiInstance.GetAllCertificates(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TPPCertificatesApi.GetAllCertificates: " + e.Message );
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

[**PageableTppCertificateList**](PageableTppCertificateList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcertificate"></a>
# **GetCertificate**
> TppCertificate GetCertificate (long? id)

Get a certificate

Get a single certificate by its id. Must pass the <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client' target='_blank'>mandator admin client</a>'s access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCertificateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TPPCertificatesApi();
            var id = 789;  // long? | Id of requested certificate

            try
            {
                // Get a certificate
                TppCertificate result = apiInstance.GetCertificate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TPPCertificatesApi.GetCertificate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of requested certificate | 

### Return type

[**TppCertificate**](TppCertificate.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

