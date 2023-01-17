using BL.DTOs.Catalog;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CatalogManager;

public interface ICatalogsManager 
{
    List<CatalogDTO> GetAllCatalog();

    CatalogDTO GetCatalog(Guid id);

    void DeleteByID(Guid id);

    bool UpdateCatalog(CatalogDTO catalog);

    CatalogDTO AddCatalog(CatalogAddDTOs catalog);

}
