using DEM_DAR;
using DEM_DAR.Models;
using Demo.BL.DataTransferObjects.Department;
using Demo.BL.DataTransferObjects.Employee;

namespace Demo.BLL.DataTransferObjects;
internal static class DepartmentFactory
{
    public static DepartmentResponse ToResponse(this Department department) => new()
    {
        Id = department.Id,
        Name = department.Name,
        Description = department.Description,
        //CreatedAt = department.CreatedOn,
        Code = department.Code,
        
    };
    public static DepartmentDetailsResponse ToDetailsResponse(this Department department) => new()
    {
        Id = department.Id,
        Name = department.Name,
        Description = department.Description,
        //Createdby = 1,
        //CreatedOn=department.CreatedOn,
        IsDeleted = department.IsDeleted,
        Code = department.Code,
        //LastModifiedBy = department.LastModifae,
        //LastModifiedOn = department.Last,
        //CreatedAt = department.CreatedAt,
    };
    public static Department ToEntity(this DepartmentRequest departmentRequest) => new()
    {
        Name = departmentRequest.Name,
        Description = departmentRequest.Description,
        Code = departmentRequest.Code,
        //CreatedAt = departmentRequest.CreatedAt,
        Createdby = 1,
        Kind = 1,
        CreatedOn = "2023-10-10",
        last = "2023-10-10",
        //Last = DateTime.Now,
    };
    public static Department ToEntity(this DepartmentUpdateRequest departmentRequest) => new()
    {
        Id = departmentRequest.Id,
        Name = departmentRequest.Name,
        Description = departmentRequest.Description,
        Code = departmentRequest.Code,
        //CreatedAt = departmentRequest.CreatedAt
    };
    public static DepartmentUpdateRequest ToUpdateRequest(this DepartmentDetailsResponse departmentRequest) => new()
    {
        Id = departmentRequest.Id,
        Name = departmentRequest.Name,
        Description = departmentRequest.Description,
        Code = departmentRequest.Code,
        CreatedAt = departmentRequest.CreatedAt,
    };
    public static DepartmentRequest ToRequest(this DepartmentUpdateRequest departmentRequest) => new()
    {
        Name = departmentRequest.Name,
        Description = departmentRequest.Description,
        Code = departmentRequest.Code
    };
    
}
