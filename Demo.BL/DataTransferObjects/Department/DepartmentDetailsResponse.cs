using System;

namespace Demo.BL.DataTransferObjects.Employee
{
    public class DepartmentDetailsResponse
    {
        public int Id { get; set; }

        // General tab fields
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public int Age { get; set; }
        public DateTime HiringDate { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; } = null!;
        public string EmployeeType { get; set; } = null!;
        public bool IsActive { get; set; }

        // Administration tab fields
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }

        // Optional system fields
        public bool IsDeleted { get; set; }
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CreationDate { get; set; }

        public string? ToUpdateRequest()
        {
            throw new NotImplementedException();
        }
    }
}
