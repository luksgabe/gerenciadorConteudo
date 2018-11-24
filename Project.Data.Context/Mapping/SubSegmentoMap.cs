using ProjectDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Project.Data.Context.Mapping
{
    public class SubSegmentoMap : EntityTypeConfiguration<SubSegmento>
    {
        public SubSegmentoMap()
        {
            HasKey(s => s.id).Property(s => s.id).HasColumnName("id_subSegmento");

            HasRequired(s => s.segmento).WithMany(s => s.listaSubSegs).HasForeignKey(s => s.codSegmento);

            Property(t => t.codSegmento).HasColumnName("cod_segmento");

            HasRequired(s => s.pagina).WithMany(p => p.listaSubSegmento).HasForeignKey(p => p.codPagina);

            Property(t => t.codPagina).HasColumnName("cod_pagina");
        }
    }
}
