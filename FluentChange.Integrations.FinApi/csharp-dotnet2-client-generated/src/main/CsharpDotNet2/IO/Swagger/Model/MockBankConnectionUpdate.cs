using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Data for a mock bank connection update
  /// </summary>
  [DataContract]
  public class MockBankConnectionUpdate {
    /// <summary>
    /// Bank connection identifier
    /// </summary>
    /// <value>Bank connection identifier</value>
    [DataMember(Name="bankConnectionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankConnectionId")]
    public long? BankConnectionId { get; set; }

    /// <summary>
    /// Banking interface to update. If not specified, then first available interface in bank connection will be used.
    /// </summary>
    /// <value>Banking interface to update. If not specified, then first available interface in bank connection will be used.</value>
    [DataMember(Name="interface", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interface")]
    public string Interface { get; set; }

    /// <summary>
    /// Whether to simulate the case that the update fails due to incorrect banking credentials. Note that there is no real communication to any bank server involved, so you won't lock your accounts when enabling this flag. Default value is 'false'.
    /// </summary>
    /// <value>Whether to simulate the case that the update fails due to incorrect banking credentials. Note that there is no real communication to any bank server involved, so you won't lock your accounts when enabling this flag. Default value is 'false'.</value>
    [DataMember(Name="simulateBankLoginError", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "simulateBankLoginError")]
    public bool? SimulateBankLoginError { get; set; }

    /// <summary>
    /// Mock accounts data. Note that for accounts that exist in a bank connection but that you do not specify in this list, the service will act like those accounts are not received by the bank servers. This means that any accounts that you do not specify here will be marked as deprecated. If you do not specify this list at all, all accounts in the bank connection will be marked as deprecated.
    /// </summary>
    /// <value>Mock accounts data. Note that for accounts that exist in a bank connection but that you do not specify in this list, the service will act like those accounts are not received by the bank servers. This means that any accounts that you do not specify here will be marked as deprecated. If you do not specify this list at all, all accounts in the bank connection will be marked as deprecated.</value>
    [DataMember(Name="mockAccountsData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mockAccountsData")]
    public List<MockAccountData> MockAccountsData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MockBankConnectionUpdate {\n");
      sb.Append("  BankConnectionId: ").Append(BankConnectionId).Append("\n");
      sb.Append("  Interface: ").Append(Interface).Append("\n");
      sb.Append("  SimulateBankLoginError: ").Append(SimulateBankLoginError).Append("\n");
      sb.Append("  MockAccountsData: ").Append(MockAccountsData).Append("\n");
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
