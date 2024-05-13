using InterviewQuestion.Core.DTOs;
using InterviewQuestion.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InterviewQuestion.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class ApplicationProgramsController : ControllerBase
    {

        IApplicationProgramRepository _applicationProgramRepository;
        public ApplicationProgramsController(IApplicationProgramRepository applicationProgramRepository)
        {
            _applicationProgramRepository = applicationProgramRepository;
        }
        // GET: ApplicationProgramsController
        [HttpGet]
        public async Task<IActionResult> GetApplicationPrograms()
        {
            var appPrograms = await _applicationProgramRepository.GetApplicationProgramsAsync();
            return Ok(appPrograms);
        }

        [HttpGet("{appProgramId}")]
        public async Task<IActionResult> GetApplicationProgramById(AppDeleteDto model)
        {
            var appPrograms = await _applicationProgramRepository.GetApplicationProgramByIdAsync(model.Id, model.Title);
            return Ok(appPrograms);
        }

        // POST: ApplicationProgramsController/Create
        [HttpPost]
        public async Task<IActionResult> CreateApplicationProgram([FromBody] ApplicationProgramDto model)
        {
            try
            {

                //var container = ContainerClient();


                var appProgram = await _applicationProgramRepository.AddApplicationProgramAsync(model);

                return Ok(appProgram);
            }
            catch
            {
                return Ok();
            }
        }

        // POST: ApplicationProgramsController/Edit/5
        [HttpPost]
        public async Task<IActionResult> UpdateApplicationProgram([FromBody] ApplicationProgramDto model)
        {
            try
            {
                var appProgram = await _applicationProgramRepository.UpdateApplicationProgramAsync(model);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: ApplicationProgramsController/Delete/5
        [HttpPost]
        public async Task<IActionResult> DeleteApplicationProgram(AppDeleteDto model)
        {
            try
            {
                var appProgram = await _applicationProgramRepository.DeleteApplicationProgramAsync(model.Id, model.Title);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
