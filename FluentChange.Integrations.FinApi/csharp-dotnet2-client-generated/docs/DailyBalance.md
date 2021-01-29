# IO.Swagger.Model.DailyBalance
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **string** | Date in the format &#39;YYYY-MM-DD HH:MM:SS.SSS&#39; (german time). | 
**Balance** | **decimal?** | Calculated balance at the end of day (aggregation of all regarded accounts). | 
**Income** | **decimal?** | The sum of income of the given day (aggregation of all regarded accounts). | 
**Spending** | **decimal?** | The sum of spending of the given day (aggregation of all regarded accounts). | 
**Transactions** | **List&lt;long?&gt;** | Identifiers of the transactions for the given day | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

