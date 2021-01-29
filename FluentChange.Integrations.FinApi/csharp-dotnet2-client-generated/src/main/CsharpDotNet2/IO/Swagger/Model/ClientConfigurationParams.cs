using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Client configuration parameters
  /// </summary>
  [DataContract]
  public class ClientConfigurationParams {
    /// <summary>
    /// Callback URL to which finAPI sends the notification messages that are triggered from the automatic batch update of the users' bank connections. This field is only relevant if the automatic batch update is enabled for your client. For details about what the notification messages look like, please see the documentation in the 'Notification Rules' section. finAPI will call this URL with HTTP method POST. Note that the response of the call is not processed by finAPI. Also note that while the callback URL may be a non-secured (http) URL on the finAPI sandbox or alpha environment, it MUST be a SSL-secured (https) URL on the finAPI live system.<p>The maximum allowed length of the URL is 512. If you have previously set a callback URL and now want to clear it (thus disabling user-related notifications altogether), you can pass an empty string (\"\").
    /// </summary>
    /// <value>Callback URL to which finAPI sends the notification messages that are triggered from the automatic batch update of the users' bank connections. This field is only relevant if the automatic batch update is enabled for your client. For details about what the notification messages look like, please see the documentation in the 'Notification Rules' section. finAPI will call this URL with HTTP method POST. Note that the response of the call is not processed by finAPI. Also note that while the callback URL may be a non-secured (http) URL on the finAPI sandbox or alpha environment, it MUST be a SSL-secured (https) URL on the finAPI live system.<p>The maximum allowed length of the URL is 512. If you have previously set a callback URL and now want to clear it (thus disabling user-related notifications altogether), you can pass an empty string (\"\").</value>
    [DataMember(Name="userNotificationCallbackUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userNotificationCallbackUrl")]
    public string UserNotificationCallbackUrl { get; set; }

    /// <summary>
    /// Callback URL for user synchronization. This field should be set if you - as a finAPI customer - have multiple clients using finAPI. In such case, all of your clients will share the same user base, making it possible for a user to be created in one client, but then deleted in another. To keep the client-side user data consistent in all clients, you should set a callback URL for each client. finAPI will send a notification to the callback URL of each client whenever a user of your user base gets deleted. Note that finAPI will send a deletion notification to ALL clients, including the one that made the user deletion request to finAPI. So when deleting a user in finAPI, a client should rely on the callback to delete the user on its own side. <p>The notification that finAPI sends to the clients' callback URLs will be a POST request, with this body: <pre>{    \"userId\" : string // contains the identifier of the deleted user    \"event\" : string // this will always be \"DELETED\" }</pre><br/>Note that finAPI does not process the response of this call. Also note that while the callback URL may be a non-secured (http) URL on the finAPI sandbox or alpha system, it MUST be a SSL-secured (https) URL on the live system.</p>As long as you have just one client, you can ignore this field and let it be null. However keep in mind that in this case your client will not receive any callback when a user gets deleted - so the deletion of the user on the client-side must not be forgotten. Of course you may still use the callback URL even for just one client, if you want to implement the deletion of the user on the client-side via the callback from finAPI.<p> The maximum allowed length of the URL is 512. If you have previously set a callback URL and now want to clear it (thus disabling user synchronization related notifications for this client), you can pass an empty string (\"\").
    /// </summary>
    /// <value>Callback URL for user synchronization. This field should be set if you - as a finAPI customer - have multiple clients using finAPI. In such case, all of your clients will share the same user base, making it possible for a user to be created in one client, but then deleted in another. To keep the client-side user data consistent in all clients, you should set a callback URL for each client. finAPI will send a notification to the callback URL of each client whenever a user of your user base gets deleted. Note that finAPI will send a deletion notification to ALL clients, including the one that made the user deletion request to finAPI. So when deleting a user in finAPI, a client should rely on the callback to delete the user on its own side. <p>The notification that finAPI sends to the clients' callback URLs will be a POST request, with this body: <pre>{    \"userId\" : string // contains the identifier of the deleted user    \"event\" : string // this will always be \"DELETED\" }</pre><br/>Note that finAPI does not process the response of this call. Also note that while the callback URL may be a non-secured (http) URL on the finAPI sandbox or alpha system, it MUST be a SSL-secured (https) URL on the live system.</p>As long as you have just one client, you can ignore this field and let it be null. However keep in mind that in this case your client will not receive any callback when a user gets deleted - so the deletion of the user on the client-side must not be forgotten. Of course you may still use the callback URL even for just one client, if you want to implement the deletion of the user on the client-side via the callback from finAPI.<p> The maximum allowed length of the URL is 512. If you have previously set a callback URL and now want to clear it (thus disabling user synchronization related notifications for this client), you can pass an empty string (\"\").</value>
    [DataMember(Name="userSynchronizationCallbackUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userSynchronizationCallbackUrl")]
    public string UserSynchronizationCallbackUrl { get; set; }

    /// <summary>
    /// The validity period that newly requested refresh tokens initially have (in seconds). The value must be greater than or equal to 60, or 0. A value of 0 means that the tokens never expire (Unless explicitly invalidated, e.g. by revocation , or when a user gets locked, or when the password is reset for a user).
    /// </summary>
    /// <value>The validity period that newly requested refresh tokens initially have (in seconds). The value must be greater than or equal to 60, or 0. A value of 0 means that the tokens never expire (Unless explicitly invalidated, e.g. by revocation , or when a user gets locked, or when the password is reset for a user).</value>
    [DataMember(Name="refreshTokensValidityPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refreshTokensValidityPeriod")]
    public int? RefreshTokensValidityPeriod { get; set; }

    /// <summary>
    /// The validity period that newly requested access tokens for users initially have (in seconds). The value must be greater than or equal to 60, or 0. A value of 0 means that the tokens never expire.
    /// </summary>
    /// <value>The validity period that newly requested access tokens for users initially have (in seconds). The value must be greater than or equal to 60, or 0. A value of 0 means that the tokens never expire.</value>
    [DataMember(Name="userAccessTokensValidityPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userAccessTokensValidityPeriod")]
    public int? UserAccessTokensValidityPeriod { get; set; }

    /// <summary>
    /// The validity period that newly requested access tokens for clients initially have (in seconds). The value must be greater than or equal to 60, or 0. A value of 0 means that the tokens never expire.
    /// </summary>
    /// <value>The validity period that newly requested access tokens for clients initially have (in seconds). The value must be greater than or equal to 60, or 0. A value of 0 means that the tokens never expire.</value>
    [DataMember(Name="clientAccessTokensValidityPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientAccessTokensValidityPeriod")]
    public int? ClientAccessTokensValidityPeriod { get; set; }

    /// <summary>
    /// Whether <a href='https://finapi.zendesk.com/hc/en-us/articles/360002596391' target='_blank'>finAPI's web form</a> will allow the user to choose whether to store login secrets (like a PIN) in finAPI. If this field is set to false, the option will not be available and the secrets not stored.
    /// </summary>
    /// <value>Whether <a href='https://finapi.zendesk.com/hc/en-us/articles/360002596391' target='_blank'>finAPI's web form</a> will allow the user to choose whether to store login secrets (like a PIN) in finAPI. If this field is set to false, the option will not be available and the secrets not stored.</value>
    [DataMember(Name="storeSecretsAvailableInWebForm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeSecretsAvailableInWebForm")]
    public bool? StoreSecretsAvailableInWebForm { get; set; }

    /// <summary>
    /// When an application name is set (e.g. \"My App\"), then <a href='https://finapi.zendesk.com/hc/en-us/articles/360002596391' target='_blank'>finAPI's web form</a> will display a text to the user \"Weiterleitung auf finAPI von ...\" (e.g. \"Weiterleitung auf finAPI von My App\"). If you have previously set a application name and now want to clear it, you can pass an empty string (\"\"). Maximum length: 64
    /// </summary>
    /// <value>When an application name is set (e.g. \"My App\"), then <a href='https://finapi.zendesk.com/hc/en-us/articles/360002596391' target='_blank'>finAPI's web form</a> will display a text to the user \"Weiterleitung auf finAPI von ...\" (e.g. \"Weiterleitung auf finAPI von My App\"). If you have previously set a application name and now want to clear it, you can pass an empty string (\"\"). Maximum length: 64</value>
    [DataMember(Name="applicationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationName")]
    public string ApplicationName { get; set; }

    /// <summary>
    /// The FinTS product registration number. Please follow <a href='https://www.hbci-zka.de/register/prod_register.htm' target='_blank'>this link</a> to apply for a registration number. Only customers who have an AISP or PISP license must define their FinTS product registration number. Customers who are relying on the finAPI web form will be assigned to finAPI's FinTS product registration number automatically and do not have to register themselves. During a batch update, finAPI is using the FinTS product registration number of the client, that was used to create the user. If you have previously set a FinTS product registration number and now want to clear it, you can pass an empty string (\"\"). Only hexa decimal characters in capital case with a maximum length of 25 characters are allowed. E.g. 'ABCDEF1234567890ABCDEF123'
    /// </summary>
    /// <value>The FinTS product registration number. Please follow <a href='https://www.hbci-zka.de/register/prod_register.htm' target='_blank'>this link</a> to apply for a registration number. Only customers who have an AISP or PISP license must define their FinTS product registration number. Customers who are relying on the finAPI web form will be assigned to finAPI's FinTS product registration number automatically and do not have to register themselves. During a batch update, finAPI is using the FinTS product registration number of the client, that was used to create the user. If you have previously set a FinTS product registration number and now want to clear it, you can pass an empty string (\"\"). Only hexa decimal characters in capital case with a maximum length of 25 characters are allowed. E.g. 'ABCDEF1234567890ABCDEF123'</value>
    [DataMember(Name="finTSProductRegistrationNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finTSProductRegistrationNumber")]
    public string FinTSProductRegistrationNumber { get; set; }

    /// <summary>
    /// Default value for the subject element of support emails. Maximum length is 100. Pass an empty string ('') if you want to clear the current subject default value.
    /// </summary>
    /// <value>Default value for the subject element of support emails. Maximum length is 100. Pass an empty string ('') if you want to clear the current subject default value.</value>
    [DataMember(Name="supportSubjectDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supportSubjectDefault")]
    public string SupportSubjectDefault { get; set; }

    /// <summary>
    /// Email address to sent support requests to from the web form. Maximum length is 320. Pass an empty string ('') if you want to clear the current email address.
    /// </summary>
    /// <value>Email address to sent support requests to from the web form. Maximum length is 320. Pass an empty string ('') if you want to clear the current email address.</value>
    [DataMember(Name="supportEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supportEmail")]
    public string SupportEmail { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClientConfigurationParams {\n");
      sb.Append("  UserNotificationCallbackUrl: ").Append(UserNotificationCallbackUrl).Append("\n");
      sb.Append("  UserSynchronizationCallbackUrl: ").Append(UserSynchronizationCallbackUrl).Append("\n");
      sb.Append("  RefreshTokensValidityPeriod: ").Append(RefreshTokensValidityPeriod).Append("\n");
      sb.Append("  UserAccessTokensValidityPeriod: ").Append(UserAccessTokensValidityPeriod).Append("\n");
      sb.Append("  ClientAccessTokensValidityPeriod: ").Append(ClientAccessTokensValidityPeriod).Append("\n");
      sb.Append("  StoreSecretsAvailableInWebForm: ").Append(StoreSecretsAvailableInWebForm).Append("\n");
      sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
      sb.Append("  FinTSProductRegistrationNumber: ").Append(FinTSProductRegistrationNumber).Append("\n");
      sb.Append("  SupportSubjectDefault: ").Append(SupportSubjectDefault).Append("\n");
      sb.Append("  SupportEmail: ").Append(SupportEmail).Append("\n");
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
