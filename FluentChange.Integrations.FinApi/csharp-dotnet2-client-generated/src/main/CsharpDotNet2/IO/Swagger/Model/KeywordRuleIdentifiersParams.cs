using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Identifiers params
  /// </summary>
  [DataContract]
  public class KeywordRuleIdentifiersParams {
    /// <summary>
    /// List of identifiers
    /// </summary>
    /// <value>List of identifiers</value>
    [DataMember(Name="ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ids")]
    public List<long?> Ids { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KeywordRuleIdentifiersParams {\n");
      sb.Append("  Ids: ").Append(Ids).Append("\n");
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
