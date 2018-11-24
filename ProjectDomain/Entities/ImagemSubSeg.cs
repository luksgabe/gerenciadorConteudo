using System;

namespace ProjectDomain.Entities
{
    [Serializable]
    public class ImagemSubSeg
    {
        public long id { get; set; }

        public int ordem { get; set; }

        public string nome { get; set; }

        public string descricao { get; set; }

        public string chave { get; set; }

        public bool visivel { get; set; }

        public long codSubSegmento { get; set; }

        public virtual SubSegmento subSegmento { get; set; }
    }
}
