using Microsoft.EntityFrameworkCore;
using XenonAPI.Models;

namespace XenonAPI.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Tenant> Tenants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
            modelBuilder.Entity<Tenant>()
                .Property(t => t.DepositAmount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Tenant>()
                .Property(t => t.RentAmount)
                .HasPrecision(18, 2);
        }
    }

}
