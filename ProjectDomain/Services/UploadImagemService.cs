using ProjetoGerenciadorConteudo.Entities;
using ProjetoGerenciadorConteudo.Interfaces.Repositories;
using ProjetoGerenciadorConteudo.Interfaces.Services;

namespace ProjetoGerenciadorConteudo.Services
{
    public class UploadImagemService : Service<UploadImagem>, IUploadImagemService
    {
        private readonly IUploadImagemRepository _uploadImagemRepository;

        public UploadImagemService(IUploadImagemRepository uploadImagemRepository) : base(uploadImagemRepository)
        {
            _uploadImagemRepository = uploadImagemRepository;
        }
    }
}