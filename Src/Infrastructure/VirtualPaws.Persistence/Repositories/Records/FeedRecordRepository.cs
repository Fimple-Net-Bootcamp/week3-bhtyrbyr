using VirtualPaws.Application.Interfaces.Repository.Records;
using VirtualPaws.Domain.RecordEntities;
using VirtualPaws.Persistence.Context;

namespace VirtualPaws.Persistence.Repositories.Records
{
    public class FeedRecordRepository : GenericRecordRepository<FeedRecord>, IFeedRecordRepository
    {
        public FeedRecordRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
