using FluentValidationWebApplication.Service;

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
