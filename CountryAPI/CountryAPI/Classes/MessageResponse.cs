namespace CountryAPI.Classes
{
    public class MessageResponse
    {
        public int isSucessfull { get; set; }
        public string userMessage { get; set; }
        public string technicalMessage { get; set; }
        public int? totalCount { get; set; }
        public object response { get; set; }
    }
}