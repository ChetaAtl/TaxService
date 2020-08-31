using System;
using Xunit;
using System.Threading.Tasks;
using TaxjarClient;
using TaxService;

namespace TaxService.Tests
{
    public class UnitTest1
    {
        private readonly TaxjarClient.TaxjarClient taxjarClient;
        private readonly TaxService taxService;
        
        public UnitTest1()
        {
            string strTaxjarApiKey = "5da2f821eee4035db4771edab942a4cc";
            taxjarClient = new TaxjarClient.TaxjarClient(strTaxjarApiKey);

            taxService = new TaxService(taxjarClient);
        }

        [Fact]
        public async Task TestGetRateByZipAsync()
        {
            string strZip = "30024";
            
            string strRate = await taxService.GetTaxRateAsync(strZip);
            string strExpected = "{\"rate\":{\"city\":\"SUWANEE\",\"city_rate\":\"0.0\",\"combined_district_rate\":\"0.0\",\"combined_rate\":\"0.06\",\"country\":\"US\",\"country_rate\":\"0.0\",\"county\":\"GWINNETT\",\"county_rate\":\"0.02\",\"freight_taxable\":true,\"state\":\"GA\",\"state_rate\":\"0.04\",\"zip\":\"30024\"}}";
            Assert.Equal(strExpected, strRate);

        }

        [Fact]
        public async Task TestGetRateByZipAddressAsync()
        {
            string strZip = "30024";
            var address = new Address {Country = "US", City = "Suwanee", Street = "3620 Peachtree Pkwy"};
            
            string strRate = await taxService.GetTaxRateAsync(strZip, address );
            string strExpected = "{\"rate\":{\"city\":\"SUWANEE\",\"city_rate\":\"0.0\",\"combined_district_rate\":\"0.0\",\"combined_rate\":\"0.07\",\"country\":\"US\",\"country_rate\":\"0.0\",\"county\":\"FORSYTH\",\"county_rate\":\"0.03\",\"freight_taxable\":true,\"state\":\"GA\",\"state_rate\":\"0.04\",\"zip\":\"30024-1029\"}}";
            Assert.Equal(strExpected, strRate);

        }

        [Fact]
        public async Task TestGetRateObjectByZipAsync()
        {
            string strZip = "30301";
            
            TaxRate taxRate = await taxService.GetTaxRateObjectAsync(strZip);
            string strExpected = "The tax rate is: zip=30301, country=US, city rate=0.019, combined rate=0.089";
            Assert.Equal(strExpected, taxRate.ToString());

        }

        [Fact]
        public async Task TestGetRateObjectByZipAddressAsync()
        {
            string strZip = "30024";
            var address = new Address {Country = "US", City = "Suwanee", Street = "3620 Peachtree Pkwy"};
            
            TaxRate taxRate = await taxService.GetTaxRateObjectAsync(strZip, address );
            string strExpected = "The tax rate is: zip=30024-1029, country=US, city rate=0.0, combined rate=0.07";
            Assert.Equal(strExpected, taxRate.ToString());

        }

        [Fact]
        public async Task TestTaxForOrderAsync()
        {
            var order = new Order { 
                FromCountry = "US",
                FromZip = "92093",
                FromState = "CA",
                FromCity = "La Jolla",
                FromStreet = "9500 Gilman Drive",
                ToCountry = "US",
                ToZip = "90002",
                ToState = "CA",
                ToCity = "Los Angeles",
                ToStreet = "1335 E 103rd St",
                Amount = 15F,
                Shipping = 1.5F
            };   

            string strTax = await taxService.TaxForOrderAsync(order);  
            string strExpected = "{\"tax\":{\"amount_to_collect\":1.43,\"freight_taxable\":false,\"has_nexus\":true,\"jurisdictions\":{\"city\":\"LOS ANGELES\",\"country\":\"US\",\"county\":\"LOS ANGELES COUNTY\",\"state\":\"CA\"},\"order_total_amount\":16.5,\"rate\":0.095,\"shipping\":1.5,\"tax_source\":\"destination\",\"taxable_amount\":15.0}}";       
            Assert.Equal(strExpected, strTax);

        }
    }
}
