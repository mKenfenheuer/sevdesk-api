# SevDeskApi.Api.CurrencyExchangeRateApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCurrencyExchangeRates**](CurrencyExchangeRateApi.md#getcurrencyexchangerates) | **GET** /CurrencyExchangeRate | Get an overview of all currency exchange rates


<a name="getcurrencyexchangerates"></a>
# **GetCurrencyExchangeRates**
> ModelCurrencyExchangeRate GetCurrencyExchangeRates (int? limit, int? offset)

Get an overview of all currency exchange rates

Calls CurrencyExchangeRate.php to get necessary variables

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetCurrencyExchangeRatesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CurrencyExchangeRateApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 1000.    Be aware that there are over 100000 entries in the database for currency exchange rate, so using a limit higher than 1000 with offset=0 is not recommended!    However you can set the offset appropriately so you minimize the amount of returned exchange rates and keep loading time to a low. (optional)  (default to 1000)
            var offset = 56;  // int? | Set the index where the returned currency exchange rates start. Default is 0 (optional)  (default to 0)

            try
            {
                // Get an overview of all currency exchange rates
                ModelCurrencyExchangeRate result = apiInstance.GetCurrencyExchangeRates(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrencyExchangeRateApi.GetCurrencyExchangeRates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 1000.    Be aware that there are over 100000 entries in the database for currency exchange rate, so using a limit higher than 1000 with offset&#x3D;0 is not recommended!    However you can set the offset appropriately so you minimize the amount of returned exchange rates and keep loading time to a low. | [optional] [default to 1000]
 **offset** | **int?**| Set the index where the returned currency exchange rates start. Default is 0 | [optional] [default to 0]

### Return type

[**ModelCurrencyExchangeRate**](ModelCurrencyExchangeRate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

