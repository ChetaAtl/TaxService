using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TaxjarClient
{
    // Tax Jar API client
    public class TaxjarClient : TaxCalculator
    {
        private string strApiKey;  

        // Potential issue to improve: 
        // This HttpClient client instance should be passed in through the constructors
        // to avoid dependecy during unit testing.    
        private readonly HttpClient client = new HttpClient();

        public TaxjarClient(string strApiKey) 
        { 
            this.strApiKey = strApiKey;
            client.DefaultRequestHeaders.Add("User-Agent", "Tax Jar Client");
            //client.DefaultRequestHeaders.Add("Authorization", "Bearer 5da2f821eee4035db4771edab942a4cc");
            client.DefaultRequestHeaders.Add("Authorization", $"Token token=\"{strApiKey}\"");

        }

        public async Task<string> GetTaxRateAsync(string strZip)
        {            
            var stringTask = client.GetStringAsync($"https://api.taxjar.com/v2/rates/{strZip}");

            var msg = await stringTask;

            return msg;
        }

        public async Task<string> GetTaxRateAsync(string strZip, Address address)
        {            
            var stringTask = client.GetStringAsync($"https://api.taxjar.com/v2/rates/{strZip}?country={address.Country}&state={address.State}&city={address.City}&street={address.Street}");

            var msg = await stringTask;

            return msg;
        }

        public async Task<TaxRate> GetTaxRateObjectAsync(string strZip)
        {            
            var streamTask = client.GetStreamAsync($"https://api.taxjar.com/v2/rates/{strZip}");
            var taxRate = await JsonSerializer.DeserializeAsync<TaxRate>(await streamTask);

            return taxRate;
        }

        public async Task<TaxRate> GetTaxRateObjectAsync(string strZip, Address address)
        {            
            var streamTask = client.GetStreamAsync($"https://api.taxjar.com/v2/rates/{strZip}?country={address.Country}&state={address.State}&city={address.City}&street={address.Street}");
            var taxRate = await JsonSerializer.DeserializeAsync<TaxRate>(await streamTask);

            return taxRate;
        }

        public async Task<string> TaxForOrderAsync(Order order)
        {
            var response = string.Empty;

            var payload = JsonSerializer.Serialize(order);

            HttpContent content = new StringContent(payload, Encoding.UTF8, "application/json");

            HttpResponseMessage result = await client.PostAsync("https://api.taxjar.com/v2/taxes", content);

            if (result.IsSuccessStatusCode)
            {
                response = await result.Content.ReadAsStringAsync();
            }

            return response;            

        }

    }

    
}