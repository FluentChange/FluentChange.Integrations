using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Category parameters
  /// </summary>
  [DataContract]
  public class CategoryParams {
    /// <summary>
    /// Name of the category. Maximum length is 128.
    /// </summary>
    /// <value>Name of the category. Maximum length is 128.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Identifier of the parent category, if the new category should be created as a sub-category. Must point to a main category in this case. If the new category should be a main category itself, this field must remain unset.
    /// </summary>
    /// <value>Identifier of the parent category, if the new category should be created as a sub-category. Must point to a main category in this case. If the new category should be a main category itself, this field must remain unset.</value>
    [DataMember(Name="parentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentId")]
    public long? ParentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CategoryParams {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
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
