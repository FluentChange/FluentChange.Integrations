using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Payment submission parameters
  /// </summary>
  [DataContract]
  public class SubmitPaymentParams {
    /// <summary>
    /// Payment identifier
    /// </summary>
    /// <value>Payment identifier</value>
    [DataMember(Name="paymentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentId")]
    public long? PaymentId { get; set; }

    /// <summary>
    /// Bank interface. Possible values:<br><br>&bull; <code>FINTS_SERVER</code> - means that finAPI will execute the payment via the bank's FinTS interface.<br>&bull; <code>WEB_SCRAPER</code> - means that finAPI will parse data from the bank's online banking website.<br>&bull; <code>XS2A</code> - means that finAPI will execute the payment via the bank's XS2A interface.Please note that XS2A doesn't support direct debits yet. <br/>To determine what interface(s) you can choose to submit a payment, please refer to the field AccountInterface.capabilities of the account that is related to the payment, or if this is a standalone payment without a related account imported in finAPI, refer to the field BankInterface.isMoneyTransferSupported.<br/>For standalone money transfers (finAPI Payment product) in particular, we suggest to always use XS2A if supported, and only use FINTS_SERVER or WEB_SCRAPER as a fallback, because non-XS2A interfaces might require not just a single, but multiple authentications when submitting the payment.<br/>
    /// </summary>
    /// <value>Bank interface. Possible values:<br><br>&bull; <code>FINTS_SERVER</code> - means that finAPI will execute the payment via the bank's FinTS interface.<br>&bull; <code>WEB_SCRAPER</code> - means that finAPI will parse data from the bank's online banking website.<br>&bull; <code>XS2A</code> - means that finAPI will execute the payment via the bank's XS2A interface.Please note that XS2A doesn't support direct debits yet. <br/>To determine what interface(s) you can choose to submit a payment, please refer to the field AccountInterface.capabilities of the account that is related to the payment, or if this is a standalone payment without a related account imported in finAPI, refer to the field BankInterface.isMoneyTransferSupported.<br/>For standalone money transfers (finAPI Payment product) in particular, we suggest to always use XS2A if supported, and only use FINTS_SERVER or WEB_SCRAPER as a fallback, because non-XS2A interfaces might require not just a single, but multiple authentications when submitting the payment.<br/></value>
    [DataMember(Name="interface", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interface")]
    public string Interface { get; set; }

    /// <summary>
    /// Login credentials. May not be required when the credentials are stored in finAPI, or when the bank interface has no login credentials.
    /// </summary>
    /// <value>Login credentials. May not be required when the credentials are stored in finAPI, or when the bank interface has no login credentials.</value>
    [DataMember(Name="loginCredentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loginCredentials")]
    public List<LoginCredential> LoginCredentials { get; set; }

    /// <summary>
    /// Must only be passed when the used interface has the property REDIRECT_APPROACH and no web form flow is used. The user will be redirected to the given URL from the bank's website after having entered his credentials.
    /// </summary>
    /// <value>Must only be passed when the used interface has the property REDIRECT_APPROACH and no web form flow is used. The user will be redirected to the given URL from the bank's website after having entered his credentials.</value>
    [DataMember(Name="redirectUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirectUrl")]
    public string RedirectUrl { get; set; }

    /// <summary>
    /// Container for multi-step authentication data. Required when a previous service call initiated a multi-step authentication.
    /// </summary>
    /// <value>Container for multi-step authentication data. Required when a previous service call initiated a multi-step authentication.</value>
    [DataMember(Name="multiStepAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "multiStepAuthentication")]
    public MultiStepAuthenticationCallback MultiStepAuthentication { get; set; }

    /// <summary>
    /// Whether the finAPI web form should hide transaction details when prompting the caller for the second factor. Default value is false.
    /// </summary>
    /// <value>Whether the finAPI web form should hide transaction details when prompting the caller for the second factor. Default value is false.</value>
    [DataMember(Name="hideTransactionDetailsInWebForm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hideTransactionDetailsInWebForm")]
    public bool? HideTransactionDetailsInWebForm { get; set; }

    /// <summary>
    /// If the user has stored credentials in finAPI for the account (resp. bank connection) that relates to the payment, then the finAPI web form will only be shown when the user must be involved for a second authentication, or when the previous connection to the bank via the selected interface had failed. However if you want to provide the web form to the user in any case, you can set this field to true. It will force the web form flow for the user and allow him to make changes to the data that he has stored in finAPI. Note that this flag is irrelevant when submitting a standalone payment, as in this case there is no related data stored in finAPI.
    /// </summary>
    /// <value>If the user has stored credentials in finAPI for the account (resp. bank connection) that relates to the payment, then the finAPI web form will only be shown when the user must be involved for a second authentication, or when the previous connection to the bank via the selected interface had failed. However if you want to provide the web form to the user in any case, you can set this field to true. It will force the web form flow for the user and allow him to make changes to the data that he has stored in finAPI. Note that this flag is irrelevant when submitting a standalone payment, as in this case there is no related data stored in finAPI.</value>
    [DataMember(Name="forceWebForm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forceWebForm")]
    public bool? ForceWebForm { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubmitPaymentParams {\n");
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
      sb.Append("  Interface: ").Append(Interface).Append("\n");
      sb.Append("  LoginCredentials: ").Append(LoginCredentials).Append("\n");
      sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
      sb.Append("  MultiStepAuthentication: ").Append(MultiStepAuthentication).Append("\n");
      sb.Append("  HideTransactionDetailsInWebForm: ").Append(HideTransactionDetailsInWebForm).Append("\n");
      sb.Append("  ForceWebForm: ").Append(ForceWebForm).Append("\n");
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
