using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for user information
  /// </summary>
  [DataContract]
  public class UserInfo {
    /// <summary>
    /// User's identifier
    /// </summary>
    /// <value>User's identifier</value>
    [DataMember(Name="userId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userId")]
    public string UserId { get; set; }

    /// <summary>
    /// User's registration date, in the format 'YYYY-MM-DD'
    /// </summary>
    /// <value>User's registration date, in the format 'YYYY-MM-DD'</value>
    [DataMember(Name="registrationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registrationDate")]
    public string RegistrationDate { get; set; }

    /// <summary>
    /// User's deletion date, in the format 'YYYY-MM-DD'. May be null if the user has not been deleted.
    /// </summary>
    /// <value>User's deletion date, in the format 'YYYY-MM-DD'. May be null if the user has not been deleted.</value>
    [DataMember(Name="deletionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deletionDate")]
    public string DeletionDate { get; set; }

    /// <summary>
    /// User's last active date, in the format 'YYYY-MM-DD'. May be null if the user has not yet logged in.
    /// </summary>
    /// <value>User's last active date, in the format 'YYYY-MM-DD'. May be null if the user has not yet logged in.</value>
    [DataMember(Name="lastActiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastActiveDate")]
    public string LastActiveDate { get; set; }

    /// <summary>
    /// Number of bank connections that currently exist for this user.
    /// </summary>
    /// <value>Number of bank connections that currently exist for this user.</value>
    [DataMember(Name="bankConnectionCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankConnectionCount")]
    public int? BankConnectionCount { get; set; }

    /// <summary>
    /// Latest date of when a bank connection was imported for this user, in the format 'YYYY-MM-DD'. This field is null when there has never been a bank connection import.
    /// </summary>
    /// <value>Latest date of when a bank connection was imported for this user, in the format 'YYYY-MM-DD'. This field is null when there has never been a bank connection import.</value>
    [DataMember(Name="latestBankConnectionImportDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latestBankConnectionImportDate")]
    public string LatestBankConnectionImportDate { get; set; }

    /// <summary>
    /// Latest date of when a bank connection was deleted for this user, in the format 'YYYY-MM-DD'. This field is null when there has never been a bank connection deletion.
    /// </summary>
    /// <value>Latest date of when a bank connection was deleted for this user, in the format 'YYYY-MM-DD'. This field is null when there has never been a bank connection deletion.</value>
    [DataMember(Name="latestBankConnectionDeletionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latestBankConnectionDeletionDate")]
    public string LatestBankConnectionDeletionDate { get; set; }

    /// <summary>
    /// Additional information about the user's data or activities, broken down in months. The list will by default contain an entry for each month starting with the month of when the user was registered, up to the current month. The date range may vary when you have limited it in the request. <br/><br/>Please note:<br/>&bull; this field is only set when 'includeMonthlyStats' = true, otherwise it will be null.<br/>&bull; the list is always ordered from the latest month first, to the oldest month last.<br/>&bull; the list will never contain an entry for a month that was prior to the month of when the user was registered, or after the month of when the user was deleted, even when you have explicitly set a respective date range. This means that the list may be empty if you are requesting a date range where the user didn't exist yet, or didn't exist any longer.
    /// </summary>
    /// <value>Additional information about the user's data or activities, broken down in months. The list will by default contain an entry for each month starting with the month of when the user was registered, up to the current month. The date range may vary when you have limited it in the request. <br/><br/>Please note:<br/>&bull; this field is only set when 'includeMonthlyStats' = true, otherwise it will be null.<br/>&bull; the list is always ordered from the latest month first, to the oldest month last.<br/>&bull; the list will never contain an entry for a month that was prior to the month of when the user was registered, or after the month of when the user was deleted, even when you have explicitly set a respective date range. This means that the list may be empty if you are requesting a date range where the user didn't exist yet, or didn't exist any longer.</value>
    [DataMember(Name="monthlyStats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "monthlyStats")]
    public List<MonthlyUserStats> MonthlyStats { get; set; }

    /// <summary>
    /// Whether the user is currently locked (for further information, see the 'maxUserLoginAttempts' setting in your client's configuration). Note that deleted users will always have this field set to 'false'.
    /// </summary>
    /// <value>Whether the user is currently locked (for further information, see the 'maxUserLoginAttempts' setting in your client's configuration). Note that deleted users will always have this field set to 'false'.</value>
    [DataMember(Name="isLocked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isLocked")]
    public bool? IsLocked { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserInfo {\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
      sb.Append("  DeletionDate: ").Append(DeletionDate).Append("\n");
      sb.Append("  LastActiveDate: ").Append(LastActiveDate).Append("\n");
      sb.Append("  BankConnectionCount: ").Append(BankConnectionCount).Append("\n");
      sb.Append("  LatestBankConnectionImportDate: ").Append(LatestBankConnectionImportDate).Append("\n");
      sb.Append("  LatestBankConnectionDeletionDate: ").Append(LatestBankConnectionDeletionDate).Append("\n");
      sb.Append("  MonthlyStats: ").Append(MonthlyStats).Append("\n");
      sb.Append("  IsLocked: ").Append(IsLocked).Append("\n");
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
