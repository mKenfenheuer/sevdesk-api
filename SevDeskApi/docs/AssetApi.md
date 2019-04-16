# SevDeskApi.Api.AssetApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAsset**](AssetApi.md#addasset) | **POST** /Asset | Create a new asset
[**AssetGetDepreciationAmount**](AssetApi.md#assetgetdepreciationamount) | **GET** /Asset/{id}/getDepreciationAmount | Get depreciation amount of the specified asset for the given year/month
[**AssetGetResidualValue**](AssetApi.md#assetgetresidualvalue) | **GET** /Asset/{id}/getResidualValue | Get residual value of the specified asset for the given year/month
[**AssetGetVoucher**](AssetApi.md#assetgetvoucher) | **GET** /Asset/{id}/getVoucher | Get voucher of the specified asset
[**DeleteAsset**](AssetApi.md#deleteasset) | **DELETE** /Asset/{id} | Delete an existing asset
[**GetAssets**](AssetApi.md#getassets) | **GET** /Asset | Get an overview of all assets
[**UpdateAsset**](AssetApi.md#updateasset) | **PUT** /Asset/{id} | Update an existing asset


<a name="addasset"></a>
# **AddAsset**
> ModelAsset AddAsset (string body)

Create a new asset

Calls Asset.php 

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddAssetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AssetApi();
            var body = "voucherPos[id]=&voucherPos[objectName]=VoucherPos&name=&usefulLife=&acquisitionDate=&purchasePrice=&taxRate=19&accountingType[id]=&accountingType[objectName]=AccountingType";  // string | To create an asset, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new asset
                ModelAsset result = apiInstance.AddAsset(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AddAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an asset, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelAsset**](ModelAsset.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assetgetdepreciationamount"></a>
# **AssetGetDepreciationAmount**
> void AssetGetDepreciationAmount (int? id, string year, string month)

Get depreciation amount of the specified asset for the given year/month

Calls getDepreciationAmount() in Asset.php to get the depreciation ammount of the specified asset for the given year/month

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AssetGetDepreciationAmountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AssetApi();
            var id = 56;  // int? | Id of the asset of which you want to get the depreciation amount
            var year = year_example;  // string | year for which you want to get the depreciation amount (optional)  (default to )
            var month = month_example;  // string | month for which you want to get the depreciation amount (optional)  (default to )

            try
            {
                // Get depreciation amount of the specified asset for the given year/month
                apiInstance.AssetGetDepreciationAmount(id, year, month);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AssetGetDepreciationAmount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the asset of which you want to get the depreciation amount | 
 **year** | **string**| year for which you want to get the depreciation amount | [optional] [default to ]
 **month** | **string**| month for which you want to get the depreciation amount | [optional] [default to ]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assetgetresidualvalue"></a>
# **AssetGetResidualValue**
> void AssetGetResidualValue (int? id, string year, string month)

Get residual value of the specified asset for the given year/month

Calls getResidualValue() in Asset.php to get the residual value of the specified asset for the given year/month

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AssetGetResidualValueExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AssetApi();
            var id = 56;  // int? | Id of the asset of which you want to get the residual value
            var year = year_example;  // string | year for which you want to get the residual value (optional)  (default to )
            var month = month_example;  // string | month for which you want to get the residual value (optional)  (default to )

            try
            {
                // Get residual value of the specified asset for the given year/month
                apiInstance.AssetGetResidualValue(id, year, month);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AssetGetResidualValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the asset of which you want to get the residual value | 
 **year** | **string**| year for which you want to get the residual value | [optional] [default to ]
 **month** | **string**| month for which you want to get the residual value | [optional] [default to ]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assetgetvoucher"></a>
# **AssetGetVoucher**
> ModelVoucher AssetGetVoucher (int? id, List<string> embed)

Get voucher of the specified asset

Calls getVoucher() in Asset.php to get the voucher of the specified asset

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AssetGetVoucherExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AssetApi();
            var id = 56;  // int? | Id of the asset of which you want to get the voucher
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get voucher of the specified asset
                ModelVoucher result = apiInstance.AssetGetVoucher(id, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AssetGetVoucher: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the asset of which you want to get the voucher | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelVoucher**](ModelVoucher.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteasset"></a>
# **DeleteAsset**
> void DeleteAsset (int? id)

Delete an existing asset

Calls the delete() function in Asset.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteAssetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AssetApi();
            var id = 56;  // int? | id of asset you want to delete

            try
            {
                // Delete an existing asset
                apiInstance.DeleteAsset(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.DeleteAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of asset you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassets"></a>
# **GetAssets**
> ModelAsset GetAssets (int? limit, int? offset, List<string> embed)

Get an overview of all assets

Calls Asset.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetAssetsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AssetApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned assets start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all assets
                ModelAsset result = apiInstance.GetAssets(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssets: " + e.Message );
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

[**ModelAsset**](ModelAsset.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateasset"></a>
# **UpdateAsset**
> ModelAsset UpdateAsset (int? id, string body)

Update an existing asset

Calls Asset.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateAssetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AssetApi();
            var id = 56;  // int? | id of asset you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create asset.    Append the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks! (optional) 

            try
            {
                // Update an existing asset
                ModelAsset result = apiInstance.UpdateAsset(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.UpdateAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of asset you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create asset.    Append the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks! | [optional] 

### Return type

[**ModelAsset**](ModelAsset.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

