namespace BackendApi.models
{
    public class ApprovalPayment
    {
        public int Id { get; set; }
        public string PaymentId { get; set; }
        public string PaymentType { get; set; }
        public string PaymentCode { get; set; }
        public string PaymentDescription { get; set; }
    }
}
