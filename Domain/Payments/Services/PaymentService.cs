using Pagamento.API.Domain.Payments.Contracts;
using Pagamento.API.Domain.Payments.Dtos;

namespace Pagamento.API.Domain.Payments.Services
{
    public class PaymentService : IPaymentService
    {
        public Task<ProcessResponse> ProcessPayment(ProcessRequest paymentRequest)
        {

            throw new NotImplementedException();
        }

        public void CompletePayment(Guid paymentId, Guid transactionId)
        {


        }

        public void CancelPayment()
        {

        }


    }
}