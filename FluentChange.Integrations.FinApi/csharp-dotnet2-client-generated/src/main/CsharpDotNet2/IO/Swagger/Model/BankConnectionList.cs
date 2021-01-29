using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for data of multiple bank connections
  /// </summary>
  [DataContract]
  public class BankConnectionList {
    /// <summary>
    /// List of bank connections
    /// </summary>
    /// <value>List of bank connections</value>
    [DataMember(Name="connections", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "connections")]
    public List<BankConnection> Connections { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BankConnectionList {\n");
      sb.Append("  Connections: ").Append(Connections).Append("\n");
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
