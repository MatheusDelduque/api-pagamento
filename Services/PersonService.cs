namespace pagamento.Services;
using pagamento.Entities;
using pagamento.Interfaces;

public class PersonService : IPersonService
{
    private readonly List<PersonEntity> people = [];
    public string Register(string email, string password)
    {
        var person = new PersonEntity()
        {
            Id = Guid.NewGuid(),
            Email = email,
            Password = password,
            Account = new AccountEntity()
        };

        people.Add(person);

        return $"Email cadastrado com sucesso {email}";
    }

    public List<PersonEntity> FindAll()
    {
        return people;
    }

    public PersonEntity? FindById(string id)
    {
        return people.FirstOrDefault(pessoa => pessoa.Id.ToString() == id);
    }

    public PersonEntity? FindByEmail(string email)
    {
        return people.FirstOrDefault(pessoa => pessoa.Email == email);
    }

    public PersonEntity? FindByToken(string token)
    {
        return people.FirstOrDefault(pessoa => pessoa.Account.Token == token);
    }

}

