using ProjectDomain.Entities;
using ProjetoGerenciadorConteudo.Interfaces.Services;
using System.Collections.Generic;

namespace ProjectDomain.Interfaces.Services
{
    public interface IUsuarioService : IService<Usuario>
    {
        IEnumerable<Usuario> BuscarRegistrosLogin(Usuario user);
    }
}
