# Countries

WebApi app that takes data from https://restcountries.com/.

App uses only Oceania countries.
Controller has 4 request methods:

[GET] https://localhost:7277/countries/oceania - returns official name, common name, area, population, tld and capital for all Oceania countries.  
[GET] https://localhost:7277/countries/top10populated returns 10 most populated Oceania countries in descending order.  
[GET] https://localhost:7277/countries/top10dense returns 10 most densely populated Oceania countries in descending order.  
[GET] https://localhost:7277/countries/{name} returns country searched by name.  


Clone repo, run in Visual Studio, use https://localhost:7277/swagger/index.html for requests.
