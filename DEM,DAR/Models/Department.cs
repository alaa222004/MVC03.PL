using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM_DAR.Models
{
    public class Department : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public string Code { get; set; } = null!;

        public int Kind { get; set; }

        public int Createdby { get; set; }
        public string CreatedOn { get; set; }

        public string last { get; set; } 
        public bool IsDeleted { get; set; } = false;

        public DateTime LastModifae { get; set; }
    }
}
