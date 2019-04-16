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
    public interface IInvoiceLogApi
    {
        /// <summary>
        /// Create a new invoice log Calls InvoiceLog.php
        /// </summary>
        /// <param name="body">To create an invoice log, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelInvoiceLog</returns>
        ModelInvoiceLog AddInvoiceLog (string body);
        /// <summary>
        /// Delete an existing invoice log Calls the delete() function in InvoiceLog.php
        /// </summary>
        /// <param name="id">Id of invoice log you want to delete</param>
        /// <returns></returns>
        void DeleteInvoiceLog (int? id);
        /// <summary>
        /// Get an overview of invoice logs Calls InvoiceLog.php to get necessary variables
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned invoice logs start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelInvoiceLog</returns>
        ModelInvoiceLog GetInvoiceLogs (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Update an existing invoice log Calls InvoiceLog.php
        /// </summary>
        /// <param name="id">Id of invoice log you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create invoice log.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks!</param>
        /// <returns>ModelInvoiceLog</returns>
        ModelInvoiceLog UpdateInvoiceLog (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InvoiceLogApi : IInvoiceLogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceLogApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InvoiceLogApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceLogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoiceLogApi(String basePath)
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
        /// Create a new invoice log Calls InvoiceLog.php
        /// </summary>
        /// <param name="body">To create an invoice log, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelInvoiceLog</returns>            
        public ModelInvoiceLog AddInvoiceLog (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddInvoiceLog");
            
    
            var path = "/InvoiceLog";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddInvoiceLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddInvoiceLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelInvoiceLog) ApiClient.Deserialize(response.Content, typeof(ModelInvoiceLog), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing invoice log Calls the delete() function in InvoiceLog.php
        /// </summary>
        /// <param name="id">Id of invoice log you want to delete</param> 
        /// <returns></returns>            
        public void DeleteInvoiceLog (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteInvoiceLog");
            
    
            var path = "/InvoiceLog/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteInvoiceLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteInvoiceLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of invoice logs Calls InvoiceLog.php to get necessary variables
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned invoice logs start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelInvoiceLog</returns>            
        public ModelInvoiceLog GetInvoiceLogs (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/InvoiceLog";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetInvoiceLogs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInvoiceLogs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelInvoiceLog) ApiClient.Deserialize(response.Content, typeof(ModelInvoiceLog), response.Headers);
        }
    
        /// <summary>
        /// Update an existing invoice log Calls InvoiceLog.php
        /// </summary>
        /// <param name="id">Id of invoice log you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create invoice log.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks!</param> 
        /// <returns>ModelInvoiceLog</returns>            
        public ModelInvoiceLog UpdateInvoiceLog (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateInvoiceLog");
            
    
            var path = "/InvoiceLog/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateInvoiceLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateInvoiceLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelInvoiceLog) ApiClient.Deserialize(response.Content, typeof(ModelInvoiceLog), response.Headers);
        }
    
    }
}
