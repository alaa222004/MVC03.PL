using DEM_DAR.Context;
using DEM_DAR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM_DAR.Repositories
{
    public class DepartmentRepository: IDepartmentRepository
    {
        private readonly CompanyDbContext _context;
        private readonly DbSet<Department> _departments;

        public DepartmentRepository(CompanyDbContext context)
        {
            _context = context;
            _departments = context.Departments;
        }

        public int Add(Department department)
        {
            _departments.Add(department);
            return _context.SaveChanges();
        }

        public int Delete(Department department)
        {
            department.IsDeleted = true;
            _departments.Update(department);
            return _context.SaveChanges();
        }


        public IEnumerable<Department> GetAll(bool trackChanges = false)
            =>
            trackChanges
                ? _departments.Where(x => !x.IsDeleted).ToList()
                : _departments.AsNoTracking().Where(x => !x.IsDeleted).ToList();

        public Department? GetById(int id)
        {
            return _departments.Find(id);
        }

        public int Update(Department department)
        {
            _departments.Update(department);
            return _context.SaveChanges();
        }
    }
}
