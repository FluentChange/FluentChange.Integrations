using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Update transactions parameters
  /// </summary>
  [DataContract]
  public class UpdateTransactionsParams {
    /// <summary>
    /// Whether this transactions should be flagged as 'new' or not. Any newly imported transaction will have this flag initially set to true. How you use this field is up to your interpretation. For example, you might want to set it to false once a user has clicked on/seen the transaction.
    /// </summary>
    /// <value>Whether this transactions should be flagged as 'new' or not. Any newly imported transaction will have this flag initially set to true. How you use this field is up to your interpretation. For example, you might want to set it to false once a user has clicked on/seen the transaction.</value>
    [DataMember(Name="isNew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isNew")]
    public bool? IsNew { get; set; }

    /// <summary>
    /// You can set this field only to 'false'. finAPI marks transactions as a potential duplicates  when its internal duplicate detection algorithm is signaling so. Transactions that are flagged as duplicates can be deleted by the user. To prevent the user from deleting original transactions, which might lead to incorrect balances, it is not possible to manually set this flag to 'true'.
    /// </summary>
    /// <value>You can set this field only to 'false'. finAPI marks transactions as a potential duplicates  when its internal duplicate detection algorithm is signaling so. Transactions that are flagged as duplicates can be deleted by the user. To prevent the user from deleting original transactions, which might lead to incorrect balances, it is not possible to manually set this flag to 'true'.</value>
    [DataMember(Name="isPotentialDuplicate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPotentialDuplicate")]
    public bool? IsPotentialDuplicate { get; set; }

    /// <summary>
    /// Identifier of the new category to apply to the transaction. When updating the transaction's category, the category's fields 'id', 'name', 'parentId', 'parentName', and 'isCustom' will all get updated. To clear the category for the transaction, the categoryId field must be passed with value 0.
    /// </summary>
    /// <value>Identifier of the new category to apply to the transaction. When updating the transaction's category, the category's fields 'id', 'name', 'parentId', 'parentName', and 'isCustom' will all get updated. To clear the category for the transaction, the categoryId field must be passed with value 0.</value>
    [DataMember(Name="categoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryId")]
    public long? CategoryId { get; set; }

    /// <summary>
    /// This field is only regarded when the field 'categoryId' is set. It controls whether finAPI's categorization system should learn from the given categorization(s). If set to 'true', then the user's categorization rules will be updated so that similar transactions will get categorized accordingly in future. If set to 'false', then the service will simply change the category of the given transaction(s), without updating the user's categorization rules. The field defaults to 'true' if not specified.
    /// </summary>
    /// <value>This field is only regarded when the field 'categoryId' is set. It controls whether finAPI's categorization system should learn from the given categorization(s). If set to 'true', then the user's categorization rules will be updated so that similar transactions will get categorized accordingly in future. If set to 'false', then the service will simply change the category of the given transaction(s), without updating the user's categorization rules. The field defaults to 'true' if not specified.</value>
    [DataMember(Name="trainCategorization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trainCategorization")]
    public bool? TrainCategorization { get; set; }

    /// <summary>
    /// Identifiers of labels to apply to the transaction. To clear transactions' labels, pass an empty array of identifiers: '[]'
    /// </summary>
    /// <value>Identifiers of labels to apply to the transaction. To clear transactions' labels, pass an empty array of identifiers: '[]'</value>
    [DataMember(Name="labelIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labelIds")]
    public List<long?> LabelIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateTransactionsParams {\n");
      sb.Append("  IsNew: ").Append(IsNew).Append("\n");
      sb.Append("  IsPotentialDuplicate: ").Append(IsPotentialDuplicate).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  TrainCategorization: ").Append(TrainCategorization).Append("\n");
      sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
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
