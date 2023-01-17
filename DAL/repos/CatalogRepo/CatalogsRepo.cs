using DAL.Models;
using DAL.repos.GenricRepo;
using Stock.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repos.CatalogRepo;

public class CatalogsRepo: GenricRepo<Catalog>, ICatalogsRepo
{
    private readonly AppdbContext context;

    public CatalogsRepo(AppdbContext _context) : base(_context)
    { 
        context = _context;
    }
}
