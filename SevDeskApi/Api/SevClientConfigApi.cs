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
    public interface ISevClientConfigApi
    {
        /// <summary>
        /// Get an overview of your sevClient config Calls SevClientConfig.php to get necessary variables.
        /// </summary>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelSevClientConfig</returns>
        ModelSevClientConfig GetSevClientConfig (List<string> embed);
        /// <summary>
        /// Update an existing sevClient config Calls SevClientConfig.php
        /// </summary>
        /// <param name="id">Id of sevClient config you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create sevClient config.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param>
        /// <returns>ModelSevClientConfig</returns>
        ModelSevClientConfig UpdateSevClientConfig (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SevClientConfigApi : ISevClientConfigApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SevClientConfigApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SevClientConfigApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SevClientConfigApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SevClientConfigApi(String basePath)
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
        /// Get an overview of your sevClient config Calls SevClientConfig.php to get necessary variables.
        /// </summary>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelSevClientConfig</returns>            
        public ModelSevClientConfig GetSevClientConfig (List<string> embed)
        {
            
    
            var path = "/SevClientConfig";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSevClientConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSevClientConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelSevClientConfig) ApiClient.Deserialize(response.Content, typeof(ModelSevClientConfig), response.Headers);
        }
    
        /// <summary>
        /// Update an existing sevClient config Calls SevClientConfig.php
        /// </summary>
        /// <param name="id">Id of sevClient config you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create sevClient config.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param> 
        /// <returns>ModelSevClientConfig</returns>            
        public ModelSevClientConfig UpdateSevClientConfig (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateSevClientConfig");
            
    
            var path = "/SevClientConfig/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSevClientConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSevClientConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelSevClientConfig) ApiClient.Deserialize(response.Content, typeof(ModelSevClientConfig), response.Headers);
        }
    
    }
}
