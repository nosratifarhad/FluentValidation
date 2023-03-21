using FluentValidation;

namespace FluentValidationWebApplication.Application.Commands.ProductCommands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan("0")
                .WithMessage("{PropertyName} must be greater than {PropertyValue}.");

            RuleFor(x => x.ProductTitle)
                .NotEmpty()
                .WithMessage("{PropertyName} must not be empty.")
                .NotNull()
                .WithMessage("{PropertyName} must not be null.");

            RuleFor(x=>x.ProductType)
                .IsInEnum()
                .WithMessage("{PropertyName} must not be enum.");

            RuleFor(p => p.ProductGroups)
                .NotEmpty().WithMessage("{PropertyName} must not be empty.");

            RuleForEach(group => group.ProductGroups)
                .SetValidator(new ProductGroupValidator());

            //RuleFor(p => p.ProductGroups)
            //    .Must(FluentValidatorHelper.ValidateIdIsUnique).WithMessage("{PropertyName} must not be duplicate.");

            RuleFor(p => p.ProductPictures)
                .NotEmpty().WithMessage("{PropertyName} must not be empty.")
                .NotNull().WithMessage("{PropertyName} must not be null.");

            //RuleForEach(rule => rule.ProductPictures)
            //    .SetValidator(new MovieRegionAclCreateValidator())
            //    .NotEmpty().WithMessage("{PropertyName} must be empty.")
            //    .NotNull().WithMessage("{PropertyName} must be null.");

            //RuleFor(order => order.ProductPictures)
            //    .Must(p => FluentValidatorHelper.ValidateIdIsUnique(p?.Select(p => p?.ProductPictureId).ToList()))
            //    .WithMessage("Product Picture Id must not be duplicate.");

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
