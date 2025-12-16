using pagamento.Interfaces;

public class PaymentService(IPersonService personService, IAuthenticationService authenticationService) : IPaymentService
{
    private readonly List<PaymentEntity> _payments = [];
    public void ProcessPayment(string email, decimal amount, string authorizationToken)
    {

        if (!authenticationService.ValidateAuthorization(authorizationToken))
        {
            throw new Exception("Unauthorized");
        }

        var personId = personService.FindByEmail(email)?.Id;

        if (personId == null)
        {
            throw new Exception("Payer not found");
        }

        if (amount <= 0)
        {
            throw new Exception("Invalid payment amount");
        }

        var payment = new PaymentEntity()
        {
            Id = Guid.NewGuid(),
            PayerId = personId.Value,
            Amount = amount,
            Status = PaymentStatus.Pending,
            CreatedAt = DateTime.UtcNow
        };
        _payments.Add(payment);
    }

    public void CompletePayment(Guid paymentId, Guid transactionId)
    {

       
    }

    public void CancelPayment()
    {
        
    }

    public void RefoundPayment(Guid paymentId, decimal amount, Guid transactionId, string authorizationToken)
    {
        if (!authenticationService.ValidateAuthorization(authorizationToken))
        {
            throw new Exception("Unauthorized");
        }

        

        var payment = FindById(paymentId);
        if (payment == null)
        {
            throw new Exception("Payment not found");
        }

        if (amount <= 0)
        {
            throw new Exception("Invalid refund amount");
        }

        if (amount > payment.Amount)
        {
            throw new Exception("Refund amount exceeds payment amount");
        }

        if (payment.Status != PaymentStatus.Completed)
        {
            throw new Exception("Only completed payments can be refunded");
        }

        payment.Status = PaymentStatus.Refunded;
    }

    public PaymentEntity? FindById(Guid id)
    {
        return _payments.FirstOrDefault(payment => payment.Id == id);
    }

}