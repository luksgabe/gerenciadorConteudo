using ProjetoGerenciadorConteudo.Entities;
using ProjetoGerenciadorConteudo.Interfaces.Repositories;
using ProjetoGerenciadorConteudo.Interfaces.Services;

namespace ProjetoGerenciadorConteudo.Services
{
    public class PaginaControleService : Service<PaginaControle>, IPaginaControleService
    {
        private readonly IPaginaControleRepository _paginaControleRepository;

        public PaginaControleService(IPaginaControleRepository paginaControleRepository) : base(paginaControleRepository)
        {
            _paginaControleRepository = paginaControleRepository;
        }
    }
}