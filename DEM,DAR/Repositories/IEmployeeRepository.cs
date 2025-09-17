using DEM_DAR.Models;
using System.Collections.Generic;

namespace DEM_DAR.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll(bool trackChanges = false);
        Employee? GetById(int id);
        int Add(Employee employee);
        int Update(Employee employee);
        int Delete(Employee employee);
    }
}
