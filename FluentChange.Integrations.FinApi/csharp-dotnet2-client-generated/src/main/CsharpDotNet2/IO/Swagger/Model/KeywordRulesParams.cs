using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Params for creation keyword rules
  /// </summary>
  [DataContract]
  public class KeywordRulesParams {
    /// <summary>
    /// Keyword rule definitions. The minimum number of rule definitions is 1. The maximum number of rule definitions is 100.
    /// </summary>
    /// <value>Keyword rule definitions. The minimum number of rule definitions is 1. The maximum number of rule definitions is 100.</value>
    [DataMember(Name="keywordRules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keywordRules")]
    public List<KeywordRuleParams> KeywordRules { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KeywordRulesParams {\n");
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
