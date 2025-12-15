namespace pagamento.Dtos;

public class RegisterRequest {
    public required string Email { get; set; }
    public required string Password { get; set; }
}

public class RegisterResponse
{
    public string? Email { get; set; }
    public required string Message { get; set; }
    public required string Status { get; set; }

}

