using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Error details
  /// </summary>
  [DataContract]
  public class ErrorDetails {
    /// <summary>
    /// Error message
    /// </summary>
    /// <value>Error message</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Error code. See the documentation of the individual services for details about what values may be returned.
    /// </summary>
    /// <value>Error code. See the documentation of the individual services for details about what values may be returned.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// Error type. BUSINESS errors depict error messages in the language of the bank (or the preferred language) for the user, e.g. from a bank server. TECHNICAL errors are meant to be read by developers and depict internal errors.
    /// </summary>
    /// <value>Error type. BUSINESS errors depict error messages in the language of the bank (or the preferred language) for the user, e.g. from a bank server. TECHNICAL errors are meant to be read by developers and depict internal errors.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// This field is set when a multi-step authentication is required, i.e. when you need to repeat the original service call and provide additional data. The field contains information about what additional data is required.
    /// </summary>
    /// <value>This field is set when a multi-step authentication is required, i.e. when you need to repeat the original service call and provide additional data. The field contains information about what additional data is required.</value>
    [DataMember(Name="multiStepAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "multiStepAuthentication")]
    public MultiStepAuthenticationChallenge MultiStepAuthentication { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ErrorDetails {\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  MultiStepAuthentication: ").Append(MultiStepAuthentication).Append("\n");
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
