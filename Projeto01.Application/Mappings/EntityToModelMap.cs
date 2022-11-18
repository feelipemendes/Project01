using AutoMapper;
using Projeto01.Application.Models;
using Projeto01.Domain.Entities;

namespace Projeto01.Application.Mappings
{
    public class EntityToModelMap : Profile
    {
        public EntityToModelMap()
        {
            CreateMap<Contato, ContatoDto>();
        }
    }
}
