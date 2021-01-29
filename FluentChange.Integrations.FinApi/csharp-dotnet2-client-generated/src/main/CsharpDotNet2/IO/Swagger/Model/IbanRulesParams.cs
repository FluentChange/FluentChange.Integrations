using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Params for creation IBAN rules
  /// </summary>
  [DataContract]
  public class IbanRulesParams {
    /// <summary>
    /// IBAN rule definitions. The minimum number of rule definitions is 1. The maximum number of rule definitions is 100.
    /// </summary>
    /// <value>IBAN rule definitions. The minimum number of rule definitions is 1. The maximum number of rule definitions is 100.</value>
    [DataMember(Name="ibanRules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ibanRules")]
    public List<IbanRuleParams> IbanRules { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IbanRulesParams {\n");
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
