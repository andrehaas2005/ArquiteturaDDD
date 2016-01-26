using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.MVC.ViewModels;
using AutoMapper;

namespace ArquiteturaDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
        }
    }
}