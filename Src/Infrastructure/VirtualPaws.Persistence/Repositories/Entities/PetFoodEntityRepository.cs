using VirtualPaws.Application.Interfaces.Repository.Entities;
using VirtualPaws.Domain.Entities;
using VirtualPaws.Persistence.Context;

namespace VirtualPaws.Persistence.Repositories.Entities
{
    public class PetFoodEntityRepository : GenericEntityRepository<PetFood>, IPetFoodEntityRepository
    {
        public PetFoodEntityRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
