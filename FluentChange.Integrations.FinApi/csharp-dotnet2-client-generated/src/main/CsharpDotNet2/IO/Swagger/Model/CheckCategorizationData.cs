using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Transactions data for categorization check
  /// </summary>
  [DataContract]
  public class CheckCategorizationData {
    /// <summary>
    /// Set of transaction data
    /// </summary>
    /// <value>Set of transaction data</value>
    [DataMember(Name="transactionData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionData")]
    public List<CheckCategorizationTransactionData> TransactionData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckCategorizationData {\n");
      sb.Append("  TransactionData: ").Append(TransactionData).Append("\n");
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
