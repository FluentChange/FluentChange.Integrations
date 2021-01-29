using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Mock transaction data
  /// </summary>
  [DataContract]
  public class NewTransaction {
    /// <summary>
    /// Amount. Required.
    /// </summary>
    /// <value>Amount. Required.</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Purpose. Any symbols are allowed. Maximum length is 2000. Optional. Default value: null.
    /// </summary>
    /// <value>Purpose. Any symbols are allowed. Maximum length is 2000. Optional. Default value: null.</value>
    [DataMember(Name="purpose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purpose")]
    public string Purpose { get; set; }

    /// <summary>
    /// Counterpart. Any symbols are allowed. Maximum length is 80. Optional. Default value: null.
    /// </summary>
    /// <value>Counterpart. Any symbols are allowed. Maximum length is 80. Optional. Default value: null.</value>
    [DataMember(Name="counterpart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpart")]
    public string Counterpart { get; set; }

    /// <summary>
    /// Counterpart IBAN. Optional. Default value: null.
    /// </summary>
    /// <value>Counterpart IBAN. Optional. Default value: null.</value>
    [DataMember(Name="counterpartIban", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartIban")]
    public string CounterpartIban { get; set; }

    /// <summary>
    /// Counterpart BLZ. Optional. Default value: null.
    /// </summary>
    /// <value>Counterpart BLZ. Optional. Default value: null.</value>
    [DataMember(Name="counterpartBlz", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartBlz")]
    public string CounterpartBlz { get; set; }

    /// <summary>
    /// Counterpart BIC. Optional. Default value: null.
    /// </summary>
    /// <value>Counterpart BIC. Optional. Default value: null.</value>
    [DataMember(Name="counterpartBic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartBic")]
    public string CounterpartBic { get; set; }

    /// <summary>
    /// Counterpart account number. Maximum length is 34. Optional. Default value: null.
    /// </summary>
    /// <value>Counterpart account number. Maximum length is 34. Optional. Default value: null.</value>
    [DataMember(Name="counterpartAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartAccountNumber")]
    public string CounterpartAccountNumber { get; set; }

    /// <summary>
    /// Booking date in the format 'YYYY-MM-DD'.<br/><br/>If the date lies back more than 10 days from the booking date of the latest transaction that currently exists in the account, then this transaction will be ignored and not imported. If the date depicts a date in the future, then finAPI will deal with it the same way as it does with real transactions during a real update (see fields 'bankBookingDate' and 'finapiBookingDate' in the Transaction Resource for explanation).<br/><br/>This field is optional, default value is the current date.
    /// </summary>
    /// <value>Booking date in the format 'YYYY-MM-DD'.<br/><br/>If the date lies back more than 10 days from the booking date of the latest transaction that currently exists in the account, then this transaction will be ignored and not imported. If the date depicts a date in the future, then finAPI will deal with it the same way as it does with real transactions during a real update (see fields 'bankBookingDate' and 'finapiBookingDate' in the Transaction Resource for explanation).<br/><br/>This field is optional, default value is the current date.</value>
    [DataMember(Name="bookingDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bookingDate")]
    public string BookingDate { get; set; }

    /// <summary>
    /// Value date in the format 'YYYY-MM-DD'. Optional. Default value: Same as the booking date.
    /// </summary>
    /// <value>Value date in the format 'YYYY-MM-DD'. Optional. Default value: Same as the booking date.</value>
    [DataMember(Name="valueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueDate")]
    public string ValueDate { get; set; }

    /// <summary>
    /// The transaction type id. It's usually a number between 1 and 999. You can look up valid transaction in the following document on page 198: <a href='https://www.hbci-zka.de/dokumente/spezifikation_deutsch/fintsv4/FinTS_4.1_Messages_Finanzdatenformate_2014-01-20-FV.pdf' target='_blank'>FinTS Financial TransactionServices</a>.<br/> For numbers not listed here, the service call might fail.
    /// </summary>
    /// <value>The transaction type id. It's usually a number between 1 and 999. You can look up valid transaction in the following document on page 198: <a href='https://www.hbci-zka.de/dokumente/spezifikation_deutsch/fintsv4/FinTS_4.1_Messages_Finanzdatenformate_2014-01-20-FV.pdf' target='_blank'>FinTS Financial TransactionServices</a>.<br/> For numbers not listed here, the service call might fail.</value>
    [DataMember(Name="typeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typeId")]
    public int? TypeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NewTransaction {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Purpose: ").Append(Purpose).Append("\n");
      sb.Append("  Counterpart: ").Append(Counterpart).Append("\n");
      sb.Append("  CounterpartIban: ").Append(CounterpartIban).Append("\n");
      sb.Append("  CounterpartBlz: ").Append(CounterpartBlz).Append("\n");
      sb.Append("  CounterpartBic: ").Append(CounterpartBic).Append("\n");
      sb.Append("  CounterpartAccountNumber: ").Append(CounterpartAccountNumber).Append("\n");
      sb.Append("  BookingDate: ").Append(BookingDate).Append("\n");
      sb.Append("  ValueDate: ").Append(ValueDate).Append("\n");
      sb.Append("  TypeId: ").Append(TypeId).Append("\n");
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
