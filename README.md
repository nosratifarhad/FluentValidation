# FluentValidation and use Mediator .

## "int" Validator ?
### Please pay attention to the text of the errors .

```cahrp

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
 
