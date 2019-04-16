# SevDeskApi.Api.DocumentFolderApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDocumentFolder**](DocumentFolderApi.md#adddocumentfolder) | **POST** /DocumentFolder | Create a new document folder
[**DeleteDocumentFolder**](DocumentFolderApi.md#deletedocumentfolder) | **DELETE** /DocumentFolder/{id} | Delete an existing document folder
[**EmptyBin**](DocumentFolderApi.md#emptybin) | **DELETE** /DocumentFolder/emptyBin | Delete all objects in the bin
[**GetDocumentFolderChildren**](DocumentFolderApi.md#getdocumentfolderchildren) | **GET** /DocumentFolder/{id}/getChildren | Returns children (documents and document folders) as &#39;nodes&#39; and count of all children as &#39;total&#39;
[**GetDocumentFolderDocuments**](DocumentFolderApi.md#getdocumentfolderdocuments) | **GET** /DocumentFolder/{id}/getDocuments | Get an overview of all documents in a document folder
[**GetDocumentFolderFolders**](DocumentFolderApi.md#getdocumentfolderfolders) | **GET** /DocumentFolder/{id}/getFolders | Get an overview of all folders in a document folder
[**GetDocumentFolderPath**](DocumentFolderApi.md#getdocumentfolderpath) | **GET** /DocumentFolder/{id}/getPath | Get path (all parent folders) of this folder
[**GetDocumentFolders**](DocumentFolderApi.md#getdocumentfolders) | **GET** /DocumentFolder | Get an overview of all document folders
[**TrashDocumentFolder**](DocumentFolderApi.md#trashdocumentfolder) | **PUT** /DocumentFolder/{id}/trash | Trash an existing document folder
[**UpdateDocumentFolder**](DocumentFolderApi.md#updatedocumentfolder) | **PUT** /DocumentFolder/{id} | Update an existing document folder


<a name="adddocumentfolder"></a>
# **AddDocumentFolder**
> ModelDocumentFolder AddDocumentFolder (string body)

Create a new document folder

Calls DocumentFolder.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddDocumentFolderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentFolderApi();
            var body = "name=&status=";  // string | To create a document folder, simply enter desired values after parameter= and remove the quotation marks

            try
            {
                // Create a new document folder
                ModelDocumentFolder result = apiInstance.AddDocumentFolder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentFolderApi.AddDocumentFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a document folder, simply enter desired values after parameter&#x3D; and remove the quotation marks | 

### Return type

[**ModelDocumentFolder**](ModelDocumentFolder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocumentfolder"></a>
# **DeleteDocumentFolder**
> void DeleteDocumentFolder (int? id)

Delete an existing document folder

Calls the delete() function in DocumentFolder.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteDocumentFolderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentFolderApi();
            var id = 56;  // int? | id of document folder you want to delete

            try
            {
                // Delete an existing document folder
                apiInstance.DeleteDocumentFolder(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentFolderApi.DeleteDocumentFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of document folder you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emptybin"></a>
# **EmptyBin**
> void EmptyBin ()

Delete all objects in the bin

Calls the emptyBin() function in DocumentFolder.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class EmptyBinExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentFolderApi();

            try
            {
                // Delete all objects in the bin
                apiInstance.EmptyBin();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentFolderApi.EmptyBin: " + e.Message );
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

<a name="getdocumentfolderchildren"></a>
# **GetDocumentFolderChildren**
> ModelDocumentFolder GetDocumentFolderChildren (int? id, int? limit, int? offset, List<string> embed)

Returns children (documents and document folders) as 'nodes' and count of all children as 'total'

Calls getChildren() in DocumentFolder.php to get necessary variables

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetDocumentFolderChildrenExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentFolderApi();
            var id = 56;  // int? | Document folder of which you want to get the children
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned children start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Returns children (documents and document folders) as 'nodes' and count of all children as 'total'
                ModelDocumentFolder result = apiInstance.GetDocumentFolderChildren(id, limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentFolderApi.GetDocumentFolderChildren: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Document folder of which you want to get the children | 
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned children start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelDocumentFolder**](ModelDocumentFolder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentfolderdocuments"></a>
# **GetDocumentFolderDocuments**
> ModelDocumentFolder GetDocumentFolderDocuments (int? id, int? limit, int? offset, List<string> embed)

Get an overview of all documents in a document folder

Calls getDocuments() in DocumentFolder.php to get necessary variables

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetDocumentFolderDocumentsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentFolderApi();
            var id = 56;  // int? | Document folder of which you want to get the containing documents
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned documents start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all documents in a document folder
                ModelDocumentFolder result = apiInstance.GetDocumentFolderDocuments(id, limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentFolderApi.GetDocumentFolderDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Document folder of which you want to get the containing documents | 
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned documents start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelDocumentFolder**](ModelDocumentFolder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentfolderfolders"></a>
# **GetDocumentFolderFolders**
> ModelDocumentFolder GetDocumentFolderFolders (int? id, int? limit, int? offset, List<string> embed)

Get an overview of all folders in a document folder

Calls getFolders() in DocumentFolder.php to get necessary variables

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetDocumentFolderFoldersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentFolderApi();
            var id = 56;  // int? | Document folder of which you want to get the containing folders
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned folders start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all folders in a document folder
                ModelDocumentFolder result = apiInstance.GetDocumentFolderFolders(id, limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentFolderApi.GetDocumentFolderFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Document folder of which you want to get the containing folders | 
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned folders start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelDocumentFolder**](ModelDocumentFolder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentfolderpath"></a>
# **GetDocumentFolderPath**
> ModelDocumentFolder GetDocumentFolderPath (int? id)

Get path (all parent folders) of this folder

Calls getPath() in DocumentFolder.php to get necessary variables

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetDocumentFolderPathExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentFolderApi();
            var id = 56;  // int? | Document folder of which you want to get the path

            try
            {
                // Get path (all parent folders) of this folder
                ModelDocumentFolder result = apiInstance.GetDocumentFolderPath(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentFolderApi.GetDocumentFolderPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Document folder of which you want to get the path | 

### Return type

[**ModelDocumentFolder**](ModelDocumentFolder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentfolders"></a>
# **GetDocumentFolders**
> ModelDocumentFolder GetDocumentFolders (int? limit, int? offset, List<string> embed)

Get an overview of all document folders

Calls DocumentFolder.php to get necessary variables

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetDocumentFoldersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentFolderApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned document folders start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all document folders
                ModelDocumentFolder result = apiInstance.GetDocumentFolders(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentFolderApi.GetDocumentFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned document folders start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelDocumentFolder**](ModelDocumentFolder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trashdocumentfolder"></a>
# **TrashDocumentFolder**
> void TrashDocumentFolder (int? id)

Trash an existing document folder

Calls trash() in DocumentFolder.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class TrashDocumentFolderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentFolderApi();
            var id = 56;  // int? | id of document folder you want to trash

            try
            {
                // Trash an existing document folder
                apiInstance.TrashDocumentFolder(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentFolderApi.TrashDocumentFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of document folder you want to trash | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocumentfolder"></a>
# **UpdateDocumentFolder**
> ModelDocumentFolder UpdateDocumentFolder (int? id, string body)

Update an existing document folder

Calls DocumentFolder.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateDocumentFolderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new DocumentFolderApi();
            var id = 56;  // int? | id of document folder you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create document folder.    Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // Update an existing document folder
                ModelDocumentFolder result = apiInstance.UpdateDocumentFolder(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentFolderApi.UpdateDocumentFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of document folder you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create document folder.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelDocumentFolder**](ModelDocumentFolder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

