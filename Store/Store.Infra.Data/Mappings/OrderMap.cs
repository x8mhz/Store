using System.Data.Entity.ModelConfiguration;
using Store.Domain.Entities;

namespace Store.Infra.Data.Mappings
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            ToTable("Pedido");

            HasKey(p => p.Id);

            Property(p => p.OrderDate)
                .HasColumnName("DataPedido")
                .IsRequired();
        }

    }
}