using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.Product
{
    public class AllProducts
    {
        public Guid id { get; set; }

        [Required]

        public string name { get; set; } = "";
        public string Photo { get; set; } = "";

        public string description { get; set; } = "";
        [Required]
        public Boolean type { get; set; } = false;

    }
}
