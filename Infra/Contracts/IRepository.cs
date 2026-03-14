namespace Pagamento.API.Infra.Contracts
{
    public interface IRepository<T>
    {
        Task AddAsync(T entity);

        Task RemoveAsync(T entity);

        Task UpdateAsync(T entity);
    }
}
