using Microsoft.EntityFrameworkCore;
using FFCE.Models;
using FFCE.Data.Mappings;

namespace FFCE.Data
{
    public class FloricultureDataContext : DbContext
    {
        // DbSet property for the Flower entity
        public DbSet<Flower> Flowers { get; set; }

        // Constructor that accepts DbContextOptions<FloricultureDataContext>
        public FloricultureDataContext(DbContextOptions<FloricultureDataContext> options)
            : base(options)
        {
        }

        // Configure the database connection string
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // You can keep this if you want to use a hardcoded connection string
            options.UseSqlServer("Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$");
        }

        // Apply the mappings for the entities
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FlowerMap());
        }
    }
}
