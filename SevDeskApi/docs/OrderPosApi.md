# SevDeskApi.Api.OrderPosApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrderPos**](OrderPosApi.md#addorderpos) | **POST** /OrderPos | Create a new order position
[**DeleteOrderPos**](OrderPosApi.md#deleteorderpos) | **DELETE** /OrderPos/{id} | Delete an existing order position
[**GetOrderPositions**](OrderPosApi.md#getorderpositions) | **GET** /OrderPos | Get an overview of all order positions
[**UpdateOrderPos**](OrderPosApi.md#updateorderpos) | **PUT** /OrderPos/{id} | Update an existing order position


<a name="addorderpos"></a>
# **AddOrderPos**
> ModelOrderPos AddOrderPos (string body)

Create a new order position

Calls OrderPos.php.     As described in the Model_Order earlier, some of its parameters get their value from other models/functions.     OrderPos is one of those Models and provides the ability to add products/parts to your order which fills values like sumNet,taxation, etc.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddOrderPosExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderPosApi();
            var body = "order[id]=194409&order[objectName]=Order&quantity=1&price=5.42&taxRate=19&unity[id]=1&unity[objectName]=Unity";  // string | To create an order position, simply enter desired values after parameter= and remove the quotation marks.      Adds a product/part to an order with a price, quantity etc, therefore the order model gets sumNet and other parameters from it too

            try
            {
                // Create a new order position
                ModelOrderPos result = apiInstance.AddOrderPos(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderPosApi.AddOrderPos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an order position, simply enter desired values after parameter&#x3D; and remove the quotation marks.      Adds a product/part to an order with a price, quantity etc, therefore the order model gets sumNet and other parameters from it too | 

### Return type

[**ModelOrderPos**](ModelOrderPos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderpos"></a>
# **DeleteOrderPos**
> void DeleteOrderPos (int? id)

Delete an existing order position

Calls the delete() function in OrderPos.php. This does NOT delete an order, just the position which belonged to the order!

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteOrderPosExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderPosApi();
            var id = 56;  // int? | id of order position you want to delete

            try
            {
                // Delete an existing order position
                apiInstance.DeleteOrderPos(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderPosApi.DeleteOrderPos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of order position you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderpositions"></a>
# **GetOrderPositions**
> ModelOrderPos GetOrderPositions (int? limit, int? offset, List<string> embed)

Get an overview of all order positions

Calls OrderPos.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetOrderPositionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderPosApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned order positions start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all order positions
                ModelOrderPos result = apiInstance.GetOrderPositions(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderPosApi.GetOrderPositions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned order positions start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelOrderPos**](ModelOrderPos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorderpos"></a>
# **UpdateOrderPos**
> ModelOrderPos UpdateOrderPos (int? id, string body)

Update an existing order position

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
    public class UpdateOrderPosExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderPosApi();
            var id = 56;  // int? | id of order position you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create order position.        Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // Update an existing order position
                ModelOrderPos result = apiInstance.UpdateOrderPos(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderPosApi.UpdateOrderPos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of order position you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create order position.        Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelOrderPos**](ModelOrderPos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

