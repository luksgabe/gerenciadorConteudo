using ProjectDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Project.Data.Context.Mapping
{
    public class ImagemSegmentoMap : EntityTypeConfiguration<ImagemSegmento>
    {
        public ImagemSegmentoMap()
        {
            HasKey(i => i.id).Property(i => i.id).HasColumnName("id_imagem_segmento");

            HasRequired( i => i.segmento).WithMany(s => s.listaImagens).HasForeignKey(i => i.codSegmento);

            Property(t => t.codSegmento).HasColumnName("cod_segmento");

        }
    }
}
