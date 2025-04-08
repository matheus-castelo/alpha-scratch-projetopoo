using FFCE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FFCE.Data.Mappings
{
    public class FlowerMap : IEntityTypeConfiguration<Flower>
    {
        public void Configure(EntityTypeBuilder<Flower> builder)
        {
            // Definir a chave primária
            builder.HasKey(f => f.Id);

            // Configurar o Id para ser gerado automaticamente
            builder.Property(f => f.Id)
                   .ValueGeneratedOnAdd();

            // Configurar as propriedades
            builder.Property(f => f.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(f => f.Url)
                   .IsRequired()
                   .HasMaxLength(200);

            // Outras configurações conforme necessário
        }
    }
}
