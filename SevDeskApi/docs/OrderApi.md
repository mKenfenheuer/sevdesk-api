# SevDeskApi.Api.OrderApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrder**](OrderApi.md#addorder) | **POST** /Order | Create a new order
[**CopyOrder**](OrderApi.md#copyorder) | **POST** /Order/{id}/copy | Copy an existing order
[**DeleteOrder**](OrderApi.md#deleteorder) | **DELETE** /Order/{id} | Delete an existing order
[**DuplicateOrder**](OrderApi.md#duplicateorder) | **POST** /Order/{id}/duplicate | Duplicate an existing order
[**GetNextOrderNumber**](OrderApi.md#getnextordernumber) | **GET** /Order/Factory/getNextOrderNumber | Get the next order number
[**GetOrderDiscounts**](OrderApi.md#getorderdiscounts) | **GET** /Order/{id}/getDiscounts | Get all order discounts
[**GetOrders**](OrderApi.md#getorders) | **GET** /Order | Get an overview of all orders
[**OrderChangeStatus**](OrderApi.md#orderchangestatus) | **PUT** /Order/{id}/changeStatus | Update status of an existing order
[**OrderGetChargeableInformation**](OrderApi.md#ordergetchargeableinformation) | **GET** /Order/{id}/getChargeableInformation | Get sum charged already, total net, gross and tax amount and tax rate
[**OrderGetChargeableSums**](OrderApi.md#ordergetchargeablesums) | **GET** /Order/{id}/getChargeableSums | Get total net, gross and tax amount of order
[**OrderGetMainOrderByLogs**](OrderApi.md#ordergetmainorderbylogs) | **GET** /Order/{id}/getMainOrderByLogs | Get main order by checking if there are existing order logs of the specified order
[**OrderGetPdf**](OrderApi.md#ordergetpdf) | **GET** /Order/{id}/getPdf | Get the order as a pdf
[**OrderGetPositions**](OrderApi.md#ordergetpositions) | **GET** /Order/{id}/getPositions | Get all order positions
[**OrderGetRelatedObjects**](OrderApi.md#ordergetrelatedobjects) | **GET** /Order/{id}/getRelatedObjects | Get related objects of a specified order
[**OrderGetTags**](OrderApi.md#ordergettags) | **GET** /Order/{id}/getTags | Get tags of the specified order
[**OrderGetTax**](OrderApi.md#ordergettax) | **GET** /Order/{id}/getTax | Get sum tax of the specified order
[**OrderGetTaxGroupes**](OrderApi.md#ordergettaxgroupes) | **GET** /Order/{id}/getTaxGroupes | Get tax groups of the specified order
[**OrderGetTotal**](OrderApi.md#ordergettotal) | **GET** /Order/{id}/getTotal | Get sum gross of the specified order
[**OrderGetTotalCalc**](OrderApi.md#ordergettotalcalc) | **GET** /Order/{id}/getTotalCalc | Get total gross amount of order
[**OrderGetTotalNet**](OrderApi.md#ordergettotalnet) | **GET** /Order/{id}/getTotalNet | Get total net amount of order
[**OrderRender**](OrderApi.md#orderrender) | **POST** /Order/{id}/render | Render the order document on doc server and return the metadata
[**OrderSendBy**](OrderApi.md#ordersendby) | **PUT** /Order/{id}/sendBy | Send an order by the desired send type
[**SendOrderViaEmail**](OrderApi.md#sendorderviaemail) | **POST** /Order/{id}/sendViaEmail | Send an order via Email
[**SendOrderViaPost**](OrderApi.md#sendorderviapost) | **POST** /Order/{id}/sendViaPost | Send an order via post
[**UpdateOrder**](OrderApi.md#updateorder) | **PUT** /Order/{id} | Update an existing order


<a name="addorder"></a>
# **AddOrder**
> ModelOrder AddOrder (string body)

Create a new order

Calls Order.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddOrderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var body = "orderNumber=AN-1042&orderType=AN&contact[id]=825022&contact[objectName]=Contact&orderDate=26.8.2015&header=Angebot O-42&headText=head text&footText=foot text&addressName=Factory&addressStreet=Hauptstr. 5&addressZip=77933&addressCity=Lahr&smallSettlement=0&contactPerson[id]=811&contactPerson[objectName]=SevUser&taxRate=0&taxText=Umsatzsteuer ausweisen&taxType=default&currency=EUR&version=1";  // string | To create an order, simply enter desired values after parameter=, concatenate additional parameters with & and remove the quotation marks.    Be aware that you can't use all the parameters included in the Model_Order, as creating an order involves other functions/models.    So for example, adding a sumNet/Gross/etc. does not work as they normally get their value from the product/part which is involved in the order.    The product/part in this case is handled in the Model_OrderPos which makes a call to Model_Part.    In Order.php there is only a function 'getPositions' which makes the call to OrderPos.php to get the positions involved in the order.

            try
            {
                // Create a new order
                ModelOrder result = apiInstance.AddOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.AddOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an order, simply enter desired values after parameter&#x3D;, concatenate additional parameters with &amp; and remove the quotation marks.    Be aware that you can&#39;t use all the parameters included in the Model_Order, as creating an order involves other functions/models.    So for example, adding a sumNet/Gross/etc. does not work as they normally get their value from the product/part which is involved in the order.    The product/part in this case is handled in the Model_OrderPos which makes a call to Model_Part.    In Order.php there is only a function &#39;getPositions&#39; which makes the call to OrderPos.php to get the positions involved in the order. | 

### Return type

[**ModelOrder**](ModelOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="copyorder"></a>
# **CopyOrder**
> ModelOrder CopyOrder (int? id)

Copy an existing order

Calls copy() in Order.php to copy an existing order.    The new orders origin is the copied order, and its version is the copied orders version increased by one.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class CopyOrderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order which you want to copy

            try
            {
                // Copy an existing order
                ModelOrder result = apiInstance.CopyOrder(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.CopyOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order which you want to copy | 

### Return type

[**ModelOrder**](ModelOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorder"></a>
# **DeleteOrder**
> void DeleteOrder (int? id)

Delete an existing order

Calls the delete() function in Order.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteOrderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | id of order you want to delete

            try
            {
                // Delete an existing order
                apiInstance.DeleteOrder(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.DeleteOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of order you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="duplicateorder"></a>
# **DuplicateOrder**
> ModelOrder DuplicateOrder (int? id)

Duplicate an existing order

Calls duplicate() in Order.php to duplicate an existing order

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DuplicateOrderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order which you want to duplicate

            try
            {
                // Duplicate an existing order
                ModelOrder result = apiInstance.DuplicateOrder(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.DuplicateOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order which you want to duplicate | 

### Return type

[**ModelOrder**](ModelOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnextordernumber"></a>
# **GetNextOrderNumber**
> void GetNextOrderNumber (string orderType, bool? useNextNumber)

Get the next order number



### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetNextOrderNumberExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var orderType = orderType_example;  // string | defines the type of order you want to get the next number from (default to AN)
            var useNextNumber = true;  // bool? | By default this is true, so the orderNumber will increase by one otherwise the orderNumber will not change (default to true)

            try
            {
                // Get the next order number
                apiInstance.GetNextOrderNumber(orderType, useNextNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetNextOrderNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderType** | **string**| defines the type of order you want to get the next number from | [default to AN]
 **useNextNumber** | **bool?**| By default this is true, so the orderNumber will increase by one otherwise the orderNumber will not change | [default to true]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderdiscounts"></a>
# **GetOrderDiscounts**
> ModelDiscounts GetOrderDiscounts (int? id, int? limit, int? offset, List<string> embed)

Get all order discounts

Calls getDiscounts() in Order.php to get the discounts of the specified order

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetOrderDiscountsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order of which you want to get the discounts
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned order positions start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get all order discounts
                ModelDiscounts result = apiInstance.GetOrderDiscounts(id, limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrderDiscounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order of which you want to get the discounts | 
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned order positions start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelDiscounts**](ModelDiscounts.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorders"></a>
# **GetOrders**
> ModelOrder GetOrders (int? limit, int? offset, List<string> embed)

Get an overview of all orders

Calls Order.php to get necessary variables. However, not all variables get their value from Order.php directly but from other models like Model_OrderPos

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetOrdersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned invoice positions start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default `` (optional) 

            try
            {
                // Get an overview of all orders
                ModelOrder result = apiInstance.GetOrders(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned invoice positions start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60; | [optional] 

### Return type

[**ModelOrder**](ModelOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderchangestatus"></a>
# **OrderChangeStatus**
> ModelOrder OrderChangeStatus (int? id, string body)

Update status of an existing order

Calls changeStatus() in Order.php to update the specified orders status

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderChangeStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of order of which you want to change the status
            var body = body_example;  // string | Enter desired values after parameter= and remove the quotation marks!    If updateOther is set to 'true', changeStatus will also change other orders with the same order number.    If updateContactStatus is set to 'true', changeStatus will update the connected contacts category if necessary. (optional) 

            try
            {
                // Update status of an existing order
                ModelOrder result = apiInstance.OrderChangeStatus(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderChangeStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of order of which you want to change the status | 
 **body** | **string**| Enter desired values after parameter&#x3D; and remove the quotation marks!    If updateOther is set to &#39;true&#39;, changeStatus will also change other orders with the same order number.    If updateContactStatus is set to &#39;true&#39;, changeStatus will update the connected contacts category if necessary. | [optional] 

### Return type

[**ModelOrder**](ModelOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergetchargeableinformation"></a>
# **OrderGetChargeableInformation**
> void OrderGetChargeableInformation (int? id)

Get sum charged already, total net, gross and tax amount and tax rate

Calls getChargeableInformation() in Order.php to get the sum charged already, total net, gross and tax amount and tax rate of the specified order

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderGetChargeableInformationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order of which you want to get the information

            try
            {
                // Get sum charged already, total net, gross and tax amount and tax rate
                apiInstance.OrderGetChargeableInformation(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderGetChargeableInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order of which you want to get the information | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergetchargeablesums"></a>
# **OrderGetChargeableSums**
> void OrderGetChargeableSums (int? id)

Get total net, gross and tax amount of order

Calls getChargeableSums() in Order.php to get the total net, gross and tax amount of the specified order

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderGetChargeableSumsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order of which you want to get the total net, gross and tax amount

            try
            {
                // Get total net, gross and tax amount of order
                apiInstance.OrderGetChargeableSums(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderGetChargeableSums: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order of which you want to get the total net, gross and tax amount | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergetmainorderbylogs"></a>
# **OrderGetMainOrderByLogs**
> ModelOrder OrderGetMainOrderByLogs (int? id)

Get main order by checking if there are existing order logs of the specified order

Calls getMainOrderByLogs() in Order.php to get main order by checking if there are existing order logs of the specified order.    If the specified order is not the main order (eg. if there are no existing logs), this will return null!

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderGetMainOrderByLogsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order of which you want to know if it is the main order

            try
            {
                // Get main order by checking if there are existing order logs of the specified order
                ModelOrder result = apiInstance.OrderGetMainOrderByLogs(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderGetMainOrderByLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order of which you want to know if it is the main order | 

### Return type

[**ModelOrder**](ModelOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergetpdf"></a>
# **OrderGetPdf**
> void OrderGetPdf (int? id, bool? preventSendBy)

Get the order as a pdf

Calls getPdf() in Order.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderGetPdfExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order of which you want to get the pdf
            var preventSendBy = true;  // bool? | Define if you want to prevent to send the order via pdf (optional)  (default to false)

            try
            {
                // Get the order as a pdf
                apiInstance.OrderGetPdf(id, preventSendBy);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderGetPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order of which you want to get the pdf | 
 **preventSendBy** | **bool?**| Define if you want to prevent to send the order via pdf | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergetpositions"></a>
# **OrderGetPositions**
> ModelOrderPos OrderGetPositions (int? id, bool? withOptional, bool? onlyChargeable, int? limit, int? offset, List<string> embed)

Get all order positions

Calls getPositions() in Order.php to get necessary variables

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderGetPositionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order of which you want to get the positions
            var withOptional = true;  // bool? | Define if you want optional order positions (optional)  (default to false)
            var onlyChargeable = true;  // bool? | Define if you want only chargeable order positions (optional)  (default to false)
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned order positions start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get all order positions
                ModelOrderPos result = apiInstance.OrderGetPositions(id, withOptional, onlyChargeable, limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderGetPositions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order of which you want to get the positions | 
 **withOptional** | **bool?**| Define if you want optional order positions | [optional] [default to false]
 **onlyChargeable** | **bool?**| Define if you want only chargeable order positions | [optional] [default to false]
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned order positions start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelOrderPos**](ModelOrderPos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergetrelatedobjects"></a>
# **OrderGetRelatedObjects**
> void OrderGetRelatedObjects (int? id, bool? includeItself, bool? sortByType, List<string> embed)

Get related objects of a specified order

Calls getRelatedObjects() in Order.php to get related objects of the order

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderGetRelatedObjectsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order of which you want to get the related objects
            var includeItself = true;  // bool? | Define if the related objects include the order itself (optional)  (default to false)
            var sortByType = true;  // bool? | Define if you want the related objects sorted by type (optional)  (default to false)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get related objects of a specified order
                apiInstance.OrderGetRelatedObjects(id, includeItself, sortByType, embed);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderGetRelatedObjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order of which you want to get the related objects | 
 **includeItself** | **bool?**| Define if the related objects include the order itself | [optional] [default to false]
 **sortByType** | **bool?**| Define if you want the related objects sorted by type | [optional] [default to false]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergettags"></a>
# **OrderGetTags**
> void OrderGetTags (int? id, List<string> embed)

Get tags of the specified order

Calls getTags() in Order.php to get the tags of the specified order

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderGetTagsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order of which you want to get the tags
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get tags of the specified order
                apiInstance.OrderGetTags(id, embed);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderGetTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order of which you want to get the tags | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergettax"></a>
# **OrderGetTax**
> void OrderGetTax (int? id, bool? foreignCurrency)

Get sum tax of the specified order

Calls getTax() in Order.php to get the sum tax of the specified order

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderGetTaxExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order of which you want to get the sum tax
            var foreignCurrency = true;  // bool? | Specify if a foreign currency is used (optional)  (default to false)

            try
            {
                // Get sum tax of the specified order
                apiInstance.OrderGetTax(id, foreignCurrency);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderGetTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order of which you want to get the sum tax | 
 **foreignCurrency** | **bool?**| Specify if a foreign currency is used | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergettaxgroupes"></a>
# **OrderGetTaxGroupes**
> void OrderGetTaxGroupes (int? id)

Get tax groups of the specified order

Calls getTaxGroupes() in Order.php to get the tax groups of the specified order

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderGetTaxGroupesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order of which you want to get the tax groups

            try
            {
                // Get tax groups of the specified order
                apiInstance.OrderGetTaxGroupes(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderGetTaxGroupes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order of which you want to get the tax groups | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergettotal"></a>
# **OrderGetTotal**
> void OrderGetTotal (int? id, bool? foreignCurrency)

Get sum gross of the specified order

Calls getTotal() in Order.php to get the sum gross of the specified order

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderGetTotalExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order of which you want to get the sum gross
            var foreignCurrency = true;  // bool? | Specify if a foreign currency is used (optional)  (default to false)

            try
            {
                // Get sum gross of the specified order
                apiInstance.OrderGetTotal(id, foreignCurrency);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderGetTotal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order of which you want to get the sum gross | 
 **foreignCurrency** | **bool?**| Specify if a foreign currency is used | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergettotalcalc"></a>
# **OrderGetTotalCalc**
> void OrderGetTotalCalc (int? id)

Get total gross amount of order

Calls getTotalCalc() in Order.php to get the total gross amount of the specified order

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderGetTotalCalcExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order of which you want to get the total gross amount

            try
            {
                // Get total gross amount of order
                apiInstance.OrderGetTotalCalc(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderGetTotalCalc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order of which you want to get the total gross amount | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergettotalnet"></a>
# **OrderGetTotalNet**
> void OrderGetTotalNet (int? id)

Get total net amount of order

Calls getTotalNet() in Order.php to get the total net amount of the specified order

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderGetTotalNetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of the order of which you want to get the total net amount

            try
            {
                // Get total net amount of order
                apiInstance.OrderGetTotalNet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderGetTotalNet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the order of which you want to get the total net amount | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderrender"></a>
# **OrderRender**
> void OrderRender (int? id)

Render the order document on doc server and return the metadata

Calls render() in Order.php to render an order document on doc server and return the metadata

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderRenderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of order you want to render

            try
            {
                // Render the order document on doc server and return the metadata
                apiInstance.OrderRender(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderRender: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of order you want to render | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordersendby"></a>
# **OrderSendBy**
> ModelOrder OrderSendBy (int? id, string sendType)

Send an order by the desired send type

Calls sendBy() in Order.php to send the order by the desired send type

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class OrderSendByExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of order which you want to send
            var sendType = sendType_example;  // string | Your desired send type. Available are: VM = Mail, VP = Post, VPDF = PDF, PRN = Print (optional)  (default to )

            try
            {
                // Send an order by the desired send type
                ModelOrder result = apiInstance.OrderSendBy(id, sendType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderSendBy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of order which you want to send | 
 **sendType** | **string**| Your desired send type. Available are: VM &#x3D; Mail, VP &#x3D; Post, VPDF &#x3D; PDF, PRN &#x3D; Print | [optional] [default to ]

### Return type

[**ModelOrder**](ModelOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendorderviaemail"></a>
# **SendOrderViaEmail**
> ModelEmail SendOrderViaEmail (int? id, string body)

Send an order via Email

Calls sendViaEmail in Order.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class SendOrderViaEmailExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of order you want to send via Email
            var body = "toEmail=test@sevenit.de&subject=This is a test&text=Hello this is a test mail";  // string | Change the desired values after the parameters and remove the quotation marks. You can also add 'additionalAttachments', 'ccEmail=' and 'bccEmail'    Please note: additionalAttachments is a String containing document id's (of existing documents!)

            try
            {
                // Send an order via Email
                ModelEmail result = apiInstance.SendOrderViaEmail(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.SendOrderViaEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of order you want to send via Email | 
 **body** | **string**| Change the desired values after the parameters and remove the quotation marks. You can also add &#39;additionalAttachments&#39;, &#39;ccEmail&#x3D;&#39; and &#39;bccEmail&#39;    Please note: additionalAttachments is a String containing document id&#39;s (of existing documents!) | 

### Return type

[**ModelEmail**](ModelEmail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendorderviapost"></a>
# **SendOrderViaPost**
> ModelOrder SendOrderViaPost (int? id)

Send an order via post

Calls sendViaPost() in Order.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class SendOrderViaPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | Id of order you want to send via post

            try
            {
                // Send an order via post
                ModelOrder result = apiInstance.SendOrderViaPost(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.SendOrderViaPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of order you want to send via post | 

### Return type

[**ModelOrder**](ModelOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorder"></a>
# **UpdateOrder**
> ModelOrder UpdateOrder (int? id, string body)

Update an existing order

Calls Order.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateOrderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new OrderApi();
            var id = 56;  // int? | id of order you want to update
            var body = body_example;  // string | Parameters which need to be updated. Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update an existing order
                ModelOrder result = apiInstance.UpdateOrder(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.UpdateOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of order you want to update | 
 **body** | **string**| Parameters which need to be updated. Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelOrder**](ModelOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

