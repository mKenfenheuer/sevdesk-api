# SevDeskApi.Api.ExportApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportContactCsv**](ExportApi.md#exportcontactcsv) | **GET** /Export/contactCsv | Export the specified contact as csv
[**ExportContactListCsv**](ExportApi.md#exportcontactlistcsv) | **GET** /Export/contactListCsv | Export the contact list as csv
[**ExportDatev**](ExportApi.md#exportdatev) | **GET** /Export/datev | Datev export as zip with csv´s
[**ExportDatevZip**](ExportApi.md#exportdatevzip) | **GET** /Export/datevZip | Export zip for voucher upload
[**ExportInventoryPartLogList**](ExportApi.md#exportinventorypartloglist) | **GET** /Export/inventoryPartLogListCsv | Export the inventory part log as csv
[**ExportInvoiceCsv**](ExportApi.md#exportinvoicecsv) | **GET** /Export/invoiceCsv | Export the invoice list as csv
[**ExportInvoiceZip**](ExportApi.md#exportinvoicezip) | **GET** /Export/invoiceZip | Export the invoice list as zip with csv´s
[**ExportPartCsv**](ExportApi.md#exportpartcsv) | **GET** /Export/partCsv | Export the parts as csv
[**ExportPebe**](ExportApi.md#exportpebe) | **GET** /Export/pebe | Pebe export as zip with csv´s
[**ExportTransactionsCsv**](ExportApi.md#exporttransactionscsv) | **GET** /Export/transactionsCsv | Export the transactions as csv
[**ExportVoucherListCsv**](ExportApi.md#exportvoucherlistcsv) | **GET** /Export/voucherListCsv | Export the voucher list as csv
[**ExportVoucherZip**](ExportApi.md#exportvoucherzip) | **GET** /Export/voucherZip | Export the voucher list as zip with csv´s


<a name="exportcontactcsv"></a>
# **ExportContactCsv**
> System.IO.Stream ExportContactCsv (int? contactId, string contactObjectName, bool? download)

Export the specified contact as csv

Calls contactCsv() in Export.php to export the specified contact as a csv.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ExportContactCsvExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ExportApi();
            var contactId = 56;  // int? | Id of the contact you want to export
            var contactObjectName = contactObjectName_example;  // string | Model name which is exported (default to Contact)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)

            try
            {
                // Export the specified contact as csv
                System.IO.Stream result = apiInstance.ExportContactCsv(contactId, contactObjectName, download);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportContactCsv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **int?**| Id of the contact you want to export | 
 **contactObjectName** | **string**| Model name which is exported | [default to Contact]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportcontactlistcsv"></a>
# **ExportContactListCsv**
> System.IO.Stream ExportContactListCsv (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, bool? sevQueryFilterDepth)

Export the contact list as csv

Calls contactListCsv() in Export.php to export the contact list as a csv.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ExportContactListCsvExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ExportApi();
            var sevQueryModelName = sevQueryModelName_example;  // string | Model name which is exported (default to Contact)
            var sevQueryObjectName = sevQueryObjectName_example;  // string | SevQuery object name (default to SevQuery)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)
            var sevQueryLimit = 56;  // int? | Limit exported contacts (optional)  (default to 99999)
            var sevQueryFilterDepth = true;  // bool? | Specify if companies and persons (true) or only persons (false) should be exported (optional)  (default to true)

            try
            {
                // Export the contact list as csv
                System.IO.Stream result = apiInstance.ExportContactListCsv(sevQueryModelName, sevQueryObjectName, download, sevQueryLimit, sevQueryFilterDepth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportContactListCsv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sevQueryModelName** | **string**| Model name which is exported | [default to Contact]
 **sevQueryObjectName** | **string**| SevQuery object name | [default to SevQuery]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]
 **sevQueryLimit** | **int?**| Limit exported contacts | [optional] [default to 99999]
 **sevQueryFilterDepth** | **bool?**| Specify if companies and persons (true) or only persons (false) should be exported | [optional] [default to true]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportdatev"></a>
# **ExportDatev**
> System.IO.Stream ExportDatev (string scope, string start, string end, bool? withEnshrined,  enshrine, bool? download)

Datev export as zip with csv´s

Calls datev() in Export.php to export the datev as a csv.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ExportDatevExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ExportApi();
            var scope = scope_example;  // string | Define what you want to include in the datev export. This parameter takes a string of 4 letters. Each stands for a model that should be included.    Possible letters are: **'I'** (Invoices), **'V'** (Vouchers), **'D'** (Depreciations), **'T'** (Transactions).    By providing one of those letter you specify that it should be included in the datev export. Some combinations are: 'IVDT', 'IVT' ... (default to IVDT)
            var start = start_example;  // string | Specify the start date for the datev export (default to )
            var end = end_example;  // string | Specify the end date for the datev export (default to )
            var withEnshrined = true;  // bool? | Specify if you want to include enshrined models (default to false)
            var enshrine = new (); //  | Specify if you want to enshrine all models which were included in the export (default to false)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)

            try
            {
                // Datev export as zip with csv´s
                System.IO.Stream result = apiInstance.ExportDatev(scope, start, end, withEnshrined, enshrine, download);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportDatev: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| Define what you want to include in the datev export. This parameter takes a string of 4 letters. Each stands for a model that should be included.    Possible letters are: **&#39;I&#39;** (Invoices), **&#39;V&#39;** (Vouchers), **&#39;D&#39;** (Depreciations), **&#39;T&#39;** (Transactions).    By providing one of those letter you specify that it should be included in the datev export. Some combinations are: &#39;IVDT&#39;, &#39;IVT&#39; ... | [default to IVDT]
 **start** | **string**| Specify the start date for the datev export | [default to ]
 **end** | **string**| Specify the end date for the datev export | [default to ]
 **withEnshrined** | **bool?**| Specify if you want to include enshrined models | [default to false]
 **enshrine** | [****](.md)| Specify if you want to enshrine all models which were included in the export | [default to false]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/zip

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportdatevzip"></a>
# **ExportDatevZip**
> System.IO.Stream ExportDatevZip (string scope, string start, string end, bool? withEnshrined, bool? download)

Export zip for voucher upload

Calls datevZip() in Export.php to export the zip for voucher upload.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ExportDatevZipExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ExportApi();
            var scope = scope_example;  // string | Define what you want to include in the zip export. This parameter takes a string of 4 letters. Each stands for a model that should be included.    Possible letters are: **'I'** (Invoices), **'V'** (Vouchers), **'D'** (Depreciations), **'T'** (Transactions).    By providing one of those letter you specify that it should be included in the datev export. Some combinations are: 'IVDT', 'IVT' ... (default to IVDT)
            var start = start_example;  // string | Specify the start date for the zip export (default to )
            var end = end_example;  // string | Specify the end date for the zip export (default to )
            var withEnshrined = true;  // bool? | Specify if you want to include enshrined models (default to false)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)

            try
            {
                // Export zip for voucher upload
                System.IO.Stream result = apiInstance.ExportDatevZip(scope, start, end, withEnshrined, download);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportDatevZip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| Define what you want to include in the zip export. This parameter takes a string of 4 letters. Each stands for a model that should be included.    Possible letters are: **&#39;I&#39;** (Invoices), **&#39;V&#39;** (Vouchers), **&#39;D&#39;** (Depreciations), **&#39;T&#39;** (Transactions).    By providing one of those letter you specify that it should be included in the datev export. Some combinations are: &#39;IVDT&#39;, &#39;IVT&#39; ... | [default to IVDT]
 **start** | **string**| Specify the start date for the zip export | [default to ]
 **end** | **string**| Specify the end date for the zip export | [default to ]
 **withEnshrined** | **bool?**| Specify if you want to include enshrined models | [default to false]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/zip

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportinventorypartloglist"></a>
# **ExportInventoryPartLogList**
> System.IO.Stream ExportInventoryPartLogList (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryFilterPartId, string sevQueryFilterPartObjectName)

Export the inventory part log as csv

Calls inventoryPartLogListCsv() in Export.php to export the inventory part log list as a csv.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ExportInventoryPartLogListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ExportApi();
            var sevQueryModelName = sevQueryModelName_example;  // string | Model name which is exported (default to InventoryPartLog)
            var sevQueryObjectName = sevQueryObjectName_example;  // string | SevQuery object name (default to SevQuery)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)
            var sevQueryLimit = 56;  // int? | Limit exported part log (optional)  (default to 99999)
            var sevQueryFilterPartId = 56;  // int? | Id of the part for which you want to export the part log (optional) 
            var sevQueryFilterPartObjectName = sevQueryFilterPartObjectName_example;  // string | Object name of part (optional)  (default to Part)

            try
            {
                // Export the inventory part log as csv
                System.IO.Stream result = apiInstance.ExportInventoryPartLogList(sevQueryModelName, sevQueryObjectName, download, sevQueryLimit, sevQueryFilterPartId, sevQueryFilterPartObjectName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportInventoryPartLogList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sevQueryModelName** | **string**| Model name which is exported | [default to InventoryPartLog]
 **sevQueryObjectName** | **string**| SevQuery object name | [default to SevQuery]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]
 **sevQueryLimit** | **int?**| Limit exported part log | [optional] [default to 99999]
 **sevQueryFilterPartId** | **int?**| Id of the part for which you want to export the part log | [optional] 
 **sevQueryFilterPartObjectName** | **string**| Object name of part | [optional] [default to Part]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportinvoicecsv"></a>
# **ExportInvoiceCsv**
> System.IO.Stream ExportInvoiceCsv (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit)

Export the invoice list as csv

Calls invoiceCsv() in Export.php to export the invoice list as a csv.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ExportInvoiceCsvExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ExportApi();
            var sevQueryModelName = sevQueryModelName_example;  // string | Model name which is exported (default to Invoice)
            var sevQueryObjectName = sevQueryObjectName_example;  // string | SevQuery object name (default to SevQuery)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)
            var sevQueryLimit = 56;  // int? | Limit exported invoices (optional)  (default to 99999)

            try
            {
                // Export the invoice list as csv
                System.IO.Stream result = apiInstance.ExportInvoiceCsv(sevQueryModelName, sevQueryObjectName, download, sevQueryLimit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportInvoiceCsv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sevQueryModelName** | **string**| Model name which is exported | [default to Invoice]
 **sevQueryObjectName** | **string**| SevQuery object name | [default to SevQuery]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]
 **sevQueryLimit** | **int?**| Limit exported invoices | [optional] [default to 99999]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportinvoicezip"></a>
# **ExportInvoiceZip**
> System.IO.Stream ExportInvoiceZip (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit)

Export the invoice list as zip with csv´s

Calls invoiceZip() in Export.php to export the invoice list as a zip with csv´s.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ExportInvoiceZipExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ExportApi();
            var sevQueryModelName = sevQueryModelName_example;  // string | Model name which is exported (default to Invoice)
            var sevQueryObjectName = sevQueryObjectName_example;  // string | SevQuery object name (default to SevQuery)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)
            var sevQueryLimit = 56;  // int? | Limit exported invoices (optional)  (default to 50)

            try
            {
                // Export the invoice list as zip with csv´s
                System.IO.Stream result = apiInstance.ExportInvoiceZip(sevQueryModelName, sevQueryObjectName, download, sevQueryLimit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportInvoiceZip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sevQueryModelName** | **string**| Model name which is exported | [default to Invoice]
 **sevQueryObjectName** | **string**| SevQuery object name | [default to SevQuery]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]
 **sevQueryLimit** | **int?**| Limit exported invoices | [optional] [default to 50]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/zip

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportpartcsv"></a>
# **ExportPartCsv**
> System.IO.Stream ExportPartCsv (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit)

Export the parts as csv

Calls partCsv() in Export.php to export the parts as csv.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ExportPartCsvExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ExportApi();
            var sevQueryModelName = sevQueryModelName_example;  // string | Model name which is exported (default to Part)
            var sevQueryObjectName = sevQueryObjectName_example;  // string | SevQuery object name (default to SevQuery)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)
            var sevQueryLimit = 56;  // int? | Limit exported part (optional)  (default to 99999)

            try
            {
                // Export the parts as csv
                System.IO.Stream result = apiInstance.ExportPartCsv(sevQueryModelName, sevQueryObjectName, download, sevQueryLimit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportPartCsv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sevQueryModelName** | **string**| Model name which is exported | [default to Part]
 **sevQueryObjectName** | **string**| SevQuery object name | [default to SevQuery]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]
 **sevQueryLimit** | **int?**| Limit exported part | [optional] [default to 99999]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportpebe"></a>
# **ExportPebe**
> System.IO.Stream ExportPebe (string scope, string start, string end, bool? withEnshrined,  enshrine, bool? download)

Pebe export as zip with csv´s

Calls pebe() in Export.php to export the pebe zip with csv´s.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ExportPebeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ExportApi();
            var scope = scope_example;  // string | Define what you want to include in the datev export. This parameter takes a string of 4 letters. Each stands for a model that should be included.    Possible letters are: **'I'** (Invoices), **'V'** (Vouchers), **'D'** (Depreciations), **'T'** (Transactions).    By providing one of those letter you specify that it should be included in the datev export. Some combinations are: 'IVDT', 'IVT' ... (default to IVDT)
            var start = start_example;  // string | Specify the start date for the pebe export (default to )
            var end = end_example;  // string | Specify the end date for the pebe export (default to )
            var withEnshrined = true;  // bool? | Specify if you want to include enshrined models (default to false)
            var enshrine = new (); //  | Specify if you want to enshrine all models which were included in the export (default to false)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)

            try
            {
                // Pebe export as zip with csv´s
                System.IO.Stream result = apiInstance.ExportPebe(scope, start, end, withEnshrined, enshrine, download);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportPebe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| Define what you want to include in the datev export. This parameter takes a string of 4 letters. Each stands for a model that should be included.    Possible letters are: **&#39;I&#39;** (Invoices), **&#39;V&#39;** (Vouchers), **&#39;D&#39;** (Depreciations), **&#39;T&#39;** (Transactions).    By providing one of those letter you specify that it should be included in the datev export. Some combinations are: &#39;IVDT&#39;, &#39;IVT&#39; ... | [default to IVDT]
 **start** | **string**| Specify the start date for the pebe export | [default to ]
 **end** | **string**| Specify the end date for the pebe export | [default to ]
 **withEnshrined** | **bool?**| Specify if you want to include enshrined models | [default to false]
 **enshrine** | [****](.md)| Specify if you want to enshrine all models which were included in the export | [default to false]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/zip

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exporttransactionscsv"></a>
# **ExportTransactionsCsv**
> System.IO.Stream ExportTransactionsCsv (bool? sevQueryFilterRegister, string sevQueryModelName, string sevQueryObjectName, string sevQueryOrderEntryDate, bool? download, int? checkAccountId, string checkAccountObjectName, int? sevQueryLimit)

Export the transactions as csv

Calls transactionsCsv() in Export.php to export the transactions as csv. Optionally you can provide a specific check account.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ExportTransactionsCsvExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ExportApi();
            var sevQueryFilterRegister = true;  // bool? | Specifies if the register is included (default to false)
            var sevQueryModelName = sevQueryModelName_example;  // string | Model name which is exported (default to CheckAccountTransaction)
            var sevQueryObjectName = sevQueryObjectName_example;  // string | SevQuery object name (default to SevQuery)
            var sevQueryOrderEntryDate = sevQueryOrderEntryDate_example;  // string | Order in which you want to have the transactions listed (default to desc)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)
            var checkAccountId = 56;  // int? | Specify check account for which you want the transactions. Otherwise all transactions will be used (optional) 
            var checkAccountObjectName = checkAccountObjectName_example;  // string | Check account model name (optional)  (default to CheckAccount)
            var sevQueryLimit = 56;  // int? | Limit exported transactions (optional)  (default to 99999)

            try
            {
                // Export the transactions as csv
                System.IO.Stream result = apiInstance.ExportTransactionsCsv(sevQueryFilterRegister, sevQueryModelName, sevQueryObjectName, sevQueryOrderEntryDate, download, checkAccountId, checkAccountObjectName, sevQueryLimit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportTransactionsCsv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sevQueryFilterRegister** | **bool?**| Specifies if the register is included | [default to false]
 **sevQueryModelName** | **string**| Model name which is exported | [default to CheckAccountTransaction]
 **sevQueryObjectName** | **string**| SevQuery object name | [default to SevQuery]
 **sevQueryOrderEntryDate** | **string**| Order in which you want to have the transactions listed | [default to desc]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]
 **checkAccountId** | **int?**| Specify check account for which you want the transactions. Otherwise all transactions will be used | [optional] 
 **checkAccountObjectName** | **string**| Check account model name | [optional] [default to CheckAccount]
 **sevQueryLimit** | **int?**| Limit exported transactions | [optional] [default to 99999]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportvoucherlistcsv"></a>
# **ExportVoucherListCsv**
> System.IO.Stream ExportVoucherListCsv (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, string sevQueryFilterStartDate, string sevQueryFilterVoucherType)

Export the voucher list as csv

Calls voucherListCsv() in Export.php to export the voucher list as a csv.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ExportVoucherListCsvExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ExportApi();
            var sevQueryModelName = sevQueryModelName_example;  // string | Model name which is exported (default to Voucher)
            var sevQueryObjectName = sevQueryObjectName_example;  // string | SevQuery object name (default to SevQuery)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)
            var sevQueryLimit = 56;  // int? | Limit exported vouchers (optional)  (default to 99999)
            var sevQueryFilterStartDate = sevQueryFilterStartDate_example;  // string | Start date of the voucher list (optional)  (default to )
            var sevQueryFilterVoucherType = sevQueryFilterVoucherType_example;  // string | Type of vouchers you want to export (optional)  (default to VOU)

            try
            {
                // Export the voucher list as csv
                System.IO.Stream result = apiInstance.ExportVoucherListCsv(sevQueryModelName, sevQueryObjectName, download, sevQueryLimit, sevQueryFilterStartDate, sevQueryFilterVoucherType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportVoucherListCsv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sevQueryModelName** | **string**| Model name which is exported | [default to Voucher]
 **sevQueryObjectName** | **string**| SevQuery object name | [default to SevQuery]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]
 **sevQueryLimit** | **int?**| Limit exported vouchers | [optional] [default to 99999]
 **sevQueryFilterStartDate** | **string**| Start date of the voucher list | [optional] [default to ]
 **sevQueryFilterVoucherType** | **string**| Type of vouchers you want to export | [optional] [default to VOU]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportvoucherzip"></a>
# **ExportVoucherZip**
> System.IO.Stream ExportVoucherZip (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, string sevQueryFilterStartDate, string sevQueryFilterVoucherType)

Export the voucher list as zip with csv´s

Calls voucherZip() in Export.php to export the voucher list as a zip with csv´s.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ExportVoucherZipExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ExportApi();
            var sevQueryModelName = sevQueryModelName_example;  // string | Model name which is exported (default to Voucher)
            var sevQueryObjectName = sevQueryObjectName_example;  // string | SevQuery object name (default to SevQuery)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)
            var sevQueryLimit = 56;  // int? | Limit exported vouchers (optional)  (default to 99999)
            var sevQueryFilterStartDate = sevQueryFilterStartDate_example;  // string | Start date of the voucher list (optional)  (default to )
            var sevQueryFilterVoucherType = sevQueryFilterVoucherType_example;  // string | Type of vouchers you want to export (optional)  (default to VOU)

            try
            {
                // Export the voucher list as zip with csv´s
                System.IO.Stream result = apiInstance.ExportVoucherZip(sevQueryModelName, sevQueryObjectName, download, sevQueryLimit, sevQueryFilterStartDate, sevQueryFilterVoucherType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportVoucherZip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sevQueryModelName** | **string**| Model name which is exported | [default to Voucher]
 **sevQueryObjectName** | **string**| SevQuery object name | [default to SevQuery]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]
 **sevQueryLimit** | **int?**| Limit exported vouchers | [optional] [default to 99999]
 **sevQueryFilterStartDate** | **string**| Start date of the voucher list | [optional] [default to ]
 **sevQueryFilterVoucherType** | **string**| Type of vouchers you want to export | [optional] [default to VOU]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/zip

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

