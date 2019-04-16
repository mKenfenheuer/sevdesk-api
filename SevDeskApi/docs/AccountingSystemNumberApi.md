# SevDeskApi.Api.AccountingSystemNumberApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAccountingSystemNumber**](AccountingSystemNumberApi.md#addaccountingsystemnumber) | **POST** /AccountingSystemNumber | Create a new accounting system number
[**DeleteAccountingSystemNumber**](AccountingSystemNumberApi.md#deleteaccountingsystemnumber) | **DELETE** /AccountingSystemNumber/{id} | Delete an existing accounting system number
[**GetAccountingSystemNumbers**](AccountingSystemNumberApi.md#getaccountingsystemnumbers) | **GET** /AccountingSystemNumber | Get an overview of all accounting system numbers
[**UpdateAccountingSystemNumber**](AccountingSystemNumberApi.md#updateaccountingsystemnumber) | **PUT** /AccountingSystemNumber/{id} | Update an existing accounting system number


<a name="addaccountingsystemnumber"></a>
# **AddAccountingSystemNumber**
> ModelAccountingSystemNumber AddAccountingSystemNumber (string body)

Create a new accounting system number

Calls AccountingSystemNumber.php 

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddAccountingSystemNumberExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingSystemNumberApi();
            var body = "number=&accountingType[id]=&accountingType[objectName]=AccountingType&accountingSystem[id]=1&accountingSystem[objectName]=AccountingSystem&objectName=AccountingSystemNumber  &id=&accountingSystemNumber=undefined";  // string | To create an accounting system number, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new accounting system number
                ModelAccountingSystemNumber result = apiInstance.AddAccountingSystemNumber(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingSystemNumberApi.AddAccountingSystemNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an accounting system number, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelAccountingSystemNumber**](ModelAccountingSystemNumber.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccountingsystemnumber"></a>
# **DeleteAccountingSystemNumber**
> void DeleteAccountingSystemNumber (int? id)

Delete an existing accounting system number

Calls the delete() function in AccountingSystemNumber.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteAccountingSystemNumberExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingSystemNumberApi();
            var id = 56;  // int? | id of accounting system number you want to delete

            try
            {
                // Delete an existing accounting system number
                apiInstance.DeleteAccountingSystemNumber(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingSystemNumberApi.DeleteAccountingSystemNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of accounting system number you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountingsystemnumbers"></a>
# **GetAccountingSystemNumbers**
> ModelAccountingSystemNumber GetAccountingSystemNumbers (int? limit, int? offset, List<string> embed)

Get an overview of all accounting system numbers

Calls AccountingSystemNumber.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetAccountingSystemNumbersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingSystemNumberApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 1000 (optional)  (default to 1000)
            var offset = 56;  // int? | Set the index where the returned accounting system numbers start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all accounting system numbers
                ModelAccountingSystemNumber result = apiInstance.GetAccountingSystemNumbers(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingSystemNumberApi.GetAccountingSystemNumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 1000 | [optional] [default to 1000]
 **offset** | **int?**| Set the index where the returned accounting system numbers start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelAccountingSystemNumber**](ModelAccountingSystemNumber.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccountingsystemnumber"></a>
# **UpdateAccountingSystemNumber**
> ModelAccountingType UpdateAccountingSystemNumber (int? id, string body)

Update an existing accounting system number

Calls AccountingSystemNumber.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateAccountingSystemNumberExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingSystemNumberApi();
            var id = 56;  // int? | id of accounting system number you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create accounting system number.    Append the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks! (optional) 

            try
            {
                // Update an existing accounting system number
                ModelAccountingType result = apiInstance.UpdateAccountingSystemNumber(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingSystemNumberApi.UpdateAccountingSystemNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of accounting system number you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create accounting system number.    Append the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks! | [optional] 

### Return type

[**ModelAccountingType**](ModelAccountingType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

