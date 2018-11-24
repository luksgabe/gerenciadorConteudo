using ProjectDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Project.Data.Context.Mapping
{
    public class ImagemSubSegmentoMap : EntityTypeConfiguration<ImagemSubSeg>
    {
        public ImagemSubSegmentoMap()
        {
            HasKey(s => s.id).Property(s => s.id).HasColumnName("id_imagem_subSegmento");

            HasRequired(i => i.subSegmento).WithMany(s => s.listaImagens).HasForeignKey(i => i.codSubSegmento);

            Property(t => t.codSubSegmento).HasColumnName("cod_subSegmento");
        }


    }
}
