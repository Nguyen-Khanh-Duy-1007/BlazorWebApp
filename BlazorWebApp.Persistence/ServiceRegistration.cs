using BlazorWebApp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWebApp.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BlazorWebAppContext>(options =>
            options.UseSqlServer(
               configuration.GetConnectionString("BlazorWebApp"),
               b => b.MigrationsAssembly(typeof(BlazorWebAppContext).Assembly.FullName)));
    }
}
