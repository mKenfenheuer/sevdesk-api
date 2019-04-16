# SevDeskApi.Model.ModelVoucherPos
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Create** | **DateTime?** | date the voucher positions was created | [optional] 
**Update** | **DateTime?** | date the voucher position was last updated | [optional] 
**SevClient** | **Object** | sevClient is the unique id every customer has and is used in nearly all operations | [optional] 
**Voucher** | [**ModelVoucher**](ModelVoucher.md) | voucher to which the position belongs | [optional] 
**AccountingType** | [**ModelAccountingType**](ModelAccountingType.md) |  | [optional] 
**EstimatedAccountingType** | [**ModelAccountingType**](ModelAccountingType.md) |  | [optional] 
**TaxRate** | **float?** |  | [optional] 
**Sum** | **float?** |  | [optional] 
**Net** | **bool?** |  | [optional] 
**IsAsset** | **bool?** |  | [optional] 
**SumNet** | **float?** |  | [optional] [default to 0.0F]
**SumTax** | **float?** |  | [optional] [default to 0.0F]
**SumGross** | **float?** |  | [optional] [default to 0.0F]
**SumNetAccounting** | **float?** |  | [optional] [default to 0.0F]
**SumTaxAccounting** | **float?** |  | [optional] [default to 0.0F]
**SumGrossAccounting** | **float?** |  | [optional] [default to 0.0F]
**Comment** | **string** |  | [optional] 
**IsGwg** | **bool?** |  | [optional] 
**CateringTaxRate** | **float?** |  | [optional] 
**CateringTip** | **float?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

