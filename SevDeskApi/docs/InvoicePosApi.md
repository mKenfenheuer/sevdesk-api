# SevDeskApi.Api.InvoicePosApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInvoicePos**](InvoicePosApi.md#addinvoicepos) | **POST** /InvoicePos | Create a new invoice position
[**DeleteInvoicePos**](InvoicePosApi.md#deleteinvoicepos) | **DELETE** /InvoicePos/{id} | Delete an existing invoice position
[**GetInvoicePositions**](InvoicePosApi.md#getinvoicepositions) | **GET** /InvoicePos | Get an overview of all invoice positions
[**UpdateInvoicePos**](InvoicePosApi.md#updateinvoicepos) | **PUT** /InvoicePos/{id} | Update an existing invoice position


<a name="addinvoicepos"></a>
# **AddInvoicePos**
> ModelInvoicePos AddInvoicePos (string body)

Create a new invoice position

Calls InvoicePos.php.    As described in the Model_Invoice earlier, some of its parameters get their value from other models/functions.    InvoicePos is one of those Models and provides the ability to add products/parts to your invoice which fills values like sumNet,taxation, etc.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddInvoicePosExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoicePosApi();
            var body = "invoice[id]=210&invoice[objectName]=Invoice&name=Pizza&quantity=1&price=4.5&unity[id]=1&unity[objectName]=Unity&taxRate=7";  // string | To create an invoice position, simply enter desired values after parameter= and remove the quotation marks.    Adds a product/part to an invoice with a price, quantity etc, therefore the invoice model gets sumNet and other parameters from it too

            try
            {
                // Create a new invoice position
                ModelInvoicePos result = apiInstance.AddInvoicePos(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicePosApi.AddInvoicePos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an invoice position, simply enter desired values after parameter&#x3D; and remove the quotation marks.    Adds a product/part to an invoice with a price, quantity etc, therefore the invoice model gets sumNet and other parameters from it too | 

### Return type

[**ModelInvoicePos**](ModelInvoicePos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinvoicepos"></a>
# **DeleteInvoicePos**
> void DeleteInvoicePos (int? id)

Delete an existing invoice position

Calls the delete() function in InvoicePos.php. This does NOT delete an invoice, just the position which belonged to the invoice!

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteInvoicePosExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoicePosApi();
            var id = 56;  // int? | id of invoice position you want to delete

            try
            {
                // Delete an existing invoice position
                apiInstance.DeleteInvoicePos(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicePosApi.DeleteInvoicePos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of invoice position you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoicepositions"></a>
# **GetInvoicePositions**
> ModelInvoicePos GetInvoicePositions (int? limit, int? offset, List<string> embed)

Get an overview of all invoice positions

Calls InvoicePos.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetInvoicePositionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoicePosApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned invoice positions start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all invoice positions
                ModelInvoicePos result = apiInstance.GetInvoicePositions(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicePosApi.GetInvoicePositions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned invoice positions start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelInvoicePos**](ModelInvoicePos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinvoicepos"></a>
# **UpdateInvoicePos**
> ModelInvoicePos UpdateInvoicePos (int? id, string body)

Update an existing invoice position

TODO: Enter short backend documentation here

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateInvoicePosExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new InvoicePosApi();
            var id = 56;  // int? | id of invoice position you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create invoice position.     Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // Update an existing invoice position
                ModelInvoicePos result = apiInstance.UpdateInvoicePos(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicePosApi.UpdateInvoicePos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of invoice position you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create invoice position.     Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelInvoicePos**](ModelInvoicePos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

