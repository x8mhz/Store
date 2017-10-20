using System.Data.Entity.ModelConfiguration;
using Store.Domain.Entities;

namespace Store.Infra.Data.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Produto");

            HasKey(p => p.Id);

            Property(p => p.Title)
                .HasColumnName("Titulo")
                .IsRequired();

            Property(p => p.Description)
                .HasColumnName("Descrição")
                .IsRequired();

            Property(p => p.QuantityOnHand)
                .HasColumnName("Quantidade")
                .IsRequired();

            Property(p => p.Price)
                .HasColumnName("Valor")
                .IsRequired();
        }
    }
}