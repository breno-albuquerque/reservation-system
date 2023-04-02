using Microsoft.Extensions.DependencyInjection;
using RerservationSystem.Core.Features.LoginUser.Handler;
using RerservationSystem.Core.Features.RegisterUser.Handler;
using RerservationSystem.Core.Shared.Data;
using RerservationSystem.Core.Shared.Handlers;
using RerservationSystem.Core.Shared.Services.JwtToken;
using RerservationSystem.Core.Shared.Users.Repositories;

namespace RerservationSystem.Core
{
    public static class CoreExtensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            return services
                .AddDataContext()
                .AddSqlService()
                .AddRegisterUser()
                .AddLoginUser()
                .AddRepositories()
                .AddServices();
        }

        private static IServiceCollection AddDataContext(this IServiceCollection services)
        {
            return services.AddScoped<IDataContext, DataContext>();
        }

        private static IServiceCollection AddSqlService(this IServiceCollection services)
        {
            return services.AddScoped<ISqlService, SqlService>();
        }
        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services.AddScoped<IUserRepository, UserRepository>();
        }

        private static IServiceCollection AddRegisterUser(this IServiceCollection services)
        {
            return services.AddScoped<IHandler<RegisterUserInput, RegisterUserOutput>, RegisterUserHandler>();
        }

        private static IServiceCollection AddLoginUser(this IServiceCollection services)
        {
            return services.AddScoped<IHandler<LoginUserInput, LoginUserOutput>, LoginUserHandler>();
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services.AddScoped<ITokenService, TokenService>();
        }
    }
}
