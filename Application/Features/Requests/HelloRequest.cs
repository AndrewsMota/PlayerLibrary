using FluentResults;
using MediatR;

namespace Application.Features.Requests;

public sealed record HelloRequest(string Name) : IRequest<Result<string>>;