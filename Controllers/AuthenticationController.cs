using System.Security.Principal;
using Microsoft.AspNetCore.Mvc;
using pagamento.Dtos;
using pagamento.Interfaces;

namespace pagamento.Controllers;


[ApiController]
[Route("api/[controller]")]
public class AuthenticationController() : Controller
{

    [HttpPost("v1/login")]
    public LoginResponse Login([FromBody] LoginRequest logarRequest, IAuthenticationService logarService)
    {

        var response = logarService.Login(logarRequest.Email, logarRequest.Password);

        if (response.Success == false)
        {
            throw new Exception(response.ErrorMessage);
        }
        if (response.Token == null)
        {
            throw new Exception("Token não gerado");
        }

        return new LoginResponse()
        {
            Token = response.Token
        };
    }
}

