using AutoMapper;
using MVCProject.ViewModels;
using ProjectDomain.Entities;

namespace MVCProject.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UsuarioViewModel, Usuario>();
        }
    }
}