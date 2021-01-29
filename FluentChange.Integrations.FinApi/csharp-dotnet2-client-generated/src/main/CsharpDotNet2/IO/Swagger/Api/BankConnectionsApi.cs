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
    public interface IBankConnectionsApi
    {
        /// <summary>
        /// Connect a new interface Connects new interface to an existing bank connection for a specific user. Must pass the connection credentials and the user&#39;s access_token. All bank accounts will be downloaded and imported with their current balances, transactions and supported two-step-procedures (note that the amount of available transactions may vary between banks, e.g. some banks deliver all transactions from the past year, others only deliver the transactions from the past three months). The balance and transactions download process runs asynchronously, so this service may return before all balances and transactions have been imported. Also, all downloaded transactions will be categorized by a separate background process that runs asynchronously too. To check the status of the balance and transactions download process as well as the background categorization process, see the status flags that are returned by the GET /bankConnections/&lt;id&gt; service.&lt;br/&gt;&lt;br/&gt;NOTE: Depending on your license, this service may respond with HTTP code 451, containing an error message with a identifier of web form in it. In addition to that the response will also have included a &#39;Location&#39; header, which contains the URL to the web form. In this case, you must forward your user to finAPI&#39;s web form. For a detailed explanation of the Web Form Flow, please refer to this article: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/360002596391&#39; target&#x3D;&#39;_blank&#39;&gt;finAPI&#39;s Web Form Flow&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;NOTE: For XS2A interface additional headers must be included in the request if the end user is involved. Please refer to the &#39;General Information/User metadata&#39; section of the swagger documentation.
        /// </summary>
        /// <param name="body">Connect interface parameters</param>
        /// <returns>BankConnection</returns>
        BankConnection ConnectInterface (ConnectInterfaceParams body);
        /// <summary>
        /// Delete a consent Deletes a consent for an interface of a bank connection (on finAPI and on the bank&#39;s side).
        /// </summary>
        /// <param name="id">Identifier of a bank connection</param>
        /// <param name="_interface">Banking interface</param>
        /// <returns>DeleteConsent</returns>
        DeleteConsent DeleteAccessData (long? id, string _interface);
        /// <summary>
        /// Delete all bank connections Delete all bank connections of the user that is authorized by the access_token. Must pass the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;Notes: &lt;br/&gt;- All notification rules that are connected to any specific bank connection will get deleted as well. &lt;br/&gt;- If at least one bank connection is busy (currently in the process of import, update, or transactions categorization), then this service will perform no action at all.
        /// </summary>
        /// <returns>IdentifierList</returns>
        IdentifierList DeleteAllBankConnections ();
        /// <summary>
        /// Delete a bank connection Delete a single bank connection of the user that is authorized by the access_token, including all of its accounts and their transactions and balance data. Must pass the connection&#39;s identifier and the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;Notes: &lt;br/&gt;- All notification rules that are connected to the bank connection will get adjusted so that they no longer have this connection listed. Notification rules that are connected to just this bank connection (and no other connection) will get deleted altogether. &lt;br/&gt;- A bank connection cannot get deleted while it is in the process of import, update, or transactions categorization.
        /// </summary>
        /// <param name="id">Identifier of the bank connection to delete</param>
        /// <returns></returns>
        void DeleteBankConnection (long? id);
        /// <summary>
        /// Edit a bank connection Edit bank connection data. Must pass the connection&#39;s identifier and the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;Note that a bank connection&#39;s credentials cannot be changed while it is in the process of being imported, updated, or connecting a new interface.&lt;br/&gt;&lt;br/&gt;NOTE: Depending on your license, this service may respond with HTTP code 451, containing an error message with a identifier of web form in it. In addition to that the response will also have included a &#39;Location&#39; header, which contains the URL to the web form. In this case, you must forward your user to finAPI&#39;s web form. For a detailed explanation of the Web Form Flow, please refer to this article: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/360002596391&#39; target&#x3D;&#39;_blank&#39;&gt;finAPI&#39;s Web Form Flow&lt;/a&gt;
        /// </summary>
        /// <param name="id">Identifier of the bank connection to change the parameters for</param>
        /// <param name="body">New bank connection parameters</param>
        /// <returns>BankConnection</returns>
        BankConnection EditBankConnection (long? id, EditBankConnectionParams body);
        /// <summary>
        /// Get all bank connections Get bank connections of the user that is authorized by the access_token. Must pass the user&#39;s access_token. You can set optional search criteria to get only those bank connections that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="ids">A comma-separated list of bank connection identifiers. If specified, then only bank connections whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param>
        /// <returns>BankConnectionList</returns>
        BankConnectionList GetAllBankConnections (List<long?> ids);
        /// <summary>
        /// Get a bank connection Get a single bank connection of the user that is authorized by the access_token. Must pass the connection&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of requested bank connection</param>
        /// <returns>BankConnection</returns>
        BankConnection GetBankConnection (long? id);
        /// <summary>
        /// Import a new bank connection Imports a new bank connection for a specific user. Must pass the connection credentials and the user&#39;s access_token. All bank accounts will be downloaded and imported with their current balances, transactions and supported two-step-procedures (note that the amount of available transactions may vary between banks, e.g. some banks deliver all transactions from the past year, others only deliver the transactions from the past three months). The balance and transactions download process runs asynchronously, so this service may return before all balances and transactions have been imported. Also, all downloaded transactions will be categorized by a separate background process that runs asynchronously too. To check the status of the balance and transactions download process as well as the background categorization process, see the status flags that are returned by the GET /bankConnections/&lt;id&gt; service.&lt;br/&gt;&lt;br/&gt;You can also import a \&quot;demo connection\&quot; which contains a single bank account with some pre-defined transactions. To import the demo connection, you need to pass the identifier of the \&quot;finAPI Test Bank\&quot;. In case of demo connection import, any other fields besides the bank identifier can remain unset. The login credentials and the &#39;storeSecrets&#39; field will be stored if you pass them, however they will not be regarded when updating the demo connection (in other words: It doesn&#39;t matter what credentials you choose for the demo connection). Note however that if you want to import the demo connection multiple times for the same user, you must use different login credentials for each of the imports. Also note that the skipPositionsDownload flag is ignored for the demo bank connection, i.e. when importing the demo bank connection, you will always get the transactions for its account. You can enable multi-step authentication for the demo bank connection by setting the bank connection name to \&quot;MSA\&quot;.&lt;br/&gt;&lt;br/&gt;The XS2A interface could also be used to initiate a demo connection import.&lt;br/&gt;The finAPI demo XS2A allows you to download a test account by using the &#39;import&#39; or &#39;connectInterface&#39; services - in general, this XS2A demo account is the FINTS_SERVER demo account, as it has the same account number and origin of balances and transactions.&lt;br/&gt;Keep in mind that calling an XS2A demo connection import will result as a newly created bank connection, while the &#39;connectInterface&#39; service attaches the XS2A demo account to an existing demo connection.&lt;br/&gt;Passing the login credentials is not obligated only for redirect banks, however the demo bank works without any given set of credentials for the XS2A interface. If you are looking to test the XS2A SCA (Strong Customer Authentication, or MSA (Multi-Step Authentication) in the finAPI context), you need to pass the bank connection name as \&quot;MSA\&quot; to trigger the SCA flow or as &#39;DECOUPLED-AUTH&#39; to simulate decoupled authentication. To get better understanding about the Multi-Step Authentication, please refer to the &#39;Error Messages&#39; section of the swagger documentation.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;For a more in-depth understanding of the import process, please also read this article on our Dev Portal: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115000296607-Import-Update-of-Bank-Connections-Accounts&#39; target&#x3D;&#39;_blank&#39;&gt;Import &amp; Update of Bank Connections / Accounts&lt;/a&gt;&lt;/b&gt;&lt;br/&gt;&lt;br/&gt;NOTE: Depending on your license, this service may respond with HTTP code 451, containing an error message with a identifier of web form in it. In addition to that the response will also have included a &#39;Location&#39; header, which contains the URL to the web form. In this case, you must forward your user to finAPI&#39;s web form. For a detailed explanation of the Web Form Flow, please refer to this article: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/360002596391&#39; target&#x3D;&#39;_blank&#39;&gt;finAPI&#39;s Web Form Flow&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;NOTE: For XS2A interface additional headers must be included in the request if the end user is involved. Please refer to the &#39;General Information/User metadata&#39; section of the swagger documentation.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Attention:&lt;/b&gt; Due to changes on the bank&#39;s side we have been forced to limit the maxDaysForDownload field to 89 days to reduce the risk of strong customer authentication (SCA) requests. If you have implemented the SCA flow, please contact us, so that we can remove this limitation from your client.
        /// </summary>
        /// <param name="body">Import bank connection parameters</param>
        /// <returns>BankConnection</returns>
        BankConnection ImportBankConnection (ImportBankConnectionParams body);
        /// <summary>
        /// Remove an interface Remove an interface from bank connection and from all associated accounts in the bank connection. Notes: &lt;br/&gt;- An interface cannot get deleted while it is in the process of import or update.
        /// </summary>
        /// <param name="body">Remove interface parameters</param>
        /// <returns></returns>
        void RemoveInterface (RemoveInterfaceParams body);
        /// <summary>
        /// Update a bank connection Update an existing bank connection of the user that is authorized by the access_token. Downloads and imports the current account balances and new transactions. Note that if the bank connection has several interfaces and some of its accounts was previously imported or updated via an interface which have higher priority than the interface used in the current update, then balances and transactions will not be downloaded for such accounts (The XS2A interface has the highest priority, followed by FINTS_SERVER and finally WEB_SCRAPER). Must pass the connection&#39;s identifier and the user&#39;s access_token. For more information about the processes of authentication, data download and transactions categorization, see POST /bankConnections/import. Note that supported two-step-procedures are updated as well. It may unset the current default two-step-procedure of the given bank connection (but only if this procedure is not supported anymore by the bank). You can also update the \&quot;demo connection\&quot; (in this case, secret login credentials and the fields &#39;importNewAccounts&#39; and &#39;skipPositionsDownload&#39; will be ignored).&lt;br/&gt;&lt;br/&gt;Note that you cannot trigger an update of a bank connection as long as there is still a previously triggered update running.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;For a more in-depth understanding of the update process, please also read this article on our Dev Portal: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115000296607-Import-Update-of-Bank-Connections-Accounts&#39; target&#x3D;&#39;_blank&#39;&gt;Import &amp; Update of Bank Connections / Accounts&lt;/a&gt;&lt;/b&gt;&lt;br/&gt;&lt;br/&gt;NOTE: Depending on your license, this service may respond with HTTP code 451, containing an error message with a identifier of web form in it. In addition to that the response will also have included a &#39;Location&#39; header, which contains the URL to the web form. In this case, you must forward your user to finAPI&#39;s web form. For a detailed explanation of the Web Form Flow, please refer to this article: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/360002596391&#39; target&#x3D;&#39;_blank&#39;&gt;finAPI&#39;s Web Form Flow&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;NOTE: For XS2A interface additional headers must be included in the request if the end user is involved. Please refer to the &#39;General Information/User metadata&#39; section of the swagger documentation.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Attention:&lt;/b&gt; Due to changes on the bank&#39;s side we have been forced to limit the transaction download time frame to 89 days. Now any update of a bank connection will fetch the last three months of transactions per account. If the last successful update was more than 3 months ago, an adjusting entry (&#39;Zwischensaldo&#39; transaction) will be created.
        /// </summary>
        /// <param name="body">Update bank connection parameters</param>
        /// <returns>BankConnection</returns>
        BankConnection UpdateBankConnection (UpdateBankConnectionParams body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BankConnectionsApi : IBankConnectionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankConnectionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BankConnectionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BankConnectionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BankConnectionsApi(String basePath)
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
        /// Connect a new interface Connects new interface to an existing bank connection for a specific user. Must pass the connection credentials and the user&#39;s access_token. All bank accounts will be downloaded and imported with their current balances, transactions and supported two-step-procedures (note that the amount of available transactions may vary between banks, e.g. some banks deliver all transactions from the past year, others only deliver the transactions from the past three months). The balance and transactions download process runs asynchronously, so this service may return before all balances and transactions have been imported. Also, all downloaded transactions will be categorized by a separate background process that runs asynchronously too. To check the status of the balance and transactions download process as well as the background categorization process, see the status flags that are returned by the GET /bankConnections/&lt;id&gt; service.&lt;br/&gt;&lt;br/&gt;NOTE: Depending on your license, this service may respond with HTTP code 451, containing an error message with a identifier of web form in it. In addition to that the response will also have included a &#39;Location&#39; header, which contains the URL to the web form. In this case, you must forward your user to finAPI&#39;s web form. For a detailed explanation of the Web Form Flow, please refer to this article: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/360002596391&#39; target&#x3D;&#39;_blank&#39;&gt;finAPI&#39;s Web Form Flow&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;NOTE: For XS2A interface additional headers must be included in the request if the end user is involved. Please refer to the &#39;General Information/User metadata&#39; section of the swagger documentation.
        /// </summary>
        /// <param name="body">Connect interface parameters</param> 
        /// <returns>BankConnection</returns>            
        public BankConnection ConnectInterface (ConnectInterfaceParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ConnectInterface");
            
    
            var path = "/api/v1/bankConnections/connectInterface";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectInterface: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectInterface: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BankConnection) ApiClient.Deserialize(response.Content, typeof(BankConnection), response.Headers);
        }
    
        /// <summary>
        /// Delete a consent Deletes a consent for an interface of a bank connection (on finAPI and on the bank&#39;s side).
        /// </summary>
        /// <param name="id">Identifier of a bank connection</param> 
        /// <param name="_interface">Banking interface</param> 
        /// <returns>DeleteConsent</returns>            
        public DeleteConsent DeleteAccessData (long? id, string _interface)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAccessData");
            
            // verify the required parameter '_interface' is set
            if (_interface == null) throw new ApiException(400, "Missing required parameter '_interface' when calling DeleteAccessData");
            
    
            var path = "/api/v1/bankConnections/{id}/aisConsent";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (_interface != null) queryParams.Add("interface", ApiClient.ParameterToString(_interface)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccessData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccessData: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DeleteConsent) ApiClient.Deserialize(response.Content, typeof(DeleteConsent), response.Headers);
        }
    
        /// <summary>
        /// Delete all bank connections Delete all bank connections of the user that is authorized by the access_token. Must pass the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;Notes: &lt;br/&gt;- All notification rules that are connected to any specific bank connection will get deleted as well. &lt;br/&gt;- If at least one bank connection is busy (currently in the process of import, update, or transactions categorization), then this service will perform no action at all.
        /// </summary>
        /// <returns>IdentifierList</returns>            
        public IdentifierList DeleteAllBankConnections ()
        {
            
    
            var path = "/api/v1/bankConnections";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAllBankConnections: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAllBankConnections: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentifierList) ApiClient.Deserialize(response.Content, typeof(IdentifierList), response.Headers);
        }
    
        /// <summary>
        /// Delete a bank connection Delete a single bank connection of the user that is authorized by the access_token, including all of its accounts and their transactions and balance data. Must pass the connection&#39;s identifier and the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;Notes: &lt;br/&gt;- All notification rules that are connected to the bank connection will get adjusted so that they no longer have this connection listed. Notification rules that are connected to just this bank connection (and no other connection) will get deleted altogether. &lt;br/&gt;- A bank connection cannot get deleted while it is in the process of import, update, or transactions categorization.
        /// </summary>
        /// <param name="id">Identifier of the bank connection to delete</param> 
        /// <returns></returns>            
        public void DeleteBankConnection (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteBankConnection");
            
    
            var path = "/api/v1/bankConnections/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBankConnection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBankConnection: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Edit a bank connection Edit bank connection data. Must pass the connection&#39;s identifier and the user&#39;s access_token.&lt;br/&gt;&lt;br/&gt;Note that a bank connection&#39;s credentials cannot be changed while it is in the process of being imported, updated, or connecting a new interface.&lt;br/&gt;&lt;br/&gt;NOTE: Depending on your license, this service may respond with HTTP code 451, containing an error message with a identifier of web form in it. In addition to that the response will also have included a &#39;Location&#39; header, which contains the URL to the web form. In this case, you must forward your user to finAPI&#39;s web form. For a detailed explanation of the Web Form Flow, please refer to this article: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/360002596391&#39; target&#x3D;&#39;_blank&#39;&gt;finAPI&#39;s Web Form Flow&lt;/a&gt;
        /// </summary>
        /// <param name="id">Identifier of the bank connection to change the parameters for</param> 
        /// <param name="body">New bank connection parameters</param> 
        /// <returns>BankConnection</returns>            
        public BankConnection EditBankConnection (long? id, EditBankConnectionParams body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditBankConnection");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling EditBankConnection");
            
    
            var path = "/api/v1/bankConnections/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EditBankConnection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditBankConnection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BankConnection) ApiClient.Deserialize(response.Content, typeof(BankConnection), response.Headers);
        }
    
        /// <summary>
        /// Get all bank connections Get bank connections of the user that is authorized by the access_token. Must pass the user&#39;s access_token. You can set optional search criteria to get only those bank connections that you are interested in. If you do not specify any search criteria, then this service functions as a &#39;get all&#39; service.
        /// </summary>
        /// <param name="ids">A comma-separated list of bank connection identifiers. If specified, then only bank connections whose identifier match any of the given identifiers will be regarded. The maximum number of identifiers is 1000.</param> 
        /// <returns>BankConnectionList</returns>            
        public BankConnectionList GetAllBankConnections (List<long?> ids)
        {
            
    
            var path = "/api/v1/bankConnections";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "finapi_auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllBankConnections: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllBankConnections: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BankConnectionList) ApiClient.Deserialize(response.Content, typeof(BankConnectionList), response.Headers);
        }
    
        /// <summary>
        /// Get a bank connection Get a single bank connection of the user that is authorized by the access_token. Must pass the connection&#39;s identifier and the user&#39;s access_token.
        /// </summary>
        /// <param name="id">Identifier of requested bank connection</param> 
        /// <returns>BankConnection</returns>            
        public BankConnection GetBankConnection (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetBankConnection");
            
    
            var path = "/api/v1/bankConnections/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBankConnection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBankConnection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BankConnection) ApiClient.Deserialize(response.Content, typeof(BankConnection), response.Headers);
        }
    
        /// <summary>
        /// Import a new bank connection Imports a new bank connection for a specific user. Must pass the connection credentials and the user&#39;s access_token. All bank accounts will be downloaded and imported with their current balances, transactions and supported two-step-procedures (note that the amount of available transactions may vary between banks, e.g. some banks deliver all transactions from the past year, others only deliver the transactions from the past three months). The balance and transactions download process runs asynchronously, so this service may return before all balances and transactions have been imported. Also, all downloaded transactions will be categorized by a separate background process that runs asynchronously too. To check the status of the balance and transactions download process as well as the background categorization process, see the status flags that are returned by the GET /bankConnections/&lt;id&gt; service.&lt;br/&gt;&lt;br/&gt;You can also import a \&quot;demo connection\&quot; which contains a single bank account with some pre-defined transactions. To import the demo connection, you need to pass the identifier of the \&quot;finAPI Test Bank\&quot;. In case of demo connection import, any other fields besides the bank identifier can remain unset. The login credentials and the &#39;storeSecrets&#39; field will be stored if you pass them, however they will not be regarded when updating the demo connection (in other words: It doesn&#39;t matter what credentials you choose for the demo connection). Note however that if you want to import the demo connection multiple times for the same user, you must use different login credentials for each of the imports. Also note that the skipPositionsDownload flag is ignored for the demo bank connection, i.e. when importing the demo bank connection, you will always get the transactions for its account. You can enable multi-step authentication for the demo bank connection by setting the bank connection name to \&quot;MSA\&quot;.&lt;br/&gt;&lt;br/&gt;The XS2A interface could also be used to initiate a demo connection import.&lt;br/&gt;The finAPI demo XS2A allows you to download a test account by using the &#39;import&#39; or &#39;connectInterface&#39; services - in general, this XS2A demo account is the FINTS_SERVER demo account, as it has the same account number and origin of balances and transactions.&lt;br/&gt;Keep in mind that calling an XS2A demo connection import will result as a newly created bank connection, while the &#39;connectInterface&#39; service attaches the XS2A demo account to an existing demo connection.&lt;br/&gt;Passing the login credentials is not obligated only for redirect banks, however the demo bank works without any given set of credentials for the XS2A interface. If you are looking to test the XS2A SCA (Strong Customer Authentication, or MSA (Multi-Step Authentication) in the finAPI context), you need to pass the bank connection name as \&quot;MSA\&quot; to trigger the SCA flow or as &#39;DECOUPLED-AUTH&#39; to simulate decoupled authentication. To get better understanding about the Multi-Step Authentication, please refer to the &#39;Error Messages&#39; section of the swagger documentation.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;For a more in-depth understanding of the import process, please also read this article on our Dev Portal: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115000296607-Import-Update-of-Bank-Connections-Accounts&#39; target&#x3D;&#39;_blank&#39;&gt;Import &amp; Update of Bank Connections / Accounts&lt;/a&gt;&lt;/b&gt;&lt;br/&gt;&lt;br/&gt;NOTE: Depending on your license, this service may respond with HTTP code 451, containing an error message with a identifier of web form in it. In addition to that the response will also have included a &#39;Location&#39; header, which contains the URL to the web form. In this case, you must forward your user to finAPI&#39;s web form. For a detailed explanation of the Web Form Flow, please refer to this article: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/360002596391&#39; target&#x3D;&#39;_blank&#39;&gt;finAPI&#39;s Web Form Flow&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;NOTE: For XS2A interface additional headers must be included in the request if the end user is involved. Please refer to the &#39;General Information/User metadata&#39; section of the swagger documentation.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Attention:&lt;/b&gt; Due to changes on the bank&#39;s side we have been forced to limit the maxDaysForDownload field to 89 days to reduce the risk of strong customer authentication (SCA) requests. If you have implemented the SCA flow, please contact us, so that we can remove this limitation from your client.
        /// </summary>
        /// <param name="body">Import bank connection parameters</param> 
        /// <returns>BankConnection</returns>            
        public BankConnection ImportBankConnection (ImportBankConnectionParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ImportBankConnection");
            
    
            var path = "/api/v1/bankConnections/import";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ImportBankConnection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ImportBankConnection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BankConnection) ApiClient.Deserialize(response.Content, typeof(BankConnection), response.Headers);
        }
    
        /// <summary>
        /// Remove an interface Remove an interface from bank connection and from all associated accounts in the bank connection. Notes: &lt;br/&gt;- An interface cannot get deleted while it is in the process of import or update.
        /// </summary>
        /// <param name="body">Remove interface parameters</param> 
        /// <returns></returns>            
        public void RemoveInterface (RemoveInterfaceParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling RemoveInterface");
            
    
            var path = "/api/v1/bankConnections/removeInterface";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveInterface: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveInterface: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a bank connection Update an existing bank connection of the user that is authorized by the access_token. Downloads and imports the current account balances and new transactions. Note that if the bank connection has several interfaces and some of its accounts was previously imported or updated via an interface which have higher priority than the interface used in the current update, then balances and transactions will not be downloaded for such accounts (The XS2A interface has the highest priority, followed by FINTS_SERVER and finally WEB_SCRAPER). Must pass the connection&#39;s identifier and the user&#39;s access_token. For more information about the processes of authentication, data download and transactions categorization, see POST /bankConnections/import. Note that supported two-step-procedures are updated as well. It may unset the current default two-step-procedure of the given bank connection (but only if this procedure is not supported anymore by the bank). You can also update the \&quot;demo connection\&quot; (in this case, secret login credentials and the fields &#39;importNewAccounts&#39; and &#39;skipPositionsDownload&#39; will be ignored).&lt;br/&gt;&lt;br/&gt;Note that you cannot trigger an update of a bank connection as long as there is still a previously triggered update running.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;For a more in-depth understanding of the update process, please also read this article on our Dev Portal: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/115000296607-Import-Update-of-Bank-Connections-Accounts&#39; target&#x3D;&#39;_blank&#39;&gt;Import &amp; Update of Bank Connections / Accounts&lt;/a&gt;&lt;/b&gt;&lt;br/&gt;&lt;br/&gt;NOTE: Depending on your license, this service may respond with HTTP code 451, containing an error message with a identifier of web form in it. In addition to that the response will also have included a &#39;Location&#39; header, which contains the URL to the web form. In this case, you must forward your user to finAPI&#39;s web form. For a detailed explanation of the Web Form Flow, please refer to this article: &lt;a href&#x3D;&#39;https://finapi.zendesk.com/hc/en-us/articles/360002596391&#39; target&#x3D;&#39;_blank&#39;&gt;finAPI&#39;s Web Form Flow&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;NOTE: For XS2A interface additional headers must be included in the request if the end user is involved. Please refer to the &#39;General Information/User metadata&#39; section of the swagger documentation.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Attention:&lt;/b&gt; Due to changes on the bank&#39;s side we have been forced to limit the transaction download time frame to 89 days. Now any update of a bank connection will fetch the last three months of transactions per account. If the last successful update was more than 3 months ago, an adjusting entry (&#39;Zwischensaldo&#39; transaction) will be created.
        /// </summary>
        /// <param name="body">Update bank connection parameters</param> 
        /// <returns>BankConnection</returns>            
        public BankConnection UpdateBankConnection (UpdateBankConnectionParams body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBankConnection");
            
    
            var path = "/api/v1/bankConnections/update";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBankConnection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBankConnection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BankConnection) ApiClient.Deserialize(response.Content, typeof(BankConnection), response.Headers);
        }
    
    }
}
