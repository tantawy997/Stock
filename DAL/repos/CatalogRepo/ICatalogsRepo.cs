using DAL.Models;
using DAL.repos.GenricRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repos.CatalogRepo;

public interface ICatalogsRepo : IGenricRepo<Catalog>
{
}
