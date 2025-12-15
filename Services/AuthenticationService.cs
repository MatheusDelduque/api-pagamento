namespace pagamento.Services;
public class AuthenticationService(PersonService personService)
{

    public string? Login(string email, string senha)
    {
        var person = personService.FindByEmail(email);

        if (person == null)
        {
            return null;
        }

        if (person.Password != senha)
        {
            return null;
        }

        var token = Guid.NewGuid().ToString();
        person.Account.Token = token;

        return token;
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