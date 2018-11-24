using ProjetoGerenciadorConteudo.Entities;
using System;

namespace ProjectDomain.Entities
{
    [Serializable]
    public class ImagemDado
    {
        public long id { get; set; }

        public int ordem { get; set; }

        public virtual Dado dado { get; set; }

        public long codDado { get; set; }

        public string nome { get; set; }
    }
}
