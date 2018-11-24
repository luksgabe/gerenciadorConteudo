using ProjetoGerenciadorConteudo.Entities;
using ProjetoGerenciadorConteudo.Interfaces.Repositories;
using ProjetoGerenciadorConteudo.Interfaces.Services;

namespace ProjetoGerenciadorConteudo.Services
{
    public class PaginaService : Service<Pagina>, IPaginaService
    {
        private readonly IPaginaRepository _paginaRepository;

        public PaginaService(IPaginaRepository paginaRepository) : base(paginaRepository)
        {
            _paginaRepository = paginaRepository;
        }
    }
}