using Microsoft.EntityFrameworkCore;
using Projeto01.Domain.Entities;
using Projeto01.Infra.Data.SqlServer.Configurations;

namespace Projeto01.Infra.Data.SqlServer.Contexts
{
    public class SqlServerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDProjeto01;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContatoConfiguration());
        }

        public DbSet<Contato>? Contatos { get; set; }
    }
}
