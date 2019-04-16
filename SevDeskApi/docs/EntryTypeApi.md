# SevDeskApi.Api.EntryTypeApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddEntryType**](EntryTypeApi.md#addentrytype) | **POST** /EntryType | Create a new entry type
[**DeleteEntryType**](EntryTypeApi.md#deleteentrytype) | **DELETE** /EntryType/{id} | Delete an existing entry type
[**EntryTypeDeleteReferencedObjects**](EntryTypeApi.md#entrytypedeletereferencedobjects) | **DELETE** /EntryType/{id}/deleteReferencedObjects | Delete all objects bound to the specified entry type
[**GetEntryTypes**](EntryTypeApi.md#getentrytypes) | **GET** /EntryType | Get an overview of all entry types
[**UpdateEntryType**](EntryTypeApi.md#updateentrytype) | **PUT** /EntryType/{id} | Update an existing entry type


<a name="addentrytype"></a>
# **AddEntryType**
> ModelEntryType AddEntryType (string body)

Create a new entry type

Calls EntryType.php to create an entry type

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddEntryTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new EntryTypeApi();
            var body = "name=";  // string | To create an entry type, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new entry type
                ModelEntryType result = apiInstance.AddEntryType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntryTypeApi.AddEntryType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an entry type, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelEntryType**](ModelEntryType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteentrytype"></a>
# **DeleteEntryType**
> void DeleteEntryType (int? id)

Delete an existing entry type

Calls EntryType.php to delete an entry type

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteEntryTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new EntryTypeApi();
            var id = 56;  // int? | id of entry type you want to delete

            try
            {
                // Delete an existing entry type
                apiInstance.DeleteEntryType(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntryTypeApi.DeleteEntryType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of entry type you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="entrytypedeletereferencedobjects"></a>
# **EntryTypeDeleteReferencedObjects**
> void EntryTypeDeleteReferencedObjects (int? id)

Delete all objects bound to the specified entry type

Tries to delete all objects bound to the specified entry type if they are not in use

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class EntryTypeDeleteReferencedObjectsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new EntryTypeApi();
            var id = 56;  // int? | Id of entry type you want to use

            try
            {
                // Delete all objects bound to the specified entry type
                apiInstance.EntryTypeDeleteReferencedObjects(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntryTypeApi.EntryTypeDeleteReferencedObjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of entry type you want to use | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentrytypes"></a>
# **GetEntryTypes**
> ModelEntryType GetEntryTypes (int? limit, int? offset)

Get an overview of all entry types

Calls EntryType.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetEntryTypesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new EntryTypeApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned entry types start. Default is 0 (optional)  (default to 0)

            try
            {
                // Get an overview of all entry types
                ModelEntryType result = apiInstance.GetEntryTypes(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntryTypeApi.GetEntryTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned entry types start. Default is 0 | [optional] [default to 0]

### Return type

[**ModelEntryType**](ModelEntryType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateentrytype"></a>
# **UpdateEntryType**
> ModelEntryType UpdateEntryType (int? id, string body)

Update an existing entry type

Calls EntryType.php to update an entry type

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateEntryTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new EntryTypeApi();
            var id = 56;  // int? | id of entry type you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create entry type.    Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update an existing entry type
                ModelEntryType result = apiInstance.UpdateEntryType(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntryTypeApi.UpdateEntryType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of entry type you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create entry type.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelEntryType**](ModelEntryType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

