namespace pagamento.Interfaces;


public interface IAuthenticationService
{
    string Login(string email, string password);
    
    bool ValidateAuthorization(string? authorization);
}