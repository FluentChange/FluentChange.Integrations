using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Sample data to train categorization
  /// </summary>
  [DataContract]
  public class TrainCategorizationData {
    /// <summary>
    /// Set of transaction data (at most 100 transactions at once)
    /// </summary>
    /// <value>Set of transaction data (at most 100 transactions at once)</value>
    [DataMember(Name="transactionData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionData")]
    public List<TrainCategorizationTransactionData> TransactionData { get; set; }

    /// <summary>
    /// Category identifier
    /// </summary>
    /// <value>Category identifier</value>
    [DataMember(Name="categoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryId")]
    public long? CategoryId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TrainCategorizationData {\n");
      sb.Append("  TransactionData: ").Append(TransactionData).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
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
