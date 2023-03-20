namespace Rextur.Infra.Responses
{
    public class TicketsResponse
    {
        public int agencyId { get; set; }
        public List<string> autorizerList { get; set; }
        public string bookClaimer { get; set; }
        public bool capturado { get; set; }
        public CarroResponse carro { get; set; }
        public float? ccAmount { get; set; }
        public string ccAuth { get; set; }
        public string ccAuthRav { get; set; }
        public string ccBandeiraRav { get; set; }
        public string ccNum { get; set; }
        public string ccNumRav { get; set; }
        public int claimerId { get; set; }
        public string claimerName { get; set; }
        public string clientCode { get; set; }
        public float comissionPercent { get; set; }
        public float comissionValue { get; set; }
        public string companyFormalName { get; set; }
        public int companyId { get; set; }
        public string companyName { get; set; }
        public int costCenterId { get; set; }
        public string costCenterName { get; set; }
        public string cpf { get; set; }
        public string currency { get; set; }
        public float? currencyValue { get; set; }
        public string department { get; set; }
        public string email { get; set; }
        public bool emd { get; set; }
        public float? fare { get; set; }
        public float? feeBRL { get; set; }
        public float? feeCliAmount { get; set; }
        public float? feeTotal { get; set; }
        public List<string> formOfPaymentList { get; set; }
        public string freeText { get; set; }
        public int groupId { get; set; }
        public string groupName { get; set; }
        public List<HotelList> hotelList { get; set; }
        public float? incentive { get; set; }
        public int installments { get; set; }
        public DateTime issueDate { get; set; }
        public string issueType { get; set; }
        public string issuerUser { get; set; }
        public List<ItineraryListResponse> itineraryList { get; set; }
        public string loc { get; set; }
        public List<ManagementFieldListResponse> managementFieldList { get; set; }
        public string numOP { get; set; }
        public List<OnibusResponse> onibus { get; set; }
        public float? originalFare { get; set; }
        public string originalTktNum { get; set; }
        public List<PassengerListResponse> passengerList { get; set; }
        public string passengerName { get; set; }
        public string paxName { get; set; }
        public float? penalty { get; set; }
        public string productType { get; set; }
        public float? rav { get; set; }
        public string reason { get; set; }
        public string status { get; set; }
        public float taxaOb { get; set; }
        public string tktNum { get; set; }
        public float? yqTax { get; set; }
    }
}
