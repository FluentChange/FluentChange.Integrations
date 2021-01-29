# IO.Swagger.Api.WebFormsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWebForm**](WebFormsApi.md#getwebform) | **GET** /api/v1/webForms/{id} | Get a web form


<a name="getwebform"></a>
# **GetWebForm**
> WebForm GetWebForm (long? id)

Get a web form

Get a web form of the user that is authorized by the access_token. Must pass the web form's identifier and the user's access_token. <br/><br/>Note that every web form resource is automatically removed from the finAPI system after 7 days from its creation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWebFormExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebFormsApi();
            var id = 789;  // long? | Identifier of web form

            try
            {
                // Get a web form
                WebForm result = apiInstance.GetWebForm(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebFormsApi.GetWebForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Identifier of web form | 

### Return type

[**WebForm**](WebForm.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

