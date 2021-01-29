using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class BadCredentialsError {
    /// <summary>
    /// Error type
    /// </summary>
    /// <value>Error type</value>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error")]
    public string Error { get; set; }

    /// <summary>
    /// Error description
    /// </summary>
    /// <value>Error description</value>
    [DataMember(Name="error_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_description")]
    public string ErrorDescription { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BadCredentialsError {\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
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
