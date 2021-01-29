using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Bank consent information
  /// </summary>
  [DataContract]
  public class BankConsent {
    /// <summary>
    /// Status of the consent. If <code>PRESENT</code>, it means that finAPI has a consent stored and can use it to connect to the bank. If <code>NOT_PRESENT</code>, finAPI will need to acquire a consent when connecting to the bank, which may require login credentials (either passed by the client, or stored in finAPI), and/or user involvement. Note that even when a consent is <code>PRESENT</code>, it may no longer be valid and finAPI will still have to acquire a new consent.
    /// </summary>
    /// <value>Status of the consent. If <code>PRESENT</code>, it means that finAPI has a consent stored and can use it to connect to the bank. If <code>NOT_PRESENT</code>, finAPI will need to acquire a consent when connecting to the bank, which may require login credentials (either passed by the client, or stored in finAPI), and/or user involvement. Note that even when a consent is <code>PRESENT</code>, it may no longer be valid and finAPI will still have to acquire a new consent.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Expiration time of the consent in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).
    /// </summary>
    /// <value>Expiration time of the consent in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).</value>
    [DataMember(Name="expiresAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiresAt")]
    public string ExpiresAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BankConsent {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
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
