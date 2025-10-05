using DEM_DAR.Models;
using System.Collections.Generic;

namespace DEM_DAR.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll(bool trackChanges = false);
        Employee? GetById(int id);   // ✅ لازم يرجع Employee مش int
        int Add(Employee employee);
        int Update(Employee employee);
        int Delete(Employee employee);  // ✅ تسيبها كده لو هتستقبل object
        int Delete(int id);             // ✅ أو كده لو هتمسح بالـId
    }
}
