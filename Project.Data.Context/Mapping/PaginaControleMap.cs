using ProjetoGerenciadorConteudo.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Project.Data.Context.Mapping
{
    public class PaginaControleMap : EntityTypeConfiguration<PaginaControle>
    {
        public PaginaControleMap()
        {
            HasKey(p => p.id).Property(p => p.id).HasColumnName("id_pagina_controle");

            HasRequired(p => p.grupoPaginas).WithMany(g => g.listaPaginasControle).HasForeignKey(p => p.codGrupoPaginas);

            Property(p => p.codGrupoPaginas).HasColumnName("cod_grupo_pagina");
        }

    }
}
