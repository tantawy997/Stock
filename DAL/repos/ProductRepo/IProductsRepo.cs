using DAL.Models;
using DAL.repos.GenricRepo;
using Microsoft.AspNetCore.Http;
using Stock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
namespace DAL.repos.ProductRepo;

public interface IProductsRepo : IGenricRepo<Products>
{
    public List<Products> getproductswithcatalogs();

    public void addDetails(ProductDetails product);

    public ProductDetails? GetProductDetails(Guid id);

    public string UploadPhoto(IFormFile file);

}