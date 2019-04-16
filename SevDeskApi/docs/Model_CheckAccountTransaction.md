# SevDeskApi.Model.ModelCheckAccountTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Create** | **DateTime?** | date the check account transaction was created | [optional] 
**Update** | **DateTime?** | date the check account transaction was last updated | [optional] 
**SevClient** | **Object** | sevClient is the unique id every customer has and is used in nearly all operations | [optional] 
**ValueDate** | **DateTime?** |  | [optional] 
**EntryDate** | **DateTime?** |  | [optional] 
**Amount** | **float?** | amount of the transaction | [optional] 
**GvCode** | **string** |  | [optional] 
**EntryText** | **string** |  | [optional] 
**PrimaNotaNo** | **string** |  | [optional] 
**PaymtPurpose** | **string** |  | [optional] 
**PayeePayerBankCode** | **string** | payer bank code | [optional] 
**PayeePayerAcctNo** | **string** | payer account number | [optional] 
**PayeePayerName** | **string** | payer name | [optional] 
**CheckAccount** | [**ModelCheckAccount**](ModelCheckAccount.md) | id of the check account | [optional] 
**Status** | **int?** |  | [optional] 
**Score** | **string** |  | [optional] 
**CompareHash** | **string** | hash to be compared | [optional] 
**EntryType** | **Object** |  | [optional] 
**Enshrined** | **bool?** |  | [optional] 
**SourceTransaction** | **Object** | source check account transaction used for transfers | [optional] 
**TargetTransaction** | **Object** | destination check account transaction used for transfers | [optional] 
**ObonoReceiptUuid** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

