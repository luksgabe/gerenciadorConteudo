using System;

namespace ProjectDomain.Entities
{
    [Serializable]
    public class ImagemSegmento
    {
        public long id { get; set; }

        public int ordem { get; set; }

        public string nome { get; set; }

        public string descricao { get; set; }

        public string chave { get; set; }

        public bool visivel { get; set; }

        public long codSegmento { get; set; }

        public virtual Segmento segmento { get; set; }

    }
}
