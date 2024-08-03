using northwind_project.Models;
using northwind_project.Services;
using northwind_project.Services.Interface;

namespace northwind_project.Extensions
{
    public static class NorthwindServiceRegistration
    {
        public static IServiceCollection AddNorthwindServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
