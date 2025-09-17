using AutoMapper;
using DEM_DAR.Models;
using Demo.BL.DataTransferObjects.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.MappingProfiles
{
    internal class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
        CreateMap<EmployeeRequest,Employee>();
             CreateMap<EmployeeUpdateRequest, Employee>();

             CreateMap< Employee,EmployeeDetailResponse>();

                CreateMap<Employee, EmployeeResponse>();
    }
}
}