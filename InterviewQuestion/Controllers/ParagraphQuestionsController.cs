using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InterviewQuestion.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class ParagraphQuestionsController : ControllerBase
    {
        IParagraphQuestionRepository _paragraphRepository;
        public ParagraphQuestionsController(IParagraphQuestionRepository paragraphRepository)
        {
            _paragraphRepository = paragraphRepository;
        }
        // GET: api/<ParagraphQuestionsController>
        // GET: api/<EmployeesController>
        [HttpGet]
        public async Task<IActionResult> GetParagraphQuestions()
        {
            var appPrograms = await _paragraphRepository.GetParagraphQuestionsAsync();
            return Ok(appPrograms);
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetParagraphQuestionById(int id)
        {
            try
            {
                var appPrograms = await _paragraphRepository.GetParagraphQuestionByIdAsync(id);
                return Ok(appPrograms);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public async Task<IActionResult> CreateParagraphQuestion([FromBody] ParagraphQuestion model)
        {
            try
            {
                var appProgram = await _paragraphRepository.AddParagraphQuestionAsync(model);

                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<EmployeesController>/5
        [HttpPost]
        public async Task<IActionResult> UpdateParagraphQuestion([FromBody] ParagraphQuestion model)
        {
            try
            {
                var appProgram = await _paragraphRepository.UpdateParagraphQuestionAsync(model);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParagraphQuestion(int id)
        {
            try
            {
                var appProgram = await _paragraphRepository.DeleteParagraphQuestionAsync(id);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
