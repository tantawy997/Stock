using BL.DTOs;
using BL.DTOs.Product;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Stock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BL.ProductsManager;

public interface IProductsManager
{
    List<AllProducts> GetAll();

    ProductsDTO? Get(Guid id);

    ProductsDTO AddProd(ProductAddDTOs product);

    bool update(ProductsDTO product);   

    void Delete(Guid id);

    ProductDetails GetProductDetails(Guid id);

    ProductsDTO AddProduct(ProductAddDTOs product);
}
