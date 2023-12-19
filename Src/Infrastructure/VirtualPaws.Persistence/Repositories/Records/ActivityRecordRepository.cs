using VirtualPaws.Application.Interfaces.Repository.Records;
using VirtualPaws.Domain.RecordEntities;
using VirtualPaws.Persistence.Context;

namespace VirtualPaws.Persistence.Repositories.Records
{
    public class ActivityRecordRepository : GenericRecordRepository<ActivityRecord>, IActivityRecordRepository
    {
        public ActivityRecordRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
