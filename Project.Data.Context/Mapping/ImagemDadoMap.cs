using ProjectDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Project.Data.Context.Mapping
{
    public class ImagemDadoMap : EntityTypeConfiguration<ImagemDado>
    {
        public ImagemDadoMap()
        {
            HasKey(t => t.id).Property(p => p.id).HasColumnName("id_ImagemDado");

            HasRequired(i => i.dado).WithMany(p => p.listaImagens).HasForeignKey(d => d.codDado);

            Property(i => i.codDado).HasColumnName("cod_dado");
        }
    }
}
