using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for a bank account&#39;s data
  /// </summary>
  [DataContract]
  public class Account {
    /// <summary>
    /// Account identifier
    /// </summary>
    /// <value>Account identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Identifier of the bank connection that this account belongs to
    /// </summary>
    /// <value>Identifier of the bank connection that this account belongs to</value>
    [DataMember(Name="bankConnectionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankConnectionId")]
    public long? BankConnectionId { get; set; }

    /// <summary>
    /// Account name
    /// </summary>
    /// <value>Account name</value>
    [DataMember(Name="accountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Account's IBAN. Note that this field can change from 'null' to a value - or vice versa - any time when the account is being updated. This is subject to changes within the bank's internal account management.
    /// </summary>
    /// <value>Account's IBAN. Note that this field can change from 'null' to a value - or vice versa - any time when the account is being updated. This is subject to changes within the bank's internal account management.</value>
    [DataMember(Name="iban", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iban")]
    public string Iban { get; set; }

    /// <summary>
    /// (National) account number. Note that this value might change whenever the account is updated (for example, leading zeros might be added or removed).
    /// </summary>
    /// <value>(National) account number. Note that this value might change whenever the account is updated (for example, leading zeros might be added or removed).</value>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Account's sub-account-number. Note that this field can change from 'null' to a value - or vice versa - any time when the account is being updated. This is subject to changes within the bank's internal account management.
    /// </summary>
    /// <value>Account's sub-account-number. Note that this field can change from 'null' to a value - or vice versa - any time when the account is being updated. This is subject to changes within the bank's internal account management.</value>
    [DataMember(Name="subAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subAccountNumber")]
    public string SubAccountNumber { get; set; }

    /// <summary>
    /// Name of the account holder
    /// </summary>
    /// <value>Name of the account holder</value>
    [DataMember(Name="accountHolderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountHolderName")]
    public string AccountHolderName { get; set; }

    /// <summary>
    /// Bank's internal identification of the account holder. Note that if your client has no license for processing this field, it will always be 'XXXXX'
    /// </summary>
    /// <value>Bank's internal identification of the account holder. Note that if your client has no license for processing this field, it will always be 'XXXXX'</value>
    [DataMember(Name="accountHolderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountHolderId")]
    public string AccountHolderId { get; set; }

    /// <summary>
    /// Account's currency
    /// </summary>
    /// <value>Account's currency</value>
    [DataMember(Name="accountCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountCurrency")]
    public string AccountCurrency { get; set; }

    /// <summary>
    /// An account type.<br/><br/>Checking,<br/>Savings,<br/>CreditCard,<br/>Security,<br/>Loan,<br/>Pocket (DEPRECATED; will not be returned for any account unless this type has explicitly been set via PATCH),<br/>Membership,<br/>Bausparen<br/><br/>
    /// </summary>
    /// <value>An account type.<br/><br/>Checking,<br/>Savings,<br/>CreditCard,<br/>Security,<br/>Loan,<br/>Pocket (DEPRECATED; will not be returned for any account unless this type has explicitly been set via PATCH),<br/>Membership,<br/>Bausparen<br/><br/></value>
    [DataMember(Name="accountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountType")]
    public string AccountType { get; set; }

    /// <summary>
    /// Current account balance
    /// </summary>
    /// <value>Current account balance</value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public decimal? Balance { get; set; }

    /// <summary>
    /// Current overdraft
    /// </summary>
    /// <value>Current overdraft</value>
    [DataMember(Name="overdraft", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overdraft")]
    public decimal? Overdraft { get; set; }

    /// <summary>
    /// Overdraft limit
    /// </summary>
    /// <value>Overdraft limit</value>
    [DataMember(Name="overdraftLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overdraftLimit")]
    public decimal? OverdraftLimit { get; set; }

    /// <summary>
    /// Current available funds. Note that this field is only set if finAPI can make a definite statement about the current available funds. This might not always be the case, for example if there is not enough information available about the overdraft limit and current overdraft.
    /// </summary>
    /// <value>Current available funds. Note that this field is only set if finAPI can make a definite statement about the current available funds. This might not always be the case, for example if there is not enough information available about the overdraft limit and current overdraft.</value>
    [DataMember(Name="availableFunds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableFunds")]
    public decimal? AvailableFunds { get; set; }

    /// <summary>
    /// Indicating whether this account is 'new' or not. Any newly imported account will have this flag initially set to true, and remain so until you set it to false (see PATCH /accounts/<id>). How you use this field is up to your interpretation, however it is recommended to set the flag to false for all accounts right after the initial import of the bank connection. This way, you will be able recognize accounts that get newly imported during a later update of the bank connection, by checking for any accounts with the flag set to true right after an update.
    /// </summary>
    /// <value>Indicating whether this account is 'new' or not. Any newly imported account will have this flag initially set to true, and remain so until you set it to false (see PATCH /accounts/<id>). How you use this field is up to your interpretation, however it is recommended to set the flag to false for all accounts right after the initial import of the bank connection. This way, you will be able recognize accounts that get newly imported during a later update of the bank connection, by checking for any accounts with the flag set to true right after an update.</value>
    [DataMember(Name="isNew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isNew")]
    public bool? IsNew { get; set; }

    /// <summary>
    /// Set of interfaces to which this account is connected
    /// </summary>
    /// <value>Set of interfaces to which this account is connected</value>
    [DataMember(Name="interfaces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interfaces")]
    public List<AccountInterface> Interfaces { get; set; }

    /// <summary>
    /// Whether this account is seized. Note that this information is not received from the bank, but determined by finAPI based on the available account information.
    /// </summary>
    /// <value>Whether this account is seized. Note that this information is not received from the bank, but determined by finAPI based on the available account information.</value>
    [DataMember(Name="isSeized", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isSeized")]
    public bool? IsSeized { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Account {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  BankConnectionId: ").Append(BankConnectionId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  Iban: ").Append(Iban).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  SubAccountNumber: ").Append(SubAccountNumber).Append("\n");
      sb.Append("  AccountHolderName: ").Append(AccountHolderName).Append("\n");
      sb.Append("  AccountHolderId: ").Append(AccountHolderId).Append("\n");
      sb.Append("  AccountCurrency: ").Append(AccountCurrency).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  Overdraft: ").Append(Overdraft).Append("\n");
      sb.Append("  OverdraftLimit: ").Append(OverdraftLimit).Append("\n");
      sb.Append("  AvailableFunds: ").Append(AvailableFunds).Append("\n");
      sb.Append("  IsNew: ").Append(IsNew).Append("\n");
      sb.Append("  Interfaces: ").Append(Interfaces).Append("\n");
      sb.Append("  IsSeized: ").Append(IsSeized).Append("\n");
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
