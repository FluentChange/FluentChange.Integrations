using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Cash flows
  /// </summary>
  [DataContract]
  public class CashFlowList {
    /// <summary>
    /// Array of cash flows
    /// </summary>
    /// <value>Array of cash flows</value>
    [DataMember(Name="cashFlows", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cashFlows")]
    public List<CashFlow> CashFlows { get; set; }

    /// <summary>
    /// The total income
    /// </summary>
    /// <value>The total income</value>
    [DataMember(Name="totalIncome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalIncome")]
    public decimal? TotalIncome { get; set; }

    /// <summary>
    /// The total spending
    /// </summary>
    /// <value>The total spending</value>
    [DataMember(Name="totalSpending", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalSpending")]
    public decimal? TotalSpending { get; set; }

    /// <summary>
    /// The total balance
    /// </summary>
    /// <value>The total balance</value>
    [DataMember(Name="totalBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalBalance")]
    public decimal? TotalBalance { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CashFlowList {\n");
      sb.Append("  CashFlows: ").Append(CashFlows).Append("\n");
      sb.Append("  TotalIncome: ").Append(TotalIncome).Append("\n");
      sb.Append("  TotalSpending: ").Append(TotalSpending).Append("\n");
      sb.Append("  TotalBalance: ").Append(TotalBalance).Append("\n");
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
