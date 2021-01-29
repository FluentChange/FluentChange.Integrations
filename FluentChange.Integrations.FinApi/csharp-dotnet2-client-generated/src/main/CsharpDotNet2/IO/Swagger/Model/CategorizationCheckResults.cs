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
  public class CategorizationCheckResults {
    /// <summary>
    /// List of results
    /// </summary>
    /// <value>List of results</value>
    [DataMember(Name="categorizationCheckResult", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categorizationCheckResult")]
    public List<CategorizationCheckResult> CategorizationCheckResult { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CategorizationCheckResults {\n");
      sb.Append("  CategorizationCheckResult: ").Append(CategorizationCheckResult).Append("\n");
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
