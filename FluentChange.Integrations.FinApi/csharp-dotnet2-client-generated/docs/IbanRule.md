# IO.Swagger.Model.IbanRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | Rule identifier | 
**Category** | [**Category**](Category.md) | The category that this rule assigns to the transactions that it matches | 
**Direction** | **string** | Direction for the rule. &#39;Income&#39; means that the rule applies to transactions with a positive amount only, &#39;Spending&#39; means it applies to transactions with a negative amount only. | 
**CreationDate** | **string** | Timestamp of when the rule was created, in the format &#39;YYYY-MM-DD HH:MM:SS.SSS&#39; (german time) | 
**Iban** | **string** | The IBAN for this rule | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

