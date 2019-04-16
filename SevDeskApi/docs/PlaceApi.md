# SevDeskApi.Api.PlaceApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPlaces**](PlaceApi.md#getplaces) | **GET** /Place | Get an overview of all places


<a name="getplaces"></a>
# **GetPlaces**
> ModelPlace GetPlaces (int? limit, int? offset)

Get an overview of all places

Calls Place.php to get necessary variables.    It is recommended to set limit and offset appropriately as there are over 5000 entries for place!

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetPlacesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PlaceApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 1000 (optional)  (default to 1000)
            var offset = 56;  // int? | Set the index where the returned places start. Default is 0 (optional)  (default to 0)

            try
            {
                // Get an overview of all places
                ModelPlace result = apiInstance.GetPlaces(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlaceApi.GetPlaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 1000 | [optional] [default to 1000]
 **offset** | **int?**| Set the index where the returned places start. Default is 0 | [optional] [default to 0]

### Return type

[**ModelPlace**](ModelPlace.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

