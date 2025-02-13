using MediatR;
using FluentResults;

namespace HelloApi.Features
{
	public class HelloRequest : IRequest<Result<string>>
	{
		// Inicializa a propriedade para evitar warning de valor nulo
		public string Name { get; set; } = string.Empty;
	}
}
