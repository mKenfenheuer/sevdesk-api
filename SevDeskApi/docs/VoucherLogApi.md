# SevDeskApi.Api.VoucherLogApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVoucherLogEntry**](VoucherLogApi.md#addvoucherlogentry) | **POST** /VoucherLog | Create a new voucher log entry
[**DeleteVoucherLogEntry**](VoucherLogApi.md#deletevoucherlogentry) | **DELETE** /VoucherLog/{id} | Delete an existing voucher log entry
[**GetVoucherLog**](VoucherLogApi.md#getvoucherlog) | **GET** /VoucherLog | Get an overview of all voucher log entries
[**UpdateVoucherLogEntry**](VoucherLogApi.md#updatevoucherlogentry) | **PUT** /VoucherLog/{id} | Update an existing voucher log entry


<a name="addvoucherlogentry"></a>
# **AddVoucherLogEntry**
> ModelVoucherLog AddVoucherLogEntry (string body)

Create a new voucher log entry

Calls VoucherLog.php to create a voucher log entry

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddVoucherLogEntryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherLogApi();
            var body = "voucher[id]=&voucher[objectName]=Voucher&fromStatus=&toStatus=&amountPayed=&bookingDate=";  // string | To create a voucher, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new voucher log entry
                ModelVoucherLog result = apiInstance.AddVoucherLogEntry(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherLogApi.AddVoucherLogEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a voucher, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelVoucherLog**](ModelVoucherLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevoucherlogentry"></a>
# **DeleteVoucherLogEntry**
> void DeleteVoucherLogEntry (int? id)

Delete an existing voucher log entry

Calls the delete() function in VoucherLog.php to delete a voucher log entry

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteVoucherLogEntryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherLogApi();
            var id = 56;  // int? | Id of voucher log entry you want to delete

            try
            {
                // Delete an existing voucher log entry
                apiInstance.DeleteVoucherLogEntry(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherLogApi.DeleteVoucherLogEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of voucher log entry you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvoucherlog"></a>
# **GetVoucherLog**
> ModelVoucherLog GetVoucherLog (int? limit, int? offset, List<string> embed)

Get an overview of all voucher log entries

Calls VoucherLog.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetVoucherLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherLogApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned voucher log entries start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all voucher log entries
                ModelVoucherLog result = apiInstance.GetVoucherLog(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherLogApi.GetVoucherLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned voucher log entries start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelVoucherLog**](ModelVoucherLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevoucherlogentry"></a>
# **UpdateVoucherLogEntry**
> ModelVoucherLog UpdateVoucherLogEntry (int? id, string body)

Update an existing voucher log entry

Calls VoucherLog.php to update an existing voucher log entry

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateVoucherLogEntryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherLogApi();
            var id = 56;  // int? | Id of the voucher log entry you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create voucher log entry.    Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // Update an existing voucher log entry
                ModelVoucherLog result = apiInstance.UpdateVoucherLogEntry(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherLogApi.UpdateVoucherLogEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher log entry you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create voucher log entry.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelVoucherLog**](ModelVoucherLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

