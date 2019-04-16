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
    public interface IPartApi
    {
        /// <summary>
        /// Create a new part Calls Part.php to add a part
        /// </summary>
        /// <param name="body">To create a part, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns>ModelPart</returns>
        ModelPart AddPart (string body);
        /// <summary>
        /// add / remove parts from the stock Calls book() in Part.php
        /// </summary>
        /// <param name="id">id of part of which you want to update the stock</param>
        /// <param name="body">Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param>
        /// <returns>ModelPart</returns>
        ModelPart BookPart (int? id, string body);
        /// <summary>
        /// Delete an existing part Calls the delete() function in Part.php. Be aware that you can&#39;t delete parts which are used somewhere!
        /// </summary>
        /// <param name="id">id of the part you want to delete</param>
        /// <returns></returns>
        void DeletePart (int? id);
        /// <summary>
        /// Duplicate an existing part Calls duplicate() in Part.php to duplicate the specified part. Mind that the stock will be zero
        /// </summary>
        /// <param name="id">Id of the part which you want to duplicate</param>
        /// <returns>ModelPart</returns>
        ModelPart DuplicatePart (int? id);
        /// <summary>
        /// Get an overview of all parts Calls Part.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned parts start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelPart</returns>
        ModelPart GetParts (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Get last log about the part Calls getLastLog() in Part.php to get the last log about the specified part
        /// </summary>
        /// <param name="id">Id of the part of which you want to get the last log</param>
        /// <param name="maxDate">Sets the maximal date if required</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelInventoryPartLog</returns>
        ModelInventoryPartLog PartGetLastLog (int? id, string maxDate, List<string> embed);
        /// <summary>
        /// Get price of a specified part Calls getPrice() in Part.php to get the price of the specified part
        /// </summary>
        /// <param name="id">Id of the part of which you want to get the price</param>
        /// <param name="contactId">Enter valid contact id here for getting a part contact price</param>
        /// <param name="contactObjectName">Enter &#39;Contact&#39; here for getting a part contact price</param>
        /// <param name="partUnityId">Enter a valid part unity id here for getting a part unity price</param>
        /// <param name="partUnityObjectName">Enter &#39;PartUnity&#39; here for getting a part unity price</param>
        /// <returns></returns>
        void PartGetPrice (int? id, int? contactId, string contactObjectName, int? partUnityId, string partUnityObjectName);
        /// <summary>
        /// Get stock of the part Calls getStock() in Part.php to get the stock of the specified part
        /// </summary>
        /// <param name="id">Id of the part of which you want to get stock</param>
        /// <param name="maxDate">Sets the maximal date if required. The function will return the stock of the part at the specified date!</param>
        /// <returns></returns>
        void PartGetStock (int? id, string maxDate);
        /// <summary>
        /// Get stock difference of the part before a specified date Calls getStockBefore() in Part.php to get the stock difference of the specified part before the specified date
        /// </summary>
        /// <param name="id">Id of the part of which you want to get the stock difference</param>
        /// <param name="date">You will get the stock difference before this specified date, otherwise the current date will be used</param>
        /// <returns></returns>
        void PartGetStockBefore (int? id, string date);
        /// <summary>
        /// Update an existing part Calls PartContactPrice to update a part
        /// </summary>
        /// <param name="id">id of part you want to update</param>
        /// <param name="body">Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param>
        /// <returns>ModelPart</returns>
        ModelPart UpdatePart (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PartApi : IPartApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PartApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PartApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PartApi(String basePath)
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
        /// Create a new part Calls Part.php to add a part
        /// </summary>
        /// <param name="body">To create a part, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns>ModelPart</returns>            
        public ModelPart AddPart (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddPart");
            
    
            var path = "/Part";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddPart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddPart: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPart) ApiClient.Deserialize(response.Content, typeof(ModelPart), response.Headers);
        }
    
        /// <summary>
        /// add / remove parts from the stock Calls book() in Part.php
        /// </summary>
        /// <param name="id">id of part of which you want to update the stock</param> 
        /// <param name="body">Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelPart</returns>            
        public ModelPart BookPart (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BookPart");
            
    
            var path = "/Part/{id}/book";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BookPart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BookPart: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPart) ApiClient.Deserialize(response.Content, typeof(ModelPart), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing part Calls the delete() function in Part.php. Be aware that you can&#39;t delete parts which are used somewhere!
        /// </summary>
        /// <param name="id">id of the part you want to delete</param> 
        /// <returns></returns>            
        public void DeletePart (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletePart");
            
    
            var path = "/Part/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePart: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Duplicate an existing part Calls duplicate() in Part.php to duplicate the specified part. Mind that the stock will be zero
        /// </summary>
        /// <param name="id">Id of the part which you want to duplicate</param> 
        /// <returns>ModelPart</returns>            
        public ModelPart DuplicatePart (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DuplicatePart");
            
    
            var path = "/Part/{id}/duplicate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DuplicatePart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DuplicatePart: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPart) ApiClient.Deserialize(response.Content, typeof(ModelPart), response.Headers);
        }
    
        /// <summary>
        /// Get an overview of all parts Calls Part.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned parts start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelPart</returns>            
        public ModelPart GetParts (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/Part";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetParts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetParts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPart) ApiClient.Deserialize(response.Content, typeof(ModelPart), response.Headers);
        }
    
        /// <summary>
        /// Get last log about the part Calls getLastLog() in Part.php to get the last log about the specified part
        /// </summary>
        /// <param name="id">Id of the part of which you want to get the last log</param> 
        /// <param name="maxDate">Sets the maximal date if required</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelInventoryPartLog</returns>            
        public ModelInventoryPartLog PartGetLastLog (int? id, string maxDate, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PartGetLastLog");
            
    
            var path = "/Part/{id}/getLastLog";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (maxDate != null) queryParams.Add("maxDate", ApiClient.ParameterToString(maxDate)); // query parameter
 if (embed != null) queryParams.Add("embed", ApiClient.ParameterToString(embed)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PartGetLastLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PartGetLastLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelInventoryPartLog) ApiClient.Deserialize(response.Content, typeof(ModelInventoryPartLog), response.Headers);
        }
    
        /// <summary>
        /// Get price of a specified part Calls getPrice() in Part.php to get the price of the specified part
        /// </summary>
        /// <param name="id">Id of the part of which you want to get the price</param> 
        /// <param name="contactId">Enter valid contact id here for getting a part contact price</param> 
        /// <param name="contactObjectName">Enter &#39;Contact&#39; here for getting a part contact price</param> 
        /// <param name="partUnityId">Enter a valid part unity id here for getting a part unity price</param> 
        /// <param name="partUnityObjectName">Enter &#39;PartUnity&#39; here for getting a part unity price</param> 
        /// <returns></returns>            
        public void PartGetPrice (int? id, int? contactId, string contactObjectName, int? partUnityId, string partUnityObjectName)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PartGetPrice");
            
    
            var path = "/Part/{id}/getPrice";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (contactId != null) queryParams.Add("contact[id]", ApiClient.ParameterToString(contactId)); // query parameter
 if (contactObjectName != null) queryParams.Add("contact[objectName]", ApiClient.ParameterToString(contactObjectName)); // query parameter
 if (partUnityId != null) queryParams.Add("partUnity[id]", ApiClient.ParameterToString(partUnityId)); // query parameter
 if (partUnityObjectName != null) queryParams.Add("partUnity[objectName]", ApiClient.ParameterToString(partUnityObjectName)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PartGetPrice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PartGetPrice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get stock of the part Calls getStock() in Part.php to get the stock of the specified part
        /// </summary>
        /// <param name="id">Id of the part of which you want to get stock</param> 
        /// <param name="maxDate">Sets the maximal date if required. The function will return the stock of the part at the specified date!</param> 
        /// <returns></returns>            
        public void PartGetStock (int? id, string maxDate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PartGetStock");
            
    
            var path = "/Part/{id}/getStock";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (maxDate != null) queryParams.Add("maxDate", ApiClient.ParameterToString(maxDate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PartGetStock: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PartGetStock: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get stock difference of the part before a specified date Calls getStockBefore() in Part.php to get the stock difference of the specified part before the specified date
        /// </summary>
        /// <param name="id">Id of the part of which you want to get the stock difference</param> 
        /// <param name="date">You will get the stock difference before this specified date, otherwise the current date will be used</param> 
        /// <returns></returns>            
        public void PartGetStockBefore (int? id, string date)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PartGetStockBefore");
            
    
            var path = "/Part/{id}/getStockBefore";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PartGetStockBefore: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PartGetStockBefore: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an existing part Calls PartContactPrice to update a part
        /// </summary>
        /// <param name="id">id of part you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelPart</returns>            
        public ModelPart UpdatePart (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdatePart");
            
    
            var path = "/Part/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePart: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPart) ApiClient.Deserialize(response.Content, typeof(ModelPart), response.Headers);
        }
    
    }
}
