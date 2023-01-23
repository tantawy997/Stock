using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.Product
{
    public class ImageDTO
    {
        //public Guid id { get; set; } 

        //public string image { get; set; } = "";

        public IFormFile file { get; set; }

    }
}
