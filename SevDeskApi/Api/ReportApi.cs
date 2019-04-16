using System;
using System.Collections.Generic;
using RestSharp;
using SevDeskApi.Client;

namespace SevDeskApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportApi
    {
        /// <summary>
        /// Export the contact Calls contact() in Report.php to export the contact.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <param name="contactId">Id of contact which should be exported</param>
        /// <param name="contactObjectName">Model name which is exported</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ReportContact (bool? download, int? contactId, string contactObjectName);
        /// <summary>
        /// Export the contact list Calls contactlist() in Report.php to export the contact list.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param>
        /// <param name="sevQueryObjectName">SevQuery object name</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <param name="sevQueryLimit">Limit exported contacts</param>
        /// <param name="sevQueryOffset">Set the index where the exported contacts start</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ReportContactList (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset);
        /// <summary>
        /// Export the inventory Calls inventory() in Report.php to export the inventory.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param>
        /// <param name="sevQueryObjectName">SevQuery object name</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <param name="sevQueryLimit">Limit exported inventory entries</param>
        /// <param name="sevQueryOffset">Set the index where the exported parts start</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ReportInventory (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset);
        /// <summary>
        /// Export the invoicelist Calls invoicelist() in Report.php to export the invoices.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param>
        /// <param name="sevQueryObjectName">SevQuery object name</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <param name="sevQueryLimit">Limit exported invoices</param>
        /// <param name="sevQueryOffset">Set the index where the exported invoices should start</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ReportInvoiceList (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset);
        /// <summary>
        /// Export the order list Calls orderlist() in Report.php to export the orders.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param>
        /// <param name="sevQueryObjectName">SevQuery object name</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <param name="sevQueryLimit">Limit exported orders</param>
        /// <param name="sevQueryOffset">Set the index where the exported orders should start</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ReportOrderList (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset);
        /// <summary>
        /// Export the profit and loss Calls profitAndLoss() in Report.php to export the profit and loss.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="startDate">Start date of the profit and loss calculation</param>
        /// <param name="endDate">End date of the profit and loss calculation</param>
        /// <param name="taxRule">Specify if you want the net income method or the profit and loss</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ReportProfitAndLoss (string startDate, string endDate, bool? taxRule, bool? download);
        /// <summary>
        /// Export the register book / cash report Calls registerBook() in Report.php to export the register book / cash report.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="checkAccountId">Check account you want to export</param>
        /// <param name="checkAccountObjectName">Check account object name</param>
        /// <param name="startDate">Start date of the register book / cash report</param>
        /// <param name="endDate">End date of the register book / cash report</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ReportRegisterBook (int? checkAccountId, string checkAccountObjectName, string startDate, string endDate, bool? download);
        /// <summary>
        /// Export the voucher list Calls voucherlist() in Report.php to export the vouchers.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryFilterStartDate">Start date to filter vouchers with</param>
        /// <param name="sevQueryModelName">Model name which is exported</param>
        /// <param name="sevQueryObjectName">SevQuery object name</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <param name="sevQueryLimit">Limit exported vouchers</param>
        /// <param name="sevQueryOffset">Set the index where the exported vouchers should start</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ReportVoucherList (string sevQueryFilterStartDate, string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportApi : IReportApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportApi(String basePath)
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
        /// Export the contact Calls contact() in Report.php to export the contact.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <param name="contactId">Id of contact which should be exported</param> 
        /// <param name="contactObjectName">Model name which is exported</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ReportContact (bool? download, int? contactId, string contactObjectName)
        {
            
            // verify the required parameter 'download' is set
            if (download == null) throw new ApiException(400, "Missing required parameter 'download' when calling ReportContact");
            
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling ReportContact");
            
            // verify the required parameter 'contactObjectName' is set
            if (contactObjectName == null) throw new ApiException(400, "Missing required parameter 'contactObjectName' when calling ReportContact");
            
    
            var path = "/Report/contact";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
 if (contactId != null) queryParams.Add("contact[id]", ApiClient.ParameterToString(contactId)); // query parameter
 if (contactObjectName != null) queryParams.Add("contact[objectName]", ApiClient.ParameterToString(contactObjectName)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportContact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportContact: " + response.ErrorMessage, response.ErrorMessage);
    
            return (System.IO.Stream) ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }
    
        /// <summary>
        /// Export the contact list Calls contactlist() in Report.php to export the contact list.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param> 
        /// <param name="sevQueryObjectName">SevQuery object name</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <param name="sevQueryLimit">Limit exported contacts</param> 
        /// <param name="sevQueryOffset">Set the index where the exported contacts start</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ReportContactList (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset)
        {
            
            // verify the required parameter 'sevQueryModelName' is set
            if (sevQueryModelName == null) throw new ApiException(400, "Missing required parameter 'sevQueryModelName' when calling ReportContactList");
            
            // verify the required parameter 'sevQueryObjectName' is set
            if (sevQueryObjectName == null) throw new ApiException(400, "Missing required parameter 'sevQueryObjectName' when calling ReportContactList");
            
    
            var path = "/Report/contactlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
 if (sevQueryLimit != null) queryParams.Add("sevQuery[limit]", ApiClient.ParameterToString(sevQueryLimit)); // query parameter
 if (sevQueryOffset != null) queryParams.Add("sevQuery[offset]", ApiClient.ParameterToString(sevQueryOffset)); // query parameter
 if (sevQueryModelName != null) queryParams.Add("sevQuery[modelName]", ApiClient.ParameterToString(sevQueryModelName)); // query parameter
 if (sevQueryObjectName != null) queryParams.Add("sevQuery[objectName]", ApiClient.ParameterToString(sevQueryObjectName)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportContactList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportContactList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (System.IO.Stream) ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }
    
        /// <summary>
        /// Export the inventory Calls inventory() in Report.php to export the inventory.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param> 
        /// <param name="sevQueryObjectName">SevQuery object name</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <param name="sevQueryLimit">Limit exported inventory entries</param> 
        /// <param name="sevQueryOffset">Set the index where the exported parts start</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ReportInventory (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset)
        {
            
            // verify the required parameter 'sevQueryModelName' is set
            if (sevQueryModelName == null) throw new ApiException(400, "Missing required parameter 'sevQueryModelName' when calling ReportInventory");
            
            // verify the required parameter 'sevQueryObjectName' is set
            if (sevQueryObjectName == null) throw new ApiException(400, "Missing required parameter 'sevQueryObjectName' when calling ReportInventory");
            
    
            var path = "/Report/inventory";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
 if (sevQueryLimit != null) queryParams.Add("sevQuery[limit]", ApiClient.ParameterToString(sevQueryLimit)); // query parameter
 if (sevQueryOffset != null) queryParams.Add("sevQuery[offset]", ApiClient.ParameterToString(sevQueryOffset)); // query parameter
 if (sevQueryModelName != null) queryParams.Add("sevQuery[modelName]", ApiClient.ParameterToString(sevQueryModelName)); // query parameter
 if (sevQueryObjectName != null) queryParams.Add("sevQuery[objectName]", ApiClient.ParameterToString(sevQueryObjectName)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportInventory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportInventory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (System.IO.Stream) ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }
    
        /// <summary>
        /// Export the invoicelist Calls invoicelist() in Report.php to export the invoices.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param> 
        /// <param name="sevQueryObjectName">SevQuery object name</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <param name="sevQueryLimit">Limit exported invoices</param> 
        /// <param name="sevQueryOffset">Set the index where the exported invoices should start</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ReportInvoiceList (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset)
        {
            
            // verify the required parameter 'sevQueryModelName' is set
            if (sevQueryModelName == null) throw new ApiException(400, "Missing required parameter 'sevQueryModelName' when calling ReportInvoiceList");
            
            // verify the required parameter 'sevQueryObjectName' is set
            if (sevQueryObjectName == null) throw new ApiException(400, "Missing required parameter 'sevQueryObjectName' when calling ReportInvoiceList");
            
    
            var path = "/Report/invoicelist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
 if (sevQueryLimit != null) queryParams.Add("sevQuery[limit]", ApiClient.ParameterToString(sevQueryLimit)); // query parameter
 if (sevQueryOffset != null) queryParams.Add("sevQuery[offset]", ApiClient.ParameterToString(sevQueryOffset)); // query parameter
 if (sevQueryModelName != null) queryParams.Add("sevQuery[modelName]", ApiClient.ParameterToString(sevQueryModelName)); // query parameter
 if (sevQueryObjectName != null) queryParams.Add("sevQuery[objectName]", ApiClient.ParameterToString(sevQueryObjectName)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportInvoiceList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportInvoiceList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (System.IO.Stream) ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }
    
        /// <summary>
        /// Export the order list Calls orderlist() in Report.php to export the orders.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param> 
        /// <param name="sevQueryObjectName">SevQuery object name</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <param name="sevQueryLimit">Limit exported orders</param> 
        /// <param name="sevQueryOffset">Set the index where the exported orders should start</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ReportOrderList (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset)
        {
            
            // verify the required parameter 'sevQueryModelName' is set
            if (sevQueryModelName == null) throw new ApiException(400, "Missing required parameter 'sevQueryModelName' when calling ReportOrderList");
            
            // verify the required parameter 'sevQueryObjectName' is set
            if (sevQueryObjectName == null) throw new ApiException(400, "Missing required parameter 'sevQueryObjectName' when calling ReportOrderList");
            
    
            var path = "/Report/orderlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
 if (sevQueryLimit != null) queryParams.Add("sevQuery[limit]", ApiClient.ParameterToString(sevQueryLimit)); // query parameter
 if (sevQueryOffset != null) queryParams.Add("sevQuery[offset]", ApiClient.ParameterToString(sevQueryOffset)); // query parameter
 if (sevQueryModelName != null) queryParams.Add("sevQuery[modelName]", ApiClient.ParameterToString(sevQueryModelName)); // query parameter
 if (sevQueryObjectName != null) queryParams.Add("sevQuery[objectName]", ApiClient.ParameterToString(sevQueryObjectName)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportOrderList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportOrderList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (System.IO.Stream) ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }
    
        /// <summary>
        /// Export the profit and loss Calls profitAndLoss() in Report.php to export the profit and loss.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="startDate">Start date of the profit and loss calculation</param> 
        /// <param name="endDate">End date of the profit and loss calculation</param> 
        /// <param name="taxRule">Specify if you want the net income method or the profit and loss</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ReportProfitAndLoss (string startDate, string endDate, bool? taxRule, bool? download)
        {
            
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling ReportProfitAndLoss");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling ReportProfitAndLoss");
            
            // verify the required parameter 'taxRule' is set
            if (taxRule == null) throw new ApiException(400, "Missing required parameter 'taxRule' when calling ReportProfitAndLoss");
            
    
            var path = "/Report/profitAndLoss";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
 if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (taxRule != null) queryParams.Add("taxRule", ApiClient.ParameterToString(taxRule)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportProfitAndLoss: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportProfitAndLoss: " + response.ErrorMessage, response.ErrorMessage);
    
            return (System.IO.Stream) ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }
    
        /// <summary>
        /// Export the register book / cash report Calls registerBook() in Report.php to export the register book / cash report.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="checkAccountId">Check account you want to export</param> 
        /// <param name="checkAccountObjectName">Check account object name</param> 
        /// <param name="startDate">Start date of the register book / cash report</param> 
        /// <param name="endDate">End date of the register book / cash report</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ReportRegisterBook (int? checkAccountId, string checkAccountObjectName, string startDate, string endDate, bool? download)
        {
            
            // verify the required parameter 'checkAccountId' is set
            if (checkAccountId == null) throw new ApiException(400, "Missing required parameter 'checkAccountId' when calling ReportRegisterBook");
            
            // verify the required parameter 'checkAccountObjectName' is set
            if (checkAccountObjectName == null) throw new ApiException(400, "Missing required parameter 'checkAccountObjectName' when calling ReportRegisterBook");
            
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling ReportRegisterBook");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling ReportRegisterBook");
            
    
            var path = "/Report/registerBook";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
 if (checkAccountId != null) queryParams.Add("checkAccount[id]", ApiClient.ParameterToString(checkAccountId)); // query parameter
 if (checkAccountObjectName != null) queryParams.Add("checkAccount[objectName]", ApiClient.ParameterToString(checkAccountObjectName)); // query parameter
 if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportRegisterBook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportRegisterBook: " + response.ErrorMessage, response.ErrorMessage);
    
            return (System.IO.Stream) ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }
    
        /// <summary>
        /// Export the voucher list Calls voucherlist() in Report.php to export the vouchers.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch &#39;yourFilter&#39; with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryFilterStartDate">Start date to filter vouchers with</param> 
        /// <param name="sevQueryModelName">Model name which is exported</param> 
        /// <param name="sevQueryObjectName">SevQuery object name</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <param name="sevQueryLimit">Limit exported vouchers</param> 
        /// <param name="sevQueryOffset">Set the index where the exported vouchers should start</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ReportVoucherList (string sevQueryFilterStartDate, string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset)
        {
            
            // verify the required parameter 'sevQueryFilterStartDate' is set
            if (sevQueryFilterStartDate == null) throw new ApiException(400, "Missing required parameter 'sevQueryFilterStartDate' when calling ReportVoucherList");
            
            // verify the required parameter 'sevQueryModelName' is set
            if (sevQueryModelName == null) throw new ApiException(400, "Missing required parameter 'sevQueryModelName' when calling ReportVoucherList");
            
            // verify the required parameter 'sevQueryObjectName' is set
            if (sevQueryObjectName == null) throw new ApiException(400, "Missing required parameter 'sevQueryObjectName' when calling ReportVoucherList");
            
    
            var path = "/Report/voucherlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
 if (sevQueryFilterStartDate != null) queryParams.Add("sevQuery[filter][startDate]", ApiClient.ParameterToString(sevQueryFilterStartDate)); // query parameter
 if (sevQueryLimit != null) queryParams.Add("sevQuery[limit]", ApiClient.ParameterToString(sevQueryLimit)); // query parameter
 if (sevQueryOffset != null) queryParams.Add("sevQuery[offset]", ApiClient.ParameterToString(sevQueryOffset)); // query parameter
 if (sevQueryModelName != null) queryParams.Add("sevQuery[modelName]", ApiClient.ParameterToString(sevQueryModelName)); // query parameter
 if (sevQueryObjectName != null) queryParams.Add("sevQuery[objectName]", ApiClient.ParameterToString(sevQueryObjectName)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportVoucherList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportVoucherList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (System.IO.Stream) ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }
    
    }
}
