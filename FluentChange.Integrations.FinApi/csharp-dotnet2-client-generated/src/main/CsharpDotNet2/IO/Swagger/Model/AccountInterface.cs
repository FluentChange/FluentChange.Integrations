using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Account interface details
  /// </summary>
  [DataContract]
  public class AccountInterface {
    /// <summary>
    /// Bank interface. Possible values:<br><br>&bull; <code>FINTS_SERVER</code> - finAPI will download account data via the bank's FinTS interface.<br>&bull; <code>WEB_SCRAPER</code> - finAPI will parse account data from the bank's online banking website.<br>&bull; <code>XS2A</code> - finAPI will download account data via the bank's XS2A interface.<br>
    /// </summary>
    /// <value>Bank interface. Possible values:<br><br>&bull; <code>FINTS_SERVER</code> - finAPI will download account data via the bank's FinTS interface.<br>&bull; <code>WEB_SCRAPER</code> - finAPI will parse account data from the bank's online banking website.<br>&bull; <code>XS2A</code> - finAPI will download account data via the bank's XS2A interface.<br></value>
    [DataMember(Name="interface", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interface")]
    public string Interface { get; set; }

    /// <summary>
    /// The current status of the account from the perspective of this interface. Possible values are:<br/>&bull; <code>UPDATED</code> means that the account is up to date from finAPI's point of view. This means that no current import/update is running, and the previous import/update had successfully updated the account's data (e.g. transactions and securities), and the bank given balance matched the transaction's calculated sum, meaning that no adjusting entry ('Zwischensaldo' transaction) was inserted.<br/>&bull; <code>UPDATED_FIXED</code> means that the account is up to date from finAPI's point of view (no current import/update is running, and the previous import/update had successfully updated the account's data), BUT there was a deviation in the bank given balance which was fixed by adding an adjusting entry ('Zwischensaldo' transaction).<br/>&bull; <code>DOWNLOAD_IN_PROGRESS</code> means that the account's data is currently being imported/updated.<br/>&bull; <code>DOWNLOAD_FAILED</code> means that the account data was not successfully imported or updated. Possible reasons: finAPI could not get the account's balance, or it could not parse all transactions/securities, or some internal error has occurred. Also, it could mean that finAPI could not even get to the point of receiving the account data from the bank server, for example because of incorrect login credentials or a network problem. Note however that when we get a balance and just an empty list of transactions or securities, then this is regarded as valid and successful download. The reason for this is that for some accounts that have little activity, we may actually get no recent transactions but only a balance.<br/>&bull; <code>DEPRECATED</code> means that the account could no longer be matched with any account from the bank server. This can mean either that the account was terminated by the user and is no longer sent by the bank server, or that finAPI could no longer match it because the account's data (name, type, iban, account number, etc.) has been changed by the bank.
    /// </summary>
    /// <value>The current status of the account from the perspective of this interface. Possible values are:<br/>&bull; <code>UPDATED</code> means that the account is up to date from finAPI's point of view. This means that no current import/update is running, and the previous import/update had successfully updated the account's data (e.g. transactions and securities), and the bank given balance matched the transaction's calculated sum, meaning that no adjusting entry ('Zwischensaldo' transaction) was inserted.<br/>&bull; <code>UPDATED_FIXED</code> means that the account is up to date from finAPI's point of view (no current import/update is running, and the previous import/update had successfully updated the account's data), BUT there was a deviation in the bank given balance which was fixed by adding an adjusting entry ('Zwischensaldo' transaction).<br/>&bull; <code>DOWNLOAD_IN_PROGRESS</code> means that the account's data is currently being imported/updated.<br/>&bull; <code>DOWNLOAD_FAILED</code> means that the account data was not successfully imported or updated. Possible reasons: finAPI could not get the account's balance, or it could not parse all transactions/securities, or some internal error has occurred. Also, it could mean that finAPI could not even get to the point of receiving the account data from the bank server, for example because of incorrect login credentials or a network problem. Note however that when we get a balance and just an empty list of transactions or securities, then this is regarded as valid and successful download. The reason for this is that for some accounts that have little activity, we may actually get no recent transactions but only a balance.<br/>&bull; <code>DEPRECATED</code> means that the account could no longer be matched with any account from the bank server. This can mean either that the account was terminated by the user and is no longer sent by the bank server, or that finAPI could no longer match it because the account's data (name, type, iban, account number, etc.) has been changed by the bank.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// List of account capabilities that this interface supports. Possible values are:<br/><br/>&bull; <code>DATA_DOWNLOAD</code> - download of balance and transactions/securities<br/>&bull; <code>IBAN_ONLY_SEPA_MONEY_TRANSFER</code> - money transfer where the recipient's account is defined just by the IBAN<br/>&bull; <code>IBAN_ONLY_SEPA_DIRECT_DEBIT</code> - direct debit where the debitor's account is defined just by the IBAN<br/>&bull; <code>SEPA_MONEY_TRANSFER</code> - single money transfer<br/>&bull; <code>SEPA_COLLECTIVE_MONEY_TRANSFER</code> - collective money transfer<br/>&bull; <code>SEPA_BASIC_DIRECT_DEBIT</code> - single basic direct debit<br/>&bull; <code>SEPA_BASIC_COLLECTIVE_DIRECT_DEBIT</code> - collective basic direct debit<br/>&bull; <code>SEPA_B2B_DIRECT_DEBIT</code> - single Business-To-Business direct debit<br/>&bull; <code>SEPA_B2B_COLLECTIVE_DIRECT_DEBIT</code> - collective Business-To-Business direct debit<br/><br/>Note that this list may be empty if the interface is not supporting any of the above capabilities. Also note that the list may be refreshed each time the account is being updated though this interface, so available capabilities may get added or removed in the course of an account update.<br/><br/>
    /// </summary>
    /// <value>List of account capabilities that this interface supports. Possible values are:<br/><br/>&bull; <code>DATA_DOWNLOAD</code> - download of balance and transactions/securities<br/>&bull; <code>IBAN_ONLY_SEPA_MONEY_TRANSFER</code> - money transfer where the recipient's account is defined just by the IBAN<br/>&bull; <code>IBAN_ONLY_SEPA_DIRECT_DEBIT</code> - direct debit where the debitor's account is defined just by the IBAN<br/>&bull; <code>SEPA_MONEY_TRANSFER</code> - single money transfer<br/>&bull; <code>SEPA_COLLECTIVE_MONEY_TRANSFER</code> - collective money transfer<br/>&bull; <code>SEPA_BASIC_DIRECT_DEBIT</code> - single basic direct debit<br/>&bull; <code>SEPA_BASIC_COLLECTIVE_DIRECT_DEBIT</code> - collective basic direct debit<br/>&bull; <code>SEPA_B2B_DIRECT_DEBIT</code> - single Business-To-Business direct debit<br/>&bull; <code>SEPA_B2B_COLLECTIVE_DIRECT_DEBIT</code> - collective Business-To-Business direct debit<br/><br/>Note that this list may be empty if the interface is not supporting any of the above capabilities. Also note that the list may be refreshed each time the account is being updated though this interface, so available capabilities may get added or removed in the course of an account update.<br/><br/></value>
    [DataMember(Name="capabilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capabilities")]
    public List<string> Capabilities { get; set; }

    /// <summary>
    /// Timestamp of when the account was last successfully updated using this interface (or initially imported); more precisely: time when the account data (balance and positions) has been stored into the finAPI databases. The value is returned in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).
    /// </summary>
    /// <value>Timestamp of when the account was last successfully updated using this interface (or initially imported); more precisely: time when the account data (balance and positions) has been stored into the finAPI databases. The value is returned in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).</value>
    [DataMember(Name="lastSuccessfulUpdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastSuccessfulUpdate")]
    public string LastSuccessfulUpdate { get; set; }

    /// <summary>
    /// Timestamp of when the account was last tried to be updated using this interface (or initially imported); more precisely: time when the update (or initial import) was triggered. The value is returned in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).
    /// </summary>
    /// <value>Timestamp of when the account was last tried to be updated using this interface (or initially imported); more precisely: time when the update (or initial import) was triggered. The value is returned in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).</value>
    [DataMember(Name="lastUpdateAttempt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdateAttempt")]
    public string LastUpdateAttempt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountInterface {\n");
      sb.Append("  Interface: ").Append(Interface).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
      sb.Append("  LastSuccessfulUpdate: ").Append(LastSuccessfulUpdate).Append("\n");
      sb.Append("  LastUpdateAttempt: ").Append(LastUpdateAttempt).Append("\n");
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
