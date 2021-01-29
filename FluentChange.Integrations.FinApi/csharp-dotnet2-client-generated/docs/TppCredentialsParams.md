# IO.Swagger.Model.TppCredentialsParams
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TppAuthenticationGroupId** | **long?** | The TPP Authentication Group Id for which the credentials can be used | 
**Label** | **string** | Label to credentials | 
**TppClientId** | **string** | ID of the TPP accessing the ASPSP API, as provided by the ASPSP as the result of registration | [optional] 
**TppClientSecret** | **string** | Secret of the TPP accessing the ASPSP API, as provided by the ASPSP as the result of registration | [optional] 
**TppApiKey** | **string** | API Key provided by ASPSP as the result of registration | [optional] 
**TppName** | **string** | TPP name | [optional] 
**ValidFromDate** | **string** | Credentials \&quot;valid from\&quot; date in the format &#39;YYYY-MM-DD&#39;. Default is today&#39;s date | [optional] 
**ValidUntilDate** | **string** | Credentials \&quot;valid until\&quot; date in the format &#39;YYYY-MM-DD&#39;. Default is null which means \&quot;indefinite\&quot; (no limit) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

