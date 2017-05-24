![alt tag](https://raw.githubusercontent.com/fabian7593/CountryAPI/master/Files/imgsReadme/totalLogo.png)

A Rest Api of country information that you need.

EndPoint Request: [http://countryapi.gear.host/v1/Country/getCountries](http://countryapi.gear.host/v1/Country/getCountries)

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/c17666154d7a45af892e2b67a4639448)](https://www.codacy.com/app/fabian7593/CountryAPI?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=fabian7593/CountryAPI&amp;utm_campaign=Badge_Grade)
[![License](https://img.shields.io/badge/license-Apache%202-4EB1BA.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)

## Contents
### How to Use
- [What is CountryAPI](#what-is-countryapi)
- [Why use CountryAPI](#why-use-countryapi)
- [Executing the CountryAPI request](#executing-the-countryapi-request)
- [Request Parameters List](#request-parameters)
- [Request Examples (with parameters)](#request-examples)
   - [Data of one specific country](#data-of-one-specific-country)
   - [Data of countries with region and subRegion specifically](#data-of-countries-with-region-and-subregion-specifically)
      - [Region and sub region list](#region-and-sub-region-list)
   - [Data of the country with Alpha code 2 or 3](#data-of-the-country-with-alpha-code-2-or-3)
   - [Data of the countries with english like native language](#data-of-the-countries-with-english-like-native-language)
   - [Data of the countries with Currency code USD (United States Dollar)](#data-of-the-countries-with-currency-code-usd-united-states-dollar)
   - [Data of the countries with an Area (km2) more than 8000 and less than 12000](#data-of-the-countries-with-an-area-km2-more-than-8000-and-less-than-12000)
   - [Data of the countries with limit and pagination](#data-of-the-countries-with-limit-and-pagination)

### Buy me a Coffee (Donate)
- [Donate](#donate)

### Footer Docs
- [Servers](#servers) 
- [Current Version](#current-version) 
- [Credits](#credits) 
- [References](#references) 
- [Apache License](#license) 


<br>

## How To Use

#### What is CountryAPI?
Country API is a simple web service, made with REST API architecture, that return a simple Json Object with the verb "GET", withouth Oauth, Oauth2, or another authetication.

This service return the next data of all the countries in the world:

* **isSucessfull:** Is sucessfull is 1 = True, refers that all works fine, else 0. 
* **userMessage:** This message is for the users, and only shown with isSucessfull is 0.
* **technicalMessage:** This message is more technical, and only shown with isSucessfull is 0, please send me a stack trace.
* **totalCount:** The numbers of country objects that gets in response.
* **response:** Array of country objects.
   * name
   * alpha2Code
   * alpha3Code
   * nativeName
   * region
   * subRegion
   * latitude
   * longitude
   * area
   * numericCode
   * nativeLanguage
   * currencyCode
   * currencyName
   * currencySymbol
   * flag


<br>

#### Why use CountryAPI?
* Not have to create an account in any web page or application.
* Gets a really simple json object.
* Gets basic information of any country.
* Gets the image of all countries.
* You don't need any type of authentication.
* You don't have limit of request.
* Has the basic and importants features of RestAPI architecture.
* Has many params to request the service (included a pagination and limit).
* It's completelly free and Open source.
* The service is always up  (24/7).
* Feel free to use or contribute to the improvement of this.


<br>

#### Executing the CountryAPI request

Simple example.
Only need to open browser and paste the url [http://countryapi.gear.host/v1/Country/getCountries](http://countryapi.gear.host/v1/Country/getCountries).

Or use [Postman](https://www.getpostman.com/) or similar software with the verb GET, and obtain the json data and/or edit the json in [Json Editor Online](http://www.jsoneditoronline.org/).
For example:
![alt tag](https://raw.githubusercontent.com/fabian7593/CountryAPI/master/Files/imgsReadme/Postman.jpg)

#### Request Parameters
You can use any parameter that you need.

**Parameter list:**

| Name | Type | Required | SQLConsult Type |
| ---------- | ----------- | ------- | ------- |
| `pName` | String | False | `LIKE "% %"` | 
| `pAlpha2Code` | string | False | `Equals` | 
| `pAlpha3Code` | string | False | `Equals` | 
| `pNativeName` | string | False | `LIKE "% %"` | 
| `pRegion` | string | False | `Equals` | 
| `pSubRegion` | string | False | `Equals` | 
| `pAreaFrom` | long? | False | `BETWEEN pAreaFrom AND pAreaTo` | 
| `pAreaTo` | long? | False | `BETWEEN pAreaFrom AND pAreaTo` | 
| `pNumericCode` | long? | False | `Equals` | 
| `pNativeLanguage` | string | False | `Equals` | 
| `pCurrencyCode` | string | False | `Equals` | 
| `pCurrencyName` | string | False | `LIKE "% %"` | 
| `pPage` | int? | False | `Pagination` | 
| `pLimit` | int? | False | `Limit of objects response` | 

<br><br>
#### Request Examples
##### Data of one specific country 

[http://countryapi.gear.host/v1/Country/getCountries?pName=Costa%20Rica](http://countryapi.gear.host/v1/Country/getCountries?pName=Costa%20Rica)

` {"isSucessfull":1,"userMessage":null,"technicalMessage":null,"totalCount":1,"response":[{"name":"Costa Rica","alpha2Code":"CR","alpha3Code":"CRI","nativeName":"Costa Rica","region":"Americas","subRegion":"Central America","latitude":"10","longitude":"-84","area":51100,"numericCode":188,"nativeLanguage":"spa","currencyCode":"CRC","currencyName":"Costa Rican colón","currencySymbol":"₡","flag":"https://api.backendless.com/2F26DFBF-433C-51CC-FF56-830CEA93BF00/473FB5A9-D20E-8D3E-FF01-E93D9D780A00/files/CountryFlags/cri.svg"}]} `

PD: the request is similar with **pNativeName**.

<br>

##### Data of countries with region and subRegion specifically

[http://countryapi.gear.host/v1/Country/getCountries?pRegion=Americas&pSubRegion=Central%20America](http://countryapi.gear.host/v1/Country/getCountries?pRegion=Americas&pSubRegion=Central%20America)

###### Region and sub region list
* Africa
   * Eastern Africa
   * Middle Africa
   * Northern Africa
   * Southern Africa
   * Western Africa
* Americas
   * Caribbean
   * Central America
   * Northern America
   * South America
* Asia
   * Central Asia
   * Eastern Asia
   * South-Eastern Asia
   * Southern Asia
   * Western Asia
* Europe
   * Eastern Europe
   * Northern Europe
   * Southern Europe
   * Western Europe
* Oceania
   * Australia and New Zealand
   * Melanesia
   * Micronesia
   * Polynesia
* Polar

<br>

##### Data of the country with Alpha code 2 or 3
[http://countryapi.gear.host/v1/Country/getCountries?pAlpha2Code=CR](http://countryapi.gear.host/v1/Country/getCountries?pAlpha2Code=CR)

##### Data of the countries with english like native language
[http://countryapi.gear.host/v1/Country/getCountries?pNativeLanguage=eng](http://countryapi.gear.host/v1/Country/getCountries?pNativeLanguage=eng)

##### Data of the countries with Currency code USD (United States Dollar)
[http://countryapi.gear.host/v1/Country/getCountries?pCurrencyCode=USD](http://countryapi.gear.host/v1/Country/getCountries?pCurrencyCode=USD)

##### Data of the countries with an Area (km2) more than 8000 and less than 12000 
[http://countryapi.gear.host/v1/Country/getCountries?pAreaFrom=8000&pAreaTo=12000](http://countryapi.gear.host/v1/Country/getCountries?pAreaFrom=8000&pAreaTo=12000)

##### Data of the countries with limit and pagination
[http://countryapi.gear.host/v1/Country/getCountries?pLimit=25&pPage=1](http://countryapi.gear.host/v1/Country/getCountries?pLimit=25&pPage=1)
[http://countryapi.gear.host/v1/Country/getCountries?pLimit=25&pPage=2](http://countryapi.gear.host/v1/Country/getCountries?pLimit=25&pPage=2)





<br><br>
## Donate
[![Donate](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=L25MKCRPR7TWY)

<br>

## Servers
#### PAAS: Host server .Net Web API 2.0
[https://www.gearhost.com/](https://www.gearhost.com/)

#### PAAS: Sql server 2008 free
[https://appharbor.com/](https://appharbor.com/)

#### BAAS: Free files storage
[https://backendless.com/](https://backendless.com/)

<br>

## Current Version
* **v1** `21/May/2017`

<br>

## Credits
**Author**
[Fabián Rosales - Frosquivel Developer](https://github.com/fabian7593)

[![alt tag](https://raw.githubusercontent.com/fabian7593/CountryAPI/master/Files/imgsReadme/github-logo.png)](https://github.com/fabian7593)
[![alt tag](https://raw.githubusercontent.com/fabian7593/CountryAPI/master/Files/imgsReadme/facebook.png)](https://www.facebook.com/fabian.rosales.509)
[![alt tag](https://raw.githubusercontent.com/fabian7593/CountryAPI/master/Files/imgsReadme/linkedin.png)](https://www.linkedin.com/in/fabian-rosales-esquivel-698893106/)
[![alt tag](https://raw.githubusercontent.com/fabian7593/CountryAPI/master/Files/imgsReadme/youtube.png)](https://www.youtube.com/channel/UCJnvvHb_vwMwbnZWplkHIfw)

<br>

## References

https://restcountries.eu

https://github.com/aredo/restcountries

<br>

## License
Copyright 2017 Fabian Rosales

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
<br><br>
