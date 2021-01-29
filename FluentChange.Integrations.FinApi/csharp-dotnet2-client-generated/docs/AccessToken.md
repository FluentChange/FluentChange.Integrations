# IO.Swagger.Model.AccessToken
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TokenType** | **string** | Token type (it&#39;s always &#39;bearer&#39;) | 
**ExpiresIn** | **int?** | Expiration time in seconds. A value of 0 means that the token never expires (unless it is explicitly invalidated, e.g. by revocation, or when a user gets locked). | 
**Scope** | **string** | Requested scopes (it&#39;s always &#39;all&#39;) | 
**RefreshToken** | **string** | Refresh token. Only set in case of grant_type&#x3D;&#39;password&#39;. Token has a length of up to 128 characters. | [optional] 
**_AccessToken** | **string** | Access token. Token has a length of up to 128 characters. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

