using FluentValidationWebApplication.Service;
using FluentValidationWebApplication.Service.Contracts;

namespace FluentValidationWebApplication.IOC
{
    public static class ServiceRegister
    {
        public static void AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
