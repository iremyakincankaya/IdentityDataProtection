using IdentityDataProtection.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentityDataProtection.DbContext
{
    public class IdentityDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options):base(options)
        {
            
        }

        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
                        .Property(u => u.Email)
                        .IsRequired();

            modelBuilder.Entity<UserEntity>()
                        .Property(u => u.Password)
                        .IsRequired();

            base.OnModelCreating(modelBuilder);
        }

    }
}
