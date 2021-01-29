using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for a bank connection owner&#39;s data
  /// </summary>
  [DataContract]
  public class BankConnectionOwner {
    /// <summary>
    /// First name
    /// </summary>
    /// <value>First name</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Last name
    /// </summary>
    /// <value>Last name</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Salutation
    /// </summary>
    /// <value>Salutation</value>
    [DataMember(Name="salutation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "salutation")]
    public string Salutation { get; set; }

    /// <summary>
    /// Title
    /// </summary>
    /// <value>Title</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    /// <value>Email</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Date of birth (in format 'YYYY-MM-DD')
    /// </summary>
    /// <value>Date of birth (in format 'YYYY-MM-DD')</value>
    [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateOfBirth")]
    public string DateOfBirth { get; set; }

    /// <summary>
    /// Post code
    /// </summary>
    /// <value>Post code</value>
    [DataMember(Name="postCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postCode")]
    public string PostCode { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    /// <value>Country</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// City
    /// </summary>
    /// <value>City</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Street
    /// </summary>
    /// <value>Street</value>
    [DataMember(Name="street", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street")]
    public string Street { get; set; }

    /// <summary>
    /// House number
    /// </summary>
    /// <value>House number</value>
    [DataMember(Name="houseNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "houseNumber")]
    public string HouseNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BankConnectionOwner {\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Salutation: ").Append(Salutation).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
      sb.Append("  PostCode: ").Append(PostCode).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Street: ").Append(Street).Append("\n");
      sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
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
