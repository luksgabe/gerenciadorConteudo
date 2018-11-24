using ProjetoGerenciadorConteudo.Entities;
using ProjetoGerenciadorConteudo.Interfaces.Repositories;
using ProjetoGerenciadorConteudo.Interfaces.Services;

namespace ProjetoGerenciadorConteudo.Services
{
    public class DadoService : Service<Dado>, IDadoService
    {
        private readonly IDadoRepository _dadoRepository;

        public DadoService(IDadoRepository dadoRepository) : base(dadoRepository) 
        {
            _dadoRepository = dadoRepository;
        }


    }
}