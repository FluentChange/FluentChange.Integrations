# IO.Swagger.Api.ClientConfigurationApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EditClientConfiguration**](ClientConfigurationApi.md#editclientconfiguration) | **PATCH** /api/v1/clientConfiguration | Edit client configuration
[**GetClientConfiguration**](ClientConfigurationApi.md#getclientconfiguration) | **GET** /api/v1/clientConfiguration | Get client configuration


<a name="editclientconfiguration"></a>
# **EditClientConfiguration**
> ClientConfiguration EditClientConfiguration (ClientConfigurationParams body)

Edit client configuration

Edit your client's configuration. Must pass your global (i.e. client) access_token.<br/><br/> <b>NOTE</b>: When token validity periods are changed, this only applies to newly requested tokens, and does not change the expiration time of already existing tokens.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditClientConfigurationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClientConfigurationApi();
            var body = new ClientConfigurationParams(); // ClientConfigurationParams | Client configuration parameters (optional) 

            try
            {
                // Edit client configuration
                ClientConfiguration result = apiInstance.EditClientConfiguration(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientConfigurationApi.EditClientConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ClientConfigurationParams**](ClientConfigurationParams.md)| Client configuration parameters | [optional] 

### Return type

[**ClientConfiguration**](ClientConfiguration.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientconfiguration"></a>
# **GetClientConfiguration**
> ClientConfiguration GetClientConfiguration ()

Get client configuration

Get your client's configuration. Must pass your global (i.e. client) access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientConfigurationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClientConfigurationApi();

            try
            {
                // Get client configuration
                ClientConfiguration result = apiInstance.GetClientConfiguration();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientConfigurationApi.GetClientConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ClientConfiguration**](ClientConfiguration.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

