# SevDeskApi.Api.StaticReferralProgramApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStaticReferralPrograms**](StaticReferralProgramApi.md#getstaticreferralprograms) | **GET** /StaticReferralProgram | Get staticReferralProgram list


<a name="getstaticreferralprograms"></a>
# **GetStaticReferralPrograms**
> ModelStaticReferralProgram GetStaticReferralPrograms ()

Get staticReferralProgram list

Calls StaticReferralProgram.php to return the staticReferralProgram list which is basically the list of referral programs.

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class GetStaticReferralProgramsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new StaticReferralProgramApi();

            try
            {
                // Get staticReferralProgram list
                ModelStaticReferralProgram result = apiInstance.GetStaticReferralPrograms();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaticReferralProgramApi.GetStaticReferralPrograms: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ModelStaticReferralProgram**](ModelStaticReferralProgram.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

