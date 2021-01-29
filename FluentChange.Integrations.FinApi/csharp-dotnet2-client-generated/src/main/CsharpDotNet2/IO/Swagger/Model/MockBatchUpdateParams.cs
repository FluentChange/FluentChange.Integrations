using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Data for mock bank connection updates
  /// </summary>
  [DataContract]
  public class MockBatchUpdateParams {
    /// <summary>
    /// List of mock bank connection updates
    /// </summary>
    /// <value>List of mock bank connection updates</value>
    [DataMember(Name="mockBankConnectionUpdates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mockBankConnectionUpdates")]
    public List<MockBankConnectionUpdate> MockBankConnectionUpdates { get; set; }

    /// <summary>
    /// Whether this call should trigger the dispatching of notifications. Default is 'false'.
    /// </summary>
    /// <value>Whether this call should trigger the dispatching of notifications. Default is 'false'.</value>
    [DataMember(Name="triggerNotifications", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerNotifications")]
    public bool? TriggerNotifications { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MockBatchUpdateParams {\n");
      sb.Append("  MockBankConnectionUpdates: ").Append(MockBankConnectionUpdates).Append("\n");
      sb.Append("  TriggerNotifications: ").Append(TriggerNotifications).Append("\n");
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
