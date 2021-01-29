using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for multi-step authentication data, as passed by the client to finAPI
  /// </summary>
  [DataContract]
  public class MultiStepAuthenticationCallback {
    /// <summary>
    /// Hash that was returned in the previous multi-step authentication error.
    /// </summary>
    /// <value>Hash that was returned in the previous multi-step authentication error.</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public string Hash { get; set; }

    /// <summary>
    /// Challenge response. Must be set when the previous multi-step authentication error had status 'CHALLENGE_RESPONSE_REQUIRED.
    /// </summary>
    /// <value>Challenge response. Must be set when the previous multi-step authentication error had status 'CHALLENGE_RESPONSE_REQUIRED.</value>
    [DataMember(Name="challengeResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challengeResponse")]
    public string ChallengeResponse { get; set; }

    /// <summary>
    /// The bank-given ID of the two-step-procedure that should be used for authentication. Must be set when the previous multi-step authentication error had status 'TWO_STEP_PROCEDURE_REQUIRED.
    /// </summary>
    /// <value>The bank-given ID of the two-step-procedure that should be used for authentication. Must be set when the previous multi-step authentication error had status 'TWO_STEP_PROCEDURE_REQUIRED.</value>
    [DataMember(Name="twoStepProcedureId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "twoStepProcedureId")]
    public string TwoStepProcedureId { get; set; }

    /// <summary>
    /// Must be passed when the previous multi-step authentication error had status 'REDIRECT_REQUIRED'. The value must consist of the complete query parameter list that was contained in the received redirect from the bank.
    /// </summary>
    /// <value>Must be passed when the previous multi-step authentication error had status 'REDIRECT_REQUIRED'. The value must consist of the complete query parameter list that was contained in the received redirect from the bank.</value>
    [DataMember(Name="redirectCallback", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirectCallback")]
    public string RedirectCallback { get; set; }

    /// <summary>
    /// Must be passed when the previous multi-step authentication error had status 'DECOUPLED_AUTH_REQUIRED' or 'DECOUPLED_AUTH_IN_PROGRESS'. The field represents the state of the decoupled authentication meaning that when it's set to 'true', the end-user has completed the authentication process on bank's side.<br/><br/>Please note: Don't repeat the service call too frequently. Some banks limit the amount of requests per minute. Our suggestion is to repeat the service call for the decoupled approach every 5 seconds.
    /// </summary>
    /// <value>Must be passed when the previous multi-step authentication error had status 'DECOUPLED_AUTH_REQUIRED' or 'DECOUPLED_AUTH_IN_PROGRESS'. The field represents the state of the decoupled authentication meaning that when it's set to 'true', the end-user has completed the authentication process on bank's side.<br/><br/>Please note: Don't repeat the service call too frequently. Some banks limit the amount of requests per minute. Our suggestion is to repeat the service call for the decoupled approach every 5 seconds.</value>
    [DataMember(Name="decoupledCallback", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decoupledCallback")]
    public bool? DecoupledCallback { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MultiStepAuthenticationCallback {\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  ChallengeResponse: ").Append(ChallengeResponse).Append("\n");
      sb.Append("  TwoStepProcedureId: ").Append(TwoStepProcedureId).Append("\n");
      sb.Append("  RedirectCallback: ").Append(RedirectCallback).Append("\n");
      sb.Append("  DecoupledCallback: ").Append(DecoupledCallback).Append("\n");
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
