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
    public interface ICategoriesApi
    {
        /// <summary>
        /// Create a new category Create a new custom transaction category for the authorized user, that can then be assigned to transactions via PATCH /transactions, and that will also be regarded in finAPI&#39;s automatic transactions categorization process. Must pass the user&#39;s access_token.
        /// </summary>
        /// <param name="body">Parameters of the new category</param>
        /// <returns>Category</returns>
        Category CreateCategory (CategoryParams body);
        /// <summary>
        /// Delete all categories Delete all custom categories of the user that is authorized by the access_token. Must pass the user&#39;s access_token. Note that this deletes both parent categories as well as any related sub-categories.
        /// </summary>
        /// <returns>IdentifierList</returns>
        IdentifierList DeleteAllCategories ();
        /// <summary>
        /// Delete a category Delete a single category of the user that is authorized by the access_token. Must pass the user&#39;s access_token. Note that you can only delete user-custom categories (category&#39;s where the &#39;isCustom&#39; flag is true). Also note that when deleting a parent category, all its sub-categories will be deleted as well.
        /// </summary>
        /// <param name="id">Category identifier</param>
        /// <returns></returns>
        void DeleteCategory (long? id);
        /// <summary>
        /// Edit a category Change the name of a custom transaction category belonging to the authorized user. Must pass the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of the category to edit</param>
        /// <param name="body">New category name</param>
        /// <returns>Category</returns>
        Category EditCategory (long? id, EditCategoryParams body);
        /// <summary>
        /// Get and search all categories Get a list of all global finAPI categories as well as all custom categories of the authorized user. Must pass the user&#39;s access_token. You can set optional search criteria to get only those categories that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="ids">A comma-separated list of category identifiers. If specified, then only categories whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param>
        /// <param name="search">If specified, then only those categories will be contained in the result whose &#39;name&#39; contains the given search string (the matching works case-insensitive). If no categories contain the search string in their name, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the name in order for a category to get included into the result.</param>
        /// <param name="isCustom">If specified, then the result will contain only categories that are either finAPI global (in case of value &#39;false&#39;), or only categories that have been created by the authorized user (in case of value &#39;true&#39;).</param>
        /// <param name="page">Result page that you want to retrieve.</param>
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param>
        /// <param name="order">Determines the order of the results. You can order the results by &#39;id&#39;, &#39;name&#39; and &#39;isCustom&#39;. The default order is &#39;id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/categories?order&#x3D;isCustom,desc&amp;order&#x3D;name&#39; will return all custom categories followed by all default categories. Both groups are ordered ascending by name. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC). </param>
        /// <returns>PageableCategoryList</returns>
        PageableCategoryList GetAndSearchAllCategories (List<long?> ids, string search, bool? isCustom, int? page, int? perPage, List<string> order);
        /// <summary>
        /// Get cash flows Get the cash flow(s) (&#x3D; total income, spending, and balance) for one or several categories. You can specify various criteria such as the time period to calculate the cash flows for, or what categories to do the calculations for. Note that the cash flow for a category may include the cash flows for all of its sub-categories, or not include it, depending on the &#39;includeSubCashFlows&#39; setting. Must pass the user&#39;s access_token.
        /// </summary>
        /// <param name="search">If specified, then only transactions that contain the search term in their purpose or counterpart fields will be contained in the result. Note that the search is case insensitive.</param>
        /// <param name="counterpart">The counterpart is the person or institution that received your payment, or that you made the payment to. If this parameter is specified, then only transactions that contain the given term in one (or more) of their counterpart fields (&#39;counterpartName&#39;, &#39;counterpartAccountNumber&#39;, &#39;counterpartIban&#39;, &#39;counterpartBic&#39; or &#39;counterpartBlz&#39;) will be contained in the result. Note that the search is case insensitive.</param>
        /// <param name="purpose">If specified, then only those transactions will be contained in the result whose purpose field contains the given search string. Note that the search is case insensitive.NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the purpose in order for a transaction to get included into the result.</param>
        /// <param name="accountIds">A comma-separated list of account identifiers. If specified, then only transactions that relate to the given accounts will be regarded. If not specified, then all accounts will be regarded.</param>
        /// <param name="minBankBookingDate">Lower bound for a transaction&#39;s booking date as returned by the bank (&#x3D; original booking date), in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;bankBookingDate&#39; is equal to or later than the given date will be regarded.</param>
        /// <param name="maxBankBookingDate">Upper bound for a transaction&#39;s booking date as returned by the bank (&#x3D; original booking date), in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;bankBookingDate&#39; is equal to or earlier than the given date will be regarded.</param>
        /// <param name="minFinapiBookingDate">Lower bound for a transaction&#39;s booking date as set by finAPI, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). For details about the meaning of the finAPI booking date, please see the field&#39;s documentation in the service&#39;s response.</param>
        /// <param name="maxFinapiBookingDate">Upper bound for a transaction&#39;s booking date as set by finAPI, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). For details about the meaning of the finAPI booking date, please see the field&#39;s documentation in the service&#39;s response.</param>
        /// <param name="minAmount">If specified, then only transactions whose amount is equal to or greater than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95</param>
        /// <param name="maxAmount">If specified, then only transactions whose amount is equal to or less than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95</param>
        /// <param name="direction">If specified, then only transactions with the given direction(s) will be regarded. Use &#39;income&#39; for regarding only received payments (amount &gt;&#x3D; 0), &#39;spending&#39; for regarding only outgoing payments (amount &lt; 0), or &#39;all&#39; to regard both directions. If not specified, the direction defaults to &#39;all&#39;.</param>
        /// <param name="labelIds">A comma-separated list of label identifiers. If specified, then only transactions that have been marked with at least one of the given labels will be contained in the result.</param>
        /// <param name="categoryIds">If specified, then the result will contain only those cash flows that relate to the given categories. Note that the cash flow for a category may include/exclude the cash flows of its sub-categories, depending on the &#39;includeSubCashFlows&#39; setting. To include the cash flow of not categorized transactions, pass the value &#39;0&#39; as categoryId. Note: When this parameter is NOT set, then the result will contain a cash flow for all categories that have transactions associated to them (this includes the &#39;null&#39;-category for the cash flow of not categorized transactions), more precisely: transactions that fulfill the filter criteria. Categories that have no associated transactions according to the filter criteria will not appear in the result. However, when you specify this parameter, then all specified categories will have a cash flow entry in the result, even if there are no associated transactions for the category (the cash flow will have income, spending and balance all set to zero).</param>
        /// <param name="isNew">If specified, then only transactions that have their &#39;isNew&#39; flag set to true/false will be regarded for the cash flow calculations.</param>
        /// <param name="minImportDate">Lower bound for a transaction&#39;s import date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;importDate&#39; is equal to or later than the given date will be regarded.</param>
        /// <param name="maxImportDate">Upper bound for a transaction&#39;s import date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;importDate&#39; is equal to or earlier than the given date will be regarded.</param>
        /// <param name="includeSubCashFlows">If it is true, then the income, spending, balance and count of transactions of a main category results from all transactions that have either this (main) category or any of its subcategories assigned (of course all transactions depends from the other filtering settings); If it is false, then the income, spending, balance and count of transactions of a main category only results from the transactions that have exactly this (main) category assigned. Default value for this parameter is &#39;true&#39;.</param>
        /// <param name="order">Determines the order of the results. You can order the results by &#39;income&#39;, &#39;spending&#39;, &#39;balance&#39;, &#39;category.id&#39; or &#39;category.name&#39;. The default order for this service is &#39;category.id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/cashFlows?order&#x3D;income,desc&amp;order&#x3D;spending,asc&amp;balance,desc&#39; will return as first result the category with the highest income. If two categories have the same income, it returns the category with the highest spending first (because spending is a negative value) and so on. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC). </param>
        /// <returns>CashFlowList</returns>
        CashFlowList GetCashFlows (string search, string counterpart, string purpose, List<long?> accountIds, string minBankBookingDate, string maxBankBookingDate, string minFinapiBookingDate, string maxFinapiBookingDate, decimal? minAmount, decimal? maxAmount, string direction, List<long?> labelIds, List<long?> categoryIds, bool? isNew, string minImportDate, string maxImportDate, bool? includeSubCashFlows, List<string> order);
        /// <summary>
        /// Get a category Get a single category that is either a global finAPI category or a custom category of the authorized user. Must pass the category&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Category identifier</param>
        /// <returns>Category</returns>
        Category GetCategory (long? id);
        /// <summary>
        /// Train categorization This service allows you to create user-specific categorization rules (for the user that is authorized by the access_token). Pass a categorization sample (&#x3D;set of transaction data and a target category), and finAPI will train the user&#39;s categorization rules so that similar transactions will be categorized accordingly in future. Basically, this service behaves the same as when assigning categories to existing transactions via the &#39;Edit a transaction&#39; service, with the difference that you can directly pass transaction data to this service, without the need of having any transactions actually imported in finAPI. Must pass the user&#39;s access_token.
        /// </summary>
        /// <param name="body">Categorization sample</param>
        /// <returns></returns>
        void TrainCategorization (TrainCategorizationData body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CategoriesApi : ICategoriesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CategoriesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CategoriesApi(String basePath)
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
        /// Create a new category Create a new custom transaction category for the authorized user, that can then be assigned to transactions via PATCH /transactions, and that will also be regarded in finAPI&#39;s automatic transactions categorization process. Must pass the user&#39;s access_token.
        /// </summary>
        /// <param name="body">Parameters of the new category</param> 
        /// <returns>Category</returns>            
        public Category CreateCategory (CategoryParams body)
        {
            
    
            var path = "/api/v1/categories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Category) ApiClient.Deserialize(response.Content, typeof(Category), response.Headers);
        }
    
        /// <summary>
        /// Delete all categories Delete all custom categories of the user that is authorized by the access_token. Must pass the user&#39;s access_token. Note that this deletes both parent categories as well as any related sub-categories.
        /// </summary>
        /// <returns>IdentifierList</returns>            
        public IdentifierList DeleteAllCategories ()
        {
            
    
            var path = "/api/v1/categories";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAllCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAllCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentifierList) ApiClient.Deserialize(response.Content, typeof(IdentifierList), response.Headers);
        }
    
        /// <summary>
        /// Delete a category Delete a single category of the user that is authorized by the access_token. Must pass the user&#39;s access_token. Note that you can only delete user-custom categories (category&#39;s where the &#39;isCustom&#39; flag is true). Also note that when deleting a parent category, all its sub-categories will be deleted as well.
        /// </summary>
        /// <param name="id">Category identifier</param> 
        /// <returns></returns>            
        public void DeleteCategory (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteCategory");
            
    
            var path = "/api/v1/categories/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Edit a category Change the name of a custom transaction category belonging to the authorized user. Must pass the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of the category to edit</param> 
        /// <param name="body">New category name</param> 
        /// <returns>Category</returns>            
        public Category EditCategory (long? id, EditCategoryParams body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditCategory");
            
    
            var path = "/api/v1/categories/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EditCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Category) ApiClient.Deserialize(response.Content, typeof(Category), response.Headers);
        }
    
        /// <summary>
        /// Get and search all categories Get a list of all global finAPI categories as well as all custom categories of the authorized user. Must pass the user&#39;s access_token. You can set optional search criteria to get only those categories that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="ids">A comma-separated list of category identifiers. If specified, then only categories whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param> 
        /// <param name="search">If specified, then only those categories will be contained in the result whose &#39;name&#39; contains the given search string (the matching works case-insensitive). If no categories contain the search string in their name, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the name in order for a category to get included into the result.</param> 
        /// <param name="isCustom">If specified, then the result will contain only categories that are either finAPI global (in case of value &#39;false&#39;), or only categories that have been created by the authorized user (in case of value &#39;true&#39;).</param> 
        /// <param name="page">Result page that you want to retrieve.</param> 
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param> 
        /// <param name="order">Determines the order of the results. You can order the results by &#39;id&#39;, &#39;name&#39; and &#39;isCustom&#39;. The default order is &#39;id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/categories?order&#x3D;isCustom,desc&amp;order&#x3D;name&#39; will return all custom categories followed by all default categories. Both groups are ordered ascending by name. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC). </param> 
        /// <returns>PageableCategoryList</returns>            
        public PageableCategoryList GetAndSearchAllCategories (List<long?> ids, string search, bool? isCustom, int? page, int? perPage, List<string> order)
        {
            
    
            var path = "/api/v1/categories";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
 if (isCustom != null) queryParams.Add("isCustom", ApiClient.ParameterToString(isCustom)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("perPage", ApiClient.ParameterToString(perPage)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchAllCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchAllCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageableCategoryList) ApiClient.Deserialize(response.Content, typeof(PageableCategoryList), response.Headers);
        }
    
        /// <summary>
        /// Get cash flows Get the cash flow(s) (&#x3D; total income, spending, and balance) for one or several categories. You can specify various criteria such as the time period to calculate the cash flows for, or what categories to do the calculations for. Note that the cash flow for a category may include the cash flows for all of its sub-categories, or not include it, depending on the &#39;includeSubCashFlows&#39; setting. Must pass the user&#39;s access_token.
        /// </summary>
        /// <param name="search">If specified, then only transactions that contain the search term in their purpose or counterpart fields will be contained in the result. Note that the search is case insensitive.</param> 
        /// <param name="counterpart">The counterpart is the person or institution that received your payment, or that you made the payment to. If this parameter is specified, then only transactions that contain the given term in one (or more) of their counterpart fields (&#39;counterpartName&#39;, &#39;counterpartAccountNumber&#39;, &#39;counterpartIban&#39;, &#39;counterpartBic&#39; or &#39;counterpartBlz&#39;) will be contained in the result. Note that the search is case insensitive.</param> 
        /// <param name="purpose">If specified, then only those transactions will be contained in the result whose purpose field contains the given search string. Note that the search is case insensitive.NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the purpose in order for a transaction to get included into the result.</param> 
        /// <param name="accountIds">A comma-separated list of account identifiers. If specified, then only transactions that relate to the given accounts will be regarded. If not specified, then all accounts will be regarded.</param> 
        /// <param name="minBankBookingDate">Lower bound for a transaction&#39;s booking date as returned by the bank (&#x3D; original booking date), in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;bankBookingDate&#39; is equal to or later than the given date will be regarded.</param> 
        /// <param name="maxBankBookingDate">Upper bound for a transaction&#39;s booking date as returned by the bank (&#x3D; original booking date), in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;bankBookingDate&#39; is equal to or earlier than the given date will be regarded.</param> 
        /// <param name="minFinapiBookingDate">Lower bound for a transaction&#39;s booking date as set by finAPI, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). For details about the meaning of the finAPI booking date, please see the field&#39;s documentation in the service&#39;s response.</param> 
        /// <param name="maxFinapiBookingDate">Upper bound for a transaction&#39;s booking date as set by finAPI, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). For details about the meaning of the finAPI booking date, please see the field&#39;s documentation in the service&#39;s response.</param> 
        /// <param name="minAmount">If specified, then only transactions whose amount is equal to or greater than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95</param> 
        /// <param name="maxAmount">If specified, then only transactions whose amount is equal to or less than the given amount will be regarded. Can contain a positive or negative number with at most two decimal places. Examples: -300.12, or 90.95</param> 
        /// <param name="direction">If specified, then only transactions with the given direction(s) will be regarded. Use &#39;income&#39; for regarding only received payments (amount &gt;&#x3D; 0), &#39;spending&#39; for regarding only outgoing payments (amount &lt; 0), or &#39;all&#39; to regard both directions. If not specified, the direction defaults to &#39;all&#39;.</param> 
        /// <param name="labelIds">A comma-separated list of label identifiers. If specified, then only transactions that have been marked with at least one of the given labels will be contained in the result.</param> 
        /// <param name="categoryIds">If specified, then the result will contain only those cash flows that relate to the given categories. Note that the cash flow for a category may include/exclude the cash flows of its sub-categories, depending on the &#39;includeSubCashFlows&#39; setting. To include the cash flow of not categorized transactions, pass the value &#39;0&#39; as categoryId. Note: When this parameter is NOT set, then the result will contain a cash flow for all categories that have transactions associated to them (this includes the &#39;null&#39;-category for the cash flow of not categorized transactions), more precisely: transactions that fulfill the filter criteria. Categories that have no associated transactions according to the filter criteria will not appear in the result. However, when you specify this parameter, then all specified categories will have a cash flow entry in the result, even if there are no associated transactions for the category (the cash flow will have income, spending and balance all set to zero).</param> 
        /// <param name="isNew">If specified, then only transactions that have their &#39;isNew&#39; flag set to true/false will be regarded for the cash flow calculations.</param> 
        /// <param name="minImportDate">Lower bound for a transaction&#39;s import date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;importDate&#39; is equal to or later than the given date will be regarded.</param> 
        /// <param name="maxImportDate">Upper bound for a transaction&#39;s import date, in the format &#39;YYYY-MM-DD&#39; (e.g. &#39;2016-01-01&#39;). If specified, then only transactions whose &#39;importDate&#39; is equal to or earlier than the given date will be regarded.</param> 
        /// <param name="includeSubCashFlows">If it is true, then the income, spending, balance and count of transactions of a main category results from all transactions that have either this (main) category or any of its subcategories assigned (of course all transactions depends from the other filtering settings); If it is false, then the income, spending, balance and count of transactions of a main category only results from the transactions that have exactly this (main) category assigned. Default value for this parameter is &#39;true&#39;.</param> 
        /// <param name="order">Determines the order of the results. You can order the results by &#39;income&#39;, &#39;spending&#39;, &#39;balance&#39;, &#39;category.id&#39; or &#39;category.name&#39;. The default order for this service is &#39;category.id,asc&#39;. You can also order by multiple properties. In that case the order of the parameters passed is important. Example: &#39;/cashFlows?order&#x3D;income,desc&amp;order&#x3D;spending,asc&amp;balance,desc&#39; will return as first result the category with the highest income. If two categories have the same income, it returns the category with the highest spending first (because spending is a negative value) and so on. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. Please note that ordering by multiple fields is not supported in our swagger frontend, but you can test this feature with any HTTP tool of your choice (e.g. postman or DHC). </param> 
        /// <returns>CashFlowList</returns>            
        public CashFlowList GetCashFlows (string search, string counterpart, string purpose, List<long?> accountIds, string minBankBookingDate, string maxBankBookingDate, string minFinapiBookingDate, string maxFinapiBookingDate, decimal? minAmount, decimal? maxAmount, string direction, List<long?> labelIds, List<long?> categoryIds, bool? isNew, string minImportDate, string maxImportDate, bool? includeSubCashFlows, List<string> order)
        {
            
    
            var path = "/api/v1/categories/cashFlows";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
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
 if (isNew != null) queryParams.Add("isNew", ApiClient.ParameterToString(isNew)); // query parameter
 if (minImportDate != null) queryParams.Add("minImportDate", ApiClient.ParameterToString(minImportDate)); // query parameter
 if (maxImportDate != null) queryParams.Add("maxImportDate", ApiClient.ParameterToString(maxImportDate)); // query parameter
 if (includeSubCashFlows != null) queryParams.Add("includeSubCashFlows", ApiClient.ParameterToString(includeSubCashFlows)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCashFlows: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCashFlows: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CashFlowList) ApiClient.Deserialize(response.Content, typeof(CashFlowList), response.Headers);
        }
    
        /// <summary>
        /// Get a category Get a single category that is either a global finAPI category or a custom category of the authorized user. Must pass the category&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Category identifier</param> 
        /// <returns>Category</returns>            
        public Category GetCategory (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetCategory");
            
    
            var path = "/api/v1/categories/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Category) ApiClient.Deserialize(response.Content, typeof(Category), response.Headers);
        }
    
        /// <summary>
        /// Train categorization This service allows you to create user-specific categorization rules (for the user that is authorized by the access_token). Pass a categorization sample (&#x3D;set of transaction data and a target category), and finAPI will train the user&#39;s categorization rules so that similar transactions will be categorized accordingly in future. Basically, this service behaves the same as when assigning categories to existing transactions via the &#39;Edit a transaction&#39; service, with the difference that you can directly pass transaction data to this service, without the need of having any transactions actually imported in finAPI. Must pass the user&#39;s access_token.
        /// </summary>
        /// <param name="body">Categorization sample</param> 
        /// <returns></returns>            
        public void TrainCategorization (TrainCategorizationData body)
        {
            
    
            var path = "/api/v1/categories/trainCategorization";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TrainCategorization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrainCategorization: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
