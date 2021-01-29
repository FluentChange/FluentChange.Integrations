# IO.Swagger.Model.CategorizationCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | The transaction identifier. The transactionId of the transaction that was passed to the service as input. This is not an actual ID of a stored transaction in finAPI, as the checkCategorization service doesn&#39;t store any data. | 
**Category** | [**Category**](Category.md) | A category. The determined transaction category for the given transactionId. This can be null, if the categorization algorithm fails to find a matching rule. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

