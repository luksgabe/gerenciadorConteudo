using ProjectDomain.Entities;
using ProjectDomain.Interfaces.Repositories;
using ProjectDomain.Interfaces.Services;
using ProjetoGerenciadorConteudo.Services;

namespace ProjectDomain.Services
{
    public class ImagemSegmentoService : Service<ImagemSegmento>, IImagemSegmentoService
    {
        private readonly IImagemSegmentoRepository _imagemSegmentoRepository;

        public ImagemSegmentoService(IImagemSegmentoRepository imagemSegmentoRepository) : base(imagemSegmentoRepository)
        {
            _imagemSegmentoRepository = imagemSegmentoRepository;
        }

    }
}
