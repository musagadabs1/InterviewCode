using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InterviewQuestion.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class YesNoQuestionsController : ControllerBase
    {
        IYesNoQuestionRepository _yesNoRepository;
        public YesNoQuestionsController(IYesNoQuestionRepository paragraphRepository)
        {
            _yesNoRepository = paragraphRepository;
        }
        // GET: api/<ParagraphQuestionsController>
        // GET: api/<EmployeesController>
        [HttpGet]
        public async Task<IActionResult> GetYesNoQuestions()
        {
            var appPrograms = await _yesNoRepository.GetYesNoQuestionsAsync();
            return Ok(appPrograms);
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetYesNoQuestionById(int id)
        {
            try
            {
                var appPrograms = await _yesNoRepository.GetYesNoQuestionByIdAsync(id);
                return Ok(appPrograms);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public async Task<IActionResult> CreateYesNoQuestion([FromBody] YesNoQuestion model)
        {
            try
            {
                var appProgram = await _yesNoRepository.AddYesNoQuestionAsync(model);

                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<EmployeesController>/5
        [HttpPost]
        public async Task<IActionResult> UpdateYesNoQuestion([FromBody] YesNoQuestion model)
        {
            try
            {
                var appProgram = await _yesNoRepository.UpdateYesNoQuestionAsync(model);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteYesNoQuestion(int id)
        {
            try
            {
                var appProgram = await _yesNoRepository.DeleteYesNoQuestionAsync(id);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
