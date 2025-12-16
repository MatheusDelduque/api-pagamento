public enum PaymentStatus
{
    Pending,
    Completed,
    Failed,
    Canceled,
    Refunded
}

public class PaymentEntity
{
    public Guid Id { get; set; }
    public Guid PayerId { get; set; }
    public Guid? TransactionId { get; set; }
    public decimal Amount { get; set; }
    public PaymentStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
}