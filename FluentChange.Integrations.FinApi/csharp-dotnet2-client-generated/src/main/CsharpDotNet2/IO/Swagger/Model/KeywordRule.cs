using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for a keyword rule
  /// </summary>
  [DataContract]
  public class KeywordRule {
    /// <summary>
    /// Rule identifier
    /// </summary>
    /// <value>Rule identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The category that this rule assigns to the transactions that it matches
    /// </summary>
    /// <value>The category that this rule assigns to the transactions that it matches</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public Category Category { get; set; }

    /// <summary>
    /// Direction for the rule. 'Income' means that the rule applies to transactions with a positive amount only, 'Spending' means it applies to transactions with a negative amount only.
    /// </summary>
    /// <value>Direction for the rule. 'Income' means that the rule applies to transactions with a positive amount only, 'Spending' means it applies to transactions with a negative amount only.</value>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }

    /// <summary>
    /// Timestamp of when the rule was created, in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time)
    /// </summary>
    /// <value>Timestamp of when the rule was created, in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time)</value>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public string CreationDate { get; set; }

    /// <summary>
    /// Set of keywords that this rule defines.
    /// </summary>
    /// <value>Set of keywords that this rule defines.</value>
    [DataMember(Name="keywords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keywords")]
    public List<string> Keywords { get; set; }

    /// <summary>
    /// This field is only relevant if the rule contains multiple keywords. If set to 'true' it means that all keywords have to be found in a transaction to apply the given category. If set to 'false', then even a single matching keyword in a transaction can trigger this rule.
    /// </summary>
    /// <value>This field is only relevant if the rule contains multiple keywords. If set to 'true' it means that all keywords have to be found in a transaction to apply the given category. If set to 'false', then even a single matching keyword in a transaction can trigger this rule.</value>
    [DataMember(Name="allKeywordsMustMatch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allKeywordsMustMatch")]
    public bool? AllKeywordsMustMatch { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KeywordRule {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
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
