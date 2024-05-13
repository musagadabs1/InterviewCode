using InterviewQuestion.Core.DTOs;
using InterviewQuestion.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InterviewQuestion.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class MultipleChoiceTemplatesController : ControllerBase
    {
        IMultipleChoiceTemplateRepository _multipleRepository;
        public MultipleChoiceTemplatesController(IMultipleChoiceTemplateRepository paragraphRepository)
        {
            _multipleRepository = paragraphRepository;
        }
        // GET: api/<ParagraphQuestionsController>
        // GET: api/<EmployeesController>
        [HttpGet]
        public async Task<IActionResult> GetMultipleChoiceTemplates()
        {
            var appPrograms = await _multipleRepository.GetMultipleChoiceTemplatesAsync();
            return Ok(appPrograms);
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMultipleChoiceTemplateById(int id)
        {
            try
            {
                var appPrograms = await _multipleRepository.GetMultipleChoiceTemplateByIdAsync(id);
                return Ok(appPrograms);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public async Task<IActionResult> CreateMultipleChoiceTemplate([FromBody] MultipleChoiceTemplateDto model)
        {
            try
            {
                var appProgram = await _multipleRepository.AddMultipleChoiceTemplateAsync(model);

                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<EmployeesController>/5
        [HttpPost]
        public async Task<IActionResult> UpdateMultipleChoiceTemplate([FromBody] MultipleChoiceTemplateDto model)
        {
            try
            {
                var appProgram = await _multipleRepository.UpdateMultipleChoiceTemplateAsync(model);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMultipleChoiceTemplate(int id)
        {
            try
            {
                var appProgram = await _multipleRepository.DeleteMultipleChoiceTemplateAsync(id);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
