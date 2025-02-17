using MediatR;
using FluentResults;
using HelloApi.Application.Features.Requests;

namespace HelloApi.Application.Features.Handlers; 

public class HelloHandler : IRequestHandler<HelloRequest, Result<string>>
{
	public Task<Result<string>> Handle(HelloRequest request, CancellationToken cancellationToken)
	{
		if(string.IsNullOrEmpty(request.Name))
			return Task.FromResult(Result.Fail<string>("O nome não pode ser vazio."));
		
		if(request.Name == "josue")
			return Task.FromResult(Result.Fail<string>("JOSUE DETECTADO"));
		
		return Task.FromResult(Result.Ok($"Hello, {request.Name}!"));
	}
}