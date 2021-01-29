using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for a security position&#39;s data
  /// </summary>
  [DataContract]
  public class Security {
    /// <summary>
    /// Identifier. Note: Whenever a security account is being updated, its security positions will be internally re-created, meaning that the identifier of a security position might change over time.
    /// </summary>
    /// <value>Identifier. Note: Whenever a security account is being updated, its security positions will be internally re-created, meaning that the identifier of a security position might change over time.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Security account identifier
    /// </summary>
    /// <value>Security account identifier</value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    /// <value>Name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// ISIN
    /// </summary>
    /// <value>ISIN</value>
    [DataMember(Name="isin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isin")]
    public string Isin { get; set; }

    /// <summary>
    /// WKN
    /// </summary>
    /// <value>WKN</value>
    [DataMember(Name="wkn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wkn")]
    public string Wkn { get; set; }

    /// <summary>
    /// Quote
    /// </summary>
    /// <value>Quote</value>
    [DataMember(Name="quote", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quote")]
    public decimal? Quote { get; set; }

    /// <summary>
    /// Currency of quote
    /// </summary>
    /// <value>Currency of quote</value>
    [DataMember(Name="quoteCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quoteCurrency")]
    public string QuoteCurrency { get; set; }

    /// <summary>
    /// Type of quote. 'PERC' if quote is a percentage value, 'ACTU' if quote is the actual amount
    /// </summary>
    /// <value>Type of quote. 'PERC' if quote is a percentage value, 'ACTU' if quote is the actual amount</value>
    [DataMember(Name="quoteType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quoteType")]
    public string QuoteType { get; set; }

    /// <summary>
    /// Quote date in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).
    /// </summary>
    /// <value>Quote date in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).</value>
    [DataMember(Name="quoteDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quoteDate")]
    public string QuoteDate { get; set; }

    /// <summary>
    /// Value of quantity or nominal
    /// </summary>
    /// <value>Value of quantity or nominal</value>
    [DataMember(Name="quantityNominal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantityNominal")]
    public decimal? QuantityNominal { get; set; }

    /// <summary>
    /// Type of quantity or nominal value. 'UNIT' if value is a quantity, 'FAMT' if value is the nominal amount
    /// </summary>
    /// <value>Type of quantity or nominal value. 'UNIT' if value is a quantity, 'FAMT' if value is the nominal amount</value>
    [DataMember(Name="quantityNominalType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantityNominalType")]
    public string QuantityNominalType { get; set; }

    /// <summary>
    /// Market value
    /// </summary>
    /// <value>Market value</value>
    [DataMember(Name="marketValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marketValue")]
    public decimal? MarketValue { get; set; }

    /// <summary>
    /// Currency of market value
    /// </summary>
    /// <value>Currency of market value</value>
    [DataMember(Name="marketValueCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marketValueCurrency")]
    public string MarketValueCurrency { get; set; }

    /// <summary>
    /// Entry quote
    /// </summary>
    /// <value>Entry quote</value>
    [DataMember(Name="entryQuote", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryQuote")]
    public decimal? EntryQuote { get; set; }

    /// <summary>
    /// Currency of entry quote
    /// </summary>
    /// <value>Currency of entry quote</value>
    [DataMember(Name="entryQuoteCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryQuoteCurrency")]
    public string EntryQuoteCurrency { get; set; }

    /// <summary>
    /// Current profit or loss
    /// </summary>
    /// <value>Current profit or loss</value>
    [DataMember(Name="profitOrLoss", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profitOrLoss")]
    public decimal? ProfitOrLoss { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Security {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Isin: ").Append(Isin).Append("\n");
      sb.Append("  Wkn: ").Append(Wkn).Append("\n");
      sb.Append("  Quote: ").Append(Quote).Append("\n");
      sb.Append("  QuoteCurrency: ").Append(QuoteCurrency).Append("\n");
      sb.Append("  QuoteType: ").Append(QuoteType).Append("\n");
      sb.Append("  QuoteDate: ").Append(QuoteDate).Append("\n");
      sb.Append("  QuantityNominal: ").Append(QuantityNominal).Append("\n");
      sb.Append("  QuantityNominalType: ").Append(QuantityNominalType).Append("\n");
      sb.Append("  MarketValue: ").Append(MarketValue).Append("\n");
      sb.Append("  MarketValueCurrency: ").Append(MarketValueCurrency).Append("\n");
      sb.Append("  EntryQuote: ").Append(EntryQuote).Append("\n");
      sb.Append("  EntryQuoteCurrency: ").Append(EntryQuoteCurrency).Append("\n");
      sb.Append("  ProfitOrLoss: ").Append(ProfitOrLoss).Append("\n");
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
