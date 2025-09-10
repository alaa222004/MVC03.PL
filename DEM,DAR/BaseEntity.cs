using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM_DAR
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int Createdby{ get; set; }
        public string CreatedOn { get; set; }
        public string last { get; set; }
        public bool IsDeleted { get; set; }//soft delete
        public DateTime LastModifae
        {
            get; set;

        }
    }
}

