# SevDeskApi.Api.TaxSetApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTaxSet**](TaxSetApi.md#addtaxset) | **POST** /TaxSet | Create a new tax set
[**DeleteTaxSet**](TaxSetApi.md#deletetaxset) | **DELETE** /TaxSet/{id} | Delete an existing tax set
[**GetTaxSets**](TaxSetApi.md#gettaxsets) | **GET** /TaxSet | Get an overview of all tax sets
[**UpdateTaxSet**](TaxSetApi.md#updatetaxset) | **PUT** /TaxSet/{id} | Update an existing tax set


<a name="addtaxset"></a>
# **AddTaxSet**
> ModelTaxSet AddTaxSet (string body)

Create a new tax set

Calls TaxSet.php to create a new tax set

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddTaxSetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TaxSetApi();
            var body = "text=&taxRate=&showInvoice=&showDebitVoucher=&showCreditVoucher=";  // string | To create a tax set, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new tax set
                ModelTaxSet result = apiInstance.AddTaxSet(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxSetApi.AddTaxSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a tax set, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelTaxSet**](ModelTaxSet.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetaxset"></a>
# **DeleteTaxSet**
> void DeleteTaxSet (int? id)

Delete an existing tax set

Calls the delete() function in TaxSet.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteTaxSetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TaxSetApi();
            var id = 56;  // int? | Id of tax set you want to delete

            try
            {
                // Delete an existing tax set
                apiInstance.DeleteTaxSet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxSetApi.DeleteTaxSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of tax set you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaxsets"></a>
# **GetTaxSets**
> ModelTaxSet GetTaxSets (int? limit, int? offset, List<string> embed)

Get an overview of all tax sets

Calls TaxSet.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetTaxSetsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TaxSetApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned tax sets start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all tax sets
                ModelTaxSet result = apiInstance.GetTaxSets(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxSetApi.GetTaxSets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned tax sets start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelTaxSet**](ModelTaxSet.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetaxset"></a>
# **UpdateTaxSet**
> ModelTaxSet UpdateTaxSet (int? id, string body)

Update an existing tax set

Calls TaxSet.php to update an existing tax set

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateTaxSetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TaxSetApi();
            var id = 56;  // int? | Id of tax set you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create tax set.    Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update an existing tax set
                ModelTaxSet result = apiInstance.UpdateTaxSet(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxSetApi.UpdateTaxSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of tax set you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create tax set.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelTaxSet**](ModelTaxSet.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

