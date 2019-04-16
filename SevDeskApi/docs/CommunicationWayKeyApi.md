# SevDeskApi.Api.CommunicationWayKeyApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCommunicationWayKeys**](CommunicationWayKeyApi.md#getcommunicationwaykeys) | **GET** /CommunicationWayKey | Get an overview of all communication way keys


<a name="getcommunicationwaykeys"></a>
# **GetCommunicationWayKeys**
> ModelCommunicationWayKey GetCommunicationWayKeys (int? limit, int? offset)

Get an overview of all communication way keys

Calls CommunicationWayKey.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetCommunicationWayKeysExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CommunicationWayKeyApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned communication way keys start. Default is 0 (optional)  (default to 0)

            try
            {
                // Get an overview of all communication way keys
                ModelCommunicationWayKey result = apiInstance.GetCommunicationWayKeys(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunicationWayKeyApi.GetCommunicationWayKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned communication way keys start. Default is 0 | [optional] [default to 0]

### Return type

[**ModelCommunicationWayKey**](ModelCommunicationWayKey.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

