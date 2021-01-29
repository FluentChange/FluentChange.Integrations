using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// User identifiers params
  /// </summary>
  [DataContract]
  public class UserIdentifiersParams {
    /// <summary>
    /// List of user identifiers
    /// </summary>
    /// <value>List of user identifiers</value>
    [DataMember(Name="userIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userIds")]
    public List<string> UserIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserIdentifiersParams {\n");
      sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
