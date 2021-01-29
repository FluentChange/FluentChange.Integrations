using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for a web form&#39;s data
  /// </summary>
  [DataContract]
  public class WebForm {
    /// <summary>
    /// Web form identifier, as returned in the 451 response of the REST service call that initiated the web form flow.
    /// </summary>
    /// <value>Web form identifier, as returned in the 451 response of the REST service call that initiated the web form flow.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Token for the finAPI web form page, as contained in the 451 response of the REST service call that initiated the web form flow (in the 'Location' header).
    /// </summary>
    /// <value>Token for the finAPI web form page, as contained in the 451 response of the REST service call that initiated the web form flow (in the 'Location' header).</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// Status of a web form. Possible values are:<br/>&bull; NOT_YET_OPENED - the web form URL was not yet called;<br/>&bull; IN_PROGRESS - the web form has been opened but not yet submitted by the user;<br/>&bull; COMPLETED - the user has opened and submitted the web form;<br/>&bull; ABORTED - the user has opened but then aborted the web form, or the web form was aborted by the finAPI system because it has expired (this is the case when a web form is opened and then not submitted within 10 minutes)
    /// </summary>
    /// <value>Status of a web form. Possible values are:<br/>&bull; NOT_YET_OPENED - the web form URL was not yet called;<br/>&bull; IN_PROGRESS - the web form has been opened but not yet submitted by the user;<br/>&bull; COMPLETED - the user has opened and submitted the web form;<br/>&bull; ABORTED - the user has opened but then aborted the web form, or the web form was aborted by the finAPI system because it has expired (this is the case when a web form is opened and then not submitted within 10 minutes)</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// HTTP response code of the REST service call that initiated the web form flow. This field can be queried as soon as the status becomes COMPLETED or ABORTED. Note that it is still not guaranteed in this case that the field has a value, i.e. it might be null.
    /// </summary>
    /// <value>HTTP response code of the REST service call that initiated the web form flow. This field can be queried as soon as the status becomes COMPLETED or ABORTED. Note that it is still not guaranteed in this case that the field has a value, i.e. it might be null.</value>
    [DataMember(Name="serviceResponseCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceResponseCode")]
    public int? ServiceResponseCode { get; set; }

    /// <summary>
    /// HTTP response body of the REST service call that initiated the web form flow. This field can be queried as soon as the status becomes COMPLETED or ABORTED. Note that it is still not guaranteed in this case that the field has a value, i.e. it might be null.
    /// </summary>
    /// <value>HTTP response body of the REST service call that initiated the web form flow. This field can be queried as soon as the status becomes COMPLETED or ABORTED. Note that it is still not guaranteed in this case that the field has a value, i.e. it might be null.</value>
    [DataMember(Name="serviceResponseBody", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceResponseBody")]
    public string ServiceResponseBody { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebForm {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ServiceResponseCode: ").Append(ServiceResponseCode).Append("\n");
      sb.Append("  ServiceResponseBody: ").Append(ServiceResponseBody).Append("\n");
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
