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
    public interface IAccountingCorrectionApi
    {
        /// <summary>
        /// Create a new accounting correction Calls AccountingCorrection.php to add an accounting correction
        /// </summary>
        /// <param name="body">To create an accounting correction, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelAccountingCorrection</returns>
        ModelAccountingCorrection AddAccountingCorrection (string body);
        /// <summary>
        /// Delete an existing accounting correction Calls AccountingCorrection.php to delete an accounting correction
        /// </summary>
        /// <param name="id">id of the accounting correction you want to delete</param>
        /// <returns></returns>
        void DeleteAccountingCorrection (int? id);
        /// <summary>
        /// Get an overview of all accounting corrections Calls AccountingCorrection.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned accounting corrections start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelAccountingCorrection</returns>
        ModelAccountingCorrection GetAccountingCorrections (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Update an existing accounting correction Calls AccountingCorrection.php to update an accounting correction
        /// </summary>
        /// <param name="id">id of accounting correction you want to update</param>
        /// <param name="body">Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param>
        /// <returns>ModelAccountingCorrection</returns>
        ModelAccountingCorrection UpdateAccountingCorrection (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountingCorrectionApi : IAccountingCorrectionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingCorrectionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountingCorrectionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingCorrectionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountingCorrectionApi(String basePath)
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
        /// Create a new accounting correction Calls AccountingCorrection.php to add an accounting correction
        /// </summary>
        /// <param name="body">To create an accounting correction, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelAccountingCorrection</returns>            
        public ModelAccountingCorrection AddAccountingCorrection (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddAccountingCorrection");
            
    
            var path = "/AccountingCorrection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddAccountingCorrection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAccountingCorrection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingCorrection) ApiClient.Deserialize(response.Content, typeof(ModelAccountingCorrection), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing accounting correction Calls AccountingCorrection.php to delete an accounting correction
        /// </summary>
        /// <param name="id">id of the accounting correction you want to delete</param> 
        /// <returns></returns>            
        public void DeleteAccountingCorrection (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAccountingCorrection");
            
    
            var path = "/AccountingCorrection/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccountingCorrection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccountingCorrection: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all accounting corrections Calls AccountingCorrection.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned accounting corrections start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelAccountingCorrection</returns>            
        public ModelAccountingCorrection GetAccountingCorrections (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/AccountingCorrection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountingCorrections: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountingCorrections: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingCorrection) ApiClient.Deserialize(response.Content, typeof(ModelAccountingCorrection), response.Headers);
        }
    
        /// <summary>
        /// Update an existing accounting correction Calls AccountingCorrection.php to update an accounting correction
        /// </summary>
        /// <param name="id">id of accounting correction you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelAccountingCorrection</returns>            
        public ModelAccountingCorrection UpdateAccountingCorrection (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateAccountingCorrection");
            
    
            var path = "/AccountingCorrection/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAccountingCorrection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAccountingCorrection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingCorrection) ApiClient.Deserialize(response.Content, typeof(ModelAccountingCorrection), response.Headers);
        }
    
    }
}
