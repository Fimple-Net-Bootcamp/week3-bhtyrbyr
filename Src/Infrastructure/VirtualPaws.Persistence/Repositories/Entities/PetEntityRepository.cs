using Microsoft.EntityFrameworkCore;
using VirtualPaws.Application.Interfaces.Repository.Entities;
using VirtualPaws.Domain.Entities;
using VirtualPaws.Persistence.Context;

namespace VirtualPaws.Persistence.Repositories.Entities
{
    public class PetEntityRepository : GenericEntityRepository<Pet>, IPetEntityRepository
    {
        public PetEntityRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
