using Pagamento.API.Domain.Defaults.Entities;

namespace Pagamento.API.Domain.Payments.Entities
{
    public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed,
        Canceled,
        Refunded
    }

    public class PaymentEntity : Entity
    {
        public Guid PayerId { get; set; }
        public Guid? TransactionId { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }
    }
}