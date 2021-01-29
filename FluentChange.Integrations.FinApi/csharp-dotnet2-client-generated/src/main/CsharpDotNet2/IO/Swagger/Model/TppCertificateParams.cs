using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A container for the new certificate data
  /// </summary>
  [DataContract]
  public class TppCertificateParams {
    /// <summary>
    /// A type of certificate submitted
    /// </summary>
    /// <value>A type of certificate submitted</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// A certificate (public key)
    /// </summary>
    /// <value>A certificate (public key)</value>
    [DataMember(Name="publicKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publicKey")]
    public string PublicKey { get; set; }

    /// <summary>
    /// A private key in PKCS #8 or PKCS #1 format. PKCS #1/#8 private keys are typically exchanged in the PEM base64-encoded format (https://support.quovadisglobal.com/kb/a37/what-is-pem-format.aspx)</br></br>NOTE: The certificate should have one of the following headers:</br>- '- -- --BEGIN RSA PRIVATE KEY- -- --'<br>- '- -- --BEGIN PRIVATE KEY- -- --'</br>- '- -- --BEGIN ENCRYPTED PRIVATE KEY- -- --'<br>Any other header denotes that the private key is neither in PKCS #8 nor in PKCS #1 formats!
    /// </summary>
    /// <value>A private key in PKCS #8 or PKCS #1 format. PKCS #1/#8 private keys are typically exchanged in the PEM base64-encoded format (https://support.quovadisglobal.com/kb/a37/what-is-pem-format.aspx)</br></br>NOTE: The certificate should have one of the following headers:</br>- '- -- --BEGIN RSA PRIVATE KEY- -- --'<br>- '- -- --BEGIN PRIVATE KEY- -- --'</br>- '- -- --BEGIN ENCRYPTED PRIVATE KEY- -- --'<br>Any other header denotes that the private key is neither in PKCS #8 nor in PKCS #1 formats!</value>
    [DataMember(Name="privateKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privateKey")]
    public string PrivateKey { get; set; }

    /// <summary>
    /// Optional passphrase for the private key
    /// </summary>
    /// <value>Optional passphrase for the private key</value>
    [DataMember(Name="passphrase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passphrase")]
    public string Passphrase { get; set; }

    /// <summary>
    /// A label for certificate to identify in the list of certificates
    /// </summary>
    /// <value>A label for certificate to identify in the list of certificates</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// Start day of the certificate's validity, in the format 'YYYY-MM-DD'. Default is the passed certificate validFrom date
    /// </summary>
    /// <value>Start day of the certificate's validity, in the format 'YYYY-MM-DD'. Default is the passed certificate validFrom date</value>
    [DataMember(Name="validFromDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validFromDate")]
    public string ValidFromDate { get; set; }

    /// <summary>
    /// Expiration day of the certificate's validity, in the format 'YYYY-MM-DD'. Default is the passed certificate validUntil date
    /// </summary>
    /// <value>Expiration day of the certificate's validity, in the format 'YYYY-MM-DD'. Default is the passed certificate validUntil date</value>
    [DataMember(Name="validUntilDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validUntilDate")]
    public string ValidUntilDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TppCertificateParams {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
      sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
      sb.Append("  Passphrase: ").Append(Passphrase).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  ValidFromDate: ").Append(ValidFromDate).Append("\n");
      sb.Append("  ValidUntilDate: ").Append(ValidUntilDate).Append("\n");
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
