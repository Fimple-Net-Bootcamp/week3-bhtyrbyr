using VirtualPaws.Application.Interfaces.Repository.Entities;
using VirtualPaws.Domain.Entities;
using VirtualPaws.Persistence.Context;

namespace VirtualPaws.Persistence.Repositories.Entities
{
    public class ActivityEntityRepository : GenericEntityRepository<Activity>, IActivityRepository
    {
        public ActivityEntityRepository(AppDbContext dbContext) : base(dbContext)
        { }
    }
}
