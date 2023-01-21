using BL.DTOs.Catalog;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.Product;

public class ProductsDTO
{
    public Guid id { get; set; }

    [Required]

    public string name { get; set; } = "";
    public string Photo { get; set; } = "";

    public string description { get; set; } = "";
    [Required]
    public Boolean type { get; set; } = false;

    public IFormFile file { get; set; } 

    //public ICollection<ProductDetails> ProductDetails { get; set; } = new HashSet<ProductDetails>();
    //public ICollection<Catalogs> Catalogs { get; set; } = new HashSet<Catalogs>();

}
