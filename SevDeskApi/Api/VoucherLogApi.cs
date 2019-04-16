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
    public interface IVoucherLogApi
    {
        /// <summary>
        /// Create a new voucher log entry Calls VoucherLog.php to create a voucher log entry
        /// </summary>
        /// <param name="body">To create a voucher, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelVoucherLog</returns>
        ModelVoucherLog AddVoucherLogEntry (string body);
        /// <summary>
        /// Delete an existing voucher log entry Calls the delete() function in VoucherLog.php to delete a voucher log entry
        /// </summary>
        /// <param name="id">Id of voucher log entry you want to delete</param>
        /// <returns></returns>
        void DeleteVoucherLogEntry (int? id);
        /// <summary>
        /// Get an overview of all voucher log entries Calls VoucherLog.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned voucher log entries start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelVoucherLog</returns>
        ModelVoucherLog GetVoucherLog (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Update an existing voucher log entry Calls VoucherLog.php to update an existing voucher log entry
        /// </summary>
        /// <param name="id">Id of the voucher log entry you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create voucher log entry.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param>
        /// <returns>ModelVoucherLog</returns>
        ModelVoucherLog UpdateVoucherLogEntry (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VoucherLogApi : IVoucherLogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherLogApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VoucherLogApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherLogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VoucherLogApi(String basePath)
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
        /// Create a new voucher log entry Calls VoucherLog.php to create a voucher log entry
        /// </summary>
        /// <param name="body">To create a voucher, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelVoucherLog</returns>            
        public ModelVoucherLog AddVoucherLogEntry (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddVoucherLogEntry");
            
    
            var path = "/VoucherLog";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddVoucherLogEntry: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddVoucherLogEntry: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucherLog) ApiClient.Deserialize(response.Content, typeof(ModelVoucherLog), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing voucher log entry Calls the delete() function in VoucherLog.php to delete a voucher log entry
        /// </summary>
        /// <param name="id">Id of voucher log entry you want to delete</param> 
        /// <returns></returns>            
        public void DeleteVoucherLogEntry (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteVoucherLogEntry");
            
    
            var path = "/VoucherLog/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVoucherLogEntry: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVoucherLogEntry: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all voucher log entries Calls VoucherLog.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned voucher log entries start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelVoucherLog</returns>            
        public ModelVoucherLog GetVoucherLog (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/VoucherLog";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetVoucherLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVoucherLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucherLog) ApiClient.Deserialize(response.Content, typeof(ModelVoucherLog), response.Headers);
        }
    
        /// <summary>
        /// Update an existing voucher log entry Calls VoucherLog.php to update an existing voucher log entry
        /// </summary>
        /// <param name="id">Id of the voucher log entry you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create voucher log entry.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelVoucherLog</returns>            
        public ModelVoucherLog UpdateVoucherLogEntry (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateVoucherLogEntry");
            
    
            var path = "/VoucherLog/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVoucherLogEntry: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVoucherLogEntry: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucherLog) ApiClient.Deserialize(response.Content, typeof(ModelVoucherLog), response.Headers);
        }
    
    }
}
