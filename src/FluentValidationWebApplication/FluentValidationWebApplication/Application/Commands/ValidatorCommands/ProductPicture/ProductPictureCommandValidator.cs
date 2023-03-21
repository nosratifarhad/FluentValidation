using FluentValidation;

namespace FluentValidationWebApplication.Application.Commands.ValidatorCommands.ProductPicture
{
    public class ProductPictureCommandValidator : AbstractValidator<ProductPictureCommand>
    {
        public ProductPictureCommandValidator()
        {

            RuleFor(p => p.Pictures)
                .NotEmpty().WithMessage("{PropertyName} must not be empty.")
                .NotNull().WithMessage("{PropertyName} must not be null.");

            RuleForEach(rule => rule.Pictures)
                .SetValidator(new PictureValidator())
                .NotEmpty().WithMessage("{PropertyName} must be empty.")
                .NotNull().WithMessage("{PropertyName} must be null.");

            //RuleFor(order => order.Pictures)
            //    .Must(p => FluentValidatorHelper.ValidateIdIsUnique(p?.Select(p => p?.ProductPictureId).ToList()))
            //    .WithMessage("Product Picture Id must not be duplicate.");

        }
    }
    public class PictureValidator : AbstractValidator<Picture>
    {
        public PictureValidator()
        {
            RuleFor(x => x.ProductPictureId)
             .GreaterThanOrEqualTo(1)
             .WithMessage("{PropertyName} must greater than 0");

            RuleFor(x => x.Path)
                .Length(20, 250).WithMessage("Please specify a first name")
                .NotEmpty().WithMessage("{PropertyName} must be empty.")
                .NotNull().WithMessage("{PropertyName} must be null.");
        }
    }

}