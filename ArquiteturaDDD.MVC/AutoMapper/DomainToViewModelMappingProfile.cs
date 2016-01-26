using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.MVC.ViewModels;
using AutoMapper;

namespace ArquiteturaDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}