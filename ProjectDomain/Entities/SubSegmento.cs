﻿using ProjetoGerenciadorConteudo.Entities;
using System;
using System.Collections.Generic;

namespace ProjectDomain.Entities
{
    [Serializable]
    public class SubSegmento
    {
        public long id { get; set; }

        public int ordem { get; set; }

        public string nome { get; set; }

        public string descricao { get; set; }

        public string chave { get; set; }

        public bool visivel { get; set; }

        public long codPagina { get; set; }

        public virtual Pagina pagina { get; set; }

        public long codSegmento { get; set; }

        public virtual Segmento segmento { get; set; }

        public virtual ICollection<Dado> listaDados { get; set; }

        public virtual ICollection<ImagemSubSeg> listaImagens { get; set; }

        public virtual ICollection<Categoria> listaCategorias { get; set; }

    }
}