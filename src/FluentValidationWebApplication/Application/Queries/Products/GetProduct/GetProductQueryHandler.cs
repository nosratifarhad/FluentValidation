using Mediator;
using FluentValidationWebApplication.Service;
using FluentValidationWebApplication.ViewModels.ProductViewModels;

namespace FluentValidationWebApplication.Application.Queries.Products.GetProduct
{
    public class GetProductQueryHandler : IQueryHandler<GetProductQuery, IEnumerable<ProductVM>>
    {
        #region Fields

        private readonly IProductService _productService;
        #endregion Fields

        #region Ctor

        public GetProductQueryHandler(IProductService productService)
        {
            this._productService = productService;
        }

        #endregion Ctor

        #region Handle

        public async ValueTask<IEnumerable<ProductVM>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var productVMList = await _productService.GetProduct().ConfigureAwait(false);

            return productVMList;
        }

        #endregion
    }
}
