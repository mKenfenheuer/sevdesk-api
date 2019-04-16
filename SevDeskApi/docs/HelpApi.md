# SevDeskApi.Api.HelpApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HelpGetArticle**](HelpApi.md#helpgetarticle) | **GET** /Help/getArticle | Get a specified article
[**HelpGetArticles**](HelpApi.md#helpgetarticles) | **GET** /Help/getArticles | Get all help articles for a specified section
[**HelpGetCategories**](HelpApi.md#helpgetcategories) | **GET** /Help/getCategories | Get all categories of help articles
[**HelpGetSections**](HelpApi.md#helpgetsections) | **GET** /Help/getSections | Get all sections of help articles
[**HelpSearchArticles**](HelpApi.md#helpsearcharticles) | **GET** /Help/search | Search for articles


<a name="helpgetarticle"></a>
# **HelpGetArticle**
> ModelHelp HelpGetArticle (int? articleId)

Get a specified article

Calls getArticle() in Help.php to get a specified help article

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class HelpGetArticleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new HelpApi();
            var articleId = 56;  // int? | Id of the article you want to get

            try
            {
                // Get a specified article
                ModelHelp result = apiInstance.HelpGetArticle(articleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpApi.HelpGetArticle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **articleId** | **int?**| Id of the article you want to get | 

### Return type

[**ModelHelp**](ModelHelp.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="helpgetarticles"></a>
# **HelpGetArticles**
> ModelHelp HelpGetArticles (int? sectionId, int? limit, int? offset)

Get all help articles for a specified section

Calls getArticles() in Help.php to get all help articles for a specified section

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class HelpGetArticlesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new HelpApi();
            var sectionId = 56;  // int? | Section id you want to get help articles about
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned help articles start. Default is 0 (optional)  (default to 0)

            try
            {
                // Get all help articles for a specified section
                ModelHelp result = apiInstance.HelpGetArticles(sectionId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpApi.HelpGetArticles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sectionId** | **int?**| Section id you want to get help articles about | 
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned help articles start. Default is 0 | [optional] [default to 0]

### Return type

[**ModelHelp**](ModelHelp.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="helpgetcategories"></a>
# **HelpGetCategories**
> ModelHelp HelpGetCategories (int? limit, int? offset)

Get all categories of help articles

Calls getCategories() in Help.php to get all categories available for searching help articles

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class HelpGetCategoriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new HelpApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned sections start. Default is 0 (optional)  (default to 0)

            try
            {
                // Get all categories of help articles
                ModelHelp result = apiInstance.HelpGetCategories(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpApi.HelpGetCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned sections start. Default is 0 | [optional] [default to 0]

### Return type

[**ModelHelp**](ModelHelp.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="helpgetsections"></a>
# **HelpGetSections**
> ModelHelp HelpGetSections (int? limit, int? offset)

Get all sections of help articles

Calls getSections() in Help.php to get all sections available for searching help articles

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class HelpGetSectionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new HelpApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned sections start. Default is 0 (optional)  (default to 0)

            try
            {
                // Get all sections of help articles
                ModelHelp result = apiInstance.HelpGetSections(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpApi.HelpGetSections: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned sections start. Default is 0 | [optional] [default to 0]

### Return type

[**ModelHelp**](ModelHelp.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="helpsearcharticles"></a>
# **HelpSearchArticles**
> ModelHelp HelpSearchArticles (string name)

Search for articles

Calls search() in Help.php to search for articles

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class HelpSearchArticlesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new HelpApi();
            var name = name_example;  // string | String to search for (optional)  (default to )

            try
            {
                // Search for articles
                ModelHelp result = apiInstance.HelpSearchArticles(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpApi.HelpSearchArticles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| String to search for | [optional] [default to ]

### Return type

[**ModelHelp**](ModelHelp.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

