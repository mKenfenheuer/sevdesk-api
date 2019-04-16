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
    public interface ISubscriptionTypeApi
    {
        /// <summary>
        /// Get an overview of all subscription types Calls SubscriptionType.php to get necessary variables.
        /// </summary>
        /// <returns>ModelSubscriptionType</returns>
        ModelSubscriptionType GetSubscriptionTypes ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SubscriptionTypeApi : ISubscriptionTypeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionTypeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SubscriptionTypeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubscriptionTypeApi(String basePath)
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
        /// Get an overview of all subscription types Calls SubscriptionType.php to get necessary variables.
        /// </summary>
        /// <returns>ModelSubscriptionType</returns>            
        public ModelSubscriptionType GetSubscriptionTypes ()
        {
            
    
            var path = "/SubscriptionType";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscriptionTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscriptionTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelSubscriptionType) ApiClient.Deserialize(response.Content, typeof(ModelSubscriptionType), response.Headers);
        }
    
    }
}
