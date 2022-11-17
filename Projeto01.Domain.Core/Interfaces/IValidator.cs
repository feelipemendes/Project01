using FluentValidation.Results;

namespace Projeto01.Domain.Core.Interfaces
{
    public interface IValidator
    {
        ValidationResult Validate { get; }
    }
}
