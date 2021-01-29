using System;
using System.Collections.Generic;

namespace FluentChange.Integrations.ExchangeRates
{
    public class ExchangeRates
    {
        public Dictionary<string,double> rates { get; set; }
        public string @base { get; set; }
        public DateTime date { get; set; }

        public ExchangeRates()
        {
            rates = new Dictionary<string, double>();
        }
    }
}
