using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Balance data for a single day
  /// </summary>
  [DataContract]
  public class DailyBalance {
    /// <summary>
    /// Date in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).
    /// </summary>
    /// <value>Date in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public string Date { get; set; }

    /// <summary>
    /// Calculated balance at the end of day (aggregation of all regarded accounts).
    /// </summary>
    /// <value>Calculated balance at the end of day (aggregation of all regarded accounts).</value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public decimal? Balance { get; set; }

    /// <summary>
    /// The sum of income of the given day (aggregation of all regarded accounts).
    /// </summary>
    /// <value>The sum of income of the given day (aggregation of all regarded accounts).</value>
    [DataMember(Name="income", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "income")]
    public decimal? Income { get; set; }

    /// <summary>
    /// The sum of spending of the given day (aggregation of all regarded accounts).
    /// </summary>
    /// <value>The sum of spending of the given day (aggregation of all regarded accounts).</value>
    [DataMember(Name="spending", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "spending")]
    public decimal? Spending { get; set; }

    /// <summary>
    /// Identifiers of the transactions for the given day
    /// </summary>
    /// <value>Identifiers of the transactions for the given day</value>
    [DataMember(Name="transactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactions")]
    public List<long?> Transactions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DailyBalance {\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  Income: ").Append(Income).Append("\n");
      sb.Append("  Spending: ").Append(Spending).Append("\n");
      sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
