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
    public interface IAssetApi
    {
        /// <summary>
        /// Create a new asset Calls Asset.php 
        /// </summary>
        /// <param name="body">To create an asset, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelAsset</returns>
        ModelAsset AddAsset (string body);
        /// <summary>
        /// Get depreciation amount of the specified asset for the given year/month Calls getDepreciationAmount() in Asset.php to get the depreciation ammount of the specified asset for the given year/month
        /// </summary>
        /// <param name="id">Id of the asset of which you want to get the depreciation amount</param>
        /// <param name="year">year for which you want to get the depreciation amount</param>
        /// <param name="month">month for which you want to get the depreciation amount</param>
        /// <returns></returns>
        void AssetGetDepreciationAmount (int? id, string year, string month);
        /// <summary>
        /// Get residual value of the specified asset for the given year/month Calls getResidualValue() in Asset.php to get the residual value of the specified asset for the given year/month
        /// </summary>
        /// <param name="id">Id of the asset of which you want to get the residual value</param>
        /// <param name="year">year for which you want to get the residual value</param>
        /// <param name="month">month for which you want to get the residual value</param>
        /// <returns></returns>
        void AssetGetResidualValue (int? id, string year, string month);
        /// <summary>
        /// Get voucher of the specified asset Calls getVoucher() in Asset.php to get the voucher of the specified asset
        /// </summary>
        /// <param name="id">Id of the asset of which you want to get the voucher</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelVoucher</returns>
        ModelVoucher AssetGetVoucher (int? id, List<string> embed);
        /// <summary>
        /// Delete an existing asset Calls the delete() function in Asset.php
        /// </summary>
        /// <param name="id">id of asset you want to delete</param>
        /// <returns></returns>
        void DeleteAsset (int? id);
        /// <summary>
        /// Get an overview of all assets Calls Asset.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned assets start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelAsset</returns>
        ModelAsset GetAssets (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Update an existing asset Calls Asset.php
        /// </summary>
        /// <param name="id">id of asset you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create asset.    Append the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks!</param>
        /// <returns>ModelAsset</returns>
        ModelAsset UpdateAsset (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AssetApi : IAssetApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AssetApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AssetApi(String basePath)
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
        /// Create a new asset Calls Asset.php 
        /// </summary>
        /// <param name="body">To create an asset, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelAsset</returns>            
        public ModelAsset AddAsset (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddAsset");
            
    
            var path = "/Asset";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddAsset: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAsset: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAsset) ApiClient.Deserialize(response.Content, typeof(ModelAsset), response.Headers);
        }
    
        /// <summary>
        /// Get depreciation amount of the specified asset for the given year/month Calls getDepreciationAmount() in Asset.php to get the depreciation ammount of the specified asset for the given year/month
        /// </summary>
        /// <param name="id">Id of the asset of which you want to get the depreciation amount</param> 
        /// <param name="year">year for which you want to get the depreciation amount</param> 
        /// <param name="month">month for which you want to get the depreciation amount</param> 
        /// <returns></returns>            
        public void AssetGetDepreciationAmount (int? id, string year, string month)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetGetDepreciationAmount");
            
    
            var path = "/Asset/{id}/getDepreciationAmount";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (year != null) queryParams.Add("year", ApiClient.ParameterToString(year)); // query parameter
 if (month != null) queryParams.Add("month", ApiClient.ParameterToString(month)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGetDepreciationAmount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGetDepreciationAmount: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get residual value of the specified asset for the given year/month Calls getResidualValue() in Asset.php to get the residual value of the specified asset for the given year/month
        /// </summary>
        /// <param name="id">Id of the asset of which you want to get the residual value</param> 
        /// <param name="year">year for which you want to get the residual value</param> 
        /// <param name="month">month for which you want to get the residual value</param> 
        /// <returns></returns>            
        public void AssetGetResidualValue (int? id, string year, string month)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetGetResidualValue");
            
    
            var path = "/Asset/{id}/getResidualValue";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (year != null) queryParams.Add("year", ApiClient.ParameterToString(year)); // query parameter
 if (month != null) queryParams.Add("month", ApiClient.ParameterToString(month)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGetResidualValue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGetResidualValue: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get voucher of the specified asset Calls getVoucher() in Asset.php to get the voucher of the specified asset
        /// </summary>
        /// <param name="id">Id of the asset of which you want to get the voucher</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelVoucher</returns>            
        public ModelVoucher AssetGetVoucher (int? id, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetGetVoucher");
            
    
            var path = "/Asset/{id}/getVoucher";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGetVoucher: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGetVoucher: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucher) ApiClient.Deserialize(response.Content, typeof(ModelVoucher), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing asset Calls the delete() function in Asset.php
        /// </summary>
        /// <param name="id">id of asset you want to delete</param> 
        /// <returns></returns>            
        public void DeleteAsset (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAsset");
            
    
            var path = "/Asset/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAsset: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAsset: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all assets Calls Asset.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned assets start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelAsset</returns>            
        public ModelAsset GetAssets (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/Asset";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAssets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAssets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAsset) ApiClient.Deserialize(response.Content, typeof(ModelAsset), response.Headers);
        }
    
        /// <summary>
        /// Update an existing asset Calls Asset.php
        /// </summary>
        /// <param name="id">id of asset you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create asset.    Append the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks!</param> 
        /// <returns>ModelAsset</returns>            
        public ModelAsset UpdateAsset (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateAsset");
            
    
            var path = "/Asset/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAsset: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAsset: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAsset) ApiClient.Deserialize(response.Content, typeof(ModelAsset), response.Headers);
        }
    
    }
}
