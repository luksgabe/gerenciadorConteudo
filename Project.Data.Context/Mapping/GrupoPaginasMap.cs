using ProjetoGerenciadorConteudo.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Project.Data.Context.Mapping
{
    public class GrupoPaginasMap : EntityTypeConfiguration<GrupoPaginas>
    {
        public GrupoPaginasMap()
        {
            HasKey(t => t.id).Property(p => p.id).HasColumnName("id_grupo_paginas");
        }


    }
}
