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
    public interface IVoucherPosApi
    {
        /// <summary>
        /// Create a new voucher position Calls VoucherPos.php to create a voucher position
        /// </summary>
        /// <param name="body">To create a voucher position, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelVoucherPos</returns>
        ModelVoucherPos AddVoucherPos (string body);
        /// <summary>
        /// Delete an existing voucher position Calls the delete() function in VoucherPos.php to delete a voucher position
        /// </summary>
        /// <param name="id">Id of voucher position you want to delete</param>
        /// <returns></returns>
        void DeleteVoucherPos (int? id);
        /// <summary>
        /// Get an overview of all voucher positions Calls VoucherPos.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned voucher positions start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelVoucherPos</returns>
        ModelVoucherPos GetVoucherPositions (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Update an existing voucher position Calls VoucherPos.php to update an existing voucher position
        /// </summary>
        /// <param name="id">Id of the voucher position you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create voucher position.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param>
        /// <returns>ModelVoucherPos</returns>
        ModelVoucherPos UpdateVoucherPos (int? id, string body);
        /// <summary>
        /// Get additional information about the asset which is connected to a specified voucher position Calls getAdditionalInformation() in VoucherPos.php to get additional information about the asset which is connected to the specified voucher position
        /// </summary>
        /// <param name="id">Id of the voucher position of which you want to get additional information about the connected asset</param>
        /// <returns></returns>
        void VoucherPosGetAdditionalInformation (int? id);
        /// <summary>
        /// Get the asset which is connected to a specified voucher position Calls getAssetInstance() in VoucherPos.php to get the asset which is connected to the specified voucher position
        /// </summary>
        /// <param name="id">Id of the voucher position of which you want to get the connected asset</param>
        /// <returns>ModelAsset</returns>
        ModelAsset VoucherPosGetAssetInstance (int? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VoucherPosApi : IVoucherPosApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherPosApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VoucherPosApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherPosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VoucherPosApi(String basePath)
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
        /// Create a new voucher position Calls VoucherPos.php to create a voucher position
        /// </summary>
        /// <param name="body">To create a voucher position, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelVoucherPos</returns>            
        public ModelVoucherPos AddVoucherPos (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddVoucherPos");
            
    
            var path = "/VoucherPos";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddVoucherPos: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddVoucherPos: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucherPos) ApiClient.Deserialize(response.Content, typeof(ModelVoucherPos), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing voucher position Calls the delete() function in VoucherPos.php to delete a voucher position
        /// </summary>
        /// <param name="id">Id of voucher position you want to delete</param> 
        /// <returns></returns>            
        public void DeleteVoucherPos (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteVoucherPos");
            
    
            var path = "/VoucherPos/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVoucherPos: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVoucherPos: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all voucher positions Calls VoucherPos.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned voucher positions start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelVoucherPos</returns>            
        public ModelVoucherPos GetVoucherPositions (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/VoucherPos";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetVoucherPositions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVoucherPositions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucherPos) ApiClient.Deserialize(response.Content, typeof(ModelVoucherPos), response.Headers);
        }
    
        /// <summary>
        /// Update an existing voucher position Calls VoucherPos.php to update an existing voucher position
        /// </summary>
        /// <param name="id">Id of the voucher position you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create voucher position.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelVoucherPos</returns>            
        public ModelVoucherPos UpdateVoucherPos (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateVoucherPos");
            
    
            var path = "/VoucherPos/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVoucherPos: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVoucherPos: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucherPos) ApiClient.Deserialize(response.Content, typeof(ModelVoucherPos), response.Headers);
        }
    
        /// <summary>
        /// Get additional information about the asset which is connected to a specified voucher position Calls getAdditionalInformation() in VoucherPos.php to get additional information about the asset which is connected to the specified voucher position
        /// </summary>
        /// <param name="id">Id of the voucher position of which you want to get additional information about the connected asset</param> 
        /// <returns></returns>            
        public void VoucherPosGetAdditionalInformation (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherPosGetAdditionalInformation");
            
    
            var path = "/VoucherPos/{id}/getAdditionalInfo";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherPosGetAdditionalInformation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherPosGetAdditionalInformation: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the asset which is connected to a specified voucher position Calls getAssetInstance() in VoucherPos.php to get the asset which is connected to the specified voucher position
        /// </summary>
        /// <param name="id">Id of the voucher position of which you want to get the connected asset</param> 
        /// <returns>ModelAsset</returns>            
        public ModelAsset VoucherPosGetAssetInstance (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherPosGetAssetInstance");
            
    
            var path = "/VoucherPos/{id}/getAssetInstance";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherPosGetAssetInstance: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherPosGetAssetInstance: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAsset) ApiClient.Deserialize(response.Content, typeof(ModelAsset), response.Headers);
        }
    
    }
}
