using Pagamento.API.Domain.Defaults.Entities;

namespace Pagamento.API.Domain.Defaults.Contracts
{
    public interface IRepository<T> where T : Entity
    {
        Task AddAsync(T entity);

        Task RemoveAsync(T entity);

        Task UpdateAsync(T entity);
    }
}
