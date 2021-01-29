using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for money transfer creation parameters
  /// </summary>
  [DataContract]
  public class CreateMoneyTransferParams {
    /// <summary>
    /// Identifier of the account that should be used for the money transfer. If you want to do a standalone money transfer (finAPI Payment product, i.e. for an account that is not imported in finAPI) leave this field unset and instead use the field 'iban'.
    /// </summary>
    /// <value>Identifier of the account that should be used for the money transfer. If you want to do a standalone money transfer (finAPI Payment product, i.e. for an account that is not imported in finAPI) leave this field unset and instead use the field 'iban'.</value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// IBAN of the account that should be used for the money transfer. Use this field only if you want to do a standalone money transfer (finAPI Payment product, i.e. for an account that is not imported in finAPI) otherwise, use the 'accountId' field and leave this field unset.
    /// </summary>
    /// <value>IBAN of the account that should be used for the money transfer. Use this field only if you want to do a standalone money transfer (finAPI Payment product, i.e. for an account that is not imported in finAPI) otherwise, use the 'accountId' field and leave this field unset.</value>
    [DataMember(Name="iban", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iban")]
    public string Iban { get; set; }

    /// <summary>
    /// List of money transfer orders (may contain at most 15000 items). Please note that collective money transfer may not always be supported.
    /// </summary>
    /// <value>List of money transfer orders (may contain at most 15000 items). Please note that collective money transfer may not always be supported.</value>
    [DataMember(Name="moneyTransfers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "moneyTransfers")]
    public List<MoneyTransferOrderParams> MoneyTransfers { get; set; }

    /// <summary>
    /// Execution date for the money transfer(s), in the format 'YYYY-MM-DD'. May not be in the past. If not specified, then the current date will be used.
    /// </summary>
    /// <value>Execution date for the money transfer(s), in the format 'YYYY-MM-DD'. May not be in the past. If not specified, then the current date will be used.</value>
    [DataMember(Name="executionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executionDate")]
    public string ExecutionDate { get; set; }

    /// <summary>
    /// This field is only relevant when you pass multiple orders. It determines whether the orders should be processed by the bank as one collective booking (in case of 'false'), or as single bookings (in case of 'true'). Note that it is subject to the bank whether it will regard the field. Default value is 'false'.
    /// </summary>
    /// <value>This field is only relevant when you pass multiple orders. It determines whether the orders should be processed by the bank as one collective booking (in case of 'false'), or as single bookings (in case of 'true'). Note that it is subject to the bank whether it will regard the field. Default value is 'false'.</value>
    [DataMember(Name="singleBooking", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "singleBooking")]
    public bool? SingleBooking { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateMoneyTransferParams {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  Iban: ").Append(Iban).Append("\n");
      sb.Append("  MoneyTransfers: ").Append(MoneyTransfers).Append("\n");
      sb.Append("  ExecutionDate: ").Append(ExecutionDate).Append("\n");
      sb.Append("  SingleBooking: ").Append(SingleBooking).Append("\n");
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
