# FluentValidation and use Mediator .

## "int" Validator ?
### Please pay attention to the text of the errors .

```csharp

RuleFor(x => x.Id)
    .GreaterThan(0)
    .WithMessage("{PropertyName} must greater than {PropertyValue}.");

//RuleFor(x => x.Id)
//    .LessThan(100)
//    .WithMessage("{PropertyName} must less than {PropertyValue}.");

//RuleFor(x => x.Id)
//    .LessThanOrEqualTo(100)
//    .WithMessage("{PropertyName} must less than or equal to {PropertyValue}.");

//RuleFor(x => x.Id)
//     .GreaterThanOrEqualTo(1)
//     .WithMessage("{PropertyName} must greater than or equal to {PropertyValue}");

RuleFor(x => x.Id)
    .ExclusiveBetween(1, 10)
    .WithMessage("{PropertyName} must greater than 1 and less than 10.");

```
## "string" Validator ?
### Please pay attention to the text of the errors .

```csharp
RuleFor(x => x.ProductTitle)
    .NotEmpty()
    .WithMessage("{PropertyName} is required.");

RuleFor(x => x.ProductTitle)
    .NotNull()
    .WithMessage("{PropertyName} is required.");

RuleFor(x => x.ProductTitle)
    .NotEqual("Foo")
    .WithMessage("{PropertyName} should not be equal to ‘Foo’.");

RuleFor(x => x.ProductTitle)
    .MaximumLength(250)
    .WithMessage("{PropertyName} must be less than 20 chars.");

RuleFor(x => x.ProductTitle)
    .MinimumLength(20)
    .WithMessage("{PropertyName} must be greater than 20 chars.");

//RuleFor(x => x.ProductTitle)
//    .Length(20, 250).WithMessage("must be between 1 and 250 chars.");

```
## "enum" Validator ?
### Please pay attention to the text of the errors .

```csharp
RuleFor(x=>x.ProductType)
    .IsInEnum()
    .WithMessage("{PropertyName} must be enum.");
```

## "List int" Validator ?
### Please pay attention to the text of the errors .
```csharp
RuleFor(p => p.ProductGroups)
    .NotEmpty().WithMessage("{PropertyName} is required.");

RuleFor(p => p.ProductGroups)
    .Must(x => x.Count <= 3)
    .WithMessage("no more than 3 group are allowed.");

// validate items list use "ForEach" OR
//RuleFor(p => p.ProductGroups)
//      .ForEach(productGroup =>
//      {
//          productGroup 
//            .GreaterThan(0)
//            .WithMessage("{PropertyName} must greater than {PropertyValue}.");
//      });

//OR you can use custom validate for Lists like this =>
RuleForEach(p => p.ProductGroups)
    .SetValidator(new ProductGroupValidator());

RuleFor(p => p.ProductGroups)
    .NotEqual(group => group.ProductGroups)
    .WithMessage("{PropertyName} must not be duplicate.");
```
## you can use custom validate For "ProductGroups" 

```csharp
// this custom validate For "ProductGroups"
public class ProductGroupValidator : AbstractValidator<int>
{
    public ProductGroupValidator()
    {
        RuleFor(item => item)
            .GreaterThan(0)
            .WithMessage("{PropertyName} must greater than {PropertyValue}.");
    }
}
```
## "List Entity" Validator ?
### Please pay attention to the text of the errors .
```csharp
RuleFor(p => p.ProductPictures)
    .NotEmpty().WithMessage("{PropertyName} is required.")
    .NotNull().WithMessage("{PropertyName} is required.");

RuleFor(p => p.ProductPictures)
  .Must(p => p.Count <= 3)
  .WithMessage("No more than 10 orders are allowed.");

//validate items list use "ForEach" OR
//RuleFor(p => p.ProductPictures)
//  .ForEach(pictureRule =>
//  {
//      pictureRule
//      .Must(picture => picture.ProductPictureId > 0)
//      .WithMessage("{PropertyName} must greater than {PropertyValue}.");

//      //...
//  });

//OR you can use custom validate for Lists like this =>
RuleForEach(rule => rule.ProductPictures)
.SetValidator(new PictureValidator());

```

## you can use custom validate For "ProductPicture" 

```csharp
public class PictureValidator : AbstractValidator<ProductPicture>
{
    public PictureValidator()
    {
        RuleFor(x => x.ProductPictureId)
         .GreaterThanOrEqualTo(1)
         .WithMessage("{PropertyName} must greater than {PropertyValue}.");

        RuleFor(x => x.Path)
            .NotEmpty()
            .WithMessage("{PropertyName} is required.");

        RuleFor(x => x.Path)
            .NotNull()
            .WithMessage("{PropertyName} is required.");

        RuleFor(x => x.Path)
            .Length(20, 250).WithMessage("must be between 1 and 250 chars.")
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.");
    }
}
```
