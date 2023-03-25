using Microsoft.OpenApi.Models;
using FluentValidationWebApplication.IOC;

namespace FluentValidationWebApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplicationService();

            #region [ Mediator ]

            services.AddMediator(options =>
            {
                options.Namespace = "FluentValidationWebApplication";
                options.ServiceLifetime = ServiceLifetime.Transient;
            });

            #endregion [ Mediator ]

            services.AddControllers();

            #region [ Swagger ]
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FluentValidationWebApplication", Version = "v1" });
            });
            #endregion [ Swagger ]
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FluentValidationWebApplication v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

}