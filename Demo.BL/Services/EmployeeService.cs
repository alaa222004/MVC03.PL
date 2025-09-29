using AutoMapper;
using DEM_DAR.Models;
using DEM_DAR.Repositories;
using Demo.BL.DataTransferObjects.Employee;
using System.Buffers;
using System.Collections.Generic;

namespace Demo.BL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public int Add(EmployeeRequest request)
        {
            var employee = _mapper.Map<Employee>(request);
            return _repository.Add(employee);
        }

        public int Update(EmployeeUpdateRequest request)
        {
            var employee = _mapper.Map<Employee>(request);
            return _repository.Update(employee);
        }

        public IEnumerable<EmployeeDetailResponse> GetAll(string? searchValue = null)
        {
            var employees = _repository.GetAll();

            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                employees = employees.Where(e =>
                    e.Name.Contains(searchValue, StringComparison.OrdinalIgnoreCase));
            }

            return _mapper.Map<IEnumerable<EmployeeDetailResponse>>(employees);
        }

        public EmployeeDetailResponse? GetById(int id)
        {
            var employee = _repository.GetById(id);
            return employee == null ? null : _mapper.Map<EmployeeDetailResponse>(employee);
        }

        public bool Delete(int id)
        {
            var employee = _repository.GetById(id);
            if (employee == null)
                return false;

            var result = _repository.Delete(employee);
            return result > 0;
        }

        public IEnumerable<EmployeeDetailResponse> GetAll() {

            var employees = _repository.GetAll();
            return _mapper.Map<IEnumerable<EmployeeDetailResponse>>(employees);
        }
    }
}
