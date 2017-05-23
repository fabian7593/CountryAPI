# CountryAPI
A Rest Api of country information that you need.

EndPoint Request: http://countryapi.gear.host/v1/Country/getCountries

## Contents
### How to Use
- [What is CountryAPI](#what-is-countryapi)
- [Why use CountryAPI](#why-use-countryapi)
- [Executing the CountryAPI request](#executing-the-countryapi-request)
- [Request Parameters List](#request-parameters)
- [Request Examples (with parameters)](#request-examples)
   - [You need the information of one country specifically](#you-need-the-information-of-one-country-specifically)
   - [You need the information of countries with region and subRegion specifically](#you-need-the-information-of-countries-with-region-and-subregion-specifically)
      - [Region and sub region list](#region-and-sub-region-list)

### Buy me a Coffee (Donate)
- [Donate](#donate)

### Footer Docs
- [Servers](#servers) 
- [Current Version](#current-version) 
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
Only need to open browser and paste the url http://countryapi.gear.host/v1/Country/getCountries.

Or use [Postman](https://www.getpostman.com/) or similar software with the verb GET, and obtain the json data.
For example:
![alt tag](https://raw.githubusercontent.com/fabian7593/CountryAPI/master/Files/imgsReadme/Postman.jpg)

Or request in web browser and Edit the Json online with: [Json Editor Online](http://www.jsoneditoronline.org/)

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
##### You need the information of one country specifically

http://countryapi.gear.host/v1/Country/getCountries?pName=Costa%20Rica

` {"isSucessfull":1,"userMessage":null,"technicalMessage":null,"totalCount":1,"response":[{"name":"Costa Rica","alpha2Code":"CR","alpha3Code":"CRI","nativeName":"Costa Rica","region":"Americas","subRegion":"Central America","latitude":"10","longitude":"-84","area":51100,"numericCode":188,"nativeLanguage":"spa","currencyCode":"CRC","currencyName":"Costa Rican colón","currencySymbol":"₡","flag":"https://api.backendless.com/2F26DFBF-433C-51CC-FF56-830CEA93BF00/473FB5A9-D20E-8D3E-FF01-E93D9D780A00/files/CountryFlags/cri.svg"}]} `

PD: the request is similar with **pNativeName**.

<br>

##### You need the information of countries with region and subRegion specifically

http://countryapi.gear.host/v1/Country/getCountries?pRegion=Americas&pSubRegion=Central%20America

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

##### You need the information of the country with Alpha code 2 or 3

http://countryapi.gear.host/v1/Country/getCountries?pAlpha2Code=CR

##### You need the information of the country with Alpha code 2 or 3

http://countryapi.gear.host/v1/Country/getCountries?pAlpha2Code=CR

##### You need the information of the all the countries with english like native language

http://countryapi.gear.host/v1/Country/getCountries?pNativeLanguage=eng

##### You need the information of the all the countries with Currency code USD (United States Dollar)

http://countryapi.gear.host/v1/Country/getCountries?pCurrencyCode=USD

##### You need the information of the all the countries with an Area (km2) more than 8000 and less than 12000 

http://countryapi.gear.host/v1/Country/getCountries?pAreaFrom=8000&pAreaTo=12000


<br><br>
## Donate
[![Donate](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=L25MKCRPR7TWY)

<br>

## Servers


## Current Version
* **v1** `21/May/2017`

## License
Copyright 2016 Fabian Rosales

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
