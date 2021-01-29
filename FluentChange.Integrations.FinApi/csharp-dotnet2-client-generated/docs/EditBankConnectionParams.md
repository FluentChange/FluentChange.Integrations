# IO.Swagger.Model.EditBankConnectionParams
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | New name for the bank connection. Maximum length is 64. If you do not want to change the current name let this field remain unset. If you want to clear the current name, set the field&#39;s value to an empty string (\&quot;\&quot;). | [optional] 
**Interface** | **string** | The interface for which you want to edit data. Must be given when you pass &#39;loginCredentials&#39; and/or a &#39;defaultTwoStepProcedureId&#39;. | [optional] 
**LoginCredentials** | [**List&lt;LoginCredential&gt;**](LoginCredential.md) | Set of login credentials that you want to edit. Must be passed in combination with the &#39;interface&#39; field. The labels that you pass must match with the login credential labels that the respective interface defines. If you want to clear the stored value for a credential, you can pass an empty string (\&quot;\&quot;) as value.In case you need to use finAPI&#39;s web form to let the user update the login credentials, send all fields the user wishes to update with a non-empty value.In case all fields contain an empty string (\&quot;\&quot;), no webform will be generated. Note that any change in the credentials will automatically remove the saved consent data associated with those credentials. | [optional] 
**DefaultTwoStepProcedureId** | **string** | NOTE: In the future, this field will work only in combination with the &#39;interface&#39; field.&lt;br/&gt;&lt;br/&gt;New default two-step-procedure. Must match the &#39;procedureId&#39; of one of the procedures that are listed in the bank connection. If you do not want to change this field let it remain unset. If you want to clear the current default two-step-procedure, set the field&#39;s value to an empty string (\&quot;\&quot;). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

