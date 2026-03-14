using Pagamento.API.Infra.Contracts;

namespace Pagamento.API.Infra.Repositories
{
    public class Payment : IRepository<Payment>
    {
        public Task<Payment> FindAsync(string transactionId)
        {

        }
    }
}
