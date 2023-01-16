using Stock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL.DTOs.Product;
using DAL.Models;
using BL.DTOs.Catalog;

namespace BL.AutoMapperProfile;

public class AutoMapping : Profile
{
    public AutoMapping() 
    {
        CreateMap<Products, ProductsDTO>().ReverseMap();
        //CreateMap<ProductsDTO, Products>();

        CreateMap<ProductAddDTOs, Products>().ReverseMap();

        CreateMap<Products, ProductsDTO>().ReverseMap();

        CreateMap<Catalog, CatalogDTO>().ReverseMap();
    }    
}
