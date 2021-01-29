using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for bank certificate information with paging info
  /// </summary>
  [DataContract]
  public class PageableTppCertificateList {
    /// <summary>
    /// List of certificates
    /// </summary>
    /// <value>List of certificates</value>
    [DataMember(Name="tppCertificates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tppCertificates")]
    public List<TppCertificate> TppCertificates { get; set; }

    /// <summary>
    /// Information for pagination
    /// </summary>
    /// <value>Information for pagination</value>
    [DataMember(Name="paging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paging")]
    public Paging Paging { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PageableTppCertificateList {\n");
      sb.Append("  TppCertificates: ").Append(TppCertificates).Append("\n");
      sb.Append("  Paging: ").Append(Paging).Append("\n");
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
