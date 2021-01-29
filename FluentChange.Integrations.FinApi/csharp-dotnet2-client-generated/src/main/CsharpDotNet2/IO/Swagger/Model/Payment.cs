using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for a payment&#39;s data
  /// </summary>
  [DataContract]
  public class Payment {
    /// <summary>
    /// Payment identifier
    /// </summary>
    /// <value>Payment identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Identifier of the account to which this payment relates. This field is only set if it was specified upon creation of the payment.
    /// </summary>
    /// <value>Identifier of the account to which this payment relates. This field is only set if it was specified upon creation of the payment.</value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// IBAN of the account to which this payment relates. This field is only set if it was specified upon creation of the payment.
    /// </summary>
    /// <value>IBAN of the account to which this payment relates. This field is only set if it was specified upon creation of the payment.</value>
    [DataMember(Name="iban", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iban")]
    public string Iban { get; set; }

    /// <summary>
    /// Payment type
    /// </summary>
    /// <value>Payment type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Total money amount of the payment order(s), as absolute value
    /// </summary>
    /// <value>Total money amount of the payment order(s), as absolute value</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Total count of orders included in this payment
    /// </summary>
    /// <value>Total count of orders included in this payment</value>
    [DataMember(Name="orderCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderCount")]
    public int? OrderCount { get; set; }

    /// <summary>
    /// Current payment status:<br/> &bull; OPEN: means that this payment has been created in finAPI, but not yet submitted to the bank.<br/> &bull; PENDING: means that this payment has been requested at the bank, but not yet executed.<br/> &bull; SUCCESSFUL: means that this payment has been successfully executed.<br/> &bull; NOT_SUCCESSFUL: means that this payment could not be executed successfully.<br/> &bull; DISCARDED: means that this payment was discarded, either because another payment was requested for the same account before this payment was executed and the bank does not support this, or because the bank has rejected the payment even before the execution.
    /// </summary>
    /// <value>Current payment status:<br/> &bull; OPEN: means that this payment has been created in finAPI, but not yet submitted to the bank.<br/> &bull; PENDING: means that this payment has been requested at the bank, but not yet executed.<br/> &bull; SUCCESSFUL: means that this payment has been successfully executed.<br/> &bull; NOT_SUCCESSFUL: means that this payment could not be executed successfully.<br/> &bull; DISCARDED: means that this payment was discarded, either because another payment was requested for the same account before this payment was executed and the bank does not support this, or because the bank has rejected the payment even before the execution.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Contains the bank's response to the execution of this payment. This field is not set until the payment gets executed. Note that even after the execution of the payment, the field might still not be set, if the bank did not send any response message.
    /// </summary>
    /// <value>Contains the bank's response to the execution of this payment. This field is not set until the payment gets executed. Note that even after the execution of the payment, the field might still not be set, if the bank did not send any response message.</value>
    [DataMember(Name="bankMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankMessage")]
    public string BankMessage { get; set; }

    /// <summary>
    /// Time of when this payment was requested, in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time)
    /// </summary>
    /// <value>Time of when this payment was requested, in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time)</value>
    [DataMember(Name="requestDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestDate")]
    public string RequestDate { get; set; }

    /// <summary>
    /// Time of when this payment was executed by finAPI, in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time)<br/>Note: this is not necessarily identical to the date when the bank will book the payment, e.g. if a future date was given in the 'executionDate' field of the payment.
    /// </summary>
    /// <value>Time of when this payment was executed by finAPI, in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time)<br/>Note: this is not necessarily identical to the date when the bank will book the payment, e.g. if a future date was given in the 'executionDate' field of the payment.</value>
    [DataMember(Name="executionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executionDate")]
    public string ExecutionDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Payment {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  Iban: ").Append(Iban).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  OrderCount: ").Append(OrderCount).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  BankMessage: ").Append(BankMessage).Append("\n");
      sb.Append("  RequestDate: ").Append(RequestDate).Append("\n");
      sb.Append("  ExecutionDate: ").Append(ExecutionDate).Append("\n");
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
