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
        public async Task<IActionResult> GetApplicationProgramById(int appProgramId)
        {
            var appPrograms = await _applicationProgramRepository.GetApplicationProgramByIdAsync(appProgramId);
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
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicationProgram(int id)
        {
            try
            {
                var appProgram = await _applicationProgramRepository.DeleteApplicationProgramAsync(id);
                return Ok(appProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
