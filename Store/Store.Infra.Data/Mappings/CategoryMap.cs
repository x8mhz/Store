using System.Data.Entity.ModelConfiguration;
using Store.Domain.Entities;

namespace Store.Infra.Data.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Categoria");

            HasKey(p => p.Id);

            Property(p => p.Title)
                .HasColumnName("Titulo")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}