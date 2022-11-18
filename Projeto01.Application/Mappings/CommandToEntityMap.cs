using AutoMapper;
using Projeto01.Application.Commands;
using Projeto01.Domain.Entities;

namespace Projeto01.Application.Mappings
{
    public class CommandToEntityMap : Profile
    {
        public CommandToEntityMap()
        {
            CreateMap<ContatoCreateCommand, Contato>()
                .AfterMap((command, entity) =>
                {
                    entity.Id = Guid.NewGuid();
                    entity.CreatedAt = DateTime.Now;
                    entity.UpdatedAt = DateTime.Now;
                });

            CreateMap<ContatoUpdateCommand, Contato>()
                .AfterMap((command, entity) =>
                {
                    entity.UpdatedAt = DateTime.Now;
                });
        }
    }
}
