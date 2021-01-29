using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Data of a sub-transaction
  /// </summary>
  [DataContract]
  public class SubTransactionParams {
    /// <summary>
    /// Amount
    /// </summary>
    /// <value>Amount</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Category identifier. If not specified, the original transaction's category will be applied. If you explicitly want the sub-transaction to have no category, then pass this field with value '0' (zero).
    /// </summary>
    /// <value>Category identifier. If not specified, the original transaction's category will be applied. If you explicitly want the sub-transaction to have no category, then pass this field with value '0' (zero).</value>
    [DataMember(Name="categoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryId")]
    public long? CategoryId { get; set; }

    /// <summary>
    /// Purpose. Maximum length is 2000. If not specified, the original transaction's value will be applied.
    /// </summary>
    /// <value>Purpose. Maximum length is 2000. If not specified, the original transaction's value will be applied.</value>
    [DataMember(Name="purpose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purpose")]
    public string Purpose { get; set; }

    /// <summary>
    /// Counterpart. Maximum length is 80. If not specified, the original transaction's value will be applied.
    /// </summary>
    /// <value>Counterpart. Maximum length is 80. If not specified, the original transaction's value will be applied.</value>
    [DataMember(Name="counterpart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpart")]
    public string Counterpart { get; set; }

    /// <summary>
    /// Counterpart account number. If not specified, the original transaction's value will be applied.
    /// </summary>
    /// <value>Counterpart account number. If not specified, the original transaction's value will be applied.</value>
    [DataMember(Name="counterpartAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartAccountNumber")]
    public string CounterpartAccountNumber { get; set; }

    /// <summary>
    /// Counterpart IBAN. If not specified, the original transaction's value will be applied.
    /// </summary>
    /// <value>Counterpart IBAN. If not specified, the original transaction's value will be applied.</value>
    [DataMember(Name="counterpartIban", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartIban")]
    public string CounterpartIban { get; set; }

    /// <summary>
    /// Counterpart BIC. If not specified, the original transaction's value will be applied.
    /// </summary>
    /// <value>Counterpart BIC. If not specified, the original transaction's value will be applied.</value>
    [DataMember(Name="counterpartBic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartBic")]
    public string CounterpartBic { get; set; }

    /// <summary>
    /// Counterpart BLZ. If not specified, the original transaction's value will be applied.
    /// </summary>
    /// <value>Counterpart BLZ. If not specified, the original transaction's value will be applied.</value>
    [DataMember(Name="counterpartBlz", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartBlz")]
    public string CounterpartBlz { get; set; }

    /// <summary>
    /// List of connected labels. Note that when this field is not specified, then the labels of the original transaction will NOT get applied to the sub-transaction. Instead, the sub-transaction will have no labels assigned to it.
    /// </summary>
    /// <value>List of connected labels. Note that when this field is not specified, then the labels of the original transaction will NOT get applied to the sub-transaction. Instead, the sub-transaction will have no labels assigned to it.</value>
    [DataMember(Name="labelIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labelIds")]
    public List<long?> LabelIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubTransactionParams {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  Purpose: ").Append(Purpose).Append("\n");
      sb.Append("  Counterpart: ").Append(Counterpart).Append("\n");
      sb.Append("  CounterpartAccountNumber: ").Append(CounterpartAccountNumber).Append("\n");
      sb.Append("  CounterpartIban: ").Append(CounterpartIban).Append("\n");
      sb.Append("  CounterpartBic: ").Append(CounterpartBic).Append("\n");
      sb.Append("  CounterpartBlz: ").Append(CounterpartBlz).Append("\n");
      sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
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
