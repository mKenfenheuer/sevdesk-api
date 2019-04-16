# SevDeskApi.Model.ModelVatReport
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Create** | **DateTime?** | date the vat report was created | [optional] 
**Update** | **DateTime?** | date the vat report was last updated | [optional] 
**SevClient** | **Object** | sevClient is the unique id every customer has and is used in nearly all operations | [optional] 
**Country** | [**ModelStaticCountry**](ModelStaticCountry.md) | StaticCountry of the vat report | [optional] 
**ReportDate** | **DateTime?** | date of the vat report | [optional] 
**ReportingYear** | **string** | year which is reported | [optional] 
**ReportingPeriod** | **string** | period which is reported | [optional] 
**ReportingPeriodCode** | **string** |  | [optional] 
**ReportingValues** | **string** |  | [optional] 
**TestCase** | **bool?** |  | [optional] 
**ActualTaxation** | **bool?** | define if you want to report the main income method or the profit and loss | [optional] 
**Corrected** | **bool?** |  | [optional] 
**ResultFinanceAuthority** | **string** |  | [optional] 
**FinanceAuthorityTicketNumber** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

