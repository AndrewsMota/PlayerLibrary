using MediatR;
using FluentResults;
using System.Threading;
using System.Threading.Tasks;

namespace HelloApi.Features
{
	public class HelloHandler : IRequestHandler<HelloRequest, Result<string>>
	{
		public Task<Result<string>> Handle(HelloRequest request, CancellationToken cancellationToken)
		{
			if (string.IsNullOrEmpty(request.Name))
				return Task.FromResult(Result.Fail<string>("O nome não pode ser vazio."));

			return Task.FromResult(Result.Ok($"Hello, {request.Name}!"));
		}
	}
}
