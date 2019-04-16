using System;
using System.Collections.Generic;
using RestSharp;
using SevDeskApi.Client;

namespace SevDeskApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVatReportApi
    {
        /// <summary>
        /// Get a vat report for a defined period of time Calls VatReport.php to get necessary variables.
        /// </summary>
        /// <param name="reportingYear">Year for which you want to have a vat report</param>
        /// <param name="reportingPeriodCode">Define the period for your vat report</param>
        /// <param name="noActualTaxationOnInputTax">Define if you want actual taxation on input tax</param>
        /// <returns></returns>
        void GetVatReport (int? reportingYear, string reportingPeriodCode, bool? noActualTaxationOnInputTax);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VatReportApi : IVatReportApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VatReportApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VatReportApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VatReportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VatReportApi(String basePath)
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
        /// Get a vat report for a defined period of time Calls VatReport.php to get necessary variables.
        /// </summary>
        /// <param name="reportingYear">Year for which you want to have a vat report</param> 
        /// <param name="reportingPeriodCode">Define the period for your vat report</param> 
        /// <param name="noActualTaxationOnInputTax">Define if you want actual taxation on input tax</param> 
        /// <returns></returns>            
        public void GetVatReport (int? reportingYear, string reportingPeriodCode, bool? noActualTaxationOnInputTax)
        {
            
            // verify the required parameter 'reportingYear' is set
            if (reportingYear == null) throw new ApiException(400, "Missing required parameter 'reportingYear' when calling GetVatReport");
            
            // verify the required parameter 'reportingPeriodCode' is set
            if (reportingPeriodCode == null) throw new ApiException(400, "Missing required parameter 'reportingPeriodCode' when calling GetVatReport");
            
            // verify the required parameter 'noActualTaxationOnInputTax' is set
            if (noActualTaxationOnInputTax == null) throw new ApiException(400, "Missing required parameter 'noActualTaxationOnInputTax' when calling GetVatReport");
            
    
            var path = "/VatReport";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (reportingYear != null) queryParams.Add("reportingYear", ApiClient.ParameterToString(reportingYear)); // query parameter
 if (reportingPeriodCode != null) queryParams.Add("reportingPeriodCode", ApiClient.ParameterToString(reportingPeriodCode)); // query parameter
 if (noActualTaxationOnInputTax != null) queryParams.Add("noActualTaxationOnInputTax", ApiClient.ParameterToString(noActualTaxationOnInputTax)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVatReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVatReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
