using VirtualPaws.Application.Interfaces.Repository;
using VirtualPaws.Domain.Entities;
using VirtualPaws.Persistence.Context;

namespace VirtualPaws.Persistence.Repositories
{
    public class PetHealtStatusRepository : GenericRepository<PetHealtStatus>, IPetHealtStatusRepository
    {
        public PetHealtStatusRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
