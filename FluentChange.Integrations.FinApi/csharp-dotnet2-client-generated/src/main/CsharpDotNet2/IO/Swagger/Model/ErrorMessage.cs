using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Response type when a service call was not successful. Contains details about the error(s) that occurred.
  /// </summary>
  [DataContract]
  public class ErrorMessage {
    /// <summary>
    /// List of errors
    /// </summary>
    /// <value>List of errors</value>
    [DataMember(Name="errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errors")]
    public List<ErrorDetails> Errors { get; set; }

    /// <summary>
    /// Server date of when the error(s) occurred, in the format YYYY-MM-DD HH:MM:SS.SSS
    /// </summary>
    /// <value>Server date of when the error(s) occurred, in the format YYYY-MM-DD HH:MM:SS.SSS</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public string Date { get; set; }

    /// <summary>
    /// The service endpoint that was called
    /// </summary>
    /// <value>The service endpoint that was called</value>
    [DataMember(Name="endpoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endpoint")]
    public string Endpoint { get; set; }

    /// <summary>
    /// Information about the authorization context of the service call
    /// </summary>
    /// <value>Information about the authorization context of the service call</value>
    [DataMember(Name="authContext", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authContext")]
    public string AuthContext { get; set; }

    /// <summary>
    /// BLZ and name (in format \"<BLZ> - <name>\") of a bank that was used for the original request
    /// </summary>
    /// <value>BLZ and name (in format \"<BLZ> - <name>\") of a bank that was used for the original request</value>
    [DataMember(Name="bank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bank")]
    public string Bank { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ErrorMessage {\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
      sb.Append("  AuthContext: ").Append(AuthContext).Append("\n");
      sb.Append("  Bank: ").Append(Bank).Append("\n");
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
