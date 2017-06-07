using CountryAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.Http;
using CountryAPI.Classes;


namespace CountryAPI.Controllers
{
    public class CountryController : ApiController
    {
        private const string USER_MESSAGE = "An error occurred, please contact with administrator.";
        private const string NOT_HAVE_DATA_TO_SHOW = "Not have data to show.";

        // GET: api/Test
        [HttpGet]
        [ActionName("getCountries")]
         public MessageResponse getCountries(string pName = null, string pAlpha2Code = null, string pAlpha3Code = null,
            string pNativeName = null, string pRegion = null, string pSubRegion = null, long? pAreaFrom = null,
            long? pAreaTo = null, int? pNumericCode = null, string pNativeLanguage = null, string pCurrencyCode = null, 
            string pCurrencyName = null, int? pPage = null, int? pLimit = null)
         {

            MessageResponse msgResponse = new MessageResponse();

            try
            {
                DataConn.countryDBDataContext countrySQLLinQ = new DataConn.countryDBDataContext();
                ISingleResult<DataConn.GET_COUNTRIESResult> countriesResult = countrySQLLinQ.GET_COUNTRIES(
                    pName, pAlpha2Code, pAlpha3Code, pNativeName, pRegion, pSubRegion, pAreaFrom,
                    pAreaTo, pNumericCode, pNativeLanguage, pCurrencyCode, pCurrencyName, pPage, pLimit);

                List<CountryModel> countryList = new List<CountryModel>();
                foreach (DataConn.GET_COUNTRIESResult countryResult in countriesResult)
                {
                    CountryModel countryModel = new CountryModel();
                    countryModel.name = countryResult.name;
                    countryModel.alpha2Code = countryResult.alpha2Code;
                    countryModel.alpha3Code = countryResult.alpha3Code;
                    countryModel.nativeName = countryResult.nativeName;
                    countryModel.region = countryResult.region;
                    countryModel.subRegion = countryResult.subRegion;
                    countryModel.latitude = countryResult.latitude;
                    countryModel.longitude = countryResult.longitude;
                    countryModel.area = countryResult.area;
                    countryModel.numericCode = countryResult.numericCode;
                    countryModel.nativeLanguage = countryResult.nativeLanguage;
                    countryModel.currencyCode = countryResult.currencyCode;
                    countryModel.currencyName = countryResult.currencyName;
                    countryModel.currencySymbol = countryResult.currencySymbol;
                    countryModel.flag = countryResult.flag;
                    countryModel.flagPng = countryResult.flagpng;
                    countryList.Add(countryModel);
                }

                msgResponse.isSucessfull = 1;
                msgResponse.response = countryList;
                msgResponse.totalCount = countryList.Count;

                if (countryList.Count <= 0)
                {
                    msgResponse.userMessage = NOT_HAVE_DATA_TO_SHOW;
                }
            }
            catch(Exception ev)
            {
                msgResponse.isSucessfull = 0;
                msgResponse.response = null;
                msgResponse.technicalMessage = ev.ToString();
                msgResponse.userMessage = USER_MESSAGE;
            }

            return msgResponse;
        }
    }
}
