using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for a bank login credential
  /// </summary>
  [DataContract]
  public class LoginCredentialResource {
    /// <summary>
    /// Label for this login credential, as we suggest to show it to the user.
    /// </summary>
    /// <value>Label for this login credential, as we suggest to show it to the user.</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// Stored value for this login credential. Please NOTE:<br/>If your client has no license for processing banking credentials, or if this field contains a value that requires password protection (e.g. PIN), then this field will always be 'XXXXX'.
    /// </summary>
    /// <value>Stored value for this login credential. Please NOTE:<br/>If your client has no license for processing banking credentials, or if this field contains a value that requires password protection (e.g. PIN), then this field will always be 'XXXXX'.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LoginCredentialResource {\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
