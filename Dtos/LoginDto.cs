namespace pagamento.Dtos;

public class LoginRequest {
    public required string Email { get; set; }
    public required string Password { get; set; }
}

public class LoginResponse
{
    public required string Token { get; set; }

}

public class LoginResult
{
    public required bool Success { get; set; }
    public string? Token { get; set; }
    public string? ErrorMessage { get; set; }

    public static LoginResult FailureResult(string errorMessage) =>
        new LoginResult { Success = false, ErrorMessage = errorMessage };

    public static LoginResult SuccessResult(string token) =>
        new LoginResult { Success = true, Token = token };
}
