using AutoMapper;
using MVCProject.ViewModels;
using ProjectDomain.Entities;

namespace MVCProject.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}