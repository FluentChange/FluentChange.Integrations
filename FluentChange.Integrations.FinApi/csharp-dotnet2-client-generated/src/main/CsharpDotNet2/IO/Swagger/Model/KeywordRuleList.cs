using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for keyword rules
  /// </summary>
  [DataContract]
  public class KeywordRuleList {
    /// <summary>
    /// List of keyword rules
    /// </summary>
    /// <value>List of keyword rules</value>
    [DataMember(Name="keywordRules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keywordRules")]
    public List<KeywordRule> KeywordRules { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KeywordRuleList {\n");
      sb.Append("  KeywordRules: ").Append(KeywordRules).Append("\n");
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
