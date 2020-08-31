using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text;
using TaxjarClient;

namespace TaxService
{
    // A wrapper class for Tax Jar API client and other similar API clients
    public class TaxService
    {
        TaxCalculator taxCal;
        public TaxService (TaxCalculator taxcal)
        {
            this.taxCal = taxcal;
        }

        public async Task<string> GetTaxRateAsync(string strZip)
        {
            return await this.taxCal.GetTaxRateAsync(strZip);
        }

        public async Task<string> GetTaxRateAsync(string strZip, Address address)
        {
            return await this.taxCal.GetTaxRateAsync(strZip, address);
        }

        public async Task<TaxRate> GetTaxRateObjectAsync(string strZip)
        {
            return await this.taxCal.GetTaxRateObjectAsync(strZip);
        }

        public async Task<TaxRate> GetTaxRateObjectAsync(string strZip, Address address)
        {
            return await this.taxCal.GetTaxRateObjectAsync(strZip, address);
        }

        public async Task<string> TaxForOrderAsync(Order order)
        {
            return await this.taxCal.TaxForOrderAsync(order);
        }
    }

}