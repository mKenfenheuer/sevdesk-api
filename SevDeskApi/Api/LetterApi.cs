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
    public interface ILetterApi
    {
        /// <summary>
        /// Create a new letter Calls Letter.php
        /// </summary>
        /// <param name="body">To create a letter, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelLetter</returns>
        ModelLetter AddLetter (string body);
        /// <summary>
        /// Delete an existing letter Calls the delete() function in Letter.php
        /// </summary>
        /// <param name="id">id of letter you want to delete</param>
        /// <returns></returns>
        void DeleteLetter (int? id);
        /// <summary>
        /// Get an overview of all letters Calls Letter.php to get necessary variables
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned letters start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelLetter</returns>
        ModelLetter GetLetters (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Get pdf from docserver Calls getPdf() in Letter.php to get the pdf of a specified letter from the docserver
        /// </summary>
        /// <param name="id">Id of the letter of which you want to get the pdf</param>
        /// <returns></returns>
        void LetterGetPdf (int? id);
        /// <summary>
        /// Render a letter to the docserver and return the metadata Calls render() in Letter.php to render a letter to the docserver and return the metadata.    Note that this does not work for letters created by calling the api directly (eg. over Swagger)!
        /// </summary>
        /// <param name="id">id of letter you want to render</param>
        /// <returns></returns>
        void LetterRender (int? id);
        /// <summary>
        /// Update parameter sendType Calls sendBy() in Letter.php to update the sendType parameter of the letter and change its status to DELIVERED
        /// </summary>
        /// <param name="id">id of letter of which you want to update the sendType parameter</param>
        /// <param name="body">Enter desired send type after sendType&#x3D; and remove the quotation marks!</param>
        /// <returns>ModelLetter</returns>
        ModelLetter LetterSendBy (int? id, string body);
        /// <summary>
        /// Send a letter via mail Calls sendViaMail() in Letter.php to send a letter via mail.    Note that you can not send a letter created by calling the api directly (eg. over Swagger)!
        /// </summary>
        /// <param name="id">id of letter you want to send</param>
        /// <param name="body">To send a letter, simply enter desired values after parameter&#x3D; and remove the quotation marks.    Please note: additionalAttachments is a String containing document id&#39;s (of existing documents!)</param>
        /// <returns></returns>
        void LetterSendViaMail (int? id, string body);
        /// <summary>
        /// Send a letter via post Calls sendViaPost() in Letter.php to send a letter via post if enabled in your subscription    Note that you can not send a letter created by calling the api directly (eg. over Swagger)!
        /// </summary>
        /// <param name="id">id of letter you want to send</param>
        /// <returns></returns>
        void LetterSendViaPost (int? id);
        /// <summary>
        /// Update an existing letter Calls Letter.php
        /// </summary>
        /// <param name="id">id of letter you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create letter.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param>
        /// <returns>ModelLetter</returns>
        ModelLetter UpdateLetter (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LetterApi : ILetterApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LetterApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LetterApi(String basePath)
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
        /// Create a new letter Calls Letter.php
        /// </summary>
        /// <param name="body">To create a letter, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelLetter</returns>            
        public ModelLetter AddLetter (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddLetter");
            
    
            var path = "/Letter";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddLetter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddLetter: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelLetter) ApiClient.Deserialize(response.Content, typeof(ModelLetter), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing letter Calls the delete() function in Letter.php
        /// </summary>
        /// <param name="id">id of letter you want to delete</param> 
        /// <returns></returns>            
        public void DeleteLetter (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteLetter");
            
    
            var path = "/Letter/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLetter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLetter: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all letters Calls Letter.php to get necessary variables
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned letters start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelLetter</returns>            
        public ModelLetter GetLetters (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/Letter";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLetters: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLetters: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelLetter) ApiClient.Deserialize(response.Content, typeof(ModelLetter), response.Headers);
        }
    
        /// <summary>
        /// Get pdf from docserver Calls getPdf() in Letter.php to get the pdf of a specified letter from the docserver
        /// </summary>
        /// <param name="id">Id of the letter of which you want to get the pdf</param> 
        /// <returns></returns>            
        public void LetterGetPdf (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LetterGetPdf");
            
    
            var path = "/Letter/{id}/getPdf";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LetterGetPdf: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LetterGetPdf: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Render a letter to the docserver and return the metadata Calls render() in Letter.php to render a letter to the docserver and return the metadata.    Note that this does not work for letters created by calling the api directly (eg. over Swagger)!
        /// </summary>
        /// <param name="id">id of letter you want to render</param> 
        /// <returns></returns>            
        public void LetterRender (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LetterRender");
            
    
            var path = "/Letter/{id}/render";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LetterRender: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LetterRender: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update parameter sendType Calls sendBy() in Letter.php to update the sendType parameter of the letter and change its status to DELIVERED
        /// </summary>
        /// <param name="id">id of letter of which you want to update the sendType parameter</param> 
        /// <param name="body">Enter desired send type after sendType&#x3D; and remove the quotation marks!</param> 
        /// <returns>ModelLetter</returns>            
        public ModelLetter LetterSendBy (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LetterSendBy");
            
    
            var path = "/Letter/{id}/sendBy";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LetterSendBy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LetterSendBy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelLetter) ApiClient.Deserialize(response.Content, typeof(ModelLetter), response.Headers);
        }
    
        /// <summary>
        /// Send a letter via mail Calls sendViaMail() in Letter.php to send a letter via mail.    Note that you can not send a letter created by calling the api directly (eg. over Swagger)!
        /// </summary>
        /// <param name="id">id of letter you want to send</param> 
        /// <param name="body">To send a letter, simply enter desired values after parameter&#x3D; and remove the quotation marks.    Please note: additionalAttachments is a String containing document id&#39;s (of existing documents!)</param> 
        /// <returns></returns>            
        public void LetterSendViaMail (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LetterSendViaMail");
            
    
            var path = "/Letter/{id}/sendViaEmail";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LetterSendViaMail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LetterSendViaMail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send a letter via post Calls sendViaPost() in Letter.php to send a letter via post if enabled in your subscription    Note that you can not send a letter created by calling the api directly (eg. over Swagger)!
        /// </summary>
        /// <param name="id">id of letter you want to send</param> 
        /// <returns></returns>            
        public void LetterSendViaPost (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LetterSendViaPost");
            
    
            var path = "/Letter/{id}/sendViaPost";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LetterSendViaPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LetterSendViaPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an existing letter Calls Letter.php
        /// </summary>
        /// <param name="id">id of letter you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create letter.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param> 
        /// <returns>ModelLetter</returns>            
        public ModelLetter UpdateLetter (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateLetter");
            
    
            var path = "/Letter/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateLetter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateLetter: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelLetter) ApiClient.Deserialize(response.Content, typeof(ModelLetter), response.Headers);
        }
    
    }
}
