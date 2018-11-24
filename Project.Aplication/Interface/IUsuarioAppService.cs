using ProjectDomain.Entities;

namespace Project.Aplication.Interface
{
    public interface IUsuarioAppService : IAppService<Usuario>
    {
        Usuario BuscaLogin(Usuario user);
    }
}
