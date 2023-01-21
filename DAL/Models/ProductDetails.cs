using Stock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductDetails
    {

        public Guid Id { get; set; }

        [MaxLength(50)]
        public string DefualtStock { get; set; } = "";

        
        public float SalesPrice { get; set; } 

        public float PurchasePrice { get; set; }

        public Products Products { get; set; } = new Products();
    }
}
