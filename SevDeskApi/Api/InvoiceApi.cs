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
    public interface IInvoiceApi
    {
        /// <summary>
        /// Create a new invoice Calls Invoice.php 
        /// </summary>
        /// <param name="body">To create an invoice, simply enter desired values after parameter&#x3D; and remove the quotation marks.    Be aware that you can&#39;t use all the parameters included in the Model_Invoice, as creating an invoice involves other functions.    So for example, adding a sumNet/Gross/etc. does not work as they normally get their value from the product which is involved in the invoice    The product/part in this case is handled in the Model_InvoicePos which makes a call to Model_Part.    In Invoice.php there is only a function &#39;addPosition&#39; which makes the call to InvoicePos.php</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice AddInvoice(string body);
        /// <summary>
        /// Cancel an invoice Calls cancel() in Invoice.php to cancel an invoice and creates a cancellation invoice  
        /// </summary>
        /// <param name="id">Id of invoice which you want to cancel</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice CancelInvoice(int? id);
        /// <summary>
        /// Create an new invoice from an existing order With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the Model.php itself still constructs the model however new instances of the model are created trough the Factory.php    So for example when you create a new invoice it wont be saved by a POST request with &#39;/Invoice?para1&#x3D;&amp;...&#39; but with the saveInvoice function in Factory.php &#39;Voucher/Factory/saveInvoice?para1&#x3D;&#39;
        /// </summary>
        /// <param name="body">Takes an existing Model_Order and creates an invoice with positions and discounts from it. Enter your values after parameter&#x3D; and remove the quotation marks</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice CreateInvoiceFromOrder(string body);
        /// <summary>
        /// Create an invoice reminder With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the Model.php itself still constructs the model however new instances of the model are created trough the Factory.php    So for example when you create a new invoice it wont be saved by a POST request with &#39;/Invoice?para1&#x3D;&amp;...&#39; but with the saveInvoice function in Factory.php &#39;Voucher/Factory/saveInvoice?para1&#x3D;&#39;
        /// </summary>
        /// <param name="body">Takes an existing Model_Invoice and creates a reminder for it.    Note that actually creating a reminder would require to save the rendered invoice reminder so this is not possible by calling the api directly.    However for demonstration purposes you can still call the function by appending an invoice id after invoice[id]&#x3D; and removing the quotation marks.</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice CreateInvoiceReminder(string body);
        /// <summary>
        /// Delete an existing invoice Calls the delete() function in Invoice.php
        /// </summary>
        /// <param name="id">id of invoice you want to delete</param>
        /// <returns></returns>
        void DeleteInvoice(int? id);
        /// <summary>
        /// Duplicate an existing invoice Calls duplicate() in Invoice.php to duplicate an existing invoice
        /// </summary>
        /// <param name="id">id of invoice you want to duplicate</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice DuplicateInvoice(int? id);
        /// <summary>
        /// Get amount of an invoice including reminders Calls the getTotalInvoiceReminderAndInvoiceAmount function in /Invoice/Factory/ to get the amount of the invoice including its reminders.
        /// </summary>
        /// <param name="invoiceId">id of the invoice you want to get the total amount for</param>
        /// <param name="invoiceObjectName"></param>
        /// <returns></returns>
        void GetInvoiceAndReminderAmount(int? invoiceId, string invoiceObjectName);
        /// <summary>
        /// Get the invoice as a PDF Calls getPdf in Invoice.php
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the PDF</param>
        /// <param name="download">If true PDF will return as filestream otherwise as json object the content base64 encoded</param>
        /// <returns></returns>
        void GetInvoiceAsPdf(int? id, bool? download);
        /// <summary>
        /// Get (monetary) amount of all reminders of an invoice Calls the getTotalInvoiceReminderAmount function in /Invoice/Factory/ to get the amount of all reminders of an invoice.
        /// </summary>
        /// <param name="invoiceId">id of the invoice you want to get the reminder amount for</param>
        /// <param name="invoiceObjectName"></param>
        /// <returns></returns>
        void GetInvoiceReminderAmount(int? invoiceId, string invoiceObjectName);
        /// <summary>
        /// Get an overview of all invoices Calls Invoice.php to get necessary variables. However, not all variables get their value from Invoice.php directly but from other models like Model_InvoicePos or Model_Part
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned invoices start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice GetInvoices(int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Get the next invoice number 
        /// </summary>
        /// <param name="invoiceType">defines the type of invoice you want to get the next number from</param>
        /// <param name="useNextNumber">By default this is true, so the invoiceNumber will increase by one otherwise the invoiceNumber will not change</param>
        /// <returns></returns>
        void GetNextInvoiceNumber(string invoiceType, bool? useNextNumber);
        /// <summary>
        /// Add a position to an existing invoice Calls addPosition() in Invoice.php to add a position to an invoice.    This function is not required anymore as there is a function for creating Invoices in Invoice/Factory which includes adding the position.
        /// </summary>
        /// <param name="id">id of invoice you want to add a position to</param>
        /// <param name="body">To add a position, simply enter desired values after parameter&#x3D; and remove the quotation marks</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice InvoiceAddPosition(int? id, string body);
        /// <summary>
        /// Book amount for an invoice Calls bookAmmount() in Invoice.php to book an invoice amount
        /// </summary>
        /// <param name="id">Id of invoice of which you want to book an amount</param>
        /// <param name="ammount">amount which should be booked</param>
        /// <param name="date">booking date</param>
        /// <param name="body">Optionally, you can enter a checkAccount and checkAccountTransaction here.    Be aware that if you dont define a checkAccount / checkAccountTransaction you need to remove the part from the body or remove everything except the quotation marks if you dont want to define anything at all!</param>
        /// <returns>ModelInvoiceLog</returns>
        ModelInvoiceLog InvoiceBookAmount(int? id, int? ammount, string date, string body);
        /// <summary>
        /// Calculate total sum of all invoices of current query Calls calcTotalDebit() in Invoice.php to calculate total sum of all invoices of current query
        /// </summary>
        /// <returns></returns>
        void InvoiceCalcTotalDebit();
        /// <summary>
        /// Get dunning level of an invoice Calls calculateDunningLevel() in Invoice.php to get the dunning level of an invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the dunning level</param>
        /// <returns></returns>
        void InvoiceCalculateDunningLevel(int? id);
        /// <summary>
        /// Change status of an invoice Calls changeStatus() in Invoice.php to book an invoice amount
        /// </summary>
        /// <param name="id">Id of invoice of which you want to book an amount</param>
        /// <param name="value">desired status</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice InvoiceChangeStatus(int? id, int? value);
        /// <summary>
        /// Returns if an invoice is cancled Calls getCancled() in Invoice.php to know if an invoice is cancled
        /// </summary>
        /// <param name="id">Id of invoice of which you want to know if it is cancled</param>
        /// <returns></returns>
        void InvoiceGetCancled(int? id);
        /// <summary>
        /// Get check account transaction logs about a specified invoice Calls getCheckAccountTransactionLogs() in Invoice.php to get check account transaction logs about the invoice
        /// </summary>
        /// <param name="id">Id of the invoice of which you want to get the check account transaction logs</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelCheckAccountTransactionLog</returns>
        ModelCheckAccountTransactionLog InvoiceGetCheckAccountTransactionLogs(int? id, List<string> embed);
        /// <summary>
        /// Get check account transactions of a specified invoice Calls getCheckAccountTransactions() in Invoice.php to get check account transactions of the invoice
        /// </summary>
        /// <param name="id">Id of the invoice of which you want to get the check account transactions</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelCheckAccountTransaction</returns>
        ModelCheckAccountTransaction InvoiceGetCheckAccountTransactions(int? id, List<string> embed);
        /// <summary>
        /// Get debit of an invoice Calls getDebit() in Invoice.php to get debit of an invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the debit</param>
        /// <returns></returns>
        void InvoiceGetDebit(int? id);
        /// <summary>
        /// Get if an invoice is delinquent Calls getDelinquent() in Invoice.php to get if an invoice is delinquent
        /// </summary>
        /// <param name="id">Id of invoice of which you want to know if its delinquent</param>
        /// <returns></returns>
        void InvoiceGetDelinquent(int? id);
        /// <summary>
        /// Get the discounts of a specified invoice Calls getDiscounts() in Invoice.php
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the discounts</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelDiscounts</returns>
        ModelDiscounts InvoiceGetDiscounts(int? id, List<string> embed);
        /// <summary>
        /// Get document of an invoice Calls getDocument() in Invoice.php to get the document of an invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the document</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns></returns>
        void InvoiceGetDocument(int? id, List<string> embed);
        /// <summary>
        /// Get invoice dunnings Calls getDunnings() in Invoice.php to get the dunnings of an invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the dunnings</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice InvoiceGetDunnings(int? id);
        /// <summary>
        /// Get the feed of a specified invoice Calls getFeed() in Invoice.php
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the feed</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelFeed</returns>
        ModelFeed InvoiceGetFeed(int? id, List<string> embed);
        /// <summary>
        /// Get final invoice id Calls getFinalInvoiceId() in Invoice.php to get final invoice id of the invoice chain
        /// </summary>
        /// <param name="id">Id of the invoice of which you want to get the final invoice id</param>
        /// <returns></returns>
        void InvoiceGetFinalInvoiceId(int? id);
        /// <summary>
        /// Returns if the invoice is partially payed Calls getIsPartiallyPaid() in Invoice.php
        /// </summary>
        /// <param name="id">Id of invoice of which you want to know if it is partially paid</param>
        /// <returns></returns>
        void InvoiceGetIsPartiallyPaid(int? id);
        /// <summary>
        /// Get last dunning date of invoice as timestamp Calls getLastDunningDate() in Invoice.php to get the date of the last dunning of an invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the date of the last dunning</param>
        /// <returns></returns>
        void InvoiceGetLastDunningDate(int? id);
        /// <summary>
        /// Get partial invoices of a specified invoice Calls getPartialInvoices() in Invoice.php to get partial invoices of the invoice
        /// </summary>
        /// <param name="id">Id of the invoice of which you want to get the partial invoices</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice InvoiceGetPartialInvoices(int? id, List<string> embed);
        /// <summary>
        /// Get the positions of a specified invoice Calls getPositions() in Invoice.php
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the positions</param>
        /// <param name="limit">limits the number of entries returned</param>
        /// <param name="offset">set the index where the returned entries start</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelInvoicePos</returns>
        ModelInvoicePos InvoiceGetPositions(int? id, int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Get related objects of a specified invoice Calls getRelatedObjects() in Invoice.php to get related objects of the invoice
        /// </summary>
        /// <param name="id">Id of the invoice of which you want to get the related objects</param>
        /// <param name="includeItself">Define if the related objects include the invoice itself</param>
        /// <param name="sortByType">Define if you want the related objects sorted by type</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns></returns>
        void InvoiceGetRelatedObjects(int? id, bool? includeItself, bool? sortByType, List<string> embed);
        /// <summary>
        /// Get swiss esr Calls getSwissEsr() in Invoice.php to get the swiss esr
        /// </summary>
        /// <returns></returns>
        void InvoiceGetSwissEsr();
        /// <summary>
        /// Get swiss esr data Calls getSwissEsrData() in Invoice.php to get the swiss esr data
        /// </summary>
        /// <returns></returns>
        void InvoiceGetSwissEsrData();
        /// <summary>
        /// Get the tags of a specified invoice Calls getTags() in Invoice.php
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the tags</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelTag</returns>
        ModelTag InvoiceGetTags(int? id, List<string> embed);
        /// <summary>
        /// Get invoice tax amount in invoice currency Calls getTax() in Invoice.php to get tax amount of invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the invoice tax amount</param>
        /// <param name="invoiceAmount">Determines whether to use sumTax from invoice or sumTaxAccounting</param>
        /// <returns></returns>
        void InvoiceGetTax(int? id, bool? invoiceAmount);
        /// <summary>
        /// Get tax groups of invoice Calls getTaxGroupes() in Invoice.php to get tax groups
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the tax groups</param>
        /// <returns></returns>
        void InvoiceGetTaxGroups(int? id);
        /// <summary>
        /// Get gross invoice amount in invoice currency Calls getTotal() in Invoice.php to get gross amount of invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the gross invoice amount</param>
        /// <param name="invoiceAmount">Determines whether to use sumGross from invoice or sumGrossAccounting</param>
        /// <returns></returns>
        void InvoiceGetTotal(int? id, bool? invoiceAmount);
        /// <summary>
        /// Get total invoice amount in invoice currency Calls getTotalCalc() in Invoice.php to get tax groups
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the invoice amount in invoice currency</param>
        /// <returns></returns>
        void InvoiceGetTotalCalc(int? id);
        /// <summary>
        /// Get total net invoice amount in invoice currency Calls getTotalNet() in Invoice.php to get total net amount of invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the total net invoice amount</param>
        /// <param name="invoiceAmount">Determines whether to use sumNet from invoice or sumNetAccounting</param>
        /// <param name="withoutDiscounts">Determines whether the total net is calculated with or without the discounts</param>
        /// <returns></returns>
        void InvoiceGetTotalNet(int? id, bool? invoiceAmount, bool? withoutDiscounts);
        /// <summary>
        /// Returns if the specified invoice has discounts Calls hasDiscounts() in Invoice.php
        /// </summary>
        /// <param name="id">Id of invoice of which you want to know if it has discounts</param>
        /// <returns></returns>
        void InvoiceHasDiscounts(int? id);
        /// <summary>
        /// Returns if the specified invoice is the origin of an order Calls isOrigin() in Invoice.php to find out if the invoice is the origin of an order
        /// </summary>
        /// <param name="id">Id of invoice of which you want to know if it is the origin of an order</param>
        /// <returns></returns>
        void InvoiceIsOrigin(int? id);
        /// <summary>
        /// Marks an invoice as sent Calls markAsSent() in Invoice.php to mark an invoice as sent
        /// </summary>
        /// <param name="id">Id of invoice which you want to mark as sent</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice InvoiceMarkAsSent(int? id);
        /// <summary>
        /// Refund an already payed invoice amount Calls refundAmmount() in Invoice.php to refund an invoice amount
        /// </summary>
        /// <param name="id">Id of invoice of which you want to refund the amount</param>
        /// <param name="ammount">amount which should be refunded</param>
        /// <param name="date">booking date</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice InvoiceRefundAmount(int? id, int? ammount, string date);
        /// <summary>
        /// Render invoice document on docserver and return metadata Calls render() in Invoice.php to render invoice document on docserver and return the metadata
        /// </summary>
        /// <param name="id">Id of invoice of which you want to render the document and get the metadata</param>
        /// <returns></returns>
        void InvoiceRender(int? id);
        /// <summary>
        /// Send invoice by desired method Calls sendBy() in Invoice.php to send an invoice by the desired method
        /// </summary>
        /// <param name="id">Id of invoice which you want to send</param>
        /// <param name="sendType">desired send type, available are: VM &#x3D; Mail, VP &#x3D; Post, VPDF &#x3D; PDF, PRN &#x3D; Print</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice InvoiceSendBy(int? id, string sendType);
        /// <summary>
        /// Create a new invoice (with / without invoice positions and discounts)  With the new version of sevdesk some models are not created by calling the model.php directly but by calling the factory.php because of better performance and flexibility.    Basically the model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new invoice it wont be saved by a POST request with &#39;/Invoice?para1&#x3D;&amp;...&#39; but with the saveInvoice function in Factory.php &#39;Voucher/Factory/saveInvoice?para1&#x3D;&#39;
        /// </summary>
        /// <param name="body">The saveInvoice function in Invoice/Factory.php combines both Invoice and InvoicePos with all their HTTP-methods.    It is now possible to **simultaneously** create an invoice with its position and discount.    To simply (only) create an invoice you can use the given parameters and concatenate your values.    For also adding an invoice position or a discount refer to the corresponding **quick reference** below.    The parameters you find there are **needed** for creating an invoice position / discount. Just concatenate them to the existing invoice / invoicePosSave parameters.    You can also find additional (optional) parameters in the **Models** section.    Quick reference InvoicePos:  * &amp;invoicePosSave[0][part][id]&#x3D;  * &amp;invoicePosSave[0][part][objectName]&#x3D;Part  * &amp;invoicePosSave[0][quantity]&#x3D;  * &amp;invoicePosSave[0][unity][id]&#x3D;  * &amp;invoicePosSave[0][unity][objectName]&#x3D;Unity  * &amp;invoicePosSave[0][taxRate]&#x3D;19  * &amp;invoicePosSave[0][objectName]&#x3D;InvoicePos  * &amp;invoicePosSave[0][mapAll]&#x3D;true  * &amp;invoicePosSave[0][price]&#x3D;  * &amp;invoicePosDelete&#x3D;null    Quick reference Discounts:  * &amp;discountSave[0][discount]&#x3D;true  * &amp;discountSave[0][text]&#x3D;  * &amp;discountSave[0][percentage]&#x3D;  * &amp;discountSave[0][value]&#x3D;  * &amp;discountSave[0][objectName]&#x3D;Discounts  * &amp;discountSave[0][mapAll]&#x3D;true  * &amp;discountDelete&#x3D;null    You can also use additional parameters for creating an invoice in the same way by adding them in the format: **invoice[yourParameter]** </param>
        /// <returns>ModelInvoiceFactory</returns>
        ModelInvoiceFactory SaveInvoice(string body);
        /// <summary>
        /// Send an invoice via Email Calls sendViaEmail in Invoice.php
        /// </summary>
        /// <param name="id">id of invoice you want to send via Email</param>
        /// <param name="body">Change the desired values after the parameters and remove the quotation marks. You can also add &#39;additionalAttachments&#39;, &#39;ccEmail&#x3D;&#39; and &#39;bccEmail&#39;    Please note: additionalAttachments is a String containing document id&#39;s (of existing documents!)</param>
        /// <returns>ModelEmail</returns>
        ModelEmail SendInvoiceViaEmail(int? id, string body);
        /// <summary>
        /// Send an invoice via Letter Calls sendViaPost in Invoice.php
        /// </summary>
        /// <param name="id">id of invoice you want to send via Letter</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice SendInvoiceViaPost(int? id);
        /// <summary>
        /// Update an existing invoice Calls Invoice.php
        /// </summary>
        /// <param name="id">id of invoice you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create invoice.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param>
        /// <returns>ModelInvoice</returns>
        ModelInvoice UpdateInvoice(int? id, string body);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InvoiceApi : IInvoiceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InvoiceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoiceApi(String basePath)
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
        /// Create a new invoice Calls Invoice.php 
        /// </summary>
        /// <param name="body">To create an invoice, simply enter desired values after parameter&#x3D; and remove the quotation marks.    Be aware that you can&#39;t use all the parameters included in the Model_Invoice, as creating an invoice involves other functions.    So for example, adding a sumNet/Gross/etc. does not work as they normally get their value from the product which is involved in the invoice    The product/part in this case is handled in the Model_InvoicePos which makes a call to Model_Part.    In Invoice.php there is only a function &#39;addPosition&#39; which makes the call to InvoicePos.php</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice AddInvoice(string body)
        {

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddInvoice");


            var path = "/Invoice";
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
                throw new ApiException((int)response.StatusCode, "Error calling AddInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AddInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

        /// <summary>
        /// Cancel an invoice Calls cancel() in Invoice.php to cancel an invoice and creates a cancellation invoice  
        /// </summary>
        /// <param name="id">Id of invoice which you want to cancel</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice CancelInvoice(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelInvoice");


            var path = "/Invoice/{id}/cancel";
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
                throw new ApiException((int)response.StatusCode, "Error calling CancelInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CancelInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

        /// <summary>
        /// Create an new invoice from an existing order With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the Model.php itself still constructs the model however new instances of the model are created trough the Factory.php    So for example when you create a new invoice it wont be saved by a POST request with &#39;/Invoice?para1&#x3D;&amp;...&#39; but with the saveInvoice function in Factory.php &#39;Voucher/Factory/saveInvoice?para1&#x3D;&#39;
        /// </summary>
        /// <param name="body">Takes an existing Model_Order and creates an invoice with positions and discounts from it. Enter your values after parameter&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice CreateInvoiceFromOrder(string body)
        {

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateInvoiceFromOrder");


            var path = "/Invoice/Factory/createInvoiceFromOrder";
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
                throw new ApiException((int)response.StatusCode, "Error calling CreateInvoiceFromOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateInvoiceFromOrder: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

        /// <summary>
        /// Create an invoice reminder With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the Model.php itself still constructs the model however new instances of the model are created trough the Factory.php    So for example when you create a new invoice it wont be saved by a POST request with &#39;/Invoice?para1&#x3D;&amp;...&#39; but with the saveInvoice function in Factory.php &#39;Voucher/Factory/saveInvoice?para1&#x3D;&#39;
        /// </summary>
        /// <param name="body">Takes an existing Model_Invoice and creates a reminder for it.    Note that actually creating a reminder would require to save the rendered invoice reminder so this is not possible by calling the api directly.    However for demonstration purposes you can still call the function by appending an invoice id after invoice[id]&#x3D; and removing the quotation marks.</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice CreateInvoiceReminder(string body)
        {

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateInvoiceReminder");


            var path = "/Invoice/Factory/createInvoiceReminder";
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
                throw new ApiException((int)response.StatusCode, "Error calling CreateInvoiceReminder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateInvoiceReminder: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

        /// <summary>
        /// Delete an existing invoice Calls the delete() function in Invoice.php
        /// </summary>
        /// <param name="id">id of invoice you want to delete</param> 
        /// <returns></returns>            
        public void DeleteInvoice(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteInvoice");


            var path = "/Invoice/{id}";
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
                throw new ApiException((int)response.StatusCode, "Error calling DeleteInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Duplicate an existing invoice Calls duplicate() in Invoice.php to duplicate an existing invoice
        /// </summary>
        /// <param name="id">id of invoice you want to duplicate</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice DuplicateInvoice(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DuplicateInvoice");


            var path = "/Invoice/{id}/duplicate";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DuplicateInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DuplicateInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

        /// <summary>
        /// Get amount of an invoice including reminders Calls the getTotalInvoiceReminderAndInvoiceAmount function in /Invoice/Factory/ to get the amount of the invoice including its reminders.
        /// </summary>
        /// <param name="invoiceId">id of the invoice you want to get the total amount for</param> 
        /// <param name="invoiceObjectName"></param> 
        /// <returns></returns>            
        public void GetInvoiceAndReminderAmount(int? invoiceId, string invoiceObjectName)
        {

            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling GetInvoiceAndReminderAmount");

            // verify the required parameter 'invoiceObjectName' is set
            if (invoiceObjectName == null) throw new ApiException(400, "Missing required parameter 'invoiceObjectName' when calling GetInvoiceAndReminderAmount");


            var path = "/Invoice/Factory/getTotalInvoiceReminderAndInvoiceAmount";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (invoiceId != null) queryParams.Add("invoice[id]", ApiClient.ParameterToString(invoiceId)); // query parameter
            if (invoiceObjectName != null) queryParams.Add("invoice[objectName]", ApiClient.ParameterToString(invoiceObjectName)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetInvoiceAndReminderAmount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetInvoiceAndReminderAmount: " + response.ErrorMessage, response.ErrorMessage);
        }

        /// <summary>
        /// Get the invoice as a PDF Calls getPdf in Invoice.php
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the PDF</param> 
        /// <param name="download">If true PDF will return as filestream otherwise as json object the content base64 encoded</param> 
        /// <returns></returns>            
        public void GetInvoiceAsPdf(int? id, bool? download)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetInvoiceAsPdf");

            // verify the required parameter 'download' is set
            if (download == null) throw new ApiException(400, "Missing required parameter 'download' when calling GetInvoiceAsPdf");


            var path = "/Invoice/{id}/getPdf";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (download != null) queryParams.Add("download", ApiClient.ParameterToString(download)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetInvoiceAsPdf: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetInvoiceAsPdf: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }


        /// <summary>
        /// Get (monetary) amount of all reminders of an invoice Calls the getTotalInvoiceReminderAmount function in /Invoice/Factory/ to get the amount of all reminders of an invoice.
        /// </summary>
        /// <param name="invoiceId">id of the invoice you want to get the reminder amount for</param> 
        /// <param name="invoiceObjectName"></param> 
        /// <returns></returns>            
        public void GetInvoiceReminderAmount(int? invoiceId, string invoiceObjectName)
        {

            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling GetInvoiceReminderAmount");

            // verify the required parameter 'invoiceObjectName' is set
            if (invoiceObjectName == null) throw new ApiException(400, "Missing required parameter 'invoiceObjectName' when calling GetInvoiceReminderAmount");


            var path = "/Invoice/Factory/getTotalInvoiceReminderAmount";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (invoiceId != null) queryParams.Add("invoice[id]", ApiClient.ParameterToString(invoiceId)); // query parameter
            if (invoiceObjectName != null) queryParams.Add("invoice[objectName]", ApiClient.ParameterToString(invoiceObjectName)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetInvoiceReminderAmount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetInvoiceReminderAmount: " + response.ErrorMessage, response.ErrorMessage);
        }

        /// <summary>
        /// Get an overview of all invoices Calls Invoice.php to get necessary variables. However, not all variables get their value from Invoice.php directly but from other models like Model_InvoicePos or Model_Part
        /// </summary>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned invoices start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice GetInvoices(int? limit, int? offset, List<string> embed)
        {


            var path = "/Invoice";
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
                throw new ApiException((int)response.StatusCode, "Error calling GetInvoices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetInvoices: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

        /// <summary>
        /// Get the next invoice number 
        /// </summary>
        /// <param name="invoiceType">defines the type of invoice you want to get the next number from</param> 
        /// <param name="useNextNumber">By default this is true, so the invoiceNumber will increase by one otherwise the invoiceNumber will not change</param> 
        /// <returns></returns>            
        public void GetNextInvoiceNumber(string invoiceType, bool? useNextNumber)
        {

            // verify the required parameter 'invoiceType' is set
            if (invoiceType == null) throw new ApiException(400, "Missing required parameter 'invoiceType' when calling GetNextInvoiceNumber");

            // verify the required parameter 'useNextNumber' is set
            if (useNextNumber == null) throw new ApiException(400, "Missing required parameter 'useNextNumber' when calling GetNextInvoiceNumber");


            var path = "/Invoice/Factory/getNextInvoiceNumber";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (invoiceType != null) queryParams.Add("invoiceType", ApiClient.ParameterToString(invoiceType)); // query parameter
            if (useNextNumber != null) queryParams.Add("useNextNumber", ApiClient.ParameterToString(useNextNumber)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetNextInvoiceNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetNextInvoiceNumber: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Add a position to an existing invoice Calls addPosition() in Invoice.php to add a position to an invoice.    This function is not required anymore as there is a function for creating Invoices in Invoice/Factory which includes adding the position.
        /// </summary>
        /// <param name="id">id of invoice you want to add a position to</param> 
        /// <param name="body">To add a position, simply enter desired values after parameter&#x3D; and remove the quotation marks</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice InvoiceAddPosition(int? id, string body)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceAddPosition");


            var path = "/Invoice/{id}/addPosition";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceAddPosition: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceAddPosition: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

        /// <summary>
        /// Book amount for an invoice Calls bookAmmount() in Invoice.php to book an invoice amount
        /// </summary>
        /// <param name="id">Id of invoice of which you want to book an amount</param> 
        /// <param name="ammount">amount which should be booked</param> 
        /// <param name="date">booking date</param> 
        /// <param name="body">Optionally, you can enter a checkAccount and checkAccountTransaction here.    Be aware that if you dont define a checkAccount / checkAccountTransaction you need to remove the part from the body or remove everything except the quotation marks if you dont want to define anything at all!</param> 
        /// <returns>ModelInvoiceLog</returns>            
        public ModelInvoiceLog InvoiceBookAmount(int? id, int? ammount, string date, string body)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceBookAmount");

            // verify the required parameter 'ammount' is set
            if (ammount == null) throw new ApiException(400, "Missing required parameter 'ammount' when calling InvoiceBookAmount");

            // verify the required parameter 'date' is set
            if (date == null) throw new ApiException(400, "Missing required parameter 'date' when calling InvoiceBookAmount");


            var path = "/Invoice/{id}/bookAmmount";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (ammount != null) queryParams.Add("ammount", ApiClient.ParameterToString(ammount)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceBookAmount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceBookAmount: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoiceLog)ApiClient.Deserialize(response.Content, typeof(ModelInvoiceLog), response.Headers);
        }

        /// <summary>
        /// Calculate total sum of all invoices of current query Calls calcTotalDebit() in Invoice.php to calculate total sum of all invoices of current query
        /// </summary>
        /// <returns></returns>            
        public void InvoiceCalcTotalDebit()
        {


            var path = "/Invoice/calcTotalDebit";
            path = path.Replace("{format}", "json");

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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceCalcTotalDebit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceCalcTotalDebit: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get dunning level of an invoice Calls calculateDunningLevel() in Invoice.php to get the dunning level of an invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the dunning level</param> 
        /// <returns></returns>            
        public void InvoiceCalculateDunningLevel(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceCalculateDunningLevel");


            var path = "/Invoice/{id}/calculateDunningLevel";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceCalculateDunningLevel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceCalculateDunningLevel: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Change status of an invoice Calls changeStatus() in Invoice.php to book an invoice amount
        /// </summary>
        /// <param name="id">Id of invoice of which you want to book an amount</param> 
        /// <param name="value">desired status</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice InvoiceChangeStatus(int? id, int? value)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceChangeStatus");

            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling InvoiceChangeStatus");


            var path = "/Invoice/{id}/changeStatus";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceChangeStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceChangeStatus: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

        /// <summary>
        /// Returns if an invoice is cancled Calls getCancled() in Invoice.php to know if an invoice is cancled
        /// </summary>
        /// <param name="id">Id of invoice of which you want to know if it is cancled</param> 
        /// <returns></returns>            
        public void InvoiceGetCancled(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetCancled");


            var path = "/Invoice/{id}/getCancled";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetCancled: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetCancled: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get check account transaction logs about a specified invoice Calls getCheckAccountTransactionLogs() in Invoice.php to get check account transaction logs about the invoice
        /// </summary>
        /// <param name="id">Id of the invoice of which you want to get the check account transaction logs</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelCheckAccountTransactionLog</returns>            
        public ModelCheckAccountTransactionLog InvoiceGetCheckAccountTransactionLogs(int? id, List<string> embed)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetCheckAccountTransactionLogs");


            var path = "/Invoice/{id}/getCheckAccountTransactionLogs";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetCheckAccountTransactionLogs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetCheckAccountTransactionLogs: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelCheckAccountTransactionLog)ApiClient.Deserialize(response.Content, typeof(ModelCheckAccountTransactionLog), response.Headers);
        }

        /// <summary>
        /// Get check account transactions of a specified invoice Calls getCheckAccountTransactions() in Invoice.php to get check account transactions of the invoice
        /// </summary>
        /// <param name="id">Id of the invoice of which you want to get the check account transactions</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelCheckAccountTransaction</returns>            
        public ModelCheckAccountTransaction InvoiceGetCheckAccountTransactions(int? id, List<string> embed)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetCheckAccountTransactions");


            var path = "/Invoice/{id}/getCheckAccountTransactions";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetCheckAccountTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetCheckAccountTransactions: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelCheckAccountTransaction)ApiClient.Deserialize(response.Content, typeof(ModelCheckAccountTransaction), response.Headers);
        }

        /// <summary>
        /// Get debit of an invoice Calls getDebit() in Invoice.php to get debit of an invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the debit</param> 
        /// <returns></returns>            
        public void InvoiceGetDebit(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetDebit");


            var path = "/Invoice/{id}/getDebit";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetDebit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetDebit: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get if an invoice is delinquent Calls getDelinquent() in Invoice.php to get if an invoice is delinquent
        /// </summary>
        /// <param name="id">Id of invoice of which you want to know if its delinquent</param> 
        /// <returns></returns>            
        public void InvoiceGetDelinquent(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetDelinquent");


            var path = "/Invoice/{id}/getDelinquent";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetDelinquent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetDelinquent: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get the discounts of a specified invoice Calls getDiscounts() in Invoice.php
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the discounts</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelDiscounts</returns>            
        public ModelDiscounts InvoiceGetDiscounts(int? id, List<string> embed)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetDiscounts");


            var path = "/Invoice/{id}/getDiscounts";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetDiscounts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetDiscounts: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelDiscounts)ApiClient.Deserialize(response.Content, typeof(ModelDiscounts), response.Headers);
        }

        /// <summary>
        /// Get document of an invoice Calls getDocument() in Invoice.php to get the document of an invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the document</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns></returns>            
        public void InvoiceGetDocument(int? id, List<string> embed)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetDocument");


            var path = "/Invoice/{id}/getDocument";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetDocument: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get invoice dunnings Calls getDunnings() in Invoice.php to get the dunnings of an invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the dunnings</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice InvoiceGetDunnings(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetDunnings");


            var path = "/Invoice/{id}/getDunnings";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetDunnings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetDunnings: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

        /// <summary>
        /// Get the feed of a specified invoice Calls getFeed() in Invoice.php
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the feed</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelFeed</returns>            
        public ModelFeed InvoiceGetFeed(int? id, List<string> embed)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetFeed");


            var path = "/Invoice/{id}/getFeed";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetFeed: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetFeed: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelFeed)ApiClient.Deserialize(response.Content, typeof(ModelFeed), response.Headers);
        }

        /// <summary>
        /// Get final invoice id Calls getFinalInvoiceId() in Invoice.php to get final invoice id of the invoice chain
        /// </summary>
        /// <param name="id">Id of the invoice of which you want to get the final invoice id</param> 
        /// <returns></returns>            
        public void InvoiceGetFinalInvoiceId(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetFinalInvoiceId");


            var path = "/Invoice/{id}/getFinalInvoiceId";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetFinalInvoiceId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetFinalInvoiceId: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Returns if the invoice is partially payed Calls getIsPartiallyPaid() in Invoice.php
        /// </summary>
        /// <param name="id">Id of invoice of which you want to know if it is partially paid</param> 
        /// <returns></returns>            
        public void InvoiceGetIsPartiallyPaid(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetIsPartiallyPaid");


            var path = "/Invoice/{id}/getIsPartiallyPaid";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetIsPartiallyPaid: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetIsPartiallyPaid: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get last dunning date of invoice as timestamp Calls getLastDunningDate() in Invoice.php to get the date of the last dunning of an invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the date of the last dunning</param> 
        /// <returns></returns>            
        public void InvoiceGetLastDunningDate(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetLastDunningDate");


            var path = "/Invoice/{id}/getLastDunningDate";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetLastDunningDate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetLastDunningDate: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get partial invoices of a specified invoice Calls getPartialInvoices() in Invoice.php to get partial invoices of the invoice
        /// </summary>
        /// <param name="id">Id of the invoice of which you want to get the partial invoices</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice InvoiceGetPartialInvoices(int? id, List<string> embed)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetPartialInvoices");


            var path = "/Invoice/{id}/getPartialInvoices";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetPartialInvoices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetPartialInvoices: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

        /// <summary>
        /// Get the positions of a specified invoice Calls getPositions() in Invoice.php
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the positions</param> 
        /// <param name="limit">limits the number of entries returned</param> 
        /// <param name="offset">set the index where the returned entries start</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelInvoicePos</returns>            
        public ModelInvoicePos InvoiceGetPositions(int? id, int? limit, int? offset, List<string> embed)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetPositions");


            var path = "/Invoice/{id}/getPositions";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetPositions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetPositions: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoicePos)ApiClient.Deserialize(response.Content, typeof(ModelInvoicePos), response.Headers);
        }

        /// <summary>
        /// Get related objects of a specified invoice Calls getRelatedObjects() in Invoice.php to get related objects of the invoice
        /// </summary>
        /// <param name="id">Id of the invoice of which you want to get the related objects</param> 
        /// <param name="includeItself">Define if the related objects include the invoice itself</param> 
        /// <param name="sortByType">Define if you want the related objects sorted by type</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns></returns>            
        public void InvoiceGetRelatedObjects(int? id, bool? includeItself, bool? sortByType, List<string> embed)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetRelatedObjects");


            var path = "/Invoice/{id}/getRelatedObjects";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetRelatedObjects: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetRelatedObjects: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get swiss esr Calls getSwissEsr() in Invoice.php to get the swiss esr
        /// </summary>
        /// <returns></returns>            
        public void InvoiceGetSwissEsr()
        {


            var path = "/Invoice/getSwissEsr";
            path = path.Replace("{format}", "json");

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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetSwissEsr: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetSwissEsr: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get swiss esr data Calls getSwissEsrData() in Invoice.php to get the swiss esr data
        /// </summary>
        /// <returns></returns>            
        public void InvoiceGetSwissEsrData()
        {


            var path = "/Invoice/getSwissEsrData";
            path = path.Replace("{format}", "json");

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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetSwissEsrData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetSwissEsrData: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get the tags of a specified invoice Calls getTags() in Invoice.php
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the tags</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelTag</returns>            
        public ModelTag InvoiceGetTags(int? id, List<string> embed)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetTags");


            var path = "/Invoice/{id}/getTags";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetTags: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetTags: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelTag)ApiClient.Deserialize(response.Content, typeof(ModelTag), response.Headers);
        }

        /// <summary>
        /// Get invoice tax amount in invoice currency Calls getTax() in Invoice.php to get tax amount of invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the invoice tax amount</param> 
        /// <param name="invoiceAmount">Determines whether to use sumTax from invoice or sumTaxAccounting</param> 
        /// <returns></returns>            
        public void InvoiceGetTax(int? id, bool? invoiceAmount)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetTax");


            var path = "/Invoice/{id}/getTax";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (invoiceAmount != null) queryParams.Add("invoiceAmount", ApiClient.ParameterToString(invoiceAmount)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetTax: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetTax: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get tax groups of invoice Calls getTaxGroupes() in Invoice.php to get tax groups
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the tax groups</param> 
        /// <returns></returns>            
        public void InvoiceGetTaxGroups(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetTaxGroups");


            var path = "/Invoice/{id}/getTaxGroupes";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetTaxGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetTaxGroups: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get gross invoice amount in invoice currency Calls getTotal() in Invoice.php to get gross amount of invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the gross invoice amount</param> 
        /// <param name="invoiceAmount">Determines whether to use sumGross from invoice or sumGrossAccounting</param> 
        /// <returns></returns>            
        public void InvoiceGetTotal(int? id, bool? invoiceAmount)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetTotal");


            var path = "/Invoice/{id}/getTotal";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (invoiceAmount != null) queryParams.Add("invoiceAmount", ApiClient.ParameterToString(invoiceAmount)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetTotal: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetTotal: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get total invoice amount in invoice currency Calls getTotalCalc() in Invoice.php to get tax groups
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the invoice amount in invoice currency</param> 
        /// <returns></returns>            
        public void InvoiceGetTotalCalc(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetTotalCalc");


            var path = "/Invoice/{id}/getTotalCalc";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetTotalCalc: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetTotalCalc: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get total net invoice amount in invoice currency Calls getTotalNet() in Invoice.php to get total net amount of invoice
        /// </summary>
        /// <param name="id">Id of invoice of which you want to get the total net invoice amount</param> 
        /// <param name="invoiceAmount">Determines whether to use sumNet from invoice or sumNetAccounting</param> 
        /// <param name="withoutDiscounts">Determines whether the total net is calculated with or without the discounts</param> 
        /// <returns></returns>            
        public void InvoiceGetTotalNet(int? id, bool? invoiceAmount, bool? withoutDiscounts)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetTotalNet");


            var path = "/Invoice/{id}/getTotalNet";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (invoiceAmount != null) queryParams.Add("invoiceAmount", ApiClient.ParameterToString(invoiceAmount)); // query parameter
            if (withoutDiscounts != null) queryParams.Add("withoutDiscounts", ApiClient.ParameterToString(withoutDiscounts)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetTotalNet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetTotalNet: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Returns if the specified invoice has discounts Calls hasDiscounts() in Invoice.php
        /// </summary>
        /// <param name="id">Id of invoice of which you want to know if it has discounts</param> 
        /// <returns></returns>            
        public void InvoiceHasDiscounts(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceHasDiscounts");


            var path = "/Invoice/{id}/hasDiscounts";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceHasDiscounts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceHasDiscounts: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Returns if the specified invoice is the origin of an order Calls isOrigin() in Invoice.php to find out if the invoice is the origin of an order
        /// </summary>
        /// <param name="id">Id of invoice of which you want to know if it is the origin of an order</param> 
        /// <returns></returns>            
        public void InvoiceIsOrigin(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceIsOrigin");


            var path = "/Invoice/{id}/isOrigin";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceIsOrigin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceIsOrigin: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Marks an invoice as sent Calls markAsSent() in Invoice.php to mark an invoice as sent
        /// </summary>
        /// <param name="id">Id of invoice which you want to mark as sent</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice InvoiceMarkAsSent(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceMarkAsSent");


            var path = "/Invoice/{id}/markAsSent";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceMarkAsSent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceMarkAsSent: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

        /// <summary>
        /// Refund an already payed invoice amount Calls refundAmmount() in Invoice.php to refund an invoice amount
        /// </summary>
        /// <param name="id">Id of invoice of which you want to refund the amount</param> 
        /// <param name="ammount">amount which should be refunded</param> 
        /// <param name="date">booking date</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice InvoiceRefundAmount(int? id, int? ammount, string date)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceRefundAmount");

            // verify the required parameter 'ammount' is set
            if (ammount == null) throw new ApiException(400, "Missing required parameter 'ammount' when calling InvoiceRefundAmount");

            // verify the required parameter 'date' is set
            if (date == null) throw new ApiException(400, "Missing required parameter 'date' when calling InvoiceRefundAmount");


            var path = "/Invoice/{id}/refundAmmount";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (ammount != null) queryParams.Add("ammount", ApiClient.ParameterToString(ammount)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceRefundAmount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceRefundAmount: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

        /// <summary>
        /// Render invoice document on docserver and return metadata Calls render() in Invoice.php to render invoice document on docserver and return the metadata
        /// </summary>
        /// <param name="id">Id of invoice of which you want to render the document and get the metadata</param> 
        /// <returns></returns>            
        public void InvoiceRender(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceRender");


            var path = "/Invoice/{id}/render";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceRender: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceRender: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Send invoice by desired method Calls sendBy() in Invoice.php to send an invoice by the desired method
        /// </summary>
        /// <param name="id">Id of invoice which you want to send</param> 
        /// <param name="sendType">desired send type, available are: VM &#x3D; Mail, VP &#x3D; Post, VPDF &#x3D; PDF, PRN &#x3D; Print</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice InvoiceSendBy(int? id, string sendType)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceSendBy");

            // verify the required parameter 'sendType' is set
            if (sendType == null) throw new ApiException(400, "Missing required parameter 'sendType' when calling InvoiceSendBy");


            var path = "/Invoice/{id}/sendBy";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceSendBy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceSendBy: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

        /// <summary>
        /// Create a new invoice (with / without invoice positions and discounts)  With the new version of sevdesk some models are not created by calling the model.php directly but by calling the factory.php because of better performance and flexibility.    Basically the model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new invoice it wont be saved by a POST request with &#39;/Invoice?para1&#x3D;&amp;...&#39; but with the saveInvoice function in Factory.php &#39;Voucher/Factory/saveInvoice?para1&#x3D;&#39;
        /// </summary>
        /// <param name="body">The saveInvoice function in Invoice/Factory.php combines both Invoice and InvoicePos with all their HTTP-methods.    It is now possible to **simultaneously** create an invoice with its position and discount.    To simply (only) create an invoice you can use the given parameters and concatenate your values.    For also adding an invoice position or a discount refer to the corresponding **quick reference** below.    The parameters you find there are **needed** for creating an invoice position / discount. Just concatenate them to the existing invoice / invoicePosSave parameters.    You can also find additional (optional) parameters in the **Models** section.    Quick reference InvoicePos:  * &amp;invoicePosSave[0][part][id]&#x3D;  * &amp;invoicePosSave[0][part][objectName]&#x3D;Part  * &amp;invoicePosSave[0][quantity]&#x3D;  * &amp;invoicePosSave[0][unity][id]&#x3D;  * &amp;invoicePosSave[0][unity][objectName]&#x3D;Unity  * &amp;invoicePosSave[0][taxRate]&#x3D;19  * &amp;invoicePosSave[0][objectName]&#x3D;InvoicePos  * &amp;invoicePosSave[0][mapAll]&#x3D;true  * &amp;invoicePosSave[0][price]&#x3D;  * &amp;invoicePosDelete&#x3D;null    Quick reference Discounts:  * &amp;discountSave[0][discount]&#x3D;true  * &amp;discountSave[0][text]&#x3D;  * &amp;discountSave[0][percentage]&#x3D;  * &amp;discountSave[0][value]&#x3D;  * &amp;discountSave[0][objectName]&#x3D;Discounts  * &amp;discountSave[0][mapAll]&#x3D;true  * &amp;discountDelete&#x3D;null    You can also use additional parameters for creating an invoice in the same way by adding them in the format: **invoice[yourParameter]** </param> 
        /// <returns>ModelInvoiceFactory</returns>            
        public ModelInvoiceFactory SaveInvoice(string body)
        {

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SaveInvoice");


            var path = "/Invoice/Factory/saveInvoice";
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
                throw new ApiException((int)response.StatusCode, "Error calling SaveInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling SaveInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoiceFactory)ApiClient.Deserialize(response.Content, typeof(ModelInvoiceFactory), response.Headers);
        }

        /// <summary>
        /// Send an invoice via Email Calls sendViaEmail in Invoice.php
        /// </summary>
        /// <param name="id">id of invoice you want to send via Email</param> 
        /// <param name="body">Change the desired values after the parameters and remove the quotation marks. You can also add &#39;additionalAttachments&#39;, &#39;ccEmail&#x3D;&#39; and &#39;bccEmail&#39;    Please note: additionalAttachments is a String containing document id&#39;s (of existing documents!)</param> 
        /// <returns>ModelEmail</returns>            
        public ModelEmail SendInvoiceViaEmail(int? id, string body)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SendInvoiceViaEmail");

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SendInvoiceViaEmail");


            var path = "/Invoice/{id}/sendViaEmail";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling SendInvoiceViaEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling SendInvoiceViaEmail: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelEmail)ApiClient.Deserialize(response.Content, typeof(ModelEmail), response.Headers);
        }

        /// <summary>
        /// Send an invoice via Letter Calls sendViaPost in Invoice.php
        /// </summary>
        /// <param name="id">id of invoice you want to send via Letter</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice SendInvoiceViaPost(int? id)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SendInvoiceViaPost");


            var path = "/Invoice/{id}/sendViaPost";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling SendInvoiceViaPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling SendInvoiceViaPost: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

        /// <summary>
        /// Update an existing invoice Calls Invoice.php
        /// </summary>
        /// <param name="id">id of invoice you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please refer to the description from create invoice.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param> 
        /// <returns>ModelInvoice</returns>            
        public ModelInvoice UpdateInvoice(int? id, string body)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateInvoice");


            var path = "/Invoice/{id}";
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
                throw new ApiException((int)response.StatusCode, "Error calling UpdateInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return (ModelInvoice)ApiClient.Deserialize(response.Content, typeof(ModelInvoice), response.Headers);
        }

    }
}
