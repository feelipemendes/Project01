using Microsoft.EntityFrameworkCore;
using Projeto01.Domain.Entities;
using Projeto01.Infra.Data.SqlServer.Configurations;

namespace Projeto01.Infra.Data.SqlServer.Contexts
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContatoConfiguration());
        }

        public DbSet<Contato>? Contatos { get; set; }
    }
}
