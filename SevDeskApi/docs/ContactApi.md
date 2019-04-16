# SevDeskApi.Api.ContactApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAddress**](ContactApi.md#addaddress) | **POST** /Contact/{id}/addAddress | Add an address
[**AddContact**](ContactApi.md#addcontact) | **POST** /Contact | Create a new contact of type person or company
[**AddContactCommunicationWay**](ContactApi.md#addcontactcommunicationway) | **POST** /Contact/{id}/addCommunicationWay | Create a new communication way for a contact
[**AddMobile**](ContactApi.md#addmobile) | **POST** /Contact/{id}/addMobile | Add a new mobile number
[**AddPhone**](ContactApi.md#addphone) | **POST** /Contact/{id}/addPhone | Add a new phone number
[**AddWebsite**](ContactApi.md#addwebsite) | **POST** /Contact/{id}/addWeb | Add a new website
[**ContactAddEmail**](ContactApi.md#contactaddemail) | **POST** /Contact/{id}/addEmail | Add a new email
[**ContactFactoryCreateContact**](ContactApi.md#contactfactorycreatecontact) | **POST** /Contact/Factory/create | Create a new contact of type person or company
[**ContactGetAddresses**](ContactApi.md#contactgetaddresses) | **GET** /Contact/{id}/getAddresses | Get the addresses of a specified contact
[**DeleteContact**](ContactApi.md#deletecontact) | **DELETE** /Contact/{id} | Delete an existing contact
[**GetContactBillingAddress**](ContactApi.md#getcontactbillingaddress) | **GET** /Contact/{id}/getBillingAddress | Get the billing address of a specified contact
[**GetContactBillingEmail**](ContactApi.md#getcontactbillingemail) | **GET** /Contact/{id}/getBillingEmail | Get the billing email of a specified contact
[**GetContactCommunicationWays**](ContactApi.md#getcontactcommunicationways) | **GET** /Contact/{id}/getCommunicationWays | Get the communication ways of a specified contact
[**GetContactMainAddress**](ContactApi.md#getcontactmainaddress) | **GET** /Contact/{id}/getMainAddress | Get the main address of a specified contact
[**GetContactMainEmail**](ContactApi.md#getcontactmainemail) | **GET** /Contact/{id}/getMainEmail | Get the main email of a specified contact
[**GetContactMainMobile**](ContactApi.md#getcontactmainmobile) | **GET** /Contact/{id}/getMainMobile | Get the main mobile of a specified contact
[**GetContactMainPhone**](ContactApi.md#getcontactmainphone) | **GET** /Contact/{id}/getMainPhone | Get the main phone of a specified contact
[**GetContactMainWebsite**](ContactApi.md#getcontactmainwebsite) | **GET** /Contact/{id}/getMainWebsite | Get the main website of a specified contact
[**GetContactRelatedCommunicationWays**](ContactApi.md#getcontactrelatedcommunicationways) | **GET** /Contact/{id}/getRelatedCommunicationWays | Get the related communication ways of a specified contact
[**GetContactTabsItemCount**](ContactApi.md#getcontacttabsitemcount) | **GET** /Contact/{id}/getTabsItemCount | Get number of all invoices, orders, etc. of a specified contact
[**GetContacts**](ContactApi.md#getcontacts) | **GET** /Contact | Get an overview of all contacts
[**GetNextCustomerNumber**](ContactApi.md#getnextcustomernumber) | **GET** /Contact/Factory/getNextCustomerNumber | Get the next customer number
[**UpdateContact**](ContactApi.md#updatecontact) | **PUT** /Contact/{id} | Update an existing contact


<a name="addaddress"></a>
# **AddAddress**
> ModelContactAddress AddAddress (int? id, string body)

Add an address

Adds an address to the contact by calling addAddress() in Contact.php. Address is defined in ContactAddress.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddAddressExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of contact you want to add an address to
            var body = "street=&zip=&city=&country=&category=";  // string | Change the desired values and remove the quotation marks to add an address.

            try
            {
                // Add an address
                ModelContactAddress result = apiInstance.AddAddress(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.AddAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of contact you want to add an address to | 
 **body** | **string**| Change the desired values and remove the quotation marks to add an address. | 

### Return type

[**ModelContactAddress**](ModelContactAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcontact"></a>
# **AddContact**
> ModelContact AddContact (string body)

Create a new contact of type person or company

Creating a new contact of type person/company calls a shared path with the same http-verb.  However, both types require certain parameters which will indicate that their type of contact should be created.  So, using **familyname** or **name** in front of 'category' will define if either a person or a company is created

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddContactExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var body = "category[id]=3&category[objectName]=Category";  // string | Concatenate the following attributes with '&' to the example and put **familyname=yourFamilyName&** at the beginning to define the **person** you want to add and remove the quotation marks:  * customerNumber  * gender (m,w, empty)  * academicTitle, titel  * surename, name2  * bankNumber, bankAccount, vatNumber  * defaultCashbackTime, defaultCashbackPercent, defaultTimeToPay  * description    Concatenate the following attributes with '&' to the example and put **name=yourCompanyName&** at the beginning  to define the **company** you want to add and remove the quotation marks:  * name2  * bankNumber, bankAccount, vatNumber  * defaultCashbackTime, defaultCashbackPercent, defaultTimeToPay  * description

            try
            {
                // Create a new contact of type person or company
                ModelContact result = apiInstance.AddContact(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.AddContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| Concatenate the following attributes with &#39;&amp;&#39; to the example and put **familyname&#x3D;yourFamilyName&amp;** at the beginning to define the **person** you want to add and remove the quotation marks:  * customerNumber  * gender (m,w, empty)  * academicTitle, titel  * surename, name2  * bankNumber, bankAccount, vatNumber  * defaultCashbackTime, defaultCashbackPercent, defaultTimeToPay  * description    Concatenate the following attributes with &#39;&amp;&#39; to the example and put **name&#x3D;yourCompanyName&amp;** at the beginning  to define the **company** you want to add and remove the quotation marks:  * name2  * bankNumber, bankAccount, vatNumber  * defaultCashbackTime, defaultCashbackPercent, defaultTimeToPay  * description | 

### Return type

[**ModelContact**](ModelContact.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcontactcommunicationway"></a>
# **AddContactCommunicationWay**
> ModelCommunicationWay AddContactCommunicationWay (int? id, string value, int? key, string type)

Create a new communication way for a contact

Calls addCommunicationWay() in Contact.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddContactCommunicationWayExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of contact you want to add a communication way to
            var value = value_example;  // string | Value of the communication way you want to add (default to )
            var key = 56;  // int? | Key of the communication way you want to add (default to 2)
            var type = type_example;  // string | Type of communication way you want to add (optional)  (default to WEB)

            try
            {
                // Create a new communication way for a contact
                ModelCommunicationWay result = apiInstance.AddContactCommunicationWay(id, value, key, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.AddContactCommunicationWay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of contact you want to add a communication way to | 
 **value** | **string**| Value of the communication way you want to add | [default to ]
 **key** | **int?**| Key of the communication way you want to add | [default to 2]
 **type** | **string**| Type of communication way you want to add | [optional] [default to WEB]

### Return type

[**ModelCommunicationWay**](ModelCommunicationWay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addmobile"></a>
# **AddMobile**
> void AddMobile (int? id, string body)

Add a new mobile number

Calls addMobile in Contact.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddMobileExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of contact you want to update
            var body = "key=1&value=1337";  // string | Change the desired values and remove the quotation marks to add a mobile number.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address)

            try
            {
                // Add a new mobile number
                apiInstance.AddMobile(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.AddMobile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of contact you want to update | 
 **body** | **string**| Change the desired values and remove the quotation marks to add a mobile number.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address) | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addphone"></a>
# **AddPhone**
> void AddPhone (int? id, string body)

Add a new phone number

Calls addPhone() in Contact.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddPhoneExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of contact you want to update
            var body = "key=1&value=1337";  // string | Change the desired values and remove the quotation marks to add a phone number.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address)

            try
            {
                // Add a new phone number
                apiInstance.AddPhone(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.AddPhone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of contact you want to update | 
 **body** | **string**| Change the desired values and remove the quotation marks to add a phone number.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address) | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwebsite"></a>
# **AddWebsite**
> void AddWebsite (int? id, string body)

Add a new website

Calls addWeb() in Contact.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddWebsiteExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of contact you want to update
            var body = "key=1&value=www.sevdesk.de";  // string | Change the desired values and remove the quotation marks to add a website.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address)

            try
            {
                // Add a new website
                apiInstance.AddWebsite(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.AddWebsite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of contact you want to update | 
 **body** | **string**| Change the desired values and remove the quotation marks to add a website.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address) | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactaddemail"></a>
# **ContactAddEmail**
> void ContactAddEmail (int? id, string body)

Add a new email

Calls addEmail() in Contact.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ContactAddEmailExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of contact you want to update
            var body = "key=1&value=example@example.com";  // string | Change the desired values and remove the quotation marks to add an email.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address)

            try
            {
                // Add a new email
                apiInstance.ContactAddEmail(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.ContactAddEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of contact you want to update | 
 **body** | **string**| Change the desired values and remove the quotation marks to add an email.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address) | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactfactorycreatecontact"></a>
# **ContactFactoryCreateContact**
> ModelContact ContactFactoryCreateContact (string body)

Create a new contact of type person or company

With the new version of sevdesk some models are not created by calling the model.php directly but by calling the factory.php because of better performance and flexibility.    Basically the model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new invoice it wont be saved by a POST request with '/Invoice?para1=&...' but with the saveInvoice function in Factory.php 'Voucher/Factory/saveInvoice?para1='    Creating a new contact of type person/company calls a shared path with the same http-verb.    However, both types require certain parameters which will indicate that their type of contact should be created.    So, using **familyname** or **name** in front of 'category' will define if either a person or a company is created

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ContactFactoryCreateContactExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var body = "data[category][id]=3&data[category][objectName]=Category";  // string | Concatenate the following attributes with '&' to the example and put **data[familyname]=yourFamilyName&** at the beginning to define the **person** you want to add and remove the quotation marks:  * &data[customerNumber]=  * &data[gender]= (m,w, empty)  * &data[academicTitle]=, &data[titel]=  * &data[surename]=, &data[name2]=  * &data[bankNumber]=, &data[bankAccount]=, &data[vatNumber]=  * &data[defaultCashbackTime]=, &data[defaultCashbackPercent]=, &data[defaultTimeToPay]=  * &data[description]=    Concatenate the following attributes with '&' to the example and put **data[name]=yourCompanyName&** at the beginning  to define the **company** you want to add and remove the quotation marks:  * &data[name2]=  * &data[bankNumber]=, &data[bankAccount]=, &data[vatNumber]=  * &data[defaultCashbackTime]=, &data[defaultCashbackPercent]=, &data[defaultTimeToPay]=  * &data[description]=

            try
            {
                // Create a new contact of type person or company
                ModelContact result = apiInstance.ContactFactoryCreateContact(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.ContactFactoryCreateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| Concatenate the following attributes with &#39;&amp;&#39; to the example and put **data[familyname]&#x3D;yourFamilyName&amp;** at the beginning to define the **person** you want to add and remove the quotation marks:  * &amp;data[customerNumber]&#x3D;  * &amp;data[gender]&#x3D; (m,w, empty)  * &amp;data[academicTitle]&#x3D;, &amp;data[titel]&#x3D;  * &amp;data[surename]&#x3D;, &amp;data[name2]&#x3D;  * &amp;data[bankNumber]&#x3D;, &amp;data[bankAccount]&#x3D;, &amp;data[vatNumber]&#x3D;  * &amp;data[defaultCashbackTime]&#x3D;, &amp;data[defaultCashbackPercent]&#x3D;, &amp;data[defaultTimeToPay]&#x3D;  * &amp;data[description]&#x3D;    Concatenate the following attributes with &#39;&amp;&#39; to the example and put **data[name]&#x3D;yourCompanyName&amp;** at the beginning  to define the **company** you want to add and remove the quotation marks:  * &amp;data[name2]&#x3D;  * &amp;data[bankNumber]&#x3D;, &amp;data[bankAccount]&#x3D;, &amp;data[vatNumber]&#x3D;  * &amp;data[defaultCashbackTime]&#x3D;, &amp;data[defaultCashbackPercent]&#x3D;, &amp;data[defaultTimeToPay]&#x3D;  * &amp;data[description]&#x3D; | 

### Return type

[**ModelContact**](ModelContact.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactgetaddresses"></a>
# **ContactGetAddresses**
> ModelContactAddress ContactGetAddresses (int? id, int? categoryId, string categoryObjectName)

Get the addresses of a specified contact

Calls getAddresses() in Contact.php to get the addresses of a specified contact

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class ContactGetAddressesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of the contact you want to get the addresses from
            var categoryId = 56;  // int? | Category of addresses you want to get (default to 43)
            var categoryObjectName = categoryObjectName_example;  // string |  (default to Category)

            try
            {
                // Get the addresses of a specified contact
                ModelContactAddress result = apiInstance.ContactGetAddresses(id, categoryId, categoryObjectName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.ContactGetAddresses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the contact you want to get the addresses from | 
 **categoryId** | **int?**| Category of addresses you want to get | [default to 43]
 **categoryObjectName** | **string**|  | [default to Category]

### Return type

[**ModelContactAddress**](ModelContactAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/text
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontact"></a>
# **DeleteContact**
> void DeleteContact (int? id)

Delete an existing contact

Calls the delete() function in Contact.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteContactExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | id of contact you want to delete

            try
            {
                // Delete an existing contact
                apiInstance.DeleteContact(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.DeleteContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of contact you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactbillingaddress"></a>
# **GetContactBillingAddress**
> ModelContactAddress GetContactBillingAddress (int? id)

Get the billing address of a specified contact

Calls getBillingAddress() in Contact.php to get the billing address of a specified contact

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetContactBillingAddressExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of the contact you want to get the billing address from

            try
            {
                // Get the billing address of a specified contact
                ModelContactAddress result = apiInstance.GetContactBillingAddress(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.GetContactBillingAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the contact you want to get the billing address from | 

### Return type

[**ModelContactAddress**](ModelContactAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/text
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactbillingemail"></a>
# **GetContactBillingEmail**
> ModelCommunicationWay GetContactBillingEmail (int? id)

Get the billing email of a specified contact

Calls getBillingEmail() in Contact.php to get the billing email of a specified contact

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetContactBillingEmailExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of the contact you want to get the billing email from

            try
            {
                // Get the billing email of a specified contact
                ModelCommunicationWay result = apiInstance.GetContactBillingEmail(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.GetContactBillingEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the contact you want to get the billing email from | 

### Return type

[**ModelCommunicationWay**](ModelCommunicationWay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/text
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactcommunicationways"></a>
# **GetContactCommunicationWays**
> ModelCommunicationWay GetContactCommunicationWays (int? id, string type)

Get the communication ways of a specified contact

Calls getCommunicationWays() in Contact.php to get the communication ways of a specified contact

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetContactCommunicationWaysExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of the contact you want to get the communication ways from
            var type = type_example;  // string | Type of communication ways you want to get (optional)  (default to WEB)

            try
            {
                // Get the communication ways of a specified contact
                ModelCommunicationWay result = apiInstance.GetContactCommunicationWays(id, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.GetContactCommunicationWays: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the contact you want to get the communication ways from | 
 **type** | **string**| Type of communication ways you want to get | [optional] [default to WEB]

### Return type

[**ModelCommunicationWay**](ModelCommunicationWay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/text
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactmainaddress"></a>
# **GetContactMainAddress**
> ModelContactAddress GetContactMainAddress (int? id)

Get the main address of a specified contact

Calls getMainAddress() in Contact.php to get the main address of a specified contact

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetContactMainAddressExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of the contact you want to get the main address from

            try
            {
                // Get the main address of a specified contact
                ModelContactAddress result = apiInstance.GetContactMainAddress(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.GetContactMainAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the contact you want to get the main address from | 

### Return type

[**ModelContactAddress**](ModelContactAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/text
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactmainemail"></a>
# **GetContactMainEmail**
> ModelCommunicationWay GetContactMainEmail (int? id)

Get the main email of a specified contact

Calls getMainEmail() in Contact.php to get the main email of a specified contact

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetContactMainEmailExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of the contact you want to get the main email from

            try
            {
                // Get the main email of a specified contact
                ModelCommunicationWay result = apiInstance.GetContactMainEmail(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.GetContactMainEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the contact you want to get the main email from | 

### Return type

[**ModelCommunicationWay**](ModelCommunicationWay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/text
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactmainmobile"></a>
# **GetContactMainMobile**
> ModelCommunicationWay GetContactMainMobile (int? id)

Get the main mobile of a specified contact

Calls getMainMobile() in Contact.php to get the main mobile of a specified contact

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetContactMainMobileExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of the contact you want to get the main mobile from

            try
            {
                // Get the main mobile of a specified contact
                ModelCommunicationWay result = apiInstance.GetContactMainMobile(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.GetContactMainMobile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the contact you want to get the main mobile from | 

### Return type

[**ModelCommunicationWay**](ModelCommunicationWay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/text
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactmainphone"></a>
# **GetContactMainPhone**
> ModelCommunicationWay GetContactMainPhone (int? id)

Get the main phone of a specified contact

Calls getMainPhone() in Contact.php to get the main phone of a specified contact

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetContactMainPhoneExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of the contact you want to get the main phone from

            try
            {
                // Get the main phone of a specified contact
                ModelCommunicationWay result = apiInstance.GetContactMainPhone(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.GetContactMainPhone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the contact you want to get the main phone from | 

### Return type

[**ModelCommunicationWay**](ModelCommunicationWay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/text
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactmainwebsite"></a>
# **GetContactMainWebsite**
> ModelCommunicationWay GetContactMainWebsite (int? id)

Get the main website of a specified contact

Calls getMainWebsite() in Contact.php to get the main website of a specified contact

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetContactMainWebsiteExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of the contact you want to get the main website from

            try
            {
                // Get the main website of a specified contact
                ModelCommunicationWay result = apiInstance.GetContactMainWebsite(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.GetContactMainWebsite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the contact you want to get the main website from | 

### Return type

[**ModelCommunicationWay**](ModelCommunicationWay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/text
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactrelatedcommunicationways"></a>
# **GetContactRelatedCommunicationWays**
> ModelCommunicationWay GetContactRelatedCommunicationWays (int? id, string type)

Get the related communication ways of a specified contact

Calls getRelatedCommunicationWays() in Contact.php to get the related communication ways of a specified contact

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetContactRelatedCommunicationWaysExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of the contact you want to get the related communication ways from
            var type = type_example;  // string | Type of related communication ways you want to get (optional)  (default to WEB)

            try
            {
                // Get the related communication ways of a specified contact
                ModelCommunicationWay result = apiInstance.GetContactRelatedCommunicationWays(id, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.GetContactRelatedCommunicationWays: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the contact you want to get the related communication ways from | 
 **type** | **string**| Type of related communication ways you want to get | [optional] [default to WEB]

### Return type

[**ModelCommunicationWay**](ModelCommunicationWay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/text
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontacttabsitemcount"></a>
# **GetContactTabsItemCount**
> void GetContactTabsItemCount (int? id)

Get number of all invoices, orders, etc. of a specified contact

Calls getTabsItemCount() in Contact.php to get the number of all invoices, orders, etc. of a specified contact

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetContactTabsItemCountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of the contact you want to get the number of all invoices, orders, etc. from

            try
            {
                // Get number of all invoices, orders, etc. of a specified contact
                apiInstance.GetContactTabsItemCount(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.GetContactTabsItemCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the contact you want to get the number of all invoices, orders, etc. from | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/text
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontacts"></a>
# **GetContacts**
> ModelContact GetContacts (int? depth, int? limit, int? offset, List<string> embed)

Get an overview of all contacts

Calls Contact.php to get necessary variables

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetContactsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var depth = 56;  // int? | If depth is set 1 companies and persons will be shown, otherwise only the companies will be shown. Default: 0 (optional)  (default to 0)
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned contacts start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all contacts
                ModelContact result = apiInstance.GetContacts(depth, limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.GetContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **depth** | **int?**| If depth is set 1 companies and persons will be shown, otherwise only the companies will be shown. Default: 0 | [optional] [default to 0]
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned contacts start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelContact**](ModelContact.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/text
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnextcustomernumber"></a>
# **GetNextCustomerNumber**
> void GetNextCustomerNumber ()

Get the next customer number

Get the next customer number in the sequence

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetNextCustomerNumberExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();

            try
            {
                // Get the next customer number
                apiInstance.GetNextCustomerNumber();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.GetNextCustomerNumber: " + e.Message );
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

<a name="updatecontact"></a>
# **UpdateContact**
> ModelContact UpdateContact (int? id, string body)

Update an existing contact

Calls Contact.php to update an existing contact

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateContactExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactApi();
            var id = 56;  // int? | Id of contact you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please be aware not to update any parameters which don't belong to the type of contact you are updating    Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update an existing contact
                ModelContact result = apiInstance.UpdateContact(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.UpdateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of contact you want to update | 
 **body** | **string**| Parameters which need to be updated. Please be aware not to update any parameters which don&#39;t belong to the type of contact you are updating    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelContact**](ModelContact.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

