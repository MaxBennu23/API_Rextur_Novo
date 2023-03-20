namespace Rextur.Requests
{
    public class QueryTicketsRequest
    {
        public int idAgencia { get; set; }

        public bool isCancel { get; set; }

        public string DateRequest { get; set; }
    }
}
