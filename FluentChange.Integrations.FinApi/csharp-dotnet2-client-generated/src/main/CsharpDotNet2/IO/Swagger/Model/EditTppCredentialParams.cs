using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A container for editing TPP client credentials data
  /// </summary>
  [DataContract]
  public class EditTppCredentialParams {
    /// <summary>
    /// The TPP Authentication Group Id for which the credentials can be used
    /// </summary>
    /// <value>The TPP Authentication Group Id for which the credentials can be used</value>
    [DataMember(Name="tppAuthenticationGroupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tppAuthenticationGroupId")]
    public long? TppAuthenticationGroupId { get; set; }

    /// <summary>
    /// Label for credentials
    /// </summary>
    /// <value>Label for credentials</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// ID of the TPP accessing the ASPSP API, as provided by the ASPSP as the result of registration
    /// </summary>
    /// <value>ID of the TPP accessing the ASPSP API, as provided by the ASPSP as the result of registration</value>
    [DataMember(Name="tppClientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tppClientId")]
    public string TppClientId { get; set; }

    /// <summary>
    /// Secret of the TPP accessing the ASPSP API, as provided by the ASPSP as the result of registration
    /// </summary>
    /// <value>Secret of the TPP accessing the ASPSP API, as provided by the ASPSP as the result of registration</value>
    [DataMember(Name="tppClientSecret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tppClientSecret")]
    public string TppClientSecret { get; set; }

    /// <summary>
    /// API Key provided by ASPSP  as the result of registration
    /// </summary>
    /// <value>API Key provided by ASPSP  as the result of registration</value>
    [DataMember(Name="tppApiKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tppApiKey")]
    public string TppApiKey { get; set; }

    /// <summary>
    /// TPP name
    /// </summary>
    /// <value>TPP name</value>
    [DataMember(Name="tppName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tppName")]
    public string TppName { get; set; }

    /// <summary>
    /// Credentials \"valid from\" date in the format 'YYYY-MM-DD'. Default is today's date
    /// </summary>
    /// <value>Credentials \"valid from\" date in the format 'YYYY-MM-DD'. Default is today's date</value>
    [DataMember(Name="validFromDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validFromDate")]
    public string ValidFromDate { get; set; }

    /// <summary>
    /// Credentials \"valid until\" date in the format 'YYYY-MM-DD'. Default is null which means \"indefinite\" (no limit)
    /// </summary>
    /// <value>Credentials \"valid until\" date in the format 'YYYY-MM-DD'. Default is null which means \"indefinite\" (no limit)</value>
    [DataMember(Name="validUntilDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validUntilDate")]
    public string ValidUntilDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EditTppCredentialParams {\n");
      sb.Append("  TppAuthenticationGroupId: ").Append(TppAuthenticationGroupId).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  TppClientId: ").Append(TppClientId).Append("\n");
      sb.Append("  TppClientSecret: ").Append(TppClientSecret).Append("\n");
      sb.Append("  TppApiKey: ").Append(TppApiKey).Append("\n");
      sb.Append("  TppName: ").Append(TppName).Append("\n");
      sb.Append("  ValidFromDate: ").Append(ValidFromDate).Append("\n");
      sb.Append("  ValidUntilDate: ").Append(ValidUntilDate).Append("\n");
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
