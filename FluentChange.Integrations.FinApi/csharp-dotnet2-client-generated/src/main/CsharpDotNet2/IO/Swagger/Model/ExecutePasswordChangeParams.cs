using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Execute password change parameters
  /// </summary>
  [DataContract]
  public class ExecutePasswordChangeParams {
    /// <summary>
    /// User identifier
    /// </summary>
    /// <value>User identifier</value>
    [DataMember(Name="userId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userId")]
    public string UserId { get; set; }

    /// <summary>
    /// User's new password. Minimum length is 6, and maximum length is 128.
    /// </summary>
    /// <value>User's new password. Minimum length is 6, and maximum length is 128.</value>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    /// <summary>
    /// Decrypted password change token (the token that you received from the /users/requestPasswordChange service, decrypted with your data decryption key)
    /// </summary>
    /// <value>Decrypted password change token (the token that you received from the /users/requestPasswordChange service, decrypted with your data decryption key)</value>
    [DataMember(Name="passwordChangeToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passwordChangeToken")]
    public string PasswordChangeToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExecutePasswordChangeParams {\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
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
