using StoreOfBuild.Data.Context;
using StoreOfBuild.Domain;
using System.Collections.Generic;
using System.Linq;

namespace StoreOfBuild.Data
{
  public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
  {
    protected readonly ApplicationDbContext _context;
    public Repository(ApplicationDbContext context)
    {
      _context = context;
    }
    public virtual TEntity GetById(int id)
    {
      var query = _context.Set<TEntity>().Where(e => e.Id == id);
      if(query.Any())
        return query.First();
      return null;
    }
    public virtual IEnumerable<TEntity> All()
    {
      return _context.Set<TEntity>().AsEnumerable();
    }
    public void Save(TEntity entity)
    {
      _context.Set<TEntity>().Add(entity);
    }

    public void Delete(int id)
    {
      var _entity = _context.Set<TEntity>().SingleOrDefault(e => e.Id == id);
      _context.Set<TEntity>().Remove(_entity);
    }
  }
}