namespace Rextur.Infra.Responses
{
    public class OnibusResponse
    {
        public DateTime boardingDate { get; set; }
        public string boardingPlace { get; set; }
        public string busClass { get; set; }
        public int busCompanyCode { get; set; }
        public string busCompanyName { get; set; }
        public DateTime landingDate { get; set; }
        public string landingPlace { get; set; }
    }
}
