# IO.Swagger.Api.TransactionsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAllTransactions**](TransactionsApi.md#deletealltransactions) | **DELETE** /api/v1/transactions | Delete all transactions
[**DeleteTransaction**](TransactionsApi.md#deletetransaction) | **DELETE** /api/v1/transactions/{id} | Delete a transaction
[**EditMultipleTransactions**](TransactionsApi.md#editmultipletransactions) | **PATCH** /api/v1/transactions | Edit multiple transactions
[**EditTransaction**](TransactionsApi.md#edittransaction) | **PATCH** /api/v1/transactions/{id} | Edit a transaction
[**GetAndSearchAllTransactions**](TransactionsApi.md#getandsearchalltransactions) | **GET** /api/v1/transactions | Get and search all transactions
[**GetTransaction**](TransactionsApi.md#gettransaction) | **GET** /api/v1/transactions/{id} | Get a transaction
[**RestoreTransaction**](TransactionsApi.md#restoretransaction) | **POST** /api/v1/transactions/{id}/restore | Restore a transaction
[**SplitTransaction**](TransactionsApi.md#splittransaction) | **POST** /api/v1/transactions/{id}/split | Split a transaction
[**TriggerCategorization**](TransactionsApi.md#triggercategorization) | **POST** /api/v1/transactions/triggerCategorization | Trigger categorization


<a name="deletealltransactions"></a>
# **DeleteAllTransactions**
> IdentifierList DeleteAllTransactions (string maxDeletionDate, string minImportDate, List<long?> accountIds, bool? safeMode, bool? rememberDeletion)

Delete all transactions

Delete a set, or the entirety, of transactions of the currently authorized user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAllTransactionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var maxDeletionDate = maxDeletionDate_example;  // string | If specified, then only those transactions are being deleted whose 'finapiBookingDate' is equal to or earlier to the given date. The date may not be in future, and must be given in the format 'YYYY-MM-DD'. If not specified, then no date limitation will be in place for the deletion. (optional) 
            var minImportDate = minImportDate_example;  // string | If specified, then only those transactions are being deleted whose 'importDate' is later than or equal to the given date. The date may not be in future, and must be given in the format 'YYYY-MM-DD'. This is useful e.g. if a bank returns incorrect transactions and then fixes that issue. Then you could put the date when the error was first observed as 'minImportDate'. This would lead to deletion of all transactions after the issue was introduced and allow finAPI to refetch them from scratch. This only works if safeMode is set to false and 'rememberDeletion' is undefined or set to false. You also can not use this parameter alongside 'maxDeletionDate'. (optional) 
            var accountIds = new List<long?>(); // List<long?> | A comma-separated list of account identifiers. If specified, then only transactions whose account's identifier is included in this list will be get deleted. The maximum number of identifiers is 1000. (optional) 
            var safeMode = true;  // bool? | When passing 'true', then only those transactions are being deleted where at least one of the following holds true: 1. The transaction belongs to a 'demo connection'; 2. The transaction's 'potentialDuplicate' flag is set to TRUE; 3. The transaction is an adjusting entry ('Zwischensaldo' transaction) that was added by finAPI. When passing 'false', then finAPI will delete transactions independent of these characteristics. The default value for this parameter is 'true'. (optional)  (default to true)
            var rememberDeletion = true;  // bool? | When passing 'true', then finAPI will make sure to not re-import deleted transactions on future account updates. When 'false', then deleted transactions might be re-imported. Default value for this parameter is 'false'. (optional)  (default to false)

            try
            {
                // Delete all transactions
                IdentifierList result = apiInstance.DeleteAllTransactions(maxDeletionDate, minImportDate, accountIds, safeMode, rememberDeletion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.DeleteAllTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maxDeletionDate** | **string**| If specified, then only those transactions are being deleted whose &#39;finapiBookingDate&#39; is equal to or earlier to the given date. The date may not be in future, and must be given in the format &#39;YYYY-MM-DD&#39;. If not specified, then no date limitation will be in place for the deletion. | [optional] 
 **minImportDate** | **string**| If specified, then only those transactions are being deleted whose &#39;importDate&#39; is later than or equal to the given date. The date may not be in future, and must be given in the format &#39;YYYY-MM-DD&#39;. This is useful e.g. if a bank returns incorrect transactions and then fixes that issue. Then you could put the date when the error was first observed as &#39;minImportDate&#39;. This would lead to deletion of all transactions after the issue was introduced and allow finAPI to refetch them from scratch. This only works if safeMode is set to false and &#39;rememberDeletion&#39; is undefined or set to false. You also can not use this parameter alongside &#39;maxDeletionDate&#39;. | [optional] 
 **accountIds** | [**List<long?>**](long?.md)| A comma-separated list of account identifiers. If specified, then only transactions whose account&#39;s identifier is included in this list will be get deleted. The maximum number of identifiers is 1000. | [optional] 
 **safeMode** | **bool?**| When passing &#39;true&#39;, then only those transactions are being deleted where at least one of the following holds true: 1. The transaction belongs to a &#39;demo connection&#39;; 2. The transaction&#39;s &#39;potentialDuplicate&#39; flag is set to TRUE; 3. The transaction is an adjusting entry (&#39;Zwischensaldo&#39; transaction) that was added by finAPI. When passing &#39;false&#39;, then finAPI will delete transactions independent of these characteristics. The default value for this parameter is &#39;true&#39;. | [optional] [default to true]
 **rememberDeletion** | **bool?**| When passing &#39;true&#39;, then finAPI will make sure to not re-import deleted transactions on future account updates. When &#39;false&#39;, then deleted transactions might be re-imported. Default value for this parameter is &#39;false&#39;. | [optional] [default to false]

### Return type

[**IdentifierList**](IdentifierList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetransaction"></a>
# **DeleteTransaction**
> void DeleteTransaction (long? id)

Delete a transaction

Delete a single transaction of the user that is authorized by the access_token.<br/><br/> A transaction can only get deleted if at least one of the following holds true:<br/> &bull; The transaction belongs to a 'demo connection'<br/> &bull; The transaction's 'potentialDuplicate' flag is set to TRUE<br/> &bull; The transaction is an adjusting entry ('Zwischensaldo' transaction) that was added by finAPI<br/><br/>Note that the 'Delete all transactions' service has additional functionality and allows you to delete transactions that you cannot delete with this service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTransactionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var id = 789;  // long? | Identifier of transaction

            try
            {
                // Delete a transaction
                apiInstance.DeleteTransaction(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.DeleteTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Identifier of transaction | 

### Return type

void (empty response body)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editmultipletransactions"></a>
# **EditMultipleTransactions**
> IdentifierList EditMultipleTransactions (UpdateMultipleTransactionsParams body)

Edit multiple transactions

Edit one or multiple transactions. You can edit the following fields: 'isNew=true|false' and/or 'isPotentialDuplicate=false' and/or 'categoryId=<id>' and/or 'labelIds=[<ids>]'. To clear the category of the given transactions (so that they are no longer categorized), pass the value '0' as the categoryId. To clear the labels of the given transactions, pass an empty array of label identifiers: '[]'. The parameters 'categoryId' and 'labelIds' are forbidden if 'ids' is NOT set (i.e. you cannot update the category or labels for ALL transactions). The result is a list of identifiers of only those transactions that have changed as a result of this service call.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditMultipleTransactionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var body = new UpdateMultipleTransactionsParams(); // UpdateMultipleTransactionsParams | Update transactions parameters

            try
            {
                // Edit multiple transactions
                IdentifierList result = apiInstance.EditMultipleTransactions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.EditMultipleTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateMultipleTransactionsParams**](UpdateMultipleTransactionsParams.md)| Update transactions parameters | 

### Return type

[**IdentifierList**](IdentifierList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittransaction"></a>
# **EditTransaction**
> Transaction EditTransaction (long? id, UpdateTransactionsParams body)

Edit a transaction

Change a transaction's fields. You can change the following fields: 'isNew=true|false' and/or 'isPotentialDuplicate=false' and/or 'categoryId=<id>' and/or 'labelIds=[<ids>]'. To clear a transaction's category (so that it is no longer categorized), pass the value '0' as the categoryId. To clear the labels of the given transaction, pass an empty array of label identifiers: '[]'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditTransactionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var id = 789;  // long? | Identifier of transaction
            var body = new UpdateTransactionsParams(); // UpdateTransactionsParams | Update transactions parameters

            try
            {
                // Edit a transaction
                Transaction result = apiInstance.EditTransaction(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.EditTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Identifier of transaction | 
 **body** | [**UpdateTransactionsParams**](UpdateTransactionsParams.md)| Update transactions parameters | 

### Return type

[**Transaction**](Transaction.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getandsearchalltransactions"></a>
# **GetAndSearchAllTransactions**
> PageableTransactionList GetAndSearchAllTransactions (string view, List<long?> ids, string search, string counterpart, string purpose, List<long?> accountIds, string minBankBookingDate, string maxBankBookingDate, string minFinapiBookingDate, string maxFinapiBookingDate, decimal? minAmount, decimal? maxAmount, string direction, List<long?> labelIds, List<long?> categoryIds, bool? includeChildCategories, bool? isNew, bool? isPotentialDuplicate, bool? isAdjustingEntry, string minImportDate, string maxImportDate, int? page, int? perPage, List<string> order)

Get and search all transactions

Get transactions of the user that is authorized by the access_token. Must pass the user's access_token. You can set optional search criteria to get only those transactions that you are interested in. If you do not specify any search criteria, then this service functions as a 'get all' service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAndSearchAllTransactionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var view = view_example;  // string | This parameter defines finAPI's logical view on the transactions when querying them: 'bankView' regards only the original transactions as they were received from the bank, without considering how the transactions might have gotten split by the user (see POST /transactions/<id>/split). This means that if a transaction is split into logical sub-transactions, then the service will still regard only the original transaction, and NOT the logical sub-transactions in its processing (though for convenience, the transactions will have the data of their sub-transactions included in the response). 'userView' by contrast regards the transactions as they exist for the user. For transactions that have not been split into logical sub-transactions, there is no difference to the \"bankView\". But for transaction that have been split into logical sub-transactions, the service will ONLY regard these sub-transactions, and not the originally received transaction (though for convenience, the sub-transactions will have the identifier of their original transaction included in the response).
            var ids = new List<long?>(); // List<long?> | A comma-separated list of transaction identifiers. If specified, then only transactions whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. (optional) 
            var search = search_example;  // string | If specified, then only those transactions will be contained in the result whose 'purpose' or counterpart fields contain the given search string (the matching works case-insensitive). If no transactions contain the search string in any of these fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for a transaction to get included into the result. (optional) 
            var counterpart = counterpart_example;  // string | If specified, then only those transactions will be contained in the result whose counterpart fields contain the given search string (the matching works case-insensitive). If no transactions contain the search string in any of the counterpart fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for a transaction to get included into the result. (optional) 
            var purpose = purpose_example;  // string | If specified, then only those transactions will be contained in the result whose purpose field contains the given search string (the matching works case-insensitive). If no transactions contain the search string in the purpose field, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the purpose in order for a transaction to get included into the result. (optional) 
            var accountIds = new List<long?>(); // List<long?> | A comma-separated list of account identifiers. If specified, then only transactions that relate to the given accounts will be regarded. If not specified, then all accounts will be regarded. (optional) 
            var minBankBookingDate = minBankBookingDate_example;  // string | Lower bound for a transaction's booking date as returned by the bank (= original booking date), in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only transactions whose 'bankBookingDate' is equal to or later than the given date will be regarded. (optional) 
            var maxBankBookingDate = maxBankBookingDate_example;  // string | Upper bound for a transaction's booking date as returned by the bank (= original booking date), in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only transactions whose 'bankBookingDate' is equal to or earlier than the given date will be regarded. (optional) 
            var minFinapiBookingDate = minFinapiBookingDate_example;  // string | Lower bound for a transaction's booking date as set by finAPI, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). For details about the meaning of the finAPI booking date, please see the field's documentation in the service's response. (optional) 
            var maxFinapiBookingDate = maxFinapiBookingDate_example;  // string | Upper bound for a transaction's booking date as set by finAPI, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). For details about the meaning of the finAPI booking date, please see the field's documentation in the service's response. (optional) 
            var minAmount = 8.14;  // decimal? | If specified, then only transactions whose amount is equal to or greater than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95 (optional) 
            var maxAmount = 8.14;  // decimal? | If specified, then only transactions whose amount is equal to or less than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95 (optional) 
            var direction = direction_example;  // string | If specified, then only transactions with the given direction(s) will be regarded. Use 'income' for regarding only received payments (amount >= 0), 'spending' for regarding only outgoing payments (amount < 0), or 'all' to regard both directions. If not specified, the direction defaults to 'all'. (optional)  (default to all)
            var labelIds = new List<long?>(); // List<long?> | A comma-separated list of label identifiers. If specified, then only transactions that have been marked with at least one of the given labels will be contained in the result. (optional) 
            var categoryIds = new List<long?>(); // List<long?> | A comma-separated list of category identifiers. If specified, then the result will contain only transactions whose category is either one of the given categories, or - but only if the 'includeChildCategories' flag is set to 'true' - whose category is a sub-category of one of the given categories. To include transactions without any category, pass the value '0' as the categoryId. (optional) 
            var includeChildCategories = true;  // bool? | This flag controls how the given 'categoryIds' are handled. If set to 'true', then all transactions of a given categoryId, as well as all transactions of any of its sub-categories will be regarded. If set to 'false', then sub-categories of a given categoryId will not be regarded and only those transactions are regarded whose category matches one of the explicitly given categoryIds. The default value for this flag is 'true'. (optional)  (default to true)
            var isNew = true;  // bool? | If specified, then only transactions that have their 'isNew' flag set to true/false will be regarded. (optional) 
            var isPotentialDuplicate = true;  // bool? | If specified, then only transactions that have their 'isPotentialDuplicate' flag set to true/false will be regarded. (optional) 
            var isAdjustingEntry = true;  // bool? | If specified, then only transactions that have their 'isAdjustingEntry' flag set to true/false will be regarded. (optional) 
            var minImportDate = minImportDate_example;  // string | Lower bound for a transaction's import date, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only transactions whose 'importDate' is equal to or later than the given date will be regarded. (optional) 
            var maxImportDate = maxImportDate_example;  // string | Upper bound for a transaction's import date, in the format 'YYYY-MM-DD' (e.g. '2016-01-01'). If specified, then only transactions whose 'importDate' is equal to or earlier than the given date will be regarded. (optional) 
            var page = 56;  // int? | Result page that you want to retrieve. (optional)  (default to 1)
            var perPage = 56;  // int? | Maximum number of records per page. By default it's 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. (optional)  (default to 20)
            var order = new List<string>(); // List<string> | Determines the order of the results. You can use the following fields for ordering the response: 'id', 'parentId', 'accountId', 'valueDate', 'bankBookingDate', 'finapiBookingDate', 'amount', 'purpose', 'counterpartName', 'counterpartAccountNumber', 'counterpartIban', 'counterpartBlz', 'counterpartBic', 'type', 'primanota', 'category.id', 'category.name', 'isPotentialDuplicate', 'isNew' and 'importDate'. The default order for all services is 'id,asc'. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: '/transactions?order=finapiBookingDate,desc&order=counterpartName' will return the latest transactions first. If there are more transactions on the same day, then these transactions are ordered by the counterpart name (ascending). The general format is: 'property[,asc|desc]', with 'asc' being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC).  (optional) 

            try
            {
                // Get and search all transactions
                PageableTransactionList result = apiInstance.GetAndSearchAllTransactions(view, ids, search, counterpart, purpose, accountIds, minBankBookingDate, maxBankBookingDate, minFinapiBookingDate, maxFinapiBookingDate, minAmount, maxAmount, direction, labelIds, categoryIds, includeChildCategories, isNew, isPotentialDuplicate, isAdjustingEntry, minImportDate, maxImportDate, page, perPage, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetAndSearchAllTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **view** | **string**| This parameter defines finAPI&#39;s logical view on the transactions when querying them: &#39;bankView&#39; regards only the original transactions as they were received from the bank, without considering how the transactions might have gotten split by the user (see POST /transactions/&lt;id&gt;/split). This means that if a transaction is split into logical sub-transactions, then the service will still regard only the original transaction, and NOT the logical sub-transactions in its processing (though for convenience, the transactions will have the data of their sub-transactions included in the response). &#39;userView&#39; by contrast regards the transactions as they exist for the user. For transactions that have not been split into logical sub-transactions, there is no difference to the \&quot;bankView\&quot;. But for transaction that have been split into logical sub-transactions, the service will ONLY regard these sub-transactions, and not the originally received transaction (though for convenience, the sub-transactions will have the identifier of their original transaction included in the response). | 
 **ids** | [**List<long?>**](long?.md)| A comma-separated list of transaction identifiers. If specified, then only transactions whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000. | [optional] 
 **search** | **string**| If specified, then only those transactions will be contained in the result whose &#39;purpose&#39; or counterpart fields contain the given search string (the matching works case-insensitive). If no transactions contain the search string in any of these fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for a transaction to get included into the result. | [optional] 
 **counterpart** | **string**| If specified, then only those transactions will be contained in the result whose counterpart fields contain the given search string (the matching works case-insensitive). If no transactions contain the search string in any of the counterpart fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for a transaction to get included into the result. | [optional] 
 **purpose** | **string**| If specified, then only those transactions will be contained in the result whose purpose field contains the given search string (the matching works case-insensitive). If no transactions contain the search string in the purpose field, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the purpose in order for a transaction to get included into the result. | [optional] 
 **accountIds** | [**List<long?>**](long?.md)| A comma-separated list of account identifiers. If specified, then only transactions that relate to the given accounts will be regarded. If not specified, then all accounts will be regarded. | [optional] 
 **minBankBookingDate** | **string**| Lower bound for a transaction&#39;s booking date as returned by the bank (&#x3D; original booking date), in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;bankBookingDate&#39; is equal to or later than the given date will be regarded. | [optional] 
 **maxBankBookingDate** | **string**| Upper bound for a transaction&#39;s booking date as returned by the bank (&#x3D; original booking date), in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;bankBookingDate&#39; is equal to or earlier than the given date will be regarded. | [optional] 
 **minFinapiBookingDate** | **string**| Lower bound for a transaction&#39;s booking date as set by finAPI, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). For details about the meaning of the finAPI booking date, please see the field&#39;s documentation in the service&#39;s response. | [optional] 
 **maxFinapiBookingDate** | **string**| Upper bound for a transaction&#39;s booking date as set by finAPI, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). For details about the meaning of the finAPI booking date, please see the field&#39;s documentation in the service&#39;s response. | [optional] 
 **minAmount** | **decimal?**| If specified, then only transactions whose amount is equal to or greater than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95 | [optional] 
 **maxAmount** | **decimal?**| If specified, then only transactions whose amount is equal to or less than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95 | [optional] 
 **direction** | **string**| If specified, then only transactions with the given direction(s) will be regarded. Use &#39;income&#39; for regarding only received payments (amount &gt;&#x3D; 0), &#39;spending&#39; for regarding only outgoing payments (amount &lt; 0), or &#39;all&#39; to regard both directions. If not specified, the direction defaults to &#39;all&#39;. | [optional] [default to all]
 **labelIds** | [**List<long?>**](long?.md)| A comma-separated list of label identifiers. If specified, then only transactions that have been marked with at least one of the given labels will be contained in the result. | [optional] 
 **categoryIds** | [**List<long?>**](long?.md)| A comma-separated list of category identifiers. If specified, then the result will contain only transactions whose category is either one of the given categories, or - but only if the &#39;includeChildCategories&#39; flag is set to &#39;true&#39; - whose category is a sub-category of one of the given categories. To include transactions without any category, pass the value &#39;0&#39; as the categoryId. | [optional] 
 **includeChildCategories** | **bool?**| This flag controls how the given &#39;categoryIds&#39; are handled. If set to &#39;true&#39;, then all transactions of a given categoryId, as well as all transactions of any of its sub-categories will be regarded. If set to &#39;false&#39;, then sub-categories of a given categoryId will not be regarded and only those transactions are regarded whose category matches one of the explicitly given categoryIds. The default value for this flag is &#39;true&#39;. | [optional] [default to true]
 **isNew** | **bool?**| If specified, then only transactions that have their &#39;isNew&#39; flag set to true/false will be regarded. | [optional] 
 **isPotentialDuplicate** | **bool?**| If specified, then only transactions that have their &#39;isPotentialDuplicate&#39; flag set to true/false will be regarded. | [optional] 
 **isAdjustingEntry** | **bool?**| If specified, then only transactions that have their &#39;isAdjustingEntry&#39; flag set to true/false will be regarded. | [optional] 
 **minImportDate** | **string**| Lower bound for a transaction&#39;s import date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;importDate&#39; is equal to or later than the given date will be regarded. | [optional] 
 **maxImportDate** | **string**| Upper bound for a transaction&#39;s import date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;importDate&#39; is equal to or earlier than the given date will be regarded. | [optional] 
 **page** | **int?**| Result page that you want to retrieve. | [optional] [default to 1]
 **perPage** | **int?**| Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. | [optional] [default to 20]
 **order** | [**List<string>**](string.md)| Determines the order of the results. You can use the following fields for ordering the response: &#39;id&#39;, &#39;parentId&#39;, &#39;accountId&#39;, &#39;valueDate&#39;, &#39;bankBookingDate&#39;, &#39;finapiBookingDate&#39;, &#39;amount&#39;, &#39;purpose&#39;, &#39;counterpartName&#39;, &#39;counterpartAccountNumber&#39;, &#39;counterpartIban&#39;, &#39;counterpartBlz&#39;, &#39;counterpartBic&#39;, &#39;type&#39;, &#39;primanota&#39;, &#39;category.id&#39;, &#39;category.name&#39;, &#39;isPotentialDuplicate&#39;, &#39;isNew&#39; and &#39;importDate&#39;. The default order for all services is &#39;id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/transactions?order&#x3D;finapiBookingDate,desc&amp;order&#x3D;counterpartName&#39; will return the latest transactions first. If there are more transactions on the same day, then these transactions are ordered by the counterpart name (ascending). The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC).  | [optional] 

### Return type

[**PageableTransactionList**](PageableTransactionList.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransaction"></a>
# **GetTransaction**
> Transaction GetTransaction (long? id)

Get a transaction

Get a single transaction of the user that is authorized by the access_token. Must pass the transaction's identifier and the user's access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTransactionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var id = 789;  // long? | Identifier of transaction

            try
            {
                // Get a transaction
                Transaction result = apiInstance.GetTransaction(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Identifier of transaction | 

### Return type

[**Transaction**](Transaction.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restoretransaction"></a>
# **RestoreTransaction**
> Transaction RestoreTransaction (long? id)

Restore a transaction

Restore a previously split transaction. Removes all of its sub-transactions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestoreTransactionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var id = 789;  // long? | Transaction identifier

            try
            {
                // Restore a transaction
                Transaction result = apiInstance.RestoreTransaction(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.RestoreTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Transaction identifier | 

### Return type

[**Transaction**](Transaction.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="splittransaction"></a>
# **SplitTransaction**
> Transaction SplitTransaction (long? id, SplitTransactionsParams body)

Split a transaction

Split a transaction into several logical sub-transactions. If the given transaction is split already, all its current sub-transactions will get deleted before the new sub-transactions will get created.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SplitTransactionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var id = 789;  // long? | Transaction identifier
            var body = new SplitTransactionsParams(); // SplitTransactionsParams | Split transactions parameters

            try
            {
                // Split a transaction
                Transaction result = apiInstance.SplitTransaction(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.SplitTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Transaction identifier | 
 **body** | [**SplitTransactionsParams**](SplitTransactionsParams.md)| Split transactions parameters | 

### Return type

[**Transaction**](Transaction.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="triggercategorization"></a>
# **TriggerCategorization**
> void TriggerCategorization (TriggerCategorizationParams body)

Trigger categorization

Triggers finAPI's background categorization process for all uncategorized transactions of the given bank connection(s) (or of all of the user's bank connections, if no bank connection identifiers are passed). The service returns as soon as the categorizations are scheduled. At this point, the bank connections will have their 'categorizationStatus' set to 'PENDING'. Use the service \"Get a bank connection\" or \"Get all bank connections\" to check when the categorization has finished (this is the case when the categorizationStatus has switched to 'READY').<br/><br/>Note that if at least one of the target bank connections is currently locked at the time when you call this service (i.e. the bank connection is currently being updated, or another categorization is already scheduled for it), then no categorization will be triggered at all and the service will respond with HTTP code 422.<br/><br/>Please also note:<br/>&bull; finAPI's background categorization process is executed automatically whenever you import or update a bank connection (though in case of update, it will categorize only the new transactions, and not re-run categorization for previously imported transactions). This means that in general you do not have to call this service after an import or update. Use this service only when you wish to re-run the categorization of all existing uncategorized transactions.<br/>&bull; if you wish to just manually assign categories to transactions, please use the service \"Edit a transaction\" or \"Edit multiple transactions\" instead.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TriggerCategorizationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var body = new TriggerCategorizationParams(); // TriggerCategorizationParams | Trigger categorization parameters

            try
            {
                // Trigger categorization
                apiInstance.TriggerCategorization(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.TriggerCategorization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TriggerCategorizationParams**](TriggerCategorizationParams.md)| Trigger categorization parameters | 

### Return type

void (empty response body)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

