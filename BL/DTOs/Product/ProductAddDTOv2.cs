using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.Product
{
    public class ProductAddDTOv2
    {
        public string FileName { get; set; } = "";
        public string FileType { get; set; } = "";
        public string FileAsBase64 { get; set; } = "";
        public byte[]? FileAsByteArray { get; set; } 

        public string name { get; set; } = "";

        public string photo { get; set; } = "";

        public string description { get; set; } = "";
        public Boolean type { get; set; } = false;

    }
}
