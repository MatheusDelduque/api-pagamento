using pagamento.Dtos;

namespace pagamento.Interfaces;


public interface IAuthenticationService
{
    public string Register(string email, string password);
    LoginResult Login(string email, string password);
    bool ValidateAuthorization(string? authorization);
}