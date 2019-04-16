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
    public interface IPartContactPriceApi
    {
        /// <summary>
        /// Create a new part contact price Calls PartContactPrice.php to add a part contact price
        /// </summary>
        /// <param name="body">To create a part contact price, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelPartContactPrice</returns>
        ModelPartContactPrice AddPartContactPrice (string body);
        /// <summary>
        /// Delete an existing part contact price Calls PartContactPrice.php to delete a part contact price
        /// </summary>
        /// <param name="id">id of the part contact price you want to delete</param>
        /// <returns></returns>
        void DeletePartContactPrice (int? id);
        /// <summary>
        /// Get an overview of all part contact prices Calls PartContactPrice.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned part contact prices start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelPartContactPrice</returns>
        ModelPartContactPrice GetPartContactPrices (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Update an existing part contact price Calls PartContactPrice.php to update a part contact price
        /// </summary>
        /// <param name="id">id of part contact price you want to update</param>
        /// <param name="body">Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param>
        /// <returns>ModelPartContactPrice</returns>
        ModelPartContactPrice UpdatePartContactPrice (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PartContactPriceApi : IPartContactPriceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartContactPriceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PartContactPriceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PartContactPriceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PartContactPriceApi(String basePath)
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
        /// Create a new part contact price Calls PartContactPrice.php to add a part contact price
        /// </summary>
        /// <param name="body">To create a part contact price, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelPartContactPrice</returns>            
        public ModelPartContactPrice AddPartContactPrice (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddPartContactPrice");
            
    
            var path = "/PartContactPrice";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddPartContactPrice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddPartContactPrice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPartContactPrice) ApiClient.Deserialize(response.Content, typeof(ModelPartContactPrice), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing part contact price Calls PartContactPrice.php to delete a part contact price
        /// </summary>
        /// <param name="id">id of the part contact price you want to delete</param> 
        /// <returns></returns>            
        public void DeletePartContactPrice (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletePartContactPrice");
            
    
            var path = "/PartContactPrice/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePartContactPrice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePartContactPrice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all part contact prices Calls PartContactPrice.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned part contact prices start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelPartContactPrice</returns>            
        public ModelPartContactPrice GetPartContactPrices (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/PartContactPrice";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPartContactPrices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPartContactPrices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPartContactPrice) ApiClient.Deserialize(response.Content, typeof(ModelPartContactPrice), response.Headers);
        }
    
        /// <summary>
        /// Update an existing part contact price Calls PartContactPrice.php to update a part contact price
        /// </summary>
        /// <param name="id">id of part contact price you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelPartContactPrice</returns>            
        public ModelPartContactPrice UpdatePartContactPrice (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdatePartContactPrice");
            
    
            var path = "/PartContactPrice/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePartContactPrice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePartContactPrice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPartContactPrice) ApiClient.Deserialize(response.Content, typeof(ModelPartContactPrice), response.Headers);
        }
    
    }
}
