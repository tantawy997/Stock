using BL.CatalogManager;
using BL.DTOs.Catalog;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Stock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogsManager catalogManager;

        public CatalogController(ICatalogsManager _catalogManager)
        {
            catalogManager = _catalogManager;
        }

        [HttpGet]
        public ActionResult<List<CatalogDTO>> GetCatalogs()
        {
            return Ok(catalogManager.GetAllCatalog());
        }

        [HttpGet("{id}")]
        public ActionResult<CatalogDTO> GetCatalogByID(Guid id) 
        {
            var row = catalogManager.GetCatalog(id); 
            if (row == null)
            {
                return NotFound();
            }

            return Ok(row);
        }

        [HttpDelete] 
        public IActionResult DeleteCatalog(Guid id)
        {
            var row = catalogManager.GetCatalog(id);
            if (row == null) 
            { 
                return NotFound();
            }

            
            return Ok(row);
        }

        [HttpPost]
        public ActionResult<CatalogDTO> AddCatalog(CatalogAddDTOs catalog)
        {
            var row= catalogManager.AddCatalog(catalog);
            return Ok(row);

        }

        [HttpPut]
        public ActionResult<CatalogDTO> UpdateCatalog(CatalogDTO catalog)
        {
            var row = catalogManager.UpdateCatalog(catalog);

            return Ok(row);
        }

    }
}
