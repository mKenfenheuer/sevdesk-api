# SevDeskApi.Api.ReportApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportContact**](ReportApi.md#reportcontact) | **GET** /Report/contact | Export the contact
[**ReportContactList**](ReportApi.md#reportcontactlist) | **GET** /Report/contactlist | Export the contact list
[**ReportInventory**](ReportApi.md#reportinventory) | **GET** /Report/inventory | Export the inventory
[**ReportInvoiceList**](ReportApi.md#reportinvoicelist) | **GET** /Report/invoicelist | Export the invoicelist
[**ReportOrderList**](ReportApi.md#reportorderlist) | **GET** /Report/orderlist | Export the order list
[**ReportProfitAndLoss**](ReportApi.md#reportprofitandloss) | **GET** /Report/profitAndLoss | Export the profit and loss
[**ReportRegisterBook**](ReportApi.md#reportregisterbook) | **GET** /Report/registerBook | Export the register book / cash report
[**ReportVoucherList**](ReportApi.md#reportvoucherlist) | **GET** /Report/voucherlist | Export the voucher list


<a name="reportcontact"></a>
# **ReportContact**
> System.IO.Stream ReportContact (bool? download, int? contactId, string contactObjectName)

Export the contact

Calls contact() in Report.php to export the contact.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch 'yourFilter' with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ReportContactExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ReportApi();
            var download = true;  // bool? | Specifies if the document is downloaded (default to true)
            var contactId = 56;  // int? | Id of contact which should be exported
            var contactObjectName = contactObjectName_example;  // string | Model name which is exported (default to Contact)

            try
            {
                // Export the contact
                System.IO.Stream result = apiInstance.ReportContact(download, contactId, contactObjectName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **download** | **bool?**| Specifies if the document is downloaded | [default to true]
 **contactId** | **int?**| Id of contact which should be exported | 
 **contactObjectName** | **string**| Model name which is exported | [default to Contact]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportcontactlist"></a>
# **ReportContactList**
> System.IO.Stream ReportContactList (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset)

Export the contact list

Calls contactlist() in Report.php to export the contact list.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch 'yourFilter' with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ReportContactListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ReportApi();
            var sevQueryModelName = sevQueryModelName_example;  // string | Model name which is exported (default to Contact)
            var sevQueryObjectName = sevQueryObjectName_example;  // string | SevQuery object name (default to SevQuery)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)
            var sevQueryLimit = 56;  // int? | Limit exported contacts (optional)  (default to 99999)
            var sevQueryOffset = 56;  // int? | Set the index where the exported contacts start (optional)  (default to 0)

            try
            {
                // Export the contact list
                System.IO.Stream result = apiInstance.ReportContactList(sevQueryModelName, sevQueryObjectName, download, sevQueryLimit, sevQueryOffset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportContactList: " + e.Message );
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
 **sevQueryOffset** | **int?**| Set the index where the exported contacts start | [optional] [default to 0]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportinventory"></a>
# **ReportInventory**
> System.IO.Stream ReportInventory (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset)

Export the inventory

Calls inventory() in Report.php to export the inventory.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch 'yourFilter' with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ReportInventoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ReportApi();
            var sevQueryModelName = sevQueryModelName_example;  // string | Model name which is exported (default to Part)
            var sevQueryObjectName = sevQueryObjectName_example;  // string | SevQuery object name (default to SevQuery)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)
            var sevQueryLimit = 56;  // int? | Limit exported inventory entries (optional)  (default to 99999)
            var sevQueryOffset = 56;  // int? | Set the index where the exported parts start (optional)  (default to 99999)

            try
            {
                // Export the inventory
                System.IO.Stream result = apiInstance.ReportInventory(sevQueryModelName, sevQueryObjectName, download, sevQueryLimit, sevQueryOffset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportInventory: " + e.Message );
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
 **sevQueryLimit** | **int?**| Limit exported inventory entries | [optional] [default to 99999]
 **sevQueryOffset** | **int?**| Set the index where the exported parts start | [optional] [default to 99999]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportinvoicelist"></a>
# **ReportInvoiceList**
> System.IO.Stream ReportInvoiceList (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset)

Export the invoicelist

Calls invoicelist() in Report.php to export the invoices.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch 'yourFilter' with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ReportInvoiceListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ReportApi();
            var sevQueryModelName = sevQueryModelName_example;  // string | Model name which is exported (default to Invoice)
            var sevQueryObjectName = sevQueryObjectName_example;  // string | SevQuery object name (default to SevQuery)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)
            var sevQueryLimit = 56;  // int? | Limit exported invoices (optional)  (default to 99999)
            var sevQueryOffset = 56;  // int? | Set the index where the exported invoices should start (optional)  (default to 0)

            try
            {
                // Export the invoicelist
                System.IO.Stream result = apiInstance.ReportInvoiceList(sevQueryModelName, sevQueryObjectName, download, sevQueryLimit, sevQueryOffset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportInvoiceList: " + e.Message );
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
 **sevQueryOffset** | **int?**| Set the index where the exported invoices should start | [optional] [default to 0]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportorderlist"></a>
# **ReportOrderList**
> System.IO.Stream ReportOrderList (string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset)

Export the order list

Calls orderlist() in Report.php to export the orders.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch 'yourFilter' with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ReportOrderListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ReportApi();
            var sevQueryModelName = sevQueryModelName_example;  // string | Model name which is exported (default to Order)
            var sevQueryObjectName = sevQueryObjectName_example;  // string | SevQuery object name (default to SevQuery)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)
            var sevQueryLimit = 56;  // int? | Limit exported orders (optional)  (default to 99999)
            var sevQueryOffset = 56;  // int? | Set the index where the exported orders should start (optional)  (default to 0)

            try
            {
                // Export the order list
                System.IO.Stream result = apiInstance.ReportOrderList(sevQueryModelName, sevQueryObjectName, download, sevQueryLimit, sevQueryOffset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportOrderList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sevQueryModelName** | **string**| Model name which is exported | [default to Order]
 **sevQueryObjectName** | **string**| SevQuery object name | [default to SevQuery]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]
 **sevQueryLimit** | **int?**| Limit exported orders | [optional] [default to 99999]
 **sevQueryOffset** | **int?**| Set the index where the exported orders should start | [optional] [default to 0]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportprofitandloss"></a>
# **ReportProfitAndLoss**
> System.IO.Stream ReportProfitAndLoss (string startDate, string endDate, bool? taxRule, bool? download)

Export the profit and loss

Calls profitAndLoss() in Report.php to export the profit and loss.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch 'yourFilter' with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ReportProfitAndLossExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ReportApi();
            var startDate = startDate_example;  // string | Start date of the profit and loss calculation (default to )
            var endDate = endDate_example;  // string | End date of the profit and loss calculation (default to )
            var taxRule = true;  // bool? | Specify if you want the net income method or the profit and loss (default to true)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)

            try
            {
                // Export the profit and loss
                System.IO.Stream result = apiInstance.ReportProfitAndLoss(startDate, endDate, taxRule, download);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportProfitAndLoss: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| Start date of the profit and loss calculation | [default to ]
 **endDate** | **string**| End date of the profit and loss calculation | [default to ]
 **taxRule** | **bool?**| Specify if you want the net income method or the profit and loss | [default to true]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportregisterbook"></a>
# **ReportRegisterBook**
> System.IO.Stream ReportRegisterBook (int? checkAccountId, string checkAccountObjectName, string startDate, string endDate, bool? download)

Export the register book / cash report

Calls registerBook() in Report.php to export the register book / cash report.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch 'yourFilter' with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ReportRegisterBookExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ReportApi();
            var checkAccountId = 56;  // int? | Check account you want to export
            var checkAccountObjectName = checkAccountObjectName_example;  // string | Check account object name (default to CheckAccount)
            var startDate = startDate_example;  // string | Start date of the register book / cash report (default to )
            var endDate = endDate_example;  // string | End date of the register book / cash report (default to )
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)

            try
            {
                // Export the register book / cash report
                System.IO.Stream result = apiInstance.ReportRegisterBook(checkAccountId, checkAccountObjectName, startDate, endDate, download);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportRegisterBook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **checkAccountId** | **int?**| Check account you want to export | 
 **checkAccountObjectName** | **string**| Check account object name | [default to CheckAccount]
 **startDate** | **string**| Start date of the register book / cash report | [default to ]
 **endDate** | **string**| End date of the register book / cash report | [default to ]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportvoucherlist"></a>
# **ReportVoucherList**
> System.IO.Stream ReportVoucherList (string sevQueryFilterStartDate, string sevQueryModelName, string sevQueryObjectName, bool? download, int? sevQueryLimit, int? sevQueryOffset)

Export the voucher list

Calls voucherlist() in Report.php to export the vouchers.    With **sevQuery[filter][yourFilter]**, you can filter the entries you want to export. For this, just switch 'yourFilter' with some parameter the involved model would normally take.    **Currently there is a problem with swagger understanding return type 'file', so the api will respond accordingly but swagger ui can not display it correctly.**

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ReportVoucherListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ReportApi();
            var sevQueryFilterStartDate = sevQueryFilterStartDate_example;  // string | Start date to filter vouchers with (default to )
            var sevQueryModelName = sevQueryModelName_example;  // string | Model name which is exported (default to Voucher)
            var sevQueryObjectName = sevQueryObjectName_example;  // string | SevQuery object name (default to SevQuery)
            var download = true;  // bool? | Specifies if the document is downloaded (optional)  (default to true)
            var sevQueryLimit = 56;  // int? | Limit exported vouchers (optional)  (default to 99999)
            var sevQueryOffset = 56;  // int? | Set the index where the exported vouchers should start (optional)  (default to 0)

            try
            {
                // Export the voucher list
                System.IO.Stream result = apiInstance.ReportVoucherList(sevQueryFilterStartDate, sevQueryModelName, sevQueryObjectName, download, sevQueryLimit, sevQueryOffset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportVoucherList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sevQueryFilterStartDate** | **string**| Start date to filter vouchers with | [default to ]
 **sevQueryModelName** | **string**| Model name which is exported | [default to Voucher]
 **sevQueryObjectName** | **string**| SevQuery object name | [default to SevQuery]
 **download** | **bool?**| Specifies if the document is downloaded | [optional] [default to true]
 **sevQueryLimit** | **int?**| Limit exported vouchers | [optional] [default to 99999]
 **sevQueryOffset** | **int?**| Set the index where the exported vouchers should start | [optional] [default to 0]

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

