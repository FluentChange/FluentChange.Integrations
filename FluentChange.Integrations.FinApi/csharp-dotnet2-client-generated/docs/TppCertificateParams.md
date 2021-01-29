# IO.Swagger.Model.TppCertificateParams
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | A type of certificate submitted | 
**PublicKey** | **string** | A certificate (public key) | 
**PrivateKey** | **string** | A private key in PKCS #8 or PKCS #1 format. PKCS #1/#8 private keys are typically exchanged in the PEM base64-encoded format (https://support.quovadisglobal.com/kb/a37/what-is-pem-format.aspx)&lt;/br&gt;&lt;/br&gt;NOTE: The certificate should have one of the following headers:&lt;/br&gt;- &#39;- -- --BEGIN RSA PRIVATE KEY- -- --&#39;&lt;br&gt;- &#39;- -- --BEGIN PRIVATE KEY- -- --&#39;&lt;/br&gt;- &#39;- -- --BEGIN ENCRYPTED PRIVATE KEY- -- --&#39;&lt;br&gt;Any other header denotes that the private key is neither in PKCS #8 nor in PKCS #1 formats! | 
**Passphrase** | **string** | Optional passphrase for the private key | [optional] 
**Label** | **string** | A label for certificate to identify in the list of certificates | 
**ValidFromDate** | **string** | Start day of the certificate&#39;s validity, in the format &#39;YYYY-MM-DD&#39;. Default is the passed certificate validFrom date | [optional] 
**ValidUntilDate** | **string** | Expiration day of the certificate&#39;s validity, in the format &#39;YYYY-MM-DD&#39;. Default is the passed certificate validUntil date | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

