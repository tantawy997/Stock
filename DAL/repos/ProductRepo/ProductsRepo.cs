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
            //Products pr = new Products();

            // getting file original name
            string photo = file.FileName;

            // combining GUID to create unique name before saving in wwwroot
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + photo;
             

            // getting full path inside wwwroot/images
            var imagePath = Path.Combine(@"./wwwroot/images/", uniqueFileName);

            // copying file

            file.CopyTo(new FileStream(imagePath, FileMode.Create));

            return $"/images/{uniqueFileName}";
        }

        catch (Exception ex)
        {
            return ex.Message;
        }

        
    }
    public string GetPhoto(IFormFile file)
    {
        try
        {
            //Products pr = new Products();

            // getting file original name
            var Photo = file.FileName;

            // combining GUID to create unique name before saving in wwwroot
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.Trim();
            string photoToView = $"/images/{uniqueFileName}";
            // getting full path inside wwwroot/images
            var imagePath = Path.Combine(@"wwwroot/images/", uniqueFileName).Trim();

            // copying file
            file.CopyTo(new FileStream(imagePath, FileMode.Open));

            return photoToView;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
     

}