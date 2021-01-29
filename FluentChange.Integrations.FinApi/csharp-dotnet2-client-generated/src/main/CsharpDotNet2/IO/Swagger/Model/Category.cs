using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Category data
  /// </summary>
  [DataContract]
  public class Category {
    /// <summary>
    /// Category identifier.<br/><br/>NOTE: Do NOT assume that the identifiers of the global finAPI categories are the same across different finAPI environments. In fact, the identifiers may change whenever a new finAPI version is released, even within the same environment. The identifiers are meant to be used for references within the finAPI services only, but not for hard-coding them in your application. If you need to hard-code the usage of a certain global category within your application, please instead refer to the category name. Also, please make sure to check the 'isCustom' flag, which is false for all global categories (if you are not regarding this flag, you might end up referring to a user-specific category, and not the global category).
    /// </summary>
    /// <value>Category identifier.<br/><br/>NOTE: Do NOT assume that the identifiers of the global finAPI categories are the same across different finAPI environments. In fact, the identifiers may change whenever a new finAPI version is released, even within the same environment. The identifiers are meant to be used for references within the finAPI services only, but not for hard-coding them in your application. If you need to hard-code the usage of a certain global category within your application, please instead refer to the category name. Also, please make sure to check the 'isCustom' flag, which is false for all global categories (if you are not regarding this flag, you might end up referring to a user-specific category, and not the global category).</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Category name
    /// </summary>
    /// <value>Category name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Identifier of the parent category (if a parent category exists)
    /// </summary>
    /// <value>Identifier of the parent category (if a parent category exists)</value>
    [DataMember(Name="parentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentId")]
    public long? ParentId { get; set; }

    /// <summary>
    /// Name of the parent category (if a parent category exists)
    /// </summary>
    /// <value>Name of the parent category (if a parent category exists)</value>
    [DataMember(Name="parentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentName")]
    public string ParentName { get; set; }

    /// <summary>
    /// Whether the category is a finAPI global category (in which case this field will be false), or the category was created by a user (in which case this field will be true)
    /// </summary>
    /// <value>Whether the category is a finAPI global category (in which case this field will be false), or the category was created by a user (in which case this field will be true)</value>
    [DataMember(Name="isCustom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isCustom")]
    public bool? IsCustom { get; set; }

    /// <summary>
    /// List of sub-categories identifiers (if any exist)
    /// </summary>
    /// <value>List of sub-categories identifiers (if any exist)</value>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public List<long?> Children { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Category {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      sb.Append("  ParentName: ").Append(ParentName).Append("\n");
      sb.Append("  IsCustom: ").Append(IsCustom).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
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
