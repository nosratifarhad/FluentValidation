using FluentValidation;

namespace FluentValidationWebApplication.Application.Commands.ValidatorCommands.ProductGroup
{
    public class ProductGroupCommandValidator: AbstractValidator<ProductGroupCommand>
    {
        public ProductGroupCommandValidator()
        {
            RuleFor(p => p.ProductGroups)
                 .NotEmpty().WithMessage("{PropertyName} must not be empty.");

            RuleForEach(group => group.ProductGroups)
                .SetValidator(new ProductGroupValidator())
                 .NotEmpty().WithMessage("{PropertyName} must not be empty.")
                 .NotNull().WithMessage("{PropertyName} must not be null.");

            //RuleFor(p => p.ProductGroups)
            //    .Must(FluentValidatorHelper.ValidateIdIsUnique).WithMessage("{PropertyName} must not be duplicate.");

        }
    }
    public class ProductGroupValidator : AbstractValidator<int>
    {
        public ProductGroupValidator()
        {
            RuleFor(item => item)
                .GreaterThan(0)
                .WithMessage("Product Group Id must be greater than 0.");
        }
    }
}
