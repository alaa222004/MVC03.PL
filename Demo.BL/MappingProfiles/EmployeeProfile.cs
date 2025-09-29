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
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
        CreateMap<EmployeeRequest,Employee>();
             CreateMap<EmployeeUpdateRequest, Employee>();

             CreateMap< Employee,EmployeeDetailResponse>().ForMember(d=>d.Department,o=>o.MapFrom(s=>s.Department.Name));
            CreateMap<EmployeeDetailResponse, EmployeeUpdateRequest>();

                CreateMap<Employee, EmployeeResponse>().ForMember(d => d.Department, o => o.MapFrom(s => s.Department.Name));

            CreateMap<EmployeeUpdateRequest, EmployeeRequest>();
        }
}
}