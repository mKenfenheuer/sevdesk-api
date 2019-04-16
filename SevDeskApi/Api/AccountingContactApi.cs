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
    public interface IAccountingContactApi
    {
        /// <summary>
        /// Return if a debitor / creditor number is available Calls isAvailableDebitorCreditorNumber() in AccountingContact.php to get if the debitor / creditor number is available.
        /// </summary>
        /// <param name="contactId">If you want to exclude a contact from getting checked you can provide its id here</param>
        /// <param name="contactObjectName">Contact object name</param>
        /// <param name="debitorNumber">debitor number of which you want to know if it is available</param>
        /// <param name="creditorNumber">creditor number of which you want to know if it is available</param>
        /// <returns></returns>
        void AccountingContactIsAvailableDebitorCreditorNumber (int? contactId, string contactObjectName, string debitorNumber, string creditorNumber);
        /// <summary>
        /// Create a new accounting contact Calls AccountingContact.php 
        /// </summary>
        /// <param name="body">To create an accounting contact, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelAccountingContact</returns>
        ModelAccountingContact AddAccountingContact (string body);
        /// <summary>
        /// Delete an existing accounting contact Calls the delete() function in AccountingContact.php
        /// </summary>
        /// <param name="id">id of accounting contact you want to delete</param>
        /// <returns></returns>
        void DeleteAccountingContact (int? id);
        /// <summary>
        /// Get an overview of all accounting contacts Calls AccountingContact.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned discounts start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelAccountingContact</returns>
        ModelAccountingContact GetAccountingContacts (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Update an existing accounting contact Calls AccountingContact.php
        /// </summary>
        /// <param name="id">id of accounting contact you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create accounting contact.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param>
        /// <returns>ModelAccountingContact</returns>
        ModelAccountingContact UpdateAccountingContact (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountingContactApi : IAccountingContactApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingContactApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountingContactApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingContactApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountingContactApi(String basePath)
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
        /// Return if a debitor / creditor number is available Calls isAvailableDebitorCreditorNumber() in AccountingContact.php to get if the debitor / creditor number is available.
        /// </summary>
        /// <param name="contactId">If you want to exclude a contact from getting checked you can provide its id here</param> 
        /// <param name="contactObjectName">Contact object name</param> 
        /// <param name="debitorNumber">debitor number of which you want to know if it is available</param> 
        /// <param name="creditorNumber">creditor number of which you want to know if it is available</param> 
        /// <returns></returns>            
        public void AccountingContactIsAvailableDebitorCreditorNumber (int? contactId, string contactObjectName, string debitorNumber, string creditorNumber)
        {
            
    
            var path = "/AccountingContact/isAvailableDebitorCreditorNumber";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (contactId != null) queryParams.Add("contact[id]", ApiClient.ParameterToString(contactId)); // query parameter
 if (contactObjectName != null) queryParams.Add("contact[objectName]", ApiClient.ParameterToString(contactObjectName)); // query parameter
 if (debitorNumber != null) queryParams.Add("debitorNumber", ApiClient.ParameterToString(debitorNumber)); // query parameter
 if (creditorNumber != null) queryParams.Add("creditorNumber", ApiClient.ParameterToString(creditorNumber)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountingContactIsAvailableDebitorCreditorNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountingContactIsAvailableDebitorCreditorNumber: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create a new accounting contact Calls AccountingContact.php 
        /// </summary>
        /// <param name="body">To create an accounting contact, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelAccountingContact</returns>            
        public ModelAccountingContact AddAccountingContact (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddAccountingContact");
            
    
            var path = "/AccountingContact";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddAccountingContact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAccountingContact: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingContact) ApiClient.Deserialize(response.Content, typeof(ModelAccountingContact), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing accounting contact Calls the delete() function in AccountingContact.php
        /// </summary>
        /// <param name="id">id of accounting contact you want to delete</param> 
        /// <returns></returns>            
        public void DeleteAccountingContact (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAccountingContact");
            
    
            var path = "/AccountingContact/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccountingContact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccountingContact: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all accounting contacts Calls AccountingContact.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned discounts start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelAccountingContact</returns>            
        public ModelAccountingContact GetAccountingContacts (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/AccountingContact";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountingContacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountingContacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingContact) ApiClient.Deserialize(response.Content, typeof(ModelAccountingContact), response.Headers);
        }
    
        /// <summary>
        /// Update an existing accounting contact Calls AccountingContact.php
        /// </summary>
        /// <param name="id">id of accounting contact you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create accounting contact.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param> 
        /// <returns>ModelAccountingContact</returns>            
        public ModelAccountingContact UpdateAccountingContact (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateAccountingContact");
            
    
            var path = "/AccountingContact/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAccountingContact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAccountingContact: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingContact) ApiClient.Deserialize(response.Content, typeof(ModelAccountingContact), response.Headers);
        }
    
    }
}
