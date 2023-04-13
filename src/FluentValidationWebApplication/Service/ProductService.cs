using FluentValidationWebApplication.Dtos;
using FluentValidationWebApplication.Service.Contracts;
using FluentValidationWebApplication.ViewModels.ProductViewModels;

namespace FluentValidationWebApplication.Service
{
    public class ProductService : IProductService
    {
        public async Task CreateProduct(CreateProductDto createProductDto)
        {
            await Task.Delay(1000);
        }

        public async Task<IEnumerable<ProductVM>> GetProduct()
        {
            return await Task.FromResult(new List<ProductVM>());
        }
    }
}
