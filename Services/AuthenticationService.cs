namespace pagamento.Services;
using pagamento.Interfaces;
using pagamento.Dtos;
using pagamento.Entities;

public class AuthenticationService(IPersonService personService) : IAuthenticationService
{

    public string Register(string email, string password)
    {
        var person = new PersonEntity()
        {
            Id = Guid.NewGuid(),
            Email = email,
            Password = password,
            Account = new AccountEntity()
        };

        personService.AddPerson(person);

        return $"Email cadastrado com sucesso {email}";
    }

    public LoginResult Login(string email, string senha)
    {
        var person = personService.FindByEmail(email);

        if (person == null)
        {
            return LoginResult.FailureResult("Email ou senha inválidos");
        }

        if (person.Password != senha)
        {
            return LoginResult.FailureResult("Email ou senha inválidos");
        }

        var token = Guid.NewGuid().ToString();
        person.Account.Token = token;

        return LoginResult.SuccessResult(token);
    }

    public bool ValidateAuthorization(string? authorization)
    {
        if (!string.IsNullOrEmpty(authorization))
        {
            var token = authorization.Split(" ")[1];
            var validToken = personService.FindByToken(token);

            if (validToken == null)
            {
                return false;
            }
        }
        return true;
    }
}