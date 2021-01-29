using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Transaction data for categorization check
  /// </summary>
  [DataContract]
  public class CheckCategorizationTransactionData {
    /// <summary>
    /// Identifier of transaction. This can be any arbitrary string that will be passed back in the response so that you can map the results to the given transactions. Note that the identifier must be unique within the given list of transactions.
    /// </summary>
    /// <value>Identifier of transaction. This can be any arbitrary string that will be passed back in the response so that you can map the results to the given transactions. Note that the identifier must be unique within the given list of transactions.</value>
    [DataMember(Name="transactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionId")]
    public string TransactionId { get; set; }

    /// <summary>
    /// Identifier of account type.<br/><br/>1 = Checking,<br/>2 = Savings,<br/>3 = CreditCard,<br/>4 = Security,<br/>5 = Loan,<br/>6 = Pocket (DEPRECATED; will not be returned for any account unless this type has explicitly been set via PATCH),<br/>7 = Membership,<br/>8 = Bausparen<br/><br/>
    /// </summary>
    /// <value>Identifier of account type.<br/><br/>1 = Checking,<br/>2 = Savings,<br/>3 = CreditCard,<br/>4 = Security,<br/>5 = Loan,<br/>6 = Pocket (DEPRECATED; will not be returned for any account unless this type has explicitly been set via PATCH),<br/>7 = Membership,<br/>8 = Bausparen<br/><br/></value>
    [DataMember(Name="accountTypeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountTypeId")]
    public long? AccountTypeId { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    /// <value>Amount</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Purpose. Any symbols are allowed. Maximum length is 2000. Default value: null.
    /// </summary>
    /// <value>Purpose. Any symbols are allowed. Maximum length is 2000. Default value: null.</value>
    [DataMember(Name="purpose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purpose")]
    public string Purpose { get; set; }

    /// <summary>
    /// Counterpart. Any symbols are allowed. Maximum length is 80. Default value: null.
    /// </summary>
    /// <value>Counterpart. Any symbols are allowed. Maximum length is 80. Default value: null.</value>
    [DataMember(Name="counterpart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpart")]
    public string Counterpart { get; set; }

    /// <summary>
    /// Counterpart IBAN. Default value: null.
    /// </summary>
    /// <value>Counterpart IBAN. Default value: null.</value>
    [DataMember(Name="counterpartIban", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartIban")]
    public string CounterpartIban { get; set; }

    /// <summary>
    /// Counterpart account number. Default value: null.
    /// </summary>
    /// <value>Counterpart account number. Default value: null.</value>
    [DataMember(Name="counterpartAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartAccountNumber")]
    public string CounterpartAccountNumber { get; set; }

    /// <summary>
    /// Counterpart BLZ. Default value: null.
    /// </summary>
    /// <value>Counterpart BLZ. Default value: null.</value>
    [DataMember(Name="counterpartBlz", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartBlz")]
    public string CounterpartBlz { get; set; }

    /// <summary>
    /// Counterpart BIC. Default value: null.
    /// </summary>
    /// <value>Counterpart BIC. Default value: null.</value>
    [DataMember(Name="counterpartBic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartBic")]
    public string CounterpartBic { get; set; }

    /// <summary>
    /// Merchant category code (for credit card transactions only). May only contain up to 4 digits. Default value: null.
    /// </summary>
    /// <value>Merchant category code (for credit card transactions only). May only contain up to 4 digits. Default value: null.</value>
    [DataMember(Name="mcCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mcCode")]
    public string McCode { get; set; }

    /// <summary>
    /// ZKA business transaction code which relates to the transaction's type (Number from 0 through 999). Default value: null.
    /// </summary>
    /// <value>ZKA business transaction code which relates to the transaction's type (Number from 0 through 999). Default value: null.</value>
    [DataMember(Name="typeCodeZka", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typeCodeZka")]
    public string TypeCodeZka { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckCategorizationTransactionData {\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
      sb.Append("  AccountTypeId: ").Append(AccountTypeId).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Purpose: ").Append(Purpose).Append("\n");
      sb.Append("  Counterpart: ").Append(Counterpart).Append("\n");
      sb.Append("  CounterpartIban: ").Append(CounterpartIban).Append("\n");
      sb.Append("  CounterpartAccountNumber: ").Append(CounterpartAccountNumber).Append("\n");
      sb.Append("  CounterpartBlz: ").Append(CounterpartBlz).Append("\n");
      sb.Append("  CounterpartBic: ").Append(CounterpartBic).Append("\n");
      sb.Append("  McCode: ").Append(McCode).Append("\n");
      sb.Append("  TypeCodeZka: ").Append(TypeCodeZka).Append("\n");
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
