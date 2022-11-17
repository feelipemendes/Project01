using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto01.Domain.Entities;

namespace Projeto01.Infra.Data.SqlServer.Configurations
{
    public class ContatoConfiguration : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasIndex(c => c.Email).IsUnique();
            builder.HasIndex(c => c.Telefone).IsUnique();
        }
    }
}
