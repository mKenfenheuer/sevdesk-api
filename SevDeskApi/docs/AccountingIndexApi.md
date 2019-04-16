# SevDeskApi.Api.AccountingIndexApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAccountingIndex**](AccountingIndexApi.md#addaccountingindex) | **POST** /AccountingIndex | Create a new accounting index
[**DeleteAccountingIndex**](AccountingIndexApi.md#deleteaccountingindex) | **DELETE** /AccountingIndex/{id} | Delete an existing accounting index
[**GetAccountingIndexes**](AccountingIndexApi.md#getaccountingindexes) | **GET** /AccountingIndex | Get an overview of all accounting indexes
[**UpdateAccountingIndex**](AccountingIndexApi.md#updateaccountingindex) | **PUT** /AccountingIndex/{id} | Update an existing accounting index


<a name="addaccountingindex"></a>
# **AddAccountingIndex**
> ModelAccountingIndex AddAccountingIndex (string body)

Create a new accounting index

Calls AccountingIndex.php to add an accounting index

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddAccountingIndexExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingIndexApi();
            var body = "keyword=&accountingType[id]=&accountingType[objectName]=AccountingType&taxType=default";  // string | To create an accounting index, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new accounting index
                ModelAccountingIndex result = apiInstance.AddAccountingIndex(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingIndexApi.AddAccountingIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an accounting index, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelAccountingIndex**](ModelAccountingIndex.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccountingindex"></a>
# **DeleteAccountingIndex**
> void DeleteAccountingIndex (int? id)

Delete an existing accounting index

Calls AccountingIndex.php to delete an accounting index

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteAccountingIndexExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingIndexApi();
            var id = 56;  // int? | id of the accounting index you want to delete

            try
            {
                // Delete an existing accounting index
                apiInstance.DeleteAccountingIndex(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingIndexApi.DeleteAccountingIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of the accounting index you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountingindexes"></a>
# **GetAccountingIndexes**
> ModelAccountingIndex GetAccountingIndexes (int? limit, int? offset, List<string> embed)

Get an overview of all accounting indexes

Calls AccountingIndex.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetAccountingIndexesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingIndexApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned accounting indexes start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all accounting indexes
                ModelAccountingIndex result = apiInstance.GetAccountingIndexes(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingIndexApi.GetAccountingIndexes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned accounting indexes start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelAccountingIndex**](ModelAccountingIndex.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccountingindex"></a>
# **UpdateAccountingIndex**
> ModelAccountingIndex UpdateAccountingIndex (int? id, string body)

Update an existing accounting index

Calls AccountingIndex.php to update an accounting index

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateAccountingIndexExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingIndexApi();
            var id = 56;  // int? | id of accounting index you want to update
            var body = body_example;  // string | Parameters which need to be updated. Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // Update an existing accounting index
                ModelAccountingIndex result = apiInstance.UpdateAccountingIndex(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingIndexApi.UpdateAccountingIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of accounting index you want to update | 
 **body** | **string**| Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelAccountingIndex**](ModelAccountingIndex.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

