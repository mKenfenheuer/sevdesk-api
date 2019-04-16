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
    public interface IInventoryPartLogApi
    {
        /// <summary>
        /// Create a new inventory part log Calls InventoryPartLog.php
        /// </summary>
        /// <param name="body">To create a inventory part log, simply enter desired values after parameter&#x3D; and remove the quotation marks!    Be aware that creating an inventory part log this way is not recommended as there is no real acquisition/dispatch of a part!</param>
        /// <returns>ModelInventoryPartLog</returns>
        ModelInventoryPartLog AddInventoryPartLog (string body);
        /// <summary>
        /// Delete an existing inventory part log Calls the delete() function in InventoryPartLog.php    Be aware that this operations sets the stock of your part to the value it had before the acquisition/dispatch and deletes the corresponding feed!
        /// </summary>
        /// <param name="id">id of inventory part log you want to delete</param>
        /// <returns></returns>
        void DeleteInventoryPartLog (int? id);
        /// <summary>
        /// Get an overview of InventoryPartLog Calls InventoryPartLog.php to get necessary variables
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned part logs start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelInventoryPartLog</returns>
        ModelInventoryPartLog GetInventoryPartLog (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Get stock of inventory part involved in part log Calls getStock() in InventoryPartLog.php to get the stock of the part involved in the part log
        /// </summary>
        /// <param name="id">Id of inventory part log you want to get the stock from</param>
        /// <returns></returns>
        void GetInventoryPartLogStock (int? id);
        /// <summary>
        /// Update an existing inventory part log Calls InventoryPartLog.php
        /// </summary>
        /// <param name="id">id of inventory part log you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create inventory part log.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks!    Be aware that updating an existing inventory part log is not recommended unless its for correcting wrong data in the database!</param>
        /// <returns>ModelInventoryPartLog</returns>
        ModelInventoryPartLog UpdateInventoryPartLog (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InventoryPartLogApi : IInventoryPartLogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryPartLogApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InventoryPartLogApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryPartLogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InventoryPartLogApi(String basePath)
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
        /// Create a new inventory part log Calls InventoryPartLog.php
        /// </summary>
        /// <param name="body">To create a inventory part log, simply enter desired values after parameter&#x3D; and remove the quotation marks!    Be aware that creating an inventory part log this way is not recommended as there is no real acquisition/dispatch of a part!</param> 
        /// <returns>ModelInventoryPartLog</returns>            
        public ModelInventoryPartLog AddInventoryPartLog (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddInventoryPartLog");
            
    
            var path = "/InventoryPartLog";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddInventoryPartLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddInventoryPartLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelInventoryPartLog) ApiClient.Deserialize(response.Content, typeof(ModelInventoryPartLog), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing inventory part log Calls the delete() function in InventoryPartLog.php    Be aware that this operations sets the stock of your part to the value it had before the acquisition/dispatch and deletes the corresponding feed!
        /// </summary>
        /// <param name="id">id of inventory part log you want to delete</param> 
        /// <returns></returns>            
        public void DeleteInventoryPartLog (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteInventoryPartLog");
            
    
            var path = "/InventoryPartLog/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteInventoryPartLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteInventoryPartLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of InventoryPartLog Calls InventoryPartLog.php to get necessary variables
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned part logs start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelInventoryPartLog</returns>            
        public ModelInventoryPartLog GetInventoryPartLog (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/InventoryPartLog";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetInventoryPartLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInventoryPartLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelInventoryPartLog) ApiClient.Deserialize(response.Content, typeof(ModelInventoryPartLog), response.Headers);
        }
    
        /// <summary>
        /// Get stock of inventory part involved in part log Calls getStock() in InventoryPartLog.php to get the stock of the part involved in the part log
        /// </summary>
        /// <param name="id">Id of inventory part log you want to get the stock from</param> 
        /// <returns></returns>            
        public void GetInventoryPartLogStock (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetInventoryPartLogStock");
            
    
            var path = "/InventoryPartLog/{id}/getStock";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetInventoryPartLogStock: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInventoryPartLogStock: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an existing inventory part log Calls InventoryPartLog.php
        /// </summary>
        /// <param name="id">id of inventory part log you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create inventory part log.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks!    Be aware that updating an existing inventory part log is not recommended unless its for correcting wrong data in the database!</param> 
        /// <returns>ModelInventoryPartLog</returns>            
        public ModelInventoryPartLog UpdateInventoryPartLog (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateInventoryPartLog");
            
    
            var path = "/InventoryPartLog/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateInventoryPartLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateInventoryPartLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelInventoryPartLog) ApiClient.Deserialize(response.Content, typeof(ModelInventoryPartLog), response.Headers);
        }
    
    }
}
