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
        int Add(IEntity entity);
        int Update(IEntity entity);
        int Delete(IEntity entity);
    }
}
