using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Parameters of IBAN rule
  /// </summary>
  [DataContract]
  public class IbanRuleParams {
    /// <summary>
    /// IBAN (case-insensitive)
    /// </summary>
    /// <value>IBAN (case-insensitive)</value>
    [DataMember(Name="iban", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iban")]
    public string Iban { get; set; }

    /// <summary>
    /// ID of the category that this rule should assign to the matching transactions
    /// </summary>
    /// <value>ID of the category that this rule should assign to the matching transactions</value>
    [DataMember(Name="categoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryId")]
    public long? CategoryId { get; set; }

    /// <summary>
    /// Direction for the rule. 'Income' means that the rule applies to transactions with a positive amount only, 'Spending' means it applies to transactions with a negative amount only. 'Both' means that it applies to both kind of transactions. Note that in case of 'Both', finAPI will create two individual rules (one with direction 'Income' and one with direction 'Spending').
    /// </summary>
    /// <value>Direction for the rule. 'Income' means that the rule applies to transactions with a positive amount only, 'Spending' means it applies to transactions with a negative amount only. 'Both' means that it applies to both kind of transactions. Note that in case of 'Both', finAPI will create two individual rules (one with direction 'Income' and one with direction 'Spending').</value>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IbanRuleParams {\n");
      sb.Append("  Iban: ").Append(Iban).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
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
