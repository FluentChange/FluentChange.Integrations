using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for TPP client credentials information with paging info
  /// </summary>
  [DataContract]
  public class PageableTppCredentialResources {
    /// <summary>
    /// List of TPP client credentials
    /// </summary>
    /// <value>List of TPP client credentials</value>
    [DataMember(Name="tppCredentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tppCredentials")]
    public List<TppCredentials> TppCredentials { get; set; }

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
      sb.Append("class PageableTppCredentialResources {\n");
      sb.Append("  TppCredentials: ").Append(TppCredentials).Append("\n");
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
