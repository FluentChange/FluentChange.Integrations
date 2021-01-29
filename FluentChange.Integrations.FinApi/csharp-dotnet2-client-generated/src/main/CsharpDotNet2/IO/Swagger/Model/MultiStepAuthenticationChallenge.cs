using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for multi-step authentication data, as returned by finAPI to the client
  /// </summary>
  [DataContract]
  public class MultiStepAuthenticationChallenge {
    /// <summary>
    /// Hash for this multi-step authentication flow. Must be passed back to finAPI when continuing the flow.
    /// </summary>
    /// <value>Hash for this multi-step authentication flow. Must be passed back to finAPI when continuing the flow.</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public string Hash { get; set; }

    /// <summary>
    /// Indicates the current status of the multi-step authentication flow:<br/><br/>TWO_STEP_PROCEDURE_REQUIRED means that the bank has requested an SCA method selection for the user. In this case, the service should be recalled with a chosen TSP-ID set to the 'twoStepProcedureId' field.<br/>When the web form flow is used, the user is forwarded to finAPI's web form to prompt for his credentials (if they are not stored in finAPI) and to select the preferred SCA method.<br/><br/>CHALLENGE_RESPONSE_REQUIRED means that the bank has requested a challenge code for the previously given TSP (SCA). This status can be completed by setting the 'challengeResponse' field.<br/>When the web form flow is used, the user should submit the challenge response for the challenge message shown by the web form.<br/><br/>REDIRECT_REQUIRED means that the user must be redirected to the bank's website, where the authentication can be finished.<br/>When the web form flow is used, the user should visit the web form, get a redirect to the bank's website, complete the authentication and will then be redirected back to the web form.<br/><br/>DECOUPLED_AUTH_REQUIRED means that the bank has asked for the decoupled authentication. In this case, the 'decoupledCallback' field must be set to true to complete the authentication.<br/><br/>DECOUPLED_AUTH_IN_PROGRESS means that the bank is waiting for the completion of the decoupled authentication by the user. Until this is done, the service should be recalled at most every 5 seconds with the 'decoupledCallback' field set to 'true'. Once the decoupled authentication is completed by the user, the service returns a successful response.
    /// </summary>
    /// <value>Indicates the current status of the multi-step authentication flow:<br/><br/>TWO_STEP_PROCEDURE_REQUIRED means that the bank has requested an SCA method selection for the user. In this case, the service should be recalled with a chosen TSP-ID set to the 'twoStepProcedureId' field.<br/>When the web form flow is used, the user is forwarded to finAPI's web form to prompt for his credentials (if they are not stored in finAPI) and to select the preferred SCA method.<br/><br/>CHALLENGE_RESPONSE_REQUIRED means that the bank has requested a challenge code for the previously given TSP (SCA). This status can be completed by setting the 'challengeResponse' field.<br/>When the web form flow is used, the user should submit the challenge response for the challenge message shown by the web form.<br/><br/>REDIRECT_REQUIRED means that the user must be redirected to the bank's website, where the authentication can be finished.<br/>When the web form flow is used, the user should visit the web form, get a redirect to the bank's website, complete the authentication and will then be redirected back to the web form.<br/><br/>DECOUPLED_AUTH_REQUIRED means that the bank has asked for the decoupled authentication. In this case, the 'decoupledCallback' field must be set to true to complete the authentication.<br/><br/>DECOUPLED_AUTH_IN_PROGRESS means that the bank is waiting for the completion of the decoupled authentication by the user. Until this is done, the service should be recalled at most every 5 seconds with the 'decoupledCallback' field set to 'true'. Once the decoupled authentication is completed by the user, the service returns a successful response.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// In case of status = CHALLENGE_RESPONSE_REQUIRED, this field contains a message from the bank containing instructions for the user on how to proceed with the authorization.
    /// </summary>
    /// <value>In case of status = CHALLENGE_RESPONSE_REQUIRED, this field contains a message from the bank containing instructions for the user on how to proceed with the authorization.</value>
    [DataMember(Name="challengeMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challengeMessage")]
    public string ChallengeMessage { get; set; }

    /// <summary>
    /// Suggestion from the bank on how you can label your input field where the user should enter his challenge response.
    /// </summary>
    /// <value>Suggestion from the bank on how you can label your input field where the user should enter his challenge response.</value>
    [DataMember(Name="answerFieldLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "answerFieldLabel")]
    public string AnswerFieldLabel { get; set; }

    /// <summary>
    /// In case of status = REDIRECT_REQUIRED, this field contains the URL to which you must direct the user. It already includes the redirect URL back to your client that you have passed when initiating the service call.
    /// </summary>
    /// <value>In case of status = REDIRECT_REQUIRED, this field contains the URL to which you must direct the user. It already includes the redirect URL back to your client that you have passed when initiating the service call.</value>
    [DataMember(Name="redirectUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirectUrl")]
    public string RedirectUrl { get; set; }

    /// <summary>
    /// Set in case of status = REDIRECT_REQUIRED. When the bank redirects the user back to your client, the redirect URL will contain this string, which you must process to identify the user context for the callback on your side.
    /// </summary>
    /// <value>Set in case of status = REDIRECT_REQUIRED. When the bank redirects the user back to your client, the redirect URL will contain this string, which you must process to identify the user context for the callback on your side.</value>
    [DataMember(Name="redirectContext", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirectContext")]
    public string RedirectContext { get; set; }

    /// <summary>
    /// Set in case of status = REDIRECT_REQUIRED. This field is set to the name of the query parameter that contains the 'redirectContext' in the redirect URL from the bank back to your client.
    /// </summary>
    /// <value>Set in case of status = REDIRECT_REQUIRED. This field is set to the name of the query parameter that contains the 'redirectContext' in the redirect URL from the bank back to your client.</value>
    [DataMember(Name="redirectContextField", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirectContextField")]
    public string RedirectContextField { get; set; }

    /// <summary>
    /// In case of status = TWO_STEP_PROCEDURE_REQUIRED, this field contains the available two-step procedures. Note that this set does not necessarily match the set that is stored in the respective bank connection interface. You should always use the set from this field for the multi-step authentication flow.
    /// </summary>
    /// <value>In case of status = TWO_STEP_PROCEDURE_REQUIRED, this field contains the available two-step procedures. Note that this set does not necessarily match the set that is stored in the respective bank connection interface. You should always use the set from this field for the multi-step authentication flow.</value>
    [DataMember(Name="twoStepProcedures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "twoStepProcedures")]
    public List<TwoStepProcedure> TwoStepProcedures { get; set; }

    /// <summary>
    /// In case that the bank server has instructed the user to scan a flicker code, then this field will contain the raw data for the flicker animation as a BASE-64 string.
    /// </summary>
    /// <value>In case that the bank server has instructed the user to scan a flicker code, then this field will contain the raw data for the flicker animation as a BASE-64 string.</value>
    [DataMember(Name="opticalData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opticalData")]
    public string OpticalData { get; set; }

    /// <summary>
    /// In case that the 'photoTanData' field is set (i.e. not null), this field contains the MIME type to use for interpreting the photo data (e.g.: 'image/png')
    /// </summary>
    /// <value>In case that the 'photoTanData' field is set (i.e. not null), this field contains the MIME type to use for interpreting the photo data (e.g.: 'image/png')</value>
    [DataMember(Name="photoTanMimeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "photoTanMimeType")]
    public string PhotoTanMimeType { get; set; }

    /// <summary>
    /// In case that the bank server has instructed the user to scan a photo (or more generally speaking, any kind of QR-code-like data), then this field will contain the raw data of the photo as a BASE-64 string. 
    /// </summary>
    /// <value>In case that the bank server has instructed the user to scan a photo (or more generally speaking, any kind of QR-code-like data), then this field will contain the raw data of the photo as a BASE-64 string. </value>
    [DataMember(Name="photoTanData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "photoTanData")]
    public string PhotoTanData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MultiStepAuthenticationChallenge {\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ChallengeMessage: ").Append(ChallengeMessage).Append("\n");
      sb.Append("  AnswerFieldLabel: ").Append(AnswerFieldLabel).Append("\n");
      sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
      sb.Append("  RedirectContext: ").Append(RedirectContext).Append("\n");
      sb.Append("  RedirectContextField: ").Append(RedirectContextField).Append("\n");
      sb.Append("  TwoStepProcedures: ").Append(TwoStepProcedures).Append("\n");
      sb.Append("  OpticalData: ").Append(OpticalData).Append("\n");
      sb.Append("  PhotoTanMimeType: ").Append(PhotoTanMimeType).Append("\n");
      sb.Append("  PhotoTanData: ").Append(PhotoTanData).Append("\n");
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
