# SevDeskApi.Api.CommunicationWayApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCommunicationWay**](CommunicationWayApi.md#addcommunicationway) | **POST** /CommunicationWay | Create a new communication way
[**DeleteCommunicationWay**](CommunicationWayApi.md#deletecommunicationway) | **DELETE** /CommunicationWay/{id} | Delete an existing communication way
[**GetCommunicationWays**](CommunicationWayApi.md#getcommunicationways) | **GET** /CommunicationWay | Get an overview of all communication ways
[**UpdateCommunicationWay**](CommunicationWayApi.md#updatecommunicationway) | **PUT** /CommunicationWay/{id} | Update a existing communication way


<a name="addcommunicationway"></a>
# **AddCommunicationWay**
> ModelCommunicationWay AddCommunicationWay (string body)

Create a new communication way

Calls CommunicationWay.php 

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddCommunicationWayExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CommunicationWayApi();
            var body = "type=&value=&key[id]=&key[objectName]=CommunicationWayKey";  // string | To create a communication way , simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new communication way
                ModelCommunicationWay result = apiInstance.AddCommunicationWay(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunicationWayApi.AddCommunicationWay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a communication way , simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelCommunicationWay**](ModelCommunicationWay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecommunicationway"></a>
# **DeleteCommunicationWay**
> void DeleteCommunicationWay (int? id)

Delete an existing communication way

Calls CommunicationWay.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteCommunicationWayExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CommunicationWayApi();
            var id = 56;  // int? | id of communication way you want to delete

            try
            {
                // Delete an existing communication way
                apiInstance.DeleteCommunicationWay(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunicationWayApi.DeleteCommunicationWay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of communication way you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommunicationways"></a>
# **GetCommunicationWays**
> ModelCommunicationWay GetCommunicationWays (int? limit, int? offset, List<string> embed)

Get an overview of all communication ways

Calls CommunicationWay.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetCommunicationWaysExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CommunicationWayApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned communication ways start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all communication ways
                ModelCommunicationWay result = apiInstance.GetCommunicationWays(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunicationWayApi.GetCommunicationWays: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned communication ways start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelCommunicationWay**](ModelCommunicationWay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecommunicationway"></a>
# **UpdateCommunicationWay**
> ModelCommunicationWay UpdateCommunicationWay (int? id, string body)

Update a existing communication way

Calls CommunicationWay.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateCommunicationWayExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CommunicationWayApi();
            var id = 56;  // int? | id of communication way you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create communication way.    Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update a existing communication way
                ModelCommunicationWay result = apiInstance.UpdateCommunicationWay(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunicationWayApi.UpdateCommunicationWay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of communication way you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create communication way.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelCommunicationWay**](ModelCommunicationWay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

