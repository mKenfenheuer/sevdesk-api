# SevDeskApi.Api.PartContactPriceApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPartContactPrice**](PartContactPriceApi.md#addpartcontactprice) | **POST** /PartContactPrice | Create a new part contact price
[**DeletePartContactPrice**](PartContactPriceApi.md#deletepartcontactprice) | **DELETE** /PartContactPrice/{id} | Delete an existing part contact price
[**GetPartContactPrices**](PartContactPriceApi.md#getpartcontactprices) | **GET** /PartContactPrice | Get an overview of all part contact prices
[**UpdatePartContactPrice**](PartContactPriceApi.md#updatepartcontactprice) | **PUT** /PartContactPrice/{id} | Update an existing part contact price


<a name="addpartcontactprice"></a>
# **AddPartContactPrice**
> ModelPartContactPrice AddPartContactPrice (string body)

Create a new part contact price

Calls PartContactPrice.php to add a part contact price

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddPartContactPriceExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PartContactPriceApi();
            var body = "contact[id]=&contact[objectName]=Contact&part[id]=&part[objectName]=Part&type=&priceNet=&priceGross=";  // string | To create a part contact price, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new part contact price
                ModelPartContactPrice result = apiInstance.AddPartContactPrice(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartContactPriceApi.AddPartContactPrice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a part contact price, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelPartContactPrice**](ModelPartContactPrice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepartcontactprice"></a>
# **DeletePartContactPrice**
> void DeletePartContactPrice (int? id)

Delete an existing part contact price

Calls PartContactPrice.php to delete a part contact price

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeletePartContactPriceExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PartContactPriceApi();
            var id = 56;  // int? | id of the part contact price you want to delete

            try
            {
                // Delete an existing part contact price
                apiInstance.DeletePartContactPrice(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartContactPriceApi.DeletePartContactPrice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of the part contact price you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpartcontactprices"></a>
# **GetPartContactPrices**
> ModelPartContactPrice GetPartContactPrices (int? limit, int? offset, List<string> embed)

Get an overview of all part contact prices

Calls PartContactPrice.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetPartContactPricesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PartContactPriceApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned part contact prices start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all part contact prices
                ModelPartContactPrice result = apiInstance.GetPartContactPrices(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartContactPriceApi.GetPartContactPrices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned part contact prices start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelPartContactPrice**](ModelPartContactPrice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepartcontactprice"></a>
# **UpdatePartContactPrice**
> ModelPartContactPrice UpdatePartContactPrice (int? id, string body)

Update an existing part contact price

Calls PartContactPrice.php to update a part contact price

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdatePartContactPriceExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PartContactPriceApi();
            var id = 56;  // int? | id of part contact price you want to update
            var body = body_example;  // string | Parameters which need to be updated. Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // Update an existing part contact price
                ModelPartContactPrice result = apiInstance.UpdatePartContactPrice(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartContactPriceApi.UpdatePartContactPrice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of part contact price you want to update | 
 **body** | **string**| Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelPartContactPrice**](ModelPartContactPrice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

