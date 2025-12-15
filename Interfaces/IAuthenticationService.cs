using pagamento.Dtos;

namespace pagamento.Interfaces;


public interface IAuthenticationService
{
    LoginResult Login(string email, string password);
    
    bool ValidateAuthorization(string? authorization);
}