using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for a result of the consent deleting
  /// </summary>
  [DataContract]
  public class DeleteConsent {
    /// <summary>
    /// Result of deleting a consent stored in the finAPI database (local):<br/><br/>&bull; <code>DELETED</code> - when there was a stored consent and it was deleted.<br/>&bull; <code>NOT_EXIST</code> - if there is no stored consent.<br/>
    /// </summary>
    /// <value>Result of deleting a consent stored in the finAPI database (local):<br/><br/>&bull; <code>DELETED</code> - when there was a stored consent and it was deleted.<br/>&bull; <code>NOT_EXIST</code> - if there is no stored consent.<br/></value>
    [DataMember(Name="local", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "local")]
    public string Local { get; set; }

    /// <summary>
    /// Result of deleting a consent stored on the bank's side (remote):<br/><br/>&bull; <code>DELETED</code> - if the consent was successfully deleted on the bank side.<br/>&bull; <code>NOT_SUPPORTED</code> - if the bank doesn't support the feature of deleting consents.<br/>&bull; <code>NOT_EXIST</code> - if either there is no remote consent, or there is no local consent (and that makes impossible to identify any remote data).<br/>
    /// </summary>
    /// <value>Result of deleting a consent stored on the bank's side (remote):<br/><br/>&bull; <code>DELETED</code> - if the consent was successfully deleted on the bank side.<br/>&bull; <code>NOT_SUPPORTED</code> - if the bank doesn't support the feature of deleting consents.<br/>&bull; <code>NOT_EXIST</code> - if either there is no remote consent, or there is no local consent (and that makes impossible to identify any remote data).<br/></value>
    [DataMember(Name="remote", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remote")]
    public string Remote { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeleteConsent {\n");
      sb.Append("  Local: ").Append(Local).Append("\n");
      sb.Append("  Remote: ").Append(Remote).Append("\n");
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
