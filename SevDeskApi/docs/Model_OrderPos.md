# SevDeskApi.Model.ModelOrderPos
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Create** | **DateTime?** | creation date of the order position | [optional] 
**Update** | **DateTime?** | date the order position was last updated | [optional] 
**Order** | [**ModelOrder**](ModelOrder.md) | Model_Order the position belongs to | [optional] 
**Part** | [**ModelPart**](ModelPart.md) | The Model_Part which is used in Model_OrderPos | [optional] 
**Quantity** | **float?** | quantity of the Model_Part | [optional] 
**Price** | **float?** | price of the Model_Part | [optional] 
**Name** | **string** |  | [optional] 
**Priority** | **int?** |  | [optional] 
**Unity** | [**ModelUnity**](ModelUnity.md) |  | [optional] 
**SevClient** | **Object** | sevClient is the unique id every customer has and is used in nearly all operations | [optional] 
**PositionNumber** | **int?** |  | [optional] 
**Text** | **string** |  | [optional] 
**Discount** | **float?** |  | [optional] 
**Optional** | **bool?** |  | [optional] 
**OptionalChargeable** | **bool?** |  | [optional] 
**TaxRate** | **float?** |  | [optional] 
**SumNet** | **float?** |  | [optional] 
**SumGross** | **float?** |  | [optional] 
**SumDiscount** | **float?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

