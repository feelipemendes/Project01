using Microsoft.EntityFrameworkCore.Storage;
using Projeto01.Domain.Interfaces;
using Projeto01.Infra.Data.SqlServer.Contexts;

namespace Projeto01.Infra.Data.SqlServer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlServerContext _sqlServerContext;
        private IDbContextTransaction _dbContextTransaction;
        public UnitOfWork(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public IContatoRepository ContatoRepository => new ContatoRepository(_sqlServerContext);

        public void BeginTransaction()
        {
            _dbContextTransaction = _sqlServerContext.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _dbContextTransaction.Commit();
        }

        public void RollbackTransaction()
        {
            _dbContextTransaction.Rollback();
        }
        public void Dispose()
        {
            _sqlServerContext.Dispose();
        }
    }
}
