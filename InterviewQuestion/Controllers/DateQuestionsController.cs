using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterviewQuestion.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class DateQuestionsController : ControllerBase
    {
        IDateQuestionRepository _dateQuestionRepository;
        public DateQuestionsController(IDateQuestionRepository dateRepository)
        {
            _dateQuestionRepository = dateRepository;
        }
        // GET: api/<DateQuestionsController>
        [HttpGet]
        public async Task<IActionResult> GetDateQuestions()
        {
            try
            {
                var appPrograms = await _dateQuestionRepository.GetDateQuestionsAsync();
                return Ok(appPrograms);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // GET api/<DateQuestionsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDateQuestionById(int id)
        {
            try
            {
                var appPrograms = await _dateQuestionRepository.GetDateQuestionByIdAsync(id);
                return Ok(appPrograms);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // POST api/<DateQuestionsController>
        [HttpPost]
        public async Task<IActionResult> CreateDateQuestion([FromBody] DateQuestion model)
        {
            try
            {
                var appProgram = await _dateQuestionRepository.AddDateQuestionAsync(model);

                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<DateQuestionsController>/5
        [HttpPost]
        public async Task<IActionResult> UpdateDateQuestion([FromBody] DateQuestion model)
        {
            try
            {
                var appProgram = await _dateQuestionRepository.UpdateDateQuestionAsync(model);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDateQuestion(int id)
        {
            try
            {
                var appProgram = await _dateQuestionRepository.DeleteDateQuestionAsync(id);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
