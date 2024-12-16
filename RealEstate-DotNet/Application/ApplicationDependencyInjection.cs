using Application.Services.Implementations;
using Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplicationDependencyInjection(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IPropertyService, PropertyService>();
            services.AddScoped<IApartmentService, ApartmentService>();
            services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<IVirtualTourService, VirtualTourService>();

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
