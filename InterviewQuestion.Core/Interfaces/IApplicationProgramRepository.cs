using InterviewQuestion.Core.DTOs;
using InterviewQuestion.Core.Models;
using Microsoft.Azure.Cosmos;

namespace InterviewQuestion.Core.Interfaces
{
    public interface IApplicationProgramRepository
    {
        Task<ItemResponse<AppProgram>> AddApplicationProgramAsync(ApplicationProgramDto model);
        Task<ApplicationProgram> UpdateApplicationProgramAsync(ApplicationProgramDto model);
        Task<ItemResponse<AppProgram>> UpdateApplicationProgramCosmosAsync(ApplicationProgramDto model);
        Task<ApplicationProgram> DeleteApplicationProgramAsync(int id);
        Task<ApplicationProgram> DeleteApplicationProgramAsync(string id, string partitionKey);
        Task<ApplicationProgram> GetApplicationProgramByIdAsync(int id);
        Task<AppProgram> GetApplicationProgramByIdAsync(string id, string partitionKey);
        Task<List<AppProgram>> GetApplicationProgramsAsync();
    }
}
