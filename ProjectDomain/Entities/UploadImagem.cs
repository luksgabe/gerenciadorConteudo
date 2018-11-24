using System;

namespace ProjetoGerenciadorConteudo.Entities
{
    [Serializable]
    public class UploadImagem
    {
        public long id { get; set; }
        public decimal quantidade { get; set; } 
    }
}