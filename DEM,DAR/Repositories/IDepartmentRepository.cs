using DEM_DAR.Models;
using Demo.DAL.Entities;
using System.Collections.Generic;

namespace DEM_DAR.Repositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll(bool trackChanges = false);
        Department? GetById(int id);
        int Add(Department department);
        int Update(Department department);
        int Delete(Department department);
   
    }
}
