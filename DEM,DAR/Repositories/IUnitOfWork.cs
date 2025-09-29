using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM_DAR.Repositories
{
 public interface IUnitOfWork
    {
        IEmployeeRepository Employees { get; }
        IDepartmentRepository Departments { get; }
        int SaveChanges();
    }
}
