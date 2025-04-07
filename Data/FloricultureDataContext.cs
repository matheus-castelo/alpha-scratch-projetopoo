using Microsoft.EntityFrameworkCore;
using FFCE.Models;

namespace FFCE.Data {
    public class FloricultureDataContext : DbContext {
        public DbSet<Flower> Flowers {get; set;}
    }
}