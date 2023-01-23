using DAL.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.Product;

public class ProductAddDTOs
{
    public string name { get; set; } = "";

    public string photo { get; set; } = "";

    public string description { get; set; } = "";
    public Boolean type { get; set; } = false;

    public IFormFile file { get; set; } 


    //public ICollection<ProductDetails> ProductDetails { get; set; } = new HashSet<ProductDetails>();
    //public ICollection<Catalogs> Catalogs { get; set; } = new HashSet<Catalogs>();


}
