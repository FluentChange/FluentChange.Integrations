using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Set of identifiers (in ascending order)
  /// </summary>
  [DataContract]
  public class IdentifierList {
    /// <summary>
    /// Set of identifiers (in ascending order)
    /// </summary>
    /// <value>Set of identifiers (in ascending order)</value>
    [DataMember(Name="identifiers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifiers")]
    public List<long?> Identifiers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentifierList {\n");
      sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
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
