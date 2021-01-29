using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for a bank&#39;s login credential field
  /// </summary>
  [DataContract]
  public class BankInterfaceLoginField {
    /// <summary>
    /// Contains a German label for the input field that you should provide to the user. Also, these labels are used to identify login fields on the API-level, when you pass credentials to the service.
    /// </summary>
    /// <value>Contains a German label for the input field that you should provide to the user. Also, these labels are used to identify login fields on the API-level, when you pass credentials to the service.</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// Whether this field has to be treated as a secret. In this case your application should use a password input field instead of a cleartext field.
    /// </summary>
    /// <value>Whether this field has to be treated as a secret. In this case your application should use a password input field instead of a cleartext field.</value>
    [DataMember(Name="isSecret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>
    /// This field depicts whether the given credential is volatile. If a field is volatile, it means that the value for the field, which is provided by the user, is valid only for a single authentication and then gets invalidated on bank-side. If a login credential field is volatile, it is not possible to store it in finAPI, as stored credentials will never work for future authentications.
    /// </summary>
    /// <value>This field depicts whether the given credential is volatile. If a field is volatile, it means that the value for the field, which is provided by the user, is valid only for a single authentication and then gets invalidated on bank-side. If a login credential field is volatile, it is not possible to store it in finAPI, as stored credentials will never work for future authentications.</value>
    [DataMember(Name="isVolatile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isVolatile")]
    public bool? IsVolatile { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BankInterfaceLoginField {\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  IsSecret: ").Append(IsSecret).Append("\n");
      sb.Append("  IsVolatile: ").Append(IsVolatile).Append("\n");
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
