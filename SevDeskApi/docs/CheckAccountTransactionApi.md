# SevDeskApi.Api.CheckAccountTransactionApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCheckAccountTransaction**](CheckAccountTransactionApi.md#addcheckaccounttransaction) | **POST** /CheckAccountTransaction | Create a new check account transaction
[**CheckAccountTransactionGetLog**](CheckAccountTransactionApi.md#checkaccounttransactiongetlog) | **GET** /CheckAccountTransaction/{id}/getLog | Get log of a specified check account transaction
[**CheckAccountTransactionGetRemainingAmount**](CheckAccountTransactionApi.md#checkaccounttransactiongetremainingamount) | **GET** /CheckAccountTransaction/{id}/getRemainingAmount | Get invoice amount which is not assigned yet
[**DeleteCheckAccountTransaction**](CheckAccountTransactionApi.md#deletecheckaccounttransaction) | **DELETE** /CheckAccountTransaction/{id} | Delete an existing check account transaction
[**GetCheckAccountTransactions**](CheckAccountTransactionApi.md#getcheckaccounttransactions) | **GET** /CheckAccountTransaction | Get an overview of all check account transactions
[**LinkInvoiceToCheckAccountTransaction**](CheckAccountTransactionApi.md#linkinvoicetocheckaccounttransaction) | **PUT** /CheckAccountTransaction/{id}/linkInvoice | link invoice to check account transaction
[**LinkVoucherToCheckAccountTransaction**](CheckAccountTransactionApi.md#linkvouchertocheckaccounttransaction) | **PUT** /CheckAccountTransaction/{id}/linkVoucher | link voucher to check account transaction
[**UpdateCheckAccountTransaction**](CheckAccountTransactionApi.md#updatecheckaccounttransaction) | **PUT** /CheckAccountTransaction/{id} | Update a existing check account transaction
[**UpdateCheckAccountTransactionStatus**](CheckAccountTransactionApi.md#updatecheckaccounttransactionstatus) | **PUT** /CheckAccountTransaction/{id}/changeStatus | Update status of a existing check account transaction


<a name="addcheckaccounttransaction"></a>
# **AddCheckAccountTransaction**
> ModelCheckAccountTransaction AddCheckAccountTransaction (string body)

Create a new check account transaction

Calls CheckAccountTransaction.php 

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddCheckAccountTransactionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountTransactionApi();
            var body = "valueDate=&amount=&paymtPurpose=&checkAccount[id]=&checkAccount[objectName]=CheckAccount";  // string | To create a check account transaction , simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new check account transaction
                ModelCheckAccountTransaction result = apiInstance.AddCheckAccountTransaction(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountTransactionApi.AddCheckAccountTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a check account transaction , simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelCheckAccountTransaction**](ModelCheckAccountTransaction.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkaccounttransactiongetlog"></a>
# **CheckAccountTransactionGetLog**
> ModelCheckAccountTransactionLog CheckAccountTransactionGetLog (int? id, List<string> embed)

Get log of a specified check account transaction

Calls getLog() in CheckAccountTransaction.php to get the log of a specified check account transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class CheckAccountTransactionGetLogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountTransactionApi();
            var id = 56;  // int? | Id of the check account transaction of which you want to get the log
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get log of a specified check account transaction
                ModelCheckAccountTransactionLog result = apiInstance.CheckAccountTransactionGetLog(id, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountTransactionApi.CheckAccountTransactionGetLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the check account transaction of which you want to get the log | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelCheckAccountTransactionLog**](ModelCheckAccountTransactionLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkaccounttransactiongetremainingamount"></a>
# **CheckAccountTransactionGetRemainingAmount**
> void CheckAccountTransactionGetRemainingAmount (int? id)

Get invoice amount which is not assigned yet

Calls getRemainingAmount() in CheckAccountTransaction.php to get invoice amount which is not assigned yet.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class CheckAccountTransactionGetRemainingAmountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountTransactionApi();
            var id = 56;  // int? | Id of check account transaction you want to use

            try
            {
                // Get invoice amount which is not assigned yet
                apiInstance.CheckAccountTransactionGetRemainingAmount(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountTransactionApi.CheckAccountTransactionGetRemainingAmount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of check account transaction you want to use | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecheckaccounttransaction"></a>
# **DeleteCheckAccountTransaction**
> void DeleteCheckAccountTransaction (int? id)

Delete an existing check account transaction

Calls the delete() function in CheckAccountTransaction.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteCheckAccountTransactionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountTransactionApi();
            var id = 56;  // int? | id of check account transaction you want to delete

            try
            {
                // Delete an existing check account transaction
                apiInstance.DeleteCheckAccountTransaction(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountTransactionApi.DeleteCheckAccountTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of check account transaction you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcheckaccounttransactions"></a>
# **GetCheckAccountTransactions**
> ModelCheckAccountTransaction GetCheckAccountTransactions (int? limit, int? offset, List<string> embed)

Get an overview of all check account transactions

Calls CheckAccountTransaction.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetCheckAccountTransactionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountTransactionApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned check account transactions start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all check account transactions
                ModelCheckAccountTransaction result = apiInstance.GetCheckAccountTransactions(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountTransactionApi.GetCheckAccountTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned check account transactions start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelCheckAccountTransaction**](ModelCheckAccountTransaction.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="linkinvoicetocheckaccounttransaction"></a>
# **LinkInvoiceToCheckAccountTransaction**
> ModelCheckAccountTransaction LinkInvoiceToCheckAccountTransaction (int? id, string body)

link invoice to check account transaction

Calls linkInvoice() in CheckAccountTransaction.php.      This will update the specified invoice as well as the status of the check account transaction!

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class LinkInvoiceToCheckAccountTransactionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountTransactionApi();
            var id = 56;  // int? | id of check account transaction you want to update
            var body = body_example;  // string | Enter the id of the invoice you want to be linked after invoiceId= and remove the quotation marks. (optional) 

            try
            {
                // link invoice to check account transaction
                ModelCheckAccountTransaction result = apiInstance.LinkInvoiceToCheckAccountTransaction(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountTransactionApi.LinkInvoiceToCheckAccountTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of check account transaction you want to update | 
 **body** | **string**| Enter the id of the invoice you want to be linked after invoiceId&#x3D; and remove the quotation marks. | [optional] 

### Return type

[**ModelCheckAccountTransaction**](ModelCheckAccountTransaction.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="linkvouchertocheckaccounttransaction"></a>
# **LinkVoucherToCheckAccountTransaction**
> ModelCheckAccountTransaction LinkVoucherToCheckAccountTransaction (int? id, string body)

link voucher to check account transaction

Calls linkVoucher() in CheckAccountTransaction.php.      This will update the specified voucher as well as the status of the check account transaction!

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class LinkVoucherToCheckAccountTransactionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountTransactionApi();
            var id = 56;  // int? | id of check account transaction you want to update
            var body = body_example;  // string | Enter the id of the voucher you want to be linked after voucherId= and remove the quotation marks. (optional) 

            try
            {
                // link voucher to check account transaction
                ModelCheckAccountTransaction result = apiInstance.LinkVoucherToCheckAccountTransaction(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountTransactionApi.LinkVoucherToCheckAccountTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of check account transaction you want to update | 
 **body** | **string**| Enter the id of the voucher you want to be linked after voucherId&#x3D; and remove the quotation marks. | [optional] 

### Return type

[**ModelCheckAccountTransaction**](ModelCheckAccountTransaction.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecheckaccounttransaction"></a>
# **UpdateCheckAccountTransaction**
> ModelCheckAccountTransaction UpdateCheckAccountTransaction (int? id, string body)

Update a existing check account transaction

Calls CheckAccountTransaction.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateCheckAccountTransactionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountTransactionApi();
            var id = 56;  // int? | id of check account transaction you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create check account transaction.    Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update a existing check account transaction
                ModelCheckAccountTransaction result = apiInstance.UpdateCheckAccountTransaction(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountTransactionApi.UpdateCheckAccountTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of check account transaction you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create check account transaction.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelCheckAccountTransaction**](ModelCheckAccountTransaction.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecheckaccounttransactionstatus"></a>
# **UpdateCheckAccountTransactionStatus**
> ModelCheckAccountTransaction UpdateCheckAccountTransactionStatus (int? id, string body)

Update status of a existing check account transaction

Calls changeStatus() in CheckAccountTransaction.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateCheckAccountTransactionStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new CheckAccountTransactionApi();
            var id = 56;  // int? | id of check account transaction you want to update
            var body = body_example;  // string | Enter your desired status after value= and remove the quotation marks (optional) 

            try
            {
                // Update status of a existing check account transaction
                ModelCheckAccountTransaction result = apiInstance.UpdateCheckAccountTransactionStatus(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckAccountTransactionApi.UpdateCheckAccountTransactionStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of check account transaction you want to update | 
 **body** | **string**| Enter your desired status after value&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelCheckAccountTransaction**](ModelCheckAccountTransaction.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

