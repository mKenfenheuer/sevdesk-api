using System;
using System.Collections.Generic;
using RestSharp;
using SevDeskApi.Client;

namespace SevDeskApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDocServerApi
    {
        /// <summary>
        /// Delete a specified letter paper Calls deleteLetterpaper() in DocServer.php to delete a specified letter paper
        /// </summary>
        /// <param name="body">Enter the id of the letter paper you want to delete after id&#x3D; and remove the quotation marks!</param>
        /// <returns></returns>
        void DocServerDeleteLetterPaper (string body);
        /// <summary>
        /// Delete a specified template Calls setDefaultTemplate() in DocServer.php to set the specified template as the default template
        /// </summary>
        /// <param name="body">Enter the id of the template you want to set as the default template after id&#x3D; and remove the quotation marks!</param>
        /// <returns></returns>
        void DocServerDeleteTemplate (string body);
        /// <summary>
        /// Get an overview of all letter papers Calls getLetterpapers() in DocServer.php to get the stored letter papers
        /// </summary>
        /// <returns></returns>
        void DocServerGetLetterPapers ();
        /// <summary>
        /// Get an overview of all letter papers with their thumb Calls getLetterpapersWithThumb() in DocServer.php to get the stored letter papers with their thumb.
        /// </summary>
        /// <returns></returns>
        void DocServerGetLetterPapersWithThumb ();
        /// <summary>
        /// Get an overview of all templates Calls getTemplates() in DocServer.php to get the stored templates.
        /// </summary>
        /// <returns></returns>
        void DocServerGetTemplates ();
        /// <summary>
        /// Get an overview of all templates with their thumb Calls getTemplatesWithThumb() in DocServer.php to get the stored templates with their thumb.
        /// </summary>
        /// <returns></returns>
        void DocServerGetTemplatesWithThumb ();
        /// <summary>
        /// Set a letter papers as the default letter paper Calls setDefaultLetterpaper() in DocServer.php to set the specified letter paper as the default letter paper
        /// </summary>
        /// <param name="body">Enter the id of the letter paper you want to set as the default letter paper after id&#x3D; and remove the quotation marks!</param>
        /// <returns></returns>
        void DocServerSetDefaultLetterPaper (string body);
        /// <summary>
        /// Set a template as the default template Calls setDefaultTemplate() in DocServer.php to set the specified template as the default template
        /// </summary>
        /// <param name="body">Enter the id of the template you want to set as the default template after id&#x3D; and remove the quotation marks!</param>
        /// <returns></returns>
        void DocServerSetDefaultTemplate (string body);
        /// <summary>
        /// Store a letter paper on the doc server Calls storeLetterpaper() in DocServer.php to store a letter paper on the doc server
        /// </summary>
        /// <param name="body">Enter the desired values after parameter&#x3D; and remove the quotation marks!    Be aware that you need to enter the base64 of the pdf you want as a letter paper after pdf&#x3D;!</param>
        /// <returns></returns>
        void DocServerStoreLetterPaper (string body);
        /// <summary>
        /// Store a template on the doc server Calls storeTemplate() in DocServer.php to store a template on the doc server
        /// </summary>
        /// <param name="body">Enter the desired values after parameter&#x3D; and remove the quotation marks!    Be aware that you need to enter the html code of your template after html&#x3D;! Type can be Invoice, Invoicereminder, Order, Contractnote, Packingllist, Letter.</param>
        /// <returns></returns>
        void DocServerStoreTemplate (string body);
        /// <summary>
        /// Test a letter paper Calls testLetterpaper() in DocServer.php to test your letter paper by providing the pdf.
        /// </summary>
        /// <param name="file">Pdf file to test</param>
        /// <returns></returns>
        void DocServerTestLetterPaper (System.IO.Stream file);
        /// <summary>
        /// Test a template Calls testTemplate() in DocServer.php to test your template by providing the html.
        /// </summary>
        /// <param name="body">Enter the html of your template after html&#x3D; and remove the quotation marks!</param>
        /// <returns></returns>
        void DocServerTestTemplate (string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DocServerApi : IDocServerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocServerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DocServerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocServerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DocServerApi(String basePath)
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
        /// Delete a specified letter paper Calls deleteLetterpaper() in DocServer.php to delete a specified letter paper
        /// </summary>
        /// <param name="body">Enter the id of the letter paper you want to delete after id&#x3D; and remove the quotation marks!</param> 
        /// <returns></returns>            
        public void DocServerDeleteLetterPaper (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DocServerDeleteLetterPaper");
            
    
            var path = "/DocServer/deleteLetterpaper";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerDeleteLetterPaper: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerDeleteLetterPaper: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a specified template Calls setDefaultTemplate() in DocServer.php to set the specified template as the default template
        /// </summary>
        /// <param name="body">Enter the id of the template you want to set as the default template after id&#x3D; and remove the quotation marks!</param> 
        /// <returns></returns>            
        public void DocServerDeleteTemplate (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DocServerDeleteTemplate");
            
    
            var path = "/DocServer/deleteTemplate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerDeleteTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerDeleteTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all letter papers Calls getLetterpapers() in DocServer.php to get the stored letter papers
        /// </summary>
        /// <returns></returns>            
        public void DocServerGetLetterPapers ()
        {
            
    
            var path = "/DocServer/getLetterpapers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerGetLetterPapers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerGetLetterPapers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all letter papers with their thumb Calls getLetterpapersWithThumb() in DocServer.php to get the stored letter papers with their thumb.
        /// </summary>
        /// <returns></returns>            
        public void DocServerGetLetterPapersWithThumb ()
        {
            
    
            var path = "/DocServer/getLetterpapersWithThumb";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerGetLetterPapersWithThumb: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerGetLetterPapersWithThumb: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all templates Calls getTemplates() in DocServer.php to get the stored templates.
        /// </summary>
        /// <returns></returns>            
        public void DocServerGetTemplates ()
        {
            
    
            var path = "/DocServer/getTemplates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerGetTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerGetTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all templates with their thumb Calls getTemplatesWithThumb() in DocServer.php to get the stored templates with their thumb.
        /// </summary>
        /// <returns></returns>            
        public void DocServerGetTemplatesWithThumb ()
        {
            
    
            var path = "/DocServer/getTemplatesWithThumb";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerGetTemplatesWithThumb: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerGetTemplatesWithThumb: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set a letter papers as the default letter paper Calls setDefaultLetterpaper() in DocServer.php to set the specified letter paper as the default letter paper
        /// </summary>
        /// <param name="body">Enter the id of the letter paper you want to set as the default letter paper after id&#x3D; and remove the quotation marks!</param> 
        /// <returns></returns>            
        public void DocServerSetDefaultLetterPaper (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DocServerSetDefaultLetterPaper");
            
    
            var path = "/DocServer/setDefaultLetterpaper";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerSetDefaultLetterPaper: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerSetDefaultLetterPaper: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set a template as the default template Calls setDefaultTemplate() in DocServer.php to set the specified template as the default template
        /// </summary>
        /// <param name="body">Enter the id of the template you want to set as the default template after id&#x3D; and remove the quotation marks!</param> 
        /// <returns></returns>            
        public void DocServerSetDefaultTemplate (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DocServerSetDefaultTemplate");
            
    
            var path = "/DocServer/setDefaultTemplate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerSetDefaultTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerSetDefaultTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Store a letter paper on the doc server Calls storeLetterpaper() in DocServer.php to store a letter paper on the doc server
        /// </summary>
        /// <param name="body">Enter the desired values after parameter&#x3D; and remove the quotation marks!    Be aware that you need to enter the base64 of the pdf you want as a letter paper after pdf&#x3D;!</param> 
        /// <returns></returns>            
        public void DocServerStoreLetterPaper (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DocServerStoreLetterPaper");
            
    
            var path = "/DocServer/storeLetterpaper";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerStoreLetterPaper: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerStoreLetterPaper: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Store a template on the doc server Calls storeTemplate() in DocServer.php to store a template on the doc server
        /// </summary>
        /// <param name="body">Enter the desired values after parameter&#x3D; and remove the quotation marks!    Be aware that you need to enter the html code of your template after html&#x3D;! Type can be Invoice, Invoicereminder, Order, Contractnote, Packingllist, Letter.</param> 
        /// <returns></returns>            
        public void DocServerStoreTemplate (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DocServerStoreTemplate");
            
    
            var path = "/DocServer/storeTemplate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerStoreTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerStoreTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Test a letter paper Calls testLetterpaper() in DocServer.php to test your letter paper by providing the pdf.
        /// </summary>
        /// <param name="file">Pdf file to test</param> 
        /// <returns></returns>            
        public void DocServerTestLetterPaper (System.IO.Stream file)
        {
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling DocServerTestLetterPaper");
            
    
            var path = "/DocServer/testLetterpaper";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (file != null) fileParams.Add("file", ApiClient.ParameterToFile("file", file));
                
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerTestLetterPaper: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerTestLetterPaper: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Test a template Calls testTemplate() in DocServer.php to test your template by providing the html.
        /// </summary>
        /// <param name="body">Enter the html of your template after html&#x3D; and remove the quotation marks!</param> 
        /// <returns></returns>            
        public void DocServerTestTemplate (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DocServerTestTemplate");
            
    
            var path = "/DocServer/testTemplate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerTestTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DocServerTestTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
