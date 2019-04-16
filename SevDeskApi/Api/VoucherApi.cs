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
    public interface IVoucherApi
    {
        /// <summary>
        /// Create a new voucher Calls Voucher.php to create a voucher
        /// </summary>
        /// <param name="body">To create a voucher, simply enter desired values after parameter&#x3D; and remove the quotation marks.      Be aware that you can&#39;t use all the parameters included in the Model_Voucher, as creating a voucher involves other functions.      So for example, adding a sumNet/Gross/etc. does not work as they normally get their value from the product which is involved in the voucher      The product/part in this case is handled in the Model_VoucherPos which makes a call to Model_Part.</param>
        /// <returns>ModelVoucher</returns>
        ModelVoucher AddVoucher (string body);
        /// <summary>
        /// Delete an existing voucher Calls the delete() function in Voucher.php
        /// </summary>
        /// <param name="id">Id of voucher you want to delete</param>
        /// <returns></returns>
        void DeleteVoucher (int? id);
        /// <summary>
        /// Get an overview of all vouchers Calls Voucher.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned vouchers start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelVoucher</returns>
        ModelVoucher GetVouchers (int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Create a new voucher With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new voucher it wont be saved by a POST request with &#39;/Voucher?para1&#x3D;&amp;...&#39; but with the saveVoucher function in Factory.php &#39;Voucher/Factory/saveVoucher?para1&#x3D;&#39;
        /// </summary>
        /// <param name="body">The saveVoucher function in Voucher/Factory.php combines both Voucher and VoucherPos with all their HTTP-methods.    It is now possible to **simultaneously** create a voucher with its position.    To simply (only) create a voucher you can use the given parameters and concatenate your values.    For also adding a voucher position refer to the **quick reference** below.    The parameters you find there are **needed** for creating a voucher position. Just concatenate them to the existing voucher parameters.    You can also find additional (optional) parameters in the **Models** section.    Quick reference:  * &amp;voucherPosSave[0][accountingType][id]&#x3D;  * &amp;voucherPosSave[0][accountingType][objectName]&#x3D;AccountingType  * &amp;voucherPosSave[0][taxRate]&#x3D;19  * &amp;voucherPosSave[0][sum]&#x3D;  * &amp;voucherPosSave[0][objectName]&#x3D;VoucherPos  * &amp;voucherPosSave[0][mapAll]&#x3D;true  * &amp;voucherPosDelete&#x3D;true/false &lt;- - if you provide this parameter, you can delete a voucher position    You can also use additional parameters for creating a voucher in the same way by adding them in the format: **voucher[yourParameter]** </param>
        /// <returns>ModelVoucherFactory</returns>
        ModelVoucherFactory SaveVoucher (string body);
        /// <summary>
        /// Update an existing voucher Calls Voucher.php to update an existing voucher
        /// </summary>
        /// <param name="id">Id of the voucher you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create invoice.      Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param>
        /// <returns>ModelVoucher</returns>
        ModelVoucher UpdateVoucher (int? id, string body);
        /// <summary>
        /// Book an amount for a specified voucher Book an amount for the specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher for which you want to book an amount</param>
        /// <param name="body">To book an amount for your voucher, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns></returns>
        void VoucherBookAmount (int? id, string body);
        /// <summary>
        /// Change status of a specified voucher Change the status of the specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to change the status</param>
        /// <param name="body">To change the status of your voucher, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param>
        /// <returns></returns>
        void VoucherChangeStatus (int? id, string body);
        /// <summary>
        /// Delete the document of an existing voucher Calls the deleteDocument() function in Voucher.php to delete the document of an existing voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to delete the document</param>
        /// <returns></returns>
        void VoucherDeleteDocument (int? id);
        /// <summary>
        /// Extract file thumb Calls extractThumb() in Voucher/Factory.php to extract the thumb of the specified file
        /// </summary>
        /// <param name="fileName">Name of the file of which you want to extract the thumb</param>
        /// <returns></returns>
        void VoucherExtractThumb (string fileName);
        /// <summary>
        /// Get the accounting types of a specified voucher Calls getAccountingTypes() in Voucher.php to get the accounting types of the specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to get the accounting types</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelAccountingType</returns>
        ModelAccountingType VoucherGetAccountingTypes (int? id, List<string> embed);
        /// <summary>
        /// Get the check account transaction logs of a specified voucher Calls getCheckAccountTransactionLogs() in Voucher.php to get the check account transaction logs of the specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to get the check account transaction logs</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns></returns>
        void VoucherGetCheckAccountTransactionLogs (int? id, List<string> embed);
        /// <summary>
        /// Get the check account transactions of a specified voucher Calls getCheckAccountTransactions() in Voucher.php to get the check account transactions of the specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to get the check account transactions</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns></returns>
        void VoucherGetCheckAccountTransactions (int? id, List<string> embed);
        /// <summary>
        /// Get the currency of a specified voucher Calls getCurrency() in Voucher.php to get the currency of the specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to get the currency</param>
        /// <returns></returns>
        void VoucherGetCurrency (int? id);
        /// <summary>
        /// Get unpaid amount of a specified voucher Calls getDebit() in Voucher.php to get the unpaid amount of a specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to get the unpaid amount</param>
        /// <returns></returns>
        void VoucherGetDebit (int? id);
        /// <summary>
        /// Return if the voucher is delinquent Calls getDelinquent() in Voucher.php to get if the voucher is delinquent
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to know if it is delinquent</param>
        /// <returns></returns>
        void VoucherGetDelinquent (int? id);
        /// <summary>
        /// Get the depending recurring vouchers of a specified origin voucher Calls getDependingRecurringVouchers() in Voucher.php to get the depending recurring vouchers of the specified origin voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to get the depending recurring vouchers</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelVoucher</returns>
        ModelVoucher VoucherGetDependingRecurringVouchers (int? id, List<string> embed);
        /// <summary>
        /// Returns the base64 encoded preview content of the vouchers document Calls getDocumentImage() in Voucher.php to return the base64 encoded preview content of the vouchers document
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to get the document image</param>
        /// <returns></returns>
        void VoucherGetDocumentImage (int? id);
        /// <summary>
        /// Get an overview of all vouchers Calls Voucher.php to get necessary variables.
        /// </summary>
        /// <param name="id">Id of the voucher you want to update</param>
        /// <param name="showTotalSum">Define if you want to have the total sum of each tax group</param>
        /// <param name="withCorrections">Define if you want to have the total sum with corrections</param>
        /// <returns></returns>
        void VoucherGetTaxGroups (int? id, bool? showTotalSum, bool? withCorrections);
        /// <summary>
        /// Mark a specified voucher as open Mark the specified voucher as open
        /// </summary>
        /// <param name="id">Id of the voucher you want to mark as open</param>
        /// <returns>ModelVoucher</returns>
        ModelVoucher VoucherMarkAsOpen (int? id);
        /// <summary>
        /// Mark a specified voucher as paid Mark the specified voucher as paid
        /// </summary>
        /// <param name="id">Id of the voucher you want to mark as paid</param>
        /// <param name="body">Enter the date the voucher was paid here, using the format DD.MM.YYYY!</param>
        /// <returns>ModelVoucher</returns>
        ModelVoucher VoucherMarkAsPaid (int? id, string body);
        /// <summary>
        /// Refund an amount for a specified voucher Refund an amount for the specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher for which you want to refund an amount</param>
        /// <param name="body">Enter the amount which should be refunded, the date of the refund (format DD.MM.YYYY) and if it should appear in the feed an remove the quotation marks!</param>
        /// <returns>ModelVoucherLog</returns>
        ModelVoucherLog VoucherRefundAmount (int? id, string body);
        /// <summary>
        /// Upload a temporary file to be used later With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new voucher it wont be saved by a POST request with &#39;/Voucher?para1&#x3D;&amp;...&#39; but with the saveVoucher function in Factory.php &#39;Voucher/Factory/saveVoucher?para1&#x3D;&#39;
        /// </summary>
        /// <param name="file">file to upload</param>
        /// <returns>ModelVoucherFactory</returns>
        ModelVoucherFactory VoucherUploadTempFile (System.IO.Stream file);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VoucherApi : IVoucherApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VoucherApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VoucherApi(String basePath)
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
        /// Create a new voucher Calls Voucher.php to create a voucher
        /// </summary>
        /// <param name="body">To create a voucher, simply enter desired values after parameter&#x3D; and remove the quotation marks.      Be aware that you can&#39;t use all the parameters included in the Model_Voucher, as creating a voucher involves other functions.      So for example, adding a sumNet/Gross/etc. does not work as they normally get their value from the product which is involved in the voucher      The product/part in this case is handled in the Model_VoucherPos which makes a call to Model_Part.</param> 
        /// <returns>ModelVoucher</returns>            
        public ModelVoucher AddVoucher (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddVoucher");
            
    
            var path = "/Voucher";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddVoucher: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddVoucher: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucher) ApiClient.Deserialize(response.Content, typeof(ModelVoucher), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing voucher Calls the delete() function in Voucher.php
        /// </summary>
        /// <param name="id">Id of voucher you want to delete</param> 
        /// <returns></returns>            
        public void DeleteVoucher (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteVoucher");
            
    
            var path = "/Voucher/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVoucher: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVoucher: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all vouchers Calls Voucher.php to get necessary variables.
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned vouchers start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelVoucher</returns>            
        public ModelVoucher GetVouchers (int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/Voucher";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetVouchers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVouchers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucher) ApiClient.Deserialize(response.Content, typeof(ModelVoucher), response.Headers);
        }
    
        /// <summary>
        /// Create a new voucher With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new voucher it wont be saved by a POST request with &#39;/Voucher?para1&#x3D;&amp;...&#39; but with the saveVoucher function in Factory.php &#39;Voucher/Factory/saveVoucher?para1&#x3D;&#39;
        /// </summary>
        /// <param name="body">The saveVoucher function in Voucher/Factory.php combines both Voucher and VoucherPos with all their HTTP-methods.    It is now possible to **simultaneously** create a voucher with its position.    To simply (only) create a voucher you can use the given parameters and concatenate your values.    For also adding a voucher position refer to the **quick reference** below.    The parameters you find there are **needed** for creating a voucher position. Just concatenate them to the existing voucher parameters.    You can also find additional (optional) parameters in the **Models** section.    Quick reference:  * &amp;voucherPosSave[0][accountingType][id]&#x3D;  * &amp;voucherPosSave[0][accountingType][objectName]&#x3D;AccountingType  * &amp;voucherPosSave[0][taxRate]&#x3D;19  * &amp;voucherPosSave[0][sum]&#x3D;  * &amp;voucherPosSave[0][objectName]&#x3D;VoucherPos  * &amp;voucherPosSave[0][mapAll]&#x3D;true  * &amp;voucherPosDelete&#x3D;true/false &lt;- - if you provide this parameter, you can delete a voucher position    You can also use additional parameters for creating a voucher in the same way by adding them in the format: **voucher[yourParameter]** </param> 
        /// <returns>ModelVoucherFactory</returns>            
        public ModelVoucherFactory SaveVoucher (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SaveVoucher");
            
    
            var path = "/Voucher/Factory/saveVoucher";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SaveVoucher: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SaveVoucher: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucherFactory) ApiClient.Deserialize(response.Content, typeof(ModelVoucherFactory), response.Headers);
        }
    
        /// <summary>
        /// Update an existing voucher Calls Voucher.php to update an existing voucher
        /// </summary>
        /// <param name="id">Id of the voucher you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create invoice.      Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelVoucher</returns>            
        public ModelVoucher UpdateVoucher (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateVoucher");
            
    
            var path = "/Voucher/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVoucher: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVoucher: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucher) ApiClient.Deserialize(response.Content, typeof(ModelVoucher), response.Headers);
        }
    
        /// <summary>
        /// Book an amount for a specified voucher Book an amount for the specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher for which you want to book an amount</param> 
        /// <param name="body">To book an amount for your voucher, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns></returns>            
        public void VoucherBookAmount (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherBookAmount");
            
    
            var path = "/Voucher/{id}/bookAmmount";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherBookAmount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherBookAmount: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Change status of a specified voucher Change the status of the specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to change the status</param> 
        /// <param name="body">To change the status of your voucher, simply enter desired values after parameter&#x3D; and remove the quotation marks.</param> 
        /// <returns></returns>            
        public void VoucherChangeStatus (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherChangeStatus");
            
    
            var path = "/Voucher/{id}/changeStatus";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherChangeStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherChangeStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete the document of an existing voucher Calls the deleteDocument() function in Voucher.php to delete the document of an existing voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to delete the document</param> 
        /// <returns></returns>            
        public void VoucherDeleteDocument (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherDeleteDocument");
            
    
            var path = "/Voucher/{id}/deleteDocument";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherDeleteDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherDeleteDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Extract file thumb Calls extractThumb() in Voucher/Factory.php to extract the thumb of the specified file
        /// </summary>
        /// <param name="fileName">Name of the file of which you want to extract the thumb</param> 
        /// <returns></returns>            
        public void VoucherExtractThumb (string fileName)
        {
            
    
            var path = "/Voucher/Factory/extractThumb";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fileName != null) queryParams.Add("fileName", ApiClient.ParameterToString(fileName)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherExtractThumb: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherExtractThumb: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the accounting types of a specified voucher Calls getAccountingTypes() in Voucher.php to get the accounting types of the specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to get the accounting types</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelAccountingType</returns>            
        public ModelAccountingType VoucherGetAccountingTypes (int? id, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherGetAccountingTypes");
            
    
            var path = "/Voucher/{id}/getAccountingTypes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetAccountingTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetAccountingTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAccountingType) ApiClient.Deserialize(response.Content, typeof(ModelAccountingType), response.Headers);
        }
    
        /// <summary>
        /// Get the check account transaction logs of a specified voucher Calls getCheckAccountTransactionLogs() in Voucher.php to get the check account transaction logs of the specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to get the check account transaction logs</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns></returns>            
        public void VoucherGetCheckAccountTransactionLogs (int? id, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherGetCheckAccountTransactionLogs");
            
    
            var path = "/Voucher/{id}/getCheckAccountTransactionLogs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetCheckAccountTransactionLogs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetCheckAccountTransactionLogs: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the check account transactions of a specified voucher Calls getCheckAccountTransactions() in Voucher.php to get the check account transactions of the specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to get the check account transactions</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns></returns>            
        public void VoucherGetCheckAccountTransactions (int? id, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherGetCheckAccountTransactions");
            
    
            var path = "/Voucher/{id}/getCheckAccountTransactions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetCheckAccountTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetCheckAccountTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the currency of a specified voucher Calls getCurrency() in Voucher.php to get the currency of the specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to get the currency</param> 
        /// <returns></returns>            
        public void VoucherGetCurrency (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherGetCurrency");
            
    
            var path = "/Voucher/{id}/getCurrency";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetCurrency: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetCurrency: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get unpaid amount of a specified voucher Calls getDebit() in Voucher.php to get the unpaid amount of a specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to get the unpaid amount</param> 
        /// <returns></returns>            
        public void VoucherGetDebit (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherGetDebit");
            
    
            var path = "/Voucher/{id}/getDebit";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetDebit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetDebit: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Return if the voucher is delinquent Calls getDelinquent() in Voucher.php to get if the voucher is delinquent
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to know if it is delinquent</param> 
        /// <returns></returns>            
        public void VoucherGetDelinquent (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherGetDelinquent");
            
    
            var path = "/Voucher/{id}/getDelinquent";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetDelinquent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetDelinquent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the depending recurring vouchers of a specified origin voucher Calls getDependingRecurringVouchers() in Voucher.php to get the depending recurring vouchers of the specified origin voucher
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to get the depending recurring vouchers</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelVoucher</returns>            
        public ModelVoucher VoucherGetDependingRecurringVouchers (int? id, List<string> embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherGetDependingRecurringVouchers");
            
    
            var path = "/Voucher/{id}/getDependingRecurringVouchers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetDependingRecurringVouchers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetDependingRecurringVouchers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucher) ApiClient.Deserialize(response.Content, typeof(ModelVoucher), response.Headers);
        }
    
        /// <summary>
        /// Returns the base64 encoded preview content of the vouchers document Calls getDocumentImage() in Voucher.php to return the base64 encoded preview content of the vouchers document
        /// </summary>
        /// <param name="id">Id of the voucher of which you want to get the document image</param> 
        /// <returns></returns>            
        public void VoucherGetDocumentImage (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherGetDocumentImage");
            
    
            var path = "/Voucher/{id}/getDocumentImage";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetDocumentImage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetDocumentImage: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all vouchers Calls Voucher.php to get necessary variables.
        /// </summary>
        /// <param name="id">Id of the voucher you want to update</param> 
        /// <param name="showTotalSum">Define if you want to have the total sum of each tax group</param> 
        /// <param name="withCorrections">Define if you want to have the total sum with corrections</param> 
        /// <returns></returns>            
        public void VoucherGetTaxGroups (int? id, bool? showTotalSum, bool? withCorrections)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherGetTaxGroups");
            
            // verify the required parameter 'showTotalSum' is set
            if (showTotalSum == null) throw new ApiException(400, "Missing required parameter 'showTotalSum' when calling VoucherGetTaxGroups");
            
            // verify the required parameter 'withCorrections' is set
            if (withCorrections == null) throw new ApiException(400, "Missing required parameter 'withCorrections' when calling VoucherGetTaxGroups");
            
    
            var path = "/Voucher/{id}/getTaxGroupes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (showTotalSum != null) queryParams.Add("showTotalSum", ApiClient.ParameterToString(showTotalSum)); // query parameter
 if (withCorrections != null) queryParams.Add("withCorrections", ApiClient.ParameterToString(withCorrections)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetTaxGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherGetTaxGroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Mark a specified voucher as open Mark the specified voucher as open
        /// </summary>
        /// <param name="id">Id of the voucher you want to mark as open</param> 
        /// <returns>ModelVoucher</returns>            
        public ModelVoucher VoucherMarkAsOpen (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherMarkAsOpen");
            
    
            var path = "/Voucher/{id}/markAsOpen";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherMarkAsOpen: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherMarkAsOpen: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucher) ApiClient.Deserialize(response.Content, typeof(ModelVoucher), response.Headers);
        }
    
        /// <summary>
        /// Mark a specified voucher as paid Mark the specified voucher as paid
        /// </summary>
        /// <param name="id">Id of the voucher you want to mark as paid</param> 
        /// <param name="body">Enter the date the voucher was paid here, using the format DD.MM.YYYY!</param> 
        /// <returns>ModelVoucher</returns>            
        public ModelVoucher VoucherMarkAsPaid (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherMarkAsPaid");
            
    
            var path = "/Voucher/{id}/markAsPaid";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherMarkAsPaid: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherMarkAsPaid: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucher) ApiClient.Deserialize(response.Content, typeof(ModelVoucher), response.Headers);
        }
    
        /// <summary>
        /// Refund an amount for a specified voucher Refund an amount for the specified voucher
        /// </summary>
        /// <param name="id">Id of the voucher for which you want to refund an amount</param> 
        /// <param name="body">Enter the amount which should be refunded, the date of the refund (format DD.MM.YYYY) and if it should appear in the feed an remove the quotation marks!</param> 
        /// <returns>ModelVoucherLog</returns>            
        public ModelVoucherLog VoucherRefundAmount (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VoucherRefundAmount");
            
    
            var path = "/Voucher/{id}/refundAmmount";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherRefundAmount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherRefundAmount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucherLog) ApiClient.Deserialize(response.Content, typeof(ModelVoucherLog), response.Headers);
        }
    
        /// <summary>
        /// Upload a temporary file to be used later With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new voucher it wont be saved by a POST request with &#39;/Voucher?para1&#x3D;&amp;...&#39; but with the saveVoucher function in Factory.php &#39;Voucher/Factory/saveVoucher?para1&#x3D;&#39;
        /// </summary>
        /// <param name="file">file to upload</param> 
        /// <returns>ModelVoucherFactory</returns>            
        public ModelVoucherFactory VoucherUploadTempFile (System.IO.Stream file)
        {
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling VoucherUploadTempFile");
            
    
            var path = "/Voucher/Factory/uploadTempFile";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherUploadTempFile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VoucherUploadTempFile: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelVoucherFactory) ApiClient.Deserialize(response.Content, typeof(ModelVoucherFactory), response.Headers);
        }
    
    }
}
