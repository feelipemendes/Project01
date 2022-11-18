using Projeto01.Application.Commands;
using Projeto01.Application.Models;

namespace Projeto01.Application.Interfaces
{
    public interface IContatoAppService : IDisposable
    {
        Task<ContatoDto> Create(ContatoCreateCommand command);
        Task<ContatoDto> Update(ContatoUpdateCommand command);
        Task<ContatoDto> Delete(ContatoDeleteCommand command);
    }
}
