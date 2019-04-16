# SevDeskApi.Api.InventoryPartLogApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInventoryPartLog**](InventoryPartLogApi.md#addinventorypartlog) | **POST** /InventoryPartLog | Create a new inventory part log
[**DeleteInventoryPartLog**](InventoryPartLogApi.md#deleteinventorypartlog) | **DELETE** /InventoryPartLog/{id} | Delete an existing inventory part log
[**GetInventoryPartLog**](InventoryPartLogApi.md#getinventorypartlog) | **GET** /InventoryPartLog | Get an overview of InventoryPartLog
[**GetInventoryPartLogStock**](InventoryPartLogApi.md#getinventorypartlogstock) | **GET** /InventoryPartLog/{id}/getStock | Get stock of inventory part involved in part log
[**UpdateInventoryPartLog**](InventoryPartLogApi.md#updateinventorypartlog) | **PUT** /InventoryPartLog/{id} | Update an existing inventory part log


<a name="addinventorypartlog"></a>
# **AddInventoryPartLog**
> ModelInventoryPartLog AddInventoryPartLog (string body)

Create a new inventory part log

Calls InventoryPartLog.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddInventoryPartLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InventoryPartLogApi();
            var body = "part[id]=&part[objectName]=Part&ammount=&name=&supplier[id]=&supplier[objectName]=Contact&postingDate=";  // string | To create a inventory part log, simply enter desired values after parameter= and remove the quotation marks!    Be aware that creating an inventory part log this way is not recommended as there is no real acquisition/dispatch of a part!

            try
            {
                // Create a new inventory part log
                ModelInventoryPartLog result = apiInstance.AddInventoryPartLog(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryPartLogApi.AddInventoryPartLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a inventory part log, simply enter desired values after parameter&#x3D; and remove the quotation marks!    Be aware that creating an inventory part log this way is not recommended as there is no real acquisition/dispatch of a part! | 

### Return type

[**ModelInventoryPartLog**](ModelInventoryPartLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinventorypartlog"></a>
# **DeleteInventoryPartLog**
> void DeleteInventoryPartLog (int? id)

Delete an existing inventory part log

Calls the delete() function in InventoryPartLog.php    Be aware that this operations sets the stock of your part to the value it had before the acquisition/dispatch and deletes the corresponding feed!

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteInventoryPartLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InventoryPartLogApi();
            var id = 56;  // int? | id of inventory part log you want to delete

            try
            {
                // Delete an existing inventory part log
                apiInstance.DeleteInventoryPartLog(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryPartLogApi.DeleteInventoryPartLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of inventory part log you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorypartlog"></a>
# **GetInventoryPartLog**
> ModelInventoryPartLog GetInventoryPartLog (int? limit, int? offset, List<string> embed)

Get an overview of InventoryPartLog

Calls InventoryPartLog.php to get necessary variables

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetInventoryPartLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InventoryPartLogApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned part logs start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of InventoryPartLog
                ModelInventoryPartLog result = apiInstance.GetInventoryPartLog(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryPartLogApi.GetInventoryPartLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned part logs start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelInventoryPartLog**](ModelInventoryPartLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorypartlogstock"></a>
# **GetInventoryPartLogStock**
> void GetInventoryPartLogStock (int? id)

Get stock of inventory part involved in part log

Calls getStock() in InventoryPartLog.php to get the stock of the part involved in the part log

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetInventoryPartLogStockExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InventoryPartLogApi();
            var id = 56;  // int? | Id of inventory part log you want to get the stock from

            try
            {
                // Get stock of inventory part involved in part log
                apiInstance.GetInventoryPartLogStock(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryPartLogApi.GetInventoryPartLogStock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of inventory part log you want to get the stock from | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinventorypartlog"></a>
# **UpdateInventoryPartLog**
> ModelInventoryPartLog UpdateInventoryPartLog (int? id, string body)

Update an existing inventory part log

Calls InventoryPartLog.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateInventoryPartLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InventoryPartLogApi();
            var id = 56;  // int? | id of inventory part log you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create inventory part log.    Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks!    Be aware that updating an existing inventory part log is not recommended unless its for correcting wrong data in the database! (optional) 

            try
            {
                // Update an existing inventory part log
                ModelInventoryPartLog result = apiInstance.UpdateInventoryPartLog(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryPartLogApi.UpdateInventoryPartLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of inventory part log you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create inventory part log.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks!    Be aware that updating an existing inventory part log is not recommended unless its for correcting wrong data in the database! | [optional] 

### Return type

[**ModelInventoryPartLog**](ModelInventoryPartLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

