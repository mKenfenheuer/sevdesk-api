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
    public interface IAccountingSystemNumberApi
    {
        /// <summary>
        /// Create a new accounting system number Calls AccountingSystemNumber.php 
        /// </summary>
        /// <param name="body">To create an accounting system number, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelAccountingSystemNumber</returns>
        ModelAccountingSystemNumber AddAccountingSystemNumber (string body);
        /// <summary>
        /// Delete an existing accounting system number Calls the delete() function in AccountingSystemNumber.php
        /// </summary>
        /// <param name="id">id of accounting system number you want to delete</param>
        /// <returns></returns>
        void DeleteAccountingSystemNumber (int? id);
        /// <summary>
        /// Get an overview of all accounting system numbers Calls AccountingSystemNumber.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 1000</param>
        /// <param name="offset">Set the index where the returned accounting system numbers start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelAccountingSystemNumber</returns>
        ModelAccountingSystemNumber GetAccountingSystemNumbers (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Update an existing accounting system number Calls AccountingSystemNumber.php
        /// </summary>
        /// <param name="id">id of accounting system number you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create accounting system number.    Append the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks!</param>
        /// <returns>ModelAccountingType</returns>
        ModelAccountingType UpdateAccountingSystemNumber (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountingSystemNumberApi : IAccountingSystemNumberApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingSystemNumberApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountingSystemNumberApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingSystemNumberApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountingSystemNumberApi(String basePath)
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
        /// Create a new accounting system number Calls AccountingSystemNumber.php 
        /// </summary>
        /// <param name="body">To create an accounting system number, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelAccountingSystemNumber</returns>            
        public ModelAccountingSystemNumber AddAccountingSystemNumber (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddAccountingSystemNumber");
            
    
            var path = "/AccountingSystemNumber";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddAccountingSystemNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAccountingSystemNumber: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingSystemNumber) ApiClient.Deserialize(response.Content, typeof(ModelAccountingSystemNumber), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing accounting system number Calls the delete() function in AccountingSystemNumber.php
        /// </summary>
        /// <param name="id">id of accounting system number you want to delete</param> 
        /// <returns></returns>            
        public void DeleteAccountingSystemNumber (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAccountingSystemNumber");
            
    
            var path = "/AccountingSystemNumber/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccountingSystemNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccountingSystemNumber: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all accounting system numbers Calls AccountingSystemNumber.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 1000</param> 
        /// <param name="offset">Set the index where the returned accounting system numbers start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelAccountingSystemNumber</returns>            
        public ModelAccountingSystemNumber GetAccountingSystemNumbers (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/AccountingSystemNumber";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountingSystemNumbers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountingSystemNumbers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingSystemNumber) ApiClient.Deserialize(response.Content, typeof(ModelAccountingSystemNumber), response.Headers);
        }
    
        /// <summary>
        /// Update an existing accounting system number Calls AccountingSystemNumber.php
        /// </summary>
        /// <param name="id">id of accounting system number you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create accounting system number.    Append the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks!</param> 
        /// <returns>ModelAccountingType</returns>            
        public ModelAccountingType UpdateAccountingSystemNumber (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateAccountingSystemNumber");
            
    
            var path = "/AccountingSystemNumber/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAccountingSystemNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAccountingSystemNumber: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingType) ApiClient.Deserialize(response.Content, typeof(ModelAccountingType), response.Headers);
        }
    
    }
}
