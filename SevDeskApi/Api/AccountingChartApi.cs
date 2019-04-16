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
    public interface IAccountingChartApi
    {
        /// <summary>
        /// Create a new accounting chart Calls AccountingChart.php to add an accounting chart
        /// </summary>
        /// <param name="body">To create an accounting chart, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelAccountingChart</returns>
        ModelAccountingChart AddAccountingChart (string body);
        /// <summary>
        /// Delete an existing accounting chart Calls AccountingChart.php to delete an accounting chart
        /// </summary>
        /// <param name="id">id of the accounting chart you want to delete</param>
        /// <returns></returns>
        void DeleteAccountingChart (int? id);
        /// <summary>
        /// Get an overview of all accounting charts Calls AccountingChart.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned accounting charts start. Default is 0</param>
        /// <returns>ModelAccountingChart</returns>
        ModelAccountingChart GetAccountingChart (int? limit, int? offset);
        /// <summary>
        /// Update an existing accounting chart Calls AccountingChart.php to update an accounting chart
        /// </summary>
        /// <param name="id">id of accounting chart you want to update</param>
        /// <param name="body">Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param>
        /// <returns>ModelAccountingChart</returns>
        ModelAccountingChart UpdateAccountingChart (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountingChartApi : IAccountingChartApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingChartApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountingChartApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingChartApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountingChartApi(String basePath)
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
        /// Create a new accounting chart Calls AccountingChart.php to add an accounting chart
        /// </summary>
        /// <param name="body">To create an accounting chart, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelAccountingChart</returns>            
        public ModelAccountingChart AddAccountingChart (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddAccountingChart");
            
    
            var path = "/AccountingChart";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddAccountingChart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAccountingChart: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingChart) ApiClient.Deserialize(response.Content, typeof(ModelAccountingChart), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing accounting chart Calls AccountingChart.php to delete an accounting chart
        /// </summary>
        /// <param name="id">id of the accounting chart you want to delete</param> 
        /// <returns></returns>            
        public void DeleteAccountingChart (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAccountingChart");
            
    
            var path = "/AccountingChart/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccountingChart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccountingChart: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all accounting charts Calls AccountingChart.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned accounting charts start. Default is 0</param> 
        /// <returns>ModelAccountingChart</returns>            
        public ModelAccountingChart GetAccountingChart (int? limit, int? offset)
        {
            
    
            var path = "/AccountingChart";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountingChart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountingChart: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingChart) ApiClient.Deserialize(response.Content, typeof(ModelAccountingChart), response.Headers);
        }
    
        /// <summary>
        /// Update an existing accounting chart Calls AccountingChart.php to update an accounting chart
        /// </summary>
        /// <param name="id">id of accounting chart you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelAccountingChart</returns>            
        public ModelAccountingChart UpdateAccountingChart (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateAccountingChart");
            
    
            var path = "/AccountingChart/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAccountingChart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAccountingChart: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingChart) ApiClient.Deserialize(response.Content, typeof(ModelAccountingChart), response.Headers);
        }
    
    }
}
