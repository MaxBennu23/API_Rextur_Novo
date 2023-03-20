namespace Rextur.Infra.Responses
{
    public class CarroResponse
    {
        public string cancellationDeadline { get; set; }
        public string categoryCode { get; set; }
        public string categoryTypeCode { get; set; }
        public string codCia { get; set; }
        public int deliverShopId { get; set; }
        public string description { get; set; }
        public string devolutionDate { get; set; }
        public string numberOfBaggages { get; set; }
        public string numberOfPassengers { get; set; }
        public string numberOfPorts { get; set; }
        public string provider { get; set; }
        public string providerCode { get; set; }
        public string type { get; set; }
        public string withdrawalDate { get; set; }
        public int withdrawalShopId { get; set; }
    }
}
