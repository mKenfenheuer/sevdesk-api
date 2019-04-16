# SevDeskApi.Api.SevClientConfigApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSevClientConfig**](SevClientConfigApi.md#getsevclientconfig) | **GET** /SevClientConfig | Get an overview of your sevClient config
[**UpdateSevClientConfig**](SevClientConfigApi.md#updatesevclientconfig) | **PUT** /SevClientConfig/{id} | Update an existing sevClient config


<a name="getsevclientconfig"></a>
# **GetSevClientConfig**
> ModelSevClientConfig GetSevClientConfig (List<string> embed)

Get an overview of your sevClient config

Calls SevClientConfig.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetSevClientConfigExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new SevClientConfigApi();
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of your sevClient config
                ModelSevClientConfig result = apiInstance.GetSevClientConfig(embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SevClientConfigApi.GetSevClientConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelSevClientConfig**](ModelSevClientConfig.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesevclientconfig"></a>
# **UpdateSevClientConfig**
> ModelSevClientConfig UpdateSevClientConfig (int? id, string body)

Update an existing sevClient config

Calls SevClientConfig.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateSevClientConfigExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new SevClientConfigApi();
            var id = 56;  // int? | Id of sevClient config you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create sevClient config.    Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update an existing sevClient config
                ModelSevClientConfig result = apiInstance.UpdateSevClientConfig(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SevClientConfigApi.UpdateSevClientConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of sevClient config you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create sevClient config.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelSevClientConfig**](ModelSevClientConfig.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

