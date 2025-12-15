using System.Security.Principal;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using pagamento.Dtos;
using pagamento.Entities;
using pagamento.Interfaces;

namespace pagamento.Controllers;


[ApiController]
[Route("api/[controller]")]
public class PeopleController() : Controller
{

    [HttpPost("v1/register")]
    public RegisterResponse Register([FromBody] RegisterRequest personRequest, IPersonService personService)
    {
        var response = personService.Register(personRequest.Email, personRequest.Password);

        return new RegisterResponse()
        {
            Status = "200",
            Message = response
        };
    }

    [HttpGet("v1/people")]
    public List<PeopleResponse> GetPersonController([FromHeader(Name = "Authorization")] string? authorizationHeader, IPersonService personService, IAuthenticationService authenticationService)

    {
        if (authenticationService.ValidateAuthorization(authorizationHeader) == false)
        {
            return [];
        }

        return personService.FindAll();
    }


    [HttpGet("v1/people/{id}")]
    public PersonResponse PersonController(string id, [FromHeader(Name = "Authorization")] string? authorizationHeader, IPersonService personService, IAuthenticationService authenticationService)
    {

        if (authenticationService.ValidateAuthorization(authorizationHeader) == false)
        {
            return new PersonResponse()
            {
                Email = "",
                Message = "Unauthorized",
                Status = "401"
            };
        }

        return new PersonResponse()
        {
            Email = personService.FindById(id)?.Email ?? "",
            Message = "Success",
            Status = "200"
        };
    }
}
