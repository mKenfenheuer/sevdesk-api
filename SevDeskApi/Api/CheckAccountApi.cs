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
    public interface ICheckAccountApi
    {
        /// <summary>
        /// Create a new check account Calls CheckAccount.php to create a check account
        /// </summary>
        /// <param name="body">To create a check account, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelCheckAccount</returns>
        ModelCheckAccount AddCheckAccount (string body);
        /// <summary>
        /// Get current balance of the specified check account Calls getCurrentBalance() in CheckAccount.php to get the balance of the specified check account.
        /// </summary>
        /// <param name="id">Id of the check account of which you want the current balance</param>
        /// <returns></returns>
        void CheckAccountGetCurrentBalance (int? id);
        /// <summary>
        /// Return if a payment method is supported Calls getPaymentIsSupported() in CheckAccount.php to get if a payment method is supported.
        /// </summary>
        /// <returns></returns>
        void CheckAccountGetPaymentIsSupported ();
        /// <summary>
        /// Set the specified check accounts as the default check account Calls setDefault() in CheckAccount.php to set a specified check account as the default check account
        /// </summary>
        /// <param name="id">Id of check account you want to set as the default check account</param>
        /// <returns></returns>
        void CheckAccountSetDefault (int? id);
        /// <summary>
        /// Transfer an amount from one check account to another Calls transfer() in CheckAccount.php to transfer an amount from one check account to another
        /// </summary>
        /// <param name="id">Id of check account you want to use as source account</param>
        /// <param name="amount">Amount you want to transfer</param>
        /// <param name="targetId">Target check account id</param>
        /// <param name="targetObjectName">Target check account object name</param>
        /// <param name="date">Date of the transfer</param>
        /// <returns></returns>
        void CheckAccountTransfer (int? id, string amount, int? targetId, string targetObjectName, string date);
        /// <summary>
        /// Delete an existing check account Calls the delete() function in CheckAccount.php
        /// </summary>
        /// <param name="id">Id of check account you want to delete</param>
        /// <returns></returns>
        void DeleteCheckAccount (int? id);
        /// <summary>
        /// Get an overview of all check accounts Calls CheckAccount.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned check accounts start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelDiscounts</returns>
        ModelDiscounts GetCheckAccounts (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Update an existing check account Calls CheckAccount.php to update a check account
        /// </summary>
        /// <param name="id">Id of check account you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create discount.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param>
        /// <returns>ModelCheckAccount</returns>
        ModelCheckAccount UpdateCheckAccount (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CheckAccountApi : ICheckAccountApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAccountApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CheckAccountApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CheckAccountApi(String basePath)
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
        /// Create a new check account Calls CheckAccount.php to create a check account
        /// </summary>
        /// <param name="body">To create a check account, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelCheckAccount</returns>            
        public ModelCheckAccount AddCheckAccount (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCheckAccount");
            
    
            var path = "/CheckAccount";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddCheckAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCheckAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCheckAccount) ApiClient.Deserialize(response.Content, typeof(ModelCheckAccount), response.Headers);
        }
    
        /// <summary>
        /// Get current balance of the specified check account Calls getCurrentBalance() in CheckAccount.php to get the balance of the specified check account.
        /// </summary>
        /// <param name="id">Id of the check account of which you want the current balance</param> 
        /// <returns></returns>            
        public void CheckAccountGetCurrentBalance (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CheckAccountGetCurrentBalance");
            
    
            var path = "/CheckAccount/{id}/getCurrentBalance";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CheckAccountGetCurrentBalance: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckAccountGetCurrentBalance: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Return if a payment method is supported Calls getPaymentIsSupported() in CheckAccount.php to get if a payment method is supported.
        /// </summary>
        /// <returns></returns>            
        public void CheckAccountGetPaymentIsSupported ()
        {
            
    
            var path = "/CheckAccount/getPaymentIsSupported";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CheckAccountGetPaymentIsSupported: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckAccountGetPaymentIsSupported: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set the specified check accounts as the default check account Calls setDefault() in CheckAccount.php to set a specified check account as the default check account
        /// </summary>
        /// <param name="id">Id of check account you want to set as the default check account</param> 
        /// <returns></returns>            
        public void CheckAccountSetDefault (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CheckAccountSetDefault");
            
    
            var path = "/CheckAccount/{id}/setDefault";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckAccountSetDefault: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckAccountSetDefault: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Transfer an amount from one check account to another Calls transfer() in CheckAccount.php to transfer an amount from one check account to another
        /// </summary>
        /// <param name="id">Id of check account you want to use as source account</param> 
        /// <param name="amount">Amount you want to transfer</param> 
        /// <param name="targetId">Target check account id</param> 
        /// <param name="targetObjectName">Target check account object name</param> 
        /// <param name="date">Date of the transfer</param> 
        /// <returns></returns>            
        public void CheckAccountTransfer (int? id, string amount, int? targetId, string targetObjectName, string date)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CheckAccountTransfer");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling CheckAccountTransfer");
            
            // verify the required parameter 'targetId' is set
            if (targetId == null) throw new ApiException(400, "Missing required parameter 'targetId' when calling CheckAccountTransfer");
            
            // verify the required parameter 'targetObjectName' is set
            if (targetObjectName == null) throw new ApiException(400, "Missing required parameter 'targetObjectName' when calling CheckAccountTransfer");
            
            // verify the required parameter 'date' is set
            if (date == null) throw new ApiException(400, "Missing required parameter 'date' when calling CheckAccountTransfer");
            
    
            var path = "/CheckAccount/{id}/transfer";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (amount != null) queryParams.Add("amount", ApiClient.ParameterToString(amount)); // query parameter
 if (targetId != null) queryParams.Add("target[id]", ApiClient.ParameterToString(targetId)); // query parameter
 if (targetObjectName != null) queryParams.Add("target[objectName]", ApiClient.ParameterToString(targetObjectName)); // query parameter
 if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckAccountTransfer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckAccountTransfer: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an existing check account Calls the delete() function in CheckAccount.php
        /// </summary>
        /// <param name="id">Id of check account you want to delete</param> 
        /// <returns></returns>            
        public void DeleteCheckAccount (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteCheckAccount");
            
    
            var path = "/CheckAccount/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCheckAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCheckAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all check accounts Calls CheckAccount.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned check accounts start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelDiscounts</returns>            
        public ModelDiscounts GetCheckAccounts (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/CheckAccount";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCheckAccounts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCheckAccounts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelDiscounts) ApiClient.Deserialize(response.Content, typeof(ModelDiscounts), response.Headers);
        }
    
        /// <summary>
        /// Update an existing check account Calls CheckAccount.php to update a check account
        /// </summary>
        /// <param name="id">Id of check account you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create discount.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param> 
        /// <returns>ModelCheckAccount</returns>            
        public ModelCheckAccount UpdateCheckAccount (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateCheckAccount");
            
    
            var path = "/CheckAccount/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCheckAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCheckAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCheckAccount) ApiClient.Deserialize(response.Content, typeof(ModelCheckAccount), response.Headers);
        }
    
    }
}
