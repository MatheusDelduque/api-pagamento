namespace pagamento.Entities;

public class PersonEntity
{
    public Guid Id { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required AccountEntity Account { get; set; }
}

public class AccountEntity
{
    public Guid Id { get; set; }
    public string? Token { get; set; }
}