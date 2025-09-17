using AutoMapper;
using DEM_DAR;
using DEM_DAR.Models;
using DEM_DAR.Repositories;
using Demo.BL.DataTransferObjects.Employee;
using System.Collections.Generic;

namespace Demo.BL.Services
{
    public class EmployeeService(IRepository<Employee> repository, IMapper mapper) 
        : IEmployeeService
    {
        private readonly IRepository<Employee> _repository;



        public int Add(EmployeeRequest request)
        {
            var employee = mapper.Map<Employee>(request);
            return _repository.Add(employee);
        }


        public int Update(Employee employee)
        {
            return _repository.Update(employee);
        }

        public int Delete(Employee employee)
        {
            return _repository.Delete(employee);
        }

        public IEnumerable<Employee> GetAll(bool trackChanges = false)
        {
            return _repository.GetAll(trackChanges);
        }

        public Employee? GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
