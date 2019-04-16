# SevDeskApi.Api.PaymentMethodApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPaymentMethod**](PaymentMethodApi.md#addpaymentmethod) | **POST** /PaymentMethod | Create a new payment method
[**DeletePaymentMethod**](PaymentMethodApi.md#deletepaymentmethod) | **DELETE** /PaymentMethod/{id} | Delete an existing payment method
[**GetPaymentMethods**](PaymentMethodApi.md#getpaymentmethods) | **GET** /PaymentMethod | Get an overview of all payment methods
[**UpdatePaymentMethod**](PaymentMethodApi.md#updatepaymentmethod) | **PUT** /PaymentMethod/{id} | Update an existing payment method


<a name="addpaymentmethod"></a>
# **AddPaymentMethod**
> ModelPaymentMethod AddPaymentMethod (string body)

Create a new payment method

Calls PaymentMethod.php to create a payment method

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddPaymentMethodExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PaymentMethodApi();
            var body = "name=&text=";  // string | write desired values behind the = and remove the quotation marks to create a payment method

            try
            {
                // Create a new payment method
                ModelPaymentMethod result = apiInstance.AddPaymentMethod(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentMethodApi.AddPaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| write desired values behind the &#x3D; and remove the quotation marks to create a payment method | 

### Return type

[**ModelPaymentMethod**](ModelPaymentMethod.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepaymentmethod"></a>
# **DeletePaymentMethod**
> void DeletePaymentMethod (int? id)

Delete an existing payment method

Calls the delete() function in PaymentMethod.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeletePaymentMethodExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PaymentMethodApi();
            var id = 56;  // int? | id of payment method you want to delete

            try
            {
                // Delete an existing payment method
                apiInstance.DeletePaymentMethod(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentMethodApi.DeletePaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of payment method you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentmethods"></a>
# **GetPaymentMethods**
> ModelPaymentMethod GetPaymentMethods (int? limit, int? offset, List<string> embed)

Get an overview of all payment methods

Calls PaymentMethod.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetPaymentMethodsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PaymentMethodApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned payment methods start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all payment methods
                ModelPaymentMethod result = apiInstance.GetPaymentMethods(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentMethodApi.GetPaymentMethods: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned payment methods start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelPaymentMethod**](ModelPaymentMethod.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepaymentmethod"></a>
# **UpdatePaymentMethod**
> ModelPaymentMethod UpdatePaymentMethod (int? id, string body)

Update an existing payment method

Calls PaymentMethod.php to update a payment method

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdatePaymentMethodExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new PaymentMethodApi();
            var id = 56;  // int? | id of payment method you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create payment method.        Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update an existing payment method
                ModelPaymentMethod result = apiInstance.UpdatePaymentMethod(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentMethodApi.UpdatePaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of payment method you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create payment method.        Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelPaymentMethod**](ModelPaymentMethod.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

