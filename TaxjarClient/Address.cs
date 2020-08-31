using System;

namespace TaxjarClient
{
    // This is a helper class used to construct a call to Tax Jar API: Rates.     
    public class Address
    {
        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }
        public string Street { get; set; }

    }
}