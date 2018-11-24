using ProjetoGerenciadorConteudo.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Project.Data.Context.Mapping
{
    public class UploadImagemMap : EntityTypeConfiguration<UploadImagem>
    {
        public UploadImagemMap()
        {
            HasKey(t => t.id).Property(p => p.id).HasColumnName("id_upload_imagem");
        }


    }
}
