using ErpCore.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ErpIoc.Options
{
    public static class OptionsService
    {
        public static IServiceCollection AddOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtOption>(configuration.GetSection(JwtOption.Jwt));
            services.Configure<ConnectionOption>(configuration.GetSection(ConnectionOption.ConnectionString));
            return services;
        }
    }
}
