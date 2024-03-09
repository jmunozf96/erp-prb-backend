using ErpCore.Options;
using ErpSecurity.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using ErpPruebaBackend.Contexts;

namespace ErpPruebaBackend.Ioc
{
    public static class AppDbContext
    {
        public static IServiceCollection AddAppDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionOptionSection = configuration.GetSection(ConnectionOption.ConnectionString);
            ConnectionOption connectionOption = connectionOptionSection.Get<ConnectionOption>()!;
            var connectionString = connectionOption.Connection;

            services.AddDbContext<ErpDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<SecurityDbContext, ErpDbContext>();
            return services;
        }
    }
}
