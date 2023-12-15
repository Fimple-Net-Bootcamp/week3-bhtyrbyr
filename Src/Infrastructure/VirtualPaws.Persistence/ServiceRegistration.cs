using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VirtualPaws.Application.Interfaces.Repository;
using VirtualPaws.Persistence.Context;
using VirtualPaws.Persistence.Repositories;

namespace VirtualPaws.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(opt => 
                                                opt.UseNpgsql(
                                                    connectionString: "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=postgres;"
                                                    )
                                                );
            services.AddTransient<IPetRepository, PetRepository>();
            services.AddTransient<IActivityRepository, ActivityRepository>();
            services.AddTransient<IPetHealtStatusRepository, PetHealtStatusRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
