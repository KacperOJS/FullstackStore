using BackendApi.models;

namespace BackendApi.Models
{
    public class LogsOfPaymentCustomer
    {
        public int Id { get; set; } // Primary key
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public Customer? Customer { get; set; }
        public PaymentStatus Status { get; set; }
    }

    public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed
    }
}
