using DEM_DAR;
using DEM_DAR.Models;
using System.Collections.Generic;

namespace Demo.BL.Services
{
    public interface IDepartmentService
    {
        int Create(Department request);
        int Update(Department department);
        int Delete(Department department);
        IEnumerable<Department> GetAll(bool trackChanges = false);
        Department? GetById(int id);
    }
}
