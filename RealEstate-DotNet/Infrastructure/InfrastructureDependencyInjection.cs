using Application.Interfaces.Repositories;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class InfrastructureDependencyInjection
    {

        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {

            services.AddScoped<IPropertyRepository, PropertyRepositoryAsync>();
            services.AddScoped<IApartmentsRepositoryAsync, ApartmentsRepositoryAsync>();
            services.AddScoped<IPhotoRepositoryAsync, PhotoRepositoryAsync>();
            services.AddScoped<IVirtualTourRepositoryAsync, VirtualTourRepositoryAsync>();

            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

            return services;
        }
    }
}
