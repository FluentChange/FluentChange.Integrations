using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for direct debit creation parameters
  /// </summary>
  [DataContract]
  public class CreateDirectDebitParams {
    /// <summary>
    /// Identifier of the account that should be used for the direct debit.
    /// </summary>
    /// <value>Identifier of the account that should be used for the direct debit.</value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// Type of the direct debit; either <code>BASIC</code> or <code>B2B</code> (Business-To-Business).
    /// </summary>
    /// <value>Type of the direct debit; either <code>BASIC</code> or <code>B2B</code> (Business-To-Business).</value>
    [DataMember(Name="directDebitType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directDebitType")]
    public string DirectDebitType { get; set; }

    /// <summary>
    /// Sequence type of the direct debit. Possible values:<br/><br/>&bull; <code>OOFF</code> - means that this is a one-time direct debit order<br/>&bull; <code>FRST</code> - means that this is the first in a row of multiple direct debit orders<br/>&bull; <code>RCUR</code> - means that this is one (but not the first or final) within a row of multiple direct debit orders<br/>&bull; <code>FNAL</code> - means that this is the final in a row of multiple direct debit orders<br/><br/>
    /// </summary>
    /// <value>Sequence type of the direct debit. Possible values:<br/><br/>&bull; <code>OOFF</code> - means that this is a one-time direct debit order<br/>&bull; <code>FRST</code> - means that this is the first in a row of multiple direct debit orders<br/>&bull; <code>RCUR</code> - means that this is one (but not the first or final) within a row of multiple direct debit orders<br/>&bull; <code>FNAL</code> - means that this is the final in a row of multiple direct debit orders<br/><br/></value>
    [DataMember(Name="sequenceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sequenceType")]
    public string SequenceType { get; set; }

    /// <summary>
    /// List of direct debit orders (may contain at most 15000 items). Please note that collective direct debit may not always be supported.
    /// </summary>
    /// <value>List of direct debit orders (may contain at most 15000 items). Please note that collective direct debit may not always be supported.</value>
    [DataMember(Name="directDebits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directDebits")]
    public List<DirectDebitOrderParams> DirectDebits { get; set; }

    /// <summary>
    /// This field is only relevant when you pass multiple orders. It determines whether the orders should be processed by the bank as one collective booking (in case of 'false'), or as single bookings (in case of 'true'). Note that it is subject to the bank whether it will regard the field. Default value is 'false'.
    /// </summary>
    /// <value>This field is only relevant when you pass multiple orders. It determines whether the orders should be processed by the bank as one collective booking (in case of 'false'), or as single bookings (in case of 'true'). Note that it is subject to the bank whether it will regard the field. Default value is 'false'.</value>
    [DataMember(Name="singleBooking", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "singleBooking")]
    public bool? SingleBooking { get; set; }

    /// <summary>
    /// Execution date for the direct debit(s), in the format 'YYYY-MM-DD'. May not be in the past.
    /// </summary>
    /// <value>Execution date for the direct debit(s), in the format 'YYYY-MM-DD'. May not be in the past.</value>
    [DataMember(Name="executionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executionDate")]
    public string ExecutionDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateDirectDebitParams {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  DirectDebitType: ").Append(DirectDebitType).Append("\n");
      sb.Append("  SequenceType: ").Append(SequenceType).Append("\n");
      sb.Append("  DirectDebits: ").Append(DirectDebits).Append("\n");
      sb.Append("  SingleBooking: ").Append(SingleBooking).Append("\n");
      sb.Append("  ExecutionDate: ").Append(ExecutionDate).Append("\n");
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
