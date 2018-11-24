using ProjectDomain.Entities;
using ProjectDomain.Interfaces.Repositories;
using ProjectDomain.Interfaces.Services;
using ProjetoGerenciadorConteudo.Services;

namespace ProjectDomain.Services
{
    public class ImagemSubSegmentoService : Service<ImagemSubSeg>, IImagemSubSegmentoService
    {
        private readonly IImagemSubSegRepository _imagemSubSegmentoRepository;

        public ImagemSubSegmentoService(IImagemSubSegRepository imagemSubSegRepository) : base(imagemSubSegRepository)
        {
            _imagemSubSegmentoRepository = imagemSubSegRepository;
        }
    }
}
