# SevDeskApi.Api.InvoiceLogApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInvoiceLog**](InvoiceLogApi.md#addinvoicelog) | **POST** /InvoiceLog | Create a new invoice log
[**DeleteInvoiceLog**](InvoiceLogApi.md#deleteinvoicelog) | **DELETE** /InvoiceLog/{id} | Delete an existing invoice log
[**GetInvoiceLogs**](InvoiceLogApi.md#getinvoicelogs) | **GET** /InvoiceLog | Get an overview of invoice logs
[**UpdateInvoiceLog**](InvoiceLogApi.md#updateinvoicelog) | **PUT** /InvoiceLog/{id} | Update an existing invoice log


<a name="addinvoicelog"></a>
# **AddInvoiceLog**
> ModelInvoiceLog AddInvoiceLog (string body)

Create a new invoice log

Calls InvoiceLog.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddInvoiceLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceLogApi();
            var body = "invoice[objectName]=Invoice&invoice[id]=&fromStatus=&toStatus=&ammountPayed=&bookingDate=";  // string | To create an invoice log, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new invoice log
                ModelInvoiceLog result = apiInstance.AddInvoiceLog(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceLogApi.AddInvoiceLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an invoice log, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelInvoiceLog**](ModelInvoiceLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinvoicelog"></a>
# **DeleteInvoiceLog**
> void DeleteInvoiceLog (int? id)

Delete an existing invoice log

Calls the delete() function in InvoiceLog.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteInvoiceLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceLogApi();
            var id = 56;  // int? | Id of invoice log you want to delete

            try
            {
                // Delete an existing invoice log
                apiInstance.DeleteInvoiceLog(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceLogApi.DeleteInvoiceLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice log you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoicelogs"></a>
# **GetInvoiceLogs**
> ModelInvoiceLog GetInvoiceLogs (int? limit, int? offset, List<string> embed)

Get an overview of invoice logs

Calls InvoiceLog.php to get necessary variables

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetInvoiceLogsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceLogApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned invoice logs start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of invoice logs
                ModelInvoiceLog result = apiInstance.GetInvoiceLogs(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceLogApi.GetInvoiceLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned invoice logs start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelInvoiceLog**](ModelInvoiceLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinvoicelog"></a>
# **UpdateInvoiceLog**
> ModelInvoiceLog UpdateInvoiceLog (int? id, string body)

Update an existing invoice log

Calls InvoiceLog.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateInvoiceLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoiceLogApi();
            var id = 56;  // int? | Id of invoice log you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create invoice log.    Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks! (optional) 

            try
            {
                // Update an existing invoice log
                ModelInvoiceLog result = apiInstance.UpdateInvoiceLog(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceLogApi.UpdateInvoiceLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of invoice log you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create invoice log.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks! | [optional] 

### Return type

[**ModelInvoiceLog**](ModelInvoiceLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

