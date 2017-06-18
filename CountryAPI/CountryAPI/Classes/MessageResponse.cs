namespace CountryAPI.Classes
{
    public class MessageResponse
    {
        public bool IsSuccess { get; set; }
        public string UserMessage { get; set; }
        public string TechnicalMessage { get; set; }
        public int? TotalCount { get; set; }
        public object Response { get; set; }
    }
}