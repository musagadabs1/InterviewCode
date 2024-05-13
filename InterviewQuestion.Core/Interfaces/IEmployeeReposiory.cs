using InterviewQuestion.Core.Models;

namespace InterviewQuestion.Core.Interfaces
{
    public interface IEmployeeReposiory
    {
        Task<Employee> AddEmployeeAsync(Employee employee);
        //Task<Employee> UpdateEmployeeAsync(Employee employee);
        //Task<Employee> DeleteEmployeeAsync(Guid employeeId);
        //Task<Employee> GetEmployeeByIdAsync(Guid employeeId);
        Task<List<Employee>> GetEmployeesAsync();
    }
}
