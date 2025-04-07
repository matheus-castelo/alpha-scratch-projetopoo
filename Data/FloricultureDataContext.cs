using Microsoft.EntityFrameworkCore;
using FFCE.Models;
using FFCE.Data.Mappings;

namespace FFCE.Data {
    public class FloricultureDataContext : DbContext {
        public DbSet<Flower> Flowers {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$");
        }
        //Adicionando arquivos de mapemaneto para o Datacontext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FlowerMap());
        }
    }
}