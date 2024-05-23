using gms.data;
using Microsoft.EntityFrameworkCore;

namespace gms.web.Extensions.Database;

public static class DatabaseExtensions
{
    public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("DefaultConnection")
                                    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

        services.AddDbContextPool<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
            options.UseLazyLoadingProxies();
        });
    }
}
