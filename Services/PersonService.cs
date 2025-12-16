namespace pagamento.Services;

using pagamento.Dtos;
using pagamento.Entities;
using pagamento.Interfaces;

public class PersonService : IPersonService
{
    public void AddPerson(PersonEntity person)
    {
        people.Add(person);
    }
    private readonly List<PersonEntity> people = [];

    public List<PeopleResponse> FindAll()
    {

        return [.. people.Select(pessoa => new PeopleResponse()
        {
            Id = pessoa.Id.ToString(),
            Email = pessoa.Email
        })];
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

