namespace pagamento.Interfaces;

using pagamento.Dtos;
using pagamento.Entities;

public interface IPersonService
{
    void AddPerson(PersonEntity person);

    List<PeopleResponse> FindAll();
    
    PersonEntity? FindById(string id);

    PersonEntity? FindByEmail(string email);

    PersonEntity? FindByToken(string token);

    
}