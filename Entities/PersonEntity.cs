namespace pagamento.Entities;

public class PersonEntity
{
    public Guid Id { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required AccountEntity Account { get; set; }
}