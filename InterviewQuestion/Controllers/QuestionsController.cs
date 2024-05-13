using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterviewQuestion.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        IQuestionRepository _questionRepository;
        public QuestionsController(IQuestionRepository dateRepository)
        {
            _questionRepository = dateRepository;
        }
        // GET: api/<DateQuestionsController>
        [HttpPost]
        public async Task<IActionResult> CreateParagraphQuestions(ParagraphQuestion model)
        {
            try
            {
                var appPrograms = await _questionRepository.AddParagraphQuestionAsync(model);
                return Ok(appPrograms);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // GET api/<DateQuestionsController>/5
        [HttpPost]
        public async Task<IActionResult> CreateYesNoQuestion(YesNoQuestion model)
        {
            try
            {
                var appPrograms = await _questionRepository.AddYesNoQuestionAsync(model);
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
                var appProgram = await _questionRepository.AddDateQuestionAsync(model);

                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<DateQuestionsController>/5
        [HttpPost]
        public async Task<IActionResult> MultipleChoiceQuestion([FromBody] MultipleChoiceTemplate model)
        {
            try
            {
                var appProgram = await _questionRepository.AddMultipleChoiceQuestionAsync(model);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateNumericQuestion(NumericQuestion model)
        {
            try
            {
                var appProgram = await _questionRepository.AddNumericQuestionAsync(model);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
