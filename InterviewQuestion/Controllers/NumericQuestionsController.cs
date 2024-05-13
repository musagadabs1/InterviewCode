using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InterviewQuestion.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class NumericQuestionsController : ControllerBase
    {
        INumericQuestionRepository _numericRepository;
        public NumericQuestionsController(INumericQuestionRepository paragraphRepository)
        {
            _numericRepository = paragraphRepository;
        }
        // GET: api/<ParagraphQuestionsController>
        // GET: api/<EmployeesController>
        [HttpGet]
        public async Task<IActionResult> GetNumericQuestions()
        {
            var appPrograms = await _numericRepository.GetNumericQuestionsAsync();
            return Ok(appPrograms);
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNumericQuesionById(int id)
        {
            try
            {
                var appPrograms = await _numericRepository.GetNumericQuestionByIdAsync(id);
                return Ok(appPrograms);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public async Task<IActionResult> CreateNumericQuestion([FromBody] NumericQuestion model)
        {
            try
            {
                var appProgram = await _numericRepository.AddNumericQuestionAsync(model);

                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<EmployeesController>/5
        [HttpPost]
        public async Task<IActionResult> UpdateNumericQuestion([FromBody] NumericQuestion model)
        {
            try
            {
                var appProgram = await _numericRepository.UpdateNumericQuestionAsync(model);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNumericQuestion(int id)
        {
            try
            {
                var appProgram = await _numericRepository.DeleteNumericQuestionAsync(id);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
