using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.DataTransferObjects.Employee
{
    public class EmployeeUpdateRequest
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Max length should be 50 character")]
        [MinLength(5, ErrorMessage = "Min length should be 5 characters")]
        public string Name { get; set; } = null!;

        [Range(22, 32)]
        public int Age { get; set; }

        [RegularExpression(@"^\d{1,3}\s([a-zA-Z]{5,10}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}$",
            ErrorMessage = "Address must be like 123-Street-City-Country")]
        public string Address { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        [EmailAddress]
        [Display(Name = "Phone Number")]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public DateOnly HiringDate { get; set; }
        public DateOnly FiringDate { get; set; }
        public byte Gender { get; set; }
        public byte EmployeeType { get; set; }
    }
}
