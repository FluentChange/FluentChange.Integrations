using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentsApi
    {
        /// <summary>
        /// Create direct debit To use this service payments must be enabled by our customer support for your client.&lt;br/&gt;&lt;br/&gt;Create a payment for a single or collective direct debit order.&lt;br/&gt;Note that this service only creates a payment resource in finAPI and there is no bank communication involved.&lt;br/&gt;To submit the direct debit to the bank, please call the submitPayment service afterwards.&lt;br/&gt;Existing direct debits can be retrieved by the getPayments service.&lt;br/&gt;&lt;br/&gt;A collective direct debit contains more than one order in the &#39;directDebits&#39; list. It is specially handled by the bank and can be booked by the bank either as a single booking for each order or as a single cumulative booking. The preferred booking type can be given with the &#39;singleBooking&#39; flag, but it is not guaranteed each bank will regard this flag.&lt;br/&gt;&lt;br/&gt;Note: Prior creation of the payment resource is also necessary if you are using finAPI&#39;s web form flow.
        /// </summary>
        /// <param name="body">Create direct debit parameters</param>
        /// <returns>Payment</returns>
        Payment CreateDirectDebit (CreateDirectDebitParams body);
        /// <summary>
        /// Create money transfer To use this service payments must be enabled by our customer support for your client.&lt;br/&gt;&lt;br/&gt;Create a payment for a single or collective money transfer order.&lt;br/&gt;Note that this service only creates a payment resource in finAPI and there is no bank communication involved.&lt;br/&gt;To submit the money transfer to the bank, call the &#39;Submit payment&#39; service.&lt;br/&gt;&lt;br/&gt;A collective money transfer contains more than one order in the &#39;moneyTransfers&#39; list. It is specially handled by the bank and can be booked by the bank either as one booking for each order, or as a single cumulative booking. The preferred booking type can be given with the &#39;singleBooking&#39; flag, but it is not guaranteed that every bank will regard this flag.&lt;br/&gt;&lt;br/&gt;Note: Creation of a payment resource before using the &#39;Submit payment&#39; service is also necessary if you are using finAPI&#39;s web form flow.
        /// </summary>
        /// <param name="body">Create money transfer parameters</param>
        /// <returns>Payment</returns>
        Payment CreateMoneyTransfer (CreateMoneyTransferParams body);
        /// <summary>
        /// Get payments Get payments of the user that is authorized by the access_token. Must pass the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;You can set optional search criteria to get only those payments returned you are interested in.
        /// </summary>
        /// <param name="ids">A comma-separated list of payment identifiers. If specified, then only payments whose identifier is matching any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param>
        /// <param name="accountIds">A comma-separated list of account identifiers. If specified, then only payments that relate to the given account(s) will be regarded. The maximum number of identifiers is 1000.</param>
        /// <param name="minAmount">If specified, then only those payments are regarded whose (absolute) total amount is equal or greater than the given amount will be regarded. The value must be a positive (absolute) amount.</param>
        /// <param name="maxAmount">If specified, then only those payments are regarded whose (absolute) total amount is equal or less than the given amount will be regarded. Value must be a positive (absolute) amount.</param>
        /// <param name="status">A comma-separated list of payment statuses. If provided, then only payments whose status is matching any of the given statuses will be returned. Allowed values &#39;OPEN&#39;, &#39;PENDING&#39;, &#39;SUCCESSFUL&#39;, &#39;NOT_SUCCESSFUL&#39; or &#39;DISCARDED&#39;. Example: &#39;OPEN,PENDING&#39;.</param>
        /// <param name="page">Result page that you want to retrieve</param>
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param>
        /// <param name="order">Determines the order of the results. You can use the following fields for ordering the response: &#39;id&#39;, &#39;amount&#39;, &#39;requestDate&#39; and &#39;executionDate&#39;. The default order for all services is &#39;id,asc&#39;.</param>
        /// <returns>PageablePaymentResources</returns>
        PageablePaymentResources GetPayments (List<long?> ids, List<long?> accountIds, decimal? minAmount, decimal? maxAmount, List<string> status, int? page, int? perPage, List<string> order);
        /// <summary>
        /// Submit payment To use this service payments must be enabled by our customer support for your client.&lt;br/&gt;&lt;br/&gt;Submit a payment to the bank which was previously created with either the createMoneyTransfer or createDirectDebit service.&lt;br/&gt;&lt;br/&gt;Before you submit the payment, please check that the given bank interface supports the required payment capabilities, otherwise the payment could get rejected.&lt;br/&gt;If the account has been imported via finAPI, then you could check the capabilities on the account level. Please refer to the field AccountInterface.capabilities.&lt;br/&gt;In case the payment is initiated from a given IBAN, please refer to the field BankInterface.isMoneyTransferSupported.&lt;br/&gt;&lt;br/&gt;Usually banks require a multi-step authentication to authorize the payment. In this case, and if the finAPI web form flow is not used, the service will respond with HTTP code 510 and an error object containing a multiStepAuthentication object which describes the necessary next authentication steps. You must then retry the service call, passing the same arguments plus an additional &#39;multiStepAuthentication&#39; element.&lt;br/&gt;Please refer to the description of the HTTP 510 error code below and the documentation of the &#39;MultiStepAuthenticationCallback&#39; response object for details.&lt;br/&gt;&lt;br/&gt;NOTE: Depending on your license, this service may respond with HTTP code 451, containing an error message with a identifier of web form in it. In addition to that the response will also have included a &#39;Location&#39; header, which contains the URL to the web form. In this case, you must forward your user to finAPI&#39;s web form. For a detailed explanation of the Web Form Flow, please refer to this article: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/360002596391&#39; target&#x3D;&#39;_blank&#39;&gt;finAPI&#39;s Web Form Flow&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;NOTE: For XS2A interface additional headers must be included in the request if the end user is involved. Please refer to the &#39;General Information/User metadata&#39; section of the swagger documentation.&lt;br/&gt;&lt;br/&gt;
        /// </summary>
        /// <param name="body">Parameters for payment submission</param>
        /// <returns>Payment</returns>
        Payment SubmitPayment (SubmitPaymentParams body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentsApi : IPaymentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Create direct debit To use this service payments must be enabled by our customer support for your client.&lt;br/&gt;&lt;br/&gt;Create a payment for a single or collective direct debit order.&lt;br/&gt;Note that this service only creates a payment resource in finAPI and there is no bank communication involved.&lt;br/&gt;To submit the direct debit to the bank, please call the submitPayment service afterwards.&lt;br/&gt;Existing direct debits can be retrieved by the getPayments service.&lt;br/&gt;&lt;br/&gt;A collective direct debit contains more than one order in the &#39;directDebits&#39; list. It is specially handled by the bank and can be booked by the bank either as a single booking for each order or as a single cumulative booking. The preferred booking type can be given with the &#39;singleBooking&#39; flag, but it is not guaranteed each bank will regard this flag.&lt;br/&gt;&lt;br/&gt;Note: Prior creation of the payment resource is also necessary if you are using finAPI&#39;s web form flow.
        /// </summary>
        /// <param name="body">Create direct debit parameters</param> 
        /// <returns>Payment</returns>            
        public Payment CreateDirectDebit (CreateDirectDebitParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateDirectDebit");
            
    
            var path = "/api/v1/payments/directDebits";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDirectDebit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDirectDebit: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Payment) ApiClient.Deserialize(response.Content, typeof(Payment), response.Headers);
        }
    
        /// <summary>
        /// Create money transfer To use this service payments must be enabled by our customer support for your client.&lt;br/&gt;&lt;br/&gt;Create a payment for a single or collective money transfer order.&lt;br/&gt;Note that this service only creates a payment resource in finAPI and there is no bank communication involved.&lt;br/&gt;To submit the money transfer to the bank, call the &#39;Submit payment&#39; service.&lt;br/&gt;&lt;br/&gt;A collective money transfer contains more than one order in the &#39;moneyTransfers&#39; list. It is specially handled by the bank and can be booked by the bank either as one booking for each order, or as a single cumulative booking. The preferred booking type can be given with the &#39;singleBooking&#39; flag, but it is not guaranteed that every bank will regard this flag.&lt;br/&gt;&lt;br/&gt;Note: Creation of a payment resource before using the &#39;Submit payment&#39; service is also necessary if you are using finAPI&#39;s web form flow.
        /// </summary>
        /// <param name="body">Create money transfer parameters</param> 
        /// <returns>Payment</returns>            
        public Payment CreateMoneyTransfer (CreateMoneyTransferParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateMoneyTransfer");
            
    
            var path = "/api/v1/payments/moneyTransfers";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateMoneyTransfer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateMoneyTransfer: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Payment) ApiClient.Deserialize(response.Content, typeof(Payment), response.Headers);
        }
    
        /// <summary>
        /// Get payments Get payments of the user that is authorized by the access_token. Must pass the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;You can set optional search criteria to get only those payments returned you are interested in.
        /// </summary>
        /// <param name="ids">A comma-separated list of payment identifiers. If specified, then only payments whose identifier is matching any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param> 
        /// <param name="accountIds">A comma-separated list of account identifiers. If specified, then only payments that relate to the given account(s) will be regarded. The maximum number of identifiers is 1000.</param> 
        /// <param name="minAmount">If specified, then only those payments are regarded whose (absolute) total amount is equal or greater than the given amount will be regarded. The value must be a positive (absolute) amount.</param> 
        /// <param name="maxAmount">If specified, then only those payments are regarded whose (absolute) total amount is equal or less than the given amount will be regarded. Value must be a positive (absolute) amount.</param> 
        /// <param name="status">A comma-separated list of payment statuses. If provided, then only payments whose status is matching any of the given statuses will be returned. Allowed values &#39;OPEN&#39;, &#39;PENDING&#39;, &#39;SUCCESSFUL&#39;, &#39;NOT_SUCCESSFUL&#39; or &#39;DISCARDED&#39;. Example: &#39;OPEN,PENDING&#39;.</param> 
        /// <param name="page">Result page that you want to retrieve</param> 
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param> 
        /// <param name="order">Determines the order of the results. You can use the following fields for ordering the response: &#39;id&#39;, &#39;amount&#39;, &#39;requestDate&#39; and &#39;executionDate&#39;. The default order for all services is &#39;id,asc&#39;.</param> 
        /// <returns>PageablePaymentResources</returns>            
        public PageablePaymentResources GetPayments (List<long?> ids, List<long?> accountIds, decimal? minAmount, decimal? maxAmount, List<string> status, int? page, int? perPage, List<string> order)
        {
            
    
            var path = "/api/v1/payments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
 if (accountIds != null) queryParams.Add("accountIds", ApiClient.ParameterToString(accountIds)); // query parameter
 if (minAmount != null) queryParams.Add("minAmount", ApiClient.ParameterToString(minAmount)); // query parameter
 if (maxAmount != null) queryParams.Add("maxAmount", ApiClient.ParameterToString(maxAmount)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("perPage", ApiClient.ParameterToString(perPage)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPayments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPayments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageablePaymentResources) ApiClient.Deserialize(response.Content, typeof(PageablePaymentResources), response.Headers);
        }
    
        /// <summary>
        /// Submit payment To use this service payments must be enabled by our customer support for your client.&lt;br/&gt;&lt;br/&gt;Submit a payment to the bank which was previously created with either the createMoneyTransfer or createDirectDebit service.&lt;br/&gt;&lt;br/&gt;Before you submit the payment, please check that the given bank interface supports the required payment capabilities, otherwise the payment could get rejected.&lt;br/&gt;If the account has been imported via finAPI, then you could check the capabilities on the account level. Please refer to the field AccountInterface.capabilities.&lt;br/&gt;In case the payment is initiated from a given IBAN, please refer to the field BankInterface.isMoneyTransferSupported.&lt;br/&gt;&lt;br/&gt;Usually banks require a multi-step authentication to authorize the payment. In this case, and if the finAPI web form flow is not used, the service will respond with HTTP code 510 and an error object containing a multiStepAuthentication object which describes the necessary next authentication steps. You must then retry the service call, passing the same arguments plus an additional &#39;multiStepAuthentication&#39; element.&lt;br/&gt;Please refer to the description of the HTTP 510 error code below and the documentation of the &#39;MultiStepAuthenticationCallback&#39; response object for details.&lt;br/&gt;&lt;br/&gt;NOTE: Depending on your license, this service may respond with HTTP code 451, containing an error message with a identifier of web form in it. In addition to that the response will also have included a &#39;Location&#39; header, which contains the URL to the web form. In this case, you must forward your user to finAPI&#39;s web form. For a detailed explanation of the Web Form Flow, please refer to this article: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/360002596391&#39; target&#x3D;&#39;_blank&#39;&gt;finAPI&#39;s Web Form Flow&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;NOTE: For XS2A interface additional headers must be included in the request if the end user is involved. Please refer to the &#39;General Information/User metadata&#39; section of the swagger documentation.&lt;br/&gt;&lt;br/&gt;
        /// </summary>
        /// <param name="body">Parameters for payment submission</param> 
        /// <returns>Payment</returns>            
        public Payment SubmitPayment (SubmitPaymentParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SubmitPayment");
            
    
            var path = "/api/v1/payments/submit";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SubmitPayment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SubmitPayment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Payment) ApiClient.Deserialize(response.Content, typeof(Payment), response.Headers);
        }
    
    }
}
