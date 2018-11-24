using System;


namespace ProjetoGerenciadorConteudo.Entities
{
    [Serializable]
    public class PaginaControle
    {
        public long id { get; set; }

        public string nome { get; set; }

        public string endereco { get; set; }

        public bool fixa { get; set; }

        public long codGrupoPaginas { get; set; }

        public virtual GrupoPaginas grupoPaginas { get; set; }

        public decimal ordem { get; set; }
    }
}