# IO.Swagger.Model.Account
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | Account identifier | 
**BankConnectionId** | **long?** | Identifier of the bank connection that this account belongs to | 
**AccountName** | **string** | Account name | [optional] 
**Iban** | **string** | Account&#39;s IBAN. Note that this field can change from &#39;null&#39; to a value - or vice versa - any time when the account is being updated. This is subject to changes within the bank&#39;s internal account management. | [optional] 
**AccountNumber** | **string** | (National) account number. Note that this value might change whenever the account is updated (for example, leading zeros might be added or removed). | 
**SubAccountNumber** | **string** | Account&#39;s sub-account-number. Note that this field can change from &#39;null&#39; to a value - or vice versa - any time when the account is being updated. This is subject to changes within the bank&#39;s internal account management. | [optional] 
**AccountHolderName** | **string** | Name of the account holder | [optional] 
**AccountHolderId** | **string** | Bank&#39;s internal identification of the account holder. Note that if your client has no license for processing this field, it will always be &#39;XXXXX&#39; | [optional] 
**AccountCurrency** | **string** | Account&#39;s currency | [optional] 
**AccountType** | **string** | An account type.&lt;br/&gt;&lt;br/&gt;Checking,&lt;br/&gt;Savings,&lt;br/&gt;CreditCard,&lt;br/&gt;Security,&lt;br/&gt;Loan,&lt;br/&gt;Pocket (DEPRECATED; will not be returned for any account unless this type has explicitly been set via PATCH),&lt;br/&gt;Membership,&lt;br/&gt;Bausparen&lt;br/&gt;&lt;br/&gt; | [optional] 
**Balance** | **decimal?** | Current account balance | [optional] 
**Overdraft** | **decimal?** | Current overdraft | [optional] 
**OverdraftLimit** | **decimal?** | Overdraft limit | [optional] 
**AvailableFunds** | **decimal?** | Current available funds. Note that this field is only set if finAPI can make a definite statement about the current available funds. This might not always be the case, for example if there is not enough information available about the overdraft limit and current overdraft. | [optional] 
**IsNew** | **bool?** | Indicating whether this account is &#39;new&#39; or not. Any newly imported account will have this flag initially set to true, and remain so until you set it to false (see PATCH /accounts/&lt;id&gt;). How you use this field is up to your interpretation, however it is recommended to set the flag to false for all accounts right after the initial import of the bank connection. This way, you will be able recognize accounts that get newly imported during a later update of the bank connection, by checking for any accounts with the flag set to true right after an update. | 
**Interfaces** | [**List&lt;AccountInterface&gt;**](AccountInterface.md) | Set of interfaces to which this account is connected | [optional] 
**IsSeized** | **bool?** | Whether this account is seized. Note that this information is not received from the bank, but determined by finAPI based on the available account information. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

