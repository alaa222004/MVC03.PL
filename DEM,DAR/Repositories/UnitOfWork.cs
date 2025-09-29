using DEM_DAR.Context;
using DEM_DAR.Repositories;

namespace Demo.DAL.Repositories;
public class UnitOfWork(CompanyDbContext dBContext,
    IEmployeeRepository employee,
    IDepartmentRepository department)
    : IUnitOfWork
{
    public IEmployeeRepository Employees => employee;

    public IDepartmentRepository Departments => department;

    public int SaveChanges() => dBContext.SaveChanges();
}