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
    public interface ITransactionsApi
    {
        /// <summary>
        /// Delete all transactions Delete a set, or the entirety, of transactions of the currently authorized user.
        /// </summary>
        /// <param name="maxDeletionDate">If specified, then only those transactions are being deleted whose &#39;finapiBookingDate&#39; is equal to or earlier to the given date. The date may not be in future, and must be given in the format &#39;YYYY-MM-DD&#39;. If not specified, then no date limitation will be in place for the deletion.</param>
        /// <param name="minImportDate">If specified, then only those transactions are being deleted whose &#39;importDate&#39; is later than or equal to the given date. The date may not be in future, and must be given in the format &#39;YYYY-MM-DD&#39;. This is useful e.g. if a bank returns incorrect transactions and then fixes that issue. Then you could put the date when the error was first observed as &#39;minImportDate&#39;. This would lead to deletion of all transactions after the issue was introduced and allow finAPI to refetch them from scratch. This only works if safeMode is set to false and &#39;rememberDeletion&#39; is undefined or set to false. You also can not use this parameter alongside &#39;maxDeletionDate&#39;.</param>
        /// <param name="accountIds">A comma-separated list of account identifiers. If specified, then only transactions whose account&#39;s identifier is included in this list will be get deleted. The maximum number of identifiers is 1000.</param>
        /// <param name="safeMode">When passing &#39;true&#39;, then only those transactions are being deleted where at least one of the following holds true: 1. The transaction belongs to a &#39;demo connection&#39;; 2. The transaction&#39;s &#39;potentialDuplicate&#39; flag is set to TRUE; 3. The transaction is an adjusting entry (&#39;Zwischensaldo&#39; transaction) that was added by finAPI. When passing &#39;false&#39;, then finAPI will delete transactions independent of these characteristics. The default value for this parameter is &#39;true&#39;.</param>
        /// <param name="rememberDeletion">When passing &#39;true&#39;, then finAPI will make sure to not re-import deleted transactions on future account updates. When &#39;false&#39;, then deleted transactions might be re-imported. Default value for this parameter is &#39;false&#39;.</param>
        /// <returns>IdentifierList</returns>
        IdentifierList DeleteAllTransactions (string maxDeletionDate, string minImportDate, List<long?> accountIds, bool? safeMode, bool? rememberDeletion);
        /// <summary>
        /// Delete a transaction Delete a single transaction of the user that is authorized by the access_token.&lt;br/&gt;&lt;br/&gt; A transaction can only get deleted if at least one of the following holds true:&lt;br/&gt; &amp;bull; The transaction belongs to a &#39;demo connection&#39;&lt;br/&gt; &amp;bull; The transaction&#39;s &#39;potentialDuplicate&#39; flag is set to TRUE&lt;br/&gt; &amp;bull; The transaction is an adjusting entry (&#39;Zwischensaldo&#39; transaction) that was added by finAPI&lt;br/&gt;&lt;br/&gt;Note that the &#39;Delete all transactions&#39; service has additional functionality and allows you to delete transactions that you cannot delete with this service.
        /// </summary>
        /// <param name="id">Identifier of transaction</param>
        /// <returns></returns>
        void DeleteTransaction (long? id);
        /// <summary>
        /// Edit multiple transactions Edit one or multiple transactions. You can edit the following fields: &#39;isNew&#x3D;true|false&#39; and/or &#39;isPotentialDuplicate&#x3D;false&#39; and/or &#39;categoryId&#x3D;&lt;id&gt;&#39; and/or &#39;labelIds&#x3D;[&lt;ids&gt;]&#39;. To clear the category of the given transactions (so that they are no longer categorized), pass the value &#39;0&#39; as the categoryId. To clear the labels of the given transactions, pass an empty array of label identifiers: &#39;[]&#39;. The parameters &#39;categoryId&#39; and &#39;labelIds&#39; are forbidden if &#39;ids&#39; is NOT set (i.e. you cannot update the category or labels for ALL transactions). The result is a list of identifiers of only those transactions that have changed as a result of this service call.
        /// </summary>
        /// <param name="body">Update transactions parameters</param>
        /// <returns>IdentifierList</returns>
        IdentifierList EditMultipleTransactions (UpdateMultipleTransactionsParams body);
        /// <summary>
        /// Edit a transaction Change a transaction&#39;s fields. You can change the following fields: &#39;isNew&#x3D;true|false&#39; and/or &#39;isPotentialDuplicate&#x3D;false&#39; and/or &#39;categoryId&#x3D;&lt;id&gt;&#39; and/or &#39;labelIds&#x3D;[&lt;ids&gt;]&#39;. To clear a transaction&#39;s category (so that it is no longer categorized), pass the value &#39;0&#39; as the categoryId. To clear the labels of the given transaction, pass an empty array of label identifiers: &#39;[]&#39;.
        /// </summary>
        /// <param name="id">Identifier of transaction</param>
        /// <param name="body">Update transactions parameters</param>
        /// <returns>Transaction</returns>
        Transaction EditTransaction (long? id, UpdateTransactionsParams body);
        /// <summary>
        /// Get and search all transactions Get transactions of the user that is authorized by the access_token. Must pass the user&#39;s access_token. You can set optional search criteria to get only those transactions that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="view">This parameter defines finAPI&#39;s logical view on the transactions when querying them: &#39;bankView&#39; regards only the original transactions as they were received from the bank, without considering how the transactions might have gotten split by the user (see POST /transactions/&lt;id&gt;/split). This means that if a transaction is split into logical sub-transactions, then the service will still regard only the original transaction, and NOT the logical sub-transactions in its processing (though for convenience, the transactions will have the data of their sub-transactions included in the response). &#39;userView&#39; by contrast regards the transactions as they exist for the user. For transactions that have not been split into logical sub-transactions, there is no difference to the \&quot;bankView\&quot;. But for transaction that have been split into logical sub-transactions, the service will ONLY regard these sub-transactions, and not the originally received transaction (though for convenience, the sub-transactions will have the identifier of their original transaction included in the response).</param>
        /// <param name="ids">A comma-separated list of transaction identifiers. If specified, then only transactions whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param>
        /// <param name="search">If specified, then only those transactions will be contained in the result whose &#39;purpose&#39; or counterpart fields contain the given search string (the matching works case-insensitive). If no transactions contain the search string in any of these fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for a transaction to get included into the result.</param>
        /// <param name="counterpart">If specified, then only those transactions will be contained in the result whose counterpart fields contain the given search string (the matching works case-insensitive). If no transactions contain the search string in any of the counterpart fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for a transaction to get included into the result.</param>
        /// <param name="purpose">If specified, then only those transactions will be contained in the result whose purpose field contains the given search string (the matching works case-insensitive). If no transactions contain the search string in the purpose field, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the purpose in order for a transaction to get included into the result.</param>
        /// <param name="accountIds">A comma-separated list of account identifiers. If specified, then only transactions that relate to the given accounts will be regarded. If not specified, then all accounts will be regarded.</param>
        /// <param name="minBankBookingDate">Lower bound for a transaction&#39;s booking date as returned by the bank (&#x3D; original booking date), in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;bankBookingDate&#39; is equal to or later than the given date will be regarded.</param>
        /// <param name="maxBankBookingDate">Upper bound for a transaction&#39;s booking date as returned by the bank (&#x3D; original booking date), in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;bankBookingDate&#39; is equal to or earlier than the given date will be regarded.</param>
        /// <param name="minFinapiBookingDate">Lower bound for a transaction&#39;s booking date as set by finAPI, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). For details about the meaning of the finAPI booking date, please see the field&#39;s documentation in the service&#39;s response.</param>
        /// <param name="maxFinapiBookingDate">Upper bound for a transaction&#39;s booking date as set by finAPI, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). For details about the meaning of the finAPI booking date, please see the field&#39;s documentation in the service&#39;s response.</param>
        /// <param name="minAmount">If specified, then only transactions whose amount is equal to or greater than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95</param>
        /// <param name="maxAmount">If specified, then only transactions whose amount is equal to or less than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95</param>
        /// <param name="direction">If specified, then only transactions with the given direction(s) will be regarded. Use &#39;income&#39; for regarding only received payments (amount &gt;&#x3D; 0), &#39;spending&#39; for regarding only outgoing payments (amount &lt; 0), or &#39;all&#39; to regard both directions. If not specified, the direction defaults to &#39;all&#39;.</param>
        /// <param name="labelIds">A comma-separated list of label identifiers. If specified, then only transactions that have been marked with at least one of the given labels will be contained in the result.</param>
        /// <param name="categoryIds">A comma-separated list of category identifiers. If specified, then the result will contain only transactions whose category is either one of the given categories, or - but only if the &#39;includeChildCategories&#39; flag is set to &#39;true&#39; - whose category is a sub-category of one of the given categories. To include transactions without any category, pass the value &#39;0&#39; as the categoryId.</param>
        /// <param name="includeChildCategories">This flag controls how the given &#39;categoryIds&#39; are handled. If set to &#39;true&#39;, then all transactions of a given categoryId, as well as all transactions of any of its sub-categories will be regarded. If set to &#39;false&#39;, then sub-categories of a given categoryId will not be regarded and only those transactions are regarded whose category matches one of the explicitly given categoryIds. The default value for this flag is &#39;true&#39;.</param>
        /// <param name="isNew">If specified, then only transactions that have their &#39;isNew&#39; flag set to true/false will be regarded.</param>
        /// <param name="isPotentialDuplicate">If specified, then only transactions that have their &#39;isPotentialDuplicate&#39; flag set to true/false will be regarded.</param>
        /// <param name="isAdjustingEntry">If specified, then only transactions that have their &#39;isAdjustingEntry&#39; flag set to true/false will be regarded.</param>
        /// <param name="minImportDate">Lower bound for a transaction&#39;s import date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;importDate&#39; is equal to or later than the given date will be regarded.</param>
        /// <param name="maxImportDate">Upper bound for a transaction&#39;s import date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;importDate&#39; is equal to or earlier than the given date will be regarded.</param>
        /// <param name="page">Result page that you want to retrieve.</param>
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param>
        /// <param name="order">Determines the order of the results. You can use the following fields for ordering the response: &#39;id&#39;, &#39;parentId&#39;, &#39;accountId&#39;, &#39;valueDate&#39;, &#39;bankBookingDate&#39;, &#39;finapiBookingDate&#39;, &#39;amount&#39;, &#39;purpose&#39;, &#39;counterpartName&#39;, &#39;counterpartAccountNumber&#39;, &#39;counterpartIban&#39;, &#39;counterpartBlz&#39;, &#39;counterpartBic&#39;, &#39;type&#39;, &#39;primanota&#39;, &#39;category.id&#39;, &#39;category.name&#39;, &#39;isPotentialDuplicate&#39;, &#39;isNew&#39; and &#39;importDate&#39;. The default order for all services is &#39;id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/transactions?order&#x3D;finapiBookingDate,desc&amp;order&#x3D;counterpartName&#39; will return the latest transactions first. If there are more transactions on the same day, then these transactions are ordered by the counterpart name (ascending). The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC). </param>
        /// <returns>PageableTransactionList</returns>
        PageableTransactionList GetAndSearchAllTransactions (string view, List<long?> ids, string search, string counterpart, string purpose, List<long?> accountIds, string minBankBookingDate, string maxBankBookingDate, string minFinapiBookingDate, string maxFinapiBookingDate, decimal? minAmount, decimal? maxAmount, string direction, List<long?> labelIds, List<long?> categoryIds, bool? includeChildCategories, bool? isNew, bool? isPotentialDuplicate, bool? isAdjustingEntry, string minImportDate, string maxImportDate, int? page, int? perPage, List<string> order);
        /// <summary>
        /// Get a transaction Get a single transaction of the user that is authorized by the access_token. Must pass the transaction&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of transaction</param>
        /// <returns>Transaction</returns>
        Transaction GetTransaction (long? id);
        /// <summary>
        /// Restore a transaction Restore a previously split transaction. Removes all of its sub-transactions.
        /// </summary>
        /// <param name="id">Transaction identifier</param>
        /// <returns>Transaction</returns>
        Transaction RestoreTransaction (long? id);
        /// <summary>
        /// Split a transaction Split a transaction into several logical sub-transactions. If the given transaction is split already, all its current sub-transactions will get deleted before the new sub-transactions will get created.
        /// </summary>
        /// <param name="id">Transaction identifier</param>
        /// <param name="body">Split transactions parameters</param>
        /// <returns>Transaction</returns>
        Transaction SplitTransaction (long? id, SplitTransactionsParams body);
        /// <summary>
        /// Trigger categorization Triggers finAPI&#39;s background categorization process for all uncategorized transactions of the given bank connection(s) (or of all of the user&#39;s bank connections, if no bank connection identifiers are passed). The service returns as soon as the categorizations are scheduled. At this point, the bank connections will have their &#39;categorizationStatus&#39; set to &#39;PENDING&#39;. Use the service \&quot;Get a bank connection\&quot; or \&quot;Get all bank connections\&quot; to check when the categorization has finished (this is the case when the categorizationStatus has switched to &#39;READY&#39;).&lt;br/&gt;&lt;br/&gt;Note that if at least one of the target bank connections is currently locked at the time when you call this service (i.e. the bank connection is currently being updated, or another categorization is already scheduled for it), then no categorization will be triggered at all and the service will respond with HTTP code 422.&lt;br/&gt;&lt;br/&gt;Please also note:&lt;br/&gt;&amp;bull; finAPI&#39;s background categorization process is executed automatically whenever you import or update a bank connection (though in case of update, it will categorize only the new transactions, and not re-run categorization for previously imported transactions). This means that in general you do not have to call this service after an import or update. Use this service only when you wish to re-run the categorization of all existing uncategorized transactions.&lt;br/&gt;&amp;bull; if you wish to just manually assign categories to transactions, please use the service \&quot;Edit a transaction\&quot; or \&quot;Edit multiple transactions\&quot; instead.
        /// </summary>
        /// <param name="body">Trigger categorization parameters</param>
        /// <returns></returns>
        void TriggerCategorization (TriggerCategorizationParams body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransactionsApi : ITransactionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TransactionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionsApi(String basePath)
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
        /// Delete all transactions Delete a set, or the entirety, of transactions of the currently authorized user.
        /// </summary>
        /// <param name="maxDeletionDate">If specified, then only those transactions are being deleted whose &#39;finapiBookingDate&#39; is equal to or earlier to the given date. The date may not be in future, and must be given in the format &#39;YYYY-MM-DD&#39;. If not specified, then no date limitation will be in place for the deletion.</param> 
        /// <param name="minImportDate">If specified, then only those transactions are being deleted whose &#39;importDate&#39; is later than or equal to the given date. The date may not be in future, and must be given in the format &#39;YYYY-MM-DD&#39;. This is useful e.g. if a bank returns incorrect transactions and then fixes that issue. Then you could put the date when the error was first observed as &#39;minImportDate&#39;. This would lead to deletion of all transactions after the issue was introduced and allow finAPI to refetch them from scratch. This only works if safeMode is set to false and &#39;rememberDeletion&#39; is undefined or set to false. You also can not use this parameter alongside &#39;maxDeletionDate&#39;.</param> 
        /// <param name="accountIds">A comma-separated list of account identifiers. If specified, then only transactions whose account&#39;s identifier is included in this list will be get deleted. The maximum number of identifiers is 1000.</param> 
        /// <param name="safeMode">When passing &#39;true&#39;, then only those transactions are being deleted where at least one of the following holds true: 1. The transaction belongs to a &#39;demo connection&#39;; 2. The transaction&#39;s &#39;potentialDuplicate&#39; flag is set to TRUE; 3. The transaction is an adjusting entry (&#39;Zwischensaldo&#39; transaction) that was added by finAPI. When passing &#39;false&#39;, then finAPI will delete transactions independent of these characteristics. The default value for this parameter is &#39;true&#39;.</param> 
        /// <param name="rememberDeletion">When passing &#39;true&#39;, then finAPI will make sure to not re-import deleted transactions on future account updates. When &#39;false&#39;, then deleted transactions might be re-imported. Default value for this parameter is &#39;false&#39;.</param> 
        /// <returns>IdentifierList</returns>            
        public IdentifierList DeleteAllTransactions (string maxDeletionDate, string minImportDate, List<long?> accountIds, bool? safeMode, bool? rememberDeletion)
        {
            
    
            var path = "/api/v1/transactions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (maxDeletionDate != null) queryParams.Add("maxDeletionDate", ApiClient.ParameterToString(maxDeletionDate)); // query parameter
 if (minImportDate != null) queryParams.Add("minImportDate", ApiClient.ParameterToString(minImportDate)); // query parameter
 if (accountIds != null) queryParams.Add("accountIds", ApiClient.ParameterToString(accountIds)); // query parameter
 if (safeMode != null) queryParams.Add("safeMode", ApiClient.ParameterToString(safeMode)); // query parameter
 if (rememberDeletion != null) queryParams.Add("rememberDeletion", ApiClient.ParameterToString(rememberDeletion)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAllTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAllTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentifierList) ApiClient.Deserialize(response.Content, typeof(IdentifierList), response.Headers);
        }
    
        /// <summary>
        /// Delete a transaction Delete a single transaction of the user that is authorized by the access_token.&lt;br/&gt;&lt;br/&gt; A transaction can only get deleted if at least one of the following holds true:&lt;br/&gt; &amp;bull; The transaction belongs to a &#39;demo connection&#39;&lt;br/&gt; &amp;bull; The transaction&#39;s &#39;potentialDuplicate&#39; flag is set to TRUE&lt;br/&gt; &amp;bull; The transaction is an adjusting entry (&#39;Zwischensaldo&#39; transaction) that was added by finAPI&lt;br/&gt;&lt;br/&gt;Note that the &#39;Delete all transactions&#39; service has additional functionality and allows you to delete transactions that you cannot delete with this service.
        /// </summary>
        /// <param name="id">Identifier of transaction</param> 
        /// <returns></returns>            
        public void DeleteTransaction (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteTransaction");
            
    
            var path = "/api/v1/transactions/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Edit multiple transactions Edit one or multiple transactions. You can edit the following fields: &#39;isNew&#x3D;true|false&#39; and/or &#39;isPotentialDuplicate&#x3D;false&#39; and/or &#39;categoryId&#x3D;&lt;id&gt;&#39; and/or &#39;labelIds&#x3D;[&lt;ids&gt;]&#39;. To clear the category of the given transactions (so that they are no longer categorized), pass the value &#39;0&#39; as the categoryId. To clear the labels of the given transactions, pass an empty array of label identifiers: &#39;[]&#39;. The parameters &#39;categoryId&#39; and &#39;labelIds&#39; are forbidden if &#39;ids&#39; is NOT set (i.e. you cannot update the category or labels for ALL transactions). The result is a list of identifiers of only those transactions that have changed as a result of this service call.
        /// </summary>
        /// <param name="body">Update transactions parameters</param> 
        /// <returns>IdentifierList</returns>            
        public IdentifierList EditMultipleTransactions (UpdateMultipleTransactionsParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling EditMultipleTransactions");
            
    
            var path = "/api/v1/transactions";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditMultipleTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditMultipleTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentifierList) ApiClient.Deserialize(response.Content, typeof(IdentifierList), response.Headers);
        }
    
        /// <summary>
        /// Edit a transaction Change a transaction&#39;s fields. You can change the following fields: &#39;isNew&#x3D;true|false&#39; and/or &#39;isPotentialDuplicate&#x3D;false&#39; and/or &#39;categoryId&#x3D;&lt;id&gt;&#39; and/or &#39;labelIds&#x3D;[&lt;ids&gt;]&#39;. To clear a transaction&#39;s category (so that it is no longer categorized), pass the value &#39;0&#39; as the categoryId. To clear the labels of the given transaction, pass an empty array of label identifiers: &#39;[]&#39;.
        /// </summary>
        /// <param name="id">Identifier of transaction</param> 
        /// <param name="body">Update transactions parameters</param> 
        /// <returns>Transaction</returns>            
        public Transaction EditTransaction (long? id, UpdateTransactionsParams body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditTransaction");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling EditTransaction");
            
    
            var path = "/api/v1/transactions/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Transaction) ApiClient.Deserialize(response.Content, typeof(Transaction), response.Headers);
        }
    
        /// <summary>
        /// Get and search all transactions Get transactions of the user that is authorized by the access_token. Must pass the user&#39;s access_token. You can set optional search criteria to get only those transactions that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="view">This parameter defines finAPI&#39;s logical view on the transactions when querying them: &#39;bankView&#39; regards only the original transactions as they were received from the bank, without considering how the transactions might have gotten split by the user (see POST /transactions/&lt;id&gt;/split). This means that if a transaction is split into logical sub-transactions, then the service will still regard only the original transaction, and NOT the logical sub-transactions in its processing (though for convenience, the transactions will have the data of their sub-transactions included in the response). &#39;userView&#39; by contrast regards the transactions as they exist for the user. For transactions that have not been split into logical sub-transactions, there is no difference to the \&quot;bankView\&quot;. But for transaction that have been split into logical sub-transactions, the service will ONLY regard these sub-transactions, and not the originally received transaction (though for convenience, the sub-transactions will have the identifier of their original transaction included in the response).</param> 
        /// <param name="ids">A comma-separated list of transaction identifiers. If specified, then only transactions whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param> 
        /// <param name="search">If specified, then only those transactions will be contained in the result whose &#39;purpose&#39; or counterpart fields contain the given search string (the matching works case-insensitive). If no transactions contain the search string in any of these fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for a transaction to get included into the result.</param> 
        /// <param name="counterpart">If specified, then only those transactions will be contained in the result whose counterpart fields contain the given search string (the matching works case-insensitive). If no transactions contain the search string in any of the counterpart fields, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the searched fields in order for a transaction to get included into the result.</param> 
        /// <param name="purpose">If specified, then only those transactions will be contained in the result whose purpose field contains the given search string (the matching works case-insensitive). If no transactions contain the search string in the purpose field, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the purpose in order for a transaction to get included into the result.</param> 
        /// <param name="accountIds">A comma-separated list of account identifiers. If specified, then only transactions that relate to the given accounts will be regarded. If not specified, then all accounts will be regarded.</param> 
        /// <param name="minBankBookingDate">Lower bound for a transaction&#39;s booking date as returned by the bank (&#x3D; original booking date), in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;bankBookingDate&#39; is equal to or later than the given date will be regarded.</param> 
        /// <param name="maxBankBookingDate">Upper bound for a transaction&#39;s booking date as returned by the bank (&#x3D; original booking date), in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;bankBookingDate&#39; is equal to or earlier than the given date will be regarded.</param> 
        /// <param name="minFinapiBookingDate">Lower bound for a transaction&#39;s booking date as set by finAPI, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). For details about the meaning of the finAPI booking date, please see the field&#39;s documentation in the service&#39;s response.</param> 
        /// <param name="maxFinapiBookingDate">Upper bound for a transaction&#39;s booking date as set by finAPI, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). For details about the meaning of the finAPI booking date, please see the field&#39;s documentation in the service&#39;s response.</param> 
        /// <param name="minAmount">If specified, then only transactions whose amount is equal to or greater than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95</param> 
        /// <param name="maxAmount">If specified, then only transactions whose amount is equal to or less than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95</param> 
        /// <param name="direction">If specified, then only transactions with the given direction(s) will be regarded. Use &#39;income&#39; for regarding only received payments (amount &gt;&#x3D; 0), &#39;spending&#39; for regarding only outgoing payments (amount &lt; 0), or &#39;all&#39; to regard both directions. If not specified, the direction defaults to &#39;all&#39;.</param> 
        /// <param name="labelIds">A comma-separated list of label identifiers. If specified, then only transactions that have been marked with at least one of the given labels will be contained in the result.</param> 
        /// <param name="categoryIds">A comma-separated list of category identifiers. If specified, then the result will contain only transactions whose category is either one of the given categories, or - but only if the &#39;includeChildCategories&#39; flag is set to &#39;true&#39; - whose category is a sub-category of one of the given categories. To include transactions without any category, pass the value &#39;0&#39; as the categoryId.</param> 
        /// <param name="includeChildCategories">This flag controls how the given &#39;categoryIds&#39; are handled. If set to &#39;true&#39;, then all transactions of a given categoryId, as well as all transactions of any of its sub-categories will be regarded. If set to &#39;false&#39;, then sub-categories of a given categoryId will not be regarded and only those transactions are regarded whose category matches one of the explicitly given categoryIds. The default value for this flag is &#39;true&#39;.</param> 
        /// <param name="isNew">If specified, then only transactions that have their &#39;isNew&#39; flag set to true/false will be regarded.</param> 
        /// <param name="isPotentialDuplicate">If specified, then only transactions that have their &#39;isPotentialDuplicate&#39; flag set to true/false will be regarded.</param> 
        /// <param name="isAdjustingEntry">If specified, then only transactions that have their &#39;isAdjustingEntry&#39; flag set to true/false will be regarded.</param> 
        /// <param name="minImportDate">Lower bound for a transaction&#39;s import date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;importDate&#39; is equal to or later than the given date will be regarded.</param> 
        /// <param name="maxImportDate">Upper bound for a transaction&#39;s import date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;importDate&#39; is equal to or earlier than the given date will be regarded.</param> 
        /// <param name="page">Result page that you want to retrieve.</param> 
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param> 
        /// <param name="order">Determines the order of the results. You can use the following fields for ordering the response: &#39;id&#39;, &#39;parentId&#39;, &#39;accountId&#39;, &#39;valueDate&#39;, &#39;bankBookingDate&#39;, &#39;finapiBookingDate&#39;, &#39;amount&#39;, &#39;purpose&#39;, &#39;counterpartName&#39;, &#39;counterpartAccountNumber&#39;, &#39;counterpartIban&#39;, &#39;counterpartBlz&#39;, &#39;counterpartBic&#39;, &#39;type&#39;, &#39;primanota&#39;, &#39;category.id&#39;, &#39;category.name&#39;, &#39;isPotentialDuplicate&#39;, &#39;isNew&#39; and &#39;importDate&#39;. The default order for all services is &#39;id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/transactions?order&#x3D;finapiBookingDate,desc&amp;order&#x3D;counterpartName&#39; will return the latest transactions first. If there are more transactions on the same day, then these transactions are ordered by the counterpart name (ascending). The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC). </param> 
        /// <returns>PageableTransactionList</returns>            
        public PageableTransactionList GetAndSearchAllTransactions (string view, List<long?> ids, string search, string counterpart, string purpose, List<long?> accountIds, string minBankBookingDate, string maxBankBookingDate, string minFinapiBookingDate, string maxFinapiBookingDate, decimal? minAmount, decimal? maxAmount, string direction, List<long?> labelIds, List<long?> categoryIds, bool? includeChildCategories, bool? isNew, bool? isPotentialDuplicate, bool? isAdjustingEntry, string minImportDate, string maxImportDate, int? page, int? perPage, List<string> order)
        {
            
            // verify the required parameter 'view' is set
            if (view == null) throw new ApiException(400, "Missing required parameter 'view' when calling GetAndSearchAllTransactions");
            
    
            var path = "/api/v1/transactions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
 if (view != null) queryParams.Add("view", ApiClient.ParameterToString(view)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
 if (counterpart != null) queryParams.Add("counterpart", ApiClient.ParameterToString(counterpart)); // query parameter
 if (purpose != null) queryParams.Add("purpose", ApiClient.ParameterToString(purpose)); // query parameter
 if (accountIds != null) queryParams.Add("accountIds", ApiClient.ParameterToString(accountIds)); // query parameter
 if (minBankBookingDate != null) queryParams.Add("minBankBookingDate", ApiClient.ParameterToString(minBankBookingDate)); // query parameter
 if (maxBankBookingDate != null) queryParams.Add("maxBankBookingDate", ApiClient.ParameterToString(maxBankBookingDate)); // query parameter
 if (minFinapiBookingDate != null) queryParams.Add("minFinapiBookingDate", ApiClient.ParameterToString(minFinapiBookingDate)); // query parameter
 if (maxFinapiBookingDate != null) queryParams.Add("maxFinapiBookingDate", ApiClient.ParameterToString(maxFinapiBookingDate)); // query parameter
 if (minAmount != null) queryParams.Add("minAmount", ApiClient.ParameterToString(minAmount)); // query parameter
 if (maxAmount != null) queryParams.Add("maxAmount", ApiClient.ParameterToString(maxAmount)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (labelIds != null) queryParams.Add("labelIds", ApiClient.ParameterToString(labelIds)); // query parameter
 if (categoryIds != null) queryParams.Add("categoryIds", ApiClient.ParameterToString(categoryIds)); // query parameter
 if (includeChildCategories != null) queryParams.Add("includeChildCategories", ApiClient.ParameterToString(includeChildCategories)); // query parameter
 if (isNew != null) queryParams.Add("isNew", ApiClient.ParameterToString(isNew)); // query parameter
 if (isPotentialDuplicate != null) queryParams.Add("isPotentialDuplicate", ApiClient.ParameterToString(isPotentialDuplicate)); // query parameter
 if (isAdjustingEntry != null) queryParams.Add("isAdjustingEntry", ApiClient.ParameterToString(isAdjustingEntry)); // query parameter
 if (minImportDate != null) queryParams.Add("minImportDate", ApiClient.ParameterToString(minImportDate)); // query parameter
 if (maxImportDate != null) queryParams.Add("maxImportDate", ApiClient.ParameterToString(maxImportDate)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("perPage", ApiClient.ParameterToString(perPage)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchAllTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchAllTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageableTransactionList) ApiClient.Deserialize(response.Content, typeof(PageableTransactionList), response.Headers);
        }
    
        /// <summary>
        /// Get a transaction Get a single transaction of the user that is authorized by the access_token. Must pass the transaction&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of transaction</param> 
        /// <returns>Transaction</returns>            
        public Transaction GetTransaction (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetTransaction");
            
    
            var path = "/api/v1/transactions/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Transaction) ApiClient.Deserialize(response.Content, typeof(Transaction), response.Headers);
        }
    
        /// <summary>
        /// Restore a transaction Restore a previously split transaction. Removes all of its sub-transactions.
        /// </summary>
        /// <param name="id">Transaction identifier</param> 
        /// <returns>Transaction</returns>            
        public Transaction RestoreTransaction (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RestoreTransaction");
            
    
            var path = "/api/v1/transactions/{id}/restore";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RestoreTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RestoreTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Transaction) ApiClient.Deserialize(response.Content, typeof(Transaction), response.Headers);
        }
    
        /// <summary>
        /// Split a transaction Split a transaction into several logical sub-transactions. If the given transaction is split already, all its current sub-transactions will get deleted before the new sub-transactions will get created.
        /// </summary>
        /// <param name="id">Transaction identifier</param> 
        /// <param name="body">Split transactions parameters</param> 
        /// <returns>Transaction</returns>            
        public Transaction SplitTransaction (long? id, SplitTransactionsParams body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SplitTransaction");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SplitTransaction");
            
    
            var path = "/api/v1/transactions/{id}/split";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SplitTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SplitTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Transaction) ApiClient.Deserialize(response.Content, typeof(Transaction), response.Headers);
        }
    
        /// <summary>
        /// Trigger categorization Triggers finAPI&#39;s background categorization process for all uncategorized transactions of the given bank connection(s) (or of all of the user&#39;s bank connections, if no bank connection identifiers are passed). The service returns as soon as the categorizations are scheduled. At this point, the bank connections will have their &#39;categorizationStatus&#39; set to &#39;PENDING&#39;. Use the service \&quot;Get a bank connection\&quot; or \&quot;Get all bank connections\&quot; to check when the categorization has finished (this is the case when the categorizationStatus has switched to &#39;READY&#39;).&lt;br/&gt;&lt;br/&gt;Note that if at least one of the target bank connections is currently locked at the time when you call this service (i.e. the bank connection is currently being updated, or another categorization is already scheduled for it), then no categorization will be triggered at all and the service will respond with HTTP code 422.&lt;br/&gt;&lt;br/&gt;Please also note:&lt;br/&gt;&amp;bull; finAPI&#39;s background categorization process is executed automatically whenever you import or update a bank connection (though in case of update, it will categorize only the new transactions, and not re-run categorization for previously imported transactions). This means that in general you do not have to call this service after an import or update. Use this service only when you wish to re-run the categorization of all existing uncategorized transactions.&lt;br/&gt;&amp;bull; if you wish to just manually assign categories to transactions, please use the service \&quot;Edit a transaction\&quot; or \&quot;Edit multiple transactions\&quot; instead.
        /// </summary>
        /// <param name="body">Trigger categorization parameters</param> 
        /// <returns></returns>            
        public void TriggerCategorization (TriggerCategorizationParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling TriggerCategorization");
            
    
            var path = "/api/v1/transactions/triggerCategorization";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TriggerCategorization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TriggerCategorization: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
