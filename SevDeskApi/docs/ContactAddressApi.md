# SevDeskApi.Api.ContactAddressApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddContactAddress**](ContactAddressApi.md#addcontactaddress) | **POST** /ContactAddress | Create a new contact address
[**DeleteContactAddress**](ContactAddressApi.md#deletecontactaddress) | **DELETE** /ContactAddress/{id} | Delete an existing contact address
[**GetContactAddresses**](ContactAddressApi.md#getcontactaddresses) | **GET** /ContactAddress | Get an overview of all contact addresses
[**UpdateContactAddress**](ContactAddressApi.md#updatecontactaddress) | **PUT** /ContactAddress/{id} | Update an existing contact address


<a name="addcontactaddress"></a>
# **AddContactAddress**
> ModelContactAddress AddContactAddress (string body)

Create a new contact address

Calls ContactAddress.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AddContactAddressExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactAddressApi();
            var body = "contact[id]=&contact[objectName]=Contact&country[id]=&country[objectName]=StaticCountry&street=&zip=&city=";  // string | To create a contact address, simply enter desired values after parameter= and remove the quotation marks

            try
            {
                // Create a new contact address
                ModelContactAddress result = apiInstance.AddContactAddress(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactAddressApi.AddContactAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| To create a contact address, simply enter desired values after parameter&#x3D; and remove the quotation marks | 

### Return type

[**ModelContactAddress**](ModelContactAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontactaddress"></a>
# **DeleteContactAddress**
> void DeleteContactAddress (int? id)

Delete an existing contact address

Calls the delete() function in ContactAddress.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class DeleteContactAddressExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactAddressApi();
            var id = 56;  // int? | id of contact address you want to delete

            try
            {
                // Delete an existing contact address
                apiInstance.DeleteContactAddress(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactAddressApi.DeleteContactAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of contact address you want to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactaddresses"></a>
# **GetContactAddresses**
> ModelContactAddress GetContactAddresses (int? limit, int? offset, List<string> embed)

Get an overview of all contact addresses

Calls ContactAddress.php to get necessary variables

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetContactAddressesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactAddressApi();
            var limit = 56;  // int? | Limits the number of entries returned. Default is 100 (optional)  (default to 100)
            var offset = 56;  // int? | Set the index where the returned contacts start. Default is 0 (optional)  (default to 0)
            var embed = new List<string>(); // List<string> | Get some additional information. Embed can handle multiple values, they must be separated by comma. Default ``. (optional) 

            try
            {
                // Get an overview of all contact addresses
                ModelContactAddress result = apiInstance.GetContactAddresses(limit, offset, embed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactAddressApi.GetContactAddresses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of entries returned. Default is 100 | [optional] [default to 100]
 **offset** | **int?**| Set the index where the returned contacts start. Default is 0 | [optional] [default to 0]
 **embed** | [**List<string>**](string.md)| Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;. | [optional] 

### Return type

[**ModelContactAddress**](ModelContactAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecontactaddress"></a>
# **UpdateContactAddress**
> ModelContactAddress UpdateContactAddress (int? id, string body)

Update an existing contact address

Calls ContactAddress.php

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class UpdateContactAddressExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new ContactAddressApi();
            var id = 56;  // int? | id of contact address you want to update
            var body = body_example;  // string | Parameters which need to be updated. Please refer to the description from create contact address.    Enter the parameters according to the syntax: parameter1=&parameter2= (optional) 

            try
            {
                // Update an existing contact address
                ModelContactAddress result = apiInstance.UpdateContactAddress(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactAddressApi.UpdateContactAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of contact address you want to update | 
 **body** | **string**| Parameters which need to be updated. Please refer to the description from create contact address.    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D; | [optional] 

### Return type

[**ModelContactAddress**](ModelContactAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

