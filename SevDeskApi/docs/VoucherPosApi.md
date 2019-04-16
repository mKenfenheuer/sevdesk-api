# SevDeskApi.Api.VoucherPosApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVoucherPos**](VoucherPosApi.md#addvoucherpos) | **POST** /VoucherPos | Create a new voucher position
[**DeleteVoucherPos**](VoucherPosApi.md#deletevoucherpos) | **DELETE** /VoucherPos/{id} | Delete an existing voucher position
[**GetVoucherPositions**](VoucherPosApi.md#getvoucherpositions) | **GET** /VoucherPos | Get an overview of all voucher positions
[**UpdateVoucherPos**](VoucherPosApi.md#updatevoucherpos) | **PUT** /VoucherPos/{id} | Update an existing voucher position
[**VoucherPosGetAdditionalInformation**](VoucherPosApi.md#voucherposgetadditionalinformation) | **GET** /VoucherPos/{id}/getAdditionalInfo | Get additional information about the asset which is connected to a specified voucher position
[**VoucherPosGetAssetInstance**](VoucherPosApi.md#voucherposgetassetinstance) | **GET** /VoucherPos/{id}/getAssetInstance | Get the asset which is connected to a specified voucher position


<a name="addvoucherpos"></a>
# **AddVoucherPos**
> ModelVoucherPos AddVoucherPos (string body)

Create a new voucher position

Calls VoucherPos.php to create a voucher position

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddVoucherPosExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherPosApi();
            var body = "voucher[id]=&voucher[objectName]=Voucher&taxRate=&sum=&accountingType[id]=&accountingType[objectName]=AccountingType&isAsset=";  // string | To create a voucher position, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new voucher position
                ModelVoucherPos result = apiInstance.AddVoucherPos(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherPosApi.AddVoucherPos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a voucher position, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelVoucherPos**](ModelVoucherPos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevoucherpos"></a>
# **DeleteVoucherPos**
> void DeleteVoucherPos (int? id)

Delete an existing voucher position

Calls the delete() function in VoucherPos.php to delete a voucher position

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteVoucherPosExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherPosApi();
            var id = 56;  // int? | Id of voucher position you want to delete

            try
            {
                // Delete an existing voucher position
                apiInstance.DeleteVoucherPos(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherPosApi.DeleteVoucherPos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of voucher position you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvoucherpositions"></a>
# **GetVoucherPositions**
> ModelVoucherPos GetVoucherPositions (int? limit, int? offset, List<string> embed)

Get an overview of all voucher positions

Calls VoucherPos.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetVoucherPositionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherPosApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned voucher positions start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all voucher positions
                ModelVoucherPos result = apiInstance.GetVoucherPositions(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherPosApi.GetVoucherPositions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned voucher positions start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelVoucherPos**](ModelVoucherPos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevoucherpos"></a>
# **UpdateVoucherPos**
> ModelVoucherPos UpdateVoucherPos (int? id, string body)

Update an existing voucher position

Calls VoucherPos.php to update an existing voucher position

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateVoucherPosExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherPosApi();
            var id = 56;  // int? | Id of the voucher position you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create voucher position.    Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // Update an existing voucher position
                ModelVoucherPos result = apiInstance.UpdateVoucherPos(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherPosApi.UpdateVoucherPos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher position you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create voucher position.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelVoucherPos**](ModelVoucherPos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voucherposgetadditionalinformation"></a>
# **VoucherPosGetAdditionalInformation**
> void VoucherPosGetAdditionalInformation (int? id)

Get additional information about the asset which is connected to a specified voucher position

Calls getAdditionalInformation() in VoucherPos.php to get additional information about the asset which is connected to the specified voucher position

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherPosGetAdditionalInformationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherPosApi();
            var id = 56;  // int? | Id of the voucher position of which you want to get additional information about the connected asset

            try
            {
                // Get additional information about the asset which is connected to a specified voucher position
                apiInstance.VoucherPosGetAdditionalInformation(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherPosApi.VoucherPosGetAdditionalInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher position of which you want to get additional information about the connected asset | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voucherposgetassetinstance"></a>
# **VoucherPosGetAssetInstance**
> ModelAsset VoucherPosGetAssetInstance (int? id)

Get the asset which is connected to a specified voucher position

Calls getAssetInstance() in VoucherPos.php to get the asset which is connected to the specified voucher position

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherPosGetAssetInstanceExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherPosApi();
            var id = 56;  // int? | Id of the voucher position of which you want to get the connected asset

            try
            {
                // Get the asset which is connected to a specified voucher position
                ModelAsset result = apiInstance.VoucherPosGetAssetInstance(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherPosApi.VoucherPosGetAssetInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher position of which you want to get the connected asset | 

### Return type

[**ModelAsset**](ModelAsset.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

