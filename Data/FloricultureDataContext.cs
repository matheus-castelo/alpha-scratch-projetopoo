using FFCE.Models;
using FFCE.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace FFCE.Data
{
    public class FloricultureDataContext : DbContext
    {
        public DbSet<Flower> Flowers { get; set; }

        public FloricultureDataContext(DbContextOptions<FloricultureDataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FlowerMap());
        }
    }
}
