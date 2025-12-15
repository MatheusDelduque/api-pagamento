namespace pagamento.Interfaces;
using pagamento.Entities;

public interface IPersonService
{

    string Register(string email, string password);
    
    List<PersonEntity> FindAll();
    
    PersonEntity? FindById(string id);

    PersonEntity? FindByEmail(string email);

    PersonEntity? FindByToken(string token);
}