
namespace CountryAPI.Models
{
    public class CountryModel
    {
        public string Name { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string NativeName { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public long? Area { get; set; }
        public int? NumericCode { get; set; }
        public string NativeLanguage { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public string Flag { get; set; }
        public string FlagPng { get; set; }
    }
}