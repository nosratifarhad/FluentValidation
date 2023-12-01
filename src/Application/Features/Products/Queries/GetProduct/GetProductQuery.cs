using Mediator;
using FluentValidationWebApplication.ViewModels.ProductViewModels;

namespace FluentValidationWebApplication.Application.Queries.Products.GetProduct
{
    public class GetProductQuery : IQuery<IEnumerable<ProductVM>>
    {
    }
}