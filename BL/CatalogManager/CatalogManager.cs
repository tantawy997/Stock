using AutoMapper;
using BL.DTOs.Catalog;
using DAL.Models;
using DAL.repos.CatalogRepo;
using Stock.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CatalogManager
{
    public class CatalogManager : ICatalogManager
    {
        private readonly CatalogRepo catalogRepo;
        private readonly Mapper mapper;

        public CatalogManager(CatalogRepo _catalogRepo, Mapper _mapper) 
        {
            catalogRepo = _catalogRepo;
            mapper = _mapper;
        }
        public void DeleteByID(Guid id)
        {
            //var row = catalogRepo.getById(id);


            catalogRepo.DeleteById(id);
        }

        public List<CatalogDTO> GetAllCatalog()
        {


            var model = catalogRepo.GetAll();
           //return mapper.Map<List<CatalogAddDTOs>, List<Catalog>>(model);
           return mapper.Map<List<CatalogDTO>>(model);


        }

        public CatalogDTO GetCatalog(Guid id)
        {

            var row = catalogRepo.getById(id);
            return mapper.Map<CatalogDTO>(row);

            //return mapper.Map<Catalog, CatalogDTO>(row);
            //return mapper.Map<CatalogDTO, Catalog>();

        }

        public bool UpdateCatalog(CatalogDTO catalog)
        {
            var model = catalogRepo.getById(catalog.Id);

            if (model == null)
            {
                return false;
            }
            var mapped = mapper.Map<CatalogDTO, Catalog>(catalog);
            catalogRepo.Update(mapped);
            catalogRepo.saveChange();
            return true;

        }

        public CatalogDTO AddCatalog(CatalogAddDTOs catalog)
        {
            var row = mapper.Map<Catalog>(catalog);
            catalogRepo.AddEntity(row);
            catalogRepo.saveChange();
            return mapper.Map<CatalogDTO>(row);
        }
    }
}
