using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {  }

        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetFood> PetFoods { get; set; }
        public DbSet<System.Diagnostics.Activity>  Activities { get; set; }
        public DbSet<PetHealtStatus> PetHealtSituations { get; set; }
        public DbSet<OwnershipRecord> OwnershipRecords { get; set; }
    }
}
