using VirtualPaws.Application.Interfaces.Repository;
using VirtualPaws.Domain.Entities;
using VirtualPaws.Persistence.Context;

namespace VirtualPaws.Persistence.Repositories
{
    public class PetFoodRepository : GenericRepository<PetFood>, IPetFoodRepository
    {
        public PetFoodRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
