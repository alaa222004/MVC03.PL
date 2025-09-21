using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.DataTransferObjects.Department
{

    public class DepartmentResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
       public int Age {  get; set; }
        public string? Description { get; set; }
        public string Code { get; set; } = String.Empty;
        public DateOnly CreatedAt { get; set; }
    }
}
