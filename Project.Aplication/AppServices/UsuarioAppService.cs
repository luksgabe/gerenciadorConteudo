using Project.Aplication.Interface;
using ProjectDomain.Entities;
using ProjectDomain.Interfaces.Repositories;
using ProjectDomain.Interfaces.Services;
using ProjectDomain.Services.Specific;
using System;
using System.Linq;
using System.Security.Cryptography;


namespace Project.Aplication.AppServices
{
    public class UsuarioAppService : AppService<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;
        public IUsuarioRepository _usuarioRepository;

        public UsuarioAppService(IUsuarioService usuarioService) : base(usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public Usuario BuscaLogin(Usuario user)
        {
            var hash = new Hash(SHA512.Create());
            user.senha = hash.GenerateHash(user.senha);

            var userList = _usuarioService.BuscarRegistrosLogin(user).ToList();

            if (userList.Count().Equals(0) || userList.Equals(null))
            {
                throw new Exception("Login ou senha inválidos.");
            }

            return userList.FirstOrDefault();
        }
    }
}
