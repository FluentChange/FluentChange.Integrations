using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Cash flow
  /// </summary>
  [DataContract]
  public class CashFlow {
    /// <summary>
    /// Category of this cash flow. When null, then this is the cash flow of transactions that do not have a category.
    /// </summary>
    /// <value>Category of this cash flow. When null, then this is the cash flow of transactions that do not have a category.</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public Category Category { get; set; }

    /// <summary>
    /// The total calculated income for the given category
    /// </summary>
    /// <value>The total calculated income for the given category</value>
    [DataMember(Name="income", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "income")]
    public decimal? Income { get; set; }

    /// <summary>
    /// The total calculated spending for the given category
    /// </summary>
    /// <value>The total calculated spending for the given category</value>
    [DataMember(Name="spending", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "spending")]
    public decimal? Spending { get; set; }

    /// <summary>
    /// The calculated balance for the given category
    /// </summary>
    /// <value>The calculated balance for the given category</value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public decimal? Balance { get; set; }

    /// <summary>
    /// The total count of income transactions for the given category
    /// </summary>
    /// <value>The total count of income transactions for the given category</value>
    [DataMember(Name="countIncomeTransactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countIncomeTransactions")]
    public int? CountIncomeTransactions { get; set; }

    /// <summary>
    /// The total count of spending transactions for the given category
    /// </summary>
    /// <value>The total count of spending transactions for the given category</value>
    [DataMember(Name="countSpendingTransactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countSpendingTransactions")]
    public int? CountSpendingTransactions { get; set; }

    /// <summary>
    /// The total count of all transactions for the given category
    /// </summary>
    /// <value>The total count of all transactions for the given category</value>
    [DataMember(Name="countAllTransactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countAllTransactions")]
    public int? CountAllTransactions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CashFlow {\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Income: ").Append(Income).Append("\n");
      sb.Append("  Spending: ").Append(Spending).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  CountIncomeTransactions: ").Append(CountIncomeTransactions).Append("\n");
      sb.Append("  CountSpendingTransactions: ").Append(CountSpendingTransactions).Append("\n");
      sb.Append("  CountAllTransactions: ").Append(CountAllTransactions).Append("\n");
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
