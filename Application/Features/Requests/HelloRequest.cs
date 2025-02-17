using FluentResults;
using MediatR;

namespace HelloApi.Application.Features.Requests;

public sealed record HelloRequest(string Name) : IRequest<Result<string>>;