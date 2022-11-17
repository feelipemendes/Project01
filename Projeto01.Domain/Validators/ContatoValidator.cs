using FluentValidation;
using Projeto01.Domain.Entities;

namespace Projeto01.Domain.Validators
{
    public class ContatoValidator : AbstractValidator<Contato>
    {
        public ContatoValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("ID do Contato é obrigatório");

            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("Nome do Contato é obrigatório")
                .Length(6, 150)
                .WithMessage("Nome do Contato deve ter de 6 a 150 caracteres");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email do Contato é obrigatório")
                .EmailAddress().WithMessage("Endereço de email inválido");

            RuleFor(x => x.Telefone)
                .NotEmpty().WithMessage("Telefone do Contato é obrigatório");
                
        }
    }
}
