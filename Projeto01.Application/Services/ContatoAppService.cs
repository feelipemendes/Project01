using MediatR;
using Projeto01.Application.Commands;
using Projeto01.Application.Interfaces;
using Projeto01.Application.Models;

namespace Projeto01.Application.Services
{
    public class ContatoAppService : IContatoAppService
    {
        private readonly IMediator _mediator;

        public ContatoAppService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ContatoDto> Create(ContatoCreateCommand command)
            => await _mediator.Send(command);

        public async Task<ContatoDto> Delete(ContatoDeleteCommand command)
            => await _mediator.Send(command);

        public async Task<ContatoDto> Update(ContatoUpdateCommand command)
            => await _mediator.Send(command);

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
