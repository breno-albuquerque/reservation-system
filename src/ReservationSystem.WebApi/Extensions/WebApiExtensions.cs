namespace ReservationSystem.WebApi.Extensions
{
    public static class WebApiExtensions
    {
        public static IServiceCollection AddWebApi(this IServiceCollection services)
        {
            return services
                .AddApiResources();
            //.AddJwtConfiguration();
        }

        public static IServiceCollection AddApiResources(this IServiceCollection services)
        {
            return services
                .AddSwaggerGen()
                .AddEndpointsApiExplorer();
        }

        //public static IServiceCollection AddJwtConfiguration(this IServiceCollection services)
        //{
        //    services
        //        .AddOptions<JwtConfiguration>()
        //        .Configure<IConfiguration>((settings, configuration) => { configuration.GetSection(nameof(JwtConfiguration)).Bind(settings); });

        //    return services;
        //}
    }
}
