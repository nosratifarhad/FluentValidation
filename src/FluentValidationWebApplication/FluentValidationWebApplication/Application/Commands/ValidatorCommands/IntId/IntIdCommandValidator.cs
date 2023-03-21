using FluentValidation;
using FluentValidationWebApplication.Application.Commands.ProductCommands.CreateProduct;

namespace FluentValidationWebApplication.Application.Commands.ValidatorCommands.IntId
{
    public class IntIdCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public IntIdCommandValidator()
        {
            RuleFor(x => x.Id)
            .GreaterThan("0")
            .WithMessage("{PropertyName} must be greater than 0.");
        }
    }
}
