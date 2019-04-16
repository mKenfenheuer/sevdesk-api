# SevDeskApi.Api.DocumentApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDocument**](DocumentApi.md#adddocument) | **POST** /Document | Create a new document. Be aware that there wont be a working document with content!
[**DeleteDocument**](DocumentApi.md#deletedocument) | **DELETE** /Document/{id} | Delete an existing document
[**DownloadDocument**](DocumentApi.md#downloaddocument) | **GET** /Document/{id}/download | Download a document
[**FactoryAddDocument**](DocumentApi.md#factoryadddocument) | **POST** /Document/Factory/fileUpload | Upload a file (creating a document)
[**GetDocuments**](DocumentApi.md#getdocuments) | **GET** /Document | Get an overview of all documents
[**UpdateDocument**](DocumentApi.md#updatedocument) | **PUT** /Document/{id} | Update an existing document. Be aware that you can only update its parameter but not the content of the document itself!
[**UpdateDocumentStatusToTrashed**](DocumentApi.md#updatedocumentstatustotrashed) | **PUT** /Document/{id}/trash | Update an existing documents status to &#39;TRASHED&#39;, be aware that this deletes the document


<a name="adddocument"></a>
# **AddDocument**
> ModelDocument AddDocument (string body)

Create a new document. Be aware that there wont be a working document with content!

Calls Document.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddDocumentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentApi();
            var body = "filename=&status=&extension=&filesize=";  // string | To create a document, simply enter desired values after parameter= and remove the quotation marks

            try
            {
                // Create a new document. Be aware that there wont be a working document with content!
                ModelDocument result = apiInstance.AddDocument(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentApi.AddDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a document, simply enter desired values after parameter&#x3D; and remove the quotation marks | 

### Return type

[**ModelDocument**](ModelDocument.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocument"></a>
# **DeleteDocument**
> void DeleteDocument (int? id)

Delete an existing document

Calls the delete() function in Document.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteDocumentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentApi();
            var id = 56;  // int? | id of document you want to delete

            try
            {
                // Delete an existing document
                apiInstance.DeleteDocument(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentApi.DeleteDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of document you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloaddocument"></a>
# **DownloadDocument**
> System.IO.Stream DownloadDocument (int? id)

Download a document

Calls download() in Document.php to download a document. Will return base64 content.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DownloadDocumentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentApi();
            var id = 56;  // int? | Id of the document you want to download

            try
            {
                // Download a document
                System.IO.Stream result = apiInstance.DownloadDocument(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentApi.DownloadDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the document you want to download | 

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="factoryadddocument"></a>
# **FactoryAddDocument**
> void FactoryAddDocument (System.IO.Stream file, string _object, string folder)

Upload a file (creating a document)

With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the Model.php itself still constructs the model however new instances of the model are created trough the Factory.php    So for example when you create a new invoice it wont be saved by a POST request with '/Invoice?para1=&...' but with the saveInvoice function in Factory.php 'Voucher/Factory/saveInvoice?para1='

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class FactoryAddDocumentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentApi();
            var file = new System.IO.Stream(); // System.IO.Stream | file to upload
            var _object = _object_example;  // string | object to which you want to upload your file (optional)  (default to )
            var folder = folder_example;  // string | folder to which you want to upload your file (optional)  (default to )

            try
            {
                // Upload a file (creating a document)
                apiInstance.FactoryAddDocument(file, _object, folder);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentApi.FactoryAddDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| file to upload | 
 **_object** | **string**| object to which you want to upload your file | [optional] [default to ]
 **folder** | **string**| folder to which you want to upload your file | [optional] [default to ]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocuments"></a>
# **GetDocuments**
> ModelDocument GetDocuments (int? limit, int? offset, List<string> embed)

Get an overview of all documents

Calls Document.php to get necessary variables

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetDocumentsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned documents start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all documents
                ModelDocument result = apiInstance.GetDocuments(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentApi.GetDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned documents start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelDocument**](ModelDocument.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocument"></a>
# **UpdateDocument**
> ModelDocument UpdateDocument (int? id, string body)

Update an existing document. Be aware that you can only update its parameter but not the content of the document itself!

Calls Document.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateDocumentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentApi();
            var id = 56;  // int? | id of document you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create document.    Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // Update an existing document. Be aware that you can only update its parameter but not the content of the document itself!
                ModelDocument result = apiInstance.UpdateDocument(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentApi.UpdateDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of document you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create document.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelDocument**](ModelDocument.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocumentstatustotrashed"></a>
# **UpdateDocumentStatusToTrashed**
>  UpdateDocumentStatusToTrashed (int? id)

Update an existing documents status to 'TRASHED', be aware that this deletes the document

Calls trash() in Document.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateDocumentStatusToTrashedExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentApi();
            var id = 56;  // int? | id of document of which you want to update the status to 'TRASHED

            try
            {
                // Update an existing documents status to 'TRASHED', be aware that this deletes the document
                 result = apiInstance.UpdateDocumentStatusToTrashed(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentApi.UpdateDocumentStatusToTrashed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of document of which you want to update the status to &#39;TRASHED | 

### Return type

[****](.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

