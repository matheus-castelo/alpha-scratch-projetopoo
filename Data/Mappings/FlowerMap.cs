using Microsoft.EntityFrameworkCore;
using FFCE.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FFCE.Data.Mappings{
    public class FlowerMap : IEntityTypeConfiguration<Flower>
    {
        public void Configure(EntityTypeBuilder<Flower> builder)
        {
            builder.ToTable("Flower"); // [Table("Flower)]. Para dizer que é a tabela FLOWER>
            builder.HasKey(x => x.Id); //Configurando Chave Primária
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x=> x.Name).IsRequired();
            builder.Property(x=> x.Url).IsRequired();
            builder.Property(x=> x.Price).IsRequired();

        }
    }
}