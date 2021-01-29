# IO.Swagger.Model.Security
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | Identifier. Note: Whenever a security account is being updated, its security positions will be internally re-created, meaning that the identifier of a security position might change over time. | 
**AccountId** | **long?** | Security account identifier | 
**Name** | **string** | Name | [optional] 
**Isin** | **string** | ISIN | [optional] 
**Wkn** | **string** | WKN | [optional] 
**Quote** | **decimal?** | Quote | [optional] 
**QuoteCurrency** | **string** | Currency of quote | [optional] 
**QuoteType** | **string** | Type of quote. &#39;PERC&#39; if quote is a percentage value, &#39;ACTU&#39; if quote is the actual amount | [optional] 
**QuoteDate** | **string** | Quote date in the format &#39;YYYY-MM-DD HH:MM:SS.SSS&#39; (german time). | [optional] 
**QuantityNominal** | **decimal?** | Value of quantity or nominal | [optional] 
**QuantityNominalType** | **string** | Type of quantity or nominal value. &#39;UNIT&#39; if value is a quantity, &#39;FAMT&#39; if value is the nominal amount | [optional] 
**MarketValue** | **decimal?** | Market value | [optional] 
**MarketValueCurrency** | **string** | Currency of market value | [optional] 
**EntryQuote** | **decimal?** | Entry quote | [optional] 
**EntryQuoteCurrency** | **string** | Currency of entry quote | [optional] 
**ProfitOrLoss** | **decimal?** | Current profit or loss | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

