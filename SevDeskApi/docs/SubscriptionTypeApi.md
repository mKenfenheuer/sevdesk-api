# SevDeskApi.Api.SubscriptionTypeApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSubscriptionTypes**](SubscriptionTypeApi.md#getsubscriptiontypes) | **GET** /SubscriptionType | Get an overview of all subscription types


<a name="getsubscriptiontypes"></a>
# **GetSubscriptionTypes**
> ModelSubscriptionType GetSubscriptionTypes ()

Get an overview of all subscription types

Calls SubscriptionType.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetSubscriptionTypesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new SubscriptionTypeApi();

            try
            {
                // Get an overview of all subscription types
                ModelSubscriptionType result = apiInstance.GetSubscriptionTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionTypeApi.GetSubscriptionTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ModelSubscriptionType**](ModelSubscriptionType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

