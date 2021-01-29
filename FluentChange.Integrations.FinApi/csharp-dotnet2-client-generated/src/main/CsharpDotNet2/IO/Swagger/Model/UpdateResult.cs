using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for a status of bank connection update
  /// </summary>
  [DataContract]
  public class UpdateResult {
    /// <summary>
    /// Note that 'OK' just means that finAPI could successfully connect and log in to the bank server. However, it does not necessarily mean that all accounts could be updated successfully. For the latter, please refer to the 'status' field of the Account resource.
    /// </summary>
    /// <value>Note that 'OK' just means that finAPI could successfully connect and log in to the bank server. However, it does not necessarily mean that all accounts could be updated successfully. For the latter, please refer to the 'status' field of the Account resource.</value>
    [DataMember(Name="result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "result")]
    public string Result { get; set; }

    /// <summary>
    /// In case the update result is not <code>OK</code>, this field may contain an error message with details about why the update failed (it is not guaranteed that a message is available though). In case the update result is <code>OK</code>, the field will always be null.
    /// </summary>
    /// <value>In case the update result is not <code>OK</code>, this field may contain an error message with details about why the update failed (it is not guaranteed that a message is available though). In case the update result is <code>OK</code>, the field will always be null.</value>
    [DataMember(Name="errorMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorMessage")]
    public string ErrorMessage { get; set; }

    /// <summary>
    /// In case the update result is not <code>OK</code>, this field contains the type of the error that occurred. BUSINESS means that the bank server responded with a non-technical error message for the user. TECHNICAL means that some internal error has occurred in finAPI or at the bank server.
    /// </summary>
    /// <value>In case the update result is not <code>OK</code>, this field contains the type of the error that occurred. BUSINESS means that the bank server responded with a non-technical error message for the user. TECHNICAL means that some internal error has occurred in finAPI or at the bank server.</value>
    [DataMember(Name="errorType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorType")]
    public string ErrorType { get; set; }

    /// <summary>
    /// Time of the update. The value is returned in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).
    /// </summary>
    /// <value>Time of the update. The value is returned in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public string Timestamp { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateResult {\n");
      sb.Append("  Result: ").Append(Result).Append("\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
