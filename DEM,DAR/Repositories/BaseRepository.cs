using DEM_DAR.Context;
using DEM_DAR.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DEM_DAR.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly CompanyDbContext _context;
        private readonly DbSet<TEntity> _entities;

        public BaseRepository(CompanyDbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
          
        }

        public void Delete(TEntity entity)
        {
            entity.IsDeleted = true;
            _entities.Update(entity);
         
        }

        public IEnumerable<TEntity> GetAll(bool trackChanges = false)
            =>
            trackChanges
                ? _entities.Where(x => !x.IsDeleted).ToList()
                : _entities.AsNoTracking().Where(x => !x.IsDeleted).ToList();

        public TEntity? GetById(int id)
        {
            return _entities.Find(id);
        }

        public void Update(TEntity entity)
        {
            _entities.Update(entity);
        
        }
    }
}
