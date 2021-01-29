using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for bank connection edit params
  /// </summary>
  [DataContract]
  public class EditBankConnectionParams {
    /// <summary>
    /// New name for the bank connection. Maximum length is 64. If you do not want to change the current name let this field remain unset. If you want to clear the current name, set the field's value to an empty string (\"\").
    /// </summary>
    /// <value>New name for the bank connection. Maximum length is 64. If you do not want to change the current name let this field remain unset. If you want to clear the current name, set the field's value to an empty string (\"\").</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The interface for which you want to edit data. Must be given when you pass 'loginCredentials' and/or a 'defaultTwoStepProcedureId'.
    /// </summary>
    /// <value>The interface for which you want to edit data. Must be given when you pass 'loginCredentials' and/or a 'defaultTwoStepProcedureId'.</value>
    [DataMember(Name="interface", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interface")]
    public string Interface { get; set; }

    /// <summary>
    /// Set of login credentials that you want to edit. Must be passed in combination with the 'interface' field. The labels that you pass must match with the login credential labels that the respective interface defines. If you want to clear the stored value for a credential, you can pass an empty string (\"\") as value.In case you need to use finAPI's web form to let the user update the login credentials, send all fields the user wishes to update with a non-empty value.In case all fields contain an empty string (\"\"), no webform will be generated. Note that any change in the credentials will automatically remove the saved consent data associated with those credentials.
    /// </summary>
    /// <value>Set of login credentials that you want to edit. Must be passed in combination with the 'interface' field. The labels that you pass must match with the login credential labels that the respective interface defines. If you want to clear the stored value for a credential, you can pass an empty string (\"\") as value.In case you need to use finAPI's web form to let the user update the login credentials, send all fields the user wishes to update with a non-empty value.In case all fields contain an empty string (\"\"), no webform will be generated. Note that any change in the credentials will automatically remove the saved consent data associated with those credentials.</value>
    [DataMember(Name="loginCredentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loginCredentials")]
    public List<LoginCredential> LoginCredentials { get; set; }

    /// <summary>
    /// NOTE: In the future, this field will work only in combination with the 'interface' field.<br/><br/>New default two-step-procedure. Must match the 'procedureId' of one of the procedures that are listed in the bank connection. If you do not want to change this field let it remain unset. If you want to clear the current default two-step-procedure, set the field's value to an empty string (\"\").
    /// </summary>
    /// <value>NOTE: In the future, this field will work only in combination with the 'interface' field.<br/><br/>New default two-step-procedure. Must match the 'procedureId' of one of the procedures that are listed in the bank connection. If you do not want to change this field let it remain unset. If you want to clear the current default two-step-procedure, set the field's value to an empty string (\"\").</value>
    [DataMember(Name="defaultTwoStepProcedureId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultTwoStepProcedureId")]
    public string DefaultTwoStepProcedureId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EditBankConnectionParams {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Interface: ").Append(Interface).Append("\n");
      sb.Append("  LoginCredentials: ").Append(LoginCredentials).Append("\n");
      sb.Append("  DefaultTwoStepProcedureId: ").Append(DefaultTwoStepProcedureId).Append("\n");
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
