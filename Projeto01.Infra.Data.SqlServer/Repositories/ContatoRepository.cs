using Projeto01.Domain.Entities;
using Projeto01.Domain.Interfaces;
using Projeto01.Infra.Data.SqlServer.Contexts;

namespace Projeto01.Infra.Data.SqlServer.Repositories
{
    public class ContatoRepository : BaseRepository<Contato, Guid>, IContatoRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public ContatoRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public Contato GetByEmail(string email)
            => _sqlServerContext.Contatos
                .First(x => x.Email.Equals(email));

        public Contato GetByTelefone(string telefone)
            => _sqlServerContext.Contatos
                .FirstOrDefault(x => x.Telefone.Equals(telefone));
    }
}
