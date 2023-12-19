using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPaws.Application.Interfaces.Repository.Entities;
using VirtualPaws.Domain.Entities;
using VirtualPaws.Persistence.Context;

namespace VirtualPaws.Persistence.Repositories.Entities
{
    public class UserEntityRepository : GenericEntityRepository<User>, IUserEntityRepository
    {
        public UserEntityRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
