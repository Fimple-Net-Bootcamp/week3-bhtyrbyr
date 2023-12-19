using VirtualPaws.Application.Interfaces.Repository.Entities;
using VirtualPaws.Domain.Entities;
using VirtualPaws.Persistence.Context;

namespace VirtualPaws.Persistence.Repositories.Entities
{
    internal class PetHealtStatusEntityRepository : GenericEntityRepository<PetHealtStatus>, IPetHealtStatusEntityRepository
    {
        public PetHealtStatusEntityRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
