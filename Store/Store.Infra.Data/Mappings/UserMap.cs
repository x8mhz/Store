using System.Data.Entity.ModelConfiguration;
using Store.Domain.Entities;

namespace Store.Infra.Data.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("Usuario");

            HasKey(p => p.Id);

            Property(p => p.Email)
                .HasColumnName("Email")
                .IsRequired();

            Property(p => p.Password)
                .HasColumnName("Password")
                .IsRequired();

            Property(p => p.RegisterDate)
                .HasColumnName("DataRegistro")
                .IsRequired();

            Property(p => p.Active)
                .HasColumnName("Ativo")
                .IsRequired();
        }
    }
}