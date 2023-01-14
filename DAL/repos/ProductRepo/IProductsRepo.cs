using DAL.repos.GenricRepo;
using Stock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
namespace DAL.repos.ProductRepo
{
    public interface IProductsRepo : IGenricRepo<Products>
    {

    }
}