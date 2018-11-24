using ProjectDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Project.Data.Context.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
           HasKey(i => i.id).Property(i => i.id).HasColumnName("id_usuario");

            Property(u => u.senha).HasMaxLength(1000);
        }
    }
}
