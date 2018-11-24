using ProjectDomain.Entities;
using ProjectDomain.Interfaces.Repositories;
using ProjectDomain.Interfaces.Services;
using ProjetoGerenciadorConteudo.Services;

namespace ProjectDomain.Services
{
    public class SubSegmentoService : Service<SubSegmento>, ISubSegmentoService
    {
        private readonly ISubSegmentoRepository _subSegmentoRepository;

        public SubSegmentoService(ISubSegmentoRepository subSegmentoRepository) : base(subSegmentoRepository)
        {
            _subSegmentoRepository = subSegmentoRepository;
        }

    }
}
