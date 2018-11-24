using ProjectDomain.Entities;
using System;
using System.Collections.Generic;

namespace ProjetoGerenciadorConteudo.Entities
{
    [Serializable]
    public class Pagina
    {
        public long id { get; set; }

        public string nome { get; set; }

        public bool multi { get; set; }

        public long codPagControl { get; set; }

        public virtual PaginaControle paginaControle { get; set; }

        public long codUploadImagem { get; set; }

        public virtual UploadImagem uploadImagem { get; set; }

        public virtual ICollection<Dado> listaDados { get; set; }

        public virtual ICollection<Segmento> listaSegmento { get; set; }

        public virtual ICollection<SubSegmento> listaSubSegmento { get; set; }

        public virtual ICollection<Categoria> listaCategoria { get; set; }
    }
}