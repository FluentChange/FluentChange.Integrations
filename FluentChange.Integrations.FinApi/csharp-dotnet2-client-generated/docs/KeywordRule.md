# IO.Swagger.Model.KeywordRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | Rule identifier | 
**Category** | [**Category**](Category.md) | The category that this rule assigns to the transactions that it matches | 
**Direction** | **string** | Direction for the rule. &#39;Income&#39; means that the rule applies to transactions with a positive amount only, &#39;Spending&#39; means it applies to transactions with a negative amount only. | 
**CreationDate** | **string** | Timestamp of when the rule was created, in the format &#39;YYYY-MM-DD HH:MM:SS.SSS&#39; (german time) | 
**Keywords** | **List&lt;string&gt;** | Set of keywords that this rule defines. | 
**AllKeywordsMustMatch** | **bool?** | This field is only relevant if the rule contains multiple keywords. If set to &#39;true&#39; it means that all keywords have to be found in a transaction to apply the given category. If set to &#39;false&#39;, then even a single matching keyword in a transaction can trigger this rule. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

