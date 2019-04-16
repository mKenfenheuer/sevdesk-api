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
    public interface IEntryTypeApi
    {
        /// <summary>
        /// Create a new entry type Calls EntryType.php to create an entry type
        /// </summary>
        /// <param name="body">To create an entry type, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelEntryType</returns>
        ModelEntryType AddEntryType (string body);
        /// <summary>
        /// Delete an existing entry type Calls EntryType.php to delete an entry type
        /// </summary>
        /// <param name="id">id of entry type you want to delete</param>
        /// <returns></returns>
        void DeleteEntryType (int? id);
        /// <summary>
        /// Delete all objects bound to the specified entry type Tries to delete all objects bound to the specified entry type if they are not in use
        /// </summary>
        /// <param name="id">Id of entry type you want to use</param>
        /// <returns></returns>
        void EntryTypeDeleteReferencedObjects (int? id);
        /// <summary>
        /// Get an overview of all entry types Calls EntryType.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned entry types start. Default is 0</param>
        /// <returns>ModelEntryType</returns>
        ModelEntryType GetEntryTypes (int? limit, int? offset);
        /// <summary>
        /// Update an existing entry type Calls EntryType.php to update an entry type
        /// </summary>
        /// <param name="id">id of entry type you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create entry type.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param>
        /// <returns>ModelEntryType</returns>
        ModelEntryType UpdateEntryType (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EntryTypeApi : IEntryTypeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntryTypeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EntryTypeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EntryTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EntryTypeApi(String basePath)
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
        /// Create a new entry type Calls EntryType.php to create an entry type
        /// </summary>
        /// <param name="body">To create an entry type, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelEntryType</returns>            
        public ModelEntryType AddEntryType (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddEntryType");
            
    
            var path = "/EntryType";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddEntryType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddEntryType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelEntryType) ApiClient.Deserialize(response.Content, typeof(ModelEntryType), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing entry type Calls EntryType.php to delete an entry type
        /// </summary>
        /// <param name="id">id of entry type you want to delete</param> 
        /// <returns></returns>            
        public void DeleteEntryType (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteEntryType");
            
    
            var path = "/EntryType/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEntryType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEntryType: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete all objects bound to the specified entry type Tries to delete all objects bound to the specified entry type if they are not in use
        /// </summary>
        /// <param name="id">Id of entry type you want to use</param> 
        /// <returns></returns>            
        public void EntryTypeDeleteReferencedObjects (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EntryTypeDeleteReferencedObjects");
            
    
            var path = "/EntryType/{id}/deleteReferencedObjects";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EntryTypeDeleteReferencedObjects: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EntryTypeDeleteReferencedObjects: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all entry types Calls EntryType.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned entry types start. Default is 0</param> 
        /// <returns>ModelEntryType</returns>            
        public ModelEntryType GetEntryTypes (int? limit, int? offset)
        {
            
    
            var path = "/EntryType";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntryTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntryTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelEntryType) ApiClient.Deserialize(response.Content, typeof(ModelEntryType), response.Headers);
        }
    
        /// <summary>
        /// Update an existing entry type Calls EntryType.php to update an entry type
        /// </summary>
        /// <param name="id">id of entry type you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create entry type.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param> 
        /// <returns>ModelEntryType</returns>            
        public ModelEntryType UpdateEntryType (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateEntryType");
            
    
            var path = "/EntryType/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEntryType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEntryType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelEntryType) ApiClient.Deserialize(response.Content, typeof(ModelEntryType), response.Headers);
        }
    
    }
}
