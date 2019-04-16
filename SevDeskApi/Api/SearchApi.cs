using System;
using System.Collections.Generic;
using RestSharp;
using SevDeskApi.Client;

namespace SevDeskApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApi
    {
        /// <summary>
        /// Search for a specified term Calls search() in Search.php to search with a specified term in Contacts, Orders, Invoices, Vouchers, Documents and Parts.    It is also possible to search without defining a model, so sevDesk system operations will also be shown.
        /// </summary>
        /// <param name="embed"></param>
        /// <param name="term">Term you want to search</param>
        /// <param name="searchType">Specify a type (model) that you want to have searched</param>
        /// <returns></returns>
        void Search (string embed, string term, List<string> searchType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SearchApi : ISearchApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SearchApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi(String basePath)
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
        /// Search for a specified term Calls search() in Search.php to search with a specified term in Contacts, Orders, Invoices, Vouchers, Documents and Parts.    It is also possible to search without defining a model, so sevDesk system operations will also be shown.
        /// </summary>
        /// <param name="embed"></param> 
        /// <param name="term">Term you want to search</param> 
        /// <param name="searchType">Specify a type (model) that you want to have searched</param> 
        /// <returns></returns>            
        public void Search (string embed, string term, List<string> searchType)
        {
            
    
            var path = "/Search/search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (embed != null) queryParams.Add("embed", ApiClient.ParameterToString(embed)); // query parameter
 if (term != null) queryParams.Add("term", ApiClient.ParameterToString(term)); // query parameter
 if (searchType != null) queryParams.Add("searchType", ApiClient.ParameterToString(searchType)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Search: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Search: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
