using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Mock account data
  /// </summary>
  [DataContract]
  public class MockAccountData {
    /// <summary>
    /// Account identifier
    /// </summary>
    /// <value>Account identifier</value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// The balance that this account should be set to. Note that when the balance does not add up to the current balance plus the sum of the transactions you pass in the 'newTransactions' field, finAPI will fix the balance deviation with the insertion of an adjusting entry ('Zwischensaldo' transaction).
    /// </summary>
    /// <value>The balance that this account should be set to. Note that when the balance does not add up to the current balance plus the sum of the transactions you pass in the 'newTransactions' field, finAPI will fix the balance deviation with the insertion of an adjusting entry ('Zwischensaldo' transaction).</value>
    [DataMember(Name="accountBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountBalance")]
    public decimal? AccountBalance { get; set; }

    /// <summary>
    /// New transactions that should be imported into the account (maximum 1000 transactions at once). Please make sure that the value you pass in the 'accountBalance' field equals the current account balance plus the sum of the new transactions that you pass here, otherwise finAPI will detect a deviation in the balance and fix it with the insertion of an adjusting entry ('Zwischensaldo' transaction). Please also note that it is not guaranteed that all transactions that you pass here will actually get imported. More specifically, finAPI will ignore any transactions whose booking date is prior to the booking date of the latest currently existing transactions minus 10 days (which is the 'update window' that finAPI uses when importing new transactions). Also, finAPI will ignore any transactions that are considered duplicates of already existing transactions within the update window. This is the case for instance when you try to import a new transaction with the same booking date and same amount as an already existing transaction. In such cases, you might get an adjusting entry too ('Zwischensaldo' transaction), as your given balance might not add up to the transactions that will exist in the account after the update.
    /// </summary>
    /// <value>New transactions that should be imported into the account (maximum 1000 transactions at once). Please make sure that the value you pass in the 'accountBalance' field equals the current account balance plus the sum of the new transactions that you pass here, otherwise finAPI will detect a deviation in the balance and fix it with the insertion of an adjusting entry ('Zwischensaldo' transaction). Please also note that it is not guaranteed that all transactions that you pass here will actually get imported. More specifically, finAPI will ignore any transactions whose booking date is prior to the booking date of the latest currently existing transactions minus 10 days (which is the 'update window' that finAPI uses when importing new transactions). Also, finAPI will ignore any transactions that are considered duplicates of already existing transactions within the update window. This is the case for instance when you try to import a new transaction with the same booking date and same amount as an already existing transaction. In such cases, you might get an adjusting entry too ('Zwischensaldo' transaction), as your given balance might not add up to the transactions that will exist in the account after the update.</value>
    [DataMember(Name="newTransactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "newTransactions")]
    public List<NewTransaction> NewTransactions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MockAccountData {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountBalance: ").Append(AccountBalance).Append("\n");
      sb.Append("  NewTransactions: ").Append(NewTransactions).Append("\n");
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
