using Microsoft.EntityFrameworkCore;
using FFCE.Models;
using FFCE.Data.Mappings;

namespace FFCE.Data
{
    /* The FloricultureDataContext class is a DbContext class in C#. */
    public class FloricultureDataContext : DbContext
    {
        /* The line `public DbSet<Flower> Flowers {get; set;}` in the
        `FloricultureDataContext` class is defining a property named `Flowers` of type
        `DbSet<Flower>`. */
        public DbSet<Flower> Flowers { get; set; } /* <summary>  The OnConfiguring method is used to configure the database connection settings  in a C# Entity Framework Core application.  </summary>  <param name="DbContextOptionsBuilder">DbContextOptionsBuilder is a class  provided by Entity Framework Core that is used to configure the behavior of a  DbContext instance. In the given code snippet, the OnConfiguring method is being  overridden to configure the DbContext to use a SQL Server database with the  specified connection string.</param> */
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$");
        }
        //Adicionando arquivos de mapemaneto para o Datacontext  <summary>
        /* The  OnModelCreating  function in C# is  used to apply  configuration  settings for  entity mapping in  Entity Framework.  </summary>  <param  name="ModelBuilder">The  ModelBuilder  class in Entity  Framework Core is  used to configure  the model that  defines the shape  of your entities  and their  relationships. It  is typically used  in the DbContext  class to define  the schema of the  database and how  the entities are  mapped to  database tables.  In the provided  code snippet, the  OnModelCreating  method</param> */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FlowerMap());
        }
    }
}