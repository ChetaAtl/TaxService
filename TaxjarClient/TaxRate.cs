using System;
using System.Text.Json.Serialization;

namespace TaxjarClient
{
    // TaxRate is the .Net object counterpart of the JSON string returned from Tax Jar API
    public class TaxRate
    {
        [JsonPropertyName("rate")]
        public RateDetail Rate { get; set; }

        public override string ToString()
        {
            return $"The tax rate is: zip={Rate.Zip}, country={Rate.Country}, city rate={Rate.CityRate}, combined rate={Rate.CombinedRate}";
        }

    }
    public class RateDetail
    {
        [JsonPropertyName("zip")]
        public string Zip { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }


        [JsonPropertyName("country_rate")]
        public string CountryRate { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("state_rate")]
        public string StateRate { get; set; }

        [JsonPropertyName("county")]
        public string County { get; set; }


        [JsonPropertyName("county_rate")]
        public string CountyRate { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }
        
        [JsonPropertyName("city_rate")]
        public string CityRate { get; set; }
        
        [JsonPropertyName("combined_district_rate")]
        public string CombinedDistrictRate { get; set; }
        
        [JsonPropertyName("combined_rate")]
        public string CombinedRate { get; set; }
        
        [JsonPropertyName("freight_taxable")]
        public bool FreightTaxable { get; set; }
                
    }

    
}