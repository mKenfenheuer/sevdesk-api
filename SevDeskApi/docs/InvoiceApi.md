# SevDeskApi.Api.InvoiceApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInvoice**](InvoiceApi.md#addinvoice) | **POST** /Invoice | Create a new invoice
[**CancelInvoice**](InvoiceApi.md#cancelinvoice) | **GET** /Invoice/{id}/cancel | Cancel an invoice
[**CreateInvoiceFromOrder**](InvoiceApi.md#createinvoicefromorder) | **POST** /Invoice/Factory/createInvoiceFromOrder | Create an new invoice from an existing order
[**CreateInvoiceReminder**](InvoiceApi.md#createinvoicereminder) | **POST** /Invoice/Factory/createInvoiceReminder | Create an invoice reminder
[**DeleteInvoice**](InvoiceApi.md#deleteinvoice) | **DELETE** /Invoice/{id} | Delete an existing invoice
[**DuplicateInvoice**](InvoiceApi.md#duplicateinvoice) | **POST** /Invoice/{id}/duplicate | Duplicate an existing invoice
[**GetInvoiceAndReminderAmount**](InvoiceApi.md#getinvoiceandreminderamount) | **GET** /Invoice/Factory/getTotalInvoiceReminderAndInvoiceAmount | Get amount of an invoice including reminders
[**GetInvoiceAsPdf**](InvoiceApi.md#getinvoiceaspdf) | **GET** /Invoice/{id}/getPdf | Get the invoice as a PDF
[**GetInvoiceReminderAmount**](InvoiceApi.md#getinvoicereminderamount) | **GET** /Invoice/Factory/getTotalInvoiceReminderAmount | Get (monetary) amount of all reminders of an invoice
[**GetInvoices**](InvoiceApi.md#getinvoices) | **GET** /Invoice | Get an overview of all invoices
[**GetNextInvoiceNumber**](InvoiceApi.md#getnextinvoicenumber) | **GET** /Invoice/Factory/getNextInvoiceNumber | Get the next invoice number
[**InvoiceAddPosition**](InvoiceApi.md#invoiceaddposition) | **PUT** /Invoice/{id}/addPosition | Add a position to an existing invoice
[**InvoiceBookAmount**](InvoiceApi.md#invoicebookamount) | **PUT** /Invoice/{id}/bookAmmount | Book amount for an invoice
[**InvoiceCalcTotalDebit**](InvoiceApi.md#invoicecalctotaldebit) | **GET** /Invoice/calcTotalDebit | Calculate total sum of all invoices of current query
[**InvoiceCalculateDunningLevel**](InvoiceApi.md#invoicecalculatedunninglevel) | **GET** /Invoice/{id}/calculateDunningLevel | Get dunning level of an invoice
[**InvoiceChangeStatus**](InvoiceApi.md#invoicechangestatus) | **PUT** /Invoice/{id}/changeStatus | Change status of an invoice
[**InvoiceGetCancled**](InvoiceApi.md#invoicegetcancled) | **GET** /Invoice/{id}/getCancled | Returns if an invoice is cancled
[**InvoiceGetCheckAccountTransactionLogs**](InvoiceApi.md#invoicegetcheckaccounttransactionlogs) | **GET** /Invoice/{id}/getCheckAccountTransactionLogs | Get check account transaction logs about a specified invoice
[**InvoiceGetCheckAccountTransactions**](InvoiceApi.md#invoicegetcheckaccounttransactions) | **GET** /Invoice/{id}/getCheckAccountTransactions | Get check account transactions of a specified invoice
[**InvoiceGetDebit**](InvoiceApi.md#invoicegetdebit) | **GET** /Invoice/{id}/getDebit | Get debit of an invoice
[**InvoiceGetDelinquent**](InvoiceApi.md#invoicegetdelinquent) | **GET** /Invoice/{id}/getDelinquent | Get if an invoice is delinquent
[**InvoiceGetDiscounts**](InvoiceApi.md#invoicegetdiscounts) | **GET** /Invoice/{id}/getDiscounts | Get the discounts of a specified invoice
[**InvoiceGetDocument**](InvoiceApi.md#invoicegetdocument) | **GET** /Invoice/{id}/getDocument | Get document of an invoice
[**InvoiceGetDunnings**](InvoiceApi.md#invoicegetdunnings) | **GET** /Invoice/{id}/getDunnings | Get invoice dunnings
[**InvoiceGetFeed**](InvoiceApi.md#invoicegetfeed) | **GET** /Invoice/{id}/getFeed | Get the feed of a specified invoice
[**InvoiceGetFinalInvoiceId**](InvoiceApi.md#invoicegetfinalinvoiceid) | **GET** /Invoice/{id}/getFinalInvoiceId | Get final invoice id
[**InvoiceGetIsPartiallyPaid**](InvoiceApi.md#invoicegetispartiallypaid) | **GET** /Invoice/{id}/getIsPartiallyPaid | Returns if the invoice is partially payed
[**InvoiceGetLastDunningDate**](InvoiceApi.md#invoicegetlastdunningdate) | **GET** /Invoice/{id}/getLastDunningDate | Get last dunning date of invoice as timestamp
[**InvoiceGetPartialInvoices**](InvoiceApi.md#invoicegetpartialinvoices) | **GET** /Invoice/{id}/getPartialInvoices | Get partial invoices of a specified invoice
[**InvoiceGetPositions**](InvoiceApi.md#invoicegetpositions) | **GET** /Invoice/{id}/getPositions | Get the positions of a specified invoice
[**InvoiceGetRelatedObjects**](InvoiceApi.md#invoicegetrelatedobjects) | **GET** /Invoice/{id}/getRelatedObjects | Get related objects of a specified invoice
[**InvoiceGetSwissEsr**](InvoiceApi.md#invoicegetswissesr) | **GET** /Invoice/getSwissEsr | Get swiss esr
[**InvoiceGetSwissEsrData**](InvoiceApi.md#invoicegetswissesrdata) | **GET** /Invoice/getSwissEsrData | Get swiss esr data
[**InvoiceGetTags**](InvoiceApi.md#invoicegettags) | **GET** /Invoice/{id}/getTags | Get the tags of a specified invoice
[**InvoiceGetTax**](InvoiceApi.md#invoicegettax) | **GET** /Invoice/{id}/getTax | Get invoice tax amount in invoice currency
[**InvoiceGetTaxGroups**](InvoiceApi.md#invoicegettaxgroups) | **GET** /Invoice/{id}/getTaxGroupes | Get tax groups of invoice
[**InvoiceGetTotal**](InvoiceApi.md#invoicegettotal) | **GET** /Invoice/{id}/getTotal | Get gross invoice amount in invoice currency
[**InvoiceGetTotalCalc**](InvoiceApi.md#invoicegettotalcalc) | **GET** /Invoice/{id}/getTotalCalc | Get total invoice amount in invoice currency
[**InvoiceGetTotalNet**](InvoiceApi.md#invoicegettotalnet) | **GET** /Invoice/{id}/getTotalNet | Get total net invoice amount in invoice currency
[**InvoiceHasDiscounts**](InvoiceApi.md#invoicehasdiscounts) | **GET** /Invoice/{id}/hasDiscounts | Returns if the specified invoice has discounts
[**InvoiceIsOrigin**](InvoiceApi.md#invoiceisorigin) | **GET** /Invoice/{id}/isOrigin | Returns if the specified invoice is the origin of an order
[**InvoiceMarkAsSent**](InvoiceApi.md#invoicemarkassent) | **PUT** /Invoice/{id}/markAsSent | Marks an invoice as sent
[**InvoiceRefundAmount**](InvoiceApi.md#invoicerefundamount) | **PUT** /Invoice/{id}/refundAmmount | Refund an already payed invoice amount
[**InvoiceRender**](InvoiceApi.md#invoicerender) | **POST** /Invoice/{id}/render | Render invoice document on docserver and return metadata
[**InvoiceSendBy**](InvoiceApi.md#invoicesendby) | **PUT** /Invoice/{id}/sendBy | Send invoice by desired method
[**SaveInvoice**](InvoiceApi.md#saveinvoice) | **POST** /Invoice/Factory/saveInvoice | Create a new invoice (with / without invoice positions and discounts) 
[**SendInvoiceViaEmail**](InvoiceApi.md#sendinvoiceviaemail) | **POST** /Invoice/{id}/sendViaEmail | Send an invoice via Email
[**SendInvoiceViaPost**](InvoiceApi.md#sendinvoiceviapost) | **POST** /Invoice/{id}/sendViaPost | Send an invoice via Letter
[**UpdateInvoice**](InvoiceApi.md#updateinvoice) | **PUT** /Invoice/{id} | Update an existing invoice


<a name="addinvoice"></a>
# **AddInvoice**
> ModelInvoice AddInvoice (string body)

Create a new invoice

Calls Invoice.php 

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddInvoiceExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var body = "header=&invoiceNumber=&invoiceType=&invoiceDate=&contactPerson[id]=705&contactPerson[objectName]=SevUser&contact[id]=207&contact[objectName]=Contact&discount=&discountTime=&  taxRate=&taxText=&taxType=&status=100&smallSettlement=&currency=";  // string | To create an invoice, simply enter desired values after parameter= and remove the quotation marks.    Be aware that you can't use all the parameters included in the Model_Invoice, as creating an invoice involves other functions.    So for example, adding a sumNet/Gross/etc. does not work as they normally get their value from the product which is involved in the invoice    The product/part in this case is handled in the Model_InvoicePos which makes a call to Model_Part.    In Invoice.php there is only a function 'addPosition' which makes the call to InvoicePos.php

            try
            {
                // Create a new invoice
                ModelInvoice result = apiInstance.AddInvoice(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.AddInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an invoice, simply enter desired values after parameter&#x3D; and remove the quotation marks.    Be aware that you can&#39;t use all the parameters included in the Model_Invoice, as creating an invoice involves other functions.    So for example, adding a sumNet/Gross/etc. does not work as they normally get their value from the product which is involved in the invoice    The product/part in this case is handled in the Model_InvoicePos which makes a call to Model_Part.    In Invoice.php there is only a function &#39;addPosition&#39; which makes the call to InvoicePos.php | 

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelinvoice"></a>
# **CancelInvoice**
> ModelInvoice CancelInvoice (int? id)

Cancel an invoice

Calls cancel() in Invoice.php to cancel an invoice and creates a cancellation invoice  

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class CancelInvoiceExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice which you want to cancel

            try
            {
                // Cancel an invoice
                ModelInvoice result = apiInstance.CancelInvoice(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.CancelInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice which you want to cancel | 

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createinvoicefromorder"></a>
# **CreateInvoiceFromOrder**
> ModelInvoice CreateInvoiceFromOrder (string body)

Create an new invoice from an existing order

With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the Model.php itself still constructs the model however new instances of the model are created trough the Factory.php    So for example when you create a new invoice it wont be saved by a POST request with '/Invoice?para1=&...' but with the saveInvoice function in Factory.php 'Voucher/Factory/saveInvoice?para1='

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class CreateInvoiceFromOrderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var body = body_example;  // string | Takes an existing Model_Order and creates an invoice with positions and discounts from it. Enter your values after parameter= and remove the quotation marks

            try
            {
                // Create an new invoice from an existing order
                ModelInvoice result = apiInstance.CreateInvoiceFromOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.CreateInvoiceFromOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| Takes an existing Model_Order and creates an invoice with positions and discounts from it. Enter your values after parameter&#x3D; and remove the quotation marks | 

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createinvoicereminder"></a>
# **CreateInvoiceReminder**
> ModelInvoice CreateInvoiceReminder (string body)

Create an invoice reminder

With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the Model.php itself still constructs the model however new instances of the model are created trough the Factory.php    So for example when you create a new invoice it wont be saved by a POST request with '/Invoice?para1=&...' but with the saveInvoice function in Factory.php 'Voucher/Factory/saveInvoice?para1='

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class CreateInvoiceReminderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var body = body_example;  // string | Takes an existing Model_Invoice and creates a reminder for it.    Note that actually creating a reminder would require to save the rendered invoice reminder so this is not possible by calling the api directly.    However for demonstration purposes you can still call the function by appending an invoice id after invoice[id]= and removing the quotation marks.

            try
            {
                // Create an invoice reminder
                ModelInvoice result = apiInstance.CreateInvoiceReminder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.CreateInvoiceReminder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| Takes an existing Model_Invoice and creates a reminder for it.    Note that actually creating a reminder would require to save the rendered invoice reminder so this is not possible by calling the api directly.    However for demonstration purposes you can still call the function by appending an invoice id after invoice[id]&#x3D; and removing the quotation marks. | 

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinvoice"></a>
# **DeleteInvoice**
> void DeleteInvoice (int? id)

Delete an existing invoice

Calls the delete() function in Invoice.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteInvoiceExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | id of invoice you want to delete

            try
            {
                // Delete an existing invoice
                apiInstance.DeleteInvoice(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.DeleteInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of invoice you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="duplicateinvoice"></a>
# **DuplicateInvoice**
> ModelInvoice DuplicateInvoice (int? id)

Duplicate an existing invoice

Calls duplicate() in Invoice.php to duplicate an existing invoice

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DuplicateInvoiceExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | id of invoice you want to duplicate

            try
            {
                // Duplicate an existing invoice
                ModelInvoice result = apiInstance.DuplicateInvoice(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.DuplicateInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of invoice you want to duplicate | 

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceandreminderamount"></a>
# **GetInvoiceAndReminderAmount**
>  GetInvoiceAndReminderAmount (int? invoiceId, string invoiceObjectName)

Get amount of an invoice including reminders

Calls the getTotalInvoiceReminderAndInvoiceAmount function in /Invoice/Factory/ to get the amount of the invoice including its reminders.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetInvoiceAndReminderAmountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var invoiceId = 56;  // int? | id of the invoice you want to get the total amount for
            var invoiceObjectName = invoiceObjectName_example;  // string |  (default to Invoice)

            try
            {
                // Get amount of an invoice including reminders
                 result = apiInstance.GetInvoiceAndReminderAmount(invoiceId, invoiceObjectName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.GetInvoiceAndReminderAmount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceId** | **int?**| id of the invoice you want to get the total amount for | 
 **invoiceObjectName** | **string**|  | [default to Invoice]

### Return type

[****](.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceaspdf"></a>
# **GetInvoiceAsPdf**
> void GetInvoiceAsPdf (int? id, bool? download)

Get the invoice as a PDF

Calls getPdf in Invoice.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetInvoiceAsPdfExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the PDF
            var download = true;  // bool? | If true PDF will return as filestream otherwise as json object the content base64 encoded (default to 0)

            try
            {
                // Get the invoice as a PDF
                apiInstance.GetInvoiceAsPdf(id, download);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.GetInvoiceAsPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the PDF | 
 **download** | **bool?**| If true PDF will return as filestream otherwise as json object the content base64 encoded | [default to 0]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoicereminderamount"></a>
# **GetInvoiceReminderAmount**
>  GetInvoiceReminderAmount (int? invoiceId, string invoiceObjectName)

Get (monetary) amount of all reminders of an invoice

Calls the getTotalInvoiceReminderAmount function in /Invoice/Factory/ to get the amount of all reminders of an invoice.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetInvoiceReminderAmountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var invoiceId = 56;  // int? | id of the invoice you want to get the reminder amount for
            var invoiceObjectName = invoiceObjectName_example;  // string |  (default to Invoice)

            try
            {
                // Get (monetary) amount of all reminders of an invoice
                 result = apiInstance.GetInvoiceReminderAmount(invoiceId, invoiceObjectName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.GetInvoiceReminderAmount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceId** | **int?**| id of the invoice you want to get the reminder amount for | 
 **invoiceObjectName** | **string**|  | [default to Invoice]

### Return type

[****](.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoices"></a>
# **GetInvoices**
> ModelInvoice GetInvoices (int? limit, int? offset, List<string> embed)

Get an overview of all invoices

Calls Invoice.php to get necessary variables. However, not all variables get their value from Invoice.php directly but from other models like Model_InvoicePos or Model_Part

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetInvoicesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned invoices start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all invoices
                ModelInvoice result = apiInstance.GetInvoices(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.GetInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned invoices start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnextinvoicenumber"></a>
# **GetNextInvoiceNumber**
> void GetNextInvoiceNumber (string invoiceType, bool? useNextNumber)

Get the next invoice number



### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetNextInvoiceNumberExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var invoiceType = invoiceType_example;  // string | defines the type of invoice you want to get the next number from (default to RE)
            var useNextNumber = true;  // bool? | By default this is true, so the invoiceNumber will increase by one otherwise the invoiceNumber will not change (default to true)

            try
            {
                // Get the next invoice number
                apiInstance.GetNextInvoiceNumber(invoiceType, useNextNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.GetNextInvoiceNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceType** | **string**| defines the type of invoice you want to get the next number from | [default to RE]
 **useNextNumber** | **bool?**| By default this is true, so the invoiceNumber will increase by one otherwise the invoiceNumber will not change | [default to true]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoiceaddposition"></a>
# **InvoiceAddPosition**
> ModelInvoice InvoiceAddPosition (int? id, string body)

Add a position to an existing invoice

Calls addPosition() in Invoice.php to add a position to an invoice.    This function is not required anymore as there is a function for creating Invoices in Invoice/Factory which includes adding the position.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceAddPositionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | id of invoice you want to add a position to
            var body = "quantity=&name=&text=&price=&taxRate=&part[id]=&part[objectName]=Part&unity[id]=&unity[objectName]=Unity&discount=&temporary=";  // string | To add a position, simply enter desired values after parameter= and remove the quotation marks (optional) 

            try
            {
                // Add a position to an existing invoice
                ModelInvoice result = apiInstance.InvoiceAddPosition(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceAddPosition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of invoice you want to add a position to | 
 **body** | **string**| To add a position, simply enter desired values after parameter&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicebookamount"></a>
# **InvoiceBookAmount**
> ModelInvoiceLog InvoiceBookAmount (int? id, int? ammount, string date, string body)

Book amount for an invoice

Calls bookAmmount() in Invoice.php to book an invoice amount

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceBookAmountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to book an amount
            var ammount = 56;  // int? | amount which should be booked
            var date = date_example;  // string | booking date (default to )
            var body = body_example;  // string | Optionally, you can enter a checkAccount and checkAccountTransaction here.    Be aware that if you dont define a checkAccount / checkAccountTransaction you need to remove the part from the body or remove everything except the quotation marks if you dont want to define anything at all! (optional) 

            try
            {
                // Book amount for an invoice
                ModelInvoiceLog result = apiInstance.InvoiceBookAmount(id, ammount, date, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceBookAmount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to book an amount | 
 **ammount** | **int?**| amount which should be booked | 
 **date** | **string**| booking date | [default to ]
 **body** | **string**| Optionally, you can enter a checkAccount and checkAccountTransaction here.    Be aware that if you dont define a checkAccount / checkAccountTransaction you need to remove the part from the body or remove everything except the quotation marks if you dont want to define anything at all! | [optional] 

### Return type

[**ModelInvoiceLog**](ModelInvoiceLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicecalctotaldebit"></a>
# **InvoiceCalcTotalDebit**
> void InvoiceCalcTotalDebit ()

Calculate total sum of all invoices of current query

Calls calcTotalDebit() in Invoice.php to calculate total sum of all invoices of current query

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceCalcTotalDebitExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();

            try
            {
                // Calculate total sum of all invoices of current query
                apiInstance.InvoiceCalcTotalDebit();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceCalcTotalDebit: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicecalculatedunninglevel"></a>
# **InvoiceCalculateDunningLevel**
> void InvoiceCalculateDunningLevel (int? id)

Get dunning level of an invoice

Calls calculateDunningLevel() in Invoice.php to get the dunning level of an invoice

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceCalculateDunningLevelExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the dunning level

            try
            {
                // Get dunning level of an invoice
                apiInstance.InvoiceCalculateDunningLevel(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceCalculateDunningLevel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the dunning level | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicechangestatus"></a>
# **InvoiceChangeStatus**
> ModelInvoice InvoiceChangeStatus (int? id, int? value)

Change status of an invoice

Calls changeStatus() in Invoice.php to book an invoice amount

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceChangeStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to book an amount
            var value = 56;  // int? | desired status

            try
            {
                // Change status of an invoice
                ModelInvoice result = apiInstance.InvoiceChangeStatus(id, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceChangeStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to book an amount | 
 **value** | **int?**| desired status | 

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetcancled"></a>
# **InvoiceGetCancled**
> void InvoiceGetCancled (int? id)

Returns if an invoice is cancled

Calls getCancled() in Invoice.php to know if an invoice is cancled

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetCancledExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to know if it is cancled

            try
            {
                // Returns if an invoice is cancled
                apiInstance.InvoiceGetCancled(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetCancled: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to know if it is cancled | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetcheckaccounttransactionlogs"></a>
# **InvoiceGetCheckAccountTransactionLogs**
> ModelCheckAccountTransactionLog InvoiceGetCheckAccountTransactionLogs (int? id, List<string> embed)

Get check account transaction logs about a specified invoice

Calls getCheckAccountTransactionLogs() in Invoice.php to get check account transaction logs about the invoice

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetCheckAccountTransactionLogsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of the invoice of which you want to get the check account transaction logs
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get check account transaction logs about a specified invoice
                ModelCheckAccountTransactionLog result = apiInstance.InvoiceGetCheckAccountTransactionLogs(id, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetCheckAccountTransactionLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the invoice of which you want to get the check account transaction logs | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelCheckAccountTransactionLog**](ModelCheckAccountTransactionLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetcheckaccounttransactions"></a>
# **InvoiceGetCheckAccountTransactions**
> ModelCheckAccountTransaction InvoiceGetCheckAccountTransactions (int? id, List<string> embed)

Get check account transactions of a specified invoice

Calls getCheckAccountTransactions() in Invoice.php to get check account transactions of the invoice

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetCheckAccountTransactionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of the invoice of which you want to get the check account transactions
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get check account transactions of a specified invoice
                ModelCheckAccountTransaction result = apiInstance.InvoiceGetCheckAccountTransactions(id, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetCheckAccountTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the invoice of which you want to get the check account transactions | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelCheckAccountTransaction**](ModelCheckAccountTransaction.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetdebit"></a>
# **InvoiceGetDebit**
> void InvoiceGetDebit (int? id)

Get debit of an invoice

Calls getDebit() in Invoice.php to get debit of an invoice

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetDebitExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the debit

            try
            {
                // Get debit of an invoice
                apiInstance.InvoiceGetDebit(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetDebit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the debit | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetdelinquent"></a>
# **InvoiceGetDelinquent**
> void InvoiceGetDelinquent (int? id)

Get if an invoice is delinquent

Calls getDelinquent() in Invoice.php to get if an invoice is delinquent

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetDelinquentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to know if its delinquent

            try
            {
                // Get if an invoice is delinquent
                apiInstance.InvoiceGetDelinquent(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetDelinquent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to know if its delinquent | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetdiscounts"></a>
# **InvoiceGetDiscounts**
> ModelDiscounts InvoiceGetDiscounts (int? id, List<string> embed)

Get the discounts of a specified invoice

Calls getDiscounts() in Invoice.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetDiscountsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the discounts
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get the discounts of a specified invoice
                ModelDiscounts result = apiInstance.InvoiceGetDiscounts(id, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetDiscounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the discounts | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelDiscounts**](ModelDiscounts.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetdocument"></a>
# **InvoiceGetDocument**
> void InvoiceGetDocument (int? id, List<string> embed)

Get document of an invoice

Calls getDocument() in Invoice.php to get the document of an invoice

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetDocumentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the document
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get document of an invoice
                apiInstance.InvoiceGetDocument(id, embed);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the document | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetdunnings"></a>
# **InvoiceGetDunnings**
> ModelInvoice InvoiceGetDunnings (int? id)

Get invoice dunnings

Calls getDunnings() in Invoice.php to get the dunnings of an invoice

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetDunningsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the dunnings

            try
            {
                // Get invoice dunnings
                ModelInvoice result = apiInstance.InvoiceGetDunnings(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetDunnings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the dunnings | 

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetfeed"></a>
# **InvoiceGetFeed**
> ModelFeed InvoiceGetFeed (int? id, List<string> embed)

Get the feed of a specified invoice

Calls getFeed() in Invoice.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetFeedExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the feed
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get the feed of a specified invoice
                ModelFeed result = apiInstance.InvoiceGetFeed(id, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetFeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the feed | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelFeed**](ModelFeed.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetfinalinvoiceid"></a>
# **InvoiceGetFinalInvoiceId**
> void InvoiceGetFinalInvoiceId (int? id)

Get final invoice id

Calls getFinalInvoiceId() in Invoice.php to get final invoice id of the invoice chain

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetFinalInvoiceIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of the invoice of which you want to get the final invoice id

            try
            {
                // Get final invoice id
                apiInstance.InvoiceGetFinalInvoiceId(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetFinalInvoiceId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the invoice of which you want to get the final invoice id | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetispartiallypaid"></a>
# **InvoiceGetIsPartiallyPaid**
> void InvoiceGetIsPartiallyPaid (int? id)

Returns if the invoice is partially payed

Calls getIsPartiallyPaid() in Invoice.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetIsPartiallyPaidExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to know if it is partially paid

            try
            {
                // Returns if the invoice is partially payed
                apiInstance.InvoiceGetIsPartiallyPaid(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetIsPartiallyPaid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to know if it is partially paid | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetlastdunningdate"></a>
# **InvoiceGetLastDunningDate**
> void InvoiceGetLastDunningDate (int? id)

Get last dunning date of invoice as timestamp

Calls getLastDunningDate() in Invoice.php to get the date of the last dunning of an invoice

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetLastDunningDateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the date of the last dunning

            try
            {
                // Get last dunning date of invoice as timestamp
                apiInstance.InvoiceGetLastDunningDate(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetLastDunningDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the date of the last dunning | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetpartialinvoices"></a>
# **InvoiceGetPartialInvoices**
> ModelInvoice InvoiceGetPartialInvoices (int? id, List<string> embed)

Get partial invoices of a specified invoice

Calls getPartialInvoices() in Invoice.php to get partial invoices of the invoice

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetPartialInvoicesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of the invoice of which you want to get the partial invoices
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get partial invoices of a specified invoice
                ModelInvoice result = apiInstance.InvoiceGetPartialInvoices(id, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetPartialInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the invoice of which you want to get the partial invoices | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetpositions"></a>
# **InvoiceGetPositions**
> ModelInvoicePos InvoiceGetPositions (int? id, int? limit, int? offset, List<string> embed)

Get the positions of a specified invoice

Calls getPositions() in Invoice.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetPositionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the positions
            var limit = 56;  // int? | limits the number of entries returned (optional)  (default to 100)
            var offset = 56;  // int? | set the index where the returned entries start (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get the positions of a specified invoice
                ModelInvoicePos result = apiInstance.InvoiceGetPositions(id, limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetPositions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the positions | 
 **limit** | **int?**| limits the number of entries returned | [optional] [default to 100]
 **offset** | **int?**| set the index where the returned entries start | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelInvoicePos**](ModelInvoicePos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetrelatedobjects"></a>
# **InvoiceGetRelatedObjects**
> void InvoiceGetRelatedObjects (int? id, bool? includeItself, bool? sortByType, List<string> embed)

Get related objects of a specified invoice

Calls getRelatedObjects() in Invoice.php to get related objects of the invoice

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetRelatedObjectsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of the invoice of which you want to get the related objects
            var includeItself = true;  // bool? | Define if the related objects include the invoice itself (optional)  (default to false)
            var sortByType = true;  // bool? | Define if you want the related objects sorted by type (optional)  (default to false)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get related objects of a specified invoice
                apiInstance.InvoiceGetRelatedObjects(id, includeItself, sortByType, embed);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetRelatedObjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the invoice of which you want to get the related objects | 
 **includeItself** | **bool?**| Define if the related objects include the invoice itself | [optional] [default to false]
 **sortByType** | **bool?**| Define if you want the related objects sorted by type | [optional] [default to false]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetswissesr"></a>
# **InvoiceGetSwissEsr**
> void InvoiceGetSwissEsr ()

Get swiss esr

Calls getSwissEsr() in Invoice.php to get the swiss esr

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetSwissEsrExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();

            try
            {
                // Get swiss esr
                apiInstance.InvoiceGetSwissEsr();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetSwissEsr: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetswissesrdata"></a>
# **InvoiceGetSwissEsrData**
> void InvoiceGetSwissEsrData ()

Get swiss esr data

Calls getSwissEsrData() in Invoice.php to get the swiss esr data

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetSwissEsrDataExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();

            try
            {
                // Get swiss esr data
                apiInstance.InvoiceGetSwissEsrData();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetSwissEsrData: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegettags"></a>
# **InvoiceGetTags**
> ModelTag InvoiceGetTags (int? id, List<string> embed)

Get the tags of a specified invoice

Calls getTags() in Invoice.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetTagsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the tags
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get the tags of a specified invoice
                ModelTag result = apiInstance.InvoiceGetTags(id, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the tags | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelTag**](ModelTag.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegettax"></a>
# **InvoiceGetTax**
> void InvoiceGetTax (int? id, bool? invoiceAmount)

Get invoice tax amount in invoice currency

Calls getTax() in Invoice.php to get tax amount of invoice

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetTaxExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the invoice tax amount
            var invoiceAmount = true;  // bool? | Determines whether to use sumTax from invoice or sumTaxAccounting (optional)  (default to false)

            try
            {
                // Get invoice tax amount in invoice currency
                apiInstance.InvoiceGetTax(id, invoiceAmount);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the invoice tax amount | 
 **invoiceAmount** | **bool?**| Determines whether to use sumTax from invoice or sumTaxAccounting | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegettaxgroups"></a>
# **InvoiceGetTaxGroups**
> void InvoiceGetTaxGroups (int? id)

Get tax groups of invoice

Calls getTaxGroupes() in Invoice.php to get tax groups

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetTaxGroupsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the tax groups

            try
            {
                // Get tax groups of invoice
                apiInstance.InvoiceGetTaxGroups(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetTaxGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the tax groups | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegettotal"></a>
# **InvoiceGetTotal**
> void InvoiceGetTotal (int? id, bool? invoiceAmount)

Get gross invoice amount in invoice currency

Calls getTotal() in Invoice.php to get gross amount of invoice

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetTotalExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the gross invoice amount
            var invoiceAmount = true;  // bool? | Determines whether to use sumGross from invoice or sumGrossAccounting (optional)  (default to false)

            try
            {
                // Get gross invoice amount in invoice currency
                apiInstance.InvoiceGetTotal(id, invoiceAmount);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetTotal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the gross invoice amount | 
 **invoiceAmount** | **bool?**| Determines whether to use sumGross from invoice or sumGrossAccounting | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegettotalcalc"></a>
# **InvoiceGetTotalCalc**
> void InvoiceGetTotalCalc (int? id)

Get total invoice amount in invoice currency

Calls getTotalCalc() in Invoice.php to get tax groups

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetTotalCalcExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the invoice amount in invoice currency

            try
            {
                // Get total invoice amount in invoice currency
                apiInstance.InvoiceGetTotalCalc(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetTotalCalc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the invoice amount in invoice currency | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegettotalnet"></a>
# **InvoiceGetTotalNet**
> void InvoiceGetTotalNet (int? id, bool? invoiceAmount, bool? withoutDiscounts)

Get total net invoice amount in invoice currency

Calls getTotalNet() in Invoice.php to get total net amount of invoice

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceGetTotalNetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to get the total net invoice amount
            var invoiceAmount = true;  // bool? | Determines whether to use sumNet from invoice or sumNetAccounting (optional)  (default to false)
            var withoutDiscounts = true;  // bool? | Determines whether the total net is calculated with or without the discounts (optional)  (default to false)

            try
            {
                // Get total net invoice amount in invoice currency
                apiInstance.InvoiceGetTotalNet(id, invoiceAmount, withoutDiscounts);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetTotalNet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to get the total net invoice amount | 
 **invoiceAmount** | **bool?**| Determines whether to use sumNet from invoice or sumNetAccounting | [optional] [default to false]
 **withoutDiscounts** | **bool?**| Determines whether the total net is calculated with or without the discounts | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicehasdiscounts"></a>
# **InvoiceHasDiscounts**
> void InvoiceHasDiscounts (int? id)

Returns if the specified invoice has discounts

Calls hasDiscounts() in Invoice.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceHasDiscountsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to know if it has discounts

            try
            {
                // Returns if the specified invoice has discounts
                apiInstance.InvoiceHasDiscounts(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceHasDiscounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to know if it has discounts | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoiceisorigin"></a>
# **InvoiceIsOrigin**
> void InvoiceIsOrigin (int? id)

Returns if the specified invoice is the origin of an order

Calls isOrigin() in Invoice.php to find out if the invoice is the origin of an order

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceIsOriginExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to know if it is the origin of an order

            try
            {
                // Returns if the specified invoice is the origin of an order
                apiInstance.InvoiceIsOrigin(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceIsOrigin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to know if it is the origin of an order | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicemarkassent"></a>
# **InvoiceMarkAsSent**
> ModelInvoice InvoiceMarkAsSent (int? id)

Marks an invoice as sent

Calls markAsSent() in Invoice.php to mark an invoice as sent

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceMarkAsSentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice which you want to mark as sent

            try
            {
                // Marks an invoice as sent
                ModelInvoice result = apiInstance.InvoiceMarkAsSent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceMarkAsSent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice which you want to mark as sent | 

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicerefundamount"></a>
# **InvoiceRefundAmount**
> ModelInvoice InvoiceRefundAmount (int? id, int? ammount, string date)

Refund an already payed invoice amount

Calls refundAmmount() in Invoice.php to refund an invoice amount

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceRefundAmountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to refund the amount
            var ammount = 56;  // int? | amount which should be refunded
            var date = date_example;  // string | booking date (default to )

            try
            {
                // Refund an already payed invoice amount
                ModelInvoice result = apiInstance.InvoiceRefundAmount(id, ammount, date);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceRefundAmount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to refund the amount | 
 **ammount** | **int?**| amount which should be refunded | 
 **date** | **string**| booking date | [default to ]

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicerender"></a>
# **InvoiceRender**
> void InvoiceRender (int? id)

Render invoice document on docserver and return metadata

Calls render() in Invoice.php to render invoice document on docserver and return the metadata

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceRenderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice of which you want to render the document and get the metadata

            try
            {
                // Render invoice document on docserver and return metadata
                apiInstance.InvoiceRender(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceRender: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice of which you want to render the document and get the metadata | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicesendby"></a>
# **InvoiceSendBy**
> ModelInvoice InvoiceSendBy (int? id, string sendType)

Send invoice by desired method

Calls sendBy() in Invoice.php to send an invoice by the desired method

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class InvoiceSendByExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Id of invoice which you want to send
            var sendType = sendType_example;  // string | desired send type, available are: VM = Mail, VP = Post, VPDF = PDF, PRN = Print (default to )

            try
            {
                // Send invoice by desired method
                ModelInvoice result = apiInstance.InvoiceSendBy(id, sendType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceSendBy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice which you want to send | 
 **sendType** | **string**| desired send type, available are: VM &#x3D; Mail, VP &#x3D; Post, VPDF &#x3D; PDF, PRN &#x3D; Print | [default to ]

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saveinvoice"></a>
# **SaveInvoice**
> ModelInvoiceFactory SaveInvoice (string body)

Create a new invoice (with / without invoice positions and discounts) 

With the new version of sevdesk some models are not created by calling the model.php directly but by calling the factory.php because of better performance and flexibility.    Basically the model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new invoice it wont be saved by a POST request with '/Invoice?para1=&...' but with the saveInvoice function in Factory.php 'Voucher/Factory/saveInvoice?para1='

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class SaveInvoiceExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var body = body_example;  // string | The saveInvoice function in Invoice/Factory.php combines both Invoice and InvoicePos with all their HTTP-methods.    It is now possible to **simultaneously** create an invoice with its position and discount.    To simply (only) create an invoice you can use the given parameters and concatenate your values.    For also adding an invoice position or a discount refer to the corresponding **quick reference** below.    The parameters you find there are **needed** for creating an invoice position / discount. Just concatenate them to the existing invoice / invoicePosSave parameters.    You can also find additional (optional) parameters in the **Models** section.    Quick reference InvoicePos:  * &invoicePosSave[0][part][id]=  * &invoicePosSave[0][part][objectName]=Part  * &invoicePosSave[0][quantity]=  * &invoicePosSave[0][unity][id]=  * &invoicePosSave[0][unity][objectName]=Unity  * &invoicePosSave[0][taxRate]=19  * &invoicePosSave[0][objectName]=InvoicePos  * &invoicePosSave[0][mapAll]=true  * &invoicePosSave[0][price]=  * &invoicePosDelete=null    Quick reference Discounts:  * &discountSave[0][discount]=true  * &discountSave[0][text]=  * &discountSave[0][percentage]=  * &discountSave[0][value]=  * &discountSave[0][objectName]=Discounts  * &discountSave[0][mapAll]=true  * &discountDelete=null    You can also use additional parameters for creating an invoice in the same way by adding them in the format: **invoice[yourParameter]** 

            try
            {
                // Create a new invoice (with / without invoice positions and discounts) 
                ModelInvoiceFactory result = apiInstance.SaveInvoice(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.SaveInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| The saveInvoice function in Invoice/Factory.php combines both Invoice and InvoicePos with all their HTTP-methods.    It is now possible to **simultaneously** create an invoice with its position and discount.    To simply (only) create an invoice you can use the given parameters and concatenate your values.    For also adding an invoice position or a discount refer to the corresponding **quick reference** below.    The parameters you find there are **needed** for creating an invoice position / discount. Just concatenate them to the existing invoice / invoicePosSave parameters.    You can also find additional (optional) parameters in the **Models** section.    Quick reference InvoicePos:  * &amp;invoicePosSave[0][part][id]&#x3D;  * &amp;invoicePosSave[0][part][objectName]&#x3D;Part  * &amp;invoicePosSave[0][quantity]&#x3D;  * &amp;invoicePosSave[0][unity][id]&#x3D;  * &amp;invoicePosSave[0][unity][objectName]&#x3D;Unity  * &amp;invoicePosSave[0][taxRate]&#x3D;19  * &amp;invoicePosSave[0][objectName]&#x3D;InvoicePos  * &amp;invoicePosSave[0][mapAll]&#x3D;true  * &amp;invoicePosSave[0][price]&#x3D;  * &amp;invoicePosDelete&#x3D;null    Quick reference Discounts:  * &amp;discountSave[0][discount]&#x3D;true  * &amp;discountSave[0][text]&#x3D;  * &amp;discountSave[0][percentage]&#x3D;  * &amp;discountSave[0][value]&#x3D;  * &amp;discountSave[0][objectName]&#x3D;Discounts  * &amp;discountSave[0][mapAll]&#x3D;true  * &amp;discountDelete&#x3D;null    You can also use additional parameters for creating an invoice in the same way by adding them in the format: **invoice[yourParameter]**  | 

### Return type

[**ModelInvoiceFactory**](ModelInvoiceFactory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendinvoiceviaemail"></a>
# **SendInvoiceViaEmail**
> ModelEmail SendInvoiceViaEmail (int? id, string body)

Send an invoice via Email

Calls sendViaEmail in Invoice.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class SendInvoiceViaEmailExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | id of invoice you want to send via Email
            var body = "toEmail=test@sevenit.de&subject=This is a test&text=Hello this is a test mail";  // string | Change the desired values after the parameters and remove the quotation marks. You can also add 'additionalAttachments', 'ccEmail=' and 'bccEmail'    Please note: additionalAttachments is a String containing document id's (of existing documents!)

            try
            {
                // Send an invoice via Email
                ModelEmail result = apiInstance.SendInvoiceViaEmail(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.SendInvoiceViaEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of invoice you want to send via Email | 
 **body** | **string**| Change the desired values after the parameters and remove the quotation marks. You can also add &#39;additionalAttachments&#39;, &#39;ccEmail&#x3D;&#39; and &#39;bccEmail&#39;    Please note: additionalAttachments is a String containing document id&#39;s (of existing documents!) | 

### Return type

[**ModelEmail**](ModelEmail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendinvoiceviapost"></a>
# **SendInvoiceViaPost**
> ModelInvoice SendInvoiceViaPost (int? id)

Send an invoice via Letter

Calls sendViaPost in Invoice.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class SendInvoiceViaPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | id of invoice you want to send via Letter

            try
            {
                // Send an invoice via Letter
                ModelInvoice result = apiInstance.SendInvoiceViaPost(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.SendInvoiceViaPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of invoice you want to send via Letter | 

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinvoice"></a>
# **UpdateInvoice**
> ModelInvoice UpdateInvoice (int? id, string body)

Update an existing invoice

Calls Invoice.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateInvoiceExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | id of invoice you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create invoice.    Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update an existing invoice
                ModelInvoice result = apiInstance.UpdateInvoice(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.UpdateInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of invoice you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create invoice.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelInvoice**](ModelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

