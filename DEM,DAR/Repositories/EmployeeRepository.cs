using DEM_DAR.Context;
using DEM_DAR.Models;


namespace DEM_DAR.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly CompanyDbContext _context;
        private readonly DbSet<Employee> _employees;

        public EmployeeRepository(CompanyDbContext context)
        {
            _context = context;
            _employees = context.Employees;
        }

        public int Add(Employee employee)
        {
            _employees.Add(employee);
            return _context.SaveChanges();
        }

        public int Delete(Employee employee)
        {
            employee.IsDeleted = true;
            _employees.Update(employee);
            return _context.SaveChanges();
        }

        // ✅ Delete by Id
        public int Delete(int id)
        {
            var employee = _employees.Find(id);
            if (employee == null) return 0;

            employee.IsDeleted = true;
            _employees.Update(employee);
            return _context.SaveChanges();
        }

        public IEnumerable<Employee> GetAll(bool trackChanges = false)
            => trackChanges
                ? _employees.Where(x => !x.IsDeleted).ToList()
                : _employees.AsNoTracking().Where(x => !x.IsDeleted).ToList();

 
        public Employee? GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id && !e.IsDeleted);
        }

        public int Update(Employee employee)
        {
            _employees.Update(employee);
            return _context.SaveChanges();
        }

        Employee? IEmployeeRepository.GetById(int id)
        {
            return GetById(id);
        }
    }
}
