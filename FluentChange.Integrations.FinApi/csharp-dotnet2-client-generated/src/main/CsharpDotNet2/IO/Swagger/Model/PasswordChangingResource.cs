using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Password changing details
  /// </summary>
  [DataContract]
  public class PasswordChangingResource {
    /// <summary>
    /// User identifier
    /// </summary>
    /// <value>User identifier</value>
    [DataMember(Name="userId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userId")]
    public string UserId { get; set; }

    /// <summary>
    /// User's email, encrypted. Decrypt with your data decryption key. If the user has no email set, then this field will be null.
    /// </summary>
    /// <value>User's email, encrypted. Decrypt with your data decryption key. If the user has no email set, then this field will be null.</value>
    [DataMember(Name="userEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userEmail")]
    public string UserEmail { get; set; }

    /// <summary>
    /// Encrypted password change token. Decrypt this token with your data decryption key, and pass the decrypted token to the /users/executePasswordChange service in order to set a new password for the user.
    /// </summary>
    /// <value>Encrypted password change token. Decrypt this token with your data decryption key, and pass the decrypted token to the /users/executePasswordChange service in order to set a new password for the user.</value>
    [DataMember(Name="passwordChangeToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passwordChangeToken")]
    public string PasswordChangeToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PasswordChangingResource {\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
      sb.Append("  PasswordChangeToken: ").Append(PasswordChangeToken).Append("\n");
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
