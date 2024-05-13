using InterviewQuestion.Core.DTOs;
using InterviewQuestion.Core.Models;
using Microsoft.Azure.Cosmos;

namespace InterviewQuestion.Core.Interfaces
{
    public interface IApplicationProgramRepository
    {
        Task<ItemResponse<AppProgram>> AddApplicationProgramAsync(ApplicationProgramDto model);
        Task<ApplicationProgram> UpdateApplicationProgramAsync(ApplicationProgramDto model);
        Task<ItemResponse<AppProgram>> UpdateApplicationProgramAsync(ApplicationProgramDto model, string partitionKey);
        Task<ApplicationProgram> DeleteApplicationProgramAsync(int id);
        Task<ApplicationProgram> DeleteApplicationProgramAsync(int id, string partitionKey);
        Task<ApplicationProgram> GetApplicationProgramByIdAsync(int id);
        Task<ApplicationProgram> GetApplicationProgramByIdAsync(int id, string partitionKey);
        Task<List<ApplicationProgram>> GetApplicationProgramsAsync();
    }
}
