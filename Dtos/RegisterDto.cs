namespace pagamento.Dtos;

class RegisterRequest {
    public required string Email { get; set; }
    public required string Password { get; set; }
}

class RegisterResponse
{
    public required string Message { get; set; }
    public required string Status { get; set; }

}

