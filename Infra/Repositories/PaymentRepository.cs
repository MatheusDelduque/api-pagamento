using Pagamento.API.Domain.Payments.Entities;
using Pagamento.API.Infra.Contracts;

namespace Pagamento.API.Infra.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        public Task<PaymentRepository> FindAsync(string transactionId)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(PaymentEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(PaymentEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PaymentEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
