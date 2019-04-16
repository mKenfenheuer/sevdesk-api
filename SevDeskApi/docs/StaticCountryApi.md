# SevDeskApi.Api.StaticCountryApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStaticCountry**](StaticCountryApi.md#getstaticcountry) | **GET** /StaticCountry | Get staticCountry list
[**GetStaticIndustry**](StaticCountryApi.md#getstaticindustry) | **GET** /StaticIndustry | Get staticIndustry list


<a name="getstaticcountry"></a>
# **GetStaticCountry**
> void GetStaticCountry ()

Get staticCountry list

Calls StaticCountry.php to return the staticCountry list which is basically the list of countries.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetStaticCountryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new StaticCountryApi();

            try
            {
                // Get staticCountry list
                apiInstance.GetStaticCountry();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaticCountryApi.GetStaticCountry: " + e.Message );
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

<a name="getstaticindustry"></a>
# **GetStaticIndustry**
> void GetStaticIndustry ()

Get staticIndustry list

Calls StaticIndustry.php to return the staticIndustry list which is basically the list of industries.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetStaticIndustryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new StaticCountryApi();

            try
            {
                // Get staticIndustry list
                apiInstance.GetStaticIndustry();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaticCountryApi.GetStaticIndustry: " + e.Message );
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

