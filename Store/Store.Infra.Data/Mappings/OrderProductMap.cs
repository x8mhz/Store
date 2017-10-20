using System.Data.Entity.ModelConfiguration;
using System.Threading;

namespace Store.Infra.Data.Mappings
{
    public class OrderProductMap : EntityTypeConfiguration<OrderMap>
    {
        public OrderProductMap()
        {
            
            ToTable("ProdutoPedido");


        }
    }
}