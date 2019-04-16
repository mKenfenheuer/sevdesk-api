# SevDeskApi.Api.VatReportApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetVatReport**](VatReportApi.md#getvatreport) | **GET** /VatReport | Get a vat report for a defined period of time


<a name="getvatreport"></a>
# **GetVatReport**
> void GetVatReport (int? reportingYear, string reportingPeriodCode, bool? noActualTaxationOnInputTax)

Get a vat report for a defined period of time

Calls VatReport.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetVatReportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VatReportApi();
            var reportingYear = 56;  // int? | Year for which you want to have a vat report
            var reportingPeriodCode = reportingPeriodCode_example;  // string | Define the period for your vat report (default to monthly)
            var noActualTaxationOnInputTax = true;  // bool? | Define if you want actual taxation on input tax (default to false)

            try
            {
                // Get a vat report for a defined period of time
                apiInstance.GetVatReport(reportingYear, reportingPeriodCode, noActualTaxationOnInputTax);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VatReportApi.GetVatReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportingYear** | **int?**| Year for which you want to have a vat report | 
 **reportingPeriodCode** | **string**| Define the period for your vat report | [default to monthly]
 **noActualTaxationOnInputTax** | **bool?**| Define if you want actual taxation on input tax | [default to false]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

