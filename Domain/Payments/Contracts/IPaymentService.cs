using Pagamento.API.Domain.Payments.Dtos;

namespace Pagamento.API.Domain.Payments.Contracts
{
    public interface IPaymentService
    {
        Task<ProcessResponse> ProcessPayment (ProcessRequest paymentRequest);
        void CompletePayment(Guid paymentId, Guid transactionId);
        void CancelPayment();

    }
}