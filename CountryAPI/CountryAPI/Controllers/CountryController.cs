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
        private const string ERROR_MESSAGE = "An error occurred, please contact the administrator.";
        private const string NO_DATA_TO_DISPLAY = "No data to display.";

        // GET: api/Test
        [HttpGet, ActionName("getCountries")]
        public MessageResponse GetCountries(string pName = null, string pAlpha2Code = null, string pAlpha3Code = null,
            string pNativeName = null, string pRegion = null, string pSubRegion = null, long? pAreaFrom = null,
            long? pAreaTo = null, int? pNumericCode = null, string pNativeLanguage = null, string pCurrencyCode = null,
            string pCurrencyName = null, int? pPage = null, int? pLimit = null)
        {

            MessageResponse msgResponse = new MessageResponse();

            try
            {
                using (DataConn.countryDBDataContext countrySQLLinQ = new DataConn.countryDBDataContext())
                {
                    ISingleResult<DataConn.GET_COUNTRIESResult> countriesResult = countrySQLLinQ.GET_COUNTRIES(
                    pName, pAlpha2Code, pAlpha3Code, pNativeName, pRegion, pSubRegion, pAreaFrom,
                    pAreaTo, pNumericCode, pNativeLanguage, pCurrencyCode, pCurrencyName, pPage, pLimit);

                    List<CountryModel> countryList = new List<CountryModel>();
                    foreach (DataConn.GET_COUNTRIESResult countryResult in countriesResult)
                    {
                        CountryModel countryModel = new CountryModel()
                        {
                            Name = countryResult.name,
                            Alpha2Code = countryResult.alpha2Code,
                            Alpha3Code = countryResult.alpha3Code,
                            NativeName = countryResult.nativeName,
                            Region = countryResult.region,
                            SubRegion = countryResult.subRegion,
                            Latitude = countryResult.latitude,
                            Longitude = countryResult.longitude,
                            Area = countryResult.area,
                            NumericCode = countryResult.numericCode,
                            NativeLanguage = countryResult.nativeLanguage,
                            CurrencyCode = countryResult.currencyCode,
                            CurrencyName = countryResult.currencyName,
                            CurrencySymbol = countryResult.currencySymbol,
                            Flag = countryResult.flag,
                            FlagPng = countryResult.flagpng
                        };

                        countryList.Add(countryModel);
                    }

                    msgResponse.IsSuccess = true;
                    msgResponse.Response = countryList;
                    msgResponse.TotalCount = countryList.Count;

                    if (countryList.Count == 0)
                    {
                        msgResponse.UserMessage = NO_DATA_TO_DISPLAY;
                    }
                }
            }
            catch (Exception ev)
            {
                msgResponse.IsSuccess = false;
                msgResponse.Response = null;
                msgResponse.TechnicalMessage = ev.Message;
                msgResponse.UserMessage = ERROR_MESSAGE;
            }

            return msgResponse;
        }
    }
}
