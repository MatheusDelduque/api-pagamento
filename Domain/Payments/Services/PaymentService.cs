using Pagamento.API.Domain.Payments.Dtos;
using Pagamento.API.Domain.Payments.Entities;
using Pagamento.API.Domain.Payments.Interfaces;

namespace Pagamento.API.Domain.Payments.Services
{
    public class PaymentService() : IPaymentService
    {
        private readonly List<Payment> _payments = [];
        Task<ProcessResponse> IPaymentService.ProcessPayment(ProcessRequest paymentRequest)
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