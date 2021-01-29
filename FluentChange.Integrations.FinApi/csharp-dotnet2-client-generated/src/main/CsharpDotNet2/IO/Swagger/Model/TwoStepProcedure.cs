using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Two-step-procedure for user authorization on bank-side
  /// </summary>
  [DataContract]
  public class TwoStepProcedure {
    /// <summary>
    /// Bank-given ID of the procedure
    /// </summary>
    /// <value>Bank-given ID of the procedure</value>
    [DataMember(Name="procedureId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "procedureId")]
    public string ProcedureId { get; set; }

    /// <summary>
    /// Bank-given name of the procedure
    /// </summary>
    /// <value>Bank-given name of the procedure</value>
    [DataMember(Name="procedureName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "procedureName")]
    public string ProcedureName { get; set; }

    /// <summary>
    /// The challenge type of the procedure. Possible values are:<br/><br/>&bull; <code>TEXT</code> - the challenge will be a text that contains instructions for the user on how to proceed with the authorization.<br/>&bull; <code>PHOTO</code> - the challenge will contain a BASE-64 string depicting a photo (or any kind of QR-code-like data) that must be shown to the user.<br/>&bull; <code>FLICKER_CODE</code> - the challenge will contain a BASE-64 string depicting a flicker code animation that must be shown to the user.<br/><br/>Note that this challenge type information does not originate from the bank, but is determined by finAPI internally. There is no guarantee that the determined challenge type is correct. Note also that this field may not be set, meaning that finAPI could not determine the challenge type of the procedure.
    /// </summary>
    /// <value>The challenge type of the procedure. Possible values are:<br/><br/>&bull; <code>TEXT</code> - the challenge will be a text that contains instructions for the user on how to proceed with the authorization.<br/>&bull; <code>PHOTO</code> - the challenge will contain a BASE-64 string depicting a photo (or any kind of QR-code-like data) that must be shown to the user.<br/>&bull; <code>FLICKER_CODE</code> - the challenge will contain a BASE-64 string depicting a flicker code animation that must be shown to the user.<br/><br/>Note that this challenge type information does not originate from the bank, but is determined by finAPI internally. There is no guarantee that the determined challenge type is correct. Note also that this field may not be set, meaning that finAPI could not determine the challenge type of the procedure.</value>
    [DataMember(Name="procedureChallengeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "procedureChallengeType")]
    public string ProcedureChallengeType { get; set; }

    /// <summary>
    /// If 'true', then there is no need for your client to pass back anything to finAPI to continue the authorization when using this procedure. The authorization will be dealt with directly between the user, finAPI, and the bank.
    /// </summary>
    /// <value>If 'true', then there is no need for your client to pass back anything to finAPI to continue the authorization when using this procedure. The authorization will be dealt with directly between the user, finAPI, and the bank.</value>
    [DataMember(Name="implicitExecute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "implicitExecute")]
    public bool? ImplicitExecute { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TwoStepProcedure {\n");
      sb.Append("  ProcedureId: ").Append(ProcedureId).Append("\n");
      sb.Append("  ProcedureName: ").Append(ProcedureName).Append("\n");
      sb.Append("  ProcedureChallengeType: ").Append(ProcedureChallengeType).Append("\n");
      sb.Append("  ImplicitExecute: ").Append(ImplicitExecute).Append("\n");
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
