using FluentValidationWebApplication.Domain.Entity;

namespace FluentValidationWebApplication.Domain
{
    public interface IProductRepository
    {
        Task CreateProduct(Product product);

        Task<IEnumerable<Product>> GetProduct();
    }
}
