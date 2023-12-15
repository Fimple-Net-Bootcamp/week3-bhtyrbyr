using VirtualPaws.Application.Interfaces.Repository;
using VirtualPaws.Domain.Entities;
using VirtualPaws.Persistence.Context;

namespace VirtualPaws.Persistence.Repositories
{
    public class OwnershipRecordRepository : GenericRepository<OwnershipRecord>, IOwnershipRecordRepository
    {
        public OwnershipRecordRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
