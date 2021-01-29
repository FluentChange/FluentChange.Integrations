using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for data of multiple bank accounts
  /// </summary>
  [DataContract]
  public class AccountList {
    /// <summary>
    /// List of bank accounts
    /// </summary>
    /// <value>List of bank accounts</value>
    [DataMember(Name="accounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accounts")]
    public List<Account> Accounts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountList {\n");
      sb.Append("  Accounts: ").Append(Accounts).Append("\n");
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
