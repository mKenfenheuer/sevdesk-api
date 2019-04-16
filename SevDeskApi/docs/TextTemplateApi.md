# SevDeskApi.Api.TextTemplateApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTextTemplate**](TextTemplateApi.md#addtexttemplate) | **POST** /TextTemplate | Create a new text template
[**DeleteTextTemplate**](TextTemplateApi.md#deletetexttemplate) | **DELETE** /TextTemplate/{id} | Delete an existing text template
[**GetTextTemplate**](TextTemplateApi.md#gettexttemplate) | **GET** /TextTemplate | Get an overview of all text template
[**UpdateTextTemplate**](TextTemplateApi.md#updatetexttemplate) | **PUT** /TextTemplate/{id} | Update an existing text template


<a name="addtexttemplate"></a>
# **AddTextTemplate**
> ModelTextTemplate AddTextTemplate (string body)

Create a new text template

Calls TextTemplate.php to create a new text template

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddTextTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TextTemplateApi();
            var body = "name=&text=&objectType=&textType=";  // string | To create a text template, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new text template
                ModelTextTemplate result = apiInstance.AddTextTemplate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextTemplateApi.AddTextTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a text template, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelTextTemplate**](ModelTextTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetexttemplate"></a>
# **DeleteTextTemplate**
> void DeleteTextTemplate (int? id)

Delete an existing text template

Calls TextTemplate.php to delete a text template

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteTextTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TextTemplateApi();
            var id = 56;  // int? | Id of text template you want to delete

            try
            {
                // Delete an existing text template
                apiInstance.DeleteTextTemplate(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextTemplateApi.DeleteTextTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of text template you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettexttemplate"></a>
# **GetTextTemplate**
> ModelTextTemplate GetTextTemplate (int? limit, int? offset, List<string> embed)

Get an overview of all text template

Calls TextTemplate.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetTextTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TextTemplateApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned text templates start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all text template
                ModelTextTemplate result = apiInstance.GetTextTemplate(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextTemplateApi.GetTextTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned text templates start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelTextTemplate**](ModelTextTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetexttemplate"></a>
# **UpdateTextTemplate**
> ModelTextTemplate UpdateTextTemplate (int? id, string body)

Update an existing text template

Calls TextTemplate.php to update an existing text template

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateTextTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TextTemplateApi();
            var id = 56;  // int? | Id of text template you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create text template.    Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update an existing text template
                ModelTextTemplate result = apiInstance.UpdateTextTemplate(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextTemplateApi.UpdateTextTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of text template you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create text template.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelTextTemplate**](ModelTextTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

