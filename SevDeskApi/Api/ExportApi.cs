using System;
using System.Collections.Generic;
using RestSharp;
using SevDeskApi.Client;

namespace SevDeskApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExportApi
    {
        /// <summary>
        /// Export the specified contact as csv Calls contactCsv() in Export.php to export the specified contact as a csv.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="contactId">Id of the contact you want to export</param>
        /// <param name="contactObjectName">Model name which is exported</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ExportContactCsv(int? contactId, string contactObjectName, bool? download);
        /// <summary>
        /// Export the contact list as csv Calls contactListCsv() in Export.php to export the contact list as a csv.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param>
        /// <param name="sevQueryObjectName">SevQuery object name</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <param name="sevQueryLimit">Limit exported contacts</param>
        /// <param name="sevQueryFilterDepth">Specify if companies and persons (true) or only persons (false) should be exported</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ExportContactListCsv(string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, bool? sevQueryFilterDepth);
        /// <summary>
        /// Datev export as zip with csv´s Calls datev() in Export.php to export the datev as a csv.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="scope">Define what you want to include in the datev export. This parameter takes a string of 4 letters. Each stands for a model that should be included.    Possible letters are: **&#39;I&#39;** (Invoices), **&#39;V&#39;** (Vouchers), **&#39;D&#39;** (Depreciations), **&#39;T&#39;** (Transactions).    By providing one of those letter you specify that it should be included in the datev export. Some combinations are: &#39;IVDT&#39;, &#39;IVT&#39; ...</param>
        /// <param name="start">Specify the start date for the datev export</param>
        /// <param name="end">Specify the end date for the datev export</param>
        /// <param name="withEnshrined">Specify if you want to include enshrined models</param>
        /// <param name="enshrine">Specify if you want to enshrine all models which were included in the export</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ExportDatev(string scope, string start, string end, bool? withEnshrined, bool enshrine, bool? download);
        /// <summary>
        /// Export zip for voucher upload Calls datevZip() in Export.php to export the zip for voucher upload.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="scope">Define what you want to include in the zip export. This parameter takes a string of 4 letters. Each stands for a model that should be included.    Possible letters are: **&#39;I&#39;** (Invoices), **&#39;V&#39;** (Vouchers), **&#39;D&#39;** (Depreciations), **&#39;T&#39;** (Transactions).    By providing one of those letter you specify that it should be included in the datev export. Some combinations are: &#39;IVDT&#39;, &#39;IVT&#39; ...</param>
        /// <param name="start">Specify the start date for the zip export</param>
        /// <param name="end">Specify the end date for the zip export</param>
        /// <param name="withEnshrined">Specify if you want to include enshrined models</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ExportDatevZip(string scope, string start, string end, bool? withEnshrined, bool? download);
        /// <summary>
        /// Export the inventory part log as csv Calls inventoryPartLogListCsv() in Export.php to export the inventory part log list as a csv.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param>
        /// <param name="sevQueryObjectName">SevQuery object name</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <param name="sevQueryLimit">Limit exported part log</param>
        /// <param name="sevQueryFilterPartId">Id of the part for which you want to export the part log</param>
        /// <param name="sevQueryFilterPartObjectName">Object name of part</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ExportInventoryPartLogList(string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryFilterPartId, string sevQueryFilterPartObjectName);
        /// <summary>
        /// Export the invoice list as csv Calls invoiceCsv() in Export.php to export the invoice list as a csv.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param>
        /// <param name="sevQueryObjectName">SevQuery object name</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <param name="sevQueryLimit">Limit exported invoices</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ExportInvoiceCsv(string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit);
        /// <summary>
        /// Export the invoice list as zip with csv´s Calls invoiceZip() in Export.php to export the invoice list as a zip with csv´s.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param>
        /// <param name="sevQueryObjectName">SevQuery object name</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <param name="sevQueryLimit">Limit exported invoices</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ExportInvoiceZip(string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit);
        /// <summary>
        /// Export the parts as csv Calls partCsv() in Export.php to export the parts as csv.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param>
        /// <param name="sevQueryObjectName">SevQuery object name</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <param name="sevQueryLimit">Limit exported part</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ExportPartCsv(string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit);
        /// <summary>
        /// Pebe export as zip with csv´s Calls pebe() in Export.php to export the pebe zip with csv´s.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="scope">Define what you want to include in the datev export. This parameter takes a string of 4 letters. Each stands for a model that should be included.    Possible letters are: **&#39;I&#39;** (Invoices), **&#39;V&#39;** (Vouchers), **&#39;D&#39;** (Depreciations), **&#39;T&#39;** (Transactions).    By providing one of those letter you specify that it should be included in the datev export. Some combinations are: &#39;IVDT&#39;, &#39;IVT&#39; ...</param>
        /// <param name="start">Specify the start date for the pebe export</param>
        /// <param name="end">Specify the end date for the pebe export</param>
        /// <param name="withEnshrined">Specify if you want to include enshrined models</param>
        /// <param name="enshrine">Specify if you want to enshrine all models which were included in the export</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ExportPebe(string scope, string start, string end, bool? withEnshrined, bool enshrine, bool? download);
        /// <summary>
        /// Export the transactions as csv Calls transactionsCsv() in Export.php to export the transactions as csv. Optionally you can provide a specific check account.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryFilterRegister">Specifies if the register is included</param>
        /// <param name="sevQueryModelName">Model name which is exported</param>
        /// <param name="sevQueryObjectName">SevQuery object name</param>
        /// <param name="sevQueryOrderEntryDate">Order in which you want to have the transactions listed</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <param name="checkAccountId">Specify check account for which you want the transactions. Otherwise all transactions will be used</param>
        /// <param name="checkAccountObjectName">Check account model name</param>
        /// <param name="sevQueryLimit">Limit exported transactions</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ExportTransactionsCsv(bool? sevQueryFilterRegister, string sevQueryModelName, string sevQueryObjectName, string sevQueryOrderEntryDate, bool? download, int? checkAccountId, string checkAccountObjectName, int? sevQueryLimit);
        /// <summary>
        /// Export the voucher list as csv Calls voucherListCsv() in Export.php to export the voucher list as a csv.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param>
        /// <param name="sevQueryObjectName">SevQuery object name</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <param name="sevQueryLimit">Limit exported vouchers</param>
        /// <param name="sevQueryFilterStartDate">Start date of the voucher list</param>
        /// <param name="sevQueryFilterVoucherType">Type of vouchers you want to export</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ExportVoucherListCsv(string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, string sevQueryFilterStartDate, string sevQueryFilterVoucherType);
        /// <summary>
        /// Export the voucher list as zip with csv´s Calls voucherZip() in Export.php to export the voucher list as a zip with csv´s.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param>
        /// <param name="sevQueryObjectName">SevQuery object name</param>
        /// <param name="download">Specifies if the document is downloaded</param>
        /// <param name="sevQueryLimit">Limit exported vouchers</param>
        /// <param name="sevQueryFilterStartDate">Start date of the voucher list</param>
        /// <param name="sevQueryFilterVoucherType">Type of vouchers you want to export</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ExportVoucherZip(string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, string sevQueryFilterStartDate, string sevQueryFilterVoucherType);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ExportApi : IExportApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ExportApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExportApi(String basePath)
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
        /// Export the specified contact as csv Calls contactCsv() in Export.php to export the specified contact as a csv.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="contactId">Id of the contact you want to export</param> 
        /// <param name="contactObjectName">Model name which is exported</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ExportContactCsv(int? contactId, string contactObjectName, bool? download)
        {

            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling ExportContactCsv");

            // verify the required parameter 'contactObjectName' is set
            if (contactObjectName == null) throw new ApiException(400, "Missing required parameter 'contactObjectName' when calling ExportContactCsv");


            var path = "/Export/contactCsv";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ExportContactCsv: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ExportContactCsv: " + response.ErrorMessage, response.ErrorMessage);

            return (System.IO.Stream)ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }

        /// <summary>
        /// Export the contact list as csv Calls contactListCsv() in Export.php to export the contact list as a csv.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param> 
        /// <param name="sevQueryObjectName">SevQuery object name</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <param name="sevQueryLimit">Limit exported contacts</param> 
        /// <param name="sevQueryFilterDepth">Specify if companies and persons (true) or only persons (false) should be exported</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ExportContactListCsv(string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, bool? sevQueryFilterDepth)
        {

            // verify the required parameter 'sevQueryModelName' is set
            if (sevQueryModelName == null) throw new ApiException(400, "Missing required parameter 'sevQueryModelName' when calling ExportContactListCsv");

            // verify the required parameter 'sevQueryObjectName' is set
            if (sevQueryObjectName == null) throw new ApiException(400, "Missing required parameter 'sevQueryObjectName' when calling ExportContactListCsv");


            var path = "/Export/contactListCsv";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
            if (sevQueryLimit != null) queryParams.Add("sevQuery[limit]", ApiClient.ParameterToString(sevQueryLimit)); // query parameter
            if (sevQueryFilterDepth != null) queryParams.Add("sevQuery[filter][depth]", ApiClient.ParameterToString(sevQueryFilterDepth)); // query parameter
            if (sevQueryModelName != null) queryParams.Add("sevQuery[modelName]", ApiClient.ParameterToString(sevQueryModelName)); // query parameter
            if (sevQueryObjectName != null) queryParams.Add("sevQuery[objectName]", ApiClient.ParameterToString(sevQueryObjectName)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ExportContactListCsv: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ExportContactListCsv: " + response.ErrorMessage, response.ErrorMessage);

            return (System.IO.Stream)ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }

        /// <summary>
        /// Datev export as zip with csv´s Calls datev() in Export.php to export the datev as a csv.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="scope">Define what you want to include in the datev export. This parameter takes a string of 4 letters. Each stands for a model that should be included.    Possible letters are: **&#39;I&#39;** (Invoices), **&#39;V&#39;** (Vouchers), **&#39;D&#39;** (Depreciations), **&#39;T&#39;** (Transactions).    By providing one of those letter you specify that it should be included in the datev export. Some combinations are: &#39;IVDT&#39;, &#39;IVT&#39; ...</param> 
        /// <param name="start">Specify the start date for the datev export</param> 
        /// <param name="end">Specify the end date for the datev export</param> 
        /// <param name="withEnshrined">Specify if you want to include enshrined models</param> 
        /// <param name="enshrine">Specify if you want to enshrine all models which were included in the export</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ExportDatev(string scope, string start, string end, bool? withEnshrined, bool enshrine, bool? download)
        {

            // verify the required parameter 'scope' is set
            if (scope == null) throw new ApiException(400, "Missing required parameter 'scope' when calling ExportDatev");

            // verify the required parameter 'start' is set
            if (start == null) throw new ApiException(400, "Missing required parameter 'start' when calling ExportDatev");

            // verify the required parameter 'end' is set
            if (end == null) throw new ApiException(400, "Missing required parameter 'end' when calling ExportDatev");

            // verify the required parameter 'withEnshrined' is set
            if (withEnshrined == null) throw new ApiException(400, "Missing required parameter 'withEnshrined' when calling ExportDatev");
            

            var path = "/Export/datev";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
            if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
            if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
            if (end != null) queryParams.Add("end", ApiClient.ParameterToString(end)); // query parameter
            if (withEnshrined != null) queryParams.Add("withEnshrined", ApiClient.ParameterToString(withEnshrined)); // query parameter
            queryParams.Add("enshrine", ApiClient.ParameterToString(enshrine)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ExportDatev: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ExportDatev: " + response.ErrorMessage, response.ErrorMessage);

            return (System.IO.Stream)ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }

        /// <summary>
        /// Export zip for voucher upload Calls datevZip() in Export.php to export the zip for voucher upload.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="scope">Define what you want to include in the zip export. This parameter takes a string of 4 letters. Each stands for a model that should be included.    Possible letters are: **&#39;I&#39;** (Invoices), **&#39;V&#39;** (Vouchers), **&#39;D&#39;** (Depreciations), **&#39;T&#39;** (Transactions).    By providing one of those letter you specify that it should be included in the datev export. Some combinations are: &#39;IVDT&#39;, &#39;IVT&#39; ...</param> 
        /// <param name="start">Specify the start date for the zip export</param> 
        /// <param name="end">Specify the end date for the zip export</param> 
        /// <param name="withEnshrined">Specify if you want to include enshrined models</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ExportDatevZip(string scope, string start, string end, bool? withEnshrined, bool? download)
        {

            // verify the required parameter 'scope' is set
            if (scope == null) throw new ApiException(400, "Missing required parameter 'scope' when calling ExportDatevZip");

            // verify the required parameter 'start' is set
            if (start == null) throw new ApiException(400, "Missing required parameter 'start' when calling ExportDatevZip");

            // verify the required parameter 'end' is set
            if (end == null) throw new ApiException(400, "Missing required parameter 'end' when calling ExportDatevZip");

            // verify the required parameter 'withEnshrined' is set
            if (withEnshrined == null) throw new ApiException(400, "Missing required parameter 'withEnshrined' when calling ExportDatevZip");


            var path = "/Export/datevZip";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
            if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
            if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
            if (end != null) queryParams.Add("end", ApiClient.ParameterToString(end)); // query parameter
            if (withEnshrined != null) queryParams.Add("withEnshrined", ApiClient.ParameterToString(withEnshrined)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ExportDatevZip: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ExportDatevZip: " + response.ErrorMessage, response.ErrorMessage);

            return (System.IO.Stream)ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }

        /// <summary>
        /// Export the inventory part log as csv Calls inventoryPartLogListCsv() in Export.php to export the inventory part log list as a csv.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param> 
        /// <param name="sevQueryObjectName">SevQuery object name</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <param name="sevQueryLimit">Limit exported part log</param> 
        /// <param name="sevQueryFilterPartId">Id of the part for which you want to export the part log</param> 
        /// <param name="sevQueryFilterPartObjectName">Object name of part</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ExportInventoryPartLogList(string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryFilterPartId, string sevQueryFilterPartObjectName)
        {

            // verify the required parameter 'sevQueryModelName' is set
            if (sevQueryModelName == null) throw new ApiException(400, "Missing required parameter 'sevQueryModelName' when calling ExportInventoryPartLogList");

            // verify the required parameter 'sevQueryObjectName' is set
            if (sevQueryObjectName == null) throw new ApiException(400, "Missing required parameter 'sevQueryObjectName' when calling ExportInventoryPartLogList");


            var path = "/Export/inventoryPartLogListCsv";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
            if (sevQueryLimit != null) queryParams.Add("sevQuery[limit]", ApiClient.ParameterToString(sevQueryLimit)); // query parameter
            if (sevQueryFilterPartId != null) queryParams.Add("sevQuery[filter][part][id]", ApiClient.ParameterToString(sevQueryFilterPartId)); // query parameter
            if (sevQueryFilterPartObjectName != null) queryParams.Add("sevQuery[filter][part][objectName]", ApiClient.ParameterToString(sevQueryFilterPartObjectName)); // query parameter
            if (sevQueryModelName != null) queryParams.Add("sevQuery[modelName]", ApiClient.ParameterToString(sevQueryModelName)); // query parameter
            if (sevQueryObjectName != null) queryParams.Add("sevQuery[objectName]", ApiClient.ParameterToString(sevQueryObjectName)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ExportInventoryPartLogList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ExportInventoryPartLogList: " + response.ErrorMessage, response.ErrorMessage);

            return (System.IO.Stream)ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }

        /// <summary>
        /// Export the invoice list as csv Calls invoiceCsv() in Export.php to export the invoice list as a csv.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param> 
        /// <param name="sevQueryObjectName">SevQuery object name</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <param name="sevQueryLimit">Limit exported invoices</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ExportInvoiceCsv(string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit)
        {

            // verify the required parameter 'sevQueryModelName' is set
            if (sevQueryModelName == null) throw new ApiException(400, "Missing required parameter 'sevQueryModelName' when calling ExportInvoiceCsv");

            // verify the required parameter 'sevQueryObjectName' is set
            if (sevQueryObjectName == null) throw new ApiException(400, "Missing required parameter 'sevQueryObjectName' when calling ExportInvoiceCsv");


            var path = "/Export/invoiceCsv";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
            if (sevQueryLimit != null) queryParams.Add("sevQuery[limit]", ApiClient.ParameterToString(sevQueryLimit)); // query parameter
            if (sevQueryModelName != null) queryParams.Add("sevQuery[modelName]", ApiClient.ParameterToString(sevQueryModelName)); // query parameter
            if (sevQueryObjectName != null) queryParams.Add("sevQuery[objectName]", ApiClient.ParameterToString(sevQueryObjectName)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ExportInvoiceCsv: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ExportInvoiceCsv: " + response.ErrorMessage, response.ErrorMessage);

            return (System.IO.Stream)ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }

        /// <summary>
        /// Export the invoice list as zip with csv´s Calls invoiceZip() in Export.php to export the invoice list as a zip with csv´s.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param> 
        /// <param name="sevQueryObjectName">SevQuery object name</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <param name="sevQueryLimit">Limit exported invoices</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ExportInvoiceZip(string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit)
        {

            // verify the required parameter 'sevQueryModelName' is set
            if (sevQueryModelName == null) throw new ApiException(400, "Missing required parameter 'sevQueryModelName' when calling ExportInvoiceZip");

            // verify the required parameter 'sevQueryObjectName' is set
            if (sevQueryObjectName == null) throw new ApiException(400, "Missing required parameter 'sevQueryObjectName' when calling ExportInvoiceZip");


            var path = "/Export/invoiceZip";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
            if (sevQueryLimit != null) queryParams.Add("sevQuery[limit]", ApiClient.ParameterToString(sevQueryLimit)); // query parameter
            if (sevQueryModelName != null) queryParams.Add("sevQuery[modelName]", ApiClient.ParameterToString(sevQueryModelName)); // query parameter
            if (sevQueryObjectName != null) queryParams.Add("sevQuery[objectName]", ApiClient.ParameterToString(sevQueryObjectName)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ExportInvoiceZip: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ExportInvoiceZip: " + response.ErrorMessage, response.ErrorMessage);

            return (System.IO.Stream)ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }

        /// <summary>
        /// Export the parts as csv Calls partCsv() in Export.php to export the parts as csv.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param> 
        /// <param name="sevQueryObjectName">SevQuery object name</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <param name="sevQueryLimit">Limit exported part</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ExportPartCsv(string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit)
        {

            // verify the required parameter 'sevQueryModelName' is set
            if (sevQueryModelName == null) throw new ApiException(400, "Missing required parameter 'sevQueryModelName' when calling ExportPartCsv");

            // verify the required parameter 'sevQueryObjectName' is set
            if (sevQueryObjectName == null) throw new ApiException(400, "Missing required parameter 'sevQueryObjectName' when calling ExportPartCsv");


            var path = "/Export/partCsv";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
            if (sevQueryLimit != null) queryParams.Add("sevQuery[limit]", ApiClient.ParameterToString(sevQueryLimit)); // query parameter
            if (sevQueryModelName != null) queryParams.Add("sevQuery[modelName]", ApiClient.ParameterToString(sevQueryModelName)); // query parameter
            if (sevQueryObjectName != null) queryParams.Add("sevQuery[objectName]", ApiClient.ParameterToString(sevQueryObjectName)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ExportPartCsv: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ExportPartCsv: " + response.ErrorMessage, response.ErrorMessage);

            return (System.IO.Stream)ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }

        /// <summary>
        /// Pebe export as zip with csv´s Calls pebe() in Export.php to export the pebe zip with csv´s.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="scope">Define what you want to include in the datev export. This parameter takes a string of 4 letters. Each stands for a model that should be included.    Possible letters are: **&#39;I&#39;** (Invoices), **&#39;V&#39;** (Vouchers), **&#39;D&#39;** (Depreciations), **&#39;T&#39;** (Transactions).    By providing one of those letter you specify that it should be included in the datev export. Some combinations are: &#39;IVDT&#39;, &#39;IVT&#39; ...</param> 
        /// <param name="start">Specify the start date for the pebe export</param> 
        /// <param name="end">Specify the end date for the pebe export</param> 
        /// <param name="withEnshrined">Specify if you want to include enshrined models</param> 
        /// <param name="enshrine">Specify if you want to enshrine all models which were included in the export</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ExportPebe(string scope, string start, string end, bool? withEnshrined, bool enshrine, bool? download)
        {

            // verify the required parameter 'scope' is set
            if (scope == null) throw new ApiException(400, "Missing required parameter 'scope' when calling ExportPebe");

            // verify the required parameter 'start' is set
            if (start == null) throw new ApiException(400, "Missing required parameter 'start' when calling ExportPebe");

            // verify the required parameter 'end' is set
            if (end == null) throw new ApiException(400, "Missing required parameter 'end' when calling ExportPebe");

            // verify the required parameter 'withEnshrined' is set
            if (withEnshrined == null) throw new ApiException(400, "Missing required parameter 'withEnshrined' when calling ExportPebe");
            

            var path = "/Export/pebe";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
            if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
            if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
            if (end != null) queryParams.Add("end", ApiClient.ParameterToString(end)); // query parameter
            if (withEnshrined != null) queryParams.Add("withEnshrined", ApiClient.ParameterToString(withEnshrined)); // query parameter
            queryParams.Add("enshrine", ApiClient.ParameterToString(enshrine)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ExportPebe: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ExportPebe: " + response.ErrorMessage, response.ErrorMessage);

            return (System.IO.Stream)ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }

        /// <summary>
        /// Export the transactions as csv Calls transactionsCsv() in Export.php to export the transactions as csv. Optionally you can provide a specific check account.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryFilterRegister">Specifies if the register is included</param> 
        /// <param name="sevQueryModelName">Model name which is exported</param> 
        /// <param name="sevQueryObjectName">SevQuery object name</param> 
        /// <param name="sevQueryOrderEntryDate">Order in which you want to have the transactions listed</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <param name="checkAccountId">Specify check account for which you want the transactions. Otherwise all transactions will be used</param> 
        /// <param name="checkAccountObjectName">Check account model name</param> 
        /// <param name="sevQueryLimit">Limit exported transactions</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ExportTransactionsCsv(bool? sevQueryFilterRegister, string sevQueryModelName, string sevQueryObjectName, string sevQueryOrderEntryDate, bool? download, int? checkAccountId, string checkAccountObjectName, int? sevQueryLimit)
        {

            // verify the required parameter 'sevQueryFilterRegister' is set
            if (sevQueryFilterRegister == null) throw new ApiException(400, "Missing required parameter 'sevQueryFilterRegister' when calling ExportTransactionsCsv");

            // verify the required parameter 'sevQueryModelName' is set
            if (sevQueryModelName == null) throw new ApiException(400, "Missing required parameter 'sevQueryModelName' when calling ExportTransactionsCsv");

            // verify the required parameter 'sevQueryObjectName' is set
            if (sevQueryObjectName == null) throw new ApiException(400, "Missing required parameter 'sevQueryObjectName' when calling ExportTransactionsCsv");

            // verify the required parameter 'sevQueryOrderEntryDate' is set
            if (sevQueryOrderEntryDate == null) throw new ApiException(400, "Missing required parameter 'sevQueryOrderEntryDate' when calling ExportTransactionsCsv");


            var path = "/Export/transactionsCsv";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
            if (checkAccountId != null) queryParams.Add("checkAccount[id]", ApiClient.ParameterToString(checkAccountId)); // query parameter
            if (checkAccountObjectName != null) queryParams.Add("checkAccount[objectName]", ApiClient.ParameterToString(checkAccountObjectName)); // query parameter
            if (sevQueryFilterRegister != null) queryParams.Add("sevQuery[filter][register]", ApiClient.ParameterToString(sevQueryFilterRegister)); // query parameter
            if (sevQueryLimit != null) queryParams.Add("sevQuery[limit]", ApiClient.ParameterToString(sevQueryLimit)); // query parameter
            if (sevQueryModelName != null) queryParams.Add("sevQuery[modelName]", ApiClient.ParameterToString(sevQueryModelName)); // query parameter
            if (sevQueryObjectName != null) queryParams.Add("sevQuery[objectName]", ApiClient.ParameterToString(sevQueryObjectName)); // query parameter
            if (sevQueryOrderEntryDate != null) queryParams.Add("sevQuery[order][entryDate]", ApiClient.ParameterToString(sevQueryOrderEntryDate)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ExportTransactionsCsv: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ExportTransactionsCsv: " + response.ErrorMessage, response.ErrorMessage);

            return (System.IO.Stream)ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }

        /// <summary>
        /// Export the voucher list as csv Calls voucherListCsv() in Export.php to export the voucher list as a csv.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param> 
        /// <param name="sevQueryObjectName">SevQuery object name</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <param name="sevQueryLimit">Limit exported vouchers</param> 
        /// <param name="sevQueryFilterStartDate">Start date of the voucher list</param> 
        /// <param name="sevQueryFilterVoucherType">Type of vouchers you want to export</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ExportVoucherListCsv(string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, string sevQueryFilterStartDate, string sevQueryFilterVoucherType)
        {

            // verify the required parameter 'sevQueryModelName' is set
            if (sevQueryModelName == null) throw new ApiException(400, "Missing required parameter 'sevQueryModelName' when calling ExportVoucherListCsv");

            // verify the required parameter 'sevQueryObjectName' is set
            if (sevQueryObjectName == null) throw new ApiException(400, "Missing required parameter 'sevQueryObjectName' when calling ExportVoucherListCsv");


            var path = "/Export/voucherListCsv";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
            if (sevQueryLimit != null) queryParams.Add("sevQuery[limit]", ApiClient.ParameterToString(sevQueryLimit)); // query parameter
            if (sevQueryFilterStartDate != null) queryParams.Add("sevQuery[filter][startDate]", ApiClient.ParameterToString(sevQueryFilterStartDate)); // query parameter
            if (sevQueryFilterVoucherType != null) queryParams.Add("sevQuery[filter][voucherType]", ApiClient.ParameterToString(sevQueryFilterVoucherType)); // query parameter
            if (sevQueryModelName != null) queryParams.Add("sevQuery[modelName]", ApiClient.ParameterToString(sevQueryModelName)); // query parameter
            if (sevQueryObjectName != null) queryParams.Add("sevQuery[objectName]", ApiClient.ParameterToString(sevQueryObjectName)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ExportVoucherListCsv: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ExportVoucherListCsv: " + response.ErrorMessage, response.ErrorMessage);

            return (System.IO.Stream)ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }

        /// <summary>
        /// Export the voucher list as zip with csv´s Calls voucherZip() in Export.php to export the voucher list as a zip with csv´s.    **Currently there is a problem with swagger understanding return type &#39;file&#39;, so the api will respond accordingly but swagger ui can not display it correctly.**
        /// </summary>
        /// <param name="sevQueryModelName">Model name which is exported</param> 
        /// <param name="sevQueryObjectName">SevQuery object name</param> 
        /// <param name="download">Specifies if the document is downloaded</param> 
        /// <param name="sevQueryLimit">Limit exported vouchers</param> 
        /// <param name="sevQueryFilterStartDate">Start date of the voucher list</param> 
        /// <param name="sevQueryFilterVoucherType">Type of vouchers you want to export</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream ExportVoucherZip(string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, string sevQueryFilterStartDate, string sevQueryFilterVoucherType)
        {

            // verify the required parameter 'sevQueryModelName' is set
            if (sevQueryModelName == null) throw new ApiException(400, "Missing required parameter 'sevQueryModelName' when calling ExportVoucherZip");

            // verify the required parameter 'sevQueryObjectName' is set
            if (sevQueryObjectName == null) throw new ApiException(400, "Missing required parameter 'sevQueryObjectName' when calling ExportVoucherZip");


            var path = "/Export/voucherZip";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter
            if (sevQueryLimit != null) queryParams.Add("sevQuery[limit]", ApiClient.ParameterToString(sevQueryLimit)); // query parameter
            if (sevQueryFilterStartDate != null) queryParams.Add("sevQuery[filter][startDate]", ApiClient.ParameterToString(sevQueryFilterStartDate)); // query parameter
            if (sevQueryFilterVoucherType != null) queryParams.Add("sevQuery[filter][voucherType]", ApiClient.ParameterToString(sevQueryFilterVoucherType)); // query parameter
            if (sevQueryModelName != null) queryParams.Add("sevQuery[modelName]", ApiClient.ParameterToString(sevQueryModelName)); // query parameter
            if (sevQueryObjectName != null) queryParams.Add("sevQuery[objectName]", ApiClient.ParameterToString(sevQueryObjectName)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ExportVoucherZip: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ExportVoucherZip: " + response.ErrorMessage, response.ErrorMessage);

            return (System.IO.Stream)ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }

    }
}
