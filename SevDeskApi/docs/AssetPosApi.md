# SevDeskApi.Api.AssetPosApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAssetPos**](AssetPosApi.md#addassetpos) | **POST** /AssetPos | Create a new asset position
[**DeleteAssetPosition**](AssetPosApi.md#deleteassetposition) | **DELETE** /AssetPos/{id} | Delete an existing asset position
[**GetAssetPositions**](AssetPosApi.md#getassetpositions) | **GET** /AssetPos | Get an overview of all asset positions
[**UpdateAssetPosition**](AssetPosApi.md#updateassetposition) | **PUT** /AssetPos/{id} | Update an existing asset position


<a name="addassetpos"></a>
# **AddAssetPos**
> ModelAssetPos AddAssetPos (string body)

Create a new asset position

Calls AssetPos.php 

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddAssetPosExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AssetPosApi();
            var body = "asset[id]=&asset[objectName]=Asset&year=&month=&depreciationAmount=&residualValue=";  // string | To create an asset position, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new asset position
                ModelAssetPos result = apiInstance.AddAssetPos(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetPosApi.AddAssetPos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an asset position, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelAssetPos**](ModelAssetPos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteassetposition"></a>
# **DeleteAssetPosition**
> void DeleteAssetPosition (int? id)

Delete an existing asset position

Calls the delete() function in AssetPos.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteAssetPositionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AssetPosApi();
            var id = 56;  // int? | id of asset position you want to delete

            try
            {
                // Delete an existing asset position
                apiInstance.DeleteAssetPosition(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetPosApi.DeleteAssetPosition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of asset position you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassetpositions"></a>
# **GetAssetPositions**
> ModelAssetPos GetAssetPositions (int? limit, int? offset, List<string> embed)

Get an overview of all asset positions

Calls AssetPos.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetAssetPositionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AssetPosApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned assets start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all asset positions
                ModelAssetPos result = apiInstance.GetAssetPositions(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetPosApi.GetAssetPositions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned assets start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelAssetPos**](ModelAssetPos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateassetposition"></a>
# **UpdateAssetPosition**
> ModelAssetPos UpdateAssetPosition (int? id, string body)

Update an existing asset position

Calls AssetPos.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateAssetPositionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AssetPosApi();
            var id = 56;  // int? | id of asset position you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create asset position.    Append the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks! (optional) 

            try
            {
                // Update an existing asset position
                ModelAssetPos result = apiInstance.UpdateAssetPosition(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetPosApi.UpdateAssetPosition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of asset position you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create asset position.    Append the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks! | [optional] 

### Return type

[**ModelAssetPos**](ModelAssetPos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

