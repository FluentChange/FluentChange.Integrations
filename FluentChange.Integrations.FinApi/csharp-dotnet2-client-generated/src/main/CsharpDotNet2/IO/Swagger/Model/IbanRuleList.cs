using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for IBAN rules
  /// </summary>
  [DataContract]
  public class IbanRuleList {
    /// <summary>
    /// List of IBAN rules
    /// </summary>
    /// <value>List of IBAN rules</value>
    [DataMember(Name="ibanRules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ibanRules")]
    public List<IbanRule> IbanRules { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IbanRuleList {\n");
      sb.Append("  IbanRules: ").Append(IbanRules).Append("\n");
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
