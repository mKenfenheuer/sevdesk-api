# SevDeskApi.Model.ModelPart
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Create** | **DateTime?** | date the part was created | [optional] 
**Update** | **DateTime?** | date the part was last updated | [optional] 
**Name** | **string** | name of the part | [optional] 
**PartNumber** | **string** |  | [optional] 
**Text** | **string** |  | [optional] 
**Category** | [**ModelCategory**](ModelCategory.md) |  | [optional] 
**Stock** | **float?** |  | [optional] 
**Unity** | [**ModelUnity**](ModelUnity.md) | unity of the part, references Unity.php | [optional] 
**PricePartner** | **float?** | price for a partner. Can be added via the options in the inventory where the part is displayed | [optional] 
**PriceCustomer** | **float?** | price for a customer. Can be added via the options in the inventory where the part is displayed | [optional] 
**Price** | **float?** | price of the part | [optional] 
**SecondUnity** | [**ModelUnity**](ModelUnity.md) | a second unity which can be added to the part | [optional] 
**SecondUnityFactor** | **float?** | factor for the second unity resulting in a new sumNet for the secondUnity | [optional] 
**SevClient** | **Object** | sevClient is the unique id every customer has and is used in nearly all operations | [optional] 
**PricePurchase** | **float?** |  | [optional] 
**TaxRate** | **float?** |  | [optional] 
**Image** | **string** |  | [optional] 
**Status** | **int?** |  | [optional] 
**Characteristics** | **string** | characteristics of the part | [optional] 
**Origin** | [**ModelPart**](ModelPart.md) |  | [optional] 
**CharacteristicsString** | **string** |  | [optional] 
**InternalComment** | **string** |  | [optional] 
**EntryType** | [**ModelEntryType**](ModelEntryType.md) |  | [optional] 
**AccountingType** | [**ModelAccountingType**](ModelAccountingType.md) |  | [optional] 
**PriceNet** | **float?** |  | [optional] 
**PriceGross** | **float?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

