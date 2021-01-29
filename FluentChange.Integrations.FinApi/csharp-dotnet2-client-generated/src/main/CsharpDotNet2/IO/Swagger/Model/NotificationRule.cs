using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Data of notification rule
  /// </summary>
  [DataContract]
  public class NotificationRule {
    /// <summary>
    /// Notification rule identifier
    /// </summary>
    /// <value>Notification rule identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Trigger event type
    /// </summary>
    /// <value>Trigger event type</value>
    [DataMember(Name="triggerEvent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerEvent")]
    public string TriggerEvent { get; set; }

    /// <summary>
    /// Additional parameters that are specific to the trigger event type. Please refer to the documentation for details.
    /// </summary>
    /// <value>Additional parameters that are specific to the trigger event type. Please refer to the documentation for details.</value>
    [DataMember(Name="params", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "params")]
    public Dictionary<string, string> Params { get; set; }

    /// <summary>
    /// The string that finAPI includes into the notifications that it sends based on this rule.
    /// </summary>
    /// <value>The string that finAPI includes into the notifications that it sends based on this rule.</value>
    [DataMember(Name="callbackHandle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callbackHandle")]
    public string CallbackHandle { get; set; }

    /// <summary>
    /// Whether the notification messages that will be sent based on this rule contain encrypted detailed data or not
    /// </summary>
    /// <value>Whether the notification messages that will be sent based on this rule contain encrypted detailed data or not</value>
    [DataMember(Name="includeDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeDetails")]
    public bool? IncludeDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NotificationRule {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  TriggerEvent: ").Append(TriggerEvent).Append("\n");
      sb.Append("  Params: ").Append(Params).Append("\n");
      sb.Append("  CallbackHandle: ").Append(CallbackHandle).Append("\n");
      sb.Append("  IncludeDetails: ").Append(IncludeDetails).Append("\n");
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
