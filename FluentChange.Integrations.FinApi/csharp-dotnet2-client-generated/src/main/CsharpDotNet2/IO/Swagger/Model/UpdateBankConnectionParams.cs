using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for bank connection update parameters
  /// </summary>
  [DataContract]
  public class UpdateBankConnectionParams {
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
    /// Set of login credentials. Must be passed in combination with the 'interface' field, if the credentials have not been previously stored. The labels that you pass must match with the login credential labels that the respective interface defines. finAPI will combine the given credentials with any credentials that it has stored. You can leave this field unset in case finAPI has stored all required credentials. When you must use a web form, you can also leave this field unset and the web form will take care of getting the credentials from the user. However, if you do pass credentials in that case, the web form will show only those fields that you have given.
    /// </summary>
    /// <value>Set of login credentials. Must be passed in combination with the 'interface' field, if the credentials have not been previously stored. The labels that you pass must match with the login credential labels that the respective interface defines. finAPI will combine the given credentials with any credentials that it has stored. You can leave this field unset in case finAPI has stored all required credentials. When you must use a web form, you can also leave this field unset and the web form will take care of getting the credentials from the user. However, if you do pass credentials in that case, the web form will show only those fields that you have given.</value>
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
    /// Whether new accounts that have not yet been imported will be imported or not. Default is false. <br/><br/>NOTES:<br/>&bull; For best performance of the bank connection update, you should not enable this flag unless you really expect new accounts to be available in the connection. It is recommended to let your users tell you through your application when they want the service to look for new accounts.<br/>&bull; If you have imported a bank connection using specific <code>accountTypeIds</code> (e.g. <code>1,2</code> to import checking and saving accounts), you would import all other accounts (e.g. security accounts or credit cards) by setting <code>importNewAccounts</code> to <code>true</code>. To avoid importing account types that you are not interested in, make sure this field is undefined or set to false.
    /// </summary>
    /// <value>Whether new accounts that have not yet been imported will be imported or not. Default is false. <br/><br/>NOTES:<br/>&bull; For best performance of the bank connection update, you should not enable this flag unless you really expect new accounts to be available in the connection. It is recommended to let your users tell you through your application when they want the service to look for new accounts.<br/>&bull; If you have imported a bank connection using specific <code>accountTypeIds</code> (e.g. <code>1,2</code> to import checking and saving accounts), you would import all other accounts (e.g. security accounts or credit cards) by setting <code>importNewAccounts</code> to <code>true</code>. To avoid importing account types that you are not interested in, make sure this field is undefined or set to false.</value>
    [DataMember(Name="importNewAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "importNewAccounts")]
    public bool? ImportNewAccounts { get; set; }

    /// <summary>
    /// Whether to skip the download of transactions and securities or not. If set to true, then finAPI will download just the accounts list with the accounts' information (like account name, number, holder, etc), as well as the accounts' balances (if possible), but skip the download of transactions and securities. Default is false.<br/><br/>NOTES:<br/>&bull; If you skip the download of transactions and securities during an import or update, you can still download them on a later update (though you might not get all positions at a later point, because the date range in which the bank servers provide this data is usually limited). However, once finAPI has downloaded the transactions or securities for the first time, you will not be able to go back to skipping the download of transactions and securities! In other words: Once you make your first request with <code>skipPositionsDownload=false</code> for a certain bank connection, you will no longer be able to make a request with <code>skipPositionsDownload=true</code> for that same bank connection.<br/>&bull; If this bank connection is updated via finAPI's automatic batch update, then transactions and security positions <u>will</u> be downloaded in any case!<br/>&bull; For security accounts, skipping the downloading of the securities might result in the account's balance also not being downloaded.<br/>
    /// </summary>
    /// <value>Whether to skip the download of transactions and securities or not. If set to true, then finAPI will download just the accounts list with the accounts' information (like account name, number, holder, etc), as well as the accounts' balances (if possible), but skip the download of transactions and securities. Default is false.<br/><br/>NOTES:<br/>&bull; If you skip the download of transactions and securities during an import or update, you can still download them on a later update (though you might not get all positions at a later point, because the date range in which the bank servers provide this data is usually limited). However, once finAPI has downloaded the transactions or securities for the first time, you will not be able to go back to skipping the download of transactions and securities! In other words: Once you make your first request with <code>skipPositionsDownload=false</code> for a certain bank connection, you will no longer be able to make a request with <code>skipPositionsDownload=true</code> for that same bank connection.<br/>&bull; If this bank connection is updated via finAPI's automatic batch update, then transactions and security positions <u>will</u> be downloaded in any case!<br/>&bull; For security accounts, skipping the downloading of the securities might result in the account's balance also not being downloaded.<br/></value>
    [DataMember(Name="skipPositionsDownload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skipPositionsDownload")]
    public bool? SkipPositionsDownload { get; set; }

    /// <summary>
    /// Whether to load/refresh information about the bank connection owner(s) - see field 'owners'. Default value is 'false'. Note that owner data is NOT loaded/refreshed during finAPI's automatic bank connection update.
    /// </summary>
    /// <value>Whether to load/refresh information about the bank connection owner(s) - see field 'owners'. Default value is 'false'. Note that owner data is NOT loaded/refreshed during finAPI's automatic bank connection update.</value>
    [DataMember(Name="loadOwnerData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loadOwnerData")]
    public bool? LoadOwnerData { get; set; }

    /// <summary>
    /// List of accounts for which access is requested from the bank. It may only be passed if the bank interface has the DETAILED_CONSENT property set. if omitted, finAPI will use the list of existing accounts. Note that the parameter is still required if you want to import new accounts (i.e. call with importNewAccounts=true).
    /// </summary>
    /// <value>List of accounts for which access is requested from the bank. It may only be passed if the bank interface has the DETAILED_CONSENT property set. if omitted, finAPI will use the list of existing accounts. Note that the parameter is still required if you want to import new accounts (i.e. call with importNewAccounts=true).</value>
    [DataMember(Name="accountReferences", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountReferences")]
    public List<AccountReference> AccountReferences { get; set; }

    /// <summary>
    /// Container for multi-step authentication data. Required when a previous service call initiated a multi-step authentication.
    /// </summary>
    /// <value>Container for multi-step authentication data. Required when a previous service call initiated a multi-step authentication.</value>
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
    /// If the user has stored credentials in finAPI for the selected bank connection, then the finAPI web form will only be shown when the user must be involved for a second authentication, or when the previous connection to the bank via the selected interface had failed. However if you want to provide the web form to the user in any case, you can set this field to true. It will force the web form flow for the user and allow him to make changes to the data that he has stored in finAPI.
    /// </summary>
    /// <value>If the user has stored credentials in finAPI for the selected bank connection, then the finAPI web form will only be shown when the user must be involved for a second authentication, or when the previous connection to the bank via the selected interface had failed. However if you want to provide the web form to the user in any case, you can set this field to true. It will force the web form flow for the user and allow him to make changes to the data that he has stored in finAPI.</value>
    [DataMember(Name="forceWebForm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forceWebForm")]
    public bool? ForceWebForm { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateBankConnectionParams {\n");
      sb.Append("  BankConnectionId: ").Append(BankConnectionId).Append("\n");
      sb.Append("  Interface: ").Append(Interface).Append("\n");
      sb.Append("  LoginCredentials: ").Append(LoginCredentials).Append("\n");
      sb.Append("  StoreSecrets: ").Append(StoreSecrets).Append("\n");
      sb.Append("  ImportNewAccounts: ").Append(ImportNewAccounts).Append("\n");
      sb.Append("  SkipPositionsDownload: ").Append(SkipPositionsDownload).Append("\n");
      sb.Append("  LoadOwnerData: ").Append(LoadOwnerData).Append("\n");
      sb.Append("  AccountReferences: ").Append(AccountReferences).Append("\n");
      sb.Append("  MultiStepAuthentication: ").Append(MultiStepAuthentication).Append("\n");
      sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
      sb.Append("  ForceWebForm: ").Append(ForceWebForm).Append("\n");
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
