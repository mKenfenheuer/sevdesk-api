# SevDeskApi.Api.TagRelationApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTagRelation**](TagRelationApi.md#addtagrelation) | **POST** /TagRelation | Create a new tag relation
[**DeleteTagRelation**](TagRelationApi.md#deletetagrelation) | **DELETE** /TagRelation/{id} | Delete an existing tag relation
[**GetTagRelations**](TagRelationApi.md#gettagrelations) | **GET** /TagRelation | Get an overview of all tag relations
[**UpdateTagRelation**](TagRelationApi.md#updatetagrelation) | **PUT** /TagRelation/{id} | Update an existing tag relation


<a name="addtagrelation"></a>
# **AddTagRelation**
> ModelTagRelation AddTagRelation (string body)

Create a new tag relation

Calls TagRelation.php to create a new tag

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddTagRelationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TagRelationApi();
            var body = "tag[id]=&tag[objectName]=Tag&object[id]=&object[objectName]=";  // string | To create a tag relation, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new tag relation
                ModelTagRelation result = apiInstance.AddTagRelation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagRelationApi.AddTagRelation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a tag relation, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelTagRelation**](ModelTagRelation.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetagrelation"></a>
# **DeleteTagRelation**
> void DeleteTagRelation (int? id)

Delete an existing tag relation

Calls the delete() function in TagRelation.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteTagRelationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TagRelationApi();
            var id = 56;  // int? | Id of tag relation you want to delete

            try
            {
                // Delete an existing tag relation
                apiInstance.DeleteTagRelation(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagRelationApi.DeleteTagRelation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of tag relation you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettagrelations"></a>
# **GetTagRelations**
> ModelTagRelation GetTagRelations (int? limit, int? offset, List<string> embed)

Get an overview of all tag relations

Calls TagRelation.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetTagRelationsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TagRelationApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned tag relations start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all tag relations
                ModelTagRelation result = apiInstance.GetTagRelations(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagRelationApi.GetTagRelations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned tag relations start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelTagRelation**](ModelTagRelation.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetagrelation"></a>
# **UpdateTagRelation**
> ModelTagRelation UpdateTagRelation (int? id, string body)

Update an existing tag relation

Calls TagRelation.php to update an existing tag

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateTagRelationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TagRelationApi();
            var id = 56;  // int? | Id of tag relation you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create tag relation.    Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update an existing tag relation
                ModelTagRelation result = apiInstance.UpdateTagRelation(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagRelationApi.UpdateTagRelation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of tag relation you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create tag relation.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelTagRelation**](ModelTagRelation.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

