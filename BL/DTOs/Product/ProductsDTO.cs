using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.Product
{
    public class ProductsDTO
    {
        public Guid id { get; set; } 
        public string name { get; set; } = "";

        public string photo { get; set; } = "";

        public string description { get; set; } = "";
        [Required]
        public string type { get; set; } = "out of stock";

        public virtual ICollection<ProductDetails> ProductDetails { get; set; } = new HashSet<ProductDetails>();
       
        public virtual ICollection<Catalog> Catalogs { get; set; } = new HashSet<Catalog>();



    }
}
