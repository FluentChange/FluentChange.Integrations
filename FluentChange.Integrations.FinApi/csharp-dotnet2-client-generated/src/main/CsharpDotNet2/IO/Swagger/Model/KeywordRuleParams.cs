using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Parameters of keyword rule
  /// </summary>
  [DataContract]
  public class KeywordRuleParams {
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
    /// Set of keywords for the rule (Keywords are regarded case-insensitive). The minimum number of keywords is 1. The maximum number of keywords is 100.
    /// </summary>
    /// <value>Set of keywords for the rule (Keywords are regarded case-insensitive). The minimum number of keywords is 1. The maximum number of keywords is 100.</value>
    [DataMember(Name="keywords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keywords")]
    public List<string> Keywords { get; set; }

    /// <summary>
    /// This field is only relevant if you pass multiple keywords. If set to 'true', it means that all keywords have to be found in a transaction to apply the given category. If set to 'false', then even a single matching keyword in a transaction can trigger this rule. Default value is 'false'.
    /// </summary>
    /// <value>This field is only relevant if you pass multiple keywords. If set to 'true', it means that all keywords have to be found in a transaction to apply the given category. If set to 'false', then even a single matching keyword in a transaction can trigger this rule. Default value is 'false'.</value>
    [DataMember(Name="allKeywordsMustMatch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allKeywordsMustMatch")]
    public bool? AllKeywordsMustMatch { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KeywordRuleParams {\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  Keywords: ").Append(Keywords).Append("\n");
      sb.Append("  AllKeywordsMustMatch: ").Append(AllKeywordsMustMatch).Append("\n");
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
