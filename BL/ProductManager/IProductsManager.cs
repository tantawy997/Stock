using BL.DTOs.Product;
using Stock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BL.ProductsManager;

public interface IProductsManager
{
    List<ProductsDTO> GetAll();

    ProductsDTO? Get(Guid id);

    ProductsDTO AddProduct(ProductAddDTOs product);

    ProductsDTO AddProd(ProductAddDTOs product);

    bool update(ProductsDTO product);   

    void Delete(Guid id);


}
