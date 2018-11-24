using ProjectDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Project.Data.Context.Mapping
{
    public class ImagemCategoriaMap : EntityTypeConfiguration<ImagemCategoria>
    {
        public ImagemCategoriaMap()
        {
            HasKey(i => i.id).Property(i => i.id).HasColumnName("id_imagem_categoria");

            HasRequired(c => c.categoria).WithMany(p => p.listaImagens).HasForeignKey(c => c.codCategoria);

            Property(t => t.codCategoria).HasColumnName("cod_categoria");
        }

    }
}
