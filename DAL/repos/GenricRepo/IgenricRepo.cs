using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repos.GenricRepo
{
    public interface IGenricRepo<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();

        TEntity? getById(Guid id);

        void AddEntity(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void DeleteById(Guid id);

        void saveChanges();

    }
}