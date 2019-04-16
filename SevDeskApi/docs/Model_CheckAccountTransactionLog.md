# SevDeskApi.Model.ModelCheckAccountTransactionLog
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Create** | **DateTime?** | date the check account transaction log was created | [optional] 
**CheckAccountTransaction** | [**ModelCheckAccountTransaction**](ModelCheckAccountTransaction.md) | the check account transaction to which the log refers | [optional] 
**FromStatus** | **int?** | the status before the logged change | [optional] 
**ToStatus** | **int?** | the status after the logged change | [optional] 
**AmountPaid** | **float?** | the logged amount which was paid | [optional] 
**BookingDate** | **DateTime?** |  | [optional] 
**SevClient** | **Object** | sevClient is the unique id every customer has and is used in nearly all operations | [optional] 
**Object** | **Object** | Invoice/Voucher to which the logged transaction belongs | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

