using System;

namespace ProjectDomain.Entities
{
    [Serializable]
    public class Usuario
    {

        public long id { get; set; }

        public string  nome { get; set; }

        public string login { get; set; }

        public string senha { get; set; }

    }
}
