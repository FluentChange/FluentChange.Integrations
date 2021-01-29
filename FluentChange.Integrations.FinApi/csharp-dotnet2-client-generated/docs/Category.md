# IO.Swagger.Model.Category
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | Category identifier.&lt;br/&gt;&lt;br/&gt;NOTE: Do NOT assume that the identifiers of the global finAPI categories are the same across different finAPI environments. In fact, the identifiers may change whenever a new finAPI version is released, even within the same environment. The identifiers are meant to be used for references within the finAPI services only, but not for hard-coding them in your application. If you need to hard-code the usage of a certain global category within your application, please instead refer to the category name. Also, please make sure to check the &#39;isCustom&#39; flag, which is false for all global categories (if you are not regarding this flag, you might end up referring to a user-specific category, and not the global category). | 
**Name** | **string** | Category name | 
**ParentId** | **long?** | Identifier of the parent category (if a parent category exists) | [optional] 
**ParentName** | **string** | Name of the parent category (if a parent category exists) | [optional] 
**IsCustom** | **bool?** | Whether the category is a finAPI global category (in which case this field will be false), or the category was created by a user (in which case this field will be true) | 
**Children** | **List&lt;long?&gt;** | List of sub-categories identifiers (if any exist) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

