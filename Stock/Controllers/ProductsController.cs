using BL.DTOs.Product;
using BL.ProductsManager;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock.Models;

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
        public ActionResult<IEnumerable<ProductsDTO>> GetAllProducts()
        {
            return Ok(Context.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<ProductsDTO> GetProduct(Guid id) 
        {
            var row = Context.Get(id);
            if (row == null)
            {
                return NotFound();
            }

            return Ok(row);
        }

        //[HttpPost]
        //public ActionResult<Products> AddProduct(ProductAddDTOs product)
        //{
        //    var row = Context.AddProduct(product);
            
        //    return Ok(row);

        //}

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

            return Ok();
        }

        [HttpPost]
        public ActionResult<ProductsDTO> AddProductTwo(ProductAddDTOs products)
        {
            var row = Context.AddProduct(products);

            return Ok(new {id = row.id,name = row.name, photo = row.photo,
                description = row.description, type = row.type});
        }
    }
}
