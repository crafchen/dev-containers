using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace api.Data
{
    public class DBContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args)
        {
            // Build configuration to read connection string
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // thư mục project
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            var area = configuration.GetSection("AppSettings:Area").Value;
            var connectionString = configuration.GetConnectionString($"{area}_DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<DBContext>();
            optionsBuilder.UseNpgsql(connectionString);

            return new DBContext(optionsBuilder.Options);
        }
    }
}
