# IO.Swagger.Api.CategoriesApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCategory**](CategoriesApi.md#createcategory) | **POST** /api/v1/categories | Create a new category
[**DeleteAllCategories**](CategoriesApi.md#deleteallcategories) | **DELETE** /api/v1/categories | Delete all categories
[**DeleteCategory**](CategoriesApi.md#deletecategory) | **DELETE** /api/v1/categories/{id} | Delete a category
[**EditCategory**](CategoriesApi.md#editcategory) | **PATCH** /api/v1/categories/{id} | Edit a category
[**GetAndSearchAllCategories**](CategoriesApi.md#getandsearchallcategories) | **GET** /api/v1/categories | Get and search all categories
[**GetCashFlows**](CategoriesApi.md#getcashflows) | **GET** /api/v1/categories/cashFlows | Get cash flows
[**GetCategory**](CategoriesApi.md#getcategory) | **GET** /api/v1/categories/{id} | Get a category
[**TrainCategorization**](CategoriesApi.md#traincategorization) | **POST** /api/v1/categories/trainCategorization | Train categorization


<a name="createcategory"></a>
# **CreateCategory**
> Category CreateCategory (CategoryParams body)

Create a new category

Create a new custom transaction category for the authorized user, that can then be assigned to transactions via PATCH /transactions, and that will also be regarded in finAPI's automatic transactions categorization process. Must pass the user's access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var body = new CategoryParams(); // CategoryParams | Parameters of the new category (optional) 

            try
            {
                // Create a new category
                Category result = apiInstance.CreateCategory(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.CreateCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CategoryParams**](CategoryParams.md)| Parameters of the new category | [optional] 

### Return type

[**Category**](Category.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteallcategories"></a>
# **DeleteAllCategories**
> IdentifierList DeleteAllCategories ()

Delete all categories

Delete all custom categories of the user that is authorized by the access_token. Must pass the user's access_token. Note that this deletes both parent categories as well as any related sub-categories.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAllCategoriesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();

            try
            {
                // Delete all categories
                IdentifierList result = apiInstance.DeleteAllCategories();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.DeleteAllCategories: " + e.Message );
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

<a name="deletecategory"></a>
# **DeleteCategory**
> void DeleteCategory (long? id)

Delete a category

Delete a single category of the user that is authorized by the access_token. Must pass the user's access_token. Note that you can only delete user-custom categories (category's where the 'isCustom' flag is true). Also note that when deleting a parent category, all its sub-categories will be deleted as well.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var id = 789;  // long? | Category identifier

            try
            {
                // Delete a category
                apiInstance.DeleteCategory(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.DeleteCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Category identifier | 

### Return type

void (empty response body)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editcategory"></a>
# **EditCategory**
> Category EditCategory (long? id, EditCategoryParams body)

Edit a category

Change the name of a custom transaction category belonging to the authorized user. Must pass the user's access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var id = 789;  // long? | Identifier of the category to edit
            var body = new EditCategoryParams(); // EditCategoryParams | New category name (optional) 

            try
            {
                // Edit a category
                Category result = apiInstance.EditCategory(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.EditCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Identifier of the category to edit | 
 **body** | [**EditCategoryParams**](EditCategoryParams.md)| New category name | [optional] 

### Return type

[**Category**](Category.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getandsearchallcategories"></a>
# **GetAndSearchAllCategories**
> PageableCategoryList GetAndSearchAllCategories (List<long?> ids, string search, bool? isCustom, int? page, int? perPage, List<string> order)

Get and search all categories

Get a list of all global finAPI categories as well as all custom categories of the authorized user. Must pass the user's access_token. You can set optional search criteria to get only those categories that you are interested in. If you do not specify any search criteria, then this service functions as a 'get all' service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAndSearchAllCategoriesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var ids = new List<long?>(); // List<long?> | A comma-separated list of category identifiers. If specified, then only categories whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. (optional) 
            var search = search_example;  // string | If specified, then only those categories will be contained in the result whose 'name' contains the given search string (the matching works case-insensitive). If no categories contain the search string in their name, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the name in order for a category to get included into the result. (optional) 
            var isCustom = true;  // bool? | If specified, then the result will contain only categories that are either finAPI global (in case of value 'false'), or only categories that have been created by the authorized user (in case of value 'true'). (optional) 
            var page = 56;  // int? | Result page that you want to retrieve. (optional)  (default to 1)
            var perPage = 56;  // int? | Maximum number of records per page. By default it's 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. (optional)  (default to 20)
            var order = new List<string>(); // List<string> | Determines the order of the results. You can order the results by 'id', 'name' and 'isCustom'. The default order is 'id,asc'. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: '/categories?order=isCustom,desc&order=name' will return all custom categories followed by all default categories. Both groups are ordered ascending by name. The general format is: 'property[,asc|desc]', with 'asc' being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC).  (optional) 

            try
            {
                // Get and search all categories
                PageableCategoryList result = apiInstance.GetAndSearchAllCategories(ids, search, isCustom, page, perPage, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetAndSearchAllCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List<long?>**](long?.md)| A comma-separated list of category identifiers. If specified, then only categories whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. | [optional] 
 **search** | **string**| If specified, then only those categories will be contained in the result whose &#39;name&#39; contains the given search string (the matching works case-insensitive). If no categories contain the search string in their name, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the name in order for a category to get included into the result. | [optional] 
 **isCustom** | **bool?**| If specified, then the result will contain only categories that are either finAPI global (in case of value &#39;false&#39;), or only categories that have been created by the authorized user (in case of value &#39;true&#39;). | [optional] 
 **page** | **int?**| Result page that you want to retrieve. | [optional] [default to 1]
 **perPage** | **int?**| Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. | [optional] [default to 20]
 **order** | [**List<string>**](string.md)| Determines the order of the results. You can order the results by &#39;id&#39;, &#39;name&#39; and &#39;isCustom&#39;. The default order is &#39;id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/categories?order&#x3D;isCustom,desc&amp;order&#x3D;name&#39; will return all custom categories followed by all default categories. Both groups are ordered ascending by name. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC).  | [optional] 

### Return type

[**PageableCategoryList**](PageableCategoryList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcashflows"></a>
# **GetCashFlows**
> CashFlowList GetCashFlows (string search, string counterpart, string purpose, List<long?> accountIds, string minBankBookingDate, string maxBankBookingDate, string minFinapiBookingDate, string maxFinapiBookingDate, decimal? minAmount, decimal? maxAmount, string direction, List<long?> labelIds, List<long?> categoryIds, bool? isNew, string minImportDate, string maxImportDate, bool? includeSubCashFlows, List<string> order)

Get cash flows

Get the cash flow(s) (= total income, spending, and balance) for one or several categories. You can specify various criteria such as the time period to calculate the cash flows for, or what categories to do the calculations for. Note that the cash flow for a category may include the cash flows for all of its sub-categories, or not include it, depending on the 'includeSubCashFlows' setting. Must pass the user's access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCashFlowsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var search = search_example;  // string | If specified, then only transactions that contain the search term in their purpose or counterpart fields will be contained in the result. Note that the search is case insensitive. (optional) 
            var counterpart = counterpart_example;  // string | The counterpart is the person or institution that received your payment, or that you made the payment to. If this parameter is specified, then only transactions that contain the given term in one (or more) of their counterpart fields ('counterpartName', 'counterpartAccountNumber', 'counterpartIban', 'counterpartBic' or 'counterpartBlz') will be contained in the result. Note that the search is case insensitive. (optional) 
            var purpose = purpose_example;  // string | If specified, then only those transactions will be contained in the result whose purpose field contains the given search string. Note that the search is case insensitive.NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the purpose in order for a transaction to get included into the result. (optional) 
            var accountIds = new List<long?>(); // List<long?> | A comma-separated list of account identifiers. If specified, then only transactions that relate to the given accounts will be regarded. If not specified, then all accounts will be regarded. (optional) 
            var minBankBookingDate = minBankBookingDate_example;  // string | Lower bound for a transaction's booking date as returned by the bank (= original booking date), in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only transactions whose 'bankBookingDate' is equal to or later than the given date will be regarded. (optional) 
            var maxBankBookingDate = maxBankBookingDate_example;  // string | Upper bound for a transaction's booking date as returned by the bank (= original booking date), in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only transactions whose 'bankBookingDate' is equal to or earlier than the given date will be regarded. (optional) 
            var minFinapiBookingDate = minFinapiBookingDate_example;  // string | Lower bound for a transaction's booking date as set by finAPI, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). For details about the meaning of the finAPI booking date, please see the field's documentation in the service's response. (optional) 
            var maxFinapiBookingDate = maxFinapiBookingDate_example;  // string | Upper bound for a transaction's booking date as set by finAPI, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). For details about the meaning of the finAPI booking date, please see the field's documentation in the service's response. (optional) 
            var minAmount = 8.14;  // decimal? | If specified, then only transactions whose amount is equal to or greater than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95 (optional) 
            var maxAmount = 8.14;  // decimal? | If specified, then only transactions whose amount is equal to or less than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95 (optional) 
            var direction = direction_example;  // string | If specified, then only transactions with the given direction(s) will be regarded. Use 'income' for regarding only received payments (amount >= 0), 'spending' for regarding only outgoing payments (amount < 0), or 'all' to regard both directions. If not specified, the direction defaults to 'all'. (optional)  (default to all)
            var labelIds = new List<long?>(); // List<long?> | A comma-separated list of label identifiers. If specified, then only transactions that have been marked with at least one of the given labels will be contained in the result. (optional) 
            var categoryIds = new List<long?>(); // List<long?> | If specified, then the result will contain only those cash flows that relate to the given categories. Note that the cash flow for a category may include/exclude the cash flows of its sub-categories, depending on the 'includeSubCashFlows' setting. To include the cash flow of not categorized transactions, pass the value '0' as categoryId. Note: When this parameter is NOT set, then the result will contain a cash flow for all categories that have transactions associated to them (this includes the 'null'-category for the cash flow of not categorized transactions), more precisely: transactions that fulfill the filter criteria. Categories that have no associated transactions according to the filter criteria will not appear in the result. However, when you specify this parameter, then all specified categories will have a cash flow entry in the result, even if there are no associated transactions for the category (the cash flow will have income, spending and balance all set to zero). (optional) 
            var isNew = true;  // bool? | If specified, then only transactions that have their 'isNew' flag set to true/false will be regarded for the cash flow calculations. (optional) 
            var minImportDate = minImportDate_example;  // string | Lower bound for a transaction's import date, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only transactions whose 'importDate' is equal to or later than the given date will be regarded. (optional) 
            var maxImportDate = maxImportDate_example;  // string | Upper bound for a transaction's import date, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only transactions whose 'importDate' is equal to or earlier than the given date will be regarded. (optional) 
            var includeSubCashFlows = true;  // bool? | If it is true, then the income, spending, balance and count of transactions of a main category results from all transactions that have either this (main) category or any of its subcategories assigned (of course all transactions depends from the other filtering settings); If it is false, then the income, spending, balance and count of transactions of a main category only results from the transactions that have exactly this (main) category assigned. Default value for this parameter is 'true'. (optional)  (default to true)
            var order = new List<string>(); // List<string> | Determines the order of the results. You can order the results by 'income', 'spending', 'balance', 'category.id' or 'category.name'. The default order for this service is 'category.id,asc'. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: '/cashFlows?order=income,desc&order=spending,asc&balance,desc' will return as first result the category with the highest income. If two categories have the same income, it returns the category with the highest spending first (because spending is a negative value) and so on. The general format is: 'property[,asc|desc]', with 'asc' being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC).  (optional) 

            try
            {
                // Get cash flows
                CashFlowList result = apiInstance.GetCashFlows(search, counterpart, purpose, accountIds, minBankBookingDate, maxBankBookingDate, minFinapiBookingDate, maxFinapiBookingDate, minAmount, maxAmount, direction, labelIds, categoryIds, isNew, minImportDate, maxImportDate, includeSubCashFlows, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCashFlows: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**| If specified, then only transactions that contain the search term in their purpose or counterpart fields will be contained in the result. Note that the search is case insensitive. | [optional] 
 **counterpart** | **string**| The counterpart is the person or institution that received your payment, or that you made the payment to. If this parameter is specified, then only transactions that contain the given term in one (or more) of their counterpart fields (&#39;counterpartName&#39;, &#39;counterpartAccountNumber&#39;, &#39;counterpartIban&#39;, &#39;counterpartBic&#39; or &#39;counterpartBlz&#39;) will be contained in the result. Note that the search is case insensitive. | [optional] 
 **purpose** | **string**| If specified, then only those transactions will be contained in the result whose purpose field contains the given search string. Note that the search is case insensitive.NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the purpose in order for a transaction to get included into the result. | [optional] 
 **accountIds** | [**List<long?>**](long?.md)| A comma-separated list of account identifiers. If specified, then only transactions that relate to the given accounts will be regarded. If not specified, then all accounts will be regarded. | [optional] 
 **minBankBookingDate** | **string**| Lower bound for a transaction&#39;s booking date as returned by the bank (&#x3D; original booking date), in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;bankBookingDate&#39; is equal to or later than the given date will be regarded. | [optional] 
 **maxBankBookingDate** | **string**| Upper bound for a transaction&#39;s booking date as returned by the bank (&#x3D; original booking date), in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;bankBookingDate&#39; is equal to or earlier than the given date will be regarded. | [optional] 
 **minFinapiBookingDate** | **string**| Lower bound for a transaction&#39;s booking date as set by finAPI, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). For details about the meaning of the finAPI booking date, please see the field&#39;s documentation in the service&#39;s response. | [optional] 
 **maxFinapiBookingDate** | **string**| Upper bound for a transaction&#39;s booking date as set by finAPI, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). For details about the meaning of the finAPI booking date, please see the field&#39;s documentation in the service&#39;s response. | [optional] 
 **minAmount** | **decimal?**| If specified, then only transactions whose amount is equal to or greater than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95 | [optional] 
 **maxAmount** | **decimal?**| If specified, then only transactions whose amount is equal to or less than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95 | [optional] 
 **direction** | **string**| If specified, then only transactions with the given direction(s) will be regarded. Use &#39;income&#39; for regarding only received payments (amount &gt;&#x3D; 0), &#39;spending&#39; for regarding only outgoing payments (amount &lt; 0), or &#39;all&#39; to regard both directions. If not specified, the direction defaults to &#39;all&#39;. | [optional] [default to all]
 **labelIds** | [**List<long?>**](long?.md)| A comma-separated list of label identifiers. If specified, then only transactions that have been marked with at least one of the given labels will be contained in the result. | [optional] 
 **categoryIds** | [**List<long?>**](long?.md)| If specified, then the result will contain only those cash flows that relate to the given categories. Note that the cash flow for a category may include/exclude the cash flows of its sub-categories, depending on the &#39;includeSubCashFlows&#39; setting. To include the cash flow of not categorized transactions, pass the value &#39;0&#39; as categoryId. Note: When this parameter is NOT set, then the result will contain a cash flow for all categories that have transactions associated to them (this includes the &#39;null&#39;-category for the cash flow of not categorized transactions), more precisely: transactions that fulfill the filter criteria. Categories that have no associated transactions according to the filter criteria will not appear in the result. However, when you specify this parameter, then all specified categories will have a cash flow entry in the result, even if there are no associated transactions for the category (the cash flow will have income, spending and balance all set to zero). | [optional] 
 **isNew** | **bool?**| If specified, then only transactions that have their &#39;isNew&#39; flag set to true/false will be regarded for the cash flow calculations. | [optional] 
 **minImportDate** | **string**| Lower bound for a transaction&#39;s import date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;importDate&#39; is equal to or later than the given date will be regarded. | [optional] 
 **maxImportDate** | **string**| Upper bound for a transaction&#39;s import date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;importDate&#39; is equal to or earlier than the given date will be regarded. | [optional] 
 **includeSubCashFlows** | **bool?**| If it is true, then the income, spending, balance and count of transactions of a main category results from all transactions that have either this (main) category or any of its subcategories assigned (of course all transactions depends from the other filtering settings); If it is false, then the income, spending, balance and count of transactions of a main category only results from the transactions that have exactly this (main) category assigned. Default value for this parameter is &#39;true&#39;. | [optional] [default to true]
 **order** | [**List<string>**](string.md)| Determines the order of the results. You can order the results by &#39;income&#39;, &#39;spending&#39;, &#39;balance&#39;, &#39;category.id&#39; or &#39;category.name&#39;. The default order for this service is &#39;category.id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/cashFlows?order&#x3D;income,desc&amp;order&#x3D;spending,asc&amp;balance,desc&#39; will return as first result the category with the highest income. If two categories have the same income, it returns the category with the highest spending first (because spending is a negative value) and so on. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC).  | [optional] 

### Return type

[**CashFlowList**](CashFlowList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategory"></a>
# **GetCategory**
> Category GetCategory (long? id)

Get a category

Get a single category that is either a global finAPI category or a custom category of the authorized user. Must pass the category's identifier and the user's access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var id = 789;  // long? | Category identifier

            try
            {
                // Get a category
                Category result = apiInstance.GetCategory(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Category identifier | 

### Return type

[**Category**](Category.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="traincategorization"></a>
# **TrainCategorization**
> void TrainCategorization (TrainCategorizationData body)

Train categorization

This service allows you to create user-specific categorization rules (for the user that is authorized by the access_token). Pass a categorization sample (=set of transaction data and a target category), and finAPI will train the user's categorization rules so that similar transactions will be categorized accordingly in future. Basically, this service behaves the same as when assigning categories to existing transactions via the 'Edit a transaction' service, with the difference that you can directly pass transaction data to this service, without the need of having any transactions actually imported in finAPI. Must pass the user's access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TrainCategorizationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var body = new TrainCategorizationData(); // TrainCategorizationData | Categorization sample (optional) 

            try
            {
                // Train categorization
                apiInstance.TrainCategorization(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.TrainCategorization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TrainCategorizationData**](TrainCategorizationData.md)| Categorization sample | [optional] 

### Return type

void (empty response body)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

