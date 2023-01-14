using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs
{
    public class ProductDetailsDTO
    {
        public int Id { get; set; }

        public string DefualtStock { get; set; } = "";

        public float SalesPrice { get; set; }

        public float PurchasePrice { get; set; }

        public Guid ProductId { get; set;}

    }
}
