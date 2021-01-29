using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Resource representing a bank connection interface
  /// </summary>
  [DataContract]
  public class BankConnectionInterface {
    /// <summary>
    /// Bank interface. Possible values:<br><br>&bull; <code>FINTS_SERVER</code> - means that finAPI will download data via the bank's FinTS interface.<br>&bull; <code>WEB_SCRAPER</code> - means that finAPI will parse data from the bank's online banking website.<br>&bull; <code>XS2A</code> - means that finAPI will download data via the bank's XS2A interface.<br>
    /// </summary>
    /// <value>Bank interface. Possible values:<br><br>&bull; <code>FINTS_SERVER</code> - means that finAPI will download data via the bank's FinTS interface.<br>&bull; <code>WEB_SCRAPER</code> - means that finAPI will parse data from the bank's online banking website.<br>&bull; <code>XS2A</code> - means that finAPI will download data via the bank's XS2A interface.<br></value>
    [DataMember(Name="interface", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interface")]
    public string Interface { get; set; }

    /// <summary>
    /// Login fields for this interface (in the order that we suggest to show them to the user), with their currently stored values. Note that this list always contains all existing login fields for this interface, even when there is no stored value for a field (value will be null in such a case).
    /// </summary>
    /// <value>Login fields for this interface (in the order that we suggest to show them to the user), with their currently stored values. Note that this list always contains all existing login fields for this interface, even when there is no stored value for a field (value will be null in such a case).</value>
    [DataMember(Name="loginCredentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loginCredentials")]
    public List<LoginCredentialResource> LoginCredentials { get; set; }

    /// <summary>
    /// The default two-step-procedure for this interface. Must match one of the available 'procedureId's from the 'twoStepProcedures' list. When this field is set, then finAPI will automatically try to select the procedure wherever applicable. Note that the list of available procedures of a bank connection may change as a result of an update of the connection, and if this field references a procedure that is no longer available after an update, finAPI will automatically clear the default procedure (set it to null).
    /// </summary>
    /// <value>The default two-step-procedure for this interface. Must match one of the available 'procedureId's from the 'twoStepProcedures' list. When this field is set, then finAPI will automatically try to select the procedure wherever applicable. Note that the list of available procedures of a bank connection may change as a result of an update of the connection, and if this field references a procedure that is no longer available after an update, finAPI will automatically clear the default procedure (set it to null).</value>
    [DataMember(Name="defaultTwoStepProcedureId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultTwoStepProcedureId")]
    public string DefaultTwoStepProcedureId { get; set; }

    /// <summary>
    /// Available two-step-procedures in this interface, used for submitting a money transfer or direct debit request (see /accounts/requestSepaMoneyTransfer or /requestSepaDirectDebit),or for multi-step-authentication during bank connection import or update. The available two-step-procedures mya be re-evaluated each time this bank connection is updated (/bankConnections/update). This means that this list may change as a result of an update.
    /// </summary>
    /// <value>Available two-step-procedures in this interface, used for submitting a money transfer or direct debit request (see /accounts/requestSepaMoneyTransfer or /requestSepaDirectDebit),or for multi-step-authentication during bank connection import or update. The available two-step-procedures mya be re-evaluated each time this bank connection is updated (/bankConnections/update). This means that this list may change as a result of an update.</value>
    [DataMember(Name="twoStepProcedures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "twoStepProcedures")]
    public List<TwoStepProcedure> TwoStepProcedures { get; set; }

    /// <summary>
    /// If this field is set, it means that this interface is handing out a consent to finAPI in exchange for the login credentials. finAPI needs to use this consent to get access to the account list and account data (i.e. Account Information Services, AIS). If this field is not set, it means that this interface does not use such consents.
    /// </summary>
    /// <value>If this field is set, it means that this interface is handing out a consent to finAPI in exchange for the login credentials. finAPI needs to use this consent to get access to the account list and account data (i.e. Account Information Services, AIS). If this field is not set, it means that this interface does not use such consents.</value>
    [DataMember(Name="aisConsent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aisConsent")]
    public BankConsent AisConsent { get; set; }

    /// <summary>
    /// Result of the last manual update of the associated bank connection using this interface. If no manual update has ever been done so far with this interface, then this field will not be set.
    /// </summary>
    /// <value>Result of the last manual update of the associated bank connection using this interface. If no manual update has ever been done so far with this interface, then this field will not be set.</value>
    [DataMember(Name="lastManualUpdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastManualUpdate")]
    public UpdateResult LastManualUpdate { get; set; }

    /// <summary>
    /// Result of the last auto update of the associated bank connection using this interface (ran by finAPI's automatic batch update process). If no auto update has ever been done so far with this interface, then this field will not be set.
    /// </summary>
    /// <value>Result of the last auto update of the associated bank connection using this interface (ran by finAPI's automatic batch update process). If no auto update has ever been done so far with this interface, then this field will not be set.</value>
    [DataMember(Name="lastAutoUpdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastAutoUpdate")]
    public UpdateResult LastAutoUpdate { get; set; }

    /// <summary>
    /// This field indicates whether the user's attention is required for the next update of the given bank connection interface.<br/>If the field is true, finAPI stops auto-updates of this bank connection interface to mitigate the risk of locking the user's bank account and also of triggering a multi-step authentication that might lead to a notification being sent to the end-user.<br/>Every communication with the bank (e.g. updating a bank connection, submitting a money transfer or a direct debit, etc.) can change the value of this flag. If the field is true, we recommend to ask the end-user to trigger a manual update of the bank connection interface (using the 'Update a bank connection' service). If the update completes successfully without triggering a strong customer authentication or results in storing a valid XS2A consent, this flag will switch to false. The logic about determination of the user's attention being required might change in time. Please use this as a convenience function to know, when you have to involve the user in the next communication with the bank. Once the flag switches to false, the bank connection interface will be enabled again for the auto-update (if it is configured).
    /// </summary>
    /// <value>This field indicates whether the user's attention is required for the next update of the given bank connection interface.<br/>If the field is true, finAPI stops auto-updates of this bank connection interface to mitigate the risk of locking the user's bank account and also of triggering a multi-step authentication that might lead to a notification being sent to the end-user.<br/>Every communication with the bank (e.g. updating a bank connection, submitting a money transfer or a direct debit, etc.) can change the value of this flag. If the field is true, we recommend to ask the end-user to trigger a manual update of the bank connection interface (using the 'Update a bank connection' service). If the update completes successfully without triggering a strong customer authentication or results in storing a valid XS2A consent, this flag will switch to false. The logic about determination of the user's attention being required might change in time. Please use this as a convenience function to know, when you have to involve the user in the next communication with the bank. Once the flag switches to false, the bank connection interface will be enabled again for the auto-update (if it is configured).</value>
    [DataMember(Name="userActionRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userActionRequired")]
    public bool? UserActionRequired { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BankConnectionInterface {\n");
      sb.Append("  Interface: ").Append(Interface).Append("\n");
      sb.Append("  LoginCredentials: ").Append(LoginCredentials).Append("\n");
      sb.Append("  DefaultTwoStepProcedureId: ").Append(DefaultTwoStepProcedureId).Append("\n");
      sb.Append("  TwoStepProcedures: ").Append(TwoStepProcedures).Append("\n");
      sb.Append("  AisConsent: ").Append(AisConsent).Append("\n");
      sb.Append("  LastManualUpdate: ").Append(LastManualUpdate).Append("\n");
      sb.Append("  LastAutoUpdate: ").Append(LastAutoUpdate).Append("\n");
      sb.Append("  UserActionRequired: ").Append(UserActionRequired).Append("\n");
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
