using Pagamento.API.Domain.Defaults.Contracts;
using Pagamento.API.Domain.Payments.Entities;
using Pagamento.API.Infra.Repositories;

namespace Pagamento.API.Infra.Contracts
{
    public interface IPaymentRepository : IRepository<PaymentEntity>
    {
        public Task<PaymentRepository> FindAsync(string transactionId);
    }
}