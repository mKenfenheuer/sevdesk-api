# SevDeskApi.Api.FeedApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFeed**](FeedApi.md#addfeed) | **POST** /Feed | Create a new action which will be displayed in the feed
[**DeleteFeed**](FeedApi.md#deletefeed) | **DELETE** /Feed/{id} | Delete an existing feed action
[**GetFeeds**](FeedApi.md#getfeeds) | **GET** /Feed | Get an overview of all actions from everyone, which will be displayed in the dashboard
[**GetParsedObjectAction**](FeedApi.md#getparsedobjectaction) | **GET** /Feed/{id}/getParsedObjectAction | Get more information about the specific feed object
[**UpdateFeed**](FeedApi.md#updatefeed) | **PUT** /Feed/{id} | Update an existing Feed action


<a name="addfeed"></a>
# **AddFeed**
> ModelFeed AddFeed (string body)

Create a new action which will be displayed in the feed

Calls Feed.php to add an action to the feed

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddFeedExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new FeedApi();
            var body = "text=&type[id]=&type[objectName]=FeedType&user[id]=&user[objectName]=SevUser";  // string | To create a new action for the feed, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new action which will be displayed in the feed
                ModelFeed result = apiInstance.AddFeed(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedApi.AddFeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a new action for the feed, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelFeed**](ModelFeed.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefeed"></a>
# **DeleteFeed**
> void DeleteFeed (int? id)

Delete an existing feed action

Deletes a feed action

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteFeedExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new FeedApi();
            var id = 56;  // int? | id of feed action you want to delete

            try
            {
                // Delete an existing feed action
                apiInstance.DeleteFeed(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedApi.DeleteFeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of feed action you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeeds"></a>
# **GetFeeds**
> ModelFeed GetFeeds (int? limit, int? offset, List<string> embed)

Get an overview of all actions from everyone, which will be displayed in the dashboard

Calls Feed.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetFeedsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new FeedApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned feeds start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all actions from everyone, which will be displayed in the dashboard
                ModelFeed result = apiInstance.GetFeeds(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedApi.GetFeeds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned feeds start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelFeed**](ModelFeed.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparsedobjectaction"></a>
# **GetParsedObjectAction**
> void GetParsedObjectAction (int? id)

Get more information about the specific feed object

Calls getParsedObjectAction() in Feed.php to get more information about the specified object

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetParsedObjectActionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new FeedApi();
            var id = 56;  // int? | Feed id of the object you want to get more information about

            try
            {
                // Get more information about the specific feed object
                apiInstance.GetParsedObjectAction(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedApi.GetParsedObjectAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Feed id of the object you want to get more information about | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefeed"></a>
# **UpdateFeed**
> ModelFeed UpdateFeed (int? id, string body)

Update an existing Feed action

TODO: Enter short backend documentation here

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateFeedExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new FeedApi();
            var id = 56;  // int? | id of feed action you want to update
            var body = "text=&type[id]=&type[objectName]=FeedType&user[id]=&user[objectName]=SevUser";  // string | Parameters which need to be updated. Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // Update an existing Feed action
                ModelFeed result = apiInstance.UpdateFeed(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedApi.UpdateFeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of feed action you want to update | 
 **body** | **string**| Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelFeed**](ModelFeed.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

