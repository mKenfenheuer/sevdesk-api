using System;
using System.Collections.Generic;
using RestSharp;
using SevDeskApi.Client;

namespace SevDeskApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAggregatorApi
    {
        /// <summary>
        /// Calculates total sum of all asset amounts for the year of the current query Calls calcTotalDepreciation() in Aggregator.php to get total sum of all asset amounts for the year of the current query
        /// </summary>
        /// <returns></returns>
        void AggregatorCalcTotalDepreciation ();
        /// <summary>
        /// Get accounting score Calls getAccountingScore() in Aggregator.php to get your accounting score
        /// </summary>
        /// <param name="startdate">Start date for the accounting score calculation</param>
        /// <param name="enddate">End date for the accounting score calculation</param>
        /// <returns></returns>
        void AggregatorGetAccountingScore (string startdate, string enddate);
        /// <summary>
        /// Get the data which is displayed in the chart on the dashboard in the app Calls getAppRevenueChartData() in Aggregator.php to get data displayed in the revenue chart on the dashboard in the app
        /// </summary>
        /// <returns></returns>
        void AggregatorGetAppRevenueChartData ();
        /// <summary>
        /// Calculates the profit and loss over a specified period Calls getProfitAndLossCalculation() in Aggregator.php to calculate the profit and loss over a specified period.    The output of this function is divided into six groups:  * costs - all invoices/vouchers which contain a spending, again separated into direct [dc] and indirect costs [ic]  * earnings - all invoices/vouchers which contain a earning  * totalcosts  * totalearnings  * totalrevenue  * profit - the profit, difference between costs and earnings
        /// </summary>
        /// <param name="startDate">Start date of the period you want to calculate</param>
        /// <param name="endDate">End date of the period you want to calculate</param>
        /// <param name="actualTaxation">Specify if you want to calculate the net income method (true) or the profit and loss (false)</param>
        /// <returns></returns>
        void AggregatorGetProfitAndLossCalculation (string startDate, string endDate, bool? actualTaxation);
        /// <summary>
        /// Calculates tax of earnings and spending over a specified period Calls getTaxInformation() in Aggregator.php to calculate tax of earnings and spending over a specified period.    This function will return:  * earningsSum (gross earnings), earningsSumNet (net earnings)  * earningsTax - tax on earnings  * expensesSum (gross expenses), expensesSumNet (net expenses)  * expensesTax - tax on expenses  * earningsTaxGroups - list of invoices/vouchers which involved a taxation, separated into tax groups  * expensesTaxGroups - list of invoices/vouchers which involved a taxation, separated into tax groups  * remainingTaxPayable - tax which is yet to be payed
        /// </summary>
        /// <param name="type">Tax period you want to calculate with</param>
        /// <param name="year">Year of your tax calculation</param>
        /// <param name="period">Starting period (month) of your tax calculation</param>
        /// <param name="actualTaxation">Specify if you want to calculate the net income method (true) or the profit and loss (false)</param>
        /// <param name="noActualTaxationOnInputTax">Specify if you want no actual taxation on input tax</param>
        /// <returns></returns>
        void AggregatorGetTaxInformation (string type, string year, int? period, bool? actualTaxation, bool? noActualTaxationOnInputTax);
        /// <summary>
        /// Get information about the categories of all vouchers in the year of the current query Calls getVoucherCategoryInformation() in Aggregator.php to get information about the categories of all vouchers in the year of the current query
        /// </summary>
        /// <returns></returns>
        void AggregatorGetVoucherCategoryInformation ();
        /// <summary>
        /// Get voucher chart data Calls getVoucherChartData() in Aggregator.php to get voucher chart data
        /// </summary>
        /// <param name="year">Year for which you want to get the voucher chart data</param>
        /// <returns></returns>
        void AggregatorGetVoucherChartData (string year);
        /// <summary>
        /// Get the data which is displayed in the chart on the dashboard Calls getWebRevenueChartData() in Aggregator.php to get data displayed in the revenue chart on the dashboard
        /// </summary>
        /// <param name="sumGrossToggle">Specify if you want to calculate sum gross instead of net</param>
        /// <returns></returns>
        void AggregatorGetWebRevenueChartData (bool? sumGrossToggle);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AggregatorApi : IAggregatorApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatorApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AggregatorApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AggregatorApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Calculates total sum of all asset amounts for the year of the current query Calls calcTotalDepreciation() in Aggregator.php to get total sum of all asset amounts for the year of the current query
        /// </summary>
        /// <returns></returns>            
        public void AggregatorCalcTotalDepreciation ()
        {
            
    
            var path = "/Aggregator/calcTotalDepreciation";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorCalcTotalDepreciation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorCalcTotalDepreciation: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get accounting score Calls getAccountingScore() in Aggregator.php to get your accounting score
        /// </summary>
        /// <param name="startdate">Start date for the accounting score calculation</param> 
        /// <param name="enddate">End date for the accounting score calculation</param> 
        /// <returns></returns>            
        public void AggregatorGetAccountingScore (string startdate, string enddate)
        {
            
    
            var path = "/Aggregator/getAccountingScore";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (enddate != null) queryParams.Add("enddate", ApiClient.ParameterToString(enddate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorGetAccountingScore: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorGetAccountingScore: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the data which is displayed in the chart on the dashboard in the app Calls getAppRevenueChartData() in Aggregator.php to get data displayed in the revenue chart on the dashboard in the app
        /// </summary>
        /// <returns></returns>            
        public void AggregatorGetAppRevenueChartData ()
        {
            
    
            var path = "/Aggregator/getAppRevenueChartData";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorGetAppRevenueChartData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorGetAppRevenueChartData: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Calculates the profit and loss over a specified period Calls getProfitAndLossCalculation() in Aggregator.php to calculate the profit and loss over a specified period.    The output of this function is divided into six groups:  * costs - all invoices/vouchers which contain a spending, again separated into direct [dc] and indirect costs [ic]  * earnings - all invoices/vouchers which contain a earning  * totalcosts  * totalearnings  * totalrevenue  * profit - the profit, difference between costs and earnings
        /// </summary>
        /// <param name="startDate">Start date of the period you want to calculate</param> 
        /// <param name="endDate">End date of the period you want to calculate</param> 
        /// <param name="actualTaxation">Specify if you want to calculate the net income method (true) or the profit and loss (false)</param> 
        /// <returns></returns>            
        public void AggregatorGetProfitAndLossCalculation (string startDate, string endDate, bool? actualTaxation)
        {
            
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling AggregatorGetProfitAndLossCalculation");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling AggregatorGetProfitAndLossCalculation");
            
            // verify the required parameter 'actualTaxation' is set
            if (actualTaxation == null) throw new ApiException(400, "Missing required parameter 'actualTaxation' when calling AggregatorGetProfitAndLossCalculation");
            
    
            var path = "/Aggregator/getProfitAndLossCalculation";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (actualTaxation != null) queryParams.Add("actualTaxation", ApiClient.ParameterToString(actualTaxation)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorGetProfitAndLossCalculation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorGetProfitAndLossCalculation: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Calculates tax of earnings and spending over a specified period Calls getTaxInformation() in Aggregator.php to calculate tax of earnings and spending over a specified period.    This function will return:  * earningsSum (gross earnings), earningsSumNet (net earnings)  * earningsTax - tax on earnings  * expensesSum (gross expenses), expensesSumNet (net expenses)  * expensesTax - tax on expenses  * earningsTaxGroups - list of invoices/vouchers which involved a taxation, separated into tax groups  * expensesTaxGroups - list of invoices/vouchers which involved a taxation, separated into tax groups  * remainingTaxPayable - tax which is yet to be payed
        /// </summary>
        /// <param name="type">Tax period you want to calculate with</param> 
        /// <param name="year">Year of your tax calculation</param> 
        /// <param name="period">Starting period (month) of your tax calculation</param> 
        /// <param name="actualTaxation">Specify if you want to calculate the net income method (true) or the profit and loss (false)</param> 
        /// <param name="noActualTaxationOnInputTax">Specify if you want no actual taxation on input tax</param> 
        /// <returns></returns>            
        public void AggregatorGetTaxInformation (string type, string year, int? period, bool? actualTaxation, bool? noActualTaxationOnInputTax)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling AggregatorGetTaxInformation");
            
            // verify the required parameter 'year' is set
            if (year == null) throw new ApiException(400, "Missing required parameter 'year' when calling AggregatorGetTaxInformation");
            
            // verify the required parameter 'period' is set
            if (period == null) throw new ApiException(400, "Missing required parameter 'period' when calling AggregatorGetTaxInformation");
            
            // verify the required parameter 'actualTaxation' is set
            if (actualTaxation == null) throw new ApiException(400, "Missing required parameter 'actualTaxation' when calling AggregatorGetTaxInformation");
            
            // verify the required parameter 'noActualTaxationOnInputTax' is set
            if (noActualTaxationOnInputTax == null) throw new ApiException(400, "Missing required parameter 'noActualTaxationOnInputTax' when calling AggregatorGetTaxInformation");
            
    
            var path = "/Aggregator/getTaxInformation";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (year != null) queryParams.Add("year", ApiClient.ParameterToString(year)); // query parameter
 if (period != null) queryParams.Add("period", ApiClient.ParameterToString(period)); // query parameter
 if (actualTaxation != null) queryParams.Add("actualTaxation", ApiClient.ParameterToString(actualTaxation)); // query parameter
 if (noActualTaxationOnInputTax != null) queryParams.Add("noActualTaxationOnInputTax", ApiClient.ParameterToString(noActualTaxationOnInputTax)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorGetTaxInformation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorGetTaxInformation: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get information about the categories of all vouchers in the year of the current query Calls getVoucherCategoryInformation() in Aggregator.php to get information about the categories of all vouchers in the year of the current query
        /// </summary>
        /// <returns></returns>            
        public void AggregatorGetVoucherCategoryInformation ()
        {
            
    
            var path = "/Aggregator/getVoucherCategoryInformation";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorGetVoucherCategoryInformation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorGetVoucherCategoryInformation: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get voucher chart data Calls getVoucherChartData() in Aggregator.php to get voucher chart data
        /// </summary>
        /// <param name="year">Year for which you want to get the voucher chart data</param> 
        /// <returns></returns>            
        public void AggregatorGetVoucherChartData (string year)
        {
            
            // verify the required parameter 'year' is set
            if (year == null) throw new ApiException(400, "Missing required parameter 'year' when calling AggregatorGetVoucherChartData");
            
    
            var path = "/Aggregator/getVoucherChartData";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (year != null) queryParams.Add("year", ApiClient.ParameterToString(year)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorGetVoucherChartData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorGetVoucherChartData: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the data which is displayed in the chart on the dashboard Calls getWebRevenueChartData() in Aggregator.php to get data displayed in the revenue chart on the dashboard
        /// </summary>
        /// <param name="sumGrossToggle">Specify if you want to calculate sum gross instead of net</param> 
        /// <returns></returns>            
        public void AggregatorGetWebRevenueChartData (bool? sumGrossToggle)
        {
            
    
            var path = "/Aggregator/getWebRevenueChartData";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (sumGrossToggle != null) queryParams.Add("sumGrossToggle", ApiClient.ParameterToString(sumGrossToggle)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorGetWebRevenueChartData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatorGetWebRevenueChartData: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
