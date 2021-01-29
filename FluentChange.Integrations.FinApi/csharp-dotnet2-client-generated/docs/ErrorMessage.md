# IO.Swagger.Model.ErrorMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;ErrorDetails&gt;**](ErrorDetails.md) | List of errors | 
**Date** | **string** | Server date of when the error(s) occurred, in the format YYYY-MM-DD HH:MM:SS.SSS | 
**Endpoint** | **string** | The service endpoint that was called | 
**AuthContext** | **string** | Information about the authorization context of the service call | 
**Bank** | **string** | BLZ and name (in format \&quot;&lt;BLZ&gt; - &lt;name&gt;\&quot;) of a bank that was used for the original request | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

