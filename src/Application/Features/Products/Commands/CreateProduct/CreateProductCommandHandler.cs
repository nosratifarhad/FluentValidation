using Mediator;

namespace FluentValidationWebApplication.Application.Features.Products.Commands.ProductCommands.CreateProduct
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand>
    {
        public ValueTask<Unit> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
