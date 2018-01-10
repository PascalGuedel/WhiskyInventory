using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WhiskyInventory.Business.Codetable;
using WhiskyInventory.Data.Models;

namespace WhiskyInventory.Api.DependencyInjection
{
    public class DiConfiguration
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            // Data
            services.AddDbContext<WhiskyStoreContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("WhiskyStoreDb")));

            // Business
            services.AddTransient<ICodetableGetter, CodetableGetter>();
        }
    }
}
