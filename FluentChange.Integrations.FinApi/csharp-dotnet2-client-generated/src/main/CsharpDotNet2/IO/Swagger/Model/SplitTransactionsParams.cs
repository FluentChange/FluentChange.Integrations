using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Set of logical sub-transactions that a transaction should get split into
  /// </summary>
  [DataContract]
  public class SplitTransactionsParams {
    /// <summary>
    /// List of sub-transactions
    /// </summary>
    /// <value>List of sub-transactions</value>
    [DataMember(Name="subTransactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subTransactions")]
    public List<SubTransactionParams> SubTransactions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SplitTransactionsParams {\n");
      sb.Append("  SubTransactions: ").Append(SubTransactions).Append("\n");
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
