namespace ReservationSystem.WebApi
{
    public static class WebApiExtensions
    {
        public static IServiceCollection AddWebApi(this IServiceCollection services)
        {
            return services
                .AddApiResources();
        }

        public static IServiceCollection AddApiResources(this IServiceCollection services)
        {
            return services
                .AddSwaggerGen()
                .AddEndpointsApiExplorer();
        }
    }
}
