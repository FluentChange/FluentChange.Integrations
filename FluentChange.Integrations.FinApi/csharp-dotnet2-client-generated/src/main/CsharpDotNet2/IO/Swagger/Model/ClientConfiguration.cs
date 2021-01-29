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
  public class ClientConfiguration {
    /// <summary>
    /// Whether finAPI performs a regular automatic update of your users' bank connections. To find out how the automatic batch update is configured for your client, i.e. which bank connections get updated, and at which time and interval, please contact your Sys-Admin. Note that even if the automatic batch update is enabled for your client, individual users can still disable the feature for their own bank connections.
    /// </summary>
    /// <value>Whether finAPI performs a regular automatic update of your users' bank connections. To find out how the automatic batch update is configured for your client, i.e. which bank connections get updated, and at which time and interval, please contact your Sys-Admin. Note that even if the automatic batch update is enabled for your client, individual users can still disable the feature for their own bank connections.</value>
    [DataMember(Name="isAutomaticBatchUpdateEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAutomaticBatchUpdateEnabled")]
    public bool? IsAutomaticBatchUpdateEnabled { get; set; }

    /// <summary>
    /// Callback URL to which finAPI sends the notification messages that are triggered from the automatic batch update of the users' bank connections. This field is only relevant if the automatic batch update is enabled for your client. For details about what the notification messages look like, please see the documentation in the 'Notification Rules' section. finAPI will call this URL with HTTP method POST. Note that the response of the call is not processed by finAPI. Also note that while the callback URL may be a non-secured (http) URL on the finAPI sandbox or alpha environment, it MUST be a SSL-secured (https) URL on the finAPI live system.
    /// </summary>
    /// <value>Callback URL to which finAPI sends the notification messages that are triggered from the automatic batch update of the users' bank connections. This field is only relevant if the automatic batch update is enabled for your client. For details about what the notification messages look like, please see the documentation in the 'Notification Rules' section. finAPI will call this URL with HTTP method POST. Note that the response of the call is not processed by finAPI. Also note that while the callback URL may be a non-secured (http) URL on the finAPI sandbox or alpha environment, it MUST be a SSL-secured (https) URL on the finAPI live system.</value>
    [DataMember(Name="userNotificationCallbackUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userNotificationCallbackUrl")]
    public string UserNotificationCallbackUrl { get; set; }

    /// <summary>
    /// Callback URL for user synchronization. This field should be set if you - as a finAPI customer - have multiple clients using finAPI. In such case, all of your clients will share the same user base, making it possible for a user to be created in one client, but then deleted in another. To keep the client-side user data consistent in all clients, you should set a callback URL for each client. finAPI will send a notification to the callback URL of each client whenever a user of your user base gets deleted. Note that finAPI will send a deletion notification to ALL clients, including the one that made the user deletion request to finAPI. So when deleting a user in finAPI, a client should rely on the callback to delete the user on its own side. <p>The notification that finAPI sends to the clients' callback URLs will be a POST request, with this body: <pre>{    \"userId\" : string // contains the identifier of the deleted user    \"event\" : string // this will always be \"DELETED\" }</pre><br/>Note that finAPI does not process the response of this call. Also note that while the callback URL may be a non-secured (http) URL on the finAPI sandbox or alpha environment, it MUST be a SSL-secured (https) URL on the finAPI live system.</p>As long as you have just one client, you can ignore this field and let it be null. However keep in mind that in this case your client will not receive any callback when a user gets deleted - so the deletion of the user on the client-side must not be forgotten. Of course you may still use the callback URL even for just one client, if you want to implement the deletion of the user on the client-side via the callback from finAPI.
    /// </summary>
    /// <value>Callback URL for user synchronization. This field should be set if you - as a finAPI customer - have multiple clients using finAPI. In such case, all of your clients will share the same user base, making it possible for a user to be created in one client, but then deleted in another. To keep the client-side user data consistent in all clients, you should set a callback URL for each client. finAPI will send a notification to the callback URL of each client whenever a user of your user base gets deleted. Note that finAPI will send a deletion notification to ALL clients, including the one that made the user deletion request to finAPI. So when deleting a user in finAPI, a client should rely on the callback to delete the user on its own side. <p>The notification that finAPI sends to the clients' callback URLs will be a POST request, with this body: <pre>{    \"userId\" : string // contains the identifier of the deleted user    \"event\" : string // this will always be \"DELETED\" }</pre><br/>Note that finAPI does not process the response of this call. Also note that while the callback URL may be a non-secured (http) URL on the finAPI sandbox or alpha environment, it MUST be a SSL-secured (https) URL on the finAPI live system.</p>As long as you have just one client, you can ignore this field and let it be null. However keep in mind that in this case your client will not receive any callback when a user gets deleted - so the deletion of the user on the client-side must not be forgotten. Of course you may still use the callback URL even for just one client, if you want to implement the deletion of the user on the client-side via the callback from finAPI.</value>
    [DataMember(Name="userSynchronizationCallbackUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userSynchronizationCallbackUrl")]
    public string UserSynchronizationCallbackUrl { get; set; }

    /// <summary>
    /// The validity period that newly requested refresh tokens initially have (in seconds). A value of 0 means that the tokens never expire (Unless explicitly invalidated, e.g. by revocation, or when a user gets locked, or when the password is reset for a user).
    /// </summary>
    /// <value>The validity period that newly requested refresh tokens initially have (in seconds). A value of 0 means that the tokens never expire (Unless explicitly invalidated, e.g. by revocation, or when a user gets locked, or when the password is reset for a user).</value>
    [DataMember(Name="refreshTokensValidityPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refreshTokensValidityPeriod")]
    public int? RefreshTokensValidityPeriod { get; set; }

    /// <summary>
    /// The validity period that newly requested access tokens for users initially have (in seconds). A value of 0 means that the tokens never expire (Unless explicitly invalidated, e.g. by revocation, or when a user gets locked, or when the password is reset for a user).
    /// </summary>
    /// <value>The validity period that newly requested access tokens for users initially have (in seconds). A value of 0 means that the tokens never expire (Unless explicitly invalidated, e.g. by revocation, or when a user gets locked, or when the password is reset for a user).</value>
    [DataMember(Name="userAccessTokensValidityPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userAccessTokensValidityPeriod")]
    public int? UserAccessTokensValidityPeriod { get; set; }

    /// <summary>
    /// The validity period that newly requested access tokens for clients initially have (in seconds). A value of 0 means that the tokens never expire (Unless explicitly invalidated, e.g. by revocation).
    /// </summary>
    /// <value>The validity period that newly requested access tokens for clients initially have (in seconds). A value of 0 means that the tokens never expire (Unless explicitly invalidated, e.g. by revocation).</value>
    [DataMember(Name="clientAccessTokensValidityPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientAccessTokensValidityPeriod")]
    public int? ClientAccessTokensValidityPeriod { get; set; }

    /// <summary>
    /// Number of consecutive failed login attempts of a user into his finAPI account that is allowed before finAPI locks the user's account. When a user's account is locked, finAPI will invalidate all user's tokens and it will deny any service call in the context of this user (i.e. any call to a service using one of the user's authorization tokens, as well as the service for requesting a new token for this user). To unlock a user's account, a new password must be set for the account by the client (see the services /users/requestPasswordChange and /users/executePasswordChange). Once a new password has been set, all services will be available again for this user and the user's failed login attempts counter is reset to 0. The user's failed login attempts counter is also reset whenever a new authorization token has been successfully retrieved, or whenever the user himself changes his password.<br/><br/>Note that when this field has a value of 0, it means that there is no limit for user login attempts, i.e. finAPI will never lock user accounts.
    /// </summary>
    /// <value>Number of consecutive failed login attempts of a user into his finAPI account that is allowed before finAPI locks the user's account. When a user's account is locked, finAPI will invalidate all user's tokens and it will deny any service call in the context of this user (i.e. any call to a service using one of the user's authorization tokens, as well as the service for requesting a new token for this user). To unlock a user's account, a new password must be set for the account by the client (see the services /users/requestPasswordChange and /users/executePasswordChange). Once a new password has been set, all services will be available again for this user and the user's failed login attempts counter is reset to 0. The user's failed login attempts counter is also reset whenever a new authorization token has been successfully retrieved, or whenever the user himself changes his password.<br/><br/>Note that when this field has a value of 0, it means that there is no limit for user login attempts, i.e. finAPI will never lock user accounts.</value>
    [DataMember(Name="maxUserLoginAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxUserLoginAttempts")]
    public int? MaxUserLoginAttempts { get; set; }

    /// <summary>
    /// Whether users that are created with this client are automatically verified on creation. If this field is set to 'false', then any user that is created with this client must first be verified with the \"Verify a user\" service before he can be authorized. If the field is 'true', then no verification is required by the client and the user can be authorized immediately after creation.
    /// </summary>
    /// <value>Whether users that are created with this client are automatically verified on creation. If this field is set to 'false', then any user that is created with this client must first be verified with the \"Verify a user\" service before he can be authorized. If the field is 'true', then no verification is required by the client and the user can be authorized immediately after creation.</value>
    [DataMember(Name="isUserAutoVerificationEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isUserAutoVerificationEnabled")]
    public bool? IsUserAutoVerificationEnabled { get; set; }

    /// <summary>
    /// Whether this client is a 'Mandator Admin'. Mandator Admins are special clients that can access the 'Mandator Administration' section of finAPI. If you do not yet have credentials for a Mandator Admin, please contact us at support@finapi.io. For further information, please refer to <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client' target='_blank'>this article</a> on our Dev Portal.
    /// </summary>
    /// <value>Whether this client is a 'Mandator Admin'. Mandator Admins are special clients that can access the 'Mandator Administration' section of finAPI. If you do not yet have credentials for a Mandator Admin, please contact us at support@finapi.io. For further information, please refer to <a href='https://finapi.zendesk.com/hc/en-us/articles/115003661827-Difference-between-app-clients-and-mandator-admin-client' target='_blank'>this article</a> on our Dev Portal.</value>
    [DataMember(Name="isMandatorAdmin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isMandatorAdmin")]
    public bool? IsMandatorAdmin { get; set; }

    /// <summary>
    /// Whether finAPI is allowed to use the WEB_SCRAPER interface for data download. If this field is set to 'true', then finAPI might download data from the online banking websites of banks (either in addition to other interfaces, or as the sole data source for the download). If this field is set to 'false', then finAPI will not use any web scrapers. For banks where no other interface except WEB_SCRAPER is available, finAPI will not allow any data download at all if web scraping is disabled for your client. Please contact your Sys-Admin if you want to change this setting.
    /// </summary>
    /// <value>Whether finAPI is allowed to use the WEB_SCRAPER interface for data download. If this field is set to 'true', then finAPI might download data from the online banking websites of banks (either in addition to other interfaces, or as the sole data source for the download). If this field is set to 'false', then finAPI will not use any web scrapers. For banks where no other interface except WEB_SCRAPER is available, finAPI will not allow any data download at all if web scraping is disabled for your client. Please contact your Sys-Admin if you want to change this setting.</value>
    [DataMember(Name="isWebScrapingEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isWebScrapingEnabled")]
    public bool? IsWebScrapingEnabled { get; set; }

    /// <summary>
    /// Whether the finAPI Payment product is enabled for this client (doing money transfers for accounts that are not imported in finAPI).
    /// </summary>
    /// <value>Whether the finAPI Payment product is enabled for this client (doing money transfers for accounts that are not imported in finAPI).</value>
    [DataMember(Name="isStandalonePaymentsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isStandalonePaymentsEnabled")]
    public bool? IsStandalonePaymentsEnabled { get; set; }

    /// <summary>
    /// List of bank groups that are available to this client. A bank group is a collection of all banks that are located in a certain country, and is defined by the country's ISO 3166 ALPHA-2 code (see also field 'location' of Bank resource). If you want to extend or limit the available bank groups for your client, please contact your Sys-Admin.<br/><br/>Note: There is no bank group for international institutes (i.e. institutes that are not bound to any specific country). Instead, those institutes are always available. If this list is empty, it means that ONLY international institutes are available.
    /// </summary>
    /// <value>List of bank groups that are available to this client. A bank group is a collection of all banks that are located in a certain country, and is defined by the country's ISO 3166 ALPHA-2 code (see also field 'location' of Bank resource). If you want to extend or limit the available bank groups for your client, please contact your Sys-Admin.<br/><br/>Note: There is no bank group for international institutes (i.e. institutes that are not bound to any specific country). Instead, those institutes are always available. If this list is empty, it means that ONLY international institutes are available.</value>
    [DataMember(Name="availableBankGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableBankGroups")]
    public List<string> AvailableBankGroups { get; set; }

    /// <summary>
    /// Application name. When an application name is set (e.g. \"My App\"), then <a href='https://finapi.zendesk.com/hc/en-us/articles/360002596391' target='_blank'>finAPI's web form</a> will display a text to the user \"Weiterleitung auf finAPI von ...\" (e.g. \"Weiterleitung auf finAPI von MyApp\").
    /// </summary>
    /// <value>Application name. When an application name is set (e.g. \"My App\"), then <a href='https://finapi.zendesk.com/hc/en-us/articles/360002596391' target='_blank'>finAPI's web form</a> will display a text to the user \"Weiterleitung auf finAPI von ...\" (e.g. \"Weiterleitung auf finAPI von MyApp\").</value>
    [DataMember(Name="applicationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationName")]
    public string ApplicationName { get; set; }

    /// <summary>
    /// The FinTS product registration number. If a value is stored, this will always be 'XXXXX'.
    /// </summary>
    /// <value>The FinTS product registration number. If a value is stored, this will always be 'XXXXX'.</value>
    [DataMember(Name="finTSProductRegistrationNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finTSProductRegistrationNumber")]
    public string FinTSProductRegistrationNumber { get; set; }

    /// <summary>
    /// Whether <a href='https://finapi.zendesk.com/hc/en-us/articles/360002596391' target='_blank'>finAPI's web form</a> will allow the user to choose whether to store login secrets (like a PIN) in finAPI. If this field is set to false, the option will not be available and the secrets not stored.
    /// </summary>
    /// <value>Whether <a href='https://finapi.zendesk.com/hc/en-us/articles/360002596391' target='_blank'>finAPI's web form</a> will allow the user to choose whether to store login secrets (like a PIN) in finAPI. If this field is set to false, the option will not be available and the secrets not stored.</value>
    [DataMember(Name="storeSecretsAvailableInWebForm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeSecretsAvailableInWebForm")]
    public bool? StoreSecretsAvailableInWebForm { get; set; }

    /// <summary>
    /// Default value for the subject element of support emails.
    /// </summary>
    /// <value>Default value for the subject element of support emails.</value>
    [DataMember(Name="supportSubjectDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supportSubjectDefault")]
    public string SupportSubjectDefault { get; set; }

    /// <summary>
    /// Email address to sent support requests to from the web form.
    /// </summary>
    /// <value>Email address to sent support requests to from the web form.</value>
    [DataMember(Name="supportEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supportEmail")]
    public string SupportEmail { get; set; }

    /// <summary>
    /// Whether this client is allowed to do payments
    /// </summary>
    /// <value>Whether this client is allowed to do payments</value>
    [DataMember(Name="paymentsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentsEnabled")]
    public bool? PaymentsEnabled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClientConfiguration {\n");
      sb.Append("  IsAutomaticBatchUpdateEnabled: ").Append(IsAutomaticBatchUpdateEnabled).Append("\n");
      sb.Append("  UserNotificationCallbackUrl: ").Append(UserNotificationCallbackUrl).Append("\n");
      sb.Append("  UserSynchronizationCallbackUrl: ").Append(UserSynchronizationCallbackUrl).Append("\n");
      sb.Append("  RefreshTokensValidityPeriod: ").Append(RefreshTokensValidityPeriod).Append("\n");
      sb.Append("  UserAccessTokensValidityPeriod: ").Append(UserAccessTokensValidityPeriod).Append("\n");
      sb.Append("  ClientAccessTokensValidityPeriod: ").Append(ClientAccessTokensValidityPeriod).Append("\n");
      sb.Append("  MaxUserLoginAttempts: ").Append(MaxUserLoginAttempts).Append("\n");
      sb.Append("  IsUserAutoVerificationEnabled: ").Append(IsUserAutoVerificationEnabled).Append("\n");
      sb.Append("  IsMandatorAdmin: ").Append(IsMandatorAdmin).Append("\n");
      sb.Append("  IsWebScrapingEnabled: ").Append(IsWebScrapingEnabled).Append("\n");
      sb.Append("  IsStandalonePaymentsEnabled: ").Append(IsStandalonePaymentsEnabled).Append("\n");
      sb.Append("  AvailableBankGroups: ").Append(AvailableBankGroups).Append("\n");
      sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
      sb.Append("  FinTSProductRegistrationNumber: ").Append(FinTSProductRegistrationNumber).Append("\n");
      sb.Append("  StoreSecretsAvailableInWebForm: ").Append(StoreSecretsAvailableInWebForm).Append("\n");
      sb.Append("  SupportSubjectDefault: ").Append(SupportSubjectDefault).Append("\n");
      sb.Append("  SupportEmail: ").Append(SupportEmail).Append("\n");
      sb.Append("  PaymentsEnabled: ").Append(PaymentsEnabled).Append("\n");
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
