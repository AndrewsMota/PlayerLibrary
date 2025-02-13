using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Scalar.AspNetCore;
using HelloApi.Features;

var builder = WebApplication.CreateBuilder(args);

// Configuracao do MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

// Configuracao do OpenAPI (Scalar)
builder.Services.AddOpenApi(); // Metodo do Scalar para gerar especificacao OpenAPI

var app = builder.Build();

// Configuracao do Scalar
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference(); // Metodo principal do Scalar para UI
    app.MapOpenApi(); // Expoe o endpoint /openapi.json
}

app.UseHttpsRedirection();

// Endpoint Minimal API
app.MapGet("/hello/", async ([FromQuery] string? name, IMediator mediator) =>
{
    var result = await mediator.Send(new HelloRequest { Name = name ?? string.Empty });
    return result.IsSuccess
           ? Results.Ok(result.Value)
           : Results.BadRequest(result.Errors);
})
.WithName("Hello")
.WithOpenApi();

app.Run();