namespace MedPulse.SharedKernel;

public static class DependencyInjection
{
    public static IServiceCollection AddPaginationSettings(
        this IServiceCollection services, 
        Action<PaginationSettings> configure)
    {
        services.Configure(configure);
        services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<PaginationSettings>>().Value);
        return services;
    }
}
