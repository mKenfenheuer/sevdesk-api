# SevDeskApi.Api.AccountingTypeApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountingTypeGetAccountingNumber**](AccountingTypeApi.md#accountingtypegetaccountingnumber) | **GET** /AccountingType/{id}/getAccountingNumber | Get accounting system number of the specified accounting type
[**AccountingTypeGetAccountingNumberDepreciation**](AccountingTypeApi.md#accountingtypegetaccountingnumberdepreciation) | **GET** /AccountingType/{id}/getAccountingNumberDepreciation | Get accounting system number depreciation of the specified accounting type
[**AccountingTypeGetAccountingSystemNumber**](AccountingTypeApi.md#accountingtypegetaccountingsystemnumber) | **GET** /AccountingType/{id}/getAccountingSystemNumber | Get accounting system number of the specified accounting type
[**AddAccountingType**](AccountingTypeApi.md#addaccountingtype) | **POST** /AccountingType | Create a new accounting type
[**AddAccountingTypeFactory**](AccountingTypeApi.md#addaccountingtypefactory) | **POST** /AccountingType/Factory/createType | Create a new accounting type
[**DeleteAccountingType**](AccountingTypeApi.md#deleteaccountingtype) | **DELETE** /AccountingType/{id} | Delete an existing accounting type
[**GetAccountingTypes**](AccountingTypeApi.md#getaccountingtypes) | **GET** /AccountingType | Get an overview of all accounting types
[**UpdateAccountingType**](AccountingTypeApi.md#updateaccountingtype) | **PUT** /AccountingType/{id} | Update an existing accounting type


<a name="accountingtypegetaccountingnumber"></a>
# **AccountingTypeGetAccountingNumber**
> void AccountingTypeGetAccountingNumber (int? id)

Get accounting system number of the specified accounting type

Calls getAccountingNumber() in AccountingType.php to get the accounting system number of the specified accounting type.    Basically this function does just calls getAccountingSystemNumber() and returns just the number, not the model.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AccountingTypeGetAccountingNumberExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingTypeApi();
            var id = 56;  // int? | Id of the accounting type for which you want to get the accounting system number

            try
            {
                // Get accounting system number of the specified accounting type
                apiInstance.AccountingTypeGetAccountingNumber(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingTypeApi.AccountingTypeGetAccountingNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the accounting type for which you want to get the accounting system number | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountingtypegetaccountingnumberdepreciation"></a>
# **AccountingTypeGetAccountingNumberDepreciation**
> void AccountingTypeGetAccountingNumberDepreciation (int? id)

Get accounting system number depreciation of the specified accounting type

Calls getAccountingNumberDepreciation() in AccountingType.php to get the accounting system number depreciation of the specified accounting type.    Basically this function does just calls getAccountingSystemNumber() and returns just the depreciation, not the model.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AccountingTypeGetAccountingNumberDepreciationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingTypeApi();
            var id = 56;  // int? | Id of the accounting type for which you want to get the accounting system number depreciation

            try
            {
                // Get accounting system number depreciation of the specified accounting type
                apiInstance.AccountingTypeGetAccountingNumberDepreciation(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingTypeApi.AccountingTypeGetAccountingNumberDepreciation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the accounting type for which you want to get the accounting system number depreciation | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountingtypegetaccountingsystemnumber"></a>
# **AccountingTypeGetAccountingSystemNumber**
> ModelAccountingSystemNumber AccountingTypeGetAccountingSystemNumber (int? id, List<string> embed)

Get accounting system number of the specified accounting type

Calls getAccountingSystemNumber() in AccountingType.php to get the accounting system number of the specified accounting type.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AccountingTypeGetAccountingSystemNumberExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingTypeApi();
            var id = 56;  // int? | Id of the accounting type for which you want to get the accounting system number
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get accounting system number of the specified accounting type
                ModelAccountingSystemNumber result = apiInstance.AccountingTypeGetAccountingSystemNumber(id, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingTypeApi.AccountingTypeGetAccountingSystemNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the accounting type for which you want to get the accounting system number | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelAccountingSystemNumber**](ModelAccountingSystemNumber.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addaccountingtype"></a>
# **AddAccountingType**
> ModelAccountingType AddAccountingType (string body)

Create a new accounting type

Calls AccountingType.php 

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddAccountingTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingTypeApi();
            var body = "parent[id]=&parent[objectName]=AccountingType&name=&type=&assetType=N&status=100";  // string | To create an accounting type, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new accounting type
                ModelAccountingType result = apiInstance.AddAccountingType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingTypeApi.AddAccountingType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an accounting type, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelAccountingType**](ModelAccountingType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addaccountingtypefactory"></a>
# **AddAccountingTypeFactory**
> ModelAccountingType AddAccountingTypeFactory (string body)

Create a new accounting type

With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the Model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new invoice it wont be saved by a POST request with '/Invoice?para1=&...' but with the saveInvoice function in Factory.php 'Voucher/Factory/saveInvoice?para1='

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddAccountingTypeFactoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingTypeApi();
            var body = "name=&type=&number=&assetType=N&numberDepreciation=&automatic=";  // string | To create an accounting type, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new accounting type
                ModelAccountingType result = apiInstance.AddAccountingTypeFactory(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingTypeApi.AddAccountingTypeFactory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an accounting type, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelAccountingType**](ModelAccountingType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccountingtype"></a>
# **DeleteAccountingType**
> void DeleteAccountingType (int? id)

Delete an existing accounting type

Calls the delete() function in AccountingType.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteAccountingTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingTypeApi();
            var id = 56;  // int? | id of accounting type you want to delete

            try
            {
                // Delete an existing accounting type
                apiInstance.DeleteAccountingType(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingTypeApi.DeleteAccountingType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of accounting type you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountingtypes"></a>
# **GetAccountingTypes**
> ModelAccountingType GetAccountingTypes (int? limit, int? offset, List<string> embed)

Get an overview of all accounting types

Calls AccountingType.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetAccountingTypesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingTypeApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 1000 (optional)  (default to 1000)
            var offset = 56;  // int? | Set the index where the returned accounting types start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all accounting types
                ModelAccountingType result = apiInstance.GetAccountingTypes(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingTypeApi.GetAccountingTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 1000 | [optional] [default to 1000]
 **offset** | **int?**| Set the index where the returned accounting types start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelAccountingType**](ModelAccountingType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccountingtype"></a>
# **UpdateAccountingType**
> ModelAccountingType UpdateAccountingType (int? id, string body)

Update an existing accounting type

Calls AccountingType.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateAccountingTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingTypeApi();
            var id = 56;  // int? | id of accounting type you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create accounting type.    Append the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks! (optional) 

            try
            {
                // Update an existing accounting type
                ModelAccountingType result = apiInstance.UpdateAccountingType(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingTypeApi.UpdateAccountingType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of accounting type you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create accounting type.    Append the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks! | [optional] 

### Return type

[**ModelAccountingType**](ModelAccountingType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

