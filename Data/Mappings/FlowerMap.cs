using Microsoft.EntityFrameworkCore;
using FFCE.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FFCE.Data.Mappings{
    public class FlowerMap : IEntityTypeConfiguration<Flower>
    {

/// <summary>
/// This C# function configures the entity type for a Flower table, setting up the
/// primary key, identity column, and required properties for Name, Url, and Price.
/// </summary>
/// <param name="builder">The `builder` parameter in the `Configure` method is an
/// instance of `EntityTypeBuilder<Flower>`. It is used to configure the entity type
/// `Flower` in Entity Framework Core. By using the `builder` parameter, you can
/// define various aspects of the entity such as table name</param>
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