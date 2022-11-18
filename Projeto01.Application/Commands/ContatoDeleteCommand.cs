using MediatR;
using Projeto01.Application.Models;

namespace Projeto01.Application.Commands
{
    public class ContatoDeleteCommand : IRequest<ContatoDto>
    {
        public Guid Id { get; set; }
    }
}
