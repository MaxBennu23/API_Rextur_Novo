namespace Rextur.Infra.Responses
{
    public class ItineraryListResponse
    {
        public string airlineCode { get; set; }
        public string arrivalDate { get; set; }
        public string arrivalTime { get; set; }
        public string date { get; set; }
        public string departureTime { get; set; }
        public string destination { get; set; }
        public string fareBase { get; set; }
        public string flightNumber { get; set; }
        public string origin { get; set; }
        public string seatClass { get; set; }
    }
}
