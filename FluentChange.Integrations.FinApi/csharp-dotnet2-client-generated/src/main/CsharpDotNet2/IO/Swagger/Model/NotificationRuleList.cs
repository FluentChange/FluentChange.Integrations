using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for notification rules
  /// </summary>
  [DataContract]
  public class NotificationRuleList {
    /// <summary>
    /// List of notification rules
    /// </summary>
    /// <value>List of notification rules</value>
    [DataMember(Name="notificationRules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notificationRules")]
    public List<NotificationRule> NotificationRules { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NotificationRuleList {\n");
      sb.Append("  NotificationRules: ").Append(NotificationRules).Append("\n");
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
