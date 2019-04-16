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
    public interface IDocumentFolderApi
    {
        /// <summary>
        /// Create a new document folder Calls DocumentFolder.php
        /// </summary>
        /// <param name="body">To create a document folder, simply enter desired values after parameter&#x3D; and remove the quotation marks</param>
        /// <returns>ModelDocumentFolder</returns>
        ModelDocumentFolder AddDocumentFolder (string body);
        /// <summary>
        /// Delete an existing document folder Calls the delete() function in DocumentFolder.php
        /// </summary>
        /// <param name="id">id of document folder you want to delete</param>
        /// <returns></returns>
        void DeleteDocumentFolder (int? id);
        /// <summary>
        /// Delete all objects in the bin Calls the emptyBin() function in DocumentFolder.php
        /// </summary>
        /// <returns></returns>
        void EmptyBin ();
        /// <summary>
        /// Returns children (documents and document folders) as &#39;nodes&#39; and count of all children as &#39;total&#39; Calls getChildren() in DocumentFolder.php to get necessary variables
        /// </summary>
        /// <param name="id">Document folder of which you want to get the children</param>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned children start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelDocumentFolder</returns>
        ModelDocumentFolder GetDocumentFolderChildren (int? id, int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Get an overview of all documents in a document folder Calls getDocuments() in DocumentFolder.php to get necessary variables
        /// </summary>
        /// <param name="id">Document folder of which you want to get the containing documents</param>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned documents start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelDocumentFolder</returns>
        ModelDocumentFolder GetDocumentFolderDocuments (int? id, int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Get an overview of all folders in a document folder Calls getFolders() in DocumentFolder.php to get necessary variables
        /// </summary>
        /// <param name="id">Document folder of which you want to get the containing folders</param>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned folders start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelDocumentFolder</returns>
        ModelDocumentFolder GetDocumentFolderFolders (int? id, int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Get path (all parent folders) of this folder Calls getPath() in DocumentFolder.php to get necessary variables
        /// </summary>
        /// <param name="id">Document folder of which you want to get the path</param>
        /// <returns>ModelDocumentFolder</returns>
        ModelDocumentFolder GetDocumentFolderPath (int? id);
        /// <summary>
        /// Get an overview of all document folders Calls DocumentFolder.php to get necessary variables
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned document folders start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelDocumentFolder</returns>
        ModelDocumentFolder GetDocumentFolders (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Trash an existing document folder Calls trash() in DocumentFolder.php
        /// </summary>
        /// <param name="id">id of document folder you want to trash</param>
        /// <returns></returns>
        void TrashDocumentFolder (int? id);
        /// <summary>
        /// Update an existing document folder Calls DocumentFolder.php
        /// </summary>
        /// <param name="id">id of document folder you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create document folder.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param>
        /// <returns>ModelDocumentFolder</returns>
        ModelDocumentFolder UpdateDocumentFolder (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DocumentFolderApi : IDocumentFolderApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentFolderApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DocumentFolderApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentFolderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DocumentFolderApi(String basePath)
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
        /// Create a new document folder Calls DocumentFolder.php
        /// </summary>
        /// <param name="body">To create a document folder, simply enter desired values after parameter&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelDocumentFolder</returns>            
        public ModelDocumentFolder AddDocumentFolder (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddDocumentFolder");
            
    
            var path = "/DocumentFolder";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddDocumentFolder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDocumentFolder: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelDocumentFolder) ApiClient.Deserialize(response.Content, typeof(ModelDocumentFolder), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing document folder Calls the delete() function in DocumentFolder.php
        /// </summary>
        /// <param name="id">id of document folder you want to delete</param> 
        /// <returns></returns>            
        public void DeleteDocumentFolder (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteDocumentFolder");
            
    
            var path = "/DocumentFolder/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDocumentFolder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDocumentFolder: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete all objects in the bin Calls the emptyBin() function in DocumentFolder.php
        /// </summary>
        /// <returns></returns>            
        public void EmptyBin ()
        {
            
    
            var path = "/DocumentFolder/emptyBin";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmptyBin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmptyBin: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns children (documents and document folders) as &#39;nodes&#39; and count of all children as &#39;total&#39; Calls getChildren() in DocumentFolder.php to get necessary variables
        /// </summary>
        /// <param name="id">Document folder of which you want to get the children</param> 
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned children start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelDocumentFolder</returns>            
        public ModelDocumentFolder GetDocumentFolderChildren (int? id, int? limit, int? offset, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDocumentFolderChildren");
            
    
            var path = "/DocumentFolder/{id}/getChildren";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocumentFolderChildren: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocumentFolderChildren: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelDocumentFolder) ApiClient.Deserialize(response.Content, typeof(ModelDocumentFolder), response.Headers);
        }
    
        /// <summary>
        /// Get an overview of all documents in a document folder Calls getDocuments() in DocumentFolder.php to get necessary variables
        /// </summary>
        /// <param name="id">Document folder of which you want to get the containing documents</param> 
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned documents start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelDocumentFolder</returns>            
        public ModelDocumentFolder GetDocumentFolderDocuments (int? id, int? limit, int? offset, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDocumentFolderDocuments");
            
    
            var path = "/DocumentFolder/{id}/getDocuments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocumentFolderDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocumentFolderDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelDocumentFolder) ApiClient.Deserialize(response.Content, typeof(ModelDocumentFolder), response.Headers);
        }
    
        /// <summary>
        /// Get an overview of all folders in a document folder Calls getFolders() in DocumentFolder.php to get necessary variables
        /// </summary>
        /// <param name="id">Document folder of which you want to get the containing folders</param> 
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned folders start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelDocumentFolder</returns>            
        public ModelDocumentFolder GetDocumentFolderFolders (int? id, int? limit, int? offset, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDocumentFolderFolders");
            
    
            var path = "/DocumentFolder/{id}/getFolders";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocumentFolderFolders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocumentFolderFolders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelDocumentFolder) ApiClient.Deserialize(response.Content, typeof(ModelDocumentFolder), response.Headers);
        }
    
        /// <summary>
        /// Get path (all parent folders) of this folder Calls getPath() in DocumentFolder.php to get necessary variables
        /// </summary>
        /// <param name="id">Document folder of which you want to get the path</param> 
        /// <returns>ModelDocumentFolder</returns>            
        public ModelDocumentFolder GetDocumentFolderPath (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDocumentFolderPath");
            
    
            var path = "/DocumentFolder/{id}/getPath";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocumentFolderPath: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocumentFolderPath: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelDocumentFolder) ApiClient.Deserialize(response.Content, typeof(ModelDocumentFolder), response.Headers);
        }
    
        /// <summary>
        /// Get an overview of all document folders Calls DocumentFolder.php to get necessary variables
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned document folders start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelDocumentFolder</returns>            
        public ModelDocumentFolder GetDocumentFolders (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/DocumentFolder";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocumentFolders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocumentFolders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelDocumentFolder) ApiClient.Deserialize(response.Content, typeof(ModelDocumentFolder), response.Headers);
        }
    
        /// <summary>
        /// Trash an existing document folder Calls trash() in DocumentFolder.php
        /// </summary>
        /// <param name="id">id of document folder you want to trash</param> 
        /// <returns></returns>            
        public void TrashDocumentFolder (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TrashDocumentFolder");
            
    
            var path = "/DocumentFolder/{id}/trash";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TrashDocumentFolder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrashDocumentFolder: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an existing document folder Calls DocumentFolder.php
        /// </summary>
        /// <param name="id">id of document folder you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create document folder.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelDocumentFolder</returns>            
        public ModelDocumentFolder UpdateDocumentFolder (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateDocumentFolder");
            
    
            var path = "/DocumentFolder/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDocumentFolder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDocumentFolder: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelDocumentFolder) ApiClient.Deserialize(response.Content, typeof(ModelDocumentFolder), response.Headers);
        }
    
    }
}
