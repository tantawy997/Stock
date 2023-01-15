using AutoMapper;
using BL.DTOs.Product;
using DAL.repos.ProductRepo;
using Stock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ProductsManager;

public class ProductsManager : IProductsManager
{
    private readonly IMapper Mapper;
    private readonly IProductsRepo productRepo;

    public ProductsManager(IMapper _mapper,IProductsRepo _ProductRepo) 
    {
        Mapper = _mapper;
        productRepo = _ProductRepo;

    }

    public ProductsDTO AddProd(ProductAddDTOs Product)
    {
        var pr = Mapper.Map<Products>(Product);
        pr.Id = Guid.NewGuid();
        productRepo.AddEntity(pr);

        return Mapper.Map<ProductsDTO>(pr);
    }
    public ProductsDTO AddProduct(ProductAddDTOs product)
    {
       var ProductToAdd =  Mapper.Map<Products>(product);
        ProductToAdd.Id = Guid.NewGuid();
        productRepo.AddEntity(ProductToAdd);

        productRepo.saveChanges();

        return Mapper.Map<ProductsDTO>(ProductToAdd);


    }

    public void Delete(Guid id)
    {

        productRepo.DeleteById(id);

        productRepo.saveChanges();
    }

    public ProductsDTO? Get(Guid id)
    {
        var row = productRepo.getById(id);

        return Mapper.Map<ProductsDTO>(row);

    }

    public List<ProductsDTO> GetAll()
    {
        var AllProducts =  productRepo.GetAll();

        return Mapper.Map<List<ProductsDTO>>(AllProducts);
        
    }


    public bool update(ProductsDTO product)
    {
        var productbyID = productRepo.getById(product.id);

        if(productbyID != null)
        {
            Mapper.Map<ProductsDTO>(productbyID);
            productRepo.Update(productbyID);
            productRepo.saveChanges();

            return true;

        }

        else
        {
            return false;
        }
    }
}
