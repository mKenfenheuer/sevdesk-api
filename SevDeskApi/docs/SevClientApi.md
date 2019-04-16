# SevDeskApi.Api.SevClientApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SevClientGetSevDeskAccountInvoices**](SevClientApi.md#sevclientgetsevdeskaccountinvoices) | **GET** /SevClient/getSevDeskAccountInvoices | Get sevDesk account invoices


<a name="sevclientgetsevdeskaccountinvoices"></a>
# **SevClientGetSevDeskAccountInvoices**
> void SevClientGetSevDeskAccountInvoices ()

Get sevDesk account invoices

Get sevDesk account invoices

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class SevClientGetSevDeskAccountInvoicesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new SevClientApi();

            try
            {
                // Get sevDesk account invoices
                apiInstance.SevClientGetSevDeskAccountInvoices();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SevClientApi.SevClientGetSevDeskAccountInvoices: " + e.Message );
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
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

