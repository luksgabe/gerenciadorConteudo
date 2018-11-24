using ProjectDomain.Interfaces.Services.Specific;
using System;
using System.Security.Cryptography;
using System.Text;

namespace ProjectDomain.Services.Specific
{
    public class Hash : IHash
    {
        private HashAlgorithm _algoritimo;

        public Hash(HashAlgorithm algoritimo)
        {
            _algoritimo = algoritimo;
        }
       
        public bool CheckHash(string password, string passwordRecorded)
        {
            if (string.IsNullOrEmpty(passwordRecorded))
                throw new NullReferenceException("Cadastre uma senha.");

            var senhaCifrada = _algoritimo.ComputeHash(Encoding.UTF8.GetBytes(password));
            var sb = new StringBuilder();
            foreach (var caractere in senhaCifrada)
            {
                sb.Append(caractere.ToString("X2"));
            }
            return sb.ToString() == passwordRecorded;
        }

        public string GenerateHash(string password)
        {
            var valorCodificado = Encoding.UTF8.GetBytes(password);
            var senhaCifrada = _algoritimo.ComputeHash(valorCodificado);
            var sb = new StringBuilder();
            foreach (var caractere in senhaCifrada)
            {
                sb.Append(caractere.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
