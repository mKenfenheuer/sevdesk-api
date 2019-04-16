# SevDeskApi.Api.LetterApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLetter**](LetterApi.md#addletter) | **POST** /Letter | Create a new letter
[**DeleteLetter**](LetterApi.md#deleteletter) | **DELETE** /Letter/{id} | Delete an existing letter
[**GetLetters**](LetterApi.md#getletters) | **GET** /Letter | Get an overview of all letters
[**LetterGetPdf**](LetterApi.md#lettergetpdf) | **GET** /Letter/{id}/getPdf | Get pdf from docserver
[**LetterRender**](LetterApi.md#letterrender) | **POST** /Letter/{id}/render | Render a letter to the docserver and return the metadata
[**LetterSendBy**](LetterApi.md#lettersendby) | **PUT** /Letter/{id}/sendBy | Update parameter sendType
[**LetterSendViaMail**](LetterApi.md#lettersendviamail) | **POST** /Letter/{id}/sendViaEmail | Send a letter via mail
[**LetterSendViaPost**](LetterApi.md#lettersendviapost) | **POST** /Letter/{id}/sendViaPost | Send a letter via post
[**UpdateLetter**](LetterApi.md#updateletter) | **PUT** /Letter/{id} | Update an existing letter


<a name="addletter"></a>
# **AddLetter**
> ModelLetter AddLetter (string body)

Create a new letter

Calls Letter.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddLetterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new LetterApi();
            var body = "letterNumber=&contact[objectName]=Contact&contact[id]=&header=&status=&text=&sendType=&sendDate=";  // string | To create a letter, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new letter
                ModelLetter result = apiInstance.AddLetter(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LetterApi.AddLetter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a letter, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelLetter**](ModelLetter.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteletter"></a>
# **DeleteLetter**
> void DeleteLetter (int? id)

Delete an existing letter

Calls the delete() function in Letter.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteLetterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new LetterApi();
            var id = 56;  // int? | id of letter you want to delete

            try
            {
                // Delete an existing letter
                apiInstance.DeleteLetter(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LetterApi.DeleteLetter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of letter you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getletters"></a>
# **GetLetters**
> ModelLetter GetLetters (int? limit, int? offset, List<string> embed)

Get an overview of all letters

Calls Letter.php to get necessary variables

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetLettersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new LetterApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned letters start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all letters
                ModelLetter result = apiInstance.GetLetters(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LetterApi.GetLetters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned letters start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelLetter**](ModelLetter.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lettergetpdf"></a>
# **LetterGetPdf**
> void LetterGetPdf (int? id)

Get pdf from docserver

Calls getPdf() in Letter.php to get the pdf of a specified letter from the docserver

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class LetterGetPdfExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new LetterApi();
            var id = 56;  // int? | Id of the letter of which you want to get the pdf

            try
            {
                // Get pdf from docserver
                apiInstance.LetterGetPdf(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LetterApi.LetterGetPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the letter of which you want to get the pdf | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="letterrender"></a>
# **LetterRender**
> void LetterRender (int? id)

Render a letter to the docserver and return the metadata

Calls render() in Letter.php to render a letter to the docserver and return the metadata.    Note that this does not work for letters created by calling the api directly (eg. over Swagger)!

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class LetterRenderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new LetterApi();
            var id = 56;  // int? | id of letter you want to render

            try
            {
                // Render a letter to the docserver and return the metadata
                apiInstance.LetterRender(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LetterApi.LetterRender: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of letter you want to render | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lettersendby"></a>
# **LetterSendBy**
> ModelLetter LetterSendBy (int? id, string body)

Update parameter sendType

Calls sendBy() in Letter.php to update the sendType parameter of the letter and change its status to DELIVERED

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class LetterSendByExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new LetterApi();
            var id = 56;  // int? | id of letter of which you want to update the sendType parameter
            var body = body_example;  // string | Enter desired send type after sendType= and remove the quotation marks! (optional) 

            try
            {
                // Update parameter sendType
                ModelLetter result = apiInstance.LetterSendBy(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LetterApi.LetterSendBy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of letter of which you want to update the sendType parameter | 
 **body** | **string**| Enter desired send type after sendType&#x3D; and remove the quotation marks! | [optional] 

### Return type

[**ModelLetter**](ModelLetter.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lettersendviamail"></a>
# **LetterSendViaMail**
> void LetterSendViaMail (int? id, string body)

Send a letter via mail

Calls sendViaMail() in Letter.php to send a letter via mail.    Note that you can not send a letter created by calling the api directly (eg. over Swagger)!

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class LetterSendViaMailExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new LetterApi();
            var id = 56;  // int? | id of letter you want to send
            var body = body_example;  // string | To send a letter, simply enter desired values after parameter= and remove the quotation marks.    Please note: additionalAttachments is a String containing document id's (of existing documents!) (optional) 

            try
            {
                // Send a letter via mail
                apiInstance.LetterSendViaMail(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LetterApi.LetterSendViaMail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of letter you want to send | 
 **body** | **string**| To send a letter, simply enter desired values after parameter&#x3D; and remove the quotation marks.    Please note: additionalAttachments is a String containing document id&#39;s (of existing documents!) | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lettersendviapost"></a>
# **LetterSendViaPost**
> void LetterSendViaPost (int? id)

Send a letter via post

Calls sendViaPost() in Letter.php to send a letter via post if enabled in your subscription    Note that you can not send a letter created by calling the api directly (eg. over Swagger)!

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class LetterSendViaPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new LetterApi();
            var id = 56;  // int? | id of letter you want to send

            try
            {
                // Send a letter via post
                apiInstance.LetterSendViaPost(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LetterApi.LetterSendViaPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of letter you want to send | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateletter"></a>
# **UpdateLetter**
> ModelLetter UpdateLetter (int? id, string body)

Update an existing letter

Calls Letter.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateLetterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new LetterApi();
            var id = 56;  // int? | id of letter you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create letter.    Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update an existing letter
                ModelLetter result = apiInstance.UpdateLetter(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LetterApi.UpdateLetter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of letter you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create letter.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelLetter**](ModelLetter.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

