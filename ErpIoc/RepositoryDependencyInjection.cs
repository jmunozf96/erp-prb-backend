using ErpSecurity.Domain.Ports.Out;
using ErpSecurity.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ErpIoc
{
    public static class RepositoryDependencyInjection
    {
        public static IServiceCollection AddRepositoryDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<UserRepositoryPort, UserRepositoryAdapter>();
            return services;
        }
    }
}
