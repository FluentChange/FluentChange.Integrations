# IO.Swagger.Api.PaymentsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDirectDebit**](PaymentsApi.md#createdirectdebit) | **POST** /api/v1/payments/directDebits | Create direct debit
[**CreateMoneyTransfer**](PaymentsApi.md#createmoneytransfer) | **POST** /api/v1/payments/moneyTransfers | Create money transfer
[**GetPayments**](PaymentsApi.md#getpayments) | **GET** /api/v1/payments | Get payments
[**SubmitPayment**](PaymentsApi.md#submitpayment) | **POST** /api/v1/payments/submit | Submit payment


<a name="createdirectdebit"></a>
# **CreateDirectDebit**
> Payment CreateDirectDebit (CreateDirectDebitParams body)

Create direct debit

To use this service payments must be enabled by our customer support for your client.<br/><br/>Create a payment for a single or collective direct debit order.<br/>Note that this service only creates a payment resource in finAPI and there is no bank communication involved.<br/>To submit the direct debit to the bank, please call the submitPayment service afterwards.<br/>Existing direct debits can be retrieved by the getPayments service.<br/><br/>A collective direct debit contains more than one order in the 'directDebits' list. It is specially handled by the bank and can be booked by the bank either as a single booking for each order or as a single cumulative booking. The preferred booking type can be given with the 'singleBooking' flag, but it is not guaranteed each bank will regard this flag.<br/><br/>Note: Prior creation of the payment resource is also necessary if you are using finAPI's web form flow.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateDirectDebitExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var body = new CreateDirectDebitParams(); // CreateDirectDebitParams | Create direct debit parameters

            try
            {
                // Create direct debit
                Payment result = apiInstance.CreateDirectDebit(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateDirectDebit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateDirectDebitParams**](CreateDirectDebitParams.md)| Create direct debit parameters | 

### Return type

[**Payment**](Payment.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmoneytransfer"></a>
# **CreateMoneyTransfer**
> Payment CreateMoneyTransfer (CreateMoneyTransferParams body)

Create money transfer

To use this service payments must be enabled by our customer support for your client.<br/><br/>Create a payment for a single or collective money transfer order.<br/>Note that this service only creates a payment resource in finAPI and there is no bank communication involved.<br/>To submit the money transfer to the bank, call the 'Submit payment' service.<br/><br/>A collective money transfer contains more than one order in the 'moneyTransfers' list. It is specially handled by the bank and can be booked by the bank either as one booking for each order, or as a single cumulative booking. The preferred booking type can be given with the 'singleBooking' flag, but it is not guaranteed that every bank will regard this flag.<br/><br/>Note: Creation of a payment resource before using the 'Submit payment' service is also necessary if you are using finAPI's web form flow.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateMoneyTransferExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var body = new CreateMoneyTransferParams(); // CreateMoneyTransferParams | Create money transfer parameters

            try
            {
                // Create money transfer
                Payment result = apiInstance.CreateMoneyTransfer(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateMoneyTransfer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateMoneyTransferParams**](CreateMoneyTransferParams.md)| Create money transfer parameters | 

### Return type

[**Payment**](Payment.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayments"></a>
# **GetPayments**
> PageablePaymentResources GetPayments (List<long?> ids, List<long?> accountIds, decimal? minAmount, decimal? maxAmount, List<string> status, int? page, int? perPage, List<string> order)

Get payments

Get payments of the user that is authorized by the access_token. Must pass the user's access_token.<br/><br/>You can set optional search criteria to get only those payments returned you are interested in.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPaymentsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var ids = new List<long?>(); // List<long?> | A comma-separated list of payment identifiers. If specified, then only payments whose identifier is matching any of the given identifiers will be regarded. The maximum number of identifiers is 1000. (optional) 
            var accountIds = new List<long?>(); // List<long?> | A comma-separated list of account identifiers. If specified, then only payments that relate to the given account(s) will be regarded. The maximum number of identifiers is 1000. (optional) 
            var minAmount = 8.14;  // decimal? | If specified, then only those payments are regarded whose (absolute) total amount is equal or greater than the given amount will be regarded. The value must be a positive (absolute) amount. (optional) 
            var maxAmount = 8.14;  // decimal? | If specified, then only those payments are regarded whose (absolute) total amount is equal or less than the given amount will be regarded. Value must be a positive (absolute) amount. (optional) 
            var status = new List<string>(); // List<string> | A comma-separated list of payment statuses. If provided, then only payments whose status is matching any of the given statuses will be returned. Allowed values 'OPEN', 'PENDING', 'SUCCESSFUL', 'NOT_SUCCESSFUL' or 'DISCARDED'. Example: 'OPEN,PENDING'. (optional) 
            var page = 56;  // int? | Result page that you want to retrieve (optional)  (default to 1)
            var perPage = 56;  // int? | Maximum number of records per page. By default it's 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. (optional)  (default to 20)
            var order = new List<string>(); // List<string> | Determines the order of the results. You can use the following fields for ordering the response: 'id', 'amount', 'requestDate' and 'executionDate'. The default order for all services is 'id,asc'. (optional) 

            try
            {
                // Get payments
                PageablePaymentResources result = apiInstance.GetPayments(ids, accountIds, minAmount, maxAmount, status, page, perPage, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPayments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List<long?>**](long?.md)| A comma-separated list of payment identifiers. If specified, then only payments whose identifier is matching any of the given identifiers will be regarded. The maximum number of identifiers is 1000. | [optional] 
 **accountIds** | [**List<long?>**](long?.md)| A comma-separated list of account identifiers. If specified, then only payments that relate to the given account(s) will be regarded. The maximum number of identifiers is 1000. | [optional] 
 **minAmount** | **decimal?**| If specified, then only those payments are regarded whose (absolute) total amount is equal or greater than the given amount will be regarded. The value must be a positive (absolute) amount. | [optional] 
 **maxAmount** | **decimal?**| If specified, then only those payments are regarded whose (absolute) total amount is equal or less than the given amount will be regarded. Value must be a positive (absolute) amount. | [optional] 
 **status** | [**List<string>**](string.md)| A comma-separated list of payment statuses. If provided, then only payments whose status is matching any of the given statuses will be returned. Allowed values &#39;OPEN&#39;, &#39;PENDING&#39;, &#39;SUCCESSFUL&#39;, &#39;NOT_SUCCESSFUL&#39; or &#39;DISCARDED&#39;. Example: &#39;OPEN,PENDING&#39;. | [optional] 
 **page** | **int?**| Result page that you want to retrieve | [optional] [default to 1]
 **perPage** | **int?**| Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes. | [optional] [default to 20]
 **order** | [**List<string>**](string.md)| Determines the order of the results. You can use the following fields for ordering the response: &#39;id&#39;, &#39;amount&#39;, &#39;requestDate&#39; and &#39;executionDate&#39;. The default order for all services is &#39;id,asc&#39;. | [optional] 

### Return type

[**PageablePaymentResources**](PageablePaymentResources.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitpayment"></a>
# **SubmitPayment**
> Payment SubmitPayment (SubmitPaymentParams body)

Submit payment

To use this service payments must be enabled by our customer support for your client.<br/><br/>Submit a payment to the bank which was previously created with either the createMoneyTransfer or createDirectDebit service.<br/><br/>Before you submit the payment, please check that the given bank interface supports the required payment capabilities, otherwise the payment could get rejected.<br/>If the account has been imported via finAPI, then you could check the capabilities on the account level. Please refer to the field AccountInterface.capabilities.<br/>In case the payment is initiated from a given IBAN, please refer to the field BankInterface.isMoneyTransferSupported.<br/><br/>Usually banks require a multi-step authentication to authorize the payment. In this case, and if the finAPI web form flow is not used, the service will respond with HTTP code 510 and an error object containing a multiStepAuthentication object which describes the necessary next authentication steps. You must then retry the service call, passing the same arguments plus an additional 'multiStepAuthentication' element.<br/>Please refer to the description of the HTTP 510 error code below and the documentation of the 'MultiStepAuthenticationCallback' response object for details.<br/><br/>NOTE: Depending on your license, this service may respond with HTTP code 451, containing an error message with a identifier of web form in it. In addition to that the response will also have included a 'Location' header, which contains the URL to the web form. In this case, you must forward your user to finAPI's web form. For a detailed explanation of the Web Form Flow, please refer to this article: <a href='https://finapi.zendesk.com/hc/en-us/articles/360002596391' target='_blank'>finAPI's Web Form Flow</a><br/><br/>NOTE: For XS2A interface additional headers must be included in the request if the end user is involved. Please refer to the 'General Information/User metadata' section of the swagger documentation.<br/><br/>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SubmitPaymentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: finapi_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var body = new SubmitPaymentParams(); // SubmitPaymentParams | Parameters for payment submission

            try
            {
                // Submit payment
                Payment result = apiInstance.SubmitPayment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.SubmitPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmitPaymentParams**](SubmitPaymentParams.md)| Parameters for payment submission | 

### Return type

[**Payment**](Payment.md)

### Authorization

[finapi_auth](../README.md#finapi_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

