using DEM_DAR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM_DAR.Repositories
{
  public interface IRepository<IEntity> where IEntity : BaseEntity
    {
        IEnumerable<IEntity> GetAll(bool trackChanges = false);
        IEntity? GetById(int id);
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}
