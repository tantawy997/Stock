using AutoMapper;
using BL.DTOs;
using BL.DTOs.Product;
using DAL.Models;
using DAL.repos.ProductRepo;
using Microsoft.AspNetCore.Http;
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
        //pr.Photos.

        productRepo.AddEntity(pr);
        productRepo.saveChange();
        return Mapper.Map<ProductsDTO>(pr);

    }

    public void Delete(Guid id)
    {

        productRepo.DeleteById(id);

        productRepo.saveChange();
    }

    public ProductsDTO? Get(Guid id)
    {
        var row = productRepo.getById(id);

        return Mapper.Map<ProductsDTO>(row);

    }

    public List<AllProducts> GetAll()
    {
        var AllProducts =  productRepo.GetAll();

        return Mapper.Map<List<AllProducts>>(AllProducts);
        
    }


    public bool update(ProductsDTO product)
    {
        var productbyID = productRepo.getById(product.id);

        if(productbyID == null)
        {
            return false;

        }

        //Mapper.Map<ProductsDTO>(productbyID);

        var prdToUpdate = Mapper.Map<ProductsDTO,Products>(product);
        productRepo.Update(productbyID);
        //productRepo.Update(prdToUpdate);

        productRepo.saveChange();

        return true;
    }

    public ProductDetails GetProductDetails(Guid id)
    {
        //var prod = Mapper.Map<Products>(product);

        var product = productRepo.GetProductDetails(id);
        return Mapper.Map<ProductDetails>(product);

        
    }

    public ProductsDTO AddProduct(ProductAddDTOs product)
    {
        var file = product.file;
        var pr = Mapper.Map<Products>(product);

        pr.Id = Guid.NewGuid();
        productRepo.UploadPhoto(file);

        productRepo.AddEntity(pr);
        productRepo.saveChange();
        return Mapper.Map<ProductsDTO>(pr);
    }

}
