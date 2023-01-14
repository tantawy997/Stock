using BL.DTOs.Product;
using BL.ProductsManager;
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

        [HttpPost]
        public ActionResult<Products> AddProduct(ProductAddDTOs product)
        {
            var row = Context.AddProduct(product);
            
            return CreatedAtAction("GetProduct", new {id = row.id}, row);

        }

        [HttpPut("{id}")]
        public ActionResult<ProductsDTO> UpdateProduct(ProductsDTO product) 
        {
            
            return Ok(Context.update(product));
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(ProductsDTO product)
        {
            var Row = Context.Get(product.id);

            if (Row == null)
            {
                return NotFound();
            }
             Context.Delete(product.id);

            return Ok();
        }
    }
}
