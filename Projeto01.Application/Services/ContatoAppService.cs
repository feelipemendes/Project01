using Projeto01.Application.Interfaces;
using Projeto01.Domain.Interfaces;

namespace Projeto01.Application.Services
{
    public class ContatoAppService : IContatoAppService
    {
        private readonly IContatoDomainService _contatoDomainService;

        public ContatoAppService(IContatoDomainService contatoDomainService)
        {
            _contatoDomainService = contatoDomainService;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
