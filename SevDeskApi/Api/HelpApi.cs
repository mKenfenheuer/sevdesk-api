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
    public interface IHelpApi
    {
        /// <summary>
        /// Get a specified article Calls getArticle() in Help.php to get a specified help article
        /// </summary>
        /// <param name="articleId">Id of the article you want to get</param>
        /// <returns>ModelHelp</returns>
        ModelHelp HelpGetArticle (int? articleId);
        /// <summary>
        /// Get all help articles for a specified section Calls getArticles() in Help.php to get all help articles for a specified section
        /// </summary>
        /// <param name="sectionId">Section id you want to get help articles about</param>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned help articles start. Default is 0</param>
        /// <returns>ModelHelp</returns>
        ModelHelp HelpGetArticles (int? sectionId, int? limit, int? offset);
        /// <summary>
        /// Get all categories of help articles Calls getCategories() in Help.php to get all categories available for searching help articles
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned sections start. Default is 0</param>
        /// <returns>ModelHelp</returns>
        ModelHelp HelpGetCategories (int? limit, int? offset);
        /// <summary>
        /// Get all sections of help articles Calls getSections() in Help.php to get all sections available for searching help articles
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned sections start. Default is 0</param>
        /// <returns>ModelHelp</returns>
        ModelHelp HelpGetSections (int? limit, int? offset);
        /// <summary>
        /// Search for articles Calls search() in Help.php to search for articles
        /// </summary>
        /// <param name="name">String to search for</param>
        /// <returns>ModelHelp</returns>
        ModelHelp HelpSearchArticles (string name);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HelpApi : IHelpApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HelpApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HelpApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HelpApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HelpApi(String basePath)
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
        /// Get a specified article Calls getArticle() in Help.php to get a specified help article
        /// </summary>
        /// <param name="articleId">Id of the article you want to get</param> 
        /// <returns>ModelHelp</returns>            
        public ModelHelp HelpGetArticle (int? articleId)
        {
            
            // verify the required parameter 'articleId' is set
            if (articleId == null) throw new ApiException(400, "Missing required parameter 'articleId' when calling HelpGetArticle");
            
    
            var path = "/Help/getArticle";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (articleId != null) queryParams.Add("articleId", ApiClient.ParameterToString(articleId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling HelpGetArticle: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HelpGetArticle: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelHelp) ApiClient.Deserialize(response.Content, typeof(ModelHelp), response.Headers);
        }
    
        /// <summary>
        /// Get all help articles for a specified section Calls getArticles() in Help.php to get all help articles for a specified section
        /// </summary>
        /// <param name="sectionId">Section id you want to get help articles about</param> 
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned help articles start. Default is 0</param> 
        /// <returns>ModelHelp</returns>            
        public ModelHelp HelpGetArticles (int? sectionId, int? limit, int? offset)
        {
            
            // verify the required parameter 'sectionId' is set
            if (sectionId == null) throw new ApiException(400, "Missing required parameter 'sectionId' when calling HelpGetArticles");
            
    
            var path = "/Help/getArticles";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (sectionId != null) queryParams.Add("sectionId", ApiClient.ParameterToString(sectionId)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling HelpGetArticles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HelpGetArticles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelHelp) ApiClient.Deserialize(response.Content, typeof(ModelHelp), response.Headers);
        }
    
        /// <summary>
        /// Get all categories of help articles Calls getCategories() in Help.php to get all categories available for searching help articles
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned sections start. Default is 0</param> 
        /// <returns>ModelHelp</returns>            
        public ModelHelp HelpGetCategories (int? limit, int? offset)
        {
            
    
            var path = "/Help/getCategories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HelpGetCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HelpGetCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelHelp) ApiClient.Deserialize(response.Content, typeof(ModelHelp), response.Headers);
        }
    
        /// <summary>
        /// Get all sections of help articles Calls getSections() in Help.php to get all sections available for searching help articles
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned sections start. Default is 0</param> 
        /// <returns>ModelHelp</returns>            
        public ModelHelp HelpGetSections (int? limit, int? offset)
        {
            
    
            var path = "/Help/getSections";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HelpGetSections: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HelpGetSections: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelHelp) ApiClient.Deserialize(response.Content, typeof(ModelHelp), response.Headers);
        }
    
        /// <summary>
        /// Search for articles Calls search() in Help.php to search for articles
        /// </summary>
        /// <param name="name">String to search for</param> 
        /// <returns>ModelHelp</returns>            
        public ModelHelp HelpSearchArticles (string name)
        {
            
    
            var path = "/Help/search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling HelpSearchArticles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HelpSearchArticles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelHelp) ApiClient.Deserialize(response.Content, typeof(ModelHelp), response.Headers);
        }
    
    }
}
