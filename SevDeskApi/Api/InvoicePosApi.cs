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
    public interface IInvoicePosApi
    {
        /// <summary>
        /// Create a new invoice position Calls InvoicePos.php.    As described in the Model_Invoice earlier, some of its parameters get their value from other models/functions.    InvoicePos is one of those Models and provides the ability to add products/parts to your invoice which fills values like sumNet,taxation, etc.
        /// </summary>
        /// <param name="body">To create an invoice position, simply enter desired values after parameter&#x3D; and remove the quotation marks.    Adds a product/part to an invoice with a price, quantity etc, therefore the invoice model gets sumNet and other parameters from it too</param>
        /// <returns>ModelInvoicePos</returns>
        ModelInvoicePos AddInvoicePos (string body);
        /// <summary>
        /// Delete an existing invoice position Calls the delete() function in InvoicePos.php. This does NOT delete an invoice, just the position which belonged to the invoice!
        /// </summary>
        /// <param name="id">id of invoice position you want to delete</param>
        /// <returns></returns>
        void DeleteInvoicePos (int? id);
        /// <summary>
        /// Get an overview of all invoice positions Calls InvoicePos.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned invoice positions start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelInvoicePos</returns>
        ModelInvoicePos GetInvoicePositions (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Update an existing invoice position TODO: Enter short backend documentation here
        /// </summary>
        /// <param name="id">id of invoice position you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create invoice position.     Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param>
        /// <returns>ModelInvoicePos</returns>
        ModelInvoicePos UpdateInvoicePos (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InvoicePosApi : IInvoicePosApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePosApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InvoicePosApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoicePosApi(String basePath)
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
        /// Create a new invoice position Calls InvoicePos.php.    As described in the Model_Invoice earlier, some of its parameters get their value from other models/functions.    InvoicePos is one of those Models and provides the ability to add products/parts to your invoice which fills values like sumNet,taxation, etc.
        /// </summary>
        /// <param name="body">To create an invoice position, simply enter desired values after parameter&#x3D; and remove the quotation marks.    Adds a product/part to an invoice with a price, quantity etc, therefore the invoice model gets sumNet and other parameters from it too</param> 
        /// <returns>ModelInvoicePos</returns>            
        public ModelInvoicePos AddInvoicePos (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddInvoicePos");
            
    
            var path = "/InvoicePos";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddInvoicePos: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddInvoicePos: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelInvoicePos) ApiClient.Deserialize(response.Content, typeof(ModelInvoicePos), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing invoice position Calls the delete() function in InvoicePos.php. This does NOT delete an invoice, just the position which belonged to the invoice!
        /// </summary>
        /// <param name="id">id of invoice position you want to delete</param> 
        /// <returns></returns>            
        public void DeleteInvoicePos (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteInvoicePos");
            
    
            var path = "/InvoicePos/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteInvoicePos: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteInvoicePos: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all invoice positions Calls InvoicePos.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned invoice positions start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelInvoicePos</returns>            
        public ModelInvoicePos GetInvoicePositions (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/InvoicePos";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetInvoicePositions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInvoicePositions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelInvoicePos) ApiClient.Deserialize(response.Content, typeof(ModelInvoicePos), response.Headers);
        }
    
        /// <summary>
        /// Update an existing invoice position TODO: Enter short backend documentation here
        /// </summary>
        /// <param name="id">id of invoice position you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create invoice position.     Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelInvoicePos</returns>            
        public ModelInvoicePos UpdateInvoicePos (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateInvoicePos");
            
    
            var path = "/InvoicePos/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateInvoicePos: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateInvoicePos: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelInvoicePos) ApiClient.Deserialize(response.Content, typeof(ModelInvoicePos), response.Headers);
        }
    
    }
}
