using DAL.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock.Models;

public class Products
{
    [Key]
    
    public Guid Id { get; set; }

    [Required]

    public string name { get; set; } = "";

    public string Photo { get; set; } = "";

    public string description { get; set; } = "";

    public Boolean type { get; set; } = false;

    [NotMapped]
    public IFormFile file { get; set; } 

    public ICollection<ProductDetails> ProductDetails { get; set; } = new HashSet<ProductDetails>();
    public  ICollection<Catalogs> Catalogs { get; set; } = new HashSet<Catalogs>();

}   
