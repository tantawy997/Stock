using Stock.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repos.GenricRepo;

public class GenricRepo<TEntity> : IGenricRepo<TEntity> where TEntity : class
{
    private readonly AppdbContext context;

    public GenricRepo(AppdbContext _context)
    {
        context = _context;
    }


    public void AddEntity(TEntity entity)
    {
        context.Set<TEntity>().Add(entity);

    }

    public void Delete(TEntity entity)
    {
        
        context.Set<TEntity>().Remove(entity);

    }

    public void DeleteById(Guid id)
    {
        var row = context.Set<TEntity>().Find(id);

        if (row != null)
        {
            context.Set<TEntity>().Remove(row);
        }

    }

    public List<TEntity> GetAll()
    {
        return context.Set<TEntity>().ToList();
    }

    public TEntity? getById(Guid id)
    {
        return context.Set<TEntity>().Find(id);
    }

    public void saveChange()
    {
        context.SaveChanges();
    }

    public void Update(TEntity entity)
    {

    }

}
