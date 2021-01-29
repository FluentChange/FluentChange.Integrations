# IO.Swagger.Model.CreateMoneyTransferParams
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **long?** | Identifier of the account that should be used for the money transfer. If you want to do a standalone money transfer (finAPI Payment product, i.e. for an account that is not imported in finAPI) leave this field unset and instead use the field &#39;iban&#39;. | [optional] 
**Iban** | **string** | IBAN of the account that should be used for the money transfer. Use this field only if you want to do a standalone money transfer (finAPI Payment product, i.e. for an account that is not imported in finAPI) otherwise, use the &#39;accountId&#39; field and leave this field unset. | [optional] 
**MoneyTransfers** | [**List&lt;MoneyTransferOrderParams&gt;**](MoneyTransferOrderParams.md) | List of money transfer orders (may contain at most 15000 items). Please note that collective money transfer may not always be supported. | 
**ExecutionDate** | **string** | Execution date for the money transfer(s), in the format &#39;YYYY-MM-DD&#39;. May not be in the past. If not specified, then the current date will be used. | [optional] 
**SingleBooking** | **bool?** | This field is only relevant when you pass multiple orders. It determines whether the orders should be processed by the bank as one collective booking (in case of &#39;false&#39;), or as single bookings (in case of &#39;true&#39;). Note that it is subject to the bank whether it will regard the field. Default value is &#39;false&#39;. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

