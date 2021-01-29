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
    public interface ILabelsApi
    {
        /// <summary>
        /// Create a new label Create a new label for a specific user. Must pass the new label&#39;s name and the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;Users can create labels to flag transactions (see method PATCH /transactions), with the goal of collecting and getting an overview of all transactions of a certain &#39;type&#39;. In this sense, labels are similar to transaction categories. However, labels are supposed to depict more of an implicit meaning of a transaction. For instance, a user might want to assign a flag to a transaction that reminds him that he can offset it against tax. At the same time, the category of the transactions might be something like &#39;insurance&#39;, which is a more &#39;fact-based&#39;, or &#39;objective&#39; way of typing the transaction. Despite this semantic difference between categories and labels, there is also the difference that a transaction can be assigned multiple labels at the same time (while in contrast it can have just a single category).
        /// </summary>
        /// <param name="body">Label&#39;s name</param>
        /// <returns>Label</returns>
        Label CreateLabel (LabelParams body);
        /// <summary>
        /// Delete all labels Delete all labels of the user that is authorized by the access_token. Must pass the user&#39;s access_token.
        /// </summary>
        /// <returns>IdentifierList</returns>
        IdentifierList DeleteAllLabels ();
        /// <summary>
        /// Delete a label Delete a single label of the user that is authorized by the access_token. Must pass the label&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of the label to delete</param>
        /// <returns></returns>
        void DeleteLabel (long? id);
        /// <summary>
        /// Edit a label Change the name of a label of the user that is authorized by the access_token. Must pass the label&#39;s identifier, the label&#39;s new name and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Label&#39;s identifier</param>
        /// <param name="body">Label&#39;s new name</param>
        /// <returns>Label</returns>
        Label EditLabel (long? id, LabelParams body);
        /// <summary>
        /// Get and search all labels Get labels of the user that is authorized by the access_token. Must pass the user&#39;s access_token. You can set optional search criteria to get only those labels that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="ids">A comma-separated list of label identifiers. If specified, then only labels whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param>
        /// <param name="search">If specified, then only those labels will be contained in the result whose &#39;name&#39; contains the given search string (the matching works case-insensitive). If no labels contain the search string in their name, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the name in order for a label to get included into the result.</param>
        /// <param name="page">Result page that you want to retrieve</param>
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param>
        /// <param name="order">Determines the order of the results. You can order the results by &#39;id&#39; or &#39;name&#39;. The default order for all services is &#39;id,asc&#39;. Since both fields (id and name) are unique, ordering by multiple fields is pointless. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. </param>
        /// <returns>PageableLabelList</returns>
        PageableLabelList GetAndSearchAllLabels (List<long?> ids, string search, int? page, int? perPage, List<string> order);
        /// <summary>
        /// Get a label Get a single label of the user that is authorized by the access_token. Must pass the label&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of requested label</param>
        /// <returns>Label</returns>
        Label GetLabel (long? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LabelsApi : ILabelsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LabelsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LabelsApi(String basePath)
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
        /// Create a new label Create a new label for a specific user. Must pass the new label&#39;s name and the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;Users can create labels to flag transactions (see method PATCH /transactions), with the goal of collecting and getting an overview of all transactions of a certain &#39;type&#39;. In this sense, labels are similar to transaction categories. However, labels are supposed to depict more of an implicit meaning of a transaction. For instance, a user might want to assign a flag to a transaction that reminds him that he can offset it against tax. At the same time, the category of the transactions might be something like &#39;insurance&#39;, which is a more &#39;fact-based&#39;, or &#39;objective&#39; way of typing the transaction. Despite this semantic difference between categories and labels, there is also the difference that a transaction can be assigned multiple labels at the same time (while in contrast it can have just a single category).
        /// </summary>
        /// <param name="body">Label&#39;s name</param> 
        /// <returns>Label</returns>            
        public Label CreateLabel (LabelParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateLabel");
            
    
            var path = "/api/v1/labels";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateLabel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateLabel: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Label) ApiClient.Deserialize(response.Content, typeof(Label), response.Headers);
        }
    
        /// <summary>
        /// Delete all labels Delete all labels of the user that is authorized by the access_token. Must pass the user&#39;s access_token.
        /// </summary>
        /// <returns>IdentifierList</returns>            
        public IdentifierList DeleteAllLabels ()
        {
            
    
            var path = "/api/v1/labels";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAllLabels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAllLabels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentifierList) ApiClient.Deserialize(response.Content, typeof(IdentifierList), response.Headers);
        }
    
        /// <summary>
        /// Delete a label Delete a single label of the user that is authorized by the access_token. Must pass the label&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of the label to delete</param> 
        /// <returns></returns>            
        public void DeleteLabel (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteLabel");
            
    
            var path = "/api/v1/labels/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLabel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLabel: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Edit a label Change the name of a label of the user that is authorized by the access_token. Must pass the label&#39;s identifier, the label&#39;s new name and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Label&#39;s identifier</param> 
        /// <param name="body">Label&#39;s new name</param> 
        /// <returns>Label</returns>            
        public Label EditLabel (long? id, LabelParams body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditLabel");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling EditLabel");
            
    
            var path = "/api/v1/labels/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EditLabel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditLabel: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Label) ApiClient.Deserialize(response.Content, typeof(Label), response.Headers);
        }
    
        /// <summary>
        /// Get and search all labels Get labels of the user that is authorized by the access_token. Must pass the user&#39;s access_token. You can set optional search criteria to get only those labels that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="ids">A comma-separated list of label identifiers. If specified, then only labels whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param> 
        /// <param name="search">If specified, then only those labels will be contained in the result whose &#39;name&#39; contains the given search string (the matching works case-insensitive). If no labels contain the search string in their name, then the result will be an empty list. NOTE: If the given search string consists of several terms (separated by whitespace), then ALL of these terms must be contained in the name in order for a label to get included into the result.</param> 
        /// <param name="page">Result page that you want to retrieve</param> 
        /// <param name="perPage">Maximum number of records per page. By default it&#39;s 20. Can be at most 500. NOTE: Due to its validation and visualization, the swagger frontend might show very low performance, or even crashes, when a service responds with a lot of data. It is recommended to use a HTTP client like Postman or DHC instead of our swagger frontend for service calls with large page sizes.</param> 
        /// <param name="order">Determines the order of the results. You can order the results by &#39;id&#39; or &#39;name&#39;. The default order for all services is &#39;id,asc&#39;. Since both fields (id and name) are unique, ordering by multiple fields is pointless. The general format is: &#39;property[,asc|desc]&#39;, with &#39;asc&#39; being the default value. </param> 
        /// <returns>PageableLabelList</returns>            
        public PageableLabelList GetAndSearchAllLabels (List<long?> ids, string search, int? page, int? perPage, List<string> order)
        {
            
    
            var path = "/api/v1/labels";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("perPage", ApiClient.ParameterToString(perPage)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchAllLabels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAndSearchAllLabels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageableLabelList) ApiClient.Deserialize(response.Content, typeof(PageableLabelList), response.Headers);
        }
    
        /// <summary>
        /// Get a label Get a single label of the user that is authorized by the access_token. Must pass the label&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of requested label</param> 
        /// <returns>Label</returns>            
        public Label GetLabel (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetLabel");
            
    
            var path = "/api/v1/labels/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLabel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLabel: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Label) ApiClient.Deserialize(response.Content, typeof(Label), response.Headers);
        }
    
    }
}
