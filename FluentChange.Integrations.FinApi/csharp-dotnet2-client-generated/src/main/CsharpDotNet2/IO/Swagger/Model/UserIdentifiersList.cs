using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for list of identifiers of deleted users, and not deleted users (in ascending order)
  /// </summary>
  [DataContract]
  public class UserIdentifiersList {
    /// <summary>
    /// List of identifiers of deleted users (in ascending order)
    /// </summary>
    /// <value>List of identifiers of deleted users (in ascending order)</value>
    [DataMember(Name="deletedUsers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deletedUsers")]
    public List<string> DeletedUsers { get; set; }

    /// <summary>
    /// List of identifiers of not deleted users (in ascending order)
    /// </summary>
    /// <value>List of identifiers of not deleted users (in ascending order)</value>
    [DataMember(Name="nonDeletedUsers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nonDeletedUsers")]
    public List<string> NonDeletedUsers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserIdentifiersList {\n");
      sb.Append("  DeletedUsers: ").Append(DeletedUsers).Append("\n");
      sb.Append("  NonDeletedUsers: ").Append(NonDeletedUsers).Append("\n");
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
