using Projeto01.Domain.Entities;
using Projeto01.Domain.Interfaces;

namespace Projeto01.Domain.Services
{
    public class ContatoDomainService : IContatoDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContatoDomainService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(Contato entity)
        {
            if (_unitOfWork.ContatoRepository.GetByEmail(entity.Email) != null)
                throw new ArgumentException("O email informado já está cadastrado, tente outro");

            if (_unitOfWork.ContatoRepository.GetByTelefone(entity.Telefone) != null)
                throw new ArgumentException("O telefone informado já está cadastrado, tente outro");

            await _unitOfWork.ContatoRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(Contato entity)
        {
            if (await _unitOfWork.ContatoRepository.GetByIdAsync(entity.Id) == null)
                throw new ArgumentException("Contato não encontrado, verifique o ID informado");

            await _unitOfWork.ContatoRepository.DeleteAsync(entity);
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public async Task<List<Contato>> GetAllAsync(int page, int limit)
        {
            if (limit > 250)
                throw new ArgumentException("Informe um limite de no máximo 250 registros");

            return await _unitOfWork.ContatoRepository.GetAllAsync(page, limit);
        }

        public async Task<Contato> GetByIdAsync(Guid id)
            => await _unitOfWork.ContatoRepository.GetByIdAsync(id); 

        public async Task UpdateAsync(Contato entity)
        {
            if (await _unitOfWork.ContatoRepository.GetByIdAsync(entity.Id) == null)
                throw new ArgumentException("Contato não encontrado, verifique o ID informado");

            var contatoByEmail = _unitOfWork.ContatoRepository.GetByEmail(entity.Email);

            if (contatoByEmail != null && contatoByEmail.Id.Equals(entity.Id))
                throw new ArgumentException("O email informado pertence a outro contato cadastrado");


            var contatoByTelefone = _unitOfWork.ContatoRepository.GetByTelefone(entity.Telefone);

            if (contatoByTelefone != null && contatoByTelefone.Id.Equals(entity.Id))
                throw new ArgumentException("O telefone informado pertence a outro contato cadastrado");

            await _unitOfWork.ContatoRepository.UpdateAsync(entity);
        }


    }
}
