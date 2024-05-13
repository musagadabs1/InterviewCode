using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using InterviewQuestion.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace InterviewQuestion.FormManagement.Repositories
{
    public class EmployeeReposiory(EmployeeDbContext dbContext) : IEmployeeReposiory
    {
        private EmployeeDbContext _dbContext = dbContext;

        public async Task<Employee> AddEmployeeAsync(Employee model)
        {
            try
            {
                //model.CreatedOn = DateTime.Now;
                //model.UpdatedOn = DateTime.Now;
                //model.EmployeeId = Guid.NewGuid();
                var result = _dbContext.Employees.Add(model);
                await _dbContext.SaveChangesAsync();

                return model;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public async Task<Employee> DeleteEmployeeAsync(Guid employeeId)
        //{
        //    try
        //    {
        //        var result = await GetEmployeeByIdAsync(employeeId);
        //        if (result != null)
        //        {
        //            _dbContext.Employees.Remove(result);
        //            await _dbContext.SaveChangesAsync();
        //            return result;
        //        }
        //        return result;

        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public async Task<Employee> GetEmployeeByIdAsync(Guid employeeId)
        //{
        //    try
        //    {
        //        var result = await _dbContext.Employees.FirstOrDefaultAsync(x => x.EmployeeId == employeeId);

        //        if (result != null)
        //        {
        //            return result;
        //        }
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            try
            {
                var result = await _dbContext.Employees.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public async Task<Employee> UpdateEmployeeAsync(Employee employee)
        //{
        //    try
        //    {
        //        var empl = await GetEmployeeByIdAsync(employee.EmployeeId);
        //        //empl.UpdatedOn = DateTime.Now;
        //        empl.FirstName = employee.FirstName;
        //        empl.LastName = employee.LastName;
        //        empl.Email = employee.Email;
        //        empl.Phone = employee.Phone;
        //        empl.CurrentResidence = employee.CurrentResidence;
        //        empl.DateOfBirth = employee.DateOfBirth;
        //        empl.Gender = employee.Gender;

        //        await _dbContext.SaveChangesAsync();

        //        return empl;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
    }
}
