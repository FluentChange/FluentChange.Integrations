using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// User&#39;s verification status
  /// </summary>
  [DataContract]
  public class VerificationStatusResource {
    /// <summary>
    /// User's identifier
    /// </summary>
    /// <value>User's identifier</value>
    [DataMember(Name="userId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userId")]
    public string UserId { get; set; }

    /// <summary>
    /// User's verification status
    /// </summary>
    /// <value>User's verification status</value>
    [DataMember(Name="isUserVerified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isUserVerified")]
    public bool? IsUserVerified { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VerificationStatusResource {\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  IsUserVerified: ").Append(IsUserVerified).Append("\n");
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
