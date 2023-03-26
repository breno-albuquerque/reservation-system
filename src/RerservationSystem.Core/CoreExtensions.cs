using Microsoft.Extensions.DependencyInjection;
using RerservationSystem.Core.Features.LoginUser.Handler;
using RerservationSystem.Core.Shared.Data;
using RerservationSystem.Core.Shared.Handlers;

namespace RerservationSystem.Core
{
    public static class CoreExtensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            return services
                .AddDataContext()
                .AddSqlService()
                .AddGetUser();
        }

        private static IServiceCollection AddDataContext(this IServiceCollection services)
        {
            return services.AddScoped<IDataContext, DataContext>();
        }

        private static IServiceCollection AddSqlService(this IServiceCollection services)
        {
            return services.AddScoped<ISqlService, SqlService>();
        }

        private static IServiceCollection AddGetUser(this IServiceCollection services)
        {
            return services.AddScoped<IHandler<LoginUserInput, LoginUserOutput>, LoginUserHandler>();
        }
    }
}
