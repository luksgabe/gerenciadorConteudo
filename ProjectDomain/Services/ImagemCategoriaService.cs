using ProjectDomain.Entities;
using ProjectDomain.Interfaces.Repositories;
using ProjectDomain.Interfaces.Services;
using ProjetoGerenciadorConteudo.Services;

namespace ProjectDomain.Services
{
    public class ImagemCategoriaService : Service<ImagemCategoria>, IImagemCategoriaService
    {
        private readonly IImagemCategoriaRepository _imagemCategoriaRepository;

        public ImagemCategoriaService(IImagemCategoriaRepository imagemCategoriaRepository) : base(imagemCategoriaRepository)
        {
            _imagemCategoriaRepository = imagemCategoriaRepository;
        }
    }
}
