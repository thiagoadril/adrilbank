using AdrilBank.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AdrilBank.Api.Setup
{
    public static class DatabaseSetup
    {
        public static void AddDatabaseSetup(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AdrilBankContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                x => x.MigrationsAssembly("AdrilBank.Infra.Data")));
        }
    }
}
