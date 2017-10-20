using FluentValidation;
using Store.Domain.Entities;

namespace Store.Domain.Validation
{
    internal class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("Campo obrigatório")
                .EmailAddress().WithMessage("Email inválido");

            RuleFor(p => p.Password)
                .NotEmpty().WithMessage("Campo obrigatório")
                .Length(6, 15).WithMessage("Sua senha deve contar de 6 a 15 caracteres");

            RuleFor(p => p.ConfirmPassword)
                .NotEmpty().WithMessage("Campo obrigatório")
                .Length(6, 15).WithMessage("Sua senha deve contar de 6 a 15 caracteres")
                .Equal(p => p.Password).WithMessage("Senha de confirmação não inválida");
        }
    }
}
