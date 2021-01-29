using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Trigger categorization parameters
  /// </summary>
  [DataContract]
  public class TriggerCategorizationParams {
    /// <summary>
    /// List of identifiers of the bank connections that you want to trigger categorization for. Leaving the list unset or empty will trigger categorization for all of the user's bank connections. Please note that if there are no bank connections, then the service will return with HTTP code 422.
    /// </summary>
    /// <value>List of identifiers of the bank connections that you want to trigger categorization for. Leaving the list unset or empty will trigger categorization for all of the user's bank connections. Please note that if there are no bank connections, then the service will return with HTTP code 422.</value>
    [DataMember(Name="bankConnectionIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankConnectionIds")]
    public List<long?> BankConnectionIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TriggerCategorizationParams {\n");
      sb.Append("  BankConnectionIds: ").Append(BankConnectionIds).Append("\n");
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
