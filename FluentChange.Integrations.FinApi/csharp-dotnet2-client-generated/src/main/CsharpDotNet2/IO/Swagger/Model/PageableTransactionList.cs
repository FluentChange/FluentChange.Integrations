using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for a page of transactions, with data about the total count of transactions and their balance
  /// </summary>
  [DataContract]
  public class PageableTransactionList {
    /// <summary>
    /// Array of transactions (for the requested page)
    /// </summary>
    /// <value>Array of transactions (for the requested page)</value>
    [DataMember(Name="transactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactions")]
    public List<Transaction> Transactions { get; set; }

    /// <summary>
    /// Information for pagination
    /// </summary>
    /// <value>Information for pagination</value>
    [DataMember(Name="paging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paging")]
    public Paging Paging { get; set; }

    /// <summary>
    /// The total income of all transactions (across all pages)
    /// </summary>
    /// <value>The total income of all transactions (across all pages)</value>
    [DataMember(Name="income", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "income")]
    public decimal? Income { get; set; }

    /// <summary>
    /// The total spending of all transactions (across all pages)
    /// </summary>
    /// <value>The total spending of all transactions (across all pages)</value>
    [DataMember(Name="spending", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "spending")]
    public decimal? Spending { get; set; }

    /// <summary>
    /// The total sum of all transactions (across all pages)
    /// </summary>
    /// <value>The total sum of all transactions (across all pages)</value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public decimal? Balance { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PageableTransactionList {\n");
      sb.Append("  Transactions: ").Append(Transactions).Append("\n");
      sb.Append("  Paging: ").Append(Paging).Append("\n");
      sb.Append("  Income: ").Append(Income).Append("\n");
      sb.Append("  Spending: ").Append(Spending).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
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
