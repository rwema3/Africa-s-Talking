namespace Voice.Controllers
{
    public class VoiceResponse
    {
        public string sessionId { get; set; }
        public string isActive { get; set; }
        public string direction {get; set; }
        public string callerNumber {get; set; }
        public string callStartTime {get; set; }
        public string callerCountryCode {get; set;}

                // etc
    }
}