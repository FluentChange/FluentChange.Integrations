# IO.Swagger.Model.SubTransactionParams
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal?** | Amount | 
**CategoryId** | **long?** | Category identifier. If not specified, the original transaction&#39;s category will be applied. If you explicitly want the sub-transaction to have no category, then pass this field with value &#39;0&#39; (zero). | [optional] 
**Purpose** | **string** | Purpose. Maximum length is 2000. If not specified, the original transaction&#39;s value will be applied. | [optional] 
**Counterpart** | **string** | Counterpart. Maximum length is 80. If not specified, the original transaction&#39;s value will be applied. | [optional] 
**CounterpartAccountNumber** | **string** | Counterpart account number. If not specified, the original transaction&#39;s value will be applied. | [optional] 
**CounterpartIban** | **string** | Counterpart IBAN. If not specified, the original transaction&#39;s value will be applied. | [optional] 
**CounterpartBic** | **string** | Counterpart BIC. If not specified, the original transaction&#39;s value will be applied. | [optional] 
**CounterpartBlz** | **string** | Counterpart BLZ. If not specified, the original transaction&#39;s value will be applied. | [optional] 
**LabelIds** | **List&lt;long?&gt;** | List of connected labels. Note that when this field is not specified, then the labels of the original transaction will NOT get applied to the sub-transaction. Instead, the sub-transaction will have no labels assigned to it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

