using MediatR;
using Projeto01.Application.Models;

namespace Projeto01.Application.Commands
{
    public class ContatoUpdateCommand : IRequest<ContatoDto>
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
    }
}
