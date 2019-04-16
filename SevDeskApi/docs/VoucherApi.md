# SevDeskApi.Api.VoucherApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVoucher**](VoucherApi.md#addvoucher) | **POST** /Voucher | Create a new voucher
[**DeleteVoucher**](VoucherApi.md#deletevoucher) | **DELETE** /Voucher/{id} | Delete an existing voucher
[**GetVouchers**](VoucherApi.md#getvouchers) | **GET** /Voucher | Get an overview of all vouchers
[**SaveVoucher**](VoucherApi.md#savevoucher) | **POST** /Voucher/Factory/saveVoucher | Create a new voucher
[**UpdateVoucher**](VoucherApi.md#updatevoucher) | **PUT** /Voucher/{id} | Update an existing voucher
[**VoucherBookAmount**](VoucherApi.md#voucherbookamount) | **PUT** /Voucher/{id}/bookAmmount | Book an amount for a specified voucher
[**VoucherChangeStatus**](VoucherApi.md#voucherchangestatus) | **PUT** /Voucher/{id}/changeStatus | Change status of a specified voucher
[**VoucherDeleteDocument**](VoucherApi.md#voucherdeletedocument) | **DELETE** /Voucher/{id}/deleteDocument | Delete the document of an existing voucher
[**VoucherExtractThumb**](VoucherApi.md#voucherextractthumb) | **GET** /Voucher/Factory/extractThumb | Extract file thumb
[**VoucherGetAccountingTypes**](VoucherApi.md#vouchergetaccountingtypes) | **GET** /Voucher/{id}/getAccountingTypes | Get the accounting types of a specified voucher
[**VoucherGetCheckAccountTransactionLogs**](VoucherApi.md#vouchergetcheckaccounttransactionlogs) | **GET** /Voucher/{id}/getCheckAccountTransactionLogs | Get the check account transaction logs of a specified voucher
[**VoucherGetCheckAccountTransactions**](VoucherApi.md#vouchergetcheckaccounttransactions) | **GET** /Voucher/{id}/getCheckAccountTransactions | Get the check account transactions of a specified voucher
[**VoucherGetCurrency**](VoucherApi.md#vouchergetcurrency) | **GET** /Voucher/{id}/getCurrency | Get the currency of a specified voucher
[**VoucherGetDebit**](VoucherApi.md#vouchergetdebit) | **GET** /Voucher/{id}/getDebit | Get unpaid amount of a specified voucher
[**VoucherGetDelinquent**](VoucherApi.md#vouchergetdelinquent) | **GET** /Voucher/{id}/getDelinquent | Return if the voucher is delinquent
[**VoucherGetDependingRecurringVouchers**](VoucherApi.md#vouchergetdependingrecurringvouchers) | **GET** /Voucher/{id}/getDependingRecurringVouchers | Get the depending recurring vouchers of a specified origin voucher
[**VoucherGetDocumentImage**](VoucherApi.md#vouchergetdocumentimage) | **GET** /Voucher/{id}/getDocumentImage | Returns the base64 encoded preview content of the vouchers document
[**VoucherGetTaxGroups**](VoucherApi.md#vouchergettaxgroups) | **GET** /Voucher/{id}/getTaxGroupes | Get an overview of all vouchers
[**VoucherMarkAsOpen**](VoucherApi.md#vouchermarkasopen) | **PUT** /Voucher/{id}/markAsOpen | Mark a specified voucher as open
[**VoucherMarkAsPaid**](VoucherApi.md#vouchermarkaspaid) | **PUT** /Voucher/{id}/markAsPaid | Mark a specified voucher as paid
[**VoucherRefundAmount**](VoucherApi.md#voucherrefundamount) | **PUT** /Voucher/{id}/refundAmmount | Refund an amount for a specified voucher
[**VoucherUploadTempFile**](VoucherApi.md#voucheruploadtempfile) | **POST** /Voucher/Factory/uploadTempFile | Upload a temporary file to be used later


<a name="addvoucher"></a>
# **AddVoucher**
> ModelVoucher AddVoucher (string body)

Create a new voucher

Calls Voucher.php to create a voucher

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddVoucherExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var body = "voucherType=VOU&description=&status=&supplier[id]=&supplier[objectName]=Contact&voucherDate=&paymentDeadline=&taxType=default&creditDebit=C";  // string | To create a voucher, simply enter desired values after parameter= and remove the quotation marks.      Be aware that you can't use all the parameters included in the Model_Voucher, as creating a voucher involves other functions.      So for example, adding a sumNet/Gross/etc. does not work as they normally get their value from the product which is involved in the voucher      The product/part in this case is handled in the Model_VoucherPos which makes a call to Model_Part.

            try
            {
                // Create a new voucher
                ModelVoucher result = apiInstance.AddVoucher(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.AddVoucher: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a voucher, simply enter desired values after parameter&#x3D; and remove the quotation marks.      Be aware that you can&#39;t use all the parameters included in the Model_Voucher, as creating a voucher involves other functions.      So for example, adding a sumNet/Gross/etc. does not work as they normally get their value from the product which is involved in the voucher      The product/part in this case is handled in the Model_VoucherPos which makes a call to Model_Part. | 

### Return type

[**ModelVoucher**](ModelVoucher.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevoucher"></a>
# **DeleteVoucher**
> void DeleteVoucher (int? id)

Delete an existing voucher

Calls the delete() function in Voucher.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteVoucherExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of voucher you want to delete

            try
            {
                // Delete an existing voucher
                apiInstance.DeleteVoucher(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.DeleteVoucher: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of voucher you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvouchers"></a>
# **GetVouchers**
> ModelVoucher GetVouchers (int? limit, int? offset, List<string> embed)

Get an overview of all vouchers

Calls Voucher.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetVouchersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned vouchers start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all vouchers
                ModelVoucher result = apiInstance.GetVouchers(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.GetVouchers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned vouchers start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelVoucher**](ModelVoucher.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savevoucher"></a>
# **SaveVoucher**
> ModelVoucherFactory SaveVoucher (string body)

Create a new voucher

With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new voucher it wont be saved by a POST request with '/Voucher?para1=&...' but with the saveVoucher function in Factory.php 'Voucher/Factory/saveVoucher?para1='

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class SaveVoucherExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var body = body_example;  // string | The saveVoucher function in Voucher/Factory.php combines both Voucher and VoucherPos with all their HTTP-methods.    It is now possible to **simultaneously** create a voucher with its position.    To simply (only) create a voucher you can use the given parameters and concatenate your values.    For also adding a voucher position refer to the **quick reference** below.    The parameters you find there are **needed** for creating a voucher position. Just concatenate them to the existing voucher parameters.    You can also find additional (optional) parameters in the **Models** section.    Quick reference:  * &voucherPosSave[0][accountingType][id]=  * &voucherPosSave[0][accountingType][objectName]=AccountingType  * &voucherPosSave[0][taxRate]=19  * &voucherPosSave[0][sum]=  * &voucherPosSave[0][objectName]=VoucherPos  * &voucherPosSave[0][mapAll]=true  * &voucherPosDelete=true/false <- - if you provide this parameter, you can delete a voucher position    You can also use additional parameters for creating a voucher in the same way by adding them in the format: **voucher[yourParameter]** 

            try
            {
                // Create a new voucher
                ModelVoucherFactory result = apiInstance.SaveVoucher(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.SaveVoucher: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| The saveVoucher function in Voucher/Factory.php combines both Voucher and VoucherPos with all their HTTP-methods.    It is now possible to **simultaneously** create a voucher with its position.    To simply (only) create a voucher you can use the given parameters and concatenate your values.    For also adding a voucher position refer to the **quick reference** below.    The parameters you find there are **needed** for creating a voucher position. Just concatenate them to the existing voucher parameters.    You can also find additional (optional) parameters in the **Models** section.    Quick reference:  * &amp;voucherPosSave[0][accountingType][id]&#x3D;  * &amp;voucherPosSave[0][accountingType][objectName]&#x3D;AccountingType  * &amp;voucherPosSave[0][taxRate]&#x3D;19  * &amp;voucherPosSave[0][sum]&#x3D;  * &amp;voucherPosSave[0][objectName]&#x3D;VoucherPos  * &amp;voucherPosSave[0][mapAll]&#x3D;true  * &amp;voucherPosDelete&#x3D;true/false &lt;- - if you provide this parameter, you can delete a voucher position    You can also use additional parameters for creating a voucher in the same way by adding them in the format: **voucher[yourParameter]**  | 

### Return type

[**ModelVoucherFactory**](ModelVoucherFactory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevoucher"></a>
# **UpdateVoucher**
> ModelVoucher UpdateVoucher (int? id, string body)

Update an existing voucher

Calls Voucher.php to update an existing voucher

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateVoucherExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create invoice.      Enter the parameters according to the syntax: parameter1=&parameter2= and remove the quotation marks (optional) 

            try
            {
                // Update an existing voucher
                ModelVoucher result = apiInstance.UpdateVoucher(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.UpdateVoucher: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create invoice.      Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; and remove the quotation marks | [optional] 

### Return type

[**ModelVoucher**](ModelVoucher.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voucherbookamount"></a>
# **VoucherBookAmount**
> void VoucherBookAmount (int? id, string body)

Book an amount for a specified voucher

Book an amount for the specified voucher

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherBookAmountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher for which you want to book an amount
            var body = body_example;  // string | To book an amount for your voucher, simply enter desired values after parameter= and remove the quotation marks. (optional) 

            try
            {
                // Book an amount for a specified voucher
                apiInstance.VoucherBookAmount(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherBookAmount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher for which you want to book an amount | 
 **body** | **string**| To book an amount for your voucher, simply enter desired values after parameter&#x3D; and remove the quotation marks. | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voucherchangestatus"></a>
# **VoucherChangeStatus**
> void VoucherChangeStatus (int? id, string body)

Change status of a specified voucher

Change the status of the specified voucher

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherChangeStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher of which you want to change the status
            var body = body_example;  // string | To change the status of your voucher, simply enter desired values after parameter= and remove the quotation marks. (optional) 

            try
            {
                // Change status of a specified voucher
                apiInstance.VoucherChangeStatus(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherChangeStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher of which you want to change the status | 
 **body** | **string**| To change the status of your voucher, simply enter desired values after parameter&#x3D; and remove the quotation marks. | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voucherdeletedocument"></a>
# **VoucherDeleteDocument**
> void VoucherDeleteDocument (int? id)

Delete the document of an existing voucher

Calls the deleteDocument() function in Voucher.php to delete the document of an existing voucher

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherDeleteDocumentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher of which you want to delete the document

            try
            {
                // Delete the document of an existing voucher
                apiInstance.VoucherDeleteDocument(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherDeleteDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher of which you want to delete the document | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voucherextractthumb"></a>
# **VoucherExtractThumb**
> void VoucherExtractThumb (string fileName)

Extract file thumb

Calls extractThumb() in Voucher/Factory.php to extract the thumb of the specified file

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherExtractThumbExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var fileName = fileName_example;  // string | Name of the file of which you want to extract the thumb (optional)  (default to )

            try
            {
                // Extract file thumb
                apiInstance.VoucherExtractThumb(fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherExtractThumb: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Name of the file of which you want to extract the thumb | [optional] [default to ]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="vouchergetaccountingtypes"></a>
# **VoucherGetAccountingTypes**
> ModelAccountingType VoucherGetAccountingTypes (int? id, List<string> embed)

Get the accounting types of a specified voucher

Calls getAccountingTypes() in Voucher.php to get the accounting types of the specified voucher

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherGetAccountingTypesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher of which you want to get the accounting types
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get the accounting types of a specified voucher
                ModelAccountingType result = apiInstance.VoucherGetAccountingTypes(id, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherGetAccountingTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher of which you want to get the accounting types | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelAccountingType**](ModelAccountingType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="vouchergetcheckaccounttransactionlogs"></a>
# **VoucherGetCheckAccountTransactionLogs**
> void VoucherGetCheckAccountTransactionLogs (int? id, List<string> embed)

Get the check account transaction logs of a specified voucher

Calls getCheckAccountTransactionLogs() in Voucher.php to get the check account transaction logs of the specified voucher

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherGetCheckAccountTransactionLogsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher of which you want to get the check account transaction logs
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get the check account transaction logs of a specified voucher
                apiInstance.VoucherGetCheckAccountTransactionLogs(id, embed);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherGetCheckAccountTransactionLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher of which you want to get the check account transaction logs | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="vouchergetcheckaccounttransactions"></a>
# **VoucherGetCheckAccountTransactions**
> void VoucherGetCheckAccountTransactions (int? id, List<string> embed)

Get the check account transactions of a specified voucher

Calls getCheckAccountTransactions() in Voucher.php to get the check account transactions of the specified voucher

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherGetCheckAccountTransactionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher of which you want to get the check account transactions
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get the check account transactions of a specified voucher
                apiInstance.VoucherGetCheckAccountTransactions(id, embed);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherGetCheckAccountTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher of which you want to get the check account transactions | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="vouchergetcurrency"></a>
# **VoucherGetCurrency**
> void VoucherGetCurrency (int? id)

Get the currency of a specified voucher

Calls getCurrency() in Voucher.php to get the currency of the specified voucher

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherGetCurrencyExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher of which you want to get the currency

            try
            {
                // Get the currency of a specified voucher
                apiInstance.VoucherGetCurrency(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherGetCurrency: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher of which you want to get the currency | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="vouchergetdebit"></a>
# **VoucherGetDebit**
> void VoucherGetDebit (int? id)

Get unpaid amount of a specified voucher

Calls getDebit() in Voucher.php to get the unpaid amount of a specified voucher

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherGetDebitExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher of which you want to get the unpaid amount

            try
            {
                // Get unpaid amount of a specified voucher
                apiInstance.VoucherGetDebit(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherGetDebit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher of which you want to get the unpaid amount | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="vouchergetdelinquent"></a>
# **VoucherGetDelinquent**
> void VoucherGetDelinquent (int? id)

Return if the voucher is delinquent

Calls getDelinquent() in Voucher.php to get if the voucher is delinquent

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherGetDelinquentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher of which you want to know if it is delinquent

            try
            {
                // Return if the voucher is delinquent
                apiInstance.VoucherGetDelinquent(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherGetDelinquent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher of which you want to know if it is delinquent | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="vouchergetdependingrecurringvouchers"></a>
# **VoucherGetDependingRecurringVouchers**
> ModelVoucher VoucherGetDependingRecurringVouchers (int? id, List<string> embed)

Get the depending recurring vouchers of a specified origin voucher

Calls getDependingRecurringVouchers() in Voucher.php to get the depending recurring vouchers of the specified origin voucher

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherGetDependingRecurringVouchersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher of which you want to get the depending recurring vouchers
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get the depending recurring vouchers of a specified origin voucher
                ModelVoucher result = apiInstance.VoucherGetDependingRecurringVouchers(id, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherGetDependingRecurringVouchers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher of which you want to get the depending recurring vouchers | 
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelVoucher**](ModelVoucher.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="vouchergetdocumentimage"></a>
# **VoucherGetDocumentImage**
> void VoucherGetDocumentImage (int? id)

Returns the base64 encoded preview content of the vouchers document

Calls getDocumentImage() in Voucher.php to return the base64 encoded preview content of the vouchers document

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherGetDocumentImageExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher of which you want to get the document image

            try
            {
                // Returns the base64 encoded preview content of the vouchers document
                apiInstance.VoucherGetDocumentImage(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherGetDocumentImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher of which you want to get the document image | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="vouchergettaxgroups"></a>
# **VoucherGetTaxGroups**
> void VoucherGetTaxGroups (int? id, bool? showTotalSum, bool? withCorrections)

Get an overview of all vouchers

Calls Voucher.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherGetTaxGroupsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher you want to update
            var showTotalSum = true;  // bool? | Define if you want to have the total sum of each tax group (default to false)
            var withCorrections = true;  // bool? | Define if you want to have the total sum with corrections (default to false)

            try
            {
                // Get an overview of all vouchers
                apiInstance.VoucherGetTaxGroups(id, showTotalSum, withCorrections);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherGetTaxGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher you want to update | 
 **showTotalSum** | **bool?**| Define if you want to have the total sum of each tax group | [default to false]
 **withCorrections** | **bool?**| Define if you want to have the total sum with corrections | [default to false]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="vouchermarkasopen"></a>
# **VoucherMarkAsOpen**
> ModelVoucher VoucherMarkAsOpen (int? id)

Mark a specified voucher as open

Mark the specified voucher as open

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherMarkAsOpenExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher you want to mark as open

            try
            {
                // Mark a specified voucher as open
                ModelVoucher result = apiInstance.VoucherMarkAsOpen(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherMarkAsOpen: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher you want to mark as open | 

### Return type

[**ModelVoucher**](ModelVoucher.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="vouchermarkaspaid"></a>
# **VoucherMarkAsPaid**
> ModelVoucher VoucherMarkAsPaid (int? id, string body)

Mark a specified voucher as paid

Mark the specified voucher as paid

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherMarkAsPaidExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher you want to mark as paid
            var body = body_example;  // string | Enter the date the voucher was paid here, using the format DD.MM.YYYY! (optional) 

            try
            {
                // Mark a specified voucher as paid
                ModelVoucher result = apiInstance.VoucherMarkAsPaid(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherMarkAsPaid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher you want to mark as paid | 
 **body** | **string**| Enter the date the voucher was paid here, using the format DD.MM.YYYY! | [optional] 

### Return type

[**ModelVoucher**](ModelVoucher.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voucherrefundamount"></a>
# **VoucherRefundAmount**
> ModelVoucherLog VoucherRefundAmount (int? id, string body)

Refund an amount for a specified voucher

Refund an amount for the specified voucher

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherRefundAmountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var id = 56;  // int? | Id of the voucher for which you want to refund an amount
            var body = body_example;  // string | Enter the amount which should be refunded, the date of the refund (format DD.MM.YYYY) and if it should appear in the feed an remove the quotation marks! (optional) 

            try
            {
                // Refund an amount for a specified voucher
                ModelVoucherLog result = apiInstance.VoucherRefundAmount(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherRefundAmount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the voucher for which you want to refund an amount | 
 **body** | **string**| Enter the amount which should be refunded, the date of the refund (format DD.MM.YYYY) and if it should appear in the feed an remove the quotation marks! | [optional] 

### Return type

[**ModelVoucherLog**](ModelVoucherLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voucheruploadtempfile"></a>
# **VoucherUploadTempFile**
> ModelVoucherFactory VoucherUploadTempFile (System.IO.Stream file)

Upload a temporary file to be used later

With the new version of sevdesk some models are not created by calling the Model.php directly but by calling the Factory.php because of better performance and flexibility.    Basically the model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new voucher it wont be saved by a POST request with '/Voucher?para1=&...' but with the saveVoucher function in Factory.php 'Voucher/Factory/saveVoucher?para1='

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class VoucherUploadTempFileExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new VoucherApi();
            var file = new System.IO.Stream(); // System.IO.Stream | file to upload

            try
            {
                // Upload a temporary file to be used later
                ModelVoucherFactory result = apiInstance.VoucherUploadTempFile(file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherUploadTempFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| file to upload | 

### Return type

[**ModelVoucherFactory**](ModelVoucherFactory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

