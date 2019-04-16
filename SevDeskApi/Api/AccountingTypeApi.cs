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
    public interface IAccountingTypeApi
    {
        /// <summary>
        /// Get accounting system number of the specified accounting type Calls getAccountingNumber() in AccountingType.php to get the accounting system number of the specified accounting type.    Basically this function does just calls getAccountingSystemNumber() and returns just the number, not the model.
        /// </summary>
        /// <param name="id">Id of the accounting type for which you want to get the accounting system number</param>
        /// <returns></returns>
        void AccountingTypeGetAccountingNumber (int? id);
        /// <summary>
        /// Get accounting system number depreciation of the specified accounting type Calls getAccountingNumberDepreciation() in AccountingType.php to get the accounting system number depreciation of the specified accounting type.    Basically this function does just calls getAccountingSystemNumber() and returns just the depreciation, not the model.
        /// </summary>
        /// <param name="id">Id of the accounting type for which you want to get the accounting system number depreciation</param>
        /// <returns></returns>
        void AccountingTypeGetAccountingNumberDepreciation (int? id);
        /// <summary>
        /// Get accounting system number of the specified accounting type Calls getAccountingSystemNumber() in AccountingType.php to get the accounting system number of the specified accounting type.
        /// </summary>
        /// <param name="id">Id of the accounting type for which you want to get the accounting system number</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelAccountingSystemNumber</returns>
        ModelAccountingSystemNumber AccountingTypeGetAccountingSystemNumber (int? id, List<string> embed);
        /// <summary>
        /// Create a new accounting type Calls AccountingType.php 
        /// </summary>
        /// <param name="body">To create an accounting type, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelAccountingType</returns>
        ModelAccountingType AddAccountingType (string body);
        /// <summary>
        /// Create a new accounting type With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the Model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new invoice it wont be saved by a POST request with &#39;/Invoice?para1&#x3D;&amp;...&#39; but with the saveInvoice function in Factory.php &#39;Voucher/Factory/saveInvoice?para1&#x3D;&#39;
        /// </summary>
        /// <param name="body">To create an accounting type, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelAccountingType</returns>
        ModelAccountingType AddAccountingTypeFactory (string body);
        /// <summary>
        /// Delete an existing accounting type Calls the delete() function in AccountingType.php
        /// </summary>
        /// <param name="id">id of accounting type you want to delete</param>
        /// <returns></returns>
        void DeleteAccountingType (int? id);
        /// <summary>
        /// Get an overview of all accounting types Calls AccountingType.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 1000</param>
        /// <param name="offset">Set the index where the returned accounting types start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelAccountingType</returns>
        ModelAccountingType GetAccountingTypes (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Update an existing accounting type Calls AccountingType.php
        /// </summary>
        /// <param name="id">id of accounting type you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create accounting type.    Append the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks!</param>
        /// <returns>ModelAccountingType</returns>
        ModelAccountingType UpdateAccountingType (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountingTypeApi : IAccountingTypeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingTypeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountingTypeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountingTypeApi(String basePath)
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
        /// Get accounting system number of the specified accounting type Calls getAccountingNumber() in AccountingType.php to get the accounting system number of the specified accounting type.    Basically this function does just calls getAccountingSystemNumber() and returns just the number, not the model.
        /// </summary>
        /// <param name="id">Id of the accounting type for which you want to get the accounting system number</param> 
        /// <returns></returns>            
        public void AccountingTypeGetAccountingNumber (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccountingTypeGetAccountingNumber");
            
    
            var path = "/AccountingType/{id}/getAccountingNumber";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountingTypeGetAccountingNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountingTypeGetAccountingNumber: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get accounting system number depreciation of the specified accounting type Calls getAccountingNumberDepreciation() in AccountingType.php to get the accounting system number depreciation of the specified accounting type.    Basically this function does just calls getAccountingSystemNumber() and returns just the depreciation, not the model.
        /// </summary>
        /// <param name="id">Id of the accounting type for which you want to get the accounting system number depreciation</param> 
        /// <returns></returns>            
        public void AccountingTypeGetAccountingNumberDepreciation (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccountingTypeGetAccountingNumberDepreciation");
            
    
            var path = "/AccountingType/{id}/getAccountingNumberDepreciation";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountingTypeGetAccountingNumberDepreciation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountingTypeGetAccountingNumberDepreciation: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get accounting system number of the specified accounting type Calls getAccountingSystemNumber() in AccountingType.php to get the accounting system number of the specified accounting type.
        /// </summary>
        /// <param name="id">Id of the accounting type for which you want to get the accounting system number</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelAccountingSystemNumber</returns>            
        public ModelAccountingSystemNumber AccountingTypeGetAccountingSystemNumber (int? id, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccountingTypeGetAccountingSystemNumber");
            
    
            var path = "/AccountingType/{id}/getAccountingSystemNumber";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountingTypeGetAccountingSystemNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountingTypeGetAccountingSystemNumber: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingSystemNumber) ApiClient.Deserialize(response.Content, typeof(ModelAccountingSystemNumber), response.Headers);
        }
    
        /// <summary>
        /// Create a new accounting type Calls AccountingType.php 
        /// </summary>
        /// <param name="body">To create an accounting type, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelAccountingType</returns>            
        public ModelAccountingType AddAccountingType (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddAccountingType");
            
    
            var path = "/AccountingType";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddAccountingType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAccountingType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingType) ApiClient.Deserialize(response.Content, typeof(ModelAccountingType), response.Headers);
        }
    
        /// <summary>
        /// Create a new accounting type With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the Model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new invoice it wont be saved by a POST request with &#39;/Invoice?para1&#x3D;&amp;...&#39; but with the saveInvoice function in Factory.php &#39;Voucher/Factory/saveInvoice?para1&#x3D;&#39;
        /// </summary>
        /// <param name="body">To create an accounting type, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelAccountingType</returns>            
        public ModelAccountingType AddAccountingTypeFactory (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddAccountingTypeFactory");
            
    
            var path = "/AccountingType/Factory/createType";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddAccountingTypeFactory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAccountingTypeFactory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingType) ApiClient.Deserialize(response.Content, typeof(ModelAccountingType), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing accounting type Calls the delete() function in AccountingType.php
        /// </summary>
        /// <param name="id">id of accounting type you want to delete</param> 
        /// <returns></returns>            
        public void DeleteAccountingType (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAccountingType");
            
    
            var path = "/AccountingType/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccountingType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccountingType: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all accounting types Calls AccountingType.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 1000</param> 
        /// <param name="offset">Set the index where the returned accounting types start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelAccountingType</returns>            
        public ModelAccountingType GetAccountingTypes (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/AccountingType";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountingTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountingTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingType) ApiClient.Deserialize(response.Content, typeof(ModelAccountingType), response.Headers);
        }
    
        /// <summary>
        /// Update an existing accounting type Calls AccountingType.php
        /// </summary>
        /// <param name="id">id of accounting type you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create accounting type.    Append the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks!</param> 
        /// <returns>ModelAccountingType</returns>            
        public ModelAccountingType UpdateAccountingType (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateAccountingType");
            
    
            var path = "/AccountingType/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAccountingType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAccountingType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingType) ApiClient.Deserialize(response.Content, typeof(ModelAccountingType), response.Headers);
        }
    
    }
}
