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
    // A common interface to be implemented by all Tax Calculator API clients
    // assuming all Tax Calculator API's to be used will have all these similar methods   
    public interface TaxCalculator
    {
        Task<string> GetTaxRateAsync(string strZip);
        
        Task<string> GetTaxRateAsync(string strZip, Address address);

        Task<TaxRate> GetTaxRateObjectAsync(string strZip);
        
        Task<TaxRate> GetTaxRateObjectAsync(string strZip, Address address);

        Task<string> TaxForOrderAsync(Order order);
    }

}