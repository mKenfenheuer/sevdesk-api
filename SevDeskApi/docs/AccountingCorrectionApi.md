# SevDeskApi.Api.AccountingCorrectionApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAccountingCorrection**](AccountingCorrectionApi.md#addaccountingcorrection) | **POST** /AccountingCorrection | Create a new accounting correction
[**DeleteAccountingCorrection**](AccountingCorrectionApi.md#deleteaccountingcorrection) | **DELETE** /AccountingCorrection/{id} | Delete an existing accounting correction
[**GetAccountingCorrections**](AccountingCorrectionApi.md#getaccountingcorrections) | **GET** /AccountingCorrection | Get an overview of all accounting corrections
[**UpdateAccountingCorrection**](AccountingCorrectionApi.md#updateaccountingcorrection) | **PUT** /AccountingCorrection/{id} | Update an existing accounting correction


<a name="addaccountingcorrection"></a>
# **AddAccountingCorrection**
> ModelAccountingCorrection AddAccountingCorrection (string body)

Create a new accounting correction

Calls AccountingCorrection.php to add an accounting correction

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddAccountingCorrectionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingCorrectionApi();
            var body = "object[id]=&object[objectName]=&accountingType[id]=&accountingType[objectName]=AccountingType&ammount=";  // string | To create an accounting correction, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new accounting correction
                ModelAccountingCorrection result = apiInstance.AddAccountingCorrection(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingCorrectionApi.AddAccountingCorrection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an accounting correction, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelAccountingCorrection**](ModelAccountingCorrection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccountingcorrection"></a>
# **DeleteAccountingCorrection**
> void DeleteAccountingCorrection (int? id)

Delete an existing accounting correction

Calls AccountingCorrection.php to delete an accounting correction

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteAccountingCorrectionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingCorrectionApi();
            var id = 56;  // int? | id of the accounting correction you want to delete

            try
            {
                // Delete an existing accounting correction
                apiInstance.DeleteAccountingCorrection(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingCorrectionApi.DeleteAccountingCorrection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of the accounting correction you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountingcorrections"></a>
# **GetAccountingCorrections**
> ModelAccountingCorrection GetAccountingCorrections (int? limit, int? offset, List<string> embed)

Get an overview of all accounting corrections

Calls AccountingCorrection.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetAccountingCorrectionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingCorrectionApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned accounting corrections start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all accounting corrections
                ModelAccountingCorrection result = apiInstance.GetAccountingCorrections(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingCorrectionApi.GetAccountingCorrections: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned accounting corrections start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelAccountingCorrection**](ModelAccountingCorrection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccountingcorrection"></a>
# **UpdateAccountingCorrection**
> ModelAccountingCorrection UpdateAccountingCorrection (int? id, string body)

Update an existing accounting correction

Calls AccountingCorrection.php to update an accounting correction

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateAccountingCorrectionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingCorrectionApi();
            var id = 56;  // int? | id of accounting correction you want to update
            var body = body_example;  // string | Parameters which need to be updated. Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // Update an existing accounting correction
                ModelAccountingCorrection result = apiInstance.UpdateAccountingCorrection(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingCorrectionApi.UpdateAccountingCorrection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of accounting correction you want to update | 
 **body** | **string**| Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelAccountingCorrection**](ModelAccountingCorrection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

