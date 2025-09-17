using DEM_DAR;
using DEM_DAR.Models;
using DEM_DAR.Repositories;
using System.Collections.Generic;

namespace Demo.BL.Services
{
    public class DepartmentsService : IDepartmentService
    {
        private readonly IRepository<Department> _repository;

        public DepartmentsService(IRepository<Department> repository)
        {
            _repository = repository;
        }

        public int Create(Department request)
        {
            return _repository.Add(request);
        }

        public int Update(Department department)
        {
            return _repository.Update(department);
        }

        public int Delete(Department department)
        {
            return _repository.Delete(department);
        }

        public IEnumerable<Department> GetAll(bool trackChanges = false)
        {
            return _repository.GetAll(trackChanges);
        }

        public Department? GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
