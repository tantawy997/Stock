using BL.DTOs.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CatalogManager
{
    internal interface ICatalogManager 
    {
        List<CatalogDTO> GetAllCatalog(CatalogDTO catalog);

        CatalogDTO GetCatalog(Guid id);

        void DeleteByID(Guid id);

        void UpdateCatalog(CatalogDTO catalog);

        CatalogDTO AddCatalog(CatalogAddDTOs catalog);

    }
}
