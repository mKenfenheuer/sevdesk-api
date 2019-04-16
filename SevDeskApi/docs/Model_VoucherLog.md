# SevDeskApi.Model.ModelVoucherLog
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Create** | **DateTime?** | date the voucher log was created | [optional] 
**Voucher** | [**ModelVoucher**](ModelVoucher.md) | voucher to which the log belongs | [optional] 
**FromStatus** | **int?** | status of the voucher before the logged change | [optional] 
**ToStatus** | **int?** | status of the voucher after the logged change | [optional] 
**AmountPayed** | **float?** | amount which was payed | [optional] 
**BookingDate** | **DateTime?** | date of the booking | [optional] 
**SevClient** | **Object** | sevClient is the unique id every customer has and is used in nearly all operations | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

