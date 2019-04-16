# SevDeskApi.Model.ModelEmail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Create** | **DateTime?** | creation date of the Email | [optional] 
**Update** | **DateTime?** | date the email was last updated | [optional] 
**Object** | [**ModelInvoice**](ModelInvoice.md) | invoice object which is send via email | [optional] 
**From** | **string** | sender of the email | [optional] 
**To** | **string** | recipient of the email | [optional] 
**Subject** | **string** | subject of the email | [optional] 
**Text** | **string** | text written in the email | [optional] 
**SevClient** | **Object** | sevClient is the unique id every customer has and is used in nearly all operations | [optional] 
**Cc** | **string** | cc of the email | [optional] 
**Bcc** | **string** | bcc of the email | [optional] 
**Arrived** | **DateTime?** | arrival date of the email | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

