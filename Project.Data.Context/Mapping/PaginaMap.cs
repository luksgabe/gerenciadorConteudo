using ProjetoGerenciadorConteudo.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Project.Data.Context.Mapping
{
    public class PaginaMap : EntityTypeConfiguration<Pagina>
    {
       public PaginaMap()
        {
            HasKey(t => t.id).Property(p => p.id).HasColumnName("id_pagina");

            HasRequired(p => p.paginaControle).WithMany().HasForeignKey(d => d.codPagControl);

            Property(d => d.codPagControl).HasColumnName("cod_pagina_controle");

            HasRequired(p => p.uploadImagem).WithMany().HasForeignKey(d => d.codUploadImagem);

            Property(d => d.codUploadImagem).HasColumnName("cod_upload_imagem");

        }


    }
}
