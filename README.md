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
