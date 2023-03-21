using FluentValidationWebApplication.Dtos;
using FluentValidationWebApplication.ViewModels.ProductViewModels;

namespace FluentValidationWebApplication.Service
{
    public interface IProductService
    {
        Task CreateProduct(CreateProductDto createProductDto);

        Task<IEnumerable<ProductVM>> GetProduct();
    }
}
