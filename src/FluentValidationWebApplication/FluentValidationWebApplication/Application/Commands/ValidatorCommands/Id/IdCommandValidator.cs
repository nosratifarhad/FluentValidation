using FluentValidation;
using FluentValidationWebApplication.Application.Commands.ValidatorCommands.Id;

namespace FluentValidationWebApplication.Application.Commands.ValidatorCommands.IntId
{
    public class IdCommandValidator : AbstractValidator<IdCommand>
    {
        public IdCommandValidator()
        {
            RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage("{PropertyName} must be greater than 0.");
        }
    }
}
