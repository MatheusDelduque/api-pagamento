using Microsoft.AspNetCore.Mvc;
using pagamento.Services;
using pagamento.Dtos;
using pagamento.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSingleton<IPersonService, PersonService>();
builder.Services.AddSingleton<IAuthenticationService, AuthenticationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapPost("/api/v1/register", ([FromBody] RegisterRequest request, PersonService personService) =>
{
    var response = personService.Register(request.Email, request.Password);

    return new RegisterResponse()
    {
        Status = "Sucess",
        Message = response
    };
});


app.MapGet("/api/v1/people",
([FromHeader(Name = "Authorization")] string? authorizationHeader, PersonService personService, AuthenticationService authenticationService) =>
{
    if (authenticationService.ValidateAuthorization(authorizationHeader) == false)
    {
        return [];
    }

    return personService.FindAll();
});

app.MapPost("/api/v1/login",
([FromBody] LoginRequest logarRequest, AuthenticationService logarService, PersonService personService) =>
{
    var response = logarService.Login(logarRequest.Email, logarRequest.Password);

    if (response == null)
    {
        throw new Exception("Email ou senha inválidos");
    }

    return new LoginResponse()
    {
        Token = response
    };
});

app.MapGet("/api/v1/people/{id}",
(string id, [FromHeader(Name = "Authorization")] string? authorizationHeader, PersonService personService, AuthenticationService authenticationService) =>
{
    if (authenticationService.ValidateAuthorization(authorizationHeader) == false)
    {
        return null;
    }

    return personService.FindById(id);
});


app.Run();