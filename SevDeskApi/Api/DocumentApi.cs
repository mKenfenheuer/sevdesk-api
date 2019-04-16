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
    public interface IDocumentApi
    {
        /// <summary>
        /// Create a new document. Be aware that there wont be a working document with content! Calls Document.php
        /// </summary>
        /// <param name="body">To create a document, simply enter desired values after parameter&#x3D; and remove the quotation marks</param>
        /// <returns>ModelDocument</returns>
        ModelDocument AddDocument(string body);
        /// <summary>
        /// Delete an existing document Calls the delete() function in Document.php
        /// </summary>
        /// <param name="id">id of document you want to delete</param>
        /// <returns></returns>
        void DeleteDocument(int? id);
        /// <summary>
        /// Download a document Calls download() in Document.php to download a document. Will return base64 content.
        /// </summary>
        /// <param name="id">Id of the document you want to download</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream DownloadDocument(int? id);
        /// <summary>
        /// Upload a file (creating a document) With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the Model.php itself still constructs the model however new instances of the model are created trough the Factory.php    So for example when you create a new invoice it wont be saved by a POST request with &#39;/Invoice?para1&#x3D;&amp;...&#39; but with the saveInvoice function in Factory.php &#39;Voucher/Factory/saveInvoice?para1&#x3D;&#39;
        /// </summary>
        /// <param name="file">file to upload</param>
        /// <param name="_object">object to which you want to upload your file</param>
        /// <param name="folder">folder to which you want to upload your file</param>
        /// <returns></returns>
        void FactoryAddDocument(System.IO.Stream file, string _object, string folder);
        /// <summary>
        /// Get an overview of all documents Calls Document.php to get necessary variables
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned documents start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelDocument</returns>
        ModelDocument GetDocuments(int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Update an existing document. Be aware that you can only update its parameter but not the content of the document itself! Calls Document.php
        /// </summary>
        /// <param name="id">id of document you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create document.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param>
        /// <returns>ModelDocument</returns>
        ModelDocument UpdateDocument(int? id, string body);
        /// <summary>
        /// Update an existing documents status to &#39;TRASHED&#39;, be aware that this deletes the document Calls trash() in Document.php
        /// </summary>
        /// <param name="id">id of document of which you want to update the status to &#39;TRASHED</param>
        /// <returns></returns>
        void UpdateDocumentStatusToTrashed(int? id);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DocumentApi : IDocumentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DocumentApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DocumentApi(String basePath)
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
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Create a new document. Be aware that there wont be a working document with content! Calls Document.php
        /// </summary>
        /// <param name="body">To create a document, simply enter desired values after parameter&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelDocument</returns>            
        public ModelDocument AddDocument(string body)
        {

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddDocument");


            var path = "/Document";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AddDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AddDocument: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelDocument)ApiClient.Deserialize(response.Content, typeof(ModelDocument), response.Headers);
        }

        /// <summary>
        /// Delete an existing document Calls the delete() function in Document.php
        /// </summary>
        /// <param name="id">id of document you want to delete</param> 
        /// <returns></returns>            
        public void DeleteDocument(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteDocument");


            var path = "/Document/{id}";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteDocument: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Download a document Calls download() in Document.php to download a document. Will return base64 content.
        /// </summary>
        /// <param name="id">Id of the document you want to download</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream DownloadDocument(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DownloadDocument");


            var path = "/Document/{id}/download";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DownloadDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DownloadDocument: " + response.ErrorMessage, response.ErrorMessage);

            return (System.IO.Stream)ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }

        /// <summary>
        /// Upload a file (creating a document) With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the Model.php itself still constructs the model however new instances of the model are created trough the Factory.php    So for example when you create a new invoice it wont be saved by a POST request with &#39;/Invoice?para1&#x3D;&amp;...&#39; but with the saveInvoice function in Factory.php &#39;Voucher/Factory/saveInvoice?para1&#x3D;&#39;
        /// </summary>
        /// <param name="file">file to upload</param> 
        /// <param name="_object">object to which you want to upload your file</param> 
        /// <param name="folder">folder to which you want to upload your file</param> 
        /// <returns></returns>            
        public void FactoryAddDocument(System.IO.Stream file, string _object, string folder)
        {

            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling FactoryAddDocument");


            var path = "/Document/Factory/fileUpload";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (_object != null) queryParams.Add("object", ApiClient.ParameterToString(_object)); // query parameter
            if (folder != null) queryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (file != null) fileParams.Add("file", ApiClient.ParameterToFile("file", file));

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling FactoryAddDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling FactoryAddDocument: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get an overview of all documents Calls Document.php to get necessary variables
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned documents start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelDocument</returns>            
        public ModelDocument GetDocuments(int? limit, int? offset, List<string> embed)
        {


            var path = "/Document";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelDocument)ApiClient.Deserialize(response.Content, typeof(ModelDocument), response.Headers);
        }

        /// <summary>
        /// Update an existing document. Be aware that you can only update its parameter but not the content of the document itself! Calls Document.php
        /// </summary>
        /// <param name="id">id of document you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create document.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelDocument</returns>            
        public ModelDocument UpdateDocument(int? id, string body)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateDocument");


            var path = "/Document/{id}";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateDocument: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelDocument)ApiClient.Deserialize(response.Content, typeof(ModelDocument), response.Headers);
        }

        /// <summary>
        /// Update an existing documents status to &#39;TRASHED&#39;, be aware that this deletes the document Calls trash() in Document.php
        /// </summary>
        /// <param name="id">id of document of which you want to update the status to &#39;TRASHED</param> 
        /// <returns></returns>            
        public void UpdateDocumentStatusToTrashed(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateDocumentStatusToTrashed");


            var path = "/Document/{id}/trash";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateDocumentStatusToTrashed: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateDocumentStatusToTrashed: " + response.ErrorMessage, response.ErrorMessage);
        }

    }
}
