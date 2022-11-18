using MediatR;
using Projeto01.Application.Models;

namespace Projeto01.Application.Commands
{
    public class ContatoCreateCommand : IRequest<ContatoDto>
    {
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
    }
}
