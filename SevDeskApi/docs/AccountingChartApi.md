# SevDeskApi.Api.AccountingChartApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAccountingChart**](AccountingChartApi.md#addaccountingchart) | **POST** /AccountingChart | Create a new accounting chart
[**DeleteAccountingChart**](AccountingChartApi.md#deleteaccountingchart) | **DELETE** /AccountingChart/{id} | Delete an existing accounting chart
[**GetAccountingChart**](AccountingChartApi.md#getaccountingchart) | **GET** /AccountingChart | Get an overview of all accounting charts
[**UpdateAccountingChart**](AccountingChartApi.md#updateaccountingchart) | **PUT** /AccountingChart/{id} | Update an existing accounting chart


<a name="addaccountingchart"></a>
# **AddAccountingChart**
> ModelAccountingChart AddAccountingChart (string body)

Create a new accounting chart

Calls AccountingChart.php to add an accounting chart

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddAccountingChartExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingChartApi();
            var body = body_example;  // string | To create an accounting chart, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new accounting chart
                ModelAccountingChart result = apiInstance.AddAccountingChart(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingChartApi.AddAccountingChart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an accounting chart, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelAccountingChart**](ModelAccountingChart.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccountingchart"></a>
# **DeleteAccountingChart**
> void DeleteAccountingChart (int? id)

Delete an existing accounting chart

Calls AccountingChart.php to delete an accounting chart

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteAccountingChartExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingChartApi();
            var id = 56;  // int? | id of the accounting chart you want to delete

            try
            {
                // Delete an existing accounting chart
                apiInstance.DeleteAccountingChart(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingChartApi.DeleteAccountingChart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of the accounting chart you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountingchart"></a>
# **GetAccountingChart**
> ModelAccountingChart GetAccountingChart (int? limit, int? offset)

Get an overview of all accounting charts

Calls AccountingChart.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetAccountingChartExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingChartApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned accounting charts start. Default is 0 (optional)  (default to 0)

            try
            {
                // Get an overview of all accounting charts
                ModelAccountingChart result = apiInstance.GetAccountingChart(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingChartApi.GetAccountingChart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned accounting charts start. Default is 0 | [optional] [default to 0]

### Return type

[**ModelAccountingChart**](ModelAccountingChart.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccountingchart"></a>
# **UpdateAccountingChart**
> ModelAccountingChart UpdateAccountingChart (int? id, string body)

Update an existing accounting chart

Calls AccountingChart.php to update an accounting chart

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateAccountingChartExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingChartApi();
            var id = 56;  // int? | id of accounting chart you want to update
            var body = body_example;  // string | Parameters which need to be updated. Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // Update an existing accounting chart
                ModelAccountingChart result = apiInstance.UpdateAccountingChart(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingChartApi.UpdateAccountingChart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of accounting chart you want to update | 
 **body** | **string**| Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelAccountingChart**](ModelAccountingChart.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

