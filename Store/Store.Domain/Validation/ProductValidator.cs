using FluentValidation;
using Store.Domain.Entities;

namespace Store.Domain.Validation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("Campo obrigatório")
                .Length(2, 50).WithMessage("Campo inválido, o titulo deve conter entre 2 e 50 caracteres");

            RuleFor(p => p.Description);

            RuleFor(p => p.Category.Title)
                .NotEmpty().WithMessage("Campo obrigatório")
                .Length(2, 50).WithMessage("Este campo deve conter entre 2 e 50 caracteres");

            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("Campo obrigatório");

            RuleFor(p => p.QuantityOnHand)
                .NotEmpty().WithMessage("Campo obrigatório");

        }
    }
}