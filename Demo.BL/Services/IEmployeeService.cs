using Demo.BL.DataTransferObjects.Employee;

public interface IEmployeeService
{
    int Add(EmployeeRequest request);

    IEnumerable<EmployeeDetailResponse> GetAll(string? searchValue = null);

    IEnumerable<EmployeeDetailResponse> GetAll();
    EmployeeDetailResponse? GetById(int id);

    bool Delete(int id);
    int Update(EmployeeUpdateRequest request);
}
