using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// TPP Authentication groups with paging information
  /// </summary>
  [DataContract]
  public class PageableTppAuthenticationGroupResources {
    /// <summary>
    /// List of received TPP authentication groups
    /// </summary>
    /// <value>List of received TPP authentication groups</value>
    [DataMember(Name="tppAuthenticationGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tppAuthenticationGroups")]
    public List<TppAuthenticationGroup> TppAuthenticationGroups { get; set; }

    /// <summary>
    /// Information for pagination
    /// </summary>
    /// <value>Information for pagination</value>
    [DataMember(Name="paging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paging")]
    public Paging Paging { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PageableTppAuthenticationGroupResources {\n");
      sb.Append("  TppAuthenticationGroups: ").Append(TppAuthenticationGroups).Append("\n");
      sb.Append("  Paging: ").Append(Paging).Append("\n");
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
