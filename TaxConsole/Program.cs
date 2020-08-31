using System;
using System.Threading.Tasks;
using TaxjarClient;
using TaxService;

namespace TaxConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome! This is a console for some Tax Calculation Testing.");
            Console.WriteLine("");

            // The API key can be stored in a Azure key vault for security purpose
            // Hard coded for now 
            string strTaxjarApiKey = "5da2f821eee4035db4771edab942a4cc";

            // test data / parameter preparation 
            string strZip = "30024";
            var address = new Address {Country = "US", City = "Suwanee", Street = "3620 Peachtree Pkwy"};
            
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

            string strRate ;
            TaxRate taxRate;
            string strTax; 
            
            // Testing TaxjarClient class
            Console.WriteLine("Testing TaxjarClient class ... \n");

            var taxjarClient = new TaxjarClient.TaxjarClient(strTaxjarApiKey); 
            
            strRate = await taxjarClient.GetTaxRateAsync(strZip, address );
            Console.WriteLine(strRate);
            Console.WriteLine("\n");

            strTax = await taxjarClient.TaxForOrderAsync(order);
            Console.WriteLine(strTax);
            Console.WriteLine("\n\n");

            // Testing TaxService class
            Console.WriteLine("Testing TaxService class ... \n");

            var taxService = new TaxService.TaxService(taxjarClient); 

            strRate = await taxService.GetTaxRateAsync(strZip);
            Console.WriteLine(strRate);
            Console.WriteLine("\n");

            strRate = await taxService.GetTaxRateAsync(strZip, address);
            Console.WriteLine(strRate);
            Console.WriteLine("\n");
            
            taxRate = await taxService.GetTaxRateObjectAsync("30301");
            Console.WriteLine(taxRate.ToString());
            Console.WriteLine("\n");

            taxRate = await taxService.GetTaxRateObjectAsync(strZip, address);
            Console.WriteLine(taxRate.ToString());
            Console.WriteLine("\n");
            
            strTax = await taxService.TaxForOrderAsync(order);
            Console.WriteLine(strTax);

        }
    }
}
