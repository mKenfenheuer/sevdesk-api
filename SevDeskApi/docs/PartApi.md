# SevDeskApi.Api.PartApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPart**](PartApi.md#addpart) | **POST** /Part | Create a new part
[**BookPart**](PartApi.md#bookpart) | **PUT** /Part/{id}/book | add / remove parts from the stock
[**DeletePart**](PartApi.md#deletepart) | **DELETE** /Part/{id} | Delete an existing part
[**DuplicatePart**](PartApi.md#duplicatepart) | **POST** /Part/{id}/duplicate | Duplicate an existing part
[**GetParts**](PartApi.md#getparts) | **GET** /Part | Get an overview of all parts
[**PartGetLastLog**](PartApi.md#partgetlastlog) | **GET** /Part/{id}/getLastLog | Get last log about the part
[**PartGetPrice**](PartApi.md#partgetprice) | **GET** /Part/{id}/getPrice | Get price of a specified part
[**PartGetStock**](PartApi.md#partgetstock) | **GET** /Part/{id}/getStock | Get stock of the part
[**PartGetStockBefore**](PartApi.md#partgetstockbefore) | **GET** /Part/{id}/getStockBefore | Get stock difference of the part before a specified date
[**UpdatePart**](PartApi.md#updatepart) | **PUT** /Part/{id} | Update an existing part


<a name="addpart"></a>
# **AddPart**
> ModelPart AddPart (string body)

Create a new part

Calls Part.php to add a part

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddPartExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PartApi();
            var body = "partNumber=1111&name=test part&stock=10&taxRate=19&unity[id]=1&unity[objectName]=Unity&price=42.50&category[id]=1&category[objectName]=Category";  // string | To create a part, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new part
                ModelPart result = apiInstance.AddPart(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartApi.AddPart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a part, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelPart**](ModelPart.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bookpart"></a>
# **BookPart**
> ModelPart BookPart (int? id, string body)

add / remove parts from the stock

Calls book() in Part.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class BookPartExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PartApi();
            var id = 56;  // int? | id of part of which you want to update the stock
            var body = "name=&amount=&date=&object[id]&object[objectName]=&supplier[id]=&supplier[objectName]=Contact";  // string | Parameters which need to be updated. Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // add / remove parts from the stock
                ModelPart result = apiInstance.BookPart(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartApi.BookPart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of part of which you want to update the stock | 
 **body** | **string**| Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelPart**](ModelPart.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepart"></a>
# **DeletePart**
> void DeletePart (int? id)

Delete an existing part

Calls the delete() function in Part.php. Be aware that you can't delete parts which are used somewhere!

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeletePartExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PartApi();
            var id = 56;  // int? | id of the part you want to delete

            try
            {
                // Delete an existing part
                apiInstance.DeletePart(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartApi.DeletePart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of the part you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="duplicatepart"></a>
# **DuplicatePart**
> ModelPart DuplicatePart (int? id)

Duplicate an existing part

Calls duplicate() in Part.php to duplicate the specified part. Mind that the stock will be zero

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DuplicatePartExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PartApi();
            var id = 56;  // int? | Id of the part which you want to duplicate

            try
            {
                // Duplicate an existing part
                ModelPart result = apiInstance.DuplicatePart(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartApi.DuplicatePart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the part which you want to duplicate | 

### Return type

[**ModelPart**](ModelPart.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparts"></a>
# **GetParts**
> ModelPart GetParts (int? limit, int? offset, List<string> embed)

Get an overview of all parts

Calls Part.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetPartsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PartApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned parts start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all parts
                ModelPart result = apiInstance.GetParts(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartApi.GetParts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned parts start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelPart**](ModelPart.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="partgetlastlog"></a>
# **PartGetLastLog**
> ModelInventoryPartLog PartGetLastLog (int? id, string maxDate, List<string> embed)

Get last log about the part

Calls getLastLog() in Part.php to get the last log about the specified part

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class PartGetLastLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PartApi();
            var id = 56;  // int? | Id of the part of which you want to get the last log
            var maxDate = maxDate_example;  // string | Sets the maximal date if required (optional)  (default to )
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get last log about the part
                ModelInventoryPartLog result = apiInstance.PartGetLastLog(id, maxDate, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartApi.PartGetLastLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the part of which you want to get the last log | 
 **maxDate** | **string**| Sets the maximal date if required | [optional] [default to ]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelInventoryPartLog**](ModelInventoryPartLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="partgetprice"></a>
# **PartGetPrice**
> void PartGetPrice (int? id, int? contactId, string contactObjectName, int? partUnityId, string partUnityObjectName)

Get price of a specified part

Calls getPrice() in Part.php to get the price of the specified part

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class PartGetPriceExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PartApi();
            var id = 56;  // int? | Id of the part of which you want to get the price
            var contactId = 56;  // int? | Enter valid contact id here for getting a part contact price (optional) 
            var contactObjectName = contactObjectName_example;  // string | Enter 'Contact' here for getting a part contact price (optional)  (default to )
            var partUnityId = 56;  // int? | Enter a valid part unity id here for getting a part unity price (optional) 
            var partUnityObjectName = partUnityObjectName_example;  // string | Enter 'PartUnity' here for getting a part unity price (optional)  (default to )

            try
            {
                // Get price of a specified part
                apiInstance.PartGetPrice(id, contactId, contactObjectName, partUnityId, partUnityObjectName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartApi.PartGetPrice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the part of which you want to get the price | 
 **contactId** | **int?**| Enter valid contact id here for getting a part contact price | [optional] 
 **contactObjectName** | **string**| Enter &#39;Contact&#39; here for getting a part contact price | [optional] [default to ]
 **partUnityId** | **int?**| Enter a valid part unity id here for getting a part unity price | [optional] 
 **partUnityObjectName** | **string**| Enter &#39;PartUnity&#39; here for getting a part unity price | [optional] [default to ]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="partgetstock"></a>
# **PartGetStock**
> void PartGetStock (int? id, string maxDate)

Get stock of the part

Calls getStock() in Part.php to get the stock of the specified part

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class PartGetStockExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PartApi();
            var id = 56;  // int? | Id of the part of which you want to get stock
            var maxDate = maxDate_example;  // string | Sets the maximal date if required. The function will return the stock of the part at the specified date! (optional)  (default to )

            try
            {
                // Get stock of the part
                apiInstance.PartGetStock(id, maxDate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartApi.PartGetStock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the part of which you want to get stock | 
 **maxDate** | **string**| Sets the maximal date if required. The function will return the stock of the part at the specified date! | [optional] [default to ]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="partgetstockbefore"></a>
# **PartGetStockBefore**
> void PartGetStockBefore (int? id, string date)

Get stock difference of the part before a specified date

Calls getStockBefore() in Part.php to get the stock difference of the specified part before the specified date

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class PartGetStockBeforeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PartApi();
            var id = 56;  // int? | Id of the part of which you want to get the stock difference
            var date = date_example;  // string | You will get the stock difference before this specified date, otherwise the current date will be used (optional)  (default to )

            try
            {
                // Get stock difference of the part before a specified date
                apiInstance.PartGetStockBefore(id, date);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartApi.PartGetStockBefore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the part of which you want to get the stock difference | 
 **date** | **string**| You will get the stock difference before this specified date, otherwise the current date will be used | [optional] [default to ]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepart"></a>
# **UpdatePart**
> ModelPart UpdatePart (int? id, string body)

Update an existing part

Calls PartContactPrice to update a part

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdatePartExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PartApi();
            var id = 56;  // int? | id of part you want to update
            var body = body_example;  // string | Parameters which need to be updated. Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // Update an existing part
                ModelPart result = apiInstance.UpdatePart(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartApi.UpdatePart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of part you want to update | 
 **body** | **string**| Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelPart**](ModelPart.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

