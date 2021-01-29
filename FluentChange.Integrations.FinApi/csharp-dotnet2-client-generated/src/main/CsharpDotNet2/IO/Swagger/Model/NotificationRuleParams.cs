using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Parameters of notification rule
  /// </summary>
  [DataContract]
  public class NotificationRuleParams {
    /// <summary>
    /// Trigger event type
    /// </summary>
    /// <value>Trigger event type</value>
    [DataMember(Name="triggerEvent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerEvent")]
    public string TriggerEvent { get; set; }

    /// <summary>
    /// Additional parameters that are specific to the chosen trigger event type. Please refer to the documentation for details.
    /// </summary>
    /// <value>Additional parameters that are specific to the chosen trigger event type. Please refer to the documentation for details.</value>
    [DataMember(Name="params", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "params")]
    public Dictionary<string, string> Params { get; set; }

    /// <summary>
    /// An arbitrary string that finAPI will include into the notifications that it sends based on this rule and that you can use to identify the notification in your application. For instance, you could include the identifier of the user that you create this rule for. Maximum allowed length of the string is 512 characters.<br/><br/>Note that for this parameter, you can pass the symbols '/', '=', '%' and '\"' in addition to the symbols that are generally allowed in finAPI (see https://finapi.zendesk.com/hc/en-us/articles/222013148). This was done to enable you to set Base64 encoded strings and JSON structures for the callback handle.
    /// </summary>
    /// <value>An arbitrary string that finAPI will include into the notifications that it sends based on this rule and that you can use to identify the notification in your application. For instance, you could include the identifier of the user that you create this rule for. Maximum allowed length of the string is 512 characters.<br/><br/>Note that for this parameter, you can pass the symbols '/', '=', '%' and '\"' in addition to the symbols that are generally allowed in finAPI (see https://finapi.zendesk.com/hc/en-us/articles/222013148). This was done to enable you to set Base64 encoded strings and JSON structures for the callback handle.</value>
    [DataMember(Name="callbackHandle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callbackHandle")]
    public string CallbackHandle { get; set; }

    /// <summary>
    /// Whether the notification messages that will be sent based on this rule should contain encrypted detailed data or not
    /// </summary>
    /// <value>Whether the notification messages that will be sent based on this rule should contain encrypted detailed data or not</value>
    [DataMember(Name="includeDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeDetails")]
    public bool? IncludeDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NotificationRuleParams {\n");
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
