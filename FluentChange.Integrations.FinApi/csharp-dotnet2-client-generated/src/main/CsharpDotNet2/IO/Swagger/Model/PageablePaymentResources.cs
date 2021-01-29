using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Payment resources with paging information
  /// </summary>
  [DataContract]
  public class PageablePaymentResources {
    /// <summary>
    /// List of received account payments
    /// </summary>
    /// <value>List of received account payments</value>
    [DataMember(Name="payments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payments")]
    public List<Payment> Payments { get; set; }

    /// <summary>
    /// Information for pagination
    /// </summary>
    /// <value>Information for pagination</value>
    [DataMember(Name="paging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paging")]
    public Paging Paging { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PageablePaymentResources {\n");
      sb.Append("  Payments: ").Append(Payments).Append("\n");
      sb.Append("  Paging: ").Append(Paging).Append("\n");
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
