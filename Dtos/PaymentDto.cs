public class ProcessRequest
{
    public required string Email { get; set; }
    public decimal Amount { get; set; }
    public required string AuthorizationToken { get; set; }
}

public class ProcessResponse
{
    public required string Status { get; set; }
    public required string Message { get; set; }
}

public class RefundRequest
{
    public Guid PaymentId { get; set; }
    public decimal Amount { get; set; }
    public Guid TransactionId { get; set; }
    public required string AuthorizationToken { get; set; }
}

public class RefundResponse
{
    public required string Status { get; set; }
    public required string Message { get; set; }
}