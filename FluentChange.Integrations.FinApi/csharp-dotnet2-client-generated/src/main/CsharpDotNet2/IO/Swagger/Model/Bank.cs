using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for a bank&#39;s data
  /// </summary>
  [DataContract]
  public class Bank {
    /// <summary>
    /// Bank identifier.<br/><br/>NOTE: Do NOT assume that the identifiers of banks are the same across different finAPI environments. In fact, the identifiers may change whenever a new finAPI version is released, even within the same environment. The identifiers are meant to be used for references within the finAPI services only, but not for hard-coding them in your application. If you need to hard-code the usage of a certain bank within your application, please instead refer to the BLZ.
    /// </summary>
    /// <value>Bank identifier.<br/><br/>NOTE: Do NOT assume that the identifiers of banks are the same across different finAPI environments. In fact, the identifiers may change whenever a new finAPI version is released, even within the same environment. The identifiers are meant to be used for references within the finAPI services only, but not for hard-coding them in your application. If you need to hard-code the usage of a certain bank within your application, please instead refer to the BLZ.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Name of bank
    /// </summary>
    /// <value>Name of bank</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// BIC of bank
    /// </summary>
    /// <value>BIC of bank</value>
    [DataMember(Name="bic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bic")]
    public string Bic { get; set; }

    /// <summary>
    /// BLZ of bank
    /// </summary>
    /// <value>BLZ of bank</value>
    [DataMember(Name="blz", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blz")]
    public string Blz { get; set; }

    /// <summary>
    /// Bank location (two-letter country code; ISO 3166 ALPHA-2). Note that when this field is not set, it means that this bank depicts an international institute which is not bound to any specific country.
    /// </summary>
    /// <value>Bank location (two-letter country code; ISO 3166 ALPHA-2). Note that when this field is not set, it means that this bank depicts an international institute which is not bound to any specific country.</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// City that this bank is located in. Note that this field may not be set for some banks.
    /// </summary>
    /// <value>City that this bank is located in. Note that this field may not be set for some banks.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// If true, then this bank does not depict a real bank, but rather a testing endpoint provided by a bank or by finAPI. You probably want to regard these banks only during the development of your application, but not in production. You can filter out these banks in production by making sure that the 'isTestBank' parameter is always set to 'false' whenever your application is calling the 'Get and search all banks' service.
    /// </summary>
    /// <value>If true, then this bank does not depict a real bank, but rather a testing endpoint provided by a bank or by finAPI. You probably want to regard these banks only during the development of your application, but not in production. You can filter out these banks in production by making sure that the 'isTestBank' parameter is always set to 'false' whenever your application is calling the 'Get and search all banks' service.</value>
    [DataMember(Name="isTestBank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isTestBank")]
    public bool? IsTestBank { get; set; }

    /// <summary>
    /// Popularity of this bank with your users (mandator-wide, i.e. across all of your clients). The value equals the number of bank connections that are currently imported for this bank across all of your users (which means it is a constantly adjusting value). You can use this field for statistical evaluation, and also for ordering bank search results (see service 'Get and search all banks').
    /// </summary>
    /// <value>Popularity of this bank with your users (mandator-wide, i.e. across all of your clients). The value equals the number of bank connections that are currently imported for this bank across all of your users (which means it is a constantly adjusting value). You can use this field for statistical evaluation, and also for ordering bank search results (see service 'Get and search all banks').</value>
    [DataMember(Name="popularity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "popularity")]
    public int? Popularity { get; set; }

    /// <summary>
    /// Set of interfaces that finAPI can use to connect to the bank. Note that this set will be empty for non-supported banks. Note also that the WEB_SCRAPER interface might be disabled for your client (see GET /clientConfiguration). When this is the case, then finAPI will not use the web scraper for data download, and if the web scraper is the only supported interface of this bank, then finAPI will not allow to download any data for this bank at all (for details, see POST /bankConnections/import and POST /bankConnections/update).
    /// </summary>
    /// <value>Set of interfaces that finAPI can use to connect to the bank. Note that this set will be empty for non-supported banks. Note also that the WEB_SCRAPER interface might be disabled for your client (see GET /clientConfiguration). When this is the case, then finAPI will not use the web scraper for data download, and if the web scraper is the only supported interface of this bank, then finAPI will not allow to download any data for this bank at all (for details, see POST /bankConnections/import and POST /bankConnections/update).</value>
    [DataMember(Name="interfaces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interfaces")]
    public List<BankInterface> Interfaces { get; set; }

    /// <summary>
    /// Bank group
    /// </summary>
    /// <value>Bank group</value>
    [DataMember(Name="bankGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankGroup")]
    public BankGroup BankGroup { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Bank {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Bic: ").Append(Bic).Append("\n");
      sb.Append("  Blz: ").Append(Blz).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  IsTestBank: ").Append(IsTestBank).Append("\n");
      sb.Append("  Popularity: ").Append(Popularity).Append("\n");
      sb.Append("  Interfaces: ").Append(Interfaces).Append("\n");
      sb.Append("  BankGroup: ").Append(BankGroup).Append("\n");
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
