using DEM_DAR.Models;
using Demo.BL.DataTransferObjects.Employee;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.Services
{
 
        public interface IEmployeeService
        {
          

        int Add(EmployeeRequest request);

        int Update(Employee employee);
            int Delete(Employee employee);
            IEnumerable<Employee> GetAll(bool trackChanges = false);
            Employee? GetById(int id);
        }

    }

