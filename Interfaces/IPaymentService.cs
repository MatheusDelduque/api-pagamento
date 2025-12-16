public interface IPaymentService
{
    void ProcessPayment(string email, decimal amount, string authorizationToken);
    void CompletePayment(Guid paymentId, Guid transactionId);
    void CancelPayment();
    void RefoundPayment(Guid paymentId, decimal amount, Guid transactionId, string authorizationToken);
    PaymentEntity? FindById(Guid id);
}