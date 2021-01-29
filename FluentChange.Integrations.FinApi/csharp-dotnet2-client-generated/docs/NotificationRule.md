# IO.Swagger.Model.NotificationRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | Notification rule identifier | 
**TriggerEvent** | **string** | Trigger event type | 
**Params** | **Dictionary&lt;string, string&gt;** | Additional parameters that are specific to the trigger event type. Please refer to the documentation for details. | [optional] 
**CallbackHandle** | **string** | The string that finAPI includes into the notifications that it sends based on this rule. | [optional] 
**IncludeDetails** | **bool?** | Whether the notification messages that will be sent based on this rule contain encrypted detailed data or not | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

