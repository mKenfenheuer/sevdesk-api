# SevDeskApi.Api.AccountingContactApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountingContactIsAvailableDebitorCreditorNumber**](AccountingContactApi.md#accountingcontactisavailabledebitorcreditornumber) | **GET** /AccountingContact/isAvailableDebitorCreditorNumber | Return if a debitor / creditor number is available
[**AddAccountingContact**](AccountingContactApi.md#addaccountingcontact) | **POST** /AccountingContact | Create a new accounting contact
[**DeleteAccountingContact**](AccountingContactApi.md#deleteaccountingcontact) | **DELETE** /AccountingContact/{id} | Delete an existing accounting contact
[**GetAccountingContacts**](AccountingContactApi.md#getaccountingcontacts) | **GET** /AccountingContact | Get an overview of all accounting contacts
[**UpdateAccountingContact**](AccountingContactApi.md#updateaccountingcontact) | **PUT** /AccountingContact/{id} | Update an existing accounting contact


<a name="accountingcontactisavailabledebitorcreditornumber"></a>
# **AccountingContactIsAvailableDebitorCreditorNumber**
> void AccountingContactIsAvailableDebitorCreditorNumber (int? contactId, string contactObjectName, string debitorNumber, string creditorNumber)

Return if a debitor / creditor number is available

Calls isAvailableDebitorCreditorNumber() in AccountingContact.php to get if the debitor / creditor number is available.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AccountingContactIsAvailableDebitorCreditorNumberExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingContactApi();
            var contactId = 56;  // int? | If you want to exclude a contact from getting checked you can provide its id here (optional) 
            var contactObjectName = contactObjectName_example;  // string | Contact object name (optional)  (default to Contact)
            var debitorNumber = debitorNumber_example;  // string | debitor number of which you want to know if it is available (optional)  (default to )
            var creditorNumber = creditorNumber_example;  // string | creditor number of which you want to know if it is available (optional)  (default to )

            try
            {
                // Return if a debitor / creditor number is available
                apiInstance.AccountingContactIsAvailableDebitorCreditorNumber(contactId, contactObjectName, debitorNumber, creditorNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingContactApi.AccountingContactIsAvailableDebitorCreditorNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **int?**| If you want to exclude a contact from getting checked you can provide its id here | [optional] 
 **contactObjectName** | **string**| Contact object name | [optional] [default to Contact]
 **debitorNumber** | **string**| debitor number of which you want to know if it is available | [optional] [default to ]
 **creditorNumber** | **string**| creditor number of which you want to know if it is available | [optional] [default to ]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addaccountingcontact"></a>
# **AddAccountingContact**
> ModelAccountingContact AddAccountingContact (string body)

Create a new accounting contact

Calls AccountingContact.php 

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddAccountingContactExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingContactApi();
            var body = "contact[id]=&contact[objectName]=Contact&debitorNumber=&creditorNumber=";  // string | To create an accounting contact, simply enter desired values after parameter= and remove the quotation marks.

            try
            {
                // Create a new accounting contact
                ModelAccountingContact result = apiInstance.AddAccountingContact(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingContactApi.AddAccountingContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create an accounting contact, simply enter desired values after parameter&#x3D; and remove the quotation marks. | 

### Return type

[**ModelAccountingContact**](ModelAccountingContact.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccountingcontact"></a>
# **DeleteAccountingContact**
> void DeleteAccountingContact (int? id)

Delete an existing accounting contact

Calls the delete() function in AccountingContact.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteAccountingContactExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingContactApi();
            var id = 56;  // int? | id of accounting contact you want to delete

            try
            {
                // Delete an existing accounting contact
                apiInstance.DeleteAccountingContact(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingContactApi.DeleteAccountingContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of accounting contact you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountingcontacts"></a>
# **GetAccountingContacts**
> ModelAccountingContact GetAccountingContacts (int? limit, int? offset, List<string> embed)

Get an overview of all accounting contacts

Calls AccountingContact.php to get necessary variables.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetAccountingContactsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingContactApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned discounts start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all accounting contacts
                ModelAccountingContact result = apiInstance.GetAccountingContacts(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingContactApi.GetAccountingContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned discounts start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelAccountingContact**](ModelAccountingContact.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccountingcontact"></a>
# **UpdateAccountingContact**
> ModelAccountingContact UpdateAccountingContact (int? id, string body)

Update an existing accounting contact

Calls AccountingContact.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateAccountingContactExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AccountingContactApi();
            var id = 56;  // int? | id of accounting contact you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create accounting contact.    Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update an existing accounting contact
                ModelAccountingContact result = apiInstance.UpdateAccountingContact(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingContactApi.UpdateAccountingContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of accounting contact you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create accounting contact.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelAccountingContact**](ModelAccountingContact.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

