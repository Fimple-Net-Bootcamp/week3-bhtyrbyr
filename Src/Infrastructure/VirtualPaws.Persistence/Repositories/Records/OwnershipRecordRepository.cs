using VirtualPaws.Application.Interfaces.Repository.Records;
using VirtualPaws.Domain.RecordEntities;
using VirtualPaws.Persistence.Context;

namespace VirtualPaws.Persistence.Repositories.Records
{
    public class OwnershipRecordRepository : GenericRecordRepository<OwnershipRecord>, IOwnershipRecordRepository
    {
        public OwnershipRecordRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
