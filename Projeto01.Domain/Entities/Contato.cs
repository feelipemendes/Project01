using FluentValidation.Results;
using Projeto01.Domain.Core.Interfaces;
using Projeto01.Domain.Validators;

namespace Projeto01.Domain.Entities
{
    public class Contato : IEntity
    {
        public Guid Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        #region Propriedades
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }

        #endregion

        #region Atributos

        private string? _nome;
        private string? _email;
        private string? _telefone;

        #endregion

        #region Validation

        public ValidationResult Validate => new ContatoValidator().Validate(this);

        #endregion
    }
}
