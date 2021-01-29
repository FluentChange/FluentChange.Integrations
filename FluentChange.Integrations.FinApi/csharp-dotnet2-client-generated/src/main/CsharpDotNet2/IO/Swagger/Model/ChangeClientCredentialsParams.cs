using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Parameters for changing client credentials
  /// </summary>
  [DataContract]
  public class ChangeClientCredentialsParams {
    /// <summary>
    /// client_id of the client that you want to change the secret for
    /// </summary>
    /// <value>client_id of the client that you want to change the secret for</value>
    [DataMember(Name="clientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientId")]
    public string ClientId { get; set; }

    /// <summary>
    /// Old (=current) client_secret
    /// </summary>
    /// <value>Old (=current) client_secret</value>
    [DataMember(Name="oldClientSecret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oldClientSecret")]
    public string OldClientSecret { get; set; }

    /// <summary>
    /// New client_secret. Required length is 36. Allowed symbols: Digits (0 through 9), lower-case and upper-case letters (A through Z), and the dash symbol (\"-\").
    /// </summary>
    /// <value>New client_secret. Required length is 36. Allowed symbols: Digits (0 through 9), lower-case and upper-case letters (A through Z), and the dash symbol (\"-\").</value>
    [DataMember(Name="newClientSecret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "newClientSecret")]
    public string NewClientSecret { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChangeClientCredentialsParams {\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  OldClientSecret: ").Append(OldClientSecret).Append("\n");
      sb.Append("  NewClientSecret: ").Append(NewClientSecret).Append("\n");
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
