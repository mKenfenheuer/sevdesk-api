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
    public interface IOrderPosApi
    {
        /// <summary>
        /// Create a new order position Calls OrderPos.php.     As described in the Model_Order earlier, some of its parameters get their value from other models/functions.     OrderPos is one of those Models and provides the ability to add products/parts to your order which fills values like sumNet,taxation, etc.
        /// </summary>
        /// <param name="body">To create an order position, simply enter desired values after parameter&#x3D; and remove the quotation marks.      Adds a product/part to an order with a price, quantity etc, therefore the order model gets sumNet and other parameters from it too</param>
        /// <returns>ModelOrderPos</returns>
        ModelOrderPos AddOrderPos (string body);
        /// <summary>
        /// Delete an existing order position Calls the delete() function in OrderPos.php. This does NOT delete an order, just the position which belonged to the order!
        /// </summary>
        /// <param name="id">id of order position you want to delete</param>
        /// <returns></returns>
        void DeleteOrderPos (int? id);
        /// <summary>
        /// Get an overview of all order positions Calls OrderPos.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned order positions start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelOrderPos</returns>
        ModelOrderPos GetOrderPositions (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Update an existing order position TODO: Enter short backend documentation here
        /// </summary>
        /// <param name="id">id of order position you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create order position.        Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param>
        /// <returns>ModelOrderPos</returns>
        ModelOrderPos UpdateOrderPos (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderPosApi : IOrderPosApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPosApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderPosApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderPosApi(String basePath)
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
        /// Create a new order position Calls OrderPos.php.     As described in the Model_Order earlier, some of its parameters get their value from other models/functions.     OrderPos is one of those Models and provides the ability to add products/parts to your order which fills values like sumNet,taxation, etc.
        /// </summary>
        /// <param name="body">To create an order position, simply enter desired values after parameter&#x3D; and remove the quotation marks.      Adds a product/part to an order with a price, quantity etc, therefore the order model gets sumNet and other parameters from it too</param> 
        /// <returns>ModelOrderPos</returns>            
        public ModelOrderPos AddOrderPos (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddOrderPos");
            
    
            var path = "/OrderPos";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddOrderPos: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddOrderPos: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelOrderPos) ApiClient.Deserialize(response.Content, typeof(ModelOrderPos), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing order position Calls the delete() function in OrderPos.php. This does NOT delete an order, just the position which belonged to the order!
        /// </summary>
        /// <param name="id">id of order position you want to delete</param> 
        /// <returns></returns>            
        public void DeleteOrderPos (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteOrderPos");
            
    
            var path = "/OrderPos/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrderPos: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrderPos: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all order positions Calls OrderPos.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned order positions start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelOrderPos</returns>            
        public ModelOrderPos GetOrderPositions (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/OrderPos";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrderPositions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrderPositions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelOrderPos) ApiClient.Deserialize(response.Content, typeof(ModelOrderPos), response.Headers);
        }
    
        /// <summary>
        /// Update an existing order position TODO: Enter short backend documentation here
        /// </summary>
        /// <param name="id">id of order position you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create order position.        Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelOrderPos</returns>            
        public ModelOrderPos UpdateOrderPos (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateOrderPos");
            
    
            var path = "/OrderPos/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrderPos: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrderPos: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelOrderPos) ApiClient.Deserialize(response.Content, typeof(ModelOrderPos), response.Headers);
        }
    
    }
}
