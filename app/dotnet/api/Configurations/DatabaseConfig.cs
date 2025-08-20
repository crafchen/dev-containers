using api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace api.Configurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            
            var area = configuration.GetSection("AppSettings:Area").Value;

            var connectionString = configuration.GetConnectionString($"{area}_DefaultConnection");
            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException($"Connection string '{area}_DefaultConnection' not found.");

            services.AddDbContext<DBContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });
        }
    }
}
