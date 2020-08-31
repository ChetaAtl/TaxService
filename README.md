# The TaxService solution was built using DotNet Core 3.1 and Visual Studio Code. 

# The solution contains five projects. The Project Structure looks like: 

1. c:\projs\TaxService\TaxConsole  
2. c:\projs\TaxService\TaxjarClient
3. c:\projs\TaxService\TaxjarClient.Tests
4. c:\projs\TaxService\TaxService
5. c:\projs\TaxService\TaxService.Tests


# 
# The result of running the TaxConsole project : 
#

c:\projs\TaxService>cd TaxConsole

c:\projs\TaxService\TaxConsole>dotnet run
Welcome! This is a console for some Tax Calculation Testing.

Testing TaxjarClient class ...

{"rate":{"city":"SUWANEE","city_rate":"0.0","combined_district_rate":"0.0","comb
ined_rate":"0.07","country":"US","country_rate":"0.0","county":"FORSYTH","county
_rate":"0.03","freight_taxable":true,"state":"GA","state_rate":"0.04","zip":"300
24-1029"}}


{"tax":{"amount_to_collect":1.43,"freight_taxable":false,"has_nexus":true,"juris
dictions":{"city":"LOS ANGELES","country":"US","county":"LOS ANGELES COUNTY","st
ate":"CA"},"order_total_amount":16.5,"rate":0.095,"shipping":1.5,"tax_source":"d
estination","taxable_amount":15.0}}



Testing TaxService class ...

{"rate":{"city":"SUWANEE","city_rate":"0.0","combined_district_rate":"0.0","comb
ined_rate":"0.06","country":"US","country_rate":"0.0","county":"GWINNETT","count
y_rate":"0.02","freight_taxable":true,"state":"GA","state_rate":"0.04","zip":"30
024"}}


{"rate":{"city":"SUWANEE","city_rate":"0.0","combined_district_rate":"0.0","comb
ined_rate":"0.07","country":"US","country_rate":"0.0","county":"FORSYTH","county
_rate":"0.03","freight_taxable":true,"state":"GA","state_rate":"0.04","zip":"300
24-1029"}}


The tax rate is: zip=30301, country=US, city rate=0.019, combined rate=0.089


The tax rate is: zip=30024-1029, country=US, city rate=0.0, combined rate=0.07


{"tax":{"amount_to_collect":1.43,"freight_taxable":false,"has_nexus":true,"juris
dictions":{"city":"LOS ANGELES","country":"US","county":"LOS ANGELES COUNTY","st
ate":"CA"},"order_total_amount":16.5,"rate":0.095,"shipping":1.5,"tax_source":"d
estination","taxable_amount":15.0}}


# 
# The result of running the TaxjarClient.Tests project : 
#

c:\projs\TaxService\TaxjarClient.Tests>dotnet test
Test run for c:\projs\TaxService\TaxjarClient.Tests\bin\Debug\netcoreapp3.1\TaxjarClient.Tests.dll(.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.7.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.

Test Run Successful.
Total tests: 5
     Passed: 5
 Total time: 5.1802 Seconds


# 
# The result of running the TaxService.Tests project : 
#

c:\projs\TaxService\TaxService.Tests>dotnet test
Test run for c:\projs\TaxService\TaxService.Tests\bin\Debug\netcoreapp3.1\TaxSer
vice.Tests.dll(.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.7.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.

Test Run Successful.
Total tests: 5
     Passed: 5
 Total time: 2.9221 Seconds


