using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM_DAR
{
    public class Department:BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string code { get; set; }
        public DateTimeKind Kind { get; set; }

    }
}
