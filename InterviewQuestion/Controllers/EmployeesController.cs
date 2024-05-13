using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using Microsoft.AspNetCore.Mvc;


namespace InterviewQuestion.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        IEmployeeReposiory _employeeRepository;
        public EmployeesController(IEmployeeReposiory employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // GET: api/<EmployeesController>
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var appPrograms = await _employeeRepository.GetEmployeesAsync();
            return Ok(appPrograms);
        }

        // GET api/<EmployeesController>/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetEmployeeById(Guid id)
        //{
        //    try
        //    {
        //        var appPrograms = await _employeeRepository.GetEmployeeByIdAsync(id);
        //        return Ok(appPrograms);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        // POST api/<EmployeesController>
        [HttpPost]
        public async Task<IActionResult> CreateEmpployee([FromBody] Employee model)
        {
            try
            {
                var appProgram = await _employeeRepository.AddEmployeeAsync(model);

                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<EmployeesController>/5
        //[HttpPost]
        //public async Task<IActionResult> UpdateEmployee([FromBody] Employee model)
        //{
        //    try
        //    {
        //        var appProgram = await _employeeRepository.UpdateEmployeeAsync(model);
        //        return Ok(appProgram);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        // DELETE api/<EmployeesController>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteEmployee(Guid id)
        //{
        //    try
        //    {
        //        var appProgram = await _employeeRepository.DeleteEmployeeAsync(id);
        //        return Ok(appProgram);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
