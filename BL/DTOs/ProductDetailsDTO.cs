using BL.DTOs.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs;

public class ProductDetailsDTO
{
    public Guid Id { get; set; }

    public string DefualtStock { get; set; } = "";

    public float SalesPrice { get; set; }

    public float PurchasePrice { get; set; }

    public ProductsDTO Products { get; set; } = new ProductsDTO();


    //public string name { get; set; } = "";

    //public string photo { get; set; } = "";

    //public string description { get; set; } = "";
    //[Required]
    //public string type { get; set; } = "out of stock";

}
