# IO.Swagger.Api.LabelsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLabel**](LabelsApi.md#createlabel) | **POST** /api/v1/labels | Create a new label
[**DeleteAllLabels**](LabelsApi.md#deletealllabels) | **DELETE** /api/v1/labels | Delete all labels
[**DeleteLabel**](LabelsApi.md#deletelabel) | **DELETE** /api/v1/labels/{id} | Delete a label
[**EditLabel**](LabelsApi.md#editlabel) | **PATCH** /api/v1/labels/{id} | Edit a label
[**GetAndSearchAllLabels**](LabelsApi.md#getandsearchalllabels) | **GET** /api/v1/labels | Get and search all labels
[**GetLabel**](LabelsApi.md#getlabel) | **GET** /api/v1/labels/{id} | Get a label


<a name="createlabel"></a>
# **CreateLabel**
> Label CreateLabel (LabelParams body)

Create a new label

Create a new label for a specific user. Must pass the new label's name and the user's access_token.<br/><br/>Users can create labels to flag transactions (see method PATCH /transactions), with the goal of collecting and getting an overview of all transactions of a certain 'type'. In this sense, labels are similar to transaction categories. However, labels are supposed to depict more of an implicit meaning of a transaction. For instance, a user might want to assign a flag to a transaction that reminds him that he can offset it against tax. At the same time, the category of the transactions might be something like 'insurance', which is a more 'fact-based', or 'objective' way of typing the transaction. Despite this semantic difference between categories and labels, there is also the difference that a transaction can be assigned multiple labels at the same time (while in contrast it can have just a single category).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateLabelExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LabelsApi();
            var body = new LabelParams(); // LabelParams | Label's name

            try
            {
                // Create a new label
                Label result = apiInstance.CreateLabel(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.CreateLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LabelParams**](LabelParams.md)| Label&#39;s name | 

### Return type

[**Label**](Label.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletealllabels"></a>
# **DeleteAllLabels**
> IdentifierList DeleteAllLabels ()

Delete all labels

Delete all labels of the user that is authorized by the access_token. Must pass the user's access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAllLabelsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LabelsApi();

            try
            {
                // Delete all labels
                IdentifierList result = apiInstance.DeleteAllLabels();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.DeleteAllLabels: " + e.Message );
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

<a name="deletelabel"></a>
# **DeleteLabel**
> void DeleteLabel (long? id)

Delete a label

Delete a single label of the user that is authorized by the access_token. Must pass the label's identifier and the user's access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteLabelExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LabelsApi();
            var id = 789;  // long? | Identifier of the label to delete

            try
            {
                // Delete a label
                apiInstance.DeleteLabel(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.DeleteLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Identifier of the label to delete | 

### Return type

void (empty response body)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editlabel"></a>
# **EditLabel**
> Label EditLabel (long? id, LabelParams body)

Edit a label

Change the name of a label of the user that is authorized by the access_token. Must pass the label's identifier, the label's new name and the user's access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditLabelExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LabelsApi();
            var id = 789;  // long? | Label's identifier
            var body = new LabelParams(); // LabelParams | Label's new name

            try
            {
                // Edit a label
                Label result = apiInstance.EditLabel(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.EditLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Label&#39;s identifier | 
 **body** | [**LabelParams**](LabelParams.md)| Label&#39;s new name | 

### Return type

[**Label**](Label.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getandsearchalllabels"></a>
# **GetAndSearchAllLabels**
> PageableLabelList GetAndSearchAllLabels (List<long?> ids, string search, int? page, int? perPage, List<string> order)

Get and search all labels

Get labels of the user that is authorized by the access_token. Must pass the user's access_token. You can set optional search criteria to get only those labels that you are interested in. If you do not specify any search criteria, then this service functions as a 'get all' service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAndSearchAllLabelsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LabelsApi();
            var ids = new List<long?>(); // List<long?> | A comma-separated list of label identifiers. If specified, then only labels whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. (optional) 
            var search = search_example;  // string | If specified, then only those labels will be contained in the result whose 'name' contains the given search string (the matching works case-insensitive). If no labels contain the search string in their name, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the name in order for a label to get included into the result. (optional) 
            var page = 56;  // int? | Result page that you want to retrieve (optional)  (default to 1)
            var perPage = 56;  // int? | Maximum number of records per page. By default it's 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. (optional)  (default to 20)
            var order = new List<string>(); // List<string> | Determines the order of the results. You can order the results by 'id' or 'name'. The default order for all services is 'id,asc'. Since both fields (id and name) are unique, ordering by multiple fields is pointless. The general format is: 'property[,asc|desc]', with 'asc' being the default value.  (optional) 

            try
            {
                // Get and search all labels
                PageableLabelList result = apiInstance.GetAndSearchAllLabels(ids, search, page, perPage, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.GetAndSearchAllLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List<long?>**](long?.md)| A comma-separated list of label identifiers. If specified, then only labels whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. | [optional] 
 **search** | **string**| If specified, then only those labels will be contained in the result whose &#39;name&#39; contains the given search string (the matching works case-insensitive). If no labels contain the search string in their name, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the name in order for a label to get included into the result. | [optional] 
 **page** | **int?**| Result page that you want to retrieve | [optional] [default to 1]
 **perPage** | **int?**| Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. | [optional] [default to 20]
 **order** | [**List<string>**](string.md)| Determines the order of the results. You can order the results by &#39;id&#39; or &#39;name&#39;. The default order for all services is &#39;id,asc&#39;. Since both fields (id and name) are unique, ordering by multiple fields is pointless. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value.  | [optional] 

### Return type

[**PageableLabelList**](PageableLabelList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlabel"></a>
# **GetLabel**
> Label GetLabel (long? id)

Get a label

Get a single label of the user that is authorized by the access_token. Must pass the label's identifier and the user's access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLabelExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LabelsApi();
            var id = 789;  // long? | Identifier of requested label

            try
            {
                // Get a label
                Label result = apiInstance.GetLabel(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.GetLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Identifier of requested label | 

### Return type

[**Label**](Label.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

