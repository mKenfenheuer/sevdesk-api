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
    public interface IOrderApi
    {
        /// <summary>
        /// Create a new order Calls Order.php
        /// </summary>
        /// <param name="body">To create an order, simply enter desired values after parameter&#x3D;, concatenate additional parameters with &amp; and remove the quotation marks.    Be aware that you can&#39;t use all the parameters included in the Model_Order, as creating an order involves other functions/models.    So for example, adding a sumNet/Gross/etc. does not work as they normally get their value from the product/part which is involved in the order.    The product/part in this case is handled in the Model_OrderPos which makes a call to Model_Part.    In Order.php there is only a function &#39;getPositions&#39; which makes the call to OrderPos.php to get the positions involved in the order.</param>
        /// <returns>ModelOrder</returns>
        ModelOrder AddOrder (string body);
        /// <summary>
        /// Copy an existing order Calls copy() in Order.php to copy an existing order.    The new orders origin is the copied order, and its version is the copied orders version increased by one.
        /// </summary>
        /// <param name="id">Id of the order which you want to copy</param>
        /// <returns>ModelOrder</returns>
        ModelOrder CopyOrder (int? id);
        /// <summary>
        /// Delete an existing order Calls the delete() function in Order.php
        /// </summary>
        /// <param name="id">id of order you want to delete</param>
        /// <returns></returns>
        void DeleteOrder (int? id);
        /// <summary>
        /// Duplicate an existing order Calls duplicate() in Order.php to duplicate an existing order
        /// </summary>
        /// <param name="id">Id of the order which you want to duplicate</param>
        /// <returns>ModelOrder</returns>
        ModelOrder DuplicateOrder (int? id);
        /// <summary>
        /// Get the next order number 
        /// </summary>
        /// <param name="orderType">defines the type of order you want to get the next number from</param>
        /// <param name="useNextNumber">By default this is true, so the orderNumber will increase by one otherwise the orderNumber will not change</param>
        /// <returns></returns>
        void GetNextOrderNumber (string orderType, bool? useNextNumber);
        /// <summary>
        /// Get all order discounts Calls getDiscounts() in Order.php to get the discounts of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the discounts</param>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned order positions start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelDiscounts</returns>
        ModelDiscounts GetOrderDiscounts (int? id, int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Get an overview of all orders Calls Order.php to get necessary variables. However, not all variables get their value from Order.php directly but from other models like Model_OrderPos
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned invoice positions start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;</param>
        /// <returns>ModelOrder</returns>
        ModelOrder GetOrders (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Update status of an existing order Calls changeStatus() in Order.php to update the specified orders status
        /// </summary>
        /// <param name="id">Id of order of which you want to change the status</param>
        /// <param name="body">Enter desired values after parameter&#x3D; and remove the quotation marks!    If updateOther is set to &#39;true&#39;, changeStatus will also change other orders with the same order number.    If updateContactStatus is set to &#39;true&#39;, changeStatus will update the connected contacts category if necessary.</param>
        /// <returns>ModelOrder</returns>
        ModelOrder OrderChangeStatus (int? id, string body);
        /// <summary>
        /// Get sum charged already, total net, gross and tax amount and tax rate Calls getChargeableInformation() in Order.php to get the sum charged already, total net, gross and tax amount and tax rate of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the information</param>
        /// <returns></returns>
        void OrderGetChargeableInformation (int? id);
        /// <summary>
        /// Get total net, gross and tax amount of order Calls getChargeableSums() in Order.php to get the total net, gross and tax amount of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the total net, gross and tax amount</param>
        /// <returns></returns>
        void OrderGetChargeableSums (int? id);
        /// <summary>
        /// Get main order by checking if there are existing order logs of the specified order Calls getMainOrderByLogs() in Order.php to get main order by checking if there are existing order logs of the specified order.    If the specified order is not the main order (eg. if there are no existing logs), this will return null!
        /// </summary>
        /// <param name="id">Id of the order of which you want to know if it is the main order</param>
        /// <returns>ModelOrder</returns>
        ModelOrder OrderGetMainOrderByLogs (int? id);
        /// <summary>
        /// Get the order as a pdf Calls getPdf() in Order.php
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the pdf</param>
        /// <param name="preventSendBy">Define if you want to prevent to send the order via pdf</param>
        /// <returns></returns>
        void OrderGetPdf (int? id, bool? preventSendBy);
        /// <summary>
        /// Get all order positions Calls getPositions() in Order.php to get necessary variables
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the positions</param>
        /// <param name="withOptional">Define if you want optional order positions</param>
        /// <param name="onlyChargeable">Define if you want only chargeable order positions</param>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned order positions start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelOrderPos</returns>
        ModelOrderPos OrderGetPositions (int? id, bool? withOptional, bool? onlyChargeable, int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Get related objects of a specified order Calls getRelatedObjects() in Order.php to get related objects of the order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the related objects</param>
        /// <param name="includeItself">Define if the related objects include the order itself</param>
        /// <param name="sortByType">Define if you want the related objects sorted by type</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns></returns>
        void OrderGetRelatedObjects (int? id, bool? includeItself, bool? sortByType, List<string> embed);
        /// <summary>
        /// Get tags of the specified order Calls getTags() in Order.php to get the tags of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the tags</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns></returns>
        void OrderGetTags (int? id, List<string> embed);
        /// <summary>
        /// Get sum tax of the specified order Calls getTax() in Order.php to get the sum tax of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the sum tax</param>
        /// <param name="foreignCurrency">Specify if a foreign currency is used</param>
        /// <returns></returns>
        void OrderGetTax (int? id, bool? foreignCurrency);
        /// <summary>
        /// Get tax groups of the specified order Calls getTaxGroupes() in Order.php to get the tax groups of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the tax groups</param>
        /// <returns></returns>
        void OrderGetTaxGroupes (int? id);
        /// <summary>
        /// Get sum gross of the specified order Calls getTotal() in Order.php to get the sum gross of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the sum gross</param>
        /// <param name="foreignCurrency">Specify if a foreign currency is used</param>
        /// <returns></returns>
        void OrderGetTotal (int? id, bool? foreignCurrency);
        /// <summary>
        /// Get total gross amount of order Calls getTotalCalc() in Order.php to get the total gross amount of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the total gross amount</param>
        /// <returns></returns>
        void OrderGetTotalCalc (int? id);
        /// <summary>
        /// Get total net amount of order Calls getTotalNet() in Order.php to get the total net amount of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the total net amount</param>
        /// <returns></returns>
        void OrderGetTotalNet (int? id);
        /// <summary>
        /// Render the order document on doc server and return the metadata Calls render() in Order.php to render an order document on doc server and return the metadata
        /// </summary>
        /// <param name="id">Id of order you want to render</param>
        /// <returns></returns>
        void OrderRender (int? id);
        /// <summary>
        /// Send an order by the desired send type Calls sendBy() in Order.php to send the order by the desired send type
        /// </summary>
        /// <param name="id">Id of order which you want to send</param>
        /// <param name="sendType">Your desired send type. Available are: VM &#x3D; Mail, VP &#x3D; Post, VPDF &#x3D; PDF, PRN &#x3D; Print</param>
        /// <returns>ModelOrder</returns>
        ModelOrder OrderSendBy (int? id, string sendType);
        /// <summary>
        /// Send an order via Email Calls sendViaEmail in Order.php
        /// </summary>
        /// <param name="id">Id of order you want to send via Email</param>
        /// <param name="body">Change the desired values after the parameters and remove the quotation marks. You can also add &#39;additionalAttachments&#39;, &#39;ccEmail&#x3D;&#39; and &#39;bccEmail&#39;    Please note: additionalAttachments is a String containing document id&#39;s (of existing documents!)</param>
        /// <returns>ModelEmail</returns>
        ModelEmail SendOrderViaEmail (int? id, string body);
        /// <summary>
        /// Send an order via post Calls sendViaPost() in Order.php
        /// </summary>
        /// <param name="id">Id of order you want to send via post</param>
        /// <returns>ModelOrder</returns>
        ModelOrder SendOrderViaPost (int? id);
        /// <summary>
        /// Update an existing order Calls Order.php
        /// </summary>
        /// <param name="id">id of order you want to update</param>
        /// <param name="body">Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param>
        /// <returns>ModelOrder</returns>
        ModelOrder UpdateOrder (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderApi : IOrderApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderApi(String basePath)
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
        /// Create a new order Calls Order.php
        /// </summary>
        /// <param name="body">To create an order, simply enter desired values after parameter&#x3D;, concatenate additional parameters with &amp; and remove the quotation marks.    Be aware that you can&#39;t use all the parameters included in the Model_Order, as creating an order involves other functions/models.    So for example, adding a sumNet/Gross/etc. does not work as they normally get their value from the product/part which is involved in the order.    The product/part in this case is handled in the Model_OrderPos which makes a call to Model_Part.    In Order.php there is only a function &#39;getPositions&#39; which makes the call to OrderPos.php to get the positions involved in the order.</param> 
        /// <returns>ModelOrder</returns>            
        public ModelOrder AddOrder (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddOrder");
            
    
            var path = "/Order";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddOrder: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelOrder) ApiClient.Deserialize(response.Content, typeof(ModelOrder), response.Headers);
        }
    
        /// <summary>
        /// Copy an existing order Calls copy() in Order.php to copy an existing order.    The new orders origin is the copied order, and its version is the copied orders version increased by one.
        /// </summary>
        /// <param name="id">Id of the order which you want to copy</param> 
        /// <returns>ModelOrder</returns>            
        public ModelOrder CopyOrder (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CopyOrder");
            
    
            var path = "/Order/{id}/copy";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CopyOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CopyOrder: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelOrder) ApiClient.Deserialize(response.Content, typeof(ModelOrder), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing order Calls the delete() function in Order.php
        /// </summary>
        /// <param name="id">id of order you want to delete</param> 
        /// <returns></returns>            
        public void DeleteOrder (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteOrder");
            
    
            var path = "/Order/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrder: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Duplicate an existing order Calls duplicate() in Order.php to duplicate an existing order
        /// </summary>
        /// <param name="id">Id of the order which you want to duplicate</param> 
        /// <returns>ModelOrder</returns>            
        public ModelOrder DuplicateOrder (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DuplicateOrder");
            
    
            var path = "/Order/{id}/duplicate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DuplicateOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DuplicateOrder: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelOrder) ApiClient.Deserialize(response.Content, typeof(ModelOrder), response.Headers);
        }
    
        /// <summary>
        /// Get the next order number 
        /// </summary>
        /// <param name="orderType">defines the type of order you want to get the next number from</param> 
        /// <param name="useNextNumber">By default this is true, so the orderNumber will increase by one otherwise the orderNumber will not change</param> 
        /// <returns></returns>            
        public void GetNextOrderNumber (string orderType, bool? useNextNumber)
        {
            
            // verify the required parameter 'orderType' is set
            if (orderType == null) throw new ApiException(400, "Missing required parameter 'orderType' when calling GetNextOrderNumber");
            
            // verify the required parameter 'useNextNumber' is set
            if (useNextNumber == null) throw new ApiException(400, "Missing required parameter 'useNextNumber' when calling GetNextOrderNumber");
            
    
            var path = "/Order/Factory/getNextOrderNumber";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (orderType != null) queryParams.Add("orderType", ApiClient.ParameterToString(orderType)); // query parameter
 if (useNextNumber != null) queryParams.Add("useNextNumber", ApiClient.ParameterToString(useNextNumber)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNextOrderNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNextOrderNumber: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get all order discounts Calls getDiscounts() in Order.php to get the discounts of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the discounts</param> 
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned order positions start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelDiscounts</returns>            
        public ModelDiscounts GetOrderDiscounts (int? id, int? limit, int? offset, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetOrderDiscounts");
            
    
            var path = "/Order/{id}/getDiscounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrderDiscounts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrderDiscounts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelDiscounts) ApiClient.Deserialize(response.Content, typeof(ModelDiscounts), response.Headers);
        }
    
        /// <summary>
        /// Get an overview of all orders Calls Order.php to get necessary variables. However, not all variables get their value from Order.php directly but from other models like Model_OrderPos
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned invoice positions start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;</param> 
        /// <returns>ModelOrder</returns>            
        public ModelOrder GetOrders (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/Order";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelOrder) ApiClient.Deserialize(response.Content, typeof(ModelOrder), response.Headers);
        }
    
        /// <summary>
        /// Update status of an existing order Calls changeStatus() in Order.php to update the specified orders status
        /// </summary>
        /// <param name="id">Id of order of which you want to change the status</param> 
        /// <param name="body">Enter desired values after parameter&#x3D; and remove the quotation marks!    If updateOther is set to &#39;true&#39;, changeStatus will also change other orders with the same order number.    If updateContactStatus is set to &#39;true&#39;, changeStatus will update the connected contacts category if necessary.</param> 
        /// <returns>ModelOrder</returns>            
        public ModelOrder OrderChangeStatus (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderChangeStatus");
            
    
            var path = "/Order/{id}/changeStatus";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrderChangeStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderChangeStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelOrder) ApiClient.Deserialize(response.Content, typeof(ModelOrder), response.Headers);
        }
    
        /// <summary>
        /// Get sum charged already, total net, gross and tax amount and tax rate Calls getChargeableInformation() in Order.php to get the sum charged already, total net, gross and tax amount and tax rate of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the information</param> 
        /// <returns></returns>            
        public void OrderGetChargeableInformation (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderGetChargeableInformation");
            
    
            var path = "/Order/{id}/getChargeableInformation";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetChargeableInformation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetChargeableInformation: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get total net, gross and tax amount of order Calls getChargeableSums() in Order.php to get the total net, gross and tax amount of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the total net, gross and tax amount</param> 
        /// <returns></returns>            
        public void OrderGetChargeableSums (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderGetChargeableSums");
            
    
            var path = "/Order/{id}/getChargeableSums";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetChargeableSums: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetChargeableSums: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get main order by checking if there are existing order logs of the specified order Calls getMainOrderByLogs() in Order.php to get main order by checking if there are existing order logs of the specified order.    If the specified order is not the main order (eg. if there are no existing logs), this will return null!
        /// </summary>
        /// <param name="id">Id of the order of which you want to know if it is the main order</param> 
        /// <returns>ModelOrder</returns>            
        public ModelOrder OrderGetMainOrderByLogs (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderGetMainOrderByLogs");
            
    
            var path = "/Order/{id}/getMainOrderByLogs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetMainOrderByLogs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetMainOrderByLogs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelOrder) ApiClient.Deserialize(response.Content, typeof(ModelOrder), response.Headers);
        }
    
        /// <summary>
        /// Get the order as a pdf Calls getPdf() in Order.php
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the pdf</param> 
        /// <param name="preventSendBy">Define if you want to prevent to send the order via pdf</param> 
        /// <returns></returns>            
        public void OrderGetPdf (int? id, bool? preventSendBy)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderGetPdf");
            
    
            var path = "/Order/{id}/getPdf";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (preventSendBy != null) queryParams.Add("preventSendBy", ApiClient.ParameterToString(preventSendBy)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetPdf: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetPdf: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get all order positions Calls getPositions() in Order.php to get necessary variables
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the positions</param> 
        /// <param name="withOptional">Define if you want optional order positions</param> 
        /// <param name="onlyChargeable">Define if you want only chargeable order positions</param> 
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned order positions start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelOrderPos</returns>            
        public ModelOrderPos OrderGetPositions (int? id, bool? withOptional, bool? onlyChargeable, int? limit, int? offset, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderGetPositions");
            
    
            var path = "/Order/{id}/getPositions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (withOptional != null) queryParams.Add("withOptional", ApiClient.ParameterToString(withOptional)); // query parameter
 if (onlyChargeable != null) queryParams.Add("onlyChargeable", ApiClient.ParameterToString(onlyChargeable)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (embed != null) queryParams.Add("embed", ApiClient.ParameterToString(embed)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetPositions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetPositions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelOrderPos) ApiClient.Deserialize(response.Content, typeof(ModelOrderPos), response.Headers);
        }
    
        /// <summary>
        /// Get related objects of a specified order Calls getRelatedObjects() in Order.php to get related objects of the order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the related objects</param> 
        /// <param name="includeItself">Define if the related objects include the order itself</param> 
        /// <param name="sortByType">Define if you want the related objects sorted by type</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns></returns>            
        public void OrderGetRelatedObjects (int? id, bool? includeItself, bool? sortByType, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderGetRelatedObjects");
            
    
            var path = "/Order/{id}/getRelatedObjects";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeItself != null) queryParams.Add("includeItself", ApiClient.ParameterToString(includeItself)); // query parameter
 if (sortByType != null) queryParams.Add("sortByType", ApiClient.ParameterToString(sortByType)); // query parameter
 if (embed != null) queryParams.Add("embed", ApiClient.ParameterToString(embed)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetRelatedObjects: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetRelatedObjects: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get tags of the specified order Calls getTags() in Order.php to get the tags of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the tags</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns></returns>            
        public void OrderGetTags (int? id, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderGetTags");
            
    
            var path = "/Order/{id}/getTags";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetTags: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetTags: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get sum tax of the specified order Calls getTax() in Order.php to get the sum tax of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the sum tax</param> 
        /// <param name="foreignCurrency">Specify if a foreign currency is used</param> 
        /// <returns></returns>            
        public void OrderGetTax (int? id, bool? foreignCurrency)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderGetTax");
            
    
            var path = "/Order/{id}/getTax";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (foreignCurrency != null) queryParams.Add("foreignCurrency", ApiClient.ParameterToString(foreignCurrency)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetTax: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetTax: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get tax groups of the specified order Calls getTaxGroupes() in Order.php to get the tax groups of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the tax groups</param> 
        /// <returns></returns>            
        public void OrderGetTaxGroupes (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderGetTaxGroupes");
            
    
            var path = "/Order/{id}/getTaxGroupes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetTaxGroupes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetTaxGroupes: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get sum gross of the specified order Calls getTotal() in Order.php to get the sum gross of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the sum gross</param> 
        /// <param name="foreignCurrency">Specify if a foreign currency is used</param> 
        /// <returns></returns>            
        public void OrderGetTotal (int? id, bool? foreignCurrency)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderGetTotal");
            
    
            var path = "/Order/{id}/getTotal";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (foreignCurrency != null) queryParams.Add("foreignCurrency", ApiClient.ParameterToString(foreignCurrency)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetTotal: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetTotal: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get total gross amount of order Calls getTotalCalc() in Order.php to get the total gross amount of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the total gross amount</param> 
        /// <returns></returns>            
        public void OrderGetTotalCalc (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderGetTotalCalc");
            
    
            var path = "/Order/{id}/getTotalCalc";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetTotalCalc: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetTotalCalc: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get total net amount of order Calls getTotalNet() in Order.php to get the total net amount of the specified order
        /// </summary>
        /// <param name="id">Id of the order of which you want to get the total net amount</param> 
        /// <returns></returns>            
        public void OrderGetTotalNet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderGetTotalNet");
            
    
            var path = "/Order/{id}/getTotalNet";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetTotalNet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderGetTotalNet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Render the order document on doc server and return the metadata Calls render() in Order.php to render an order document on doc server and return the metadata
        /// </summary>
        /// <param name="id">Id of order you want to render</param> 
        /// <returns></returns>            
        public void OrderRender (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderRender");
            
    
            var path = "/Order/{id}/render";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrderRender: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderRender: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send an order by the desired send type Calls sendBy() in Order.php to send the order by the desired send type
        /// </summary>
        /// <param name="id">Id of order which you want to send</param> 
        /// <param name="sendType">Your desired send type. Available are: VM &#x3D; Mail, VP &#x3D; Post, VPDF &#x3D; PDF, PRN &#x3D; Print</param> 
        /// <returns>ModelOrder</returns>            
        public ModelOrder OrderSendBy (int? id, string sendType)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderSendBy");
            
    
            var path = "/Order/{id}/sendBy";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (sendType != null) queryParams.Add("sendType", ApiClient.ParameterToString(sendType)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderSendBy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderSendBy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelOrder) ApiClient.Deserialize(response.Content, typeof(ModelOrder), response.Headers);
        }
    
        /// <summary>
        /// Send an order via Email Calls sendViaEmail in Order.php
        /// </summary>
        /// <param name="id">Id of order you want to send via Email</param> 
        /// <param name="body">Change the desired values after the parameters and remove the quotation marks. You can also add &#39;additionalAttachments&#39;, &#39;ccEmail&#x3D;&#39; and &#39;bccEmail&#39;    Please note: additionalAttachments is a String containing document id&#39;s (of existing documents!)</param> 
        /// <returns>ModelEmail</returns>            
        public ModelEmail SendOrderViaEmail (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SendOrderViaEmail");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SendOrderViaEmail");
            
    
            var path = "/Order/{id}/sendViaEmail";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SendOrderViaEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendOrderViaEmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelEmail) ApiClient.Deserialize(response.Content, typeof(ModelEmail), response.Headers);
        }
    
        /// <summary>
        /// Send an order via post Calls sendViaPost() in Order.php
        /// </summary>
        /// <param name="id">Id of order you want to send via post</param> 
        /// <returns>ModelOrder</returns>            
        public ModelOrder SendOrderViaPost (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SendOrderViaPost");
            
    
            var path = "/Order/{id}/sendViaPost";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SendOrderViaPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendOrderViaPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelOrder) ApiClient.Deserialize(response.Content, typeof(ModelOrder), response.Headers);
        }
    
        /// <summary>
        /// Update an existing order Calls Order.php
        /// </summary>
        /// <param name="id">id of order you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param> 
        /// <returns>ModelOrder</returns>            
        public ModelOrder UpdateOrder (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateOrder");
            
    
            var path = "/Order/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrder: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelOrder) ApiClient.Deserialize(response.Content, typeof(ModelOrder), response.Headers);
        }
    
    }
}
