
namespace CountryAPI.Models
{
    public class CountryModel
    {
        public string name { get; set; }
        public string alpha2Code { get; set; }
        public string alpha3Code { get; set; }
        public string nativeName { get; set; }
        public string region { get; set; }
        public string subRegion { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public long? area { get; set; }
        public int? numericCode { get; set; }
        public string nativeLanguage { get; set; }
        public string currencyCode { get; set; }
        public string currencyName { get; set; }
        public string currencySymbol { get; set; }
        public string flag { get; set; }
        
    }
}