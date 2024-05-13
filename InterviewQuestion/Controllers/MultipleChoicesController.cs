using InterviewQuestion.Core.DTOs;
using InterviewQuestion.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InterviewQuestion.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class MultipleChoicesController : ControllerBase
    {
        IMultipleChoiceRepository _multipleRepository;
        public MultipleChoicesController(IMultipleChoiceRepository paragraphRepository)
        {
            _multipleRepository = paragraphRepository;
        }
        // GET: api/<ParagraphQuestionsController>
        // GET: api/<EmployeesController>
        [HttpGet]
        public async Task<IActionResult> GetMultipleChoices()
        {
            var appPrograms = await _multipleRepository.GetMultipleChoicesAsync();
            return Ok(appPrograms);
        }

        // GET api/<EmployeesController>/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetMultipleChoiceById(int id)
        //{
        //    try
        //    {
        //        var appPrograms = await _multipleRepository.GetMultipleChoiceByIdAsync(id);
        //        return Ok(appPrograms);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        // POST api/<EmployeesController>
        [HttpPost]
        public async Task<IActionResult> CreateMultipleChoice([FromBody] MultipleChoiceDto model)
        {
            try
            {
                var appProgram = await _multipleRepository.AddMultipleChoiceAsync(model);

                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<EmployeesController>/5
        //[HttpPost]
        //public async Task<IActionResult> UpdateMultipleChoice([FromBody] MultipleChoiceDto model)
        //{
        //    try
        //    {
        //        var appProgram = await _multipleRepository.UpdateMultipleChoiceAsync(model);
        //        return Ok(appProgram);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        // DELETE api/<EmployeesController>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteMultipleChoice(int id)
        //{
        //    try
        //    {
        //        var appProgram = await _multipleRepository.DeleteMultipleChoiceAsync(id);
        //        return Ok(appProgram);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
