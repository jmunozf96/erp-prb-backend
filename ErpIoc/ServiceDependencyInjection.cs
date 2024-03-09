using ErpSecurity.Application.Services;
using ErpSecurity.Application.Usecases;
using ErpSecurity.Domain.Ports.In.Services;
using ErpSecurity.Domain.Ports.In.Usecases;
using Microsoft.Extensions.DependencyInjection;

namespace ErpIoc
{
    public static class ServiceDependencyInjection
    {
        public static IServiceCollection AddServiceDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<SignInUseCase, SignInUseCaseImpl>();
            services.AddScoped<GetAccessTokenUseCase, GetAccessTokenUseCaseImpl>();
            services.AddScoped<UserSessionService, UserSessionServiceImpl>();
            return services;
        }
    }
}
