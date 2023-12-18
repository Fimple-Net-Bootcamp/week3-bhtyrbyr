using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VirtualPaws.Persistence.Context;

namespace VirtualPaws.Persistence
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, string connectionStringinAppSettings)
        {
            services.AddDbContext<AppDbContext>(opt => 
                                                opt.UseNpgsql(
                                                    connectionString: "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=postgres;"
                                                    )
                                                );
            return services;
        }
    }
}
