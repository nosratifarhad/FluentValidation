using FluentValidationWebApplication.Domain.Entity;

namespace FluentValidationWebApplication.Domain
{
    public interface IProductRepository
    {
        Task CreateProduct(Product product, CancellationToken cancellationToken);

        Task<IEnumerable<Product>> GetProduct(CancellationToken cancellationToken);
    }
}
