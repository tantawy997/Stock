using DAL.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock.Models;

public class Products
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    
    public string name { get; set; } = "";

    public string photo { get; set; } = "";

    public string description { get; set; } = "";
    [Required]
    public string type { get; set; } = "out of stock";

    //[InverseProperty("Products")]

    public  ICollection<ProductDetails> ProductDetails { get; set; } = new HashSet<ProductDetails>();
    public  ICollection<Catalog> Catalogs { get; set; } = new HashSet<Catalog>();

}   
