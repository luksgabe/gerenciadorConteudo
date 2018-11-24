using ProjectDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Project.Data.Context.Mapping
{
    public class SegmentoMap : EntityTypeConfiguration<Segmento>
    {
        public SegmentoMap()
        {
            HasKey(t => t.id).Property(t => t.id).HasColumnName("id_segmento");

            HasRequired(s => s.pagina).WithMany(p => p.listaSegmento).HasForeignKey(p => p.codPagina);

            Property(t => t.codPagina).HasColumnName("cod_pagina");
        }

    }
}
