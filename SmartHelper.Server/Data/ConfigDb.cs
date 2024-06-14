using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartHelper.Server.Models.PremisesAndFacilities;

namespace SmartHelper.Server.Data
{
    public class ConfigDb
    {
        private static DbContextOptions<SmarthelperDbContext>? _options;

        public void StartDb()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");

            var config = builder.Build();
            string? connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<SmarthelperDbContext>();
            var options = optionsBuilder.UseNpgsql(connectionString).Options;

            _options = options;
            
        }

        public DbContextOptions<SmarthelperDbContext> Options
        {
            get { return _options!; }
        }
    }
}
