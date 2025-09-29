using DEM_DAR.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM_DAR.Models
{
    public class Employee:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int Salary { get; set; }
        public string Adress { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public Gender? Gender { get; set; }
        public EmployeeType?employeeType { get; set; }
        public Department Department { get; set; }


    }
}
