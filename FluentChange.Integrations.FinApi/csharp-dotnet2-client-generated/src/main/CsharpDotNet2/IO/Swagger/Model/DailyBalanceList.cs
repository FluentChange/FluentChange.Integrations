using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Contains a list of daily balances
  /// </summary>
  [DataContract]
  public class DailyBalanceList {
    /// <summary>
    /// The latestCommonBalanceTimestamp is the latest timestamp at which all regarded  accounts have been up to date. Only balances with their date being smaller than the latestCommonBalanceTimestamp are reliable. Example: A user has two accounts: A (last update today, so balance from today) and B (last update yesterday, so balance from yesterday). The service /accounts/dailyBalances will return a balance for yesterday and for today, with the info latestCommonBalanceTimestamp=yesterday. Since account B might have received transactions this morning, today's balance might be wrong. So either make sure that all regarded accounts are up to date before calling this service, or use the results carefully in combination with the latestCommonBalanceTimestamp. The format is 'YYYY-MM-DD HH:MM:SS.SSS' (german time).
    /// </summary>
    /// <value>The latestCommonBalanceTimestamp is the latest timestamp at which all regarded  accounts have been up to date. Only balances with their date being smaller than the latestCommonBalanceTimestamp are reliable. Example: A user has two accounts: A (last update today, so balance from today) and B (last update yesterday, so balance from yesterday). The service /accounts/dailyBalances will return a balance for yesterday and for today, with the info latestCommonBalanceTimestamp=yesterday. Since account B might have received transactions this morning, today's balance might be wrong. So either make sure that all regarded accounts are up to date before calling this service, or use the results carefully in combination with the latestCommonBalanceTimestamp. The format is 'YYYY-MM-DD HH:MM:SS.SSS' (german time).</value>
    [DataMember(Name="latestCommonBalanceTimestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latestCommonBalanceTimestamp")]
    public string LatestCommonBalanceTimestamp { get; set; }

    /// <summary>
    /// List of daily balances for the requested period and account(s)
    /// </summary>
    /// <value>List of daily balances for the requested period and account(s)</value>
    [DataMember(Name="dailyBalances", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dailyBalances")]
    public List<DailyBalance> DailyBalances { get; set; }

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
      sb.Append("class DailyBalanceList {\n");
      sb.Append("  LatestCommonBalanceTimestamp: ").Append(LatestCommonBalanceTimestamp).Append("\n");
      sb.Append("  DailyBalances: ").Append(DailyBalances).Append("\n");
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
