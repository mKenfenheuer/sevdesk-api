# SevDeskApi.Model.ModelVoucher
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Create** | **DateTime?** | date the voucher was created | [optional] 
**Update** | **DateTime?** | date the voucher was last updated | [optional] 
**SevClient** | **Object** | sevClient is the unique id every customer has and is used in nearly all operations | [optional] 
**CreateUser** | [**ModelSevUser**](ModelSevUser.md) | sevUser who created the voucher | [optional] 
**VoucherDate** | **DateTime?** |  | [optional] 
**Supplier** | [**ModelContact**](ModelContact.md) |  | [optional] 
**SupplierName** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Document** | [**ModelDocument**](ModelDocument.md) |  | [optional] 
**ResultDisdar** | **string** |  | [optional] 
**DocumentPreview** | [**ModelDocument**](ModelDocument.md) |  | [optional] 
**PayDate** | **DateTime?** |  | [optional] 
**Status** | **int?** |  | [optional] 
**Object** | **Object** |  | [optional] 
**SumNet** | **float?** |  | [optional] [default to 0.0F]
**SumTax** | **float?** |  | [optional] [default to 0.0F]
**SumGross** | **float?** |  | [optional] [default to 0.0F]
**SumNetAccounting** | **float?** |  | [optional] [default to 0.0F]
**SumTaxAccounting** | **float?** |  | [optional] [default to 0.0F]
**SumGrossAccounting** | **float?** |  | [optional] [default to 0.0F]
**TaxType** | **string** |  | [optional] 
**CreditDebit** | **string** |  | [optional] 
**Hidden** | **bool?** |  | [optional] 
**CostCentre** | [**ModelCostCentre**](ModelCostCentre.md) |  | [optional] 
**Origin** | **Object** |  | [optional] 
**VoucherType** | **string** |  | [optional] 
**RecurringIntervall** | **int?** |  | [optional] 
**RecurringStartDate** | **DateTime?** |  | [optional] 
**RecurringNextVoucher** | **DateTime?** |  | [optional] 
**RecurringLastVoucher** | **DateTime?** |  | [optional] 
**RecurringEndDate** | **DateTime?** |  | [optional] 
**Enshrined** | **bool?** |  | [optional] 
**InSource** | **string** |  | [optional] 
**TaxSet** | [**ModelTaxSet**](ModelTaxSet.md) |  | [optional] 
**Iban** | **string** |  | [optional] 
**AccountingSpecialCase** | **string** |  | [optional] 
**PaymentDeadline** | **DateTime?** |  | [optional] 
**Tip** | **float?** |  | [optional] [default to 0.0F]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

