using Demo.BL.DataTransferObjects.Employee;

public interface IEmployeeService
{
    int Add(EmployeeRequest request);

    IEnumerable<EmployeeDetailResponse> GetAll(string? searchValue = null);
    EmployeeDetailResponse? GetById(int id);

    bool Delete(int id);
    int Update(EmployeeUpdateRequest request);
}
