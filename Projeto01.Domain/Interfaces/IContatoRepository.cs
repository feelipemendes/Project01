using Projeto01.Domain.Core.Interfaces;
using Projeto01.Domain.Entities;

namespace Projeto01.Domain.Interfaces
{
    public interface IContatoRepository : IRepository<Contato, Guid>
    {
        Contato GetByEmail(string email);
        Contato GetByTelefone(string telefone);  
    }
}
