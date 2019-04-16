# SevDeskApi.Api.CheckAccountTransactionLogApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCheckAccountTransactionLog**](CheckAccountTransactionLogApi.md#addcheckaccounttransactionlog) | **POST** /CheckAccountTransactionLog | Create a new logged check account transaction
[**DeleteCheckAccountTransactionLog**](CheckAccountTransactionLogApi.md#deletecheckaccounttransactionlog) | **DELETE** /CheckAccountTransactionLog/{id} | Delete an existing logged check account transaction
[**GetCheckAccountTransactionLog**](CheckAccountTransactionLogApi.md#getcheckaccounttransactionlog) | **GET** /CheckAccountTransactionLog | Get an overview of all check account transactions which were logged
[**UpdateCheckAccountTransactionLog**](CheckAccountTransactionLogApi.md#updatecheckaccounttransactionlog) | **PUT** /CheckAccountTransactionLog/{id} | Update a existing logged check account transaction


<a name="addcheckaccounttransactionlog"></a>
# **AddCheckAccountTransactionLog**
> ModelCheckAccountTransactionLog AddCheckAccountTransactionLog (string body)

Create a new logged check account transaction

Calls CheckAccountTransactionLog.php 

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddCheckAccountTransactionLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountTransactionLogApi();
            var body = "checkAccountTransaction[id]=&checkAccountTransaction[objectName]=CheckAccountTransaction&fromStatus=&toStatus=&bookingDate=";  // string | To create a logged check account transaction , simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new logged check account transaction
                ModelCheckAccountTransactionLog result = apiInstance.AddCheckAccountTransactionLog(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountTransactionLogApi.AddCheckAccountTransactionLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a logged check account transaction , simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelCheckAccountTransactionLog**](ModelCheckAccountTransactionLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecheckaccounttransactionlog"></a>
# **DeleteCheckAccountTransactionLog**
> void DeleteCheckAccountTransactionLog (int? id)

Delete an existing logged check account transaction

Calls the delete() function in CheckAccountTransactionLog.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteCheckAccountTransactionLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountTransactionLogApi();
            var id = 56;  // int? | id of logged check account transaction you want to delete

            try
            {
                // Delete an existing logged check account transaction
                apiInstance.DeleteCheckAccountTransactionLog(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountTransactionLogApi.DeleteCheckAccountTransactionLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of logged check account transaction you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcheckaccounttransactionlog"></a>
# **GetCheckAccountTransactionLog**
> ModelCheckAccountTransactionLog GetCheckAccountTransactionLog (int? limit, int? offset, List<string> embed)

Get an overview of all check account transactions which were logged

Calls CheckAccountTransactionLog.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetCheckAccountTransactionLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountTransactionLogApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned logged check account transactions start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all check account transactions which were logged
                ModelCheckAccountTransactionLog result = apiInstance.GetCheckAccountTransactionLog(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountTransactionLogApi.GetCheckAccountTransactionLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned logged check account transactions start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelCheckAccountTransactionLog**](ModelCheckAccountTransactionLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecheckaccounttransactionlog"></a>
# **UpdateCheckAccountTransactionLog**
> ModelCheckAccountTransactionLog UpdateCheckAccountTransactionLog (int? id, string body)

Update a existing logged check account transaction

Calls CheckAccountTransactionLog.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateCheckAccountTransactionLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountTransactionLogApi();
            var id = 56;  // int? | id of logged check account transaction you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create check account transaction log.    Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update a existing logged check account transaction
                ModelCheckAccountTransactionLog result = apiInstance.UpdateCheckAccountTransactionLog(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountTransactionLogApi.UpdateCheckAccountTransactionLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of logged check account transaction you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create check account transaction log.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelCheckAccountTransactionLog**](ModelCheckAccountTransactionLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

