using DAL.Models;
using DAL.repos.GenricRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Stock.Context;
using Stock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repos.ProductRepo;


public class ProductsRepo : GenricRepo<Products>, IProductsRepo
{
    private readonly AppdbContext context;

    public ProductsRepo(AppdbContext _context) : base(_context)
    {
        context = _context;
    }

    public List<Products> getproductswithcatalogs()
    {
        return context.Products.Include(a => a.Catalogs).ToList();
    }



    public void addDetails(ProductDetails details)
    {
        context.ProductDetails.Include(a => a.Products).ToList().Add(details);

    }

    public ProductDetails? GetProductDetails(Guid id)
    {
        return context.ProductDetails.FirstOrDefault(p => p.Id == id);
    }


    public string UploadPhoto(IFormFile file)
    {
        try
        {
            Products p = new Products();

            // getting file original name
            p.Photo = file.FileName;

            // combining GUID to create unique name before saving in wwwroot
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + p.Photo;

            // getting full path inside wwwroot/images
            var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", p.Photo);

            // copying file
            file.CopyTo(new FileStream(imagePath, FileMode.Create));

            return "File Uploaded Successfully";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
}