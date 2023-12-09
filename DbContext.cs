using Microsoft.EntityFrameworkCore;

namespace GreenThumb
{
    public class YourDbContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plant>()
                .HasMany(p => p.FollowingInstructions)
                .WithOne(i => i.Plant)
                .HasForeignKey(i => i.PlantId);
        }
    }
}
