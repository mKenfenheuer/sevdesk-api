# SevDeskApi.Api.OrderLogApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrderLog**](OrderLogApi.md#addorderlog) | **POST** /OrderLog | Create a new order log
[**DeleteOrderLog**](OrderLogApi.md#deleteorderlog) | **DELETE** /OrderLog/{id} | Delete an existing order log
[**GetOrderLogs**](OrderLogApi.md#getorderlogs) | **GET** /OrderLog | Get an overview of order logs
[**UpdateOrderLog**](OrderLogApi.md#updateorderlog) | **PUT** /OrderLog/{id} | Update an existing order log


<a name="addorderlog"></a>
# **AddOrderLog**
> ModelOrderLog AddOrderLog (string body)

Create a new order log

Calls OrderLog.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddOrderLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderLogApi();
            var body = "date=&order[id]=&order[objectName]=Order&object[id]=&object[objectName]=&currency=EUR&amount=&taxRate=&amountType=";  // string | To create an order log, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new order log
                ModelOrderLog result = apiInstance.AddOrderLog(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLogApi.AddOrderLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an order log, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelOrderLog**](ModelOrderLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderlog"></a>
# **DeleteOrderLog**
> void DeleteOrderLog (int? id)

Delete an existing order log

Calls the delete() function in OrderLog.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteOrderLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderLogApi();
            var id = 56;  // int? | Id of order log you want to delete

            try
            {
                // Delete an existing order log
                apiInstance.DeleteOrderLog(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLogApi.DeleteOrderLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of order log you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlogs"></a>
# **GetOrderLogs**
> ModelOrderLog GetOrderLogs (int? limit, int? offset, List<string> embed)

Get an overview of order logs

Calls OrderLog.php to get necessary variables

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetOrderLogsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderLogApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned order logs start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of order logs
                ModelOrderLog result = apiInstance.GetOrderLogs(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLogApi.GetOrderLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned order logs start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelOrderLog**](ModelOrderLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorderlog"></a>
# **UpdateOrderLog**
> ModelOrderLog UpdateOrderLog (int? id, string body)

Update an existing order log

Calls OrderLog.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateOrderLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderLogApi();
            var id = 56;  // int? | Id of order log you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create order log.    Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks! (optional) 

            try
            {
                // Update an existing order log
                ModelOrderLog result = apiInstance.UpdateOrderLog(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLogApi.UpdateOrderLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of order log you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create order log.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks! | [optional] 

### Return type

[**ModelOrderLog**](ModelOrderLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

