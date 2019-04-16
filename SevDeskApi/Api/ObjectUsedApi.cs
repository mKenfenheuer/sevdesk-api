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
    public interface IObjectUsedApi
    {
        /// <summary>
        /// Get an overview of all objects used Calls ObjectUsed.php to get necessary variables
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned objects used start. Default is 0</param>
        /// <returns>ModelObjectUsed</returns>
        ModelObjectUsed GetObjectUsed (int? limit, int? offset);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ObjectUsedApi : IObjectUsedApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectUsedApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ObjectUsedApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectUsedApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectUsedApi(String basePath)
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
        /// Get an overview of all objects used Calls ObjectUsed.php to get necessary variables
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned objects used start. Default is 0</param> 
        /// <returns>ModelObjectUsed</returns>            
        public ModelObjectUsed GetObjectUsed (int? limit, int? offset)
        {
            
    
            var path = "/ObjectUsed";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetObjectUsed: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetObjectUsed: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelObjectUsed) ApiClient.Deserialize(response.Content, typeof(ModelObjectUsed), response.Headers);
        }
    
    }
}
