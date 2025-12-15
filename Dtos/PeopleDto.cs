namespace pagamento.Dtos;

public class PeopleResponse
{
    public required string Id { get; set; }
    public required string Email { get; set; }
}



public class PersonRequest
{
    public required string Email { get; set; }

    public required string Password { get; set; }
    public required string Message { get; set; }
    public required string Status { get; set; }

}

public class PersonResponse
{
    public string? Email { get; set; }
    public required string Message { get; set; }
    public required string Status { get; set; }

}
