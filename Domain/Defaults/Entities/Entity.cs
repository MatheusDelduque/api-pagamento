namespace Pagamento.API.Domain.Defaults.Entities
{
    public abstract class Entity
    {
        public long Id { get; private set; }

        public Guid Code { get; private set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; internal set; } = DateTime.UtcNow;
        public DateTime LastUpdate { get; internal set; } = DateTime.UtcNow;
        public DateTime? DeletedAt { get; private set; }

        public void Delete()
        {
            DeletedAt = DateTime.UtcNow;
            LastUpdate = DateTime.UtcNow;
        }

        public void UpdateLastUpdatedDate()
        {
            LastUpdate = DateTime.UtcNow;
        }
    }
}
