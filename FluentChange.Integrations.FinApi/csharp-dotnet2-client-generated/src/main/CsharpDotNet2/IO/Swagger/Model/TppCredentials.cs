using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A container for the TPP client credentials data
  /// </summary>
  [DataContract]
  public class TppCredentials {
    /// <summary>
    /// The credential identifier.
    /// </summary>
    /// <value>The credential identifier.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Optional label of tpp client credentials set.
    /// </summary>
    /// <value>Optional label of tpp client credentials set.</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// TPP Authentication Group ID
    /// </summary>
    /// <value>TPP Authentication Group ID</value>
    [DataMember(Name="tppAuthenticationGroupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tppAuthenticationGroupId")]
    public long? TppAuthenticationGroupId { get; set; }

    /// <summary>
    /// Valid from date in the format 'YYYY-MM-DD'.
    /// </summary>
    /// <value>Valid from date in the format 'YYYY-MM-DD'.</value>
    [DataMember(Name="validFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validFrom")]
    public string ValidFrom { get; set; }

    /// <summary>
    /// Valid until date in the format 'YYYY-MM-DD'.
    /// </summary>
    /// <value>Valid until date in the format 'YYYY-MM-DD'.</value>
    [DataMember(Name="validUntil", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validUntil")]
    public string ValidUntil { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TppCredentials {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  TppAuthenticationGroupId: ").Append(TppAuthenticationGroupId).Append("\n");
      sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
      sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
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
