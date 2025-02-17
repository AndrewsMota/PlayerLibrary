using MediatR;
using FluentResults;

namespace HelloApi.Features;

public sealed record HelloRequest(string Name) : IRequest<Result<string>>;