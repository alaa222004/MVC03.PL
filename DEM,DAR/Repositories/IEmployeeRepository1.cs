using DEM_DAR.Models;

namespace DEM_DAR.Repositories
{
    public interface IEmployeeRepository1
    {
        int Add(Employee employee);
        int Delete(Employee employee);
        IEnumerable<Employee> GetAll(bool trackChanges = false);
        Employee? GetById(int id);
        int Update(Employee employee);
    }
}