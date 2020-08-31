# TaxService

# The solution was built using DotNet Core 3.1 and Visual Studio Code. 

# The solution contains five projects. The Project Structure looks like: 

c:\projs\TaxService>dir
 Volume in drive C is Windows
 Volume Serial Number is 06EE-C6D8

 Directory of c:\projs\TaxService

08/31/2020  03:00 PM    <DIR>          .
08/31/2020  03:00 PM    <DIR>          ..
08/31/2020  12:44 PM               823 .gitignore
08/31/2020  03:10 AM    <DIR>          .vscode
08/30/2020  05:48 PM    <DIR>          TaxConsole
08/30/2020  07:00 PM    <DIR>          TaxjarClient
08/30/2020  04:43 PM    <DIR>          TaxjarClient.Tests
08/30/2020  06:05 PM    <DIR>          TaxService
08/31/2020  01:54 AM             5,133 TaxService.sln
08/31/2020  02:14 AM    <DIR>          TaxService.Tests
               2 File(s)          5,956 bytes
               8 Dir(s)  142,948,630,528 bytes free


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
Test run for c:\projs\TaxService\TaxjarClient.Tests\bin\Debug\netcoreapp3.1\Taxj
arClient.Tests.dll(.NETCoreApp,Version=v3.1)
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


