# SevDeskApi.Api.DocServerApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocServerDeleteLetterPaper**](DocServerApi.md#docserverdeleteletterpaper) | **POST** /DocServer/deleteLetterpaper | Delete a specified letter paper
[**DocServerDeleteTemplate**](DocServerApi.md#docserverdeletetemplate) | **POST** /DocServer/deleteTemplate | Delete a specified template
[**DocServerGetLetterPapers**](DocServerApi.md#docservergetletterpapers) | **GET** /DocServer/getLetterpapers | Get an overview of all letter papers
[**DocServerGetLetterPapersWithThumb**](DocServerApi.md#docservergetletterpaperswiththumb) | **GET** /DocServer/getLetterpapersWithThumb | Get an overview of all letter papers with their thumb
[**DocServerGetTemplates**](DocServerApi.md#docservergettemplates) | **GET** /DocServer/getTemplates | Get an overview of all templates
[**DocServerGetTemplatesWithThumb**](DocServerApi.md#docservergettemplateswiththumb) | **GET** /DocServer/getTemplatesWithThumb | Get an overview of all templates with their thumb
[**DocServerSetDefaultLetterPaper**](DocServerApi.md#docserversetdefaultletterpaper) | **POST** /DocServer/setDefaultLetterpaper | Set a letter papers as the default letter paper
[**DocServerSetDefaultTemplate**](DocServerApi.md#docserversetdefaulttemplate) | **POST** /DocServer/setDefaultTemplate | Set a template as the default template
[**DocServerStoreLetterPaper**](DocServerApi.md#docserverstoreletterpaper) | **POST** /DocServer/storeLetterpaper | Store a letter paper on the doc server
[**DocServerStoreTemplate**](DocServerApi.md#docserverstoretemplate) | **POST** /DocServer/storeTemplate | Store a template on the doc server
[**DocServerTestLetterPaper**](DocServerApi.md#docservertestletterpaper) | **POST** /DocServer/testLetterpaper | Test a letter paper
[**DocServerTestTemplate**](DocServerApi.md#docservertesttemplate) | **POST** /DocServer/testTemplate | Test a template


<a name="docserverdeleteletterpaper"></a>
# **DocServerDeleteLetterPaper**
> void DocServerDeleteLetterPaper (string body)

Delete a specified letter paper

Calls deleteLetterpaper() in DocServer.php to delete a specified letter paper

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DocServerDeleteLetterPaperExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocServerApi();
            var body = "id=";  // string | Enter the id of the letter paper you want to delete after id= and remove the quotation marks!

            try
            {
                // Delete a specified letter paper
                apiInstance.DocServerDeleteLetterPaper(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocServerApi.DocServerDeleteLetterPaper: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| Enter the id of the letter paper you want to delete after id&#x3D; and remove the quotation marks! | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="docserverdeletetemplate"></a>
# **DocServerDeleteTemplate**
> void DocServerDeleteTemplate (string body)

Delete a specified template

Calls setDefaultTemplate() in DocServer.php to set the specified template as the default template

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DocServerDeleteTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocServerApi();
            var body = "id=";  // string | Enter the id of the template you want to set as the default template after id= and remove the quotation marks!

            try
            {
                // Delete a specified template
                apiInstance.DocServerDeleteTemplate(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocServerApi.DocServerDeleteTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| Enter the id of the template you want to set as the default template after id&#x3D; and remove the quotation marks! | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="docservergetletterpapers"></a>
# **DocServerGetLetterPapers**
> void DocServerGetLetterPapers ()

Get an overview of all letter papers

Calls getLetterpapers() in DocServer.php to get the stored letter papers

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DocServerGetLetterPapersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocServerApi();

            try
            {
                // Get an overview of all letter papers
                apiInstance.DocServerGetLetterPapers();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocServerApi.DocServerGetLetterPapers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="docservergetletterpaperswiththumb"></a>
# **DocServerGetLetterPapersWithThumb**
> void DocServerGetLetterPapersWithThumb ()

Get an overview of all letter papers with their thumb

Calls getLetterpapersWithThumb() in DocServer.php to get the stored letter papers with their thumb.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DocServerGetLetterPapersWithThumbExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocServerApi();

            try
            {
                // Get an overview of all letter papers with their thumb
                apiInstance.DocServerGetLetterPapersWithThumb();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocServerApi.DocServerGetLetterPapersWithThumb: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="docservergettemplates"></a>
# **DocServerGetTemplates**
> void DocServerGetTemplates ()

Get an overview of all templates

Calls getTemplates() in DocServer.php to get the stored templates.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DocServerGetTemplatesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocServerApi();

            try
            {
                // Get an overview of all templates
                apiInstance.DocServerGetTemplates();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocServerApi.DocServerGetTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="docservergettemplateswiththumb"></a>
# **DocServerGetTemplatesWithThumb**
> void DocServerGetTemplatesWithThumb ()

Get an overview of all templates with their thumb

Calls getTemplatesWithThumb() in DocServer.php to get the stored templates with their thumb.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DocServerGetTemplatesWithThumbExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocServerApi();

            try
            {
                // Get an overview of all templates with their thumb
                apiInstance.DocServerGetTemplatesWithThumb();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocServerApi.DocServerGetTemplatesWithThumb: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="docserversetdefaultletterpaper"></a>
# **DocServerSetDefaultLetterPaper**
> void DocServerSetDefaultLetterPaper (string body)

Set a letter papers as the default letter paper

Calls setDefaultLetterpaper() in DocServer.php to set the specified letter paper as the default letter paper

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DocServerSetDefaultLetterPaperExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocServerApi();
            var body = "id=";  // string | Enter the id of the letter paper you want to set as the default letter paper after id= and remove the quotation marks!

            try
            {
                // Set a letter papers as the default letter paper
                apiInstance.DocServerSetDefaultLetterPaper(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocServerApi.DocServerSetDefaultLetterPaper: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| Enter the id of the letter paper you want to set as the default letter paper after id&#x3D; and remove the quotation marks! | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="docserversetdefaulttemplate"></a>
# **DocServerSetDefaultTemplate**
> void DocServerSetDefaultTemplate (string body)

Set a template as the default template

Calls setDefaultTemplate() in DocServer.php to set the specified template as the default template

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DocServerSetDefaultTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocServerApi();
            var body = "id=";  // string | Enter the id of the template you want to set as the default template after id= and remove the quotation marks!

            try
            {
                // Set a template as the default template
                apiInstance.DocServerSetDefaultTemplate(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocServerApi.DocServerSetDefaultTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| Enter the id of the template you want to set as the default template after id&#x3D; and remove the quotation marks! | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="docserverstoreletterpaper"></a>
# **DocServerStoreLetterPaper**
> void DocServerStoreLetterPaper (string body)

Store a letter paper on the doc server

Calls storeLetterpaper() in DocServer.php to store a letter paper on the doc server

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DocServerStoreLetterPaperExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocServerApi();
            var body = "name=&pdf=&type=null&id=null&isDefault=null";  // string | Enter the desired values after parameter= and remove the quotation marks!    Be aware that you need to enter the base64 of the pdf you want as a letter paper after pdf=!

            try
            {
                // Store a letter paper on the doc server
                apiInstance.DocServerStoreLetterPaper(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocServerApi.DocServerStoreLetterPaper: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| Enter the desired values after parameter&#x3D; and remove the quotation marks!    Be aware that you need to enter the base64 of the pdf you want as a letter paper after pdf&#x3D;! | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="docserverstoretemplate"></a>
# **DocServerStoreTemplate**
> void DocServerStoreTemplate (string body)

Store a template on the doc server

Calls storeTemplate() in DocServer.php to store a template on the doc server

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DocServerStoreTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocServerApi();
            var body = "name=&html=&type=&id=null&isDefault=null&json=undefined";  // string | Enter the desired values after parameter= and remove the quotation marks!    Be aware that you need to enter the html code of your template after html=! Type can be Invoice, Invoicereminder, Order, Contractnote, Packingllist, Letter.

            try
            {
                // Store a template on the doc server
                apiInstance.DocServerStoreTemplate(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocServerApi.DocServerStoreTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| Enter the desired values after parameter&#x3D; and remove the quotation marks!    Be aware that you need to enter the html code of your template after html&#x3D;! Type can be Invoice, Invoicereminder, Order, Contractnote, Packingllist, Letter. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="docservertestletterpaper"></a>
# **DocServerTestLetterPaper**
> void DocServerTestLetterPaper (System.IO.Stream file)

Test a letter paper

Calls testLetterpaper() in DocServer.php to test your letter paper by providing the pdf.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DocServerTestLetterPaperExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocServerApi();
            var file = new System.IO.Stream(); // System.IO.Stream | Pdf file to test

            try
            {
                // Test a letter paper
                apiInstance.DocServerTestLetterPaper(file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocServerApi.DocServerTestLetterPaper: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| Pdf file to test | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="docservertesttemplate"></a>
# **DocServerTestTemplate**
> void DocServerTestTemplate (string body)

Test a template

Calls testTemplate() in DocServer.php to test your template by providing the html.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DocServerTestTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocServerApi();
            var body = "html=";  // string | Enter the html of your template after html= and remove the quotation marks!

            try
            {
                // Test a template
                apiInstance.DocServerTestTemplate(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocServerApi.DocServerTestTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| Enter the html of your template after html&#x3D; and remove the quotation marks! | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

