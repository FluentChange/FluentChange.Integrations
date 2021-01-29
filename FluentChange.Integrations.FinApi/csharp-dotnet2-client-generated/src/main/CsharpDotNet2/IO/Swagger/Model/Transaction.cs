using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for a transaction&#39;s data
  /// </summary>
  [DataContract]
  public class Transaction {
    /// <summary>
    /// Transaction identifier
    /// </summary>
    /// <value>Transaction identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Parent transaction identifier
    /// </summary>
    /// <value>Parent transaction identifier</value>
    [DataMember(Name="parentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentId")]
    public long? ParentId { get; set; }

    /// <summary>
    /// Account identifier
    /// </summary>
    /// <value>Account identifier</value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// Value date in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).
    /// </summary>
    /// <value>Value date in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).</value>
    [DataMember(Name="valueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueDate")]
    public string ValueDate { get; set; }

    /// <summary>
    /// Bank booking date in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).
    /// </summary>
    /// <value>Bank booking date in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).</value>
    [DataMember(Name="bankBookingDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankBookingDate")]
    public string BankBookingDate { get; set; }

    /// <summary>
    /// finAPI Booking date in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time). NOTE: In some cases, banks may deliver transactions that are booked in future, but already included in the current account balance. To keep the account balance consistent with the set of transactions, such \"future transactions\" will be imported with their finapiBookingDate set to the current date (i.e.: date of import). The finapiBookingDate will automatically get adjusted towards the bankBookingDate each time the associated bank account is updated. Example: A transaction is imported on July, 3rd, with a bank reported booking date of July, 6th. The transaction will be imported with its finapiBookingDate set to July, 3rd. Then, on July 4th, the associated account is updated. During this update, the transaction's finapiBookingDate will be automatically adjusted to July 4th. This adjustment of the finapiBookingDate takes place on each update until the bank account is updated on July 6th or later, in which case the transaction's finapiBookingDate will be adjusted to its final value, July 6th.<br/> The finapiBookingDate is the date that is used by the finAPI PFM services. E.g. when you calculate the spendings of an account for the current month, and have a transaction with finapiBookingDate in the current month but bankBookingDate at the beginning of the next month, then this transaction is included in the calculations (as the bank has this transaction's amount included in the current account balance as well).
    /// </summary>
    /// <value>finAPI Booking date in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time). NOTE: In some cases, banks may deliver transactions that are booked in future, but already included in the current account balance. To keep the account balance consistent with the set of transactions, such \"future transactions\" will be imported with their finapiBookingDate set to the current date (i.e.: date of import). The finapiBookingDate will automatically get adjusted towards the bankBookingDate each time the associated bank account is updated. Example: A transaction is imported on July, 3rd, with a bank reported booking date of July, 6th. The transaction will be imported with its finapiBookingDate set to July, 3rd. Then, on July 4th, the associated account is updated. During this update, the transaction's finapiBookingDate will be automatically adjusted to July 4th. This adjustment of the finapiBookingDate takes place on each update until the bank account is updated on July 6th or later, in which case the transaction's finapiBookingDate will be adjusted to its final value, July 6th.<br/> The finapiBookingDate is the date that is used by the finAPI PFM services. E.g. when you calculate the spendings of an account for the current month, and have a transaction with finapiBookingDate in the current month but bankBookingDate at the beginning of the next month, then this transaction is included in the calculations (as the bank has this transaction's amount included in the current account balance as well).</value>
    [DataMember(Name="finapiBookingDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finapiBookingDate")]
    public string FinapiBookingDate { get; set; }

    /// <summary>
    /// Transaction amount
    /// </summary>
    /// <value>Transaction amount</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Transaction purpose. Maximum length: 2000
    /// </summary>
    /// <value>Transaction purpose. Maximum length: 2000</value>
    [DataMember(Name="purpose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purpose")]
    public string Purpose { get; set; }

    /// <summary>
    /// Counterpart name. Maximum length: 80
    /// </summary>
    /// <value>Counterpart name. Maximum length: 80</value>
    [DataMember(Name="counterpartName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartName")]
    public string CounterpartName { get; set; }

    /// <summary>
    /// Counterpart account number
    /// </summary>
    /// <value>Counterpart account number</value>
    [DataMember(Name="counterpartAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartAccountNumber")]
    public string CounterpartAccountNumber { get; set; }

    /// <summary>
    /// Counterpart IBAN
    /// </summary>
    /// <value>Counterpart IBAN</value>
    [DataMember(Name="counterpartIban", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartIban")]
    public string CounterpartIban { get; set; }

    /// <summary>
    /// Counterpart BLZ
    /// </summary>
    /// <value>Counterpart BLZ</value>
    [DataMember(Name="counterpartBlz", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartBlz")]
    public string CounterpartBlz { get; set; }

    /// <summary>
    /// Counterpart BIC
    /// </summary>
    /// <value>Counterpart BIC</value>
    [DataMember(Name="counterpartBic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartBic")]
    public string CounterpartBic { get; set; }

    /// <summary>
    /// Counterpart Bank name
    /// </summary>
    /// <value>Counterpart Bank name</value>
    [DataMember(Name="counterpartBankName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartBankName")]
    public string CounterpartBankName { get; set; }

    /// <summary>
    /// The mandate reference of the counterpart
    /// </summary>
    /// <value>The mandate reference of the counterpart</value>
    [DataMember(Name="counterpartMandateReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartMandateReference")]
    public string CounterpartMandateReference { get; set; }

    /// <summary>
    /// The customer reference of the counterpart
    /// </summary>
    /// <value>The customer reference of the counterpart</value>
    [DataMember(Name="counterpartCustomerReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartCustomerReference")]
    public string CounterpartCustomerReference { get; set; }

    /// <summary>
    /// The creditor ID of the counterpart. Exists only for SEPA direct debit transactions (\"Lastschrift\").
    /// </summary>
    /// <value>The creditor ID of the counterpart. Exists only for SEPA direct debit transactions (\"Lastschrift\").</value>
    [DataMember(Name="counterpartCreditorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartCreditorId")]
    public string CounterpartCreditorId { get; set; }

    /// <summary>
    /// The originator's identification code. Exists only for SEPA money transfer transactions (\"Überweisung\").
    /// </summary>
    /// <value>The originator's identification code. Exists only for SEPA money transfer transactions (\"Überweisung\").</value>
    [DataMember(Name="counterpartDebitorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterpartDebitorId")]
    public string CounterpartDebitorId { get; set; }

    /// <summary>
    /// Transaction type, according to the bank. If set, this will contain a German term that you can display to the user. Some examples of common values are: \"Lastschrift\", \"Auslands&uuml;berweisung\", \"Geb&uuml;hren\", \"Zinsen\". The maximum possible length of this field is 255 characters.
    /// </summary>
    /// <value>Transaction type, according to the bank. If set, this will contain a German term that you can display to the user. Some examples of common values are: \"Lastschrift\", \"Auslands&uuml;berweisung\", \"Geb&uuml;hren\", \"Zinsen\". The maximum possible length of this field is 255 characters.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// ZKA business transaction code which relates to the transaction's type. Possible values range from 1 through 999. If no information about the ZKA type code is available, then this field will be null.
    /// </summary>
    /// <value>ZKA business transaction code which relates to the transaction's type. Possible values range from 1 through 999. If no information about the ZKA type code is available, then this field will be null.</value>
    [DataMember(Name="typeCodeZka", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typeCodeZka")]
    public string TypeCodeZka { get; set; }

    /// <summary>
    /// SWIFT transaction type code. If no information about the SWIFT code is available, then this field will be null.
    /// </summary>
    /// <value>SWIFT transaction type code. If no information about the SWIFT code is available, then this field will be null.</value>
    [DataMember(Name="typeCodeSwift", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typeCodeSwift")]
    public string TypeCodeSwift { get; set; }

    /// <summary>
    /// SEPA purpose code, according to ISO 20022
    /// </summary>
    /// <value>SEPA purpose code, according to ISO 20022</value>
    [DataMember(Name="sepaPurposeCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sepaPurposeCode")]
    public string SepaPurposeCode { get; set; }

    /// <summary>
    /// Transaction primanota (bank side identification number)
    /// </summary>
    /// <value>Transaction primanota (bank side identification number)</value>
    [DataMember(Name="primanota", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primanota")]
    public string Primanota { get; set; }

    /// <summary>
    /// Transaction category, if any is assigned. Note: Recently imported transactions that have currently no category assigned might still get categorized by the background categorization process. To check the status of the background categorization, see GET /bankConnections. Manual category assignments to a transaction will remove the transaction from the background categorization process (i.e. the background categorization process will never overwrite a manual category assignment).
    /// </summary>
    /// <value>Transaction category, if any is assigned. Note: Recently imported transactions that have currently no category assigned might still get categorized by the background categorization process. To check the status of the background categorization, see GET /bankConnections. Manual category assignments to a transaction will remove the transaction from the background categorization process (i.e. the background categorization process will never overwrite a manual category assignment).</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public Category Category { get; set; }

    /// <summary>
    /// Array of assigned labels
    /// </summary>
    /// <value>Array of assigned labels</value>
    [DataMember(Name="labels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labels")]
    public List<Label> Labels { get; set; }

    /// <summary>
    /// While finAPI uses a well-elaborated algorithm for uniquely identifying transactions, there is still the possibility that during an account update, a transaction that was imported previously may be imported a second time as a new transaction. For example, this can happen if some transaction data changes on the bank server side. However, finAPI also includes an algorithm of identifying such \"potential duplicate\" transactions. If this field is set to true, it means that finAPI detected a similar transaction that might actually be the same. It is recommended to communicate this information to the end user, and give him an option to delete the transaction in case he confirms that it really is a duplicate.
    /// </summary>
    /// <value>While finAPI uses a well-elaborated algorithm for uniquely identifying transactions, there is still the possibility that during an account update, a transaction that was imported previously may be imported a second time as a new transaction. For example, this can happen if some transaction data changes on the bank server side. However, finAPI also includes an algorithm of identifying such \"potential duplicate\" transactions. If this field is set to true, it means that finAPI detected a similar transaction that might actually be the same. It is recommended to communicate this information to the end user, and give him an option to delete the transaction in case he confirms that it really is a duplicate.</value>
    [DataMember(Name="isPotentialDuplicate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPotentialDuplicate")]
    public bool? IsPotentialDuplicate { get; set; }

    /// <summary>
    /// Indicating whether this transaction is an adjusting entry ('Zwischensaldo').<br/><br/>Adjusting entries do not originate from the bank, but are added by finAPI during an account update when the bank reported account balance does not add up to the set of transactions that finAPI receives for the account. In this case, the adjusting entry will fix the deviation between the balance and the received transactions so that both adds up again.<br/><br/>Possible causes for such deviations are:<br/>- Inconsistencies in how the bank calculates the balance, for instance when not yet booked transactions are already included in the balance, but not included in the set of transactions<br/>- Gaps in the transaction history that finAPI receives, for instance because the account has not been updated for a while and older transactions are no longer available
    /// </summary>
    /// <value>Indicating whether this transaction is an adjusting entry ('Zwischensaldo').<br/><br/>Adjusting entries do not originate from the bank, but are added by finAPI during an account update when the bank reported account balance does not add up to the set of transactions that finAPI receives for the account. In this case, the adjusting entry will fix the deviation between the balance and the received transactions so that both adds up again.<br/><br/>Possible causes for such deviations are:<br/>- Inconsistencies in how the bank calculates the balance, for instance when not yet booked transactions are already included in the balance, but not included in the set of transactions<br/>- Gaps in the transaction history that finAPI receives, for instance because the account has not been updated for a while and older transactions are no longer available</value>
    [DataMember(Name="isAdjustingEntry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAdjustingEntry")]
    public bool? IsAdjustingEntry { get; set; }

    /// <summary>
    /// Indicating whether this transaction is 'new' or not. Any newly imported transaction will have this flag initially set to true. How you use this field is up to your interpretation. For example, you might want to set it to false once a user has clicked on/seen the transaction. You can change this flag to 'false' with the PATCH method.
    /// </summary>
    /// <value>Indicating whether this transaction is 'new' or not. Any newly imported transaction will have this flag initially set to true. How you use this field is up to your interpretation. For example, you might want to set it to false once a user has clicked on/seen the transaction. You can change this flag to 'false' with the PATCH method.</value>
    [DataMember(Name="isNew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isNew")]
    public bool? IsNew { get; set; }

    /// <summary>
    /// Date of transaction import, in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).
    /// </summary>
    /// <value>Date of transaction import, in the format 'YYYY-MM-DD HH:MM:SS.SSS' (german time).</value>
    [DataMember(Name="importDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "importDate")]
    public string ImportDate { get; set; }

    /// <summary>
    /// Sub-transactions identifiers (if this transaction is split)
    /// </summary>
    /// <value>Sub-transactions identifiers (if this transaction is split)</value>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public List<long?> Children { get; set; }

    /// <summary>
    /// End-To-End reference
    /// </summary>
    /// <value>End-To-End reference</value>
    [DataMember(Name="endToEndReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endToEndReference")]
    public string EndToEndReference { get; set; }

    /// <summary>
    /// Compensation Amount. Sum of reimbursement of out-of-pocket expenses plus processing brokerage in case of a national return / refund debit as well as an optional interest equalisation. Exists predominantly for SEPA direct debit returns.
    /// </summary>
    /// <value>Compensation Amount. Sum of reimbursement of out-of-pocket expenses plus processing brokerage in case of a national return / refund debit as well as an optional interest equalisation. Exists predominantly for SEPA direct debit returns.</value>
    [DataMember(Name="compensationAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "compensationAmount")]
    public decimal? CompensationAmount { get; set; }

    /// <summary>
    /// Original Amount of the original direct debit. Exists predominantly for SEPA direct debit returns.
    /// </summary>
    /// <value>Original Amount of the original direct debit. Exists predominantly for SEPA direct debit returns.</value>
    [DataMember(Name="originalAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalAmount")]
    public decimal? OriginalAmount { get; set; }

    /// <summary>
    /// Payer's/debtor's reference party (in the case of a credit transfer) or payee's/creditor's reference party (in the case of a direct debit)
    /// </summary>
    /// <value>Payer's/debtor's reference party (in the case of a credit transfer) or payee's/creditor's reference party (in the case of a direct debit)</value>
    [DataMember(Name="differentDebitor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "differentDebitor")]
    public string DifferentDebitor { get; set; }

    /// <summary>
    /// Payee's/creditor's reference party (in the case of a credit transfer) or payer's/debtor's reference party (in the case of a direct debit)
    /// </summary>
    /// <value>Payee's/creditor's reference party (in the case of a credit transfer) or payer's/debtor's reference party (in the case of a direct debit)</value>
    [DataMember(Name="differentCreditor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "differentCreditor")]
    public string DifferentCreditor { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Transaction {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  ValueDate: ").Append(ValueDate).Append("\n");
      sb.Append("  BankBookingDate: ").Append(BankBookingDate).Append("\n");
      sb.Append("  FinapiBookingDate: ").Append(FinapiBookingDate).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Purpose: ").Append(Purpose).Append("\n");
      sb.Append("  CounterpartName: ").Append(CounterpartName).Append("\n");
      sb.Append("  CounterpartAccountNumber: ").Append(CounterpartAccountNumber).Append("\n");
      sb.Append("  CounterpartIban: ").Append(CounterpartIban).Append("\n");
      sb.Append("  CounterpartBlz: ").Append(CounterpartBlz).Append("\n");
      sb.Append("  CounterpartBic: ").Append(CounterpartBic).Append("\n");
      sb.Append("  CounterpartBankName: ").Append(CounterpartBankName).Append("\n");
      sb.Append("  CounterpartMandateReference: ").Append(CounterpartMandateReference).Append("\n");
      sb.Append("  CounterpartCustomerReference: ").Append(CounterpartCustomerReference).Append("\n");
      sb.Append("  CounterpartCreditorId: ").Append(CounterpartCreditorId).Append("\n");
      sb.Append("  CounterpartDebitorId: ").Append(CounterpartDebitorId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TypeCodeZka: ").Append(TypeCodeZka).Append("\n");
      sb.Append("  TypeCodeSwift: ").Append(TypeCodeSwift).Append("\n");
      sb.Append("  SepaPurposeCode: ").Append(SepaPurposeCode).Append("\n");
      sb.Append("  Primanota: ").Append(Primanota).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Labels: ").Append(Labels).Append("\n");
      sb.Append("  IsPotentialDuplicate: ").Append(IsPotentialDuplicate).Append("\n");
      sb.Append("  IsAdjustingEntry: ").Append(IsAdjustingEntry).Append("\n");
      sb.Append("  IsNew: ").Append(IsNew).Append("\n");
      sb.Append("  ImportDate: ").Append(ImportDate).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
      sb.Append("  EndToEndReference: ").Append(EndToEndReference).Append("\n");
      sb.Append("  CompensationAmount: ").Append(CompensationAmount).Append("\n");
      sb.Append("  OriginalAmount: ").Append(OriginalAmount).Append("\n");
      sb.Append("  DifferentDebitor: ").Append(DifferentDebitor).Append("\n");
      sb.Append("  DifferentCreditor: ").Append(DifferentCreditor).Append("\n");
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
