using FluentValidation;
using FluentValidationWebApplication.Application.Commands.ValidatorCommands.ProductTypeEnum;

namespace FluentValidationWebApplication.Application.Commands.ValidatorCommands.EnumProductType
{
    public class ProductTypeCommandValidator: AbstractValidator<ProductTypeCommand>
    {
        public ProductTypeCommandValidator()
        {
            RuleFor(x => x.ProductType)
            .IsInEnum()
            .WithMessage("{PropertyName} must not be enum.");
        }
    }
}
