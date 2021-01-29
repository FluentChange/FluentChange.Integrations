using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for interface removal parameters
  /// </summary>
  [DataContract]
  public class RemoveInterfaceParams {
    /// <summary>
    /// Bank connection identifier
    /// </summary>
    /// <value>Bank connection identifier</value>
    [DataMember(Name="bankConnectionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankConnectionId")]
    public long? BankConnectionId { get; set; }

    /// <summary>
    /// The interface which you want to remove.
    /// </summary>
    /// <value>The interface which you want to remove.</value>
    [DataMember(Name="interface", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interface")]
    public string Interface { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RemoveInterfaceParams {\n");
      sb.Append("  BankConnectionId: ").Append(BankConnectionId).Append("\n");
      sb.Append("  Interface: ").Append(Interface).Append("\n");
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
