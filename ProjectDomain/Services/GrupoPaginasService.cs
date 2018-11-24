using ProjetoGerenciadorConteudo.Entities;
using ProjetoGerenciadorConteudo.Interfaces.Repositories;
using ProjetoGerenciadorConteudo.Interfaces.Services;

namespace ProjetoGerenciadorConteudo.Services
{
    public class GrupoPaginasService : Service<GrupoPaginas>, IGrupoPaginasService
    {
        private readonly IGrupoPaginasRepository _grupoPaginasRepository;

        public GrupoPaginasService(IGrupoPaginasRepository grupoPaginasRepository) : base(grupoPaginasRepository)
        {
            _grupoPaginasRepository = grupoPaginasRepository;
        }
        
    }
}