using Stock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL.DTOs.Product;

namespace BL.AutoMapperProfile;

public class AutoMapping : Profile
{
    public AutoMapping() 
    {
        CreateMap<Products, ProductsDTO>().PreserveReferences();
        CreateMap<ProductsDTO, Products>().PreserveReferences();

        CreateMap<ProductAddDTOs, Products>().PreserveReferences();
        CreateMap<Products, ProductsDTO>().PreserveReferences();

        CreateMap<Products, ProductAddDTOs>().PreserveReferences();

    }    
}
