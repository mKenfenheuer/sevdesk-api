# SevDeskApi.Model.ModelTask
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Create** | **DateTime?** | the date the task was created | [optional] 
**Update** | **DateTime?** | date the task was last updated | [optional] 
**Name** | **string** |  | [optional] 
**Assigned** | [**ModelSevUser**](ModelSevUser.md) | the sevDesk user who is assigned to the task | [optional] 
**Object** | **Object** | can be a contact, invoice, etc to which the task refers to | [optional] 
**Deadline** | **DateTime?** |  | [optional] 
**Status** | **int?** |  | [optional] 
**Category** | [**ModelCategory**](ModelCategory.md) | category of the created task | [optional] 
**Done** | **DateTime?** |  | [optional] 
**CreateUser** | [**ModelSevUser**](ModelSevUser.md) | the SevUser who created the task | [optional] 
**DoneUser** | [**ModelSevUser**](ModelSevUser.md) | the SevUser who completed the task | [optional] 
**NoticeCreator** | **bool?** | notice the creator when the task is finished | [optional] 
**SevClient** | **Object** | sevClient is the unique id every customer has and is used in nearly all operations | [optional] 
**Begin** | **DateTime?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

