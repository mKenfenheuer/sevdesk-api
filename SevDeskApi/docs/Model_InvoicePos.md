# SevDeskApi.Model.ModelInvoicePos
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Create** | **DateTime?** | creation date of the invoice position | [optional] 
**Update** | **DateTime?** | date the invoice position was last updated | [optional] 
**Invoice** | [**ModelInvoice**](ModelInvoice.md) | the Model_Invoice the invoice position belongs to | [optional] 
**Part** | [**ModelPart**](ModelPart.md) | the product/part which belongs to the invoice position | [optional] 
**Quantity** | **float?** | the quantity of the product/part | [optional] 
**Price** | **float?** | the price of the product/part | [optional] 
**Name** | **string** | the name of the product/part | [optional] 
**Priority** | **int?** |  | [optional] 
**Unity** | [**ModelUnity**](ModelUnity.md) |  | [optional] 
**SevClient** | **Object** | sevClient is the unique id every customer has and is used in nearly all operations | [optional] 
**PositionNumber** | **int?** |  | [optional] 
**Text** | **string** |  | [optional] 
**Discount** | **float?** | does not get filled, discount is handled in the discount_model | [optional] 
**TaxRate** | **float?** | tax rate in percent | [optional] 
**Temporary** | **bool?** |  | [optional] 
**SumNet** | **float?** |  | [optional] 
**SumGross** | **float?** |  | [optional] 
**SumDiscount** | **float?** | does not get filled, sumDiscount is handled in the discount_model | [optional] 
**SumTax** | **float?** |  | [optional] 
**SumNetAccounting** | **float?** | equals sumNet | [optional] 
**SumTaxAccounting** | **float?** | equals sumTax | [optional] 
**SumGrossAccounting** | **float?** | equals sumGross | [optional] 
**PriceNet** | **float?** | net price of the product/part (one) | [optional] 
**PriceGross** | **float?** | gross price of the product/part (one) | [optional] 
**PriceTax** | **float?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

