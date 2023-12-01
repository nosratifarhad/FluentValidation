using FluentValidationWebApplication.Domain;
using FluentValidationWebApplication.Domain.Entity;

namespace FluentValidationWebApplication.Repository
{
    public class ProductRepository : IProductRepository
    {
        public async Task CreateProduct(Product product, CancellationToken cancellationToken)
        {
            await Task.Delay(1000);
        }

        public async Task<IEnumerable<Product>> GetProduct(CancellationToken cancellationToken)
        {
            return await Task.FromResult(Enumerable.Empty<Product>());
        }
    }
}
