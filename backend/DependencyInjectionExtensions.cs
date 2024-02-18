namespace Chat.Api;

internal static class DependencyInjectionExtensions
{
    public static void AddApiServicesAsync(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSwaggerGen();
    }
}
