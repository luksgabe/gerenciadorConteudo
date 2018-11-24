using ProjetoGerenciadorConteudo.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Project.Data.Context.Mapping
{
    public class DadoMap : EntityTypeConfiguration<Dado>
    {
        public DadoMap()
        {
            HasKey(t => t.id).Property(p => p.id).HasColumnName("id_dado");

            Property(t => t.palavraChave).HasColumnName("palavra_chave");

            HasRequired(d => d.pagina).WithMany(p => p.listaDados).HasForeignKey(d => d.codPagina);

            Property(t => t.codPagina).HasColumnName("cod_pagina");

            HasRequired(d => d.segmento).WithMany(s => s.listaDados).HasForeignKey(d => d.codSegmento);

            Property(t => t.codSegmento).HasColumnName("cod_segmento");

            HasRequired(d => d.subSegmento).WithMany(s => s.listaDados).HasForeignKey(d => d.codSubSegmento);

            Property(t => t.codSubSegmento).HasColumnName("cod_subSegmento");

            HasRequired(d => d.categoria).WithMany().HasForeignKey(d => d.codCategoria);

            Property(t => t.codCategoria).HasColumnName("cod_categoria");
        }
    }
}
