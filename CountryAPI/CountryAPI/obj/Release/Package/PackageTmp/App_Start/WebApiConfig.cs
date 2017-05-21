using System.Web.Http;
namespace CountryAPI
{
    //http://countryapi.gear.host/CountryAPI/v1/Country/getCountries
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            
            config.Formatters.JsonFormatter.SupportedMediaTypes
            .Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));

            
            config.Routes.MapHttpRoute(
                name: "Countries",
                routeTemplate: "v1/{controller}/{action}",
                defaults: new {
                    controller = "Country",
                    pName = RouteParameter.Optional,
                    pAlpha2Code = RouteParameter.Optional,
                    pAlpha3Code = RouteParameter.Optional,
                    pNativeName = RouteParameter.Optional,
                    pRegion = RouteParameter.Optional,
                    pSubRegion = RouteParameter.Optional,
                    pAreaFrom = RouteParameter.Optional,
                    pAreaTo = RouteParameter.Optional,
                    pNumericCode = RouteParameter.Optional,
                    pNativeLanguage = RouteParameter.Optional,
                    pCurrencyCode = RouteParameter.Optional,
                    pCurrencyName = RouteParameter.Optional,
                    pPage = RouteParameter.Optional,
                    pLimit = RouteParameter.Optional
                }
            );
        }
    }
}
