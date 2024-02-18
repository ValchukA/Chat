namespace Chat.Api
{
    internal static class DependencyInjectionExtensions
    {
        public static void AddApiServices(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();
        }
    }
}
