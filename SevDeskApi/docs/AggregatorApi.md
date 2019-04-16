# SevDeskApi.Api.AggregatorApi

All URIs are relative to *https://my.sevdesk.de/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AggregatorCalcTotalDepreciation**](AggregatorApi.md#aggregatorcalctotaldepreciation) | **GET** /Aggregator/calcTotalDepreciation | Calculates total sum of all asset amounts for the year of the current query
[**AggregatorGetAccountingScore**](AggregatorApi.md#aggregatorgetaccountingscore) | **GET** /Aggregator/getAccountingScore | Get accounting score
[**AggregatorGetAppRevenueChartData**](AggregatorApi.md#aggregatorgetapprevenuechartdata) | **GET** /Aggregator/getAppRevenueChartData | Get the data which is displayed in the chart on the dashboard in the app
[**AggregatorGetProfitAndLossCalculation**](AggregatorApi.md#aggregatorgetprofitandlosscalculation) | **GET** /Aggregator/getProfitAndLossCalculation | Calculates the profit and loss over a specified period
[**AggregatorGetTaxInformation**](AggregatorApi.md#aggregatorgettaxinformation) | **GET** /Aggregator/getTaxInformation | Calculates tax of earnings and spending over a specified period
[**AggregatorGetVoucherCategoryInformation**](AggregatorApi.md#aggregatorgetvouchercategoryinformation) | **GET** /Aggregator/getVoucherCategoryInformation | Get information about the categories of all vouchers in the year of the current query
[**AggregatorGetVoucherChartData**](AggregatorApi.md#aggregatorgetvoucherchartdata) | **GET** /Aggregator/getVoucherChartData | Get voucher chart data
[**AggregatorGetWebRevenueChartData**](AggregatorApi.md#aggregatorgetwebrevenuechartdata) | **GET** /Aggregator/getWebRevenueChartData | Get the data which is displayed in the chart on the dashboard


<a name="aggregatorcalctotaldepreciation"></a>
# **AggregatorCalcTotalDepreciation**
> void AggregatorCalcTotalDepreciation ()

Calculates total sum of all asset amounts for the year of the current query

Calls calcTotalDepreciation() in Aggregator.php to get total sum of all asset amounts for the year of the current query

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AggregatorCalcTotalDepreciationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AggregatorApi();

            try
            {
                // Calculates total sum of all asset amounts for the year of the current query
                apiInstance.AggregatorCalcTotalDepreciation();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregatorApi.AggregatorCalcTotalDepreciation: " + e.Message );
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

<a name="aggregatorgetaccountingscore"></a>
# **AggregatorGetAccountingScore**
> void AggregatorGetAccountingScore (string startdate, string enddate)

Get accounting score

Calls getAccountingScore() in Aggregator.php to get your accounting score

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AggregatorGetAccountingScoreExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AggregatorApi();
            var startdate = startdate_example;  // string | Start date for the accounting score calculation (optional)  (default to )
            var enddate = enddate_example;  // string | End date for the accounting score calculation (optional)  (default to )

            try
            {
                // Get accounting score
                apiInstance.AggregatorGetAccountingScore(startdate, enddate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregatorApi.AggregatorGetAccountingScore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startdate** | **string**| Start date for the accounting score calculation | [optional] [default to ]
 **enddate** | **string**| End date for the accounting score calculation | [optional] [default to ]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aggregatorgetapprevenuechartdata"></a>
# **AggregatorGetAppRevenueChartData**
> void AggregatorGetAppRevenueChartData ()

Get the data which is displayed in the chart on the dashboard in the app

Calls getAppRevenueChartData() in Aggregator.php to get data displayed in the revenue chart on the dashboard in the app

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AggregatorGetAppRevenueChartDataExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AggregatorApi();

            try
            {
                // Get the data which is displayed in the chart on the dashboard in the app
                apiInstance.AggregatorGetAppRevenueChartData();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregatorApi.AggregatorGetAppRevenueChartData: " + e.Message );
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

<a name="aggregatorgetprofitandlosscalculation"></a>
# **AggregatorGetProfitAndLossCalculation**
> void AggregatorGetProfitAndLossCalculation (string startDate, string endDate, bool? actualTaxation)

Calculates the profit and loss over a specified period

Calls getProfitAndLossCalculation() in Aggregator.php to calculate the profit and loss over a specified period.    The output of this function is divided into six groups:  * costs - all invoices/vouchers which contain a spending, again separated into direct [dc] and indirect costs [ic]  * earnings - all invoices/vouchers which contain a earning  * totalcosts  * totalearnings  * totalrevenue  * profit - the profit, difference between costs and earnings

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AggregatorGetProfitAndLossCalculationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AggregatorApi();
            var startDate = startDate_example;  // string | Start date of the period you want to calculate (default to )
            var endDate = endDate_example;  // string | End date of the period you want to calculate (default to )
            var actualTaxation = true;  // bool? | Specify if you want to calculate the net income method (true) or the profit and loss (false) (default to false)

            try
            {
                // Calculates the profit and loss over a specified period
                apiInstance.AggregatorGetProfitAndLossCalculation(startDate, endDate, actualTaxation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregatorApi.AggregatorGetProfitAndLossCalculation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| Start date of the period you want to calculate | [default to ]
 **endDate** | **string**| End date of the period you want to calculate | [default to ]
 **actualTaxation** | **bool?**| Specify if you want to calculate the net income method (true) or the profit and loss (false) | [default to false]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aggregatorgettaxinformation"></a>
# **AggregatorGetTaxInformation**
> void AggregatorGetTaxInformation (string type, string year, int? period, bool? actualTaxation, bool? noActualTaxationOnInputTax)

Calculates tax of earnings and spending over a specified period

Calls getTaxInformation() in Aggregator.php to calculate tax of earnings and spending over a specified period.    This function will return:  * earningsSum (gross earnings), earningsSumNet (net earnings)  * earningsTax - tax on earnings  * expensesSum (gross expenses), expensesSumNet (net expenses)  * expensesTax - tax on expenses  * earningsTaxGroups - list of invoices/vouchers which involved a taxation, separated into tax groups  * expensesTaxGroups - list of invoices/vouchers which involved a taxation, separated into tax groups  * remainingTaxPayable - tax which is yet to be payed

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AggregatorGetTaxInformationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AggregatorApi();
            var type = type_example;  // string | Tax period you want to calculate with (default to monthly)
            var year = year_example;  // string | Year of your tax calculation (default to )
            var period = 56;  // int? | Starting period (month) of your tax calculation
            var actualTaxation = true;  // bool? | Specify if you want to calculate the net income method (true) or the profit and loss (false) (default to false)
            var noActualTaxationOnInputTax = true;  // bool? | Specify if you want no actual taxation on input tax (default to false)

            try
            {
                // Calculates tax of earnings and spending over a specified period
                apiInstance.AggregatorGetTaxInformation(type, year, period, actualTaxation, noActualTaxationOnInputTax);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregatorApi.AggregatorGetTaxInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Tax period you want to calculate with | [default to monthly]
 **year** | **string**| Year of your tax calculation | [default to ]
 **period** | **int?**| Starting period (month) of your tax calculation | 
 **actualTaxation** | **bool?**| Specify if you want to calculate the net income method (true) or the profit and loss (false) | [default to false]
 **noActualTaxationOnInputTax** | **bool?**| Specify if you want no actual taxation on input tax | [default to false]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aggregatorgetvouchercategoryinformation"></a>
# **AggregatorGetVoucherCategoryInformation**
> void AggregatorGetVoucherCategoryInformation ()

Get information about the categories of all vouchers in the year of the current query

Calls getVoucherCategoryInformation() in Aggregator.php to get information about the categories of all vouchers in the year of the current query

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AggregatorGetVoucherCategoryInformationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AggregatorApi();

            try
            {
                // Get information about the categories of all vouchers in the year of the current query
                apiInstance.AggregatorGetVoucherCategoryInformation();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregatorApi.AggregatorGetVoucherCategoryInformation: " + e.Message );
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

<a name="aggregatorgetvoucherchartdata"></a>
# **AggregatorGetVoucherChartData**
> void AggregatorGetVoucherChartData (string year)

Get voucher chart data

Calls getVoucherChartData() in Aggregator.php to get voucher chart data

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AggregatorGetVoucherChartDataExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AggregatorApi();
            var year = year_example;  // string | Year for which you want to get the voucher chart data (default to )

            try
            {
                // Get voucher chart data
                apiInstance.AggregatorGetVoucherChartData(year);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregatorApi.AggregatorGetVoucherChartData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **string**| Year for which you want to get the voucher chart data | [default to ]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aggregatorgetwebrevenuechartdata"></a>
# **AggregatorGetWebRevenueChartData**
> void AggregatorGetWebRevenueChartData (bool? sumGrossToggle)

Get the data which is displayed in the chart on the dashboard

Calls getWebRevenueChartData() in Aggregator.php to get data displayed in the revenue chart on the dashboard

### Example
```csharp
using System;
using System.Diagnostics;
using SevDeskApi.Api;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace Example
{
    public class AggregatorGetWebRevenueChartDataExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new AggregatorApi();
            var sumGrossToggle = true;  // bool? | Specify if you want to calculate sum gross instead of net (optional)  (default to false)

            try
            {
                // Get the data which is displayed in the chart on the dashboard
                apiInstance.AggregatorGetWebRevenueChartData(sumGrossToggle);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregatorApi.AggregatorGetWebRevenueChartData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sumGrossToggle** | **bool?**| Specify if you want to calculate sum gross instead of net | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

