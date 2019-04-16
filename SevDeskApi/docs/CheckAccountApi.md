# SevDeskApi.Api.CheckAccountApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCheckAccount**](CheckAccountApi.md#addcheckaccount) | **POST** /CheckAccount | Create a new check account
[**CheckAccountGetCurrentBalance**](CheckAccountApi.md#checkaccountgetcurrentbalance) | **GET** /CheckAccount/{id}/getCurrentBalance | Get current balance of the specified check account
[**CheckAccountGetPaymentIsSupported**](CheckAccountApi.md#checkaccountgetpaymentissupported) | **GET** /CheckAccount/getPaymentIsSupported | Return if a payment method is supported
[**CheckAccountSetDefault**](CheckAccountApi.md#checkaccountsetdefault) | **PUT** /CheckAccount/{id}/setDefault | Set the specified check accounts as the default check account
[**CheckAccountTransfer**](CheckAccountApi.md#checkaccounttransfer) | **PUT** /CheckAccount/{id}/transfer | Transfer an amount from one check account to another
[**DeleteCheckAccount**](CheckAccountApi.md#deletecheckaccount) | **DELETE** /CheckAccount/{id} | Delete an existing check account
[**GetCheckAccounts**](CheckAccountApi.md#getcheckaccounts) | **GET** /CheckAccount | Get an overview of all check accounts
[**UpdateCheckAccount**](CheckAccountApi.md#updatecheckaccount) | **PUT** /CheckAccount/{id} | Update an existing check account


<a name="addcheckaccount"></a>
# **AddCheckAccount**
> ModelCheckAccount AddCheckAccount (string body)

Create a new check account

Calls CheckAccount.php to create a check account

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddCheckAccountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountApi();
            var body = "name=&type=&currency=&status=";  // string | To create a check account, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new check account
                ModelCheckAccount result = apiInstance.AddCheckAccount(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountApi.AddCheckAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a check account, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelCheckAccount**](ModelCheckAccount.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkaccountgetcurrentbalance"></a>
# **CheckAccountGetCurrentBalance**
> void CheckAccountGetCurrentBalance (int? id)

Get current balance of the specified check account

Calls getCurrentBalance() in CheckAccount.php to get the balance of the specified check account.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class CheckAccountGetCurrentBalanceExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountApi();
            var id = 56;  // int? | Id of the check account of which you want the current balance

            try
            {
                // Get current balance of the specified check account
                apiInstance.CheckAccountGetCurrentBalance(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountApi.CheckAccountGetCurrentBalance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the check account of which you want the current balance | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkaccountgetpaymentissupported"></a>
# **CheckAccountGetPaymentIsSupported**
> void CheckAccountGetPaymentIsSupported ()

Return if a payment method is supported

Calls getPaymentIsSupported() in CheckAccount.php to get if a payment method is supported.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class CheckAccountGetPaymentIsSupportedExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountApi();

            try
            {
                // Return if a payment method is supported
                apiInstance.CheckAccountGetPaymentIsSupported();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountApi.CheckAccountGetPaymentIsSupported: " + e.Message );
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

<a name="checkaccountsetdefault"></a>
# **CheckAccountSetDefault**
> void CheckAccountSetDefault (int? id)

Set the specified check accounts as the default check account

Calls setDefault() in CheckAccount.php to set a specified check account as the default check account

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class CheckAccountSetDefaultExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountApi();
            var id = 56;  // int? | Id of check account you want to set as the default check account

            try
            {
                // Set the specified check accounts as the default check account
                apiInstance.CheckAccountSetDefault(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountApi.CheckAccountSetDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of check account you want to set as the default check account | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkaccounttransfer"></a>
# **CheckAccountTransfer**
> void CheckAccountTransfer (int? id, string amount, int? targetId, string targetObjectName, string date)

Transfer an amount from one check account to another

Calls transfer() in CheckAccount.php to transfer an amount from one check account to another

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class CheckAccountTransferExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountApi();
            var id = 56;  // int? | Id of check account you want to use as source account
            var amount = amount_example;  // string | Amount you want to transfer (default to )
            var targetId = 56;  // int? | Target check account id
            var targetObjectName = targetObjectName_example;  // string | Target check account object name (default to CheckAccount)
            var date = date_example;  // string | Date of the transfer (default to )

            try
            {
                // Transfer an amount from one check account to another
                apiInstance.CheckAccountTransfer(id, amount, targetId, targetObjectName, date);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountApi.CheckAccountTransfer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of check account you want to use as source account | 
 **amount** | **string**| Amount you want to transfer | [default to ]
 **targetId** | **int?**| Target check account id | 
 **targetObjectName** | **string**| Target check account object name | [default to CheckAccount]
 **date** | **string**| Date of the transfer | [default to ]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecheckaccount"></a>
# **DeleteCheckAccount**
> void DeleteCheckAccount (int? id)

Delete an existing check account

Calls the delete() function in CheckAccount.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteCheckAccountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountApi();
            var id = 56;  // int? | Id of check account you want to delete

            try
            {
                // Delete an existing check account
                apiInstance.DeleteCheckAccount(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountApi.DeleteCheckAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of check account you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcheckaccounts"></a>
# **GetCheckAccounts**
> ModelDiscounts GetCheckAccounts (int? limit, int? offset, List<string> embed)

Get an overview of all check accounts

Calls CheckAccount.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetCheckAccountsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned check accounts start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all check accounts
                ModelDiscounts result = apiInstance.GetCheckAccounts(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountApi.GetCheckAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned check accounts start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelDiscounts**](ModelDiscounts.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecheckaccount"></a>
# **UpdateCheckAccount**
> ModelCheckAccount UpdateCheckAccount (int? id, string body)

Update an existing check account

Calls CheckAccount.php to update a check account

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateCheckAccountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountApi();
            var id = 56;  // int? | Id of check account you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create discount.    Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update an existing check account
                ModelCheckAccount result = apiInstance.UpdateCheckAccount(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountApi.UpdateCheckAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of check account you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create discount.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelCheckAccount**](ModelCheckAccount.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

