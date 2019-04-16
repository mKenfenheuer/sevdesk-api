# SevDeskApi.Api.SearchApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Search**](SearchApi.md#search) | **GET** /Search/search | Search for a specified term


<a name="search"></a>
# **Search**
> void Search (string embed, string term, List<string> searchType)

Search for a specified term

Calls search() in Search.php to search with a specified term in Contacts, Orders, Invoices, Vouchers, Documents and Parts.    It is also possible to search without defining a model, so sevDesk system operations will also be shown.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class SearchExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new SearchApi();
            var embed = embed_example;  // string |  (optional)  (default to contact,contact.parent,parent)
            var term = term_example;  // string | Term you want to search (optional)  (default to )
            var searchType = searchType_example;  // List<string> | Specify a type (model) that you want to have searched (optional) 

            try
            {
                // Search for a specified term
                apiInstance.Search(embed, term, searchType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.Search: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **embed** | **string**|  | [optional] [default to contact,contact.parent,parent]
 **term** | **string**| Term you want to search | [optional] [default to ]
 **searchType** | **List<string>**| Specify a type (model) that you want to have searched | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

