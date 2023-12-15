using Microsoft.EntityFrameworkCore;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=qawsedb12;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetFood> PetFoods { get; set; }
        public DbSet<Activity>  Activities { get; set; }
        public DbSet<PetHealtStatus> PetHealtSituations { get; set; }
        public DbSet<OwnershipRecord> OwnershipRecords { get; set; }
    }
}
