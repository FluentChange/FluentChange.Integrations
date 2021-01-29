using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for a bank connection&#39;s data
  /// </summary>
  [DataContract]
  public class BankConnection {
    /// <summary>
    /// Bank connection identifier
    /// </summary>
    /// <value>Bank connection identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Custom name for the bank connection. You can set this field with the 'Edit a bank connection' service, as well as during the initial import of the bank connection. Maximum length is 64.
    /// </summary>
    /// <value>Custom name for the bank connection. You can set this field with the 'Edit a bank connection' service, as well as during the initial import of the bank connection. Maximum length is 64.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Bank connection type
    /// </summary>
    /// <value>Bank connection type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Current status of data download (account balances and transactions/securities). The POST /bankConnections/import and POST /bankConnections/<id>/update services will set this flag to IN_PROGRESS before they return. Once the import or update has finished, the status will be changed to READY.
    /// </summary>
    /// <value>Current status of data download (account balances and transactions/securities). The POST /bankConnections/import and POST /bankConnections/<id>/update services will set this flag to IN_PROGRESS before they return. Once the import or update has finished, the status will be changed to READY.</value>
    [DataMember(Name="updateStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updateStatus")]
    public string UpdateStatus { get; set; }

    /// <summary>
    /// Current status of transactions categorization. The asynchronous download process that is triggered by a call of the POST /bankConnections/import and POST /bankConnections/<id>/update services (and also by finAPI's auto update, if enabled) will set this flag to PENDING once the download has finished and a categorization is scheduled for the imported transactions. A separate categorization thread will then start to categorize the transactions (during this process, the status is IN_PROGRESS). When categorization has finished, the status will be (re-)set to READY. Note that the current categorization status should only be queried after the download has finished, i.e. once the download status has switched from IN_PROGRESS to READY.
    /// </summary>
    /// <value>Current status of transactions categorization. The asynchronous download process that is triggered by a call of the POST /bankConnections/import and POST /bankConnections/<id>/update services (and also by finAPI's auto update, if enabled) will set this flag to PENDING once the download has finished and a categorization is scheduled for the imported transactions. A separate categorization thread will then start to categorize the transactions (during this process, the status is IN_PROGRESS). When categorization has finished, the status will be (re-)set to READY. Note that the current categorization status should only be queried after the download has finished, i.e. once the download status has switched from IN_PROGRESS to READY.</value>
    [DataMember(Name="categorizationStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categorizationStatus")]
    public string CategorizationStatus { get; set; }

    /// <summary>
    /// Set of interfaces that are connected for this bank connection.
    /// </summary>
    /// <value>Set of interfaces that are connected for this bank connection.</value>
    [DataMember(Name="interfaces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interfaces")]
    public List<BankConnectionInterface> Interfaces { get; set; }

    /// <summary>
    /// Identifiers of the accounts that belong to this bank connection
    /// </summary>
    /// <value>Identifiers of the accounts that belong to this bank connection</value>
    [DataMember(Name="accountIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountIds")]
    public List<long?> AccountIds { get; set; }

    /// <summary>
    /// Information about the owner(s) of the bank connection
    /// </summary>
    /// <value>Information about the owner(s) of the bank connection</value>
    [DataMember(Name="owners", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owners")]
    public List<BankConnectionOwner> Owners { get; set; }

    /// <summary>
    /// Bank that this connection belongs to
    /// </summary>
    /// <value>Bank that this connection belongs to</value>
    [DataMember(Name="bank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bank")]
    public Bank Bank { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BankConnection {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  UpdateStatus: ").Append(UpdateStatus).Append("\n");
      sb.Append("  CategorizationStatus: ").Append(CategorizationStatus).Append("\n");
      sb.Append("  Interfaces: ").Append(Interfaces).Append("\n");
      sb.Append("  AccountIds: ").Append(AccountIds).Append("\n");
      sb.Append("  Owners: ").Append(Owners).Append("\n");
      sb.Append("  Bank: ").Append(Bank).Append("\n");
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
