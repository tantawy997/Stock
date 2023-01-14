using DAL.repos.GenricRepo;
using Stock.Context;
using Stock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repos.ProductRepo
{

    public class ProductsRepo : GenricRepo<Products>, IProductsRepo
    {
        private readonly AppdbContext context;

        public ProductsRepo(AppdbContext _context) : base(_context)
        {
            context = _context;
        }
    }
}