using System;
using System.Collections.Generic;
using RestSharp;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace SevDeskApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICheckAccountTransactionApi
    {
        /// <summary>
        /// Create a new check account transaction Calls CheckAccountTransaction.php 
        /// </summary>
        /// <param name="body">To create a check account transaction , simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelCheckAccountTransaction</returns>
        ModelCheckAccountTransaction AddCheckAccountTransaction (string body);
        /// <summary>
        /// Get log of a specified check account transaction Calls getLog() in CheckAccountTransaction.php to get the log of a specified check account transaction.
        /// </summary>
        /// <param name="id">Id of the check account transaction of which you want to get the log</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelCheckAccountTransactionLog</returns>
        ModelCheckAccountTransactionLog CheckAccountTransactionGetLog (int? id, List<string> embed);
        /// <summary>
        /// Get invoice amount which is not assigned yet Calls getRemainingAmount() in CheckAccountTransaction.php to get invoice amount which is not assigned yet.
        /// </summary>
        /// <param name="id">Id of check account transaction you want to use</param>
        /// <returns></returns>
        void CheckAccountTransactionGetRemainingAmount (int? id);
        /// <summary>
        /// Delete an existing check account transaction Calls the delete() function in CheckAccountTransaction.php
        /// </summary>
        /// <param name="id">id of check account transaction you want to delete</param>
        /// <returns></returns>
        void DeleteCheckAccountTransaction (int? id);
        /// <summary>
        /// Get an overview of all check account transactions Calls CheckAccountTransaction.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned check account transactions start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelCheckAccountTransaction</returns>
        ModelCheckAccountTransaction GetCheckAccountTransactions (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// link invoice to check account transaction Calls linkInvoice() in CheckAccountTransaction.php.      This will update the specified invoice as well as the status of the check account transaction!
        /// </summary>
        /// <param name="id">id of check account transaction you want to update</param>
        /// <param name="body">Enter the id of the invoice you want to be linked after invoiceId&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelCheckAccountTransaction</returns>
        ModelCheckAccountTransaction LinkInvoiceToCheckAccountTransaction (int? id, string body);
        /// <summary>
        /// link voucher to check account transaction Calls linkVoucher() in CheckAccountTransaction.php.      This will update the specified voucher as well as the status of the check account transaction!
        /// </summary>
        /// <param name="id">id of check account transaction you want to update</param>
        /// <param name="body">Enter the id of the voucher you want to be linked after voucherId&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelCheckAccountTransaction</returns>
        ModelCheckAccountTransaction LinkVoucherToCheckAccountTransaction (int? id, string body);
        /// <summary>
        /// Update a existing check account transaction Calls CheckAccountTransaction.php
        /// </summary>
        /// <param name="id">id of check account transaction you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create check account transaction.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param>
        /// <returns>ModelCheckAccountTransaction</returns>
        ModelCheckAccountTransaction UpdateCheckAccountTransaction (int? id, string body);
        /// <summary>
        /// Update status of a existing check account transaction Calls changeStatus() in CheckAccountTransaction.php
        /// </summary>
        /// <param name="id">id of check account transaction you want to update</param>
        /// <param name="body">Enter your desired status after value&#x3D; and remove the quotation marks</param>
        /// <returns>ModelCheckAccountTransaction</returns>
        ModelCheckAccountTransaction UpdateCheckAccountTransactionStatus (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CheckAccountTransactionApi : ICheckAccountTransactionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAccountTransactionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CheckAccountTransactionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAccountTransactionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CheckAccountTransactionApi(String basePath)
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
        /// Create a new check account transaction Calls CheckAccountTransaction.php 
        /// </summary>
        /// <param name="body">To create a check account transaction , simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelCheckAccountTransaction</returns>            
        public ModelCheckAccountTransaction AddCheckAccountTransaction (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCheckAccountTransaction");
            
    
            var path = "/CheckAccountTransaction";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCheckAccountTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCheckAccountTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCheckAccountTransaction) ApiClient.Deserialize(response.Content, typeof(ModelCheckAccountTransaction), response.Headers);
        }
    
        /// <summary>
        /// Get log of a specified check account transaction Calls getLog() in CheckAccountTransaction.php to get the log of a specified check account transaction.
        /// </summary>
        /// <param name="id">Id of the check account transaction of which you want to get the log</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelCheckAccountTransactionLog</returns>            
        public ModelCheckAccountTransactionLog CheckAccountTransactionGetLog (int? id, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CheckAccountTransactionGetLog");
            
    
            var path = "/CheckAccountTransaction/{id}/getLog";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (embed != null) queryParams.Add("embed", ApiClient.ParameterToString(embed)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckAccountTransactionGetLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckAccountTransactionGetLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCheckAccountTransactionLog) ApiClient.Deserialize(response.Content, typeof(ModelCheckAccountTransactionLog), response.Headers);
        }
    
        /// <summary>
        /// Get invoice amount which is not assigned yet Calls getRemainingAmount() in CheckAccountTransaction.php to get invoice amount which is not assigned yet.
        /// </summary>
        /// <param name="id">Id of check account transaction you want to use</param> 
        /// <returns></returns>            
        public void CheckAccountTransactionGetRemainingAmount (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CheckAccountTransactionGetRemainingAmount");
            
    
            var path = "/CheckAccountTransaction/{id}/getRemainingAmount";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckAccountTransactionGetRemainingAmount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckAccountTransactionGetRemainingAmount: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an existing check account transaction Calls the delete() function in CheckAccountTransaction.php
        /// </summary>
        /// <param name="id">id of check account transaction you want to delete</param> 
        /// <returns></returns>            
        public void DeleteCheckAccountTransaction (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteCheckAccountTransaction");
            
    
            var path = "/CheckAccountTransaction/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCheckAccountTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCheckAccountTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all check account transactions Calls CheckAccountTransaction.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned check account transactions start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelCheckAccountTransaction</returns>            
        public ModelCheckAccountTransaction GetCheckAccountTransactions (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/CheckAccountTransaction";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (embed != null) queryParams.Add("embed", ApiClient.ParameterToString(embed)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCheckAccountTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCheckAccountTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCheckAccountTransaction) ApiClient.Deserialize(response.Content, typeof(ModelCheckAccountTransaction), response.Headers);
        }
    
        /// <summary>
        /// link invoice to check account transaction Calls linkInvoice() in CheckAccountTransaction.php.      This will update the specified invoice as well as the status of the check account transaction!
        /// </summary>
        /// <param name="id">id of check account transaction you want to update</param> 
        /// <param name="body">Enter the id of the invoice you want to be linked after invoiceId&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelCheckAccountTransaction</returns>            
        public ModelCheckAccountTransaction LinkInvoiceToCheckAccountTransaction (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LinkInvoiceToCheckAccountTransaction");
            
    
            var path = "/CheckAccountTransaction/{id}/linkInvoice";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LinkInvoiceToCheckAccountTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LinkInvoiceToCheckAccountTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCheckAccountTransaction) ApiClient.Deserialize(response.Content, typeof(ModelCheckAccountTransaction), response.Headers);
        }
    
        /// <summary>
        /// link voucher to check account transaction Calls linkVoucher() in CheckAccountTransaction.php.      This will update the specified voucher as well as the status of the check account transaction!
        /// </summary>
        /// <param name="id">id of check account transaction you want to update</param> 
        /// <param name="body">Enter the id of the voucher you want to be linked after voucherId&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelCheckAccountTransaction</returns>            
        public ModelCheckAccountTransaction LinkVoucherToCheckAccountTransaction (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LinkVoucherToCheckAccountTransaction");
            
    
            var path = "/CheckAccountTransaction/{id}/linkVoucher";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LinkVoucherToCheckAccountTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LinkVoucherToCheckAccountTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCheckAccountTransaction) ApiClient.Deserialize(response.Content, typeof(ModelCheckAccountTransaction), response.Headers);
        }
    
        /// <summary>
        /// Update a existing check account transaction Calls CheckAccountTransaction.php
        /// </summary>
        /// <param name="id">id of check account transaction you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create check account transaction.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param> 
        /// <returns>ModelCheckAccountTransaction</returns>            
        public ModelCheckAccountTransaction UpdateCheckAccountTransaction (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateCheckAccountTransaction");
            
    
            var path = "/CheckAccountTransaction/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCheckAccountTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCheckAccountTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCheckAccountTransaction) ApiClient.Deserialize(response.Content, typeof(ModelCheckAccountTransaction), response.Headers);
        }
    
        /// <summary>
        /// Update status of a existing check account transaction Calls changeStatus() in CheckAccountTransaction.php
        /// </summary>
        /// <param name="id">id of check account transaction you want to update</param> 
        /// <param name="body">Enter your desired status after value&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelCheckAccountTransaction</returns>            
        public ModelCheckAccountTransaction UpdateCheckAccountTransactionStatus (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateCheckAccountTransactionStatus");
            
    
            var path = "/CheckAccountTransaction/{id}/changeStatus";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCheckAccountTransactionStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCheckAccountTransactionStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCheckAccountTransaction) ApiClient.Deserialize(response.Content, typeof(ModelCheckAccountTransaction), response.Headers);
        }
    
    }
}
