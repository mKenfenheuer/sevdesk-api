# SevDeskApi.Model.ModelOrderLog
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Create** | **DateTime?** | date the order log was created | [optional] 
**Update** | **DateTime?** | date the order was last updated | [optional] 
**Date** | **DateTime?** | date of the order log | [optional] 
**Order** | [**ModelOrder**](ModelOrder.md) | the order to which the order log refers | [optional] 
**Object** | **Object** | the object which was involved in the logged order action (eg. a created invoice) | [optional] 
**SevClient** | **Object** | sevClient is the unique id every customer has and is used in nearly all operations | [optional] 
**Currency** | **string** | currency of the logged order | [optional] 
**Amount** | **float?** | amount of the order position | [optional] 
**AmountType** | **string** | type of the order position amount, can be one from unity or custom | [optional] 
**TaxRate** | **int?** | tax rate of the order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

