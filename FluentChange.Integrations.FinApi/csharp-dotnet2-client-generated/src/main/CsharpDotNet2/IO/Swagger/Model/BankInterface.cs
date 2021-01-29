using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Interface used to connect to a bank
  /// </summary>
  [DataContract]
  public class BankInterface {
    /// <summary>
    /// Bank interface. Possible values:<br><br>&bull; <code>FINTS_SERVER</code> - means that finAPI will download data via the bank's FinTS server.<br>&bull; <code>WEB_SCRAPER</code> - means that finAPI will parse data from the bank's online banking website.<br>&bull; <code>XS2A</code> - means that finAPI will download data via the bank's XS2A interface.<br>
    /// </summary>
    /// <value>Bank interface. Possible values:<br><br>&bull; <code>FINTS_SERVER</code> - means that finAPI will download data via the bank's FinTS server.<br>&bull; <code>WEB_SCRAPER</code> - means that finAPI will parse data from the bank's online banking website.<br>&bull; <code>XS2A</code> - means that finAPI will download data via the bank's XS2A interface.<br></value>
    [DataMember(Name="interface", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interface")]
    public string Interface { get; set; }

    /// <summary>
    /// TPP Authentication Group which the bank interface is connected to
    /// </summary>
    /// <value>TPP Authentication Group which the bank interface is connected to</value>
    [DataMember(Name="tppAuthenticationGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tppAuthenticationGroup")]
    public TppAuthenticationGroup TppAuthenticationGroup { get; set; }

    /// <summary>
    /// Login credentials fields which should be shown to the user.
    /// </summary>
    /// <value>Login credentials fields which should be shown to the user.</value>
    [DataMember(Name="loginCredentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loginCredentials")]
    public List<BankInterfaceLoginField> LoginCredentials { get; set; }

    /// <summary>
    /// Set of interface properties/specifics. Possible values:<br><br>&bull; <code>REDIRECT_APPROACH</code> - means that the interface uses a redirect approach when authorizing the user. It requires you to pass the 'redirectUrl' field in all services which define the field. If the user already has imported a bank connection of the same bank that he is about to import, we recommend to confront the user with the question: <blockquote>For the selected bank you have already imported successfully the following accounts: &lt;account list&gt;. Are you sure that you want to import another bank connection from &lt;bank name&gt;? </blockquote>&bull; <code>DECOUPLED_APPROACH</code> - means that the interface can trigger a decoupled approval during user authorization.<br/><br/>&bull; <code>DETAILED_CONSENT</code> - means that the interface requires a list of account references when authorizing the user. It requires you to pass the 'accountReferences' field in all services which define the field.<br/><br/>Note that this set can be empty, if the interface does not have any specific properties.
    /// </summary>
    /// <value>Set of interface properties/specifics. Possible values:<br><br>&bull; <code>REDIRECT_APPROACH</code> - means that the interface uses a redirect approach when authorizing the user. It requires you to pass the 'redirectUrl' field in all services which define the field. If the user already has imported a bank connection of the same bank that he is about to import, we recommend to confront the user with the question: <blockquote>For the selected bank you have already imported successfully the following accounts: &lt;account list&gt;. Are you sure that you want to import another bank connection from &lt;bank name&gt;? </blockquote>&bull; <code>DECOUPLED_APPROACH</code> - means that the interface can trigger a decoupled approval during user authorization.<br/><br/>&bull; <code>DETAILED_CONSENT</code> - means that the interface requires a list of account references when authorizing the user. It requires you to pass the 'accountReferences' field in all services which define the field.<br/><br/>Note that this set can be empty, if the interface does not have any specific properties.</value>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<string> Properties { get; set; }

    /// <summary>
    /// Login hint. Contains a German message for the user that explains what kind of credentials are expected.<br/><br/>Please note that it is essential to always show the login hint to the user if there is one, as the credentials that finAPI requires for the bank might be different to the credentials that the user knows from his online banking.<br/><br/>Also note that the contents of this field should always be interpreted as HTML, as the text might contain HTML tags for highlighted words, paragraphs, etc.
    /// </summary>
    /// <value>Login hint. Contains a German message for the user that explains what kind of credentials are expected.<br/><br/>Please note that it is essential to always show the login hint to the user if there is one, as the credentials that finAPI requires for the bank might be different to the credentials that the user knows from his online banking.<br/><br/>Also note that the contents of this field should always be interpreted as HTML, as the text might contain HTML tags for highlighted words, paragraphs, etc.</value>
    [DataMember(Name="loginHint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loginHint")]
    public string LoginHint { get; set; }

    /// <summary>
    /// The health status of this interface. This is a value between 0 and 100, depicting the percentage of successful communication attempts with the bank via this interface during the latest couple of bank connection imports or updates (across the entire finAPI system). Note that 'successful' means that there was no technical error trying to establish a communication with the bank. Non-technical errors (like incorrect credentials) are regarded successful communication attempts.
    /// </summary>
    /// <value>The health status of this interface. This is a value between 0 and 100, depicting the percentage of successful communication attempts with the bank via this interface during the latest couple of bank connection imports or updates (across the entire finAPI system). Note that 'successful' means that there was no technical error trying to establish a communication with the bank. Non-technical errors (like incorrect credentials) are regarded successful communication attempts.</value>
    [DataMember(Name="health", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "health")]
    public int? Health { get; set; }

    /// <summary>
    /// Time of the last communication attempt with this interface during an import, update or connect interface (across the entire finAPI system). The value is returned in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).
    /// </summary>
    /// <value>Time of the last communication attempt with this interface during an import, update or connect interface (across the entire finAPI system). The value is returned in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).</value>
    [DataMember(Name="lastCommunicationAttempt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastCommunicationAttempt")]
    public string LastCommunicationAttempt { get; set; }

    /// <summary>
    /// Time of the last successful communication with this interface during an import, update or connect interface (across the entire finAPI system). The value is returned in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).
    /// </summary>
    /// <value>Time of the last successful communication with this interface during an import, update or connect interface (across the entire finAPI system). The value is returned in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).</value>
    [DataMember(Name="lastSuccessfulCommunication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastSuccessfulCommunication")]
    public string LastSuccessfulCommunication { get; set; }

    /// <summary>
    /// Whether this interface has the general capability to do money transfers. Note that it still depends on the specifics of an account whether you will actually be able to do money transfers for that account or not - see the field AccountInterface.capabilities for more. In general, you should prefer the field AccountInterface.capabilities to determine what kind of payments an account supports. This field here is meant to be used mainly for when you are planning to do standalone money transfers (finAPI Payment product, i.e. when you do not plan to import an account and thus will not have the data about the account's exact capabilities).
    /// </summary>
    /// <value>Whether this interface has the general capability to do money transfers. Note that it still depends on the specifics of an account whether you will actually be able to do money transfers for that account or not - see the field AccountInterface.capabilities for more. In general, you should prefer the field AccountInterface.capabilities to determine what kind of payments an account supports. This field here is meant to be used mainly for when you are planning to do standalone money transfers (finAPI Payment product, i.e. when you do not plan to import an account and thus will not have the data about the account's exact capabilities).</value>
    [DataMember(Name="isMoneyTransferSupported", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isMoneyTransferSupported")]
    public bool? IsMoneyTransferSupported { get; set; }

    /// <summary>
    /// Whether this interface has the general capability to perform Account Information Services (AIS), i.e. if this interface can be used to download accounts, balances and transactions. 
    /// </summary>
    /// <value>Whether this interface has the general capability to perform Account Information Services (AIS), i.e. if this interface can be used to download accounts, balances and transactions. </value>
    [DataMember(Name="isAisSupported", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAisSupported")]
    public bool? IsAisSupported { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BankInterface {\n");
      sb.Append("  Interface: ").Append(Interface).Append("\n");
      sb.Append("  TppAuthenticationGroup: ").Append(TppAuthenticationGroup).Append("\n");
      sb.Append("  LoginCredentials: ").Append(LoginCredentials).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  LoginHint: ").Append(LoginHint).Append("\n");
      sb.Append("  Health: ").Append(Health).Append("\n");
      sb.Append("  LastCommunicationAttempt: ").Append(LastCommunicationAttempt).Append("\n");
      sb.Append("  LastSuccessfulCommunication: ").Append(LastSuccessfulCommunication).Append("\n");
      sb.Append("  IsMoneyTransferSupported: ").Append(IsMoneyTransferSupported).Append("\n");
      sb.Append("  IsAisSupported: ").Append(IsAisSupported).Append("\n");
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
