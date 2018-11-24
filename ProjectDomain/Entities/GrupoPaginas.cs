using System;
using System.Collections.Generic;

namespace ProjetoGerenciadorConteudo.Entities
{
    [Serializable]
    public class GrupoPaginas
    {
        public long id { get; set; }

        public string nome { get; set; }

        public decimal ordem { get; set; }

        public virtual ICollection<PaginaControle> listaPaginasControle { get; set; }
    }
}