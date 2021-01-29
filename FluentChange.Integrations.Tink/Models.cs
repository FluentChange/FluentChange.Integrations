using System.Collections.Generic;

namespace FluentChange.Integrations.Tink
{

    public class MarketsResponse
    {
        public List<string> markets { get; set; }
        public MarketsResponse()
        {
            markets = new List<string>();
        }
    }

    public class ProvidersResponse
    {
        public List<Provider> providers { get; set; }
        public ProvidersResponse()
        {
            providers = new List<Provider>();
        }
    }


  
    public class Provider
    {
        public string accessType { get; set; }
        public string authenticationFlow { get; set; }
        public string authenticationUserType { get; set; }
        public List<string> capabilities { get; set; }
        public string credentialsType { get; set; }
        public string currency { get; set; }
        public string displayDescription { get; set; }
        public string displayName { get; set; }
        public List<ProviderField> fields { get; set; }
        public string financialInstitutionId { get; set; }
        public string financialInstitutionName { get; set; }
        public string groupDisplayName { get; set; }
        public ProviderImages images { get; set; }
        public string market { get; set; }
        public bool multiFactor { get; set; }
        public string name { get; set; }
        public string passwordHelpText { get; set; }
        public bool popular { get; set; }
        public string status { get; set; }
        public bool transactional { get; set; }
        public string type { get; set; }

        public Provider()
        {
            capabilities = new List<string>();
            fields = new List<ProviderField>();
        }
    }

    public class ProviderImages
    {
        public string banner { get; set; }
        public string icon { get; set; }
    }

    public class ProviderField
    {
        public string additionalInfo { get; set; }
        public bool checkbox { get; set; }
        public string defaultValue { get; set; }
        public string description { get; set; }
        public string helpText { get; set; }
        public string hint { get; set; }
        public bool immutable { get; set; }
        public bool masked { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
        public string name { get; set; }
        public bool numeric { get; set; }
        public bool optional { get; set; }
        public string[] options { get; set; }
        public string pattern { get; set; }
        public string patternError { get; set; }
        public bool sensitive { get; set; }
        public string value { get; set; }
    }





    public class AccountsRequest
    {
        public List<Account> accounts { get; set; }
        public AccountsRequest()
        {
            accounts = new List<Account>();
        }
    }

    public class Account
    {
        public string accountNumber { get; set; }
        public float availableCredit { get; set; }
        public float balance { get; set; }
        public string bankId { get; set; }
        public long? certainDate { get; set; }
        public string credentialsId { get; set; }
        public bool excluded { get; set; }
        public bool favored { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public float ownership { get; set; }
        public object payload { get; set; }
        public string type { get; set; }
        public string userId { get; set; }
        public bool userModifiedExcluded { get; set; }
        public bool userModifiedName { get; set; }
        public bool userModifiedType { get; set; }
        public string identifiers { get; set; }
        public object transferDestinations { get; set; }
        public Details details { get; set; }
        public ProviderImages images { get; set; }
        public string holderName { get; set; }
        public bool closed { get; set; }
        public string flags { get; set; }
        public string accountExclusion { get; set; }
        public string currencyCode { get; set; }
        public Currencydenominatedbalance currencyDenominatedBalance { get; set; }
        public long refreshed { get; set; }
        public string financialInstitutionId { get; set; }
    }

    public class Details
    {
        public float interest { get; set; }
        public object numMonthsBound { get; set; }
        public string type { get; set; }
        public object nextDayOfTermsChange { get; set; }
    }

   

    public class Currencydenominatedbalance
    {
        public int unscaledValue { get; set; }
        public int scale { get; set; }
        public string currencyCode { get; set; }
    }

    public class TransactionsSearchRequest
    {
        public int count { get; set; }
        public Metrics metrics { get; set; }
        public List<Periodamount> periodAmounts { get; set; }
        public Query query { get; set; }
        public List<Result> results { get; set; }
        public float net { get; set; }
        public TransactionsSearchRequest()
        {
            periodAmounts = new List<Periodamount>();
            results = new List<Result>();
        }
    }

    public class Metrics
    {
        public int COUNT { get; set; }
        public float NET { get; set; }
        public float SUM { get; set; }
        public float AVG { get; set; }
        public CATEGORIES CATEGORIES { get; set; }
    }

    public class CATEGORIES
    {
        public float _075fab3ec31f43aa9d39675475c1fb1a { get; set; }
        public float _83f5dccf39ca43a8a0d4413be23464c6 { get; set; }
        public float _3b52969658164d30930f51a2965ecc65 { get; set; }
        public float bde2284069594e3380941026474cbda2 { get; set; }
        public float _9faddd4c806b48a29301891f6a310c78 { get; set; }
        public float c59a38ff206c4fe29a9e7b2bb1fcb3de { get; set; }
        public float fb7618bd315248eeaac217fec003f89c { get; set; }
        public float b3963cfe6bf54c06b22eaa44e0a6cf3f { get; set; }
        public float _63a7e66150d44c67a3380265c86e1c26 { get; set; }
        public float c22e51b7abfa48088fb500005e21df76 { get; set; }
    }

    public class Query
    {
        //public object[] accounts { get; set; }
        //public object[] categories { get; set; }
        //public object[] externalIds { get; set; }
        public object minAmount { get; set; }
        public object maxAmount { get; set; }
        public object endDate { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public string order { get; set; }
        public string queryString { get; set; }
        public string sort { get; set; }
        public object startDate { get; set; }
        public object transactionId { get; set; }
        public bool includeUpcoming { get; set; }
        public object lastTransactionId { get; set; }
    }

    public class Periodamount
    {
        public string key { get; set; }
        public float value { get; set; }
    }

    public class Result
    {
        public float score { get; set; }
        public long timestamp { get; set; }
        public Transaction transaction { get; set; }
        public string type { get; set; }
    }

    public class Transaction
    {
        public string accountId { get; set; }
        public float amount { get; set; }
        public string categoryId { get; set; }
        public string categoryType { get; set; }
        public long date { get; set; }
        public string description { get; set; }
        public string formattedDescription { get; set; }
        public string id { get; set; }
        public long inserted { get; set; }
        public long lastModified { get; set; }
        public object merchantId { get; set; }
        public string notes { get; set; }
        public float originalAmount { get; set; }
        public long originalDate { get; set; }
        public string originalDescription { get; set; }
        public Payload payload { get; set; }
        public bool pending { get; set; }
        public long timestamp { get; set; }
        public string type { get; set; }
        public string userId { get; set; }
        public bool upcoming { get; set; }
        public bool userModifiedAmount { get; set; }
        public bool userModifiedCategory { get; set; }
        public bool userModifiedDate { get; set; }
        public bool userModifiedDescription { get; set; }
        public bool userModifiedLocation { get; set; }
        public Currencydenominatedamount currencyDenominatedAmount { get; set; }
        public Currencydenominatedoriginalamount currencyDenominatedOriginalAmount { get; set; }
        //public object[] parts { get; set; }
        public Internalpayload internalPayload { get; set; }
        public Partnerpayload partnerPayload { get; set; }
        public float dispensableAmount { get; set; }
        public bool userModified { get; set; }
    }

    public class Payload
    {
    }

    public class Currencydenominatedamount
    {
        public int unscaledValue { get; set; }
        public int scale { get; set; }
        public string currencyCode { get; set; }
    }

    public class Currencydenominatedoriginalamount
    {
        public int unscaledValue { get; set; }
        public int scale { get; set; }
        public string currencyCode { get; set; }
    }

    public class Internalpayload
    {
    }

    public class Partnerpayload
    {
    }

}
