
using ProjectDomain.Entities;
using ProjectDomain.Interfaces.Repositories;
using ProjectDomain.Interfaces.Services;
using ProjetoGerenciadorConteudo.Services;

namespace ProjectDomain.Services
{
    public class SegmentoService : Service<Segmento>, ISegmentoService
    {

        private readonly ISegmentoRepository _segmentoRepository;

        public SegmentoService(ISegmentoRepository segmentoRepository) : base(segmentoRepository)
        {
            _segmentoRepository = segmentoRepository;
        }
    }
}
