using FluentValidation;

namespace FluentValidationWebApplication.Application.Commands.ValidatorCommands.EnumProductType
{
    public class EnumProductTypeCommandValidator: AbstractValidator<EnumProductTypeCommand>
    {
        public EnumProductTypeCommandValidator()
        {
            RuleFor(x => x.ProductType)
            .IsInEnum()
            .WithMessage("{PropertyName} must not be enum.");
        }
    }
}
