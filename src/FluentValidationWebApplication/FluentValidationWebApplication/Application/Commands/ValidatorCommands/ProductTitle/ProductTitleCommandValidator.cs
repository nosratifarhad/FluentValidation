using FluentValidation;

namespace FluentValidationWebApplication.Application.Commands.ValidatorCommands.ProductTitle
{
    public class ProductTitleCommandValidator: AbstractValidator<ProductTitleCommand>
    {
        public ProductTitleCommandValidator()
        {
            RuleFor(x => x.ProductTitle)
                .NotEmpty()
                .WithMessage("{PropertyName} must not be empty.")
                .NotNull()
                .WithMessage("{PropertyName} must not be null.");
        }
    }
}
