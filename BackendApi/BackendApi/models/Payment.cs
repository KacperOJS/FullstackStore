namespace BackendApi.models
{
    public class Payment
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string PaymentIntentId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
