using BL.DTOs;
using BL.DTOs.Product;
using BL.ProductsManager;
using DAL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock.Models;
using System.Diagnostics;

namespace Stock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductsController : ControllerBase
    {
        private readonly IProductsManager Context;

        public ProductsController(IProductsManager _context)
        {
            Context = _context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AllProducts>> GetAllProducts()
        {
            var all = Context.GetAll();

            return Ok(all);
        }

        [HttpGet("{id}")]
        public ActionResult<Products> GetProduct(Guid product)
        {
            var rowId = Context.Get(product);
            if (rowId == null)
            {
                return NotFound();
            }

            //var row = Context.GetProductDetails(product);

            return Ok(new
            {
                id = rowId.id,
                name = rowId.name,
                photo = rowId.Photo,
                description = rowId.description,
                type = rowId.type
            });


        }


        [HttpPut("{id}")]
        public ActionResult<ProductsDTO> UpdateProduct(ProductsDTO product)
        {

            return Ok(Context.update(product));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(Guid id)
        {
            var RowID = Context.Get(id);

            if (RowID == null)
            {
                return NotFound();
            }
            Context.Delete(id);

            return Ok(RowID);
        }

        [HttpPost]
        public ActionResult<ProductsDTO> AddProduct([FromForm] ProductAddDTOs products)
        {
            
            if (products == null)
            {
                return Content("Invalid info");
            }

            var row = Context.AddProd(products);


            return Ok(new { id = row.id, name = row.name,photo = row.Photo, 
                description = row.description, type = row.type });
        }

        [HttpPost("Add")]
        public ActionResult<ProductsDTO> CreateProduct([FromForm] ProductAddDTOs product)
        {
            if (product != null)
            {

                var row = Context.AddProduct(product);


                return Ok(row);
            }
            else
            {
                return Content("model is null");
            }


        }
        [HttpPost("addv2")]
        public ActionResult<ProductsDTO> CreateProductv2([FromForm] ProductAddDTOv2 product)
        {
            if (product != null)
            {

                var row = Context.AddProductv2(product);


                return Ok(row);
            }
            else
            {
                return Content("model is null");
            }
        }
    }
}
