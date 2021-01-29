using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Parameters for a money transfer order
  /// </summary>
  [DataContract]
  public class MoneyTransferOrderParams {
    /// <summary>
    /// Name of the counterpart. Note: Neither finAPI nor the involved bank servers are guaranteed to validate the counterpart name. Even if the name does not depict the actual registered account holder of the target account, the order might still be successful.
    /// </summary>
    /// <value>Name of the counterpart. Note: Neither finAPI nor the involved bank servers are guaranteed to validate the counterpart name. Even if the name does not depict the actual registered account holder of the target account, the order might still be successful.</value>
    [DataMember(Name="counterpartName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartName")]
    public string CounterpartName { get; set; }

    /// <summary>
    /// IBAN of the counterpart's account.
    /// </summary>
    /// <value>IBAN of the counterpart's account.</value>
    [DataMember(Name="counterpartIban", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartIban")]
    public string CounterpartIban { get; set; }

    /// <summary>
    /// BIC of the counterpart's account. Only required when there is no 'IBAN_ONLY'-capability in the respective account/interface combination that is to be used when submitting the payment.
    /// </summary>
    /// <value>BIC of the counterpart's account. Only required when there is no 'IBAN_ONLY'-capability in the respective account/interface combination that is to be used when submitting the payment.</value>
    [DataMember(Name="counterpartBic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartBic")]
    public string CounterpartBic { get; set; }

    /// <summary>
    /// The amount of the payment. Must be a positive decimal number with at most two decimal places. For money transfers over the XS2A interface, finAPI will interpret the amount to be in the currency of the related account. For money transfers over other interfaces (FINTS_SERVER, WEB_SCRAPER), as well as for standalone money transfers (finAPI Payment product) over all interfaces (FINTS_SERVER, WEB_SCRAPER, XS2A), finAPI will consider the amount to be in EUR.
    /// </summary>
    /// <value>The amount of the payment. Must be a positive decimal number with at most two decimal places. For money transfers over the XS2A interface, finAPI will interpret the amount to be in the currency of the related account. For money transfers over other interfaces (FINTS_SERVER, WEB_SCRAPER), as well as for standalone money transfers (finAPI Payment product) over all interfaces (FINTS_SERVER, WEB_SCRAPER, XS2A), finAPI will consider the amount to be in EUR.</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// The purpose of the transfer transaction
    /// </summary>
    /// <value>The purpose of the transfer transaction</value>
    [DataMember(Name="purpose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purpose")]
    public string Purpose { get; set; }

    /// <summary>
    /// SEPA purpose code, according to ISO 20022, external codes set.<br/>Please note that the SEPA purpose code may be ignored by some banks.
    /// </summary>
    /// <value>SEPA purpose code, according to ISO 20022, external codes set.<br/>Please note that the SEPA purpose code may be ignored by some banks.</value>
    [DataMember(Name="sepaPurposeCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sepaPurposeCode")]
    public string SepaPurposeCode { get; set; }

    /// <summary>
    /// End-To-End ID for the transfer transaction
    /// </summary>
    /// <value>End-To-End ID for the transfer transaction</value>
    [DataMember(Name="endToEndId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endToEndId")]
    public string EndToEndId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MoneyTransferOrderParams {\n");
      sb.Append("  CounterpartName: ").Append(CounterpartName).Append("\n");
      sb.Append("  CounterpartIban: ").Append(CounterpartIban).Append("\n");
      sb.Append("  CounterpartBic: ").Append(CounterpartBic).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Purpose: ").Append(Purpose).Append("\n");
      sb.Append("  SepaPurposeCode: ").Append(SepaPurposeCode).Append("\n");
      sb.Append("  EndToEndId: ").Append(EndToEndId).Append("\n");
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
