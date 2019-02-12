using AutoMapper;
using Domain.Entities;
using ModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
   
            public DomainToViewModelMappingProfile()
            {
                CreateMap<ClienteViewModel, Cliente>();
                CreateMap<ProdutoViewModel, Produto>();
            }
        
    }
}