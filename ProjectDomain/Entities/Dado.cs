using ProjectDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoGerenciadorConteudo.Entities
{
    [Serializable]
    public class Dado
    {
        public long id { get; set; }

        public int ordem { get; set; }

        public string nome { get; set; }

        public string referencia { get; set; }

        public string palavraChave { get; set; }

        public string chave { get; set; }

        public string oferta { get; set; }

        public string descricao { get; set; }

        public string texto { get; set; }

        public string resumo { get; set; }

        public string valor { get; set; }

        public string meta { get; set; }

        public DateTime data { get; set; }

        public bool visivel { get; set; }

        public bool ativo { get; set; }

        public bool destaque { get; set; }

        public long codPagina { get; set; }

        public virtual Pagina pagina { get; set; }

        public long codSegmento { get; set; }

        public virtual Segmento segmento { get; set; }

        public long codSubSegmento { get; set; }

        public virtual SubSegmento subSegmento { get; set; }

        public long codCategoria { get; set; }

        public virtual Categoria categoria { get; set; }

        public virtual ICollection<ImagemDado> listaImagens { get; set; }

        public virtual IList<ImagemDado> getImagensOrdenadas()
        {
            return listaImagens.OrderBy(x => x.ordem).ThenBy(x => x.nome).ToList();
        }


        //public virtual string getPrimeiraImagemHQ()
        //{
        //    if (listaImagens.Count > 0)
        //    {
        //        listaImagens = listaImagens.OrderBy(x => x.ordem).ToList();
        //        return MetodosFE.BaseURL + "/ImagensLQ/" + listaImagens[0].nome;
        //    }
        //    else
        //        return uplImage.imgSemImagem;
        //}

    }
}