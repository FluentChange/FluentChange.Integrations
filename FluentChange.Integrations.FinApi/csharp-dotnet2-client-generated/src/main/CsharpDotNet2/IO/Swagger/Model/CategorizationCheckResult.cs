using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CategorizationCheckResult {
    /// <summary>
    /// The transaction identifier. The transactionId of the transaction that was passed to the service as input. This is not an actual ID of a stored transaction in finAPI, as the checkCategorization service doesn't store any data.
    /// </summary>
    /// <value>The transaction identifier. The transactionId of the transaction that was passed to the service as input. This is not an actual ID of a stored transaction in finAPI, as the checkCategorization service doesn't store any data.</value>
    [DataMember(Name="transactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionId")]
    public string TransactionId { get; set; }

    /// <summary>
    /// A category. The determined transaction category for the given transactionId. This can be null, if the categorization algorithm fails to find a matching rule.
    /// </summary>
    /// <value>A category. The determined transaction category for the given transactionId. This can be null, if the categorization algorithm fails to find a matching rule.</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public Category Category { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CategorizationCheckResult {\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
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
