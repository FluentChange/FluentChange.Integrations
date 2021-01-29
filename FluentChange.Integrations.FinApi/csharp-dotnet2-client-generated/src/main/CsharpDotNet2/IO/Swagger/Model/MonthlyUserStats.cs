using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Information about a user&#39;s data or activities for a certain month
  /// </summary>
  [DataContract]
  public class MonthlyUserStats {
    /// <summary>
    /// The month that the contained information applies to, in the format 'YYYY-MM'.
    /// </summary>
    /// <value>The month that the contained information applies to, in the format 'YYYY-MM'.</value>
    [DataMember(Name="month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "month")]
    public string Month { get; set; }

    /// <summary>
    /// Minimum count of bank connections that this user has had at any point during the month.
    /// </summary>
    /// <value>Minimum count of bank connections that this user has had at any point during the month.</value>
    [DataMember(Name="minBankConnectionCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minBankConnectionCount")]
    public int? MinBankConnectionCount { get; set; }

    /// <summary>
    /// Maximum count of bank connections that this user has had at any point during the month.
    /// </summary>
    /// <value>Maximum count of bank connections that this user has had at any point during the month.</value>
    [DataMember(Name="maxBankConnectionCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxBankConnectionCount")]
    public int? MaxBankConnectionCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MonthlyUserStats {\n");
      sb.Append("  Month: ").Append(Month).Append("\n");
      sb.Append("  MinBankConnectionCount: ").Append(MinBankConnectionCount).Append("\n");
      sb.Append("  MaxBankConnectionCount: ").Append(MaxBankConnectionCount).Append("\n");
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
