using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for interface connection parameters
  /// </summary>
  [DataContract]
  public class ConnectInterfaceParams {
    /// <summary>
    /// Bank connection identifier
    /// </summary>
    /// <value>Bank connection identifier</value>
    [DataMember(Name="bankConnectionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankConnectionId")]
    public long? BankConnectionId { get; set; }

    /// <summary>
    /// The interface to use for connecting with the bank.
    /// </summary>
    /// <value>The interface to use for connecting with the bank.</value>
    [DataMember(Name="interface", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interface")]
    public string Interface { get; set; }

    /// <summary>
    /// The source interface that should be used as the source of credentials. Set it to one of already existing bank connection's interfaces and finAPI will try to use the stored credentials of that interface for the current service call. The source interface must fit the following requirements:<br/>- it must have the same set of bank login fields as the main interface (the 'interface' parameter);<br/>- it must have stored values for all its bank login fields.<br/>If any of those conditions are not met - the service will throw an appropriate error.<br/>Note: the source interface is ignored if any login credentials are given.
    /// </summary>
    /// <value>The source interface that should be used as the source of credentials. Set it to one of already existing bank connection's interfaces and finAPI will try to use the stored credentials of that interface for the current service call. The source interface must fit the following requirements:<br/>- it must have the same set of bank login fields as the main interface (the 'interface' parameter);<br/>- it must have stored values for all its bank login fields.<br/>If any of those conditions are not met - the service will throw an appropriate error.<br/>Note: the source interface is ignored if any login credentials are given.</value>
    [DataMember(Name="sourceInterface", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceInterface")]
    public string SourceInterface { get; set; }

    /// <summary>
    /// Set of login credentials. Must be passed in combination with the 'interface' field. For mandators requiring a web form, no matter the passed login credentials, the web form will contain all login fields defined by the bank for the respective interface.
    /// </summary>
    /// <value>Set of login credentials. Must be passed in combination with the 'interface' field. For mandators requiring a web form, no matter the passed login credentials, the web form will contain all login fields defined by the bank for the respective interface.</value>
    [DataMember(Name="loginCredentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loginCredentials")]
    public List<LoginCredential> LoginCredentials { get; set; }

    /// <summary>
    /// Whether to store the secret login fields. If the secret fields are stored, then updates can be triggered without the involvement of the users, as long as the credentials remain valid and the bank consent has not expired. Note that bank consent will be stored regardless of the field value. Default value is false.<br/><br/>NOTES:<br/> - this field is ignored in case when the user will need to use finAPI's web form. The user will be able to decide whether to store the secrets or not in the web form, depending on the 'storeSecretsAvailableInWebForm' setting (see Client Configuration).
    /// </summary>
    /// <value>Whether to store the secret login fields. If the secret fields are stored, then updates can be triggered without the involvement of the users, as long as the credentials remain valid and the bank consent has not expired. Note that bank consent will be stored regardless of the field value. Default value is false.<br/><br/>NOTES:<br/> - this field is ignored in case when the user will need to use finAPI's web form. The user will be able to decide whether to store the secrets or not in the web form, depending on the 'storeSecretsAvailableInWebForm' setting (see Client Configuration).</value>
    [DataMember(Name="storeSecrets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeSecrets")]
    public bool? StoreSecrets { get; set; }

    /// <summary>
    /// Whether to skip the download of transactions and securities or not. If set to true, then finAPI will download just the accounts list with the accounts' information (like account name, number, holder, etc), as well as the accounts' balances (if possible), but skip the download of transactions and securities. Default is false.<br/><br/>NOTES:<br/>&bull; If you skip the download of transactions and securities during an import or update, you can still download them on a later update (though you might not get all positions at a later point, because the date range in which the bank servers provide this data is usually limited). However, once finAPI has downloaded the transactions or securities for the first time, you will not be able to go back to skipping the download of transactions and securities! In other words: Once you make your first request with skipPositionsDownload=false for a certain bank connection, you will no longer be able to make a request with skipPositionsDownload=true for that same bank connection.<br/>&bull; If this bank connection is updated via finAPI's automatic batch update, then transactions and security positions <u>will</u> be downloaded in any case!<br/>&bull; For security accounts, skipping the downloading of the securities might result in the account's balance also not being downloaded.<br/>&bull; For Bausparen accounts, this field is ignored. finAPI will always download transactions for Bausparen accounts.<br/>
    /// </summary>
    /// <value>Whether to skip the download of transactions and securities or not. If set to true, then finAPI will download just the accounts list with the accounts' information (like account name, number, holder, etc), as well as the accounts' balances (if possible), but skip the download of transactions and securities. Default is false.<br/><br/>NOTES:<br/>&bull; If you skip the download of transactions and securities during an import or update, you can still download them on a later update (though you might not get all positions at a later point, because the date range in which the bank servers provide this data is usually limited). However, once finAPI has downloaded the transactions or securities for the first time, you will not be able to go back to skipping the download of transactions and securities! In other words: Once you make your first request with skipPositionsDownload=false for a certain bank connection, you will no longer be able to make a request with skipPositionsDownload=true for that same bank connection.<br/>&bull; If this bank connection is updated via finAPI's automatic batch update, then transactions and security positions <u>will</u> be downloaded in any case!<br/>&bull; For security accounts, skipping the downloading of the securities might result in the account's balance also not being downloaded.<br/>&bull; For Bausparen accounts, this field is ignored. finAPI will always download transactions for Bausparen accounts.<br/></value>
    [DataMember(Name="skipPositionsDownload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skipPositionsDownload")]
    public bool? SkipPositionsDownload { get; set; }

    /// <summary>
    /// Whether to load information about the bank connection owner(s) - see field 'owners'. Default value is 'false'.<br/><br/>NOTE: This feature is supported only by the WEB_SCRAPER interface.
    /// </summary>
    /// <value>Whether to load information about the bank connection owner(s) - see field 'owners'. Default value is 'false'.<br/><br/>NOTE: This feature is supported only by the WEB_SCRAPER interface.</value>
    [DataMember(Name="loadOwnerData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loadOwnerData")]
    public bool? LoadOwnerData { get; set; }

    /// <summary>
    /// List of accounts for which access is requested from the bank. It must only be passed if the bank interface has the DETAILED_CONSENT property set.
    /// </summary>
    /// <value>List of accounts for which access is requested from the bank. It must only be passed if the bank interface has the DETAILED_CONSENT property set.</value>
    [DataMember(Name="accountReferences", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountReferences")]
    public List<AccountReference> AccountReferences { get; set; }

    /// <summary>
    /// A set of account types of finAPI account types that are considered for the import. Only accounts whose type matches with one of the given types will be imported. Note that when the bank connection does not contain any accounts of the given types, the import will fail with error code NO_ACCOUNTS_FOR_TYPE_LIST. If no values is given, then all accounts will be imported.<br/><br/><br/>Checking,<br/>Savings,<br/>CreditCard,<br/>Security,<br/>Loan,<br/>Pocket (DEPRECATED; will not be returned for any account unless this type has explicitly been set via PATCH),<br/>Membership,<br/>Bausparen<br/><br/><b>This flag is currently not guaranteed to work for all banks!</b>
    /// </summary>
    /// <value>A set of account types of finAPI account types that are considered for the import. Only accounts whose type matches with one of the given types will be imported. Note that when the bank connection does not contain any accounts of the given types, the import will fail with error code NO_ACCOUNTS_FOR_TYPE_LIST. If no values is given, then all accounts will be imported.<br/><br/><br/>Checking,<br/>Savings,<br/>CreditCard,<br/>Security,<br/>Loan,<br/>Pocket (DEPRECATED; will not be returned for any account unless this type has explicitly been set via PATCH),<br/>Membership,<br/>Bausparen<br/><br/><b>This flag is currently not guaranteed to work for all banks!</b></value>
    [DataMember(Name="accountTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountTypes")]
    public List<string> AccountTypes { get; set; }

    /// <summary>
    /// Container for multi-step authentication data
    /// </summary>
    /// <value>Container for multi-step authentication data</value>
    [DataMember(Name="multiStepAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "multiStepAuthentication")]
    public MultiStepAuthenticationCallback MultiStepAuthentication { get; set; }

    /// <summary>
    /// Must only be passed when the used interface has the property REDIRECT_APPROACH and no web form flow is used. The user will be redirected to the given URL from the bank's website after having entered his credentials.
    /// </summary>
    /// <value>Must only be passed when the used interface has the property REDIRECT_APPROACH and no web form flow is used. The user will be redirected to the given URL from the bank's website after having entered his credentials.</value>
    [DataMember(Name="redirectUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirectUrl")]
    public string RedirectUrl { get; set; }

    /// <summary>
    /// Use this parameter if you want to limit the date range for transactions download. The value depicts the number of days that finAPI will download transactions for, starting from - and including - today. For example, if you want to download only transactions from within the past 30 days (including today), then pass the value 30. The minimum allowed value is 14, the maximum value is 3650. You may also pass the value 0 though (which is also the default value when you do not specify this parameter), in which case there will be no limit to the transactions download and finAPI will try to get all transactions that it can. Please note that when you specify the parameter there is no guarantee that finAPI will actually download transactions for the entire given date range, as the bank servers may limit the date range on their own. Also note that this parameter only applies to transactions, not to security positions; finAPI will always download all positions that it can get.<br/><br/><b>Please note: If you are not limiting the maxDaysForDownload with a value smaller than 90 days, the bank is more likely to trigger a strong customer authentication request for the user.<br/>This parameter is applied for the current 'bankingInterface'.</b>
    /// </summary>
    /// <value>Use this parameter if you want to limit the date range for transactions download. The value depicts the number of days that finAPI will download transactions for, starting from - and including - today. For example, if you want to download only transactions from within the past 30 days (including today), then pass the value 30. The minimum allowed value is 14, the maximum value is 3650. You may also pass the value 0 though (which is also the default value when you do not specify this parameter), in which case there will be no limit to the transactions download and finAPI will try to get all transactions that it can. Please note that when you specify the parameter there is no guarantee that finAPI will actually download transactions for the entire given date range, as the bank servers may limit the date range on their own. Also note that this parameter only applies to transactions, not to security positions; finAPI will always download all positions that it can get.<br/><br/><b>Please note: If you are not limiting the maxDaysForDownload with a value smaller than 90 days, the bank is more likely to trigger a strong customer authentication request for the user.<br/>This parameter is applied for the current 'bankingInterface'.</b></value>
    [DataMember(Name="maxDaysForDownload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxDaysForDownload")]
    public int? MaxDaysForDownload { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConnectInterfaceParams {\n");
      sb.Append("  BankConnectionId: ").Append(BankConnectionId).Append("\n");
      sb.Append("  Interface: ").Append(Interface).Append("\n");
      sb.Append("  SourceInterface: ").Append(SourceInterface).Append("\n");
      sb.Append("  LoginCredentials: ").Append(LoginCredentials).Append("\n");
      sb.Append("  StoreSecrets: ").Append(StoreSecrets).Append("\n");
      sb.Append("  SkipPositionsDownload: ").Append(SkipPositionsDownload).Append("\n");
      sb.Append("  LoadOwnerData: ").Append(LoadOwnerData).Append("\n");
      sb.Append("  AccountReferences: ").Append(AccountReferences).Append("\n");
      sb.Append("  AccountTypes: ").Append(AccountTypes).Append("\n");
      sb.Append("  MultiStepAuthentication: ").Append(MultiStepAuthentication).Append("\n");
      sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
      sb.Append("  MaxDaysForDownload: ").Append(MaxDaysForDownload).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
