# SevDeskApi.Api.TaskApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTask**](TaskApi.md#addtask) | **POST** /Task | Create a new task
[**DeleteTask**](TaskApi.md#deletetask) | **DELETE** /Task/{id} | Delete an existing task
[**GetTasks**](TaskApi.md#gettasks) | **GET** /Task | Get an overview of all tasks
[**UpdateTask**](TaskApi.md#updatetask) | **PUT** /Task/{id} | Update an existing Task


<a name="addtask"></a>
# **AddTask**
> ModelOrderPos AddTask (string body)

Create a new task

Calls Task.php to add a task

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddTaskExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TaskApi();
            var body = "name=&assigned[id]=&assigned[objectName]=SevUser&category[id]=38&category[objectName]=Category& createUser[id]=&createUser[objectName]=SevUser&noticeCreator=0&deadline=01.01.1997&status=100&object[id]=&object[objectName]=";  // string | To create a task, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new task
                ModelOrderPos result = apiInstance.AddTask(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskApi.AddTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a task, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelOrderPos**](ModelOrderPos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetask"></a>
# **DeleteTask**
> void DeleteTask (int? id)

Delete an existing task

TODO: Write backend documentation

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteTaskExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TaskApi();
            var id = 56;  // int? | id of the task you want to delete

            try
            {
                // Delete an existing task
                apiInstance.DeleteTask(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskApi.DeleteTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of the task you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasks"></a>
# **GetTasks**
> ModelTask GetTasks (int? limit, int? offset, List<string> embed)

Get an overview of all tasks

Calls Task.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetTasksExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TaskApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned tasks start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all tasks
                ModelTask result = apiInstance.GetTasks(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskApi.GetTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned tasks start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelTask**](ModelTask.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetask"></a>
# **UpdateTask**
> ModelTask UpdateTask (int? id, string body)

Update an existing Task

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
    public class UpdateTaskExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new TaskApi();
            var id = 56;  // int? | id of task you want to update
            var body = "name=&assigned[id]=&assigned[objectName]=SevUser&category[id]=38&category[objectName]=Category& createUser[id]=&createUser[objectName]=SevUser&noticeCreator=0&deadline=01.01.1997&status=100&object[id]=&object[objectName]=";  // string | Parameters which need to be updated. Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // Update an existing Task
                ModelTask result = apiInstance.UpdateTask(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskApi.UpdateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of task you want to update | 
 **body** | **string**| Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelTask**](ModelTask.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

