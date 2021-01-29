# IO.Swagger.Model.MoneyTransferOrderParams
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CounterpartName** | **string** | Name of the counterpart. Note: Neither finAPI nor the involved bank servers are guaranteed to validate the counterpart name. Even if the name does not depict the actual registered account holder of the target account, the order might still be successful. | 
**CounterpartIban** | **string** | IBAN of the counterpart&#39;s account. | 
**CounterpartBic** | **string** | BIC of the counterpart&#39;s account. Only required when there is no &#39;IBAN_ONLY&#39;-capability in the respective account/interface combination that is to be used when submitting the payment. | [optional] 
**Amount** | **decimal?** | The amount of the payment. Must be a positive decimal number with at most two decimal places. For money transfers over the XS2A interface, finAPI will interpret the amount to be in the currency of the related account. For money transfers over other interfaces (FINTS_SERVER, WEB_SCRAPER), as well as for standalone money transfers (finAPI Payment product) over all interfaces (FINTS_SERVER, WEB_SCRAPER, XS2A), finAPI will consider the amount to be in EUR. | 
**Purpose** | **string** | The purpose of the transfer transaction | [optional] 
**SepaPurposeCode** | **string** | SEPA purpose code, according to ISO 20022, external codes set.&lt;br/&gt;Please note that the SEPA purpose code may be ignored by some banks. | [optional] 
**EndToEndId** | **string** | End-To-End ID for the transfer transaction | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

