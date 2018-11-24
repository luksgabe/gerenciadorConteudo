using ProjectDomain.Entities;
using ProjectDomain.Interfaces.Repositories;
using ProjectDomain.Interfaces.Services;
using ProjetoGerenciadorConteudo.Services;

namespace ProjectDomain.Services
{
    public class ImagemDadoService : Service<ImagemDado>, IImagemDadoService
    {
        private readonly IImagemDadoRepository _imagemDadoRepository;

        public ImagemDadoService(IImagemDadoRepository imagemDadoRepository) : base(imagemDadoRepository)
        {
            _imagemDadoRepository = imagemDadoRepository;
        }

    }
}
