using MediatR;
using Microsoft.AspNetCore.Mvc;
using Scalar.AspNetCore;
using HelloApi.Features;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference(); 
    app.MapOpenApi(); 
}

app.UseHttpsRedirection();

// Endpoint Minimal API
app.MapGet("/hello/{name}", async ([FromRoute] string name, ISender sender) =>
{
    var result = await sender.Send(new HelloRequest(name));
    return result.IsSuccess
           ? Results.Ok(result.Value)
           : Results.BadRequest(result.Errors);
})
.WithName("Hello")
.WithOpenApi();

app.Run();