using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for pagination information
  /// </summary>
  [DataContract]
  public class Paging {
    /// <summary>
    /// Current page number
    /// </summary>
    /// <value>Current page number</value>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public int? Page { get; set; }

    /// <summary>
    /// Current page size (number of entries in this page)
    /// </summary>
    /// <value>Current page size (number of entries in this page)</value>
    [DataMember(Name="perPage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perPage")]
    public int? PerPage { get; set; }

    /// <summary>
    /// Total number of pages
    /// </summary>
    /// <value>Total number of pages</value>
    [DataMember(Name="pageCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageCount")]
    public int? PageCount { get; set; }

    /// <summary>
    /// Total number of entries across all pages
    /// </summary>
    /// <value>Total number of entries across all pages</value>
    [DataMember(Name="totalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCount")]
    public long? TotalCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Paging {\n");
      sb.Append("  Page: ").Append(Page).Append("\n");
      sb.Append("  PerPage: ").Append(PerPage).Append("\n");
      sb.Append("  PageCount: ").Append(PageCount).Append("\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
