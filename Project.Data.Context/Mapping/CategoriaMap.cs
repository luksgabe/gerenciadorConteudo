using ProjectDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Project.Data.Context.Mapping
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            HasKey(i => i.id).Property(i => i.id).HasColumnName("id_categoria");

            HasRequired(c => c.pagina).WithMany(p => p.listaCategoria).HasForeignKey(c => c.codPagina);

            Property(t => t.codPagina).HasColumnName("cod_pagina");

            HasRequired(c => c.subSegmento).WithMany(s => s.listaCategorias).HasForeignKey(c => c.codSubSegmento);

            Property(t => t.codSubSegmento).HasColumnName("cod_subSegmento");

        }
    }
}
