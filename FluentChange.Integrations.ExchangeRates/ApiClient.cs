using RestSharp;

namespace FluentChange.Integrations.ExchangeRates
{

    public class ApiClient
    {
        private static string apiEndpoint = "https://api.exchangeratesapi.io/";
        private RestClient client { get; set; }

        public string Name = "https://exchangeratesapi.io/";
        public ApiClient()
        {       
            client = new RestClient(apiEndpoint);
        }       
      
        public ExchangeRates Latest()
        {
            var request = new RestRequest("latest", Method.GET);
      
            var response = client.Execute<ExchangeRates>(request);
            var data = response.Data;
            return data;

        }   
    }
}
