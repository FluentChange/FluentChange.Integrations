using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// User access token info
  /// </summary>
  [DataContract]
  public class AccessToken {
    /// <summary>
    /// Token type (it's always 'bearer')
    /// </summary>
    /// <value>Token type (it's always 'bearer')</value>
    [DataMember(Name="token_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token_type")]
    public string TokenType { get; set; }

    /// <summary>
    /// Expiration time in seconds. A value of 0 means that the token never expires (unless it is explicitly invalidated, e.g. by revocation, or when a user gets locked).
    /// </summary>
    /// <value>Expiration time in seconds. A value of 0 means that the token never expires (unless it is explicitly invalidated, e.g. by revocation, or when a user gets locked).</value>
    [DataMember(Name="expires_in", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expires_in")]
    public int? ExpiresIn { get; set; }

    /// <summary>
    /// Requested scopes (it's always 'all')
    /// </summary>
    /// <value>Requested scopes (it's always 'all')</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public string Scope { get; set; }

    /// <summary>
    /// Refresh token. Only set in case of grant_type='password'. Token has a length of up to 128 characters.
    /// </summary>
    /// <value>Refresh token. Only set in case of grant_type='password'. Token has a length of up to 128 characters.</value>
    [DataMember(Name="refresh_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refresh_token")]
    public string RefreshToken { get; set; }

    /// <summary>
    /// Access token. Token has a length of up to 128 characters.
    /// </summary>
    /// <value>Access token. Token has a length of up to 128 characters.</value>
    [DataMember(Name="access_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_token")]
    public string _AccessToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessToken {\n");
      sb.Append("  TokenType: ").Append(TokenType).Append("\n");
      sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
      sb.Append("  _AccessToken: ").Append(_AccessToken).Append("\n");
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
