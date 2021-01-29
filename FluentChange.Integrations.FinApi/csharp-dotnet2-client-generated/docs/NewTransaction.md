# IO.Swagger.Model.NewTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal?** | Amount. Required. | 
**Purpose** | **string** | Purpose. Any symbols are allowed. Maximum length is 2000. Optional. Default value: null. | [optional] 
**Counterpart** | **string** | Counterpart. Any symbols are allowed. Maximum length is 80. Optional. Default value: null. | [optional] 
**CounterpartIban** | **string** | Counterpart IBAN. Optional. Default value: null. | [optional] 
**CounterpartBlz** | **string** | Counterpart BLZ. Optional. Default value: null. | [optional] 
**CounterpartBic** | **string** | Counterpart BIC. Optional. Default value: null. | [optional] 
**CounterpartAccountNumber** | **string** | Counterpart account number. Maximum length is 34. Optional. Default value: null. | [optional] 
**BookingDate** | **string** | Booking date in the format &#39;YYYY-MM-DD&#39;.&lt;br/&gt;&lt;br/&gt;If the date lies back more than 10 days from the booking date of the latest transaction that currently exists in the account, then this transaction will be ignored and not imported. If the date depicts a date in the future, then finAPI will deal with it the same way as it does with real transactions during a real update (see fields &#39;bankBookingDate&#39; and &#39;finapiBookingDate&#39; in the Transaction Resource for explanation).&lt;br/&gt;&lt;br/&gt;This field is optional, default value is the current date. | [optional] 
**ValueDate** | **string** | Value date in the format &#39;YYYY-MM-DD&#39;. Optional. Default value: Same as the booking date. | [optional] 
**TypeId** | **int?** | The transaction type id. It&#39;s usually a number between 1 and 999. You can look up valid transaction in the following document on page 198: &lt;a href&#x3D;&#39;https://www.hbci-zka.de/dokumente/spezifikation_deutsch/fintsv4/FinTS_4.1_Messages_Finanzdatenformate_2014-01-20-FV.pdf&#39; target&#x3D;&#39;_blank&#39;&gt;FinTS Financial TransactionServices&lt;/a&gt;.&lt;br/&gt; For numbers not listed here, the service call might fail. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

